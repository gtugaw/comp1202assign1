# COMP1202 – Assignment&nbsp;1  
**Individual – 10 %**

**Due:** End of day **Monday, June 16, 2025**

---

## Purpose  
Using C#, develop an application for a simple **Quiz** using only the programming constructs taught in class up to and including **Week 4** (sequential programming, selection structures, loops).

---

## Outcomes  
1. Apply the programming techniques of C#.  
2. Apply sequence-logic and selection-logic concepts.  
3. Write decision-making and iterative statements to solve problems.  
4. Explore best practices for designing and developing **Console** applications.

---

## Problem Statement  

- The application allows the user to take a **Quiz** and displays a **Progress Report**.  
- At the start, ask the user for:  
  - course code  
  - last name  
  - first name  
- The quiz contains **four** multiple-choice questions (five options each) about a hobby, popular music, or another interest.  
- Each question is worth **25 points**.  
- When the user answers correctly:  
  - show a congratulatory message  
  - display the intermediate score  
- When the user answers incorrectly, show an appropriate message.  
- Each question may be attempted **up to 4 times**.  
  - Stop asking that question once it is correct **or** 4 attempts are exhausted (0 points).  
- The application must track the number of attempts for every question.

### Scoring per Question

| Attempt | Points |
|---------|--------|
| 1st     | 25     |
| 2nd     | 15     |
| 3rd     | 5      |
| 4th     | 0      |

---

## Progress Report (displayed on screen)

- Full name and course code.  
- Total points for the quiz **plus a breakdown** for each question, including number of attempts.  
- Percentage score (e.g., `60 / 100 = 60 %`).

---

## Important Guidelines

- Comment **course, name, and student ID** at the very top of the program.  
- Submit only **one** `.cs` file (single-file program).  
- Visual Studio project name pattern: `COMP1202_Ass1_<StudentID>`.  
- Use only constructs taught up to Week 4.  
- Identical or nearly identical assignments receive **0 marks** for all parties involved.  
- Multiple submissions allowed; **latest** one is graded.  
- Incorrect file formats (e.g., `.txt`, `.pdf`) earn **0 marks**.  
- Submit via the **D2L Dropbox** for Assignment 1.

---

## Marking Scheme (100 pts)

| Task | Possible Points | Description |
|------|----------------:|-------------|
| Program Requirements | 60 | Application logic meets all requirements; quiz mark calculated correctly. Maximum points for simple, efficient code. |
| UX | 10 | User experience is smooth; no confusion or frustration while taking the quiz. |
| UI | 10 | Interface is seamless and well-planned. |
| Quiz Results | 10 | Correctly track quiz score, keep user updated, and display overall data after quiz completion. |
| Code Documentation & Convention | 10 | Proper comments plus best coding practices and conventions discussed in class. |
| **Total** | **100** | |

---
