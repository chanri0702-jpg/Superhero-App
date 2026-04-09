# PRG2782
A C# Windows Forms application for managing student records. Built on .NET Framework 4.7.2, the project follows a three-layer architecture separating presentation, business logic, and data concerns.

---

## Features

- **Main Menu** — Entry point with navigation to other forms
- **Add New Student** — Form to capture student details including name, surname, age, superpower, and exam score
- Layered project structure ready for expansion with database or file persistence

---

## Project Structure

### Architecture

The project is divided into three namespaces reflecting a layered design:

| Namespace | Purpose |
|---|---|
| `PRG_282_Project` (root) | Application entry point and top-level forms |
| `PRG_282_Project.PresentationLayer` | UI forms for user interaction |
| `PRG_282_Project.BusinessLayer` | Business logic (currently a stub — `Logic.cs`) |
| `PRG_282_Project.DataLayer` | Data models and data handling |

### Source Files

| File | Description |
|---|---|
| `Program.cs` | Application entry point; launches `MainMenuForm` |
| `Form1.cs` / `Form1.Designer.cs` | `MainMenuForm` — main menu with a button to navigate to the new student form |
| `Form2.cs` / `Form2.Designer.cs` | `NewStudentForm` — form with fields for Name, Surname, Superpower, Age, and Exam Score |
| `Form3.cs` / `Form3.Designer.cs` | `Form3` — placeholder form in the `PresentationLayer` namespace |
| `Student.cs` | `Student` entity class in the `DataLayer`; holds student fields and a hardcoded sample list |
| `Datahandler.cs` | `Datahandler` class in the `DataLayer`; mirrors `Student` structure, intended for data access logic |
| `Logic.cs` | Stub class in the `BusinessLayer`; placeholder for future business rules |

### Student Data Fields

Each student record contains the following properties:

| Field | Type | Description |
|---|---|---|
| `ID` | `int` | Unique student identifier |
| `Name` | `string` | First name |
| `Surname` | `string` | Last name |
| `Age` | `int` | Student age |
| `Superpower` | `string` | Student's assigned superpower |
| `Score` | `int` | Exam score |

---

## Forms Overview

**MainMenuForm (`Form1`)**
- Single button: *Add New Student*
- Navigates to `NewStudentForm` and hides itself

**NewStudentForm (`Form2`)**
- Input fields for all student properties
- *Submit* button currently navigates back to `MainMenuForm`
- Form closes itself on submit (does not just hide)

**Form3**
- Empty placeholder form in the `PresentationLayer` namespace
- No functionality implemented yet

---

## Requirements

- .NET Framework 4.7.2
- Visual Studio (any edition supporting Windows Forms and .NET Framework)

---

## Running the Application

1. Open `PRG_282_Project.csproj` in Visual Studio.
2. Build the solution (`Ctrl+Shift+B`).
3. Run the application (`F5` or `Ctrl+F5`).
4. The Main Menu will open — click *Add New Student* to navigate to the student entry form.
