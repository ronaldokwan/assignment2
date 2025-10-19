# Task Management System

## Overview

This is a simple **Windows Forms (WinForms) Task Management System** in C#. It allows an **admin** to create users, manage tasks, and track task history. Users can view tasks assigned to them, mark them as done, and view the task history.

---

## Features

### Admin

* Can **create new users** (admin or regular users).
* Can **assign tasks** to users.
* Can **edit or delete any task**.
* Can **view all users and their tasks**.
* Can **sign out** and return to the login screen.

### User

* Can view tasks assigned to them.
* Can **mark tasks as done**.
* Can view **task history**.
* Cannot create or delete tasks.
* Cannot see other users’ tasks.

### General

* **Admin seeding:** If `database.txt` does not exist, a default admin is created:

  ```
  Username: admin
  Password: admin123
  Role: admin
  ```
* Task history is saved in `tasks.txt`.
* User database is saved in `database.txt`.

---

## Files

| File                  | Purpose                                         |
| --------------------- | ----------------------------------------------- |
| `Program.cs`          | Application entry point, seeds admin if needed. |
| `LogInScreen.cs`      | Login screen for authentication.                |
| `Admin.cs`            | Admin panel for user management and task access.|
| `TaskList.cs`         | Task list view with actions (inherits from `BaseTaskForm`). |
| `AddTask.cs`          | Form for adding/editing tasks.                  |
| `FileRepository.cs`   | Implements repositories for tasks and users (includes interfaces). |
| `TaskRepositoryTests.cs` | NUnit tests for task repository.             |
| `database.txt`        | Stores users in format: `Username|Password|Role`. |
| `tasks.txt`           | Stores tasks in format: `Title|Description|Status|AssignedUser|History|DueDate|Priority`. |

---

## Usage

1. Run the application.
2. If `database.txt` is missing, a default admin account is created.
3. Log in as admin (`admin` / `admin123`).
4. Create users using the **Admin Panel**.
5. Assign tasks to users using **Manage Tasks**.
6. Users can log in, view, and update their tasks.

---


