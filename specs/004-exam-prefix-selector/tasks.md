# Tasks: Exam Prefix Selector

**Branch**: `004-exam-prefix-selector`  
**Input**: [spec.md](spec.md) · [plan.md](plan.md) · [research.md](research.md) · [data-model.md](data-model.md) · [quickstart.md](quickstart.md)  
**Prerequisites**: plan.md ✅ · spec.md ✅ · research.md ✅ · data-model.md ✅

## Format: `[ID] [P?] [Story?] Description`

- **[P]**: Can run in parallel (different files, no unresolved dependencies)
- **[Story]**: Which user story this task belongs to ([US1], [US2])

---

## Phase 1: Setup — Test Infrastructure

**Purpose**: Bootstrap the xUnit test project (Constitution Principle III — NON-NEGOTIABLE). No user story work can begin until this phase is complete.

**⚠️ CRITICAL**: Tests MUST be committed before any implementation code in Phases 2–3.

- [X] T001 Create `FlashCards.Tests/FlashCards.Tests.csproj` at the repository root, targeting net9.0 with xUnit and Microsoft.NET.Test.Sdk references; add project to `FlashCards.sln` via `dotnet sln add FlashCards.Tests/FlashCards.Tests.csproj`
- [X] T002 Add `[assembly: InternalsVisibleTo("FlashCards.Tests")]` to `FlashCards/Web/Properties/AssemblyInfo.cs` (create the file if it does not exist) so unit tests can access `internal` helpers

**Checkpoint**: `dotnet test` runs on the empty test project without errors

---

## Phase 2: Foundational — Helper Class + Unit Tests

**Purpose**: Extract pure prefix functions to a testable helper and write the two unit tests before any UI change. Blocks both user story phases.

**⚠️ CRITICAL**: Tests must be written and confirmed to FAIL before Phase 3 implementation begins.

- [X] T003 Create `FlashCards/Web/Helpers/ExamPrefixHelper.cs` with two `internal static` methods: `GetPrefixes(IEnumerable<string> examOptions)` and `GetFilteredOptions(IEnumerable<string> examOptions, string prefix)` — stubs only (return `Enumerable.Empty<string>()`) so tests fail intentionally
- [X] T004 [P] Create `FlashCards.Tests/ExamPrefixHelperTests.cs` with test `ExamPrefixes_ReturnsDistinctPrefixesInOrder`: given `["dva-1","dva-2","dea-01","aif-01","dd-fundamentals-1"]`, asserts result equals `["dva","dea","aif","dd"]`
- [X] T005 Add test `FilteredExamOptions_FiltersCorrectlyByPrefix` to existing `FlashCards.Tests/ExamPrefixHelperTests.cs`: given `["dva-1","dva-2","dea-01","aif-01"]` and prefix `"dva"`, asserts result equals `["dva-1","dva-2"]`

**Checkpoint**: `dotnet test` runs; T004 and T005 tests are RED (stubs return empty)

---

## Phase 3: User Story 1 — Filter Exams by Prefix (Priority: P1) 🎯 MVP

**Goal**: Add prefix selector dropdown to the home page that filters the exam selector to show only matching exams. Changing prefix resets only the exam selector — scores and session state are preserved.

**Independent Test**: Select "DVA" in the prefix selector → exam selector shows only dva-1 … dva-8, no other exams. Change prefix to "DEA" → exam selector resets to placeholder and shows only dea-01 … dea-22.

### Implementation

- [X] T006 [US1] Implement `ExamPrefixHelper.GetPrefixes` in `FlashCards/Web/Helpers/ExamPrefixHelper.cs`: use `examOptions.Select(e => e.Split('-')[0]).Distinct()` to return unique prefixes in first-occurrence order; confirm T004 turns GREEN
- [X] T007 [US1] Implement `ExamPrefixHelper.GetFilteredOptions` in `FlashCards/Web/Helpers/ExamPrefixHelper.cs`: use `examOptions.Where(e => e.Split('-')[0] == prefix)` for non-empty prefix, empty enumerable otherwise; confirm T005 turns GREEN
- [X] T008 [US1] Add `string selectedPrefix { get; set; } = string.Empty;` field to the `@code` block of `FlashCards/Web/Pages/Home.razor`
- [X] T009 [US1] Add `List<string> ExamPrefixes` and `List<string> FilteredExamOptions` computed properties to `@code` in `FlashCards/Web/Pages/Home.razor`, delegating to `ExamPrefixHelper`
- [X] T010 [US1] Add `void OnPrefixChanged(ChangeEventArgs e)` handler to `@code` in `FlashCards/Web/Pages/Home.razor`: sets `selectedPrefix`, clears `examName = string.Empty`, does NOT touch Questions/CurrentIndex/CorrectCount/WrongCount/localStorage, calls `StateHasChanged()`
- [X] T011 [US1] Add the prefix selector `<div class="mb md-navigation-panel">` block with `<select id="prefixSelect" @onchange="OnPrefixChanged">` to the template in `FlashCards/Web/Pages/Home.razor` immediately before the existing exam selector block; options rendered with `@prefix.ToUpper()` labels
- [X] T012 [US1] Update the existing exam selector `@foreach` in `FlashCards/Web/Pages/Home.razor` to iterate over `FilteredExamOptions` instead of `examOptions`

**Checkpoint**: Full User Story 1 is independently testable. Prefix selector shows all 7 prefixes (DVA, DEA, AIF, SAA, AWS, DD, REPO) in uppercase. Exam selector shows only matching exams. Load button remains disabled until both prefix and exam are selected.

---

## Phase 4: User Story 2 — Prefixes Derived Automatically (Priority: P2)

**Goal**: Verify that adding a new exam entry to `examOptions` automatically produces its prefix in the selector, with zero additional code changes.

**Independent Test**: Add `"soa-01"` to the `examOptions` list in `Home.razor` → reload page → "SOA" appears in the prefix selector without any other file change.

### Implementation

- [X] T013 [US2] Verify in `FlashCards/Web/Pages/Home.razor` that `examOptions` is the single source of truth — confirm no hard-coded prefix list exists anywhere in the file; add a code comment above `ExamPrefixes` property documenting the derivation rule: _"Prefixes are always derived from examOptions; no separate list must be maintained."_

**Checkpoint**: No hard-coded prefix list exists. US2 is independently verifiable by the inspection above and the passing unit test T004.

---

## Phase 5: Polish & Cross-Cutting Concerns

**Purpose**: Accessibility, label, and regression verification.

- [X] T014 [P] Add `for="prefixSelect"` on the prefix selector `<label>` in `FlashCards/Web/Pages/Home.razor` and verify the existing exam selector label continues to have `for="examSelect"` (keyboard/screen-reader accessibility — constitution Technical Constraints)
- [X] T015 Run `dotnet build FlashCards/Web/Web.csproj` and `dotnet test` and confirm zero errors and both unit tests GREEN; also verify that the Load button is disabled when a prefix is selected but no exam is chosen (FR-006 acceptance check)
- [X] T016 [P] Manual smoke test per `quickstart.md`: verify the two-step selection flow end to end in the browser (prefix → exam → Load → navigate questions → change prefix → session preserved)

---

## Dependencies & Execution Order

### Phase Dependencies

```
Phase 1 (Setup)
  └─▶ Phase 2 (Foundational — helper + failing tests)
        └─▶ Phase 3 (US1 — implement helper, wire UI) [MVP delivery]
        └─▶ Phase 4 (US2 — derived-automatically verification)
              └─▶ Phase 5 (Polish)
```

### User Story Dependencies

- **US1 (P1)**: Depends on Phase 2 (helper stubs + tests). No dependency on US2. Independently testable.
- **US2 (P2)**: Depends on US1 (ExamPrefixes property must exist). Verification-only: no new code beyond a comment and an inspection.

### Parallelism within phases

| Parallel group | Tasks |
|---|---|
| Phase 2 — tests | T004, T005 (same file, same session) |
| Phase 5 — polish | T014 (accessibility fix) and T016 (smoke test) can overlap |

### Within-story order (Phase 3)

```
T006, T007 (implement helpers) → tests go GREEN
  └─▶ T008 (new field)
        └─▶ T009 (computed properties)
              └─▶ T010 (handler)
                    └─▶ T011 (prefix dropdown in template)
                          └─▶ T012 (update exam foreach)
```

---

## Implementation Strategy

**MVP = Phase 1 + Phase 2 + Phase 3** (T001 – T012).

This delivers the full user-visible feature: prefix selector with uppercase labels, filtered exam selector, preserved session on prefix change, and unit test coverage. US2 (Phase 4) is a low-effort verification step with no net-new behavior — it confirms the automatic derivation contract that US1 already implements. Polish (Phase 5) adds accessibility labels and a final build/test pass.

**Total tasks**: 16  
**Tasks for US1**: 7 (T006–T012)  
**Tasks for US2**: 1 (T013)  
**Test tasks**: 2 (T004, T005) — written before implementation per Principle III  
**Parallel opportunities**: T004+T005 (Phase 2), T006+T007 (Phase 3 start), T014+T016 (Phase 5)
