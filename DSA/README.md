# Data Structures & Algorithms (DSA)

This folder contains organized DSA practice problems, templates, and notes.

## Goal
- Build and maintain a clean, language-agnostic collection of DSA solutions.
- Provide a reproducible project structure for solving and testing problems.

## Project Structure

```
DSA/
├── README.md                # This file
├── templates/               # Language templates (main, input parsing, tests)
├── arrays/                  # Array problems
├── linked-list/             # Linked list problems
├── stacks-queues/           # Stack & Queue problems
├── trees/                   # Binary trees, BST problems
├── graphs/                  # Graph problems & algorithms
├── dp/                      # Dynamic programming problems
├── sorting-searching/       # Sorting and searching algorithms
├── maths/                   # Number theory, combinatorics
├── problems/                # Mixed problems organized by difficulty
│   ├── easy/
│   ├── medium/
│   └── hard/
└── resources/               # Reference links, cheat-sheets, notes
```

## Conventions
- One problem per folder or file. Use a descriptive filename prefixed by platform/ID when available (e.g., two-sum_1_leetcode.cs).
- Include a short README or comment at top explaining inputs/outputs and complexity.
- Keep language templates in `templates/` to speed up new problems.

## Languages & Tools
- Primary language: add the language(s) you're using (C#, Java, Python, etc.).
- Use simple build/run instructions in each language folder (e.g., `dotnet run`, `python file.py`).

## How to add a new problem
1. Pick a category folder (e.g., `arrays/`).
2. Create a new folder or file following the naming convention.
3. Add solution file, brief explanation, and sample input/output.
4. If tests exist, add them alongside or under `tests/` in the problem folder.

## Useful Resources
- Algorithms cheat sheets, complexity tables, and links can go into `resources/`.

## Contribution
- Keep commits focused (one problem per commit) and include brief message.
- Open a PR when adding multiple problems or refactoring templates.

---
Happy coding — solve consistently and refactor for clarity.
