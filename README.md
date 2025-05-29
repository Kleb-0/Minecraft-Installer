# MineCLI Installer

A terminal-based tool for installing and managing Minecraft mods, shaders, resource packs, and (soon) modpacks.

> Project in active development. The goal is to evolve it into a complete Minecraft launcher with backend support.

---

## Purpose

MineCLI Installer automates common installation tasks for Minecraft: Java Edition content. It currently helps users move files like mods or shaders into the correct `.minecraft` folders, and will eventually support online downloads, modpacks, and user profiles.

---

## Tech Stack

- **Language:** C#
- **Interface:** CLI (Command Line), with planned GUI using WinForms or WPF
- **Target OS:** Windows

---

## Current Structure

The project is currently in its CLI phase, with a clean modular architecture and three main classes:

- `Program.cs`: Runs the main app and calls the menu
- `MainMenu.cs`: Displays options and handles user interaction
- `DirectoryManager.cs`: Manages folder verification, creation, and file movement

---

## Current Features

- One-click installation of:
  - Mods (`.jar`)
  - Shaders (`.zip`)
  - Resource packs (`.zip`)
- Interactive terminal menu
- Organized folder structure on Desktop
- Modular code, built for future expansion

---

## Roadmap

### ✅ Phase 1 – Basic Local Installer (CLI Script)
- Adds a terminal menu for mods, shaders, and resource packs
- Moves files from Desktop folders to `.minecraft`

### Phase 2 – Graphical UI (GUI)
- Desktop interface with buttons and status messages

### Phase 3 – Online Installation
- Download and install files directly from provided URLs

### Phase 4 – Modpacks & Profiles
- One-click modpack installation from `.zip` + metadata via `.json`

### Phase 5 – Full Launcher with Backend
- Login screen, modpack API integration, database, and admin dashboard

---

## Getting Started

> Prerequisites: [.NET SDK 8+](https://dotnet.microsoft.com/download)

```bash
git clone https://github.com/your-username/minecli-installer.git
cd minecli-installer
dotnet run
