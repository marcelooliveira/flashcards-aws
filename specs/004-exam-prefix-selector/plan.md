# Implementation Plan: Exam Prefix Selector

**Branch**: `004-exam-prefix-selector` | **Date**: 2026-03-29 | **Spec**: [spec.md](spec.md)  
**Input**: Feature specification from `/specs/004-exam-prefix-selector/spec.md`

## Summary

Add a first-level prefix selector (DVA, DEA, AIF, SAA, AWS, DD, REPO) before the existing exam selector on the home page. Prefixes are derived automatically from the existing `examOptions` list — no separate hard-coded list. Selecting a prefix filters the exam dropdown to show only matching exams. Changing the prefix resets only the exam dropdown to its placeholder; scores, navigation state, and localStorage saved answers are fully preserved. The change is contained entirely in `Home.razor` plus a new xUnit test project for the two pure helper functions.

## Technical Context

**Language/Version**: C# 13 / .NET 9 (net9.0)  
**Primary Dependencies**: Blazor WebAssembly, YamlDotNet (existing), JSRuntime for localStorage  
**Storage**: Browser localStorage (existing, for saved answers); in-memory `List<string>` for exam options  
**Testing**: xUnit — new `FlashCards.Tests` project to be created  
**Target Platform**: Browser (Blazor WASM static hosting)  
**Project Type**: Blazor WASM single-page application  
**Performance Goals**: N/A — client-side filtering of <60 items, O(n) LINQ with negligible cost  
**Constraints**: No server dependency; must work in static hosting (GitHub Pages / Azure Static Web Apps); no new NuGet packages required  
**Scale/Scope**: ~60 exam entries, 7 unique prefixes

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|---|---|---|
| I. User-Focused Simplicity | ✅ PASS | Reduces user friction — finding an exam group goes from scanning a 60-item flat list to 2 targeted clicks. No feature creep; only the selector UI changes. |
| II. Component Responsibility (Blazor-first) | ✅ PASS | Feature stays in `Home.razor`. No second call-site exists for a prefix selector today, so no new component is premature but would be justified by the constitution for future reuse. Revisit if a second page needs a selector. |
| III. Test-First (NON-NEGOTIABLE) | ⚠️ VIOLATION — JUSTIFIED | No test project exists in the repository. **Justification**: This feature introduces two pure helper functions. A new xUnit project (`FlashCards.Tests`) will be created as the first task, and the two unit tests will be written before the implementation code. This is the bootstrap case for test infrastructure. Accepted by plan; reviewers must verify tests are committed before implementation code. |
| IV. Content-as-Code | ✅ N/A | No content changes. `examOptions` list in code is not exam content. |
| V. Observability, Versioning & Simplicity | ✅ PASS | Simplest possible implementation — two computed properties and one event handler. No new abstractions, no new libraries. |

**Pre-Phase-0 gate**: PASS (with justified violation tracked above)  
**Post-Phase-1 re-check**: No constitution issues introduced by design. Violation III tracked and mitigated by test-project creation task.

## Project Structure

### Documentation (this feature)

```text
specs/004-exam-prefix-selector/
├── plan.md              ← this file
├── research.md          ← Phase 0 output
├── data-model.md        ← Phase 1 output
├── quickstart.md        ← Phase 1 output
└── tasks.md             ← Phase 2 output (/speckit.tasks — not yet created)
```

No `/contracts/` folder — this is a purely internal UI change with no external interface.

### Source Code

```text
FlashCards/
└── Web/
    ├── Pages/
    │   └── Home.razor                    ← modified: prefix selector dropdown + state fields + computed properties + handler
    └── Helpers/
        └── ExamPrefixHelper.cs           ← new: static helper with GetPrefixes() and GetFilteredOptions() — enables unit testing

FlashCards.Tests/                         ← new xUnit test project
├── FlashCards.Tests.csproj
└── ExamPrefixHelperTests.cs
```

**Structure Decision**: Single Blazor WASM project with a new sibling test project. The two pure functions are extracted to a small static helper class so they can be tested without Blazor rendering infrastructure.
