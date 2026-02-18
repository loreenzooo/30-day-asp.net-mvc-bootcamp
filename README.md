# 30-Day ASP.NET MVC Discipline Bootcamp – Scenario Based

This repository contains the 30-day discipline plan for learning **ASP.NET MVC** and related technologies through scenario-based exercises. The goal is to build an evolving **Student Enrollment Management System**, starting from a Console App to a full ASP.NET MVC web application with jQuery enhancements.

---

## 📌 Project Overview

- **Objective:** Build a complete Student Enrollment System in progressive phases.
- **Technologies:** C#, OOP, LINQ, Exception Handling, ASP.NET MVC, Razor Views, jQuery, AJAX, Validation
- **Discipline Approach:** Daily tasks with checkboxes, progress tracking, and GitHub commits
- **Focus:** Build real projects, not just practice snippets.

---

## 🧱 Database / Task Properties (for Notion Tracking)

1. **Task Name** (Title)
2. **Phase** (Foundation Console System, MVC Core System, jQuery Enhancement, Final System)
3. **Day** (1–30)
4. **Scenario & Requirements** (Detailed project instructions)
5. **Core Topics Used** (C#, OOP, Lists, Exception Handling, LINQ, MVC, Razor, Model Binding, Validation, jQuery, AJAX, Partial View)
6. **Status** (Not Started, In Progress, Completed)
7. **Priority** (High, Very High, Non-Negotiable)
8. **Hours Completed**
9. **Target Hours** (default 5)
10. **Progress** (Hours Completed / Target Hours)
11. **Pushed to GitHub** (Checkbox)
12. **No Games Today** (Checkbox)
13. **Reflection / Errors Faced** (Text)

---

## 🔥 Phase 1 – Foundation Console System (Days 1–7)

**Project Scenario:**  
You are building a **Student Enrollment Console Management System** for a small school.

### Day 1 – System Base Setup
- Create Console App: `EnrollmentConsoleSystem`
- Display welcome message
- Create main menu using `switch`:
  1. Add Student  
  2. View Students  
  3. Exit
- Use loops to keep program running
- Use methods for each menu option
- Use variables properly  

**Core Topics:** C#, Methods, Loops, Switch

### Day 2 – OOP Implementation
- Create `Student` class (Id, FullName, Age, Course)
- Create constructor
- Add method: `DisplayInfo()`
- Store students inside `List<Student>`

**Core Topics:** OOP, Classes, Lists

### Day 3 – Full CRUD Implementation
- Add, View, Update, Delete, Search Student by ID

**Core Topics:** Lists, Methods, Conditions

### Day 4 – Exception Handling Layer
- Implement try-catch
- Validate numeric inputs
- Prevent duplicate Student IDs
- Handle empty names

**Core Topics:** Exception Handling, Validation

### Day 5 – LINQ Features
- Filter students older than X age
- Sort students by Name
- Search students by partial name

**Core Topics:** LINQ, Lambda Expressions

### Day 6 – Refactor & Improve
- Separate logic into multiple methods
- Improve UI formatting
- Handle edge cases

### Day 7 – Rebuild From Memory
- Rebuild entire Console System without referencing old code

---

## 🔥 Phase 2 – MVC Core System (Days 8–15)

**Project Scenario:**  
Convert the Console Enrollment System into a **Web Application** using ASP.NET MVC.

- **Day 8:** MVC architecture understanding, setup layout page  
- **Day 9:** Create Student Model, DbContext, configure database  
- **Day 10:** Create Controller, implement Index() action  
- **Day 11:** Create Razor View, display students in table  
- **Day 12:** Implement Create form, Model Binding, Save to DB  
- **Day 13:** Implement Edit & Delete  
- **Day 14:** Add server-side validation (Data Annotations)  
- **Day 15:** Refactor MVC structure, clean controllers, improve UI

---

## 🔥 Phase 3 – jQuery Enhancement (Days 16–22)

**Scenario:** Improve UI interactions with jQuery.  

- Add jQuery click events  
- Implement client-side validation  
- AJAX GET & POST  
- Use Partial Views  
- Update table dynamically without page refresh  

**Core Topics:** jQuery, AJAX, DOM Manipulation

---

## 🔥 Phase 4 – Final System (Days 23–30)

**Project:** Build a polished **Student Enrollment Web System**  

- Full CRUD  
- Clean UI  
- Proper layered structure  
- Server + client validation  
- AJAX-powered interactions  
- Daily GitHub commits

---

## ✅ Tracking & Discipline

Create Notion database or Kanban for:

- Today’s Mission  
- High Priority  
- Discipline Tracker  
- Completed Tasks

**Rules:**  
- Minimum 5 hours coding daily  
- Push daily to GitHub  
- No games before tasks  
- Track errors & reflections  

---

## 📂 Project Folder Structure

