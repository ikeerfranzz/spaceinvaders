
# 👾 Space Invaders

<p>
  <img alt="Unity" src="https://img.shields.io/badge/Unity-6000.0.58f2-black?logo=unity&logoColor=white">
  <img alt="Render Pipeline" src="https://img.shields.io/badge/Render%20Pipeline-URP%202D-blue">
  <img alt="Platform" src="https://img.shields.io/badge/Platform-PC-lightgrey">
  <img alt="Status" src="https://img.shields.io/badge/Status-Completed-brightgreen">
</p>

A faithful **Space Invaders** clone built from scratch in Unity: pilot a ship along the bottom of the screen, shoot down a descending grid of aliens before they overrun your defenses, and survive their return fire behind a set of destructible shield buildings. The alien formation speeds up with every kill — just like the arcade original — turning each wave into a race against an accelerating threat.

---

## 📋 Table of Contents

- [Gameplay](#-gameplay)
- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
- [Controls](#-controls)
- [Author](#-author)
- [Status & License](#-status--license)

---

## 🎮 Gameplay

- **Player ship** — moves left/right along the bottom of the screen and fires straight upward.
- **Alien formation** — a full grid of aliens moves as one synchronized unit, sweeping side to side; when the edge of the formation reaches a wall it reverses direction and drops one row closer to the player.
- **Dynamic difficulty** — every alien destroyed increases the whole formation's movement speed, escalating the tension as the wave thins out — the closer you are to clearing it, the faster it gets.
- **Alien counter-fire** — a random alien in the formation fires back at a fixed interval, so no member of the group is ever truly safe to ignore.
- **Destructible shields** — buildings positioned between the player and the aliens absorb hits and visibly shrink with each one, offering diminishing cover as the fight goes on.
- **Player lives** — the player has a limited number of lives, tracked live on a UI counter, and is taken out of play once they run out.

## ✨ Features

- Full alien-formation AI: synchronized group movement, wall detection, direction reversal, and progressive speed-up on kills
- Random alien selection for enemy return fire, decoupled from the group's movement logic
- Destructible shield buildings with proportional visual damage (scale shrinks with remaining health)
- Player life system with real-time UI feedback (TextMesh Pro)
- Self-cleaning projectiles (player and alien bullets) that despawn on collision or after a timeout, keeping the scene light
- Physics-driven and transform-driven projectile variants (`Shooting` vs. `AlienBullet`) for different bullet behaviors

## 🛠️ Tech Stack

| Category | Technology |
|---|---|
| Engine | Unity **6000.0.58f2** (Unity 6) |
| Rendering | Universal Render Pipeline (URP) — 2D |
| Input | Unity Input System |
| Physics | Unity 2D Physics (`Rigidbody2D`, trigger/collision events) |
| UI Text | TextMesh Pro |
| Language | C# |

## 📁 Project Structure

```
spaceinvaders/
├── Assets/
│   ├── Scenes/
│   │   └── SpaceInvaders.unity   # Main (and only) gameplay scene
│   ├── Scripts/
│   │   ├── ShipMovement.cs       # Player movement + firing
│   │   ├── playerHealth.cs       # Player lives + UI
│   │   ├── FatherMovement.cs     # Alien formation movement, direction & speed-up
│   │   ├── AlienMovement.cs      # Per-alien wall detection → notifies formation
│   │   ├── DestroyEnemy.cs       # Alien death on player hit
│   │   ├── AlienBullet.cs        # Alien projectile behavior
│   │   ├── Shooting.cs           # Physics-based projectile behavior
│   │   └── BuildingHealth.cs     # Destructible shield buildings
│   └── TextMesh Pro/             # TMP package assets (font, shaders, examples)
├── Packages/                      # Unity Package Manager manifest
├── ProjectSettings/                # Unity project configuration
└── .gitignore                      # Unity-specific ignore rules
```

## 🚀 Getting Started

### Prerequisites

- [Unity Hub](https://unity.com/download) with editor version **6000.0.58f2** (or a compatible Unity 6 LTS release) installed
- Git

### Setup

```bash
git clone https://github.com/ikeerfranzz/spaceinvaders.git
```

1. Open **Unity Hub** → **Add** → select the cloned `spaceinvaders` folder
2. Let the Unity Editor import all assets and resolve packages from `Packages/manifest.json`
3. Open `Assets/Scenes/SpaceInvaders.unity`
4. Press **Play** in the Editor

## 🕹️ Controls

| Input | Action |
|---|---|
| ← / → Arrow Keys | Move the ship horizontally |
| Space | Fire |

## 👨‍💻 Author

**Iker Franzoni** ([@ikeerfranzz](https://github.com/ikeerfranzz)) — sole developer of this project, responsible for all gameplay programming: player control and shooting, the alien formation AI (movement, wall bouncing, progressive speed-up), enemy return fire, destructible shields, and the player life/UI system.

## 📄 Status & License

This project is **complete**. It was built as a personal/course exercise and is shared here as a portfolio piece; no open-source license is granted. Please reach out before reusing any part of this code or its assets.
