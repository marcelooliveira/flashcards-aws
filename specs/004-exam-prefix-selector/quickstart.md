# Quickstart: Exam Prefix Selector

**Feature**: 004-exam-prefix-selector | **Date**: 2026-03-29

---

## What is being built

A two-step exam selector on the home page:
1. **Prefix selector** — first dropdown listing unique exam groups (DVA, DEA, AIF, SAA, AWS, DD, REPO) derived automatically from `examOptions`.
2. **Exam selector** — existing dropdown, now shown only after a prefix is chosen, filtered to that prefix's exams.

Changing the prefix resets only the exam dropdown selection. It does not clear scores, navigation state, or saved answers.

---

## Files changed

| File | Change type | What changes |
|---|---|---|
| `FlashCards/Web/Pages/Home.razor` | Modified | Add prefix dropdown; add `selectedPrefix` field; add `ExamPrefixes` and `FilteredExamOptions` computed properties; add `OnPrefixChanged` handler; update `@bind` on exam selector to use filtered list |
| `FlashCards.Tests/` *(new project)* | Created | xUnit test project with two unit tests for prefix extraction and filtering logic |

---

## Step-by-step implementation

### Step 1 — Add state field to `Home.razor @code`

```csharp
string selectedPrefix { get; set; } = string.Empty;
```

### Step 2 — Add computed properties to `Home.razor @code`

```csharp
List<string> ExamPrefixes =>
    examOptions
        .Select(e => e.Split('-')[0])
        .Distinct()
        .ToList();

List<string> FilteredExamOptions =>
    string.IsNullOrEmpty(selectedPrefix)
        ? new List<string>()
        : examOptions.Where(e => e.Split('-')[0] == selectedPrefix).ToList();
```

### Step 3 — Add prefix-change handler to `Home.razor @code`

```csharp
void OnPrefixChanged(ChangeEventArgs e)
{
    selectedPrefix = e.Value?.ToString() ?? string.Empty;
    examName = string.Empty;
    // Do NOT reset Questions, CurrentIndex, CorrectCount, WrongCount, or localStorage
    StateHasChanged();
}
```

### Step 4 — Add prefix dropdown to the template (before the existing exam selector)

```razor
<div class="mb md-navigation-panel">
    <label for="prefixSelect" class="md-label"><b>Selecione o prefixo:</b></label>
    <div class="md-select-wrapper">
        <select id="prefixSelect" @onchange="OnPrefixChanged" class="md-select">
            <option value="">-- Escolha --</option>
            @foreach (var prefix in ExamPrefixes)
            {
                <option value="@prefix">@prefix.ToUpper()</option>
            }
        </select>
        <span class="md-highlight"></span>
    </div>
</div>
```

### Step 5 — Update the exam selector dropdown to use `FilteredExamOptions`

Replace:
```razor
@foreach (var exam in examOptions)
```
With:
```razor
@foreach (var exam in FilteredExamOptions)
```

### Step 6 — Update the Load button disabled condition

The existing condition `disabled="@string.IsNullOrEmpty(examName)"` already handles this correctly because `examName` is cleared when prefix changes. No change needed.

---

## Test project setup

Create `FlashCards.Tests/FlashCards.Tests.csproj` at the repository root as an xUnit test project targeting net9.0. Extract the two pure functions as `internal static` helpers in a `ExamPrefixHelper` static class inside the `Web` project (accessible via `InternalsVisibleTo`), then write two unit tests:

```csharp
[Fact]
public void ExamPrefixes_ReturnsDistinctPrefixesInOrder()
{
    var options = new[] { "dva-1", "dva-2", "dea-01", "aif-01", "dd-fundamentals-1" };
    var result = ExamPrefixHelper.GetPrefixes(options);
    Assert.Equal(new[] { "dva", "dea", "aif", "dd" }, result);
}

[Fact]
public void FilteredExamOptions_FiltersCorrectlyByPrefix()
{
    var options = new[] { "dva-1", "dva-2", "dea-01", "aif-01" };
    var result = ExamPrefixHelper.GetFilteredOptions(options, "dva");
    Assert.Equal(new[] { "dva-1", "dva-2" }, result);
}
```
