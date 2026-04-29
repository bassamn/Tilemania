# Tilemania - 2D Platformer Game

A 2D platformer game created during the GameDev.tv course with custom modifications and improvements.

## 🎮 About

This project is based on the **Tilemania** tutorial from GameDev.tv. I've customized the game by modifying rules, UI elements, and gameplay mechanics to create a unique experience.

## 🕹️ How to Play

### Controls
- **WASD** - Move character
- **Space** - Jump
- **Left Click / Enter** - Fire

### Game Rules
- **3 Lives System**: You start with 3 lives (shown as heart). When you die, you respawn at the beginning of the current level
- **Coins persist**: Collected coins and defeated enemies remain collected after death
- **Game Over**: When all lives are lost (skull icon appears), dying will restart the game from Level 1
- **3 Levels**: Complete all three levels to finish the game (currently restarts after completion)

### Gameplay Elements
- **Hazards**: Avoid water, spikes, and enemies - touching them causes death
- **Bouncing Mushrooms**: Use mushrooms to bounce higher
- **Coins**: Collect coins scattered throughout levels
- **Enemies**: Defeat enemies to earn 3 coins each

## 📸 Screenshots & Gameplay

## 🎨 Assets

- **Base Assets**: [Unity Asset Store](https://assetstore.unity.com/packages/2d/environments/super-platformer-assets-42013)
- **Custom Assets**: Exit button, UI elements, and additional sprites created by me:
  <div>
    <img src="Assets/Sprites/bullet.png">
  </div>
  <div>
    <img src="Assets/Sprites/exit.png">
  </div>
  <div>
    <img src="Assets/Sprites/heart.png">
  </div>
  <div>
    <img src="Assets/Sprites/skull.png">
  </div>

## 🛠️ Built With

- **Unity** (version 6000.4.2f1)
- **C#**

## 📥 Download & Play

Download the latest release from the [Releases](../../releases) page.

### System Requirements
- **OS**: Windows 64-bit
- **Architecture**: Intel 64-bit (x86_64)

## 📝 Development Notes

This project was created as part of my learning journey in game development. Key modifications from the original tutorial include:
- Custom lives system with skull/heart UI
- Modified respawn mechanics
- Custom exit button
- Enhanced level design
- Persistent coin/enemy state within levels

