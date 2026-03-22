<!--
Sync Impact Report

- Version change: template (unset) -> 1.0.0
- Modified principles:
	- [PRINCIPLE_1_NAME] -> I. User-Focused Simplicity
	- [PRINCIPLE_2_NAME] -> II. Component Responsibility (Blazor-first)
	- [PRINCIPLE_3_NAME] -> III. Test-First (NON-NEGOTIABLE)
	- [PRINCIPLE_4_NAME] -> IV. Content-as-Code
	- [PRINCIPLE_5_NAME] -> V. Observability, Versioning & Simplicity
- Added sections: Technical Constraints & Standards; Development Workflow & Quality Gates
- Removed sections: none
- Templates reviewed:
	- .specify/templates/plan-template.md ✅ aligned
	- .specify/templates/spec-template.md ✅ aligned
	- .specify/templates/tasks-template.md ✅ aligned
	- .specify/templates/agent-file-template.md ✅ no changes required
- Follow-up TODOs:
	- RATIFICATION_DATE intentionally left as TODO since original adoption date is unknown
	- Verify CI checks include the constitution checklist (manual review)
-->

# FlashCards (flashcards-aws) Constitution

## Core Principles

### I. User-Focused Simplicity
The project MUST prioritize a simple, fast question-and-answer user experience. Features are added only when they deliver measurable user value; feature creep is disallowed. UI and content changes that increase complexity MUST include a short justification and measurable acceptance criteria.

### II. Component Responsibility (Blazor-first)
All UI logic MUST be implemented as small, single-responsibility Blazor components that are independently testable. Components MUST avoid hidden global state; data flows should be explicit via parameters and event callbacks. Reuse is encouraged through composition, not by creating monolithic components.

### III. Test-First (NON-NEGOTIABLE)
Tests MUST be written for new behavior before implementation. Unit tests for component logic and model behavior are REQUIRED; integration or end-to-end tests are REQUIRED for cross-cutting flows (e.g., loading exam content, navigation, answer scoring). Tests are the canonical specification for intended behavior.

### IV. Content-as-Code
Content (exam questions, practice exams, guides) is treated as versioned, reviewable code (YAML/Markdown in `wwwroot/Exams` and related folders). Changes to content MUST follow the same PR + review process as code; content must include provenance and, where applicable, licensing notes.

### V. Observability, Versioning & Simplicity
The project MUST emit structured logs for server-side operations and replayable telemetry for key user journeys when available. Adopt semantic versioning for releases: MAJOR for incompatible changes, MINOR for added backwards-compatible features, PATCH for fixes and wording/content clarifications. Default to the simplest implementation that satisfies requirements.

## Technical Constraints & Standards

- Language & runtime: .NET 9 (net9.0) and Blazor as used in the `Web` project.
- Project structure: preserve the existing `FlashCards/Web` layout; follow component and model folders under `Web/Components` and `Web/Model`.
- Content formats: exam content MUST be stored as YAML/Markdown under `wwwroot/Exams` and authored as Content-as-Code.
- Security: NO secrets, keys, or credentials in the repository. Use environment configuration and secret stores for runtime secrets.
- Accessibility: UI components MUST aim for basic accessibility (semantic HTML, labels for inputs, keyboard navigation for cards).

## Development Workflow & Quality Gates

- Pull Requests: All changes MUST be made via PRs targeting the main integration branch. Each PR MUST include a short description of the change, linked issues or specs, and the related tests.
- Reviews: At least one approving review from a project maintainer is REQUIRED for non-trivial changes; substantial changes (new features, content schema changes) require two approvers.
- CI: PRs MUST run automated tests (unit + any available integration tests) and lint/format checks before merging.
- Constitution Check: Feature plans (per `.specify/templates/plan-template.md`) MUST include a Constitution Check section; any gate violations MUST be justified in the plan and accepted by reviewers before implementation proceeds.
- Releases: Tag releases with semantic version numbers and include a changelog summarizing user-facing and content changes.

## Governance

- Amendments: Amendments to this constitution MUST be proposed via PR against `.specify/memory/constitution.md`. The PR MUST include a rationale, migration notes if needed, and examples of how to comply. A minor or patch amendment requires one approver; major redefinitions that change principles or remove existing guarantees require two approvers and a migration plan.
- Versioning policy:
	- MAJOR: Backwards-incompatible principle changes or removals.
	- MINOR: New principle or material expansion of guidance.
	- PATCH: Clarifications, wording, typos, or non-semantic refinements.
- Compliance review: Significant PRs (feature additions, content schema updates, production config changes) MUST include a short checklist verifying compliance with relevant principles.

**Version**: 1.0.0 | **Ratified**: TODO(RATIFICATION_DATE) | **Last Amended**: 2026-03-21

