# Feature Specification: Exam Prefix Selector

**Feature Branch**: `004-exam-prefix-selector`  
**Created**: 2026-03-29  
**Status**: Draft  
**Input**: User description: "Atualmente, a aplicação tem uma home page com um único seletor de exames que é carregado a partir de uma lista fixa no código. Eu quero que, antes desse seletor, seja apresentado um seletor apenas com os prefixos dos exames (dva, dea, aif, etc.). O segundo seletor deve carregar o bloco de exames filtrado pelo primeiro seletor."

## Clarifications

### Session 2026-03-29

- Q: When no prefix is selected, should the exam selector show all exams (fallback) or remain empty (placeholder only)? → A: Empty — only placeholder shown until a prefix is selected.
- Q: When the user changes the prefix, should the active session state (scores, navigation index, loaded questions) be reset? → A: No — changing the prefix only filters the exam selector dropdown; scores, navigation index, loaded questions, and saved answers in storage are all preserved. Only clicking Load with a new exam selection triggers a session change.
- Q: Should prefix values be displayed as-is (lowercase) or formatted for readability? → A: Uppercase — display as DVA, DEA, AIF, SAA, AWS, DD, REPO, etc.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Filter Exams by Prefix (Priority: P1)

A user opens the home page and wants to find a specific exam group (e.g., all DVA exams). Instead of scrolling through a long flat list of all exams, they first select the exam prefix (e.g., "dva") in a new prefix selector. The second selector then narrows down automatically showing only the exams that belong to that prefix (e.g., dva-1, dva-2, dva-3, ...). The user selects the specific exam and loads it.

**Why this priority**: This is the core of the feature. Without prefix filtering, the second selector remains identical to today's behavior. Every other improvement depends on this working correctly.

**Independent Test**: Can be fully tested by selecting a prefix in the first dropdown and verifying that only the matching exams appear in the second dropdown, without needing any other change to the application.

**Acceptance Scenarios**:

1. **Given** the home page is loaded, **When** no prefix is selected, **Then** the exam selector shows only its placeholder ("-- Escolha --") with no exam options available.
2. **Given** the home page is loaded, **When** the user selects "dva" in the prefix selector, **Then** the exam selector shows only dva-1, dva-2, dva-3, ... and hides all other exam groups.
3. **Given** a prefix is selected and an exam is loaded, **When** the user changes the prefix selector to a different prefix, **Then** the exam selector dropdown resets to its placeholder (no exam selected), but scores, navigation index, loaded questions, and saved answers in storage are all preserved unchanged.

---

### User Story 2 - All Prefixes Are Derived Automatically (Priority: P2)

The list of prefixes shown in the first selector must be derived from the existing `examOptions` list without any manual duplication. When a new exam group is added to `examOptions` (e.g., "soa-01"), its prefix "soa" automatically appears in the prefix selector.

**Why this priority**: Reduces maintenance burden. Without this, two lists must be kept in sync manually, which is error-prone.

**Independent Test**: Can be tested by inspecting the prefix selector options and confirming they match the unique prefixes extracted from `examOptions`, with no hard-coded prefix list elsewhere.

**Acceptance Scenarios**:

1. **Given** the list of exams contains "dva-1", "dea-01", "aif-01", "saa-01", "aws-01", "dd-fundamentals-1", "repo-01", **When** the page loads, **Then** the prefix selector contains exactly those unique prefixes displayed in uppercase: DVA, DEA, AIF, SAA, AWS, DD, REPO.
2. **Given** a new exam "soa-01" is added to the list, **When** the page reloads, **Then** "soa" appears in the prefix selector without any other code change.

---

### Edge Cases

- What happens when only one exam belongs to a prefix? The second selector should still show that single exam correctly.
- What happens when the user resets the prefix selector back to the placeholder? The exam selector MUST reset to its placeholder with no exam options shown (per FR-001); no message is displayed.
- What happens when an exam name does not follow the `prefix-number` pattern (e.g., "dd-fundamentals-1")? The prefix extraction rule must handle multi-word prefixes or non-numeric suffixes gracefully — any text before the first hyphen is treated as the prefix.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The home page MUST display a prefix selector before the existing exam selector. Until a prefix is selected, the exam selector MUST show only its placeholder with no selectable exam options.
- **FR-002**: The prefix selector MUST be populated with the unique prefixes derived from the existing exam list; no separate hard-coded prefix list is required.
- **FR-003**: A prefix is defined as all characters before the first hyphen (`-`) in an exam name (e.g., "dva" from "dva-1", "dd" from "dd-fundamentals-1").
- **FR-004**: When the user selects a prefix, the exam selector MUST show only the exams whose prefix matches the selected value.
- **FR-005**: When the user changes or clears the prefix selector, the exam selector MUST reset to its default placeholder state (no exam selected). Score counters, navigation index, loaded questions, and saved answers in storage MUST NOT be modified.
- **FR-006**: The Load button MUST remain disabled until both a prefix and an exam are selected.
- **FR-007**: The only trigger for resetting and reloading session state is clicking the Load button with a newly selected exam; prefix-only changes MUST NOT trigger any session reset.
- **FR-008**: Prefix values in the prefix selector MUST be displayed in uppercase (e.g., "DVA", "DEA", "AIF"). The internal value used for filtering the exam list remains the lowercase prefix derived from the exam name.

### Key Entities

- **Exam Name**: A string in the form `{prefix}-{identifier}` (e.g., "dva-1", "dea-12", "dd-fundamentals-2"). The prefix is the substring before the first hyphen.
- **Prefix**: The leading segment of an exam name used to group related exam sets (e.g., "dva", "dea", "aif", "saa", "aws", "dd", "repo").

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: Users can locate a specific exam group (e.g., all DEA exams) with at most 2 interactions: one prefix selection and one exam selection.
- **SC-002**: The prefix selector list is always consistent with the exam list — zero manual sync required when new exams are added.
- **SC-003**: The exam selector always shows only the exams for the selected prefix, with no exams from other groups leaking through.
- **SC-004**: The feature introduces no regression to the existing load, answer, and navigation flows. Verified by `dotnet build` (zero errors) and manual smoke test per quickstart.md (T015, T016).
