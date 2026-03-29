# Research: Exam Prefix Selector

**Phase**: 0 | **Date**: 2026-03-29  
**Feature**: 004-exam-prefix-selector

---

## 1. Where should prefix extraction logic live?

**Decision**: Inline computed property in the `@code` block of `Home.razor`.  
**Rationale**: The prefix list is derived from the existing `examOptions` list via a single LINQ expression. It carries no domain logic beyond splitting a string. Extracting it into a service or injectable would add indirection for zero testability benefit at this scope. A C# expression-bodied property keeps the rule co-located with the data it describes.  
**Alternatives considered**:  
- Dedicated `ExamService` class — rejected; overkill for a one-liner derived from an in-memory list.  
- Extension method in a utility file — rejected; not reused anywhere else.

```csharp
// Derived prefix list (unique, ordered as they first appear in examOptions)
List<string> ExamPrefixes =>
    examOptions
        .Select(e => e.Split('-')[0])
        .Distinct()
        .ToList();
```

---

## 2. How should filtered exam options be computed?

**Decision**: Inline computed property in `@code`, reactive to `selectedPrefix`.  
**Rationale**: Blazor's rendering model re-evaluates bound expressions on every `StateHasChanged`. A computed `IEnumerable<string>` property filtered by `selectedPrefix` will automatically reflect the current selection without any explicit event handler wiring beyond setting `selectedPrefix`.  
**Alternatives considered**:  
- Precomputed dictionary `Dictionary<string, List<string>>` built once — rejected; premature optimization; the list has <60 entries.

```csharp
List<string> FilteredExamOptions =>
    string.IsNullOrEmpty(selectedPrefix)
        ? new List<string>()
        : examOptions.Where(e => e.Split('-')[0] == selectedPrefix).ToList();
```

---

## 3. How should the prefix selector reset state?

**Decision**: On prefix change, set `examName = string.Empty` only. Do not touch `Questions`, `CurrentIndex`, `CorrectCount`, `WrongCount`, or localStorage.  
**Rationale**: Per FR-005 and FR-007 (confirmed in clarifications), changing the prefix must not reset session state. The exam selector resets visually because `examName` is cleared and `FilteredExamOptions` points to a new list; the Load button becomes disabled because `string.IsNullOrEmpty(examName)` is true. No further cleanup is needed.  
**Alternatives considered**:  
- Full session reset on prefix change — rejected per clarification Q2 answer.

```csharp
void OnPrefixChanged(string newPrefix)
{
    selectedPrefix = newPrefix;
    examName = string.Empty;  // Clears second selector selection
    // No reset of Questions, counters, or localStorage
    StateHasChanged();
}
```

---

## 4. How should prefix labels be displayed?

**Decision**: Display uppercase (`prefix.ToUpper()`) in the option label, while keeping the raw lowercase string as the `<option value>` for filtering.  
**Rationale**: Per clarification Q3. Uppercase matches official AWS/cloud exam naming conventions and improves scannability. The display and the internal filter key are decoupled.  

```razor
@foreach (var prefix in ExamPrefixes)
{
    <option value="@prefix">@prefix.ToUpper()</option>
}
```

---

## 5. Is a new Blazor component needed?

**Decision**: No. The change stays in `Home.razor`.  
**Rationale**: Constitution Principle II (Component Responsibility) calls for single-responsibility components, but it also says "reuse is encouraged through composition." The prefix selector + exam selector pair is not reused anywhere else in the codebase. Splitting them into a child component now would be premature and adds wiring overhead (parameter passing, EventCallback). The inline approach remains the simplest compliant implementation (Principle V).  
**Alternatives considered**:  
- `<ExamSelector>` child component — viable for future reuse, deferred until there is a second call-site.

---

## 6. Constitution: Test-First gate (NON-NEGOTIABLE)

**Finding**: No test project exists in the repository (`FlashCards.sln` lists only `FlashCards/Web`). The constitution requires unit tests for new behavior before implementation.  
**Decision**: A test project (`FlashCards.Tests`) should be created as part of this feature. Because the prefix extraction and filtering are pure functions (no UI rendering required), they can be unit-tested with xUnit + no bUnit dependency by extracting the two LINQ expressions into `static` helpers on the `Home` component or a minimal `ExamUtil` static class.  
**Scope**: Two unit tests are sufficient:  
1. `ExamPrefixes_ReturnsDistinctPrefixesInOrder` — verifies prefix extraction and deduplication.  
2. `FilteredExamOptions_FiltersCorrectlyByPrefix` — verifies that only exams matching the selected prefix are returned.

All NEEDS CLARIFICATION items resolved. No open unknowns remain.
