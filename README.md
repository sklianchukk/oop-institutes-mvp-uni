# RezerwacjaSalMVP (Room Reservation System)

A professional desktop application for managing university room reservations, designed as an educational project to demonstrate the **Model-View-Presenter (MVP)** architectural pattern in a modern .NET environment.

## 📖 Overview
**RezerwacjaSalMVP** is a comprehensive system built for university departments to manage rooms, academic staff, and reservation schedules. It emphasizes clean code, separation of concerns, and modularity through the use of repositories and services.

## 🚀 Technologies
* **Language:** C# 14.0
* **Framework:** .NET 10
* **UI:** Windows Forms (WinForms)
* **Architecture:** MVP (Model-View-Presenter)
* **IDE:** Visual Studio 2026

## 🏗️ Architecture (MVP Pattern)
The project is strictly divided into three layers to ensure maintainability and testability:

* **Model:** Contains business logic and data structures (`Sala`, `Rezerwacja`, `Prowadzacy`, etc.).
* **View:** Passive UI components (`UserControls`) that display data and capture user events without containing logic.
* **Presenter:** Acts as the "brain." It subscribes to View events, interacts with Repositories/Services, and updates the View.

### Additional Layers:
* **Repositories:** Encapsulate data access logic (CRUD operations).
* **Services:** `FileService` handles data persistence (e.g., JSON/XML serialization).

## 📂 Project Structure
```text
RezerwacjaSalMVP/
├── Models/              # Domain entities (Sala, Adres, Rezerwacja, etc.)
├── Views/               # UI Controls (SalaViewControl, RezerwacjaViewControl)
├── Presenters/          # Logic mediators (SalaPresenter, RezerwacjaPresenter)
├── Repositories/        # Data access layer (SalaRepository, ProwadzacyRepository)
├── Services/            # Business services (FileService)
├── Common/              # Interfaces and shared utilities
├── MainForm.cs          # Application entry point and navigation shell
└── Program.cs           # Bootstrap logic
