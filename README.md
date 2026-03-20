# C# Snake Game

A classic Snake game built with WPF and C# .NET 8, featuring smooth animations, modern graphics, and responsive controls

## 📋 Features

- **Classic Gameplay**: Control the snake to eat food and grow longer
- **Smooth Animations**: Animated countdown at game start and death animation when game over
- **Rotating Snake Head**: The snake head rotates based on movement direction
- **Score Tracking**: Keep track of your score as you eat more food
- **Responsive Controls**: Arrow keys for smooth and precise movement
- **Modern UI**: Clean, modern interface with custom graphics

## 🎮 How to Play

1. **Start the Game**: Press any key to start
2. **Controls**:
   - ⬆️ **Up Arrow**: Move up
   - ⬇️ **Down Arrow**: Move down
   - ⬅️ **Left Arrow**: Move left
   - ➡️ **Right Arrow**: Move right
3. **Objective**: Eat the food to grow longer and increase your score
4. **Game Over**: The game ends when you hit the wall or run into yourself
5. **Restart**: Press any key after game over to play again

## 🛠️ Technologies Used

- **Framework**: .NET 8
- **Language**: C# 12.0
- **UI Framework**: WPF (Windows Presentation Foundation)
- **Architecture**: MVVM-inspired pattern with separated game logic

## 🎯 Game Features

### Core Mechanics
- **15x15 Grid**: Optimal size for gameplay balance
- **Collision Detection**: Accurate detection for walls and self-collision
- **Food Spawning**: Random food placement in empty cells only
- **Direction Buffering**: Queue up to 2 direction changes for smooth gameplay
- **Smart Movement**: Prevents 180-degree turns and invalid moves
- **Score System**: Earn points for each food item consumed

### Visual Features
- **3-Second Countdown**: Visual countdown timer before game starts
- **Death Animation**: Progressive animation showing dead snake segments with 70ms delay
- **Rotating Head**: Snake head image rotates 90° increments based on direction
- **Real-time Score**: Score updates displayed at the top of the window
- **Game Over Screen**: Clear overlay with restart instructions
- **Responsive Window**: Viewbox ensures game scales properly on different screen sizes

### Technical Features
- **Async Game Loop**: Non-blocking game loop running at 140ms intervals
- **Efficient Rendering**: Grid-based rendering system with cached image references
- **LinkedList Snake**: Efficient snake body management using `LinkedList<Position>`
- **Image Caching**: All images loaded once at startup for performance
- **Transform Rendering**: Uses `RotateTransform` for smooth head rotation

## 🚀 Getting Started

### Prerequisites
- **Operating System**: Windows 10 or higher
- **.NET SDK**: .NET 8.0 or higher
- **IDE**: Visual Studio 2022 (recommended) or Visual Studio Code with C# extension

### Installation

1. **Clone the repository**: git clone https://github.com/CristianCiulica/Snake.git cd Snake
2. **Open in Visual Studio**: start Snake.sln
3. **Restore dependencies** (automatic in Visual Studio): dotnet restore
4. **Build the project**: dotnet build
5. **Run the game**:
   - In Visual Studio: Press `F5` or click the "Start" button
   - In CLI: `dotnet run`
  
     
## 🐛 Known Issues

- None currently reported

## 🔮 Future Enhancements

Potential features for future versions:
- [ ] High score persistence
- [ ] Difficulty levels
- [ ] Sound effects and background music
- [ ] Pause functionality
- [ ] Multiple food types with different point values
- [ ] Power-ups (speed boost, invincibility, etc.)
- [ ] Walls and obstacles
- [ ] Leaderboard system

## 🤝 Contributing

Contributions are welcome! Here's how you can help:

1. **Fork the repository**
2. **Create a feature branch**: `git checkout -b feature/AmazingFeature`
3. **Commit your changes**: `git commit -m 'Add some AmazingFeature'`
4. **Push to the branch**: `git push origin feature/AmazingFeature`
5. **Open a Pull Request**

### Contribution Guidelines
- Follow existing code style and conventions
- Add comments for complex logic
- Test your changes thoroughly
- Update README if adding new features

## 📄 License

This project is open source and available under the MIT License.

## 👤 Author

**Cristian Ciulica**
- GitHub: [@CristianCiulica](https://github.com/CristianCiulica)
- Repository: [Snake Game](https://github.com/CristianCiulica/Snake)

## 🙏 Acknowledgments

- Inspired by the classic Snake game
- Built with WPF framework and .NET 8
- Thanks to the .NET community for excellent documentation
- Visual assets created for this project

## 📊 Project Stats

- **Lines of Code**: ~500+
- **Language**: C# 12.0
- **Framework**: .NET 8.0
- **Platform**: Windows

## 🎓 Learning Resources

If you're learning from this project, here are some key concepts demonstrated:

- **WPF Data Binding**: UI updates and data flow
- **Async/Await Pattern**: Non-blocking operations
- **MVVM Architecture**: Separation of concerns
- **Game Loop Implementation**: Real-time game mechanics
- **Collections**: LinkedList for efficient operations
- **Enums and Extensions**: Type-safe direction handling
- **Image Transforms**: Rotation and rendering
- **Event Handling**: Keyboard input processing

---

⭐ **If you enjoyed this project, please consider giving it a star on GitHub!**

🐛 **Found a bug?** [Open an issue](https://github.com/CristianCiulica/Snake/issues)

💡 **Have a suggestion?** [Start a discussion](https://github.com/CristianCiulica/Snake/discussions)
