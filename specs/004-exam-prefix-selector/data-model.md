# Data Model: Exam Prefix Selector

**Phase**: 1 | **Date**: 2026-03-29  
**Feature**: 004-exam-prefix-selector

---

## New State Fields (in `Home.razor @code`)

No new model classes or database entities are required. The feature introduces two new pieces of state in the existing `Home.razor` component:

| Field | Type | Default | Description |
|---|---|---|---|
| `selectedPrefix` | `string` | `string.Empty` | The prefix currently selected in the first dropdown. Empty string means no prefix selected. |

The second selector continues to use the existing `examName` field, now constrained to `FilteredExamOptions`.

---

## Derived Computed Properties (in `Home.razor @code`)

| Property | Derivation Rule | Notes |
|---|---|---|
| `ExamPrefixes` | `examOptions.Select(e => e.Split('-')[0]).Distinct().ToList()` | Preserves first-occurrence order. Uppercase used only for display in the template. |
| `FilteredExamOptions` | Returns `examOptions.Where(e => e.Split('-')[0] == selectedPrefix)` when prefix is set; returns empty list otherwise | Drives the second dropdown's `@foreach` |

---

## Existing Fields (unchanged)

| Field | Type | Notes |
|---|---|---|
| `examOptions` | `List<string>` | Source of truth. Prefix list and filtered list are always derived from it. |
| `examName` | `string` | Selected exam. Cleared to `string.Empty` when prefix changes. |
| `Questions` | `List<Question>` | Not touched by prefix change. |
| `CurrentIndex` | `int` | Not touched by prefix change. |
| `CorrectCount` | `int` | Not touched by prefix change. |
| `WrongCount` | `int` | Not touched by prefix change. |

---

## State Transitions

```
[No prefix selected]
  selectedPrefix = ""
  examName = ""
  FilteredExamOptions = []
  Load button: disabled

  ↓ user selects a prefix

[Prefix selected, no exam]
  selectedPrefix = "dva"
  examName = ""
  FilteredExamOptions = ["dva-1", "dva-2", ...]
  Load button: disabled

  ↓ user selects an exam

[Prefix + exam selected]
  selectedPrefix = "dva"
  examName = "dva-2"
  FilteredExamOptions = ["dva-1", "dva-2", ...]
  Load button: ENABLED

  ↓ user clicks Load

[Exam loaded]
  Questions populated, CurrentIndex/CorrectCount/WrongCount active

  ↓ user changes prefix selector

[Prefix changed, previous session preserved]
  selectedPrefix = "dea"
  examName = ""           ← reset to placeholder
  FilteredExamOptions = ["dea-01", "dea-02", ...]
  Questions, CurrentIndex, CorrectCount, WrongCount: UNCHANGED
  Load button: disabled
```

---

## No New Contracts

The feature is a purely internal UI change within a single Blazor WASM application. No public APIs, CLI schemas, or external interfaces are exposed. The `/contracts/` folder is not required for this feature.

---

## Prefix Extraction Rule

A prefix is defined as all characters before the first hyphen (`-`) in an exam name.

| Exam name | Prefix extracted | Display label |
|---|---|---|
| `dva-1` | `dva` | DVA |
| `dea-01` | `dea` | DEA |
| `aif-01` | `aif` | AIF |
| `saa-01` | `saa` | SAA |
| `aws-01` | `aws` | AWS |
| `dd-fundamentals-1` | `dd` | DD |
| `repo-01` | `repo` | REPO |
