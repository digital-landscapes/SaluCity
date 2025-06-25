# SaluCity

An interactive Unity-based city planning educational game designed to help users understand the principles and practices of healthy city design.

## 🎮 Project Overview

SaluCity is an educational city planning simulation game where players can learn how to design and manage a healthy, sustainable urban environment through interactive experiences.

## 🔧 Technical Requirements

### Unity Version
- **Unity 2021.3.21f1** (LTS)

### System Requirements
- **Windows**: Windows 10 64-bit or higher
- **macOS**: macOS 10.14 or higher  
- **Memory**: Minimum 4GB RAM (8GB or higher recommended)
- **Storage**: At least 2GB available space
- **Graphics**: DirectX 11 or Metal compatible graphics card

## 📦 Installation and Setup

### 1. Install Unity
1. Download and install [Unity Hub](https://unity3d.com/get-unity/download)
2. Install **Unity 2021.3.21f1** version through Unity Hub
3. Make sure to install the following modules:
   - Android Build Support (if mobile platform needed)
   - iOS Build Support (if iOS needed)
   - WebGL Build Support (if web version needed)

### 2. Clone the Project
```bash
git clone https://github.com/digital-landscapes/SaluCity.git
cd SaluCity
```

### 3. Open Project in Unity
1. Open Unity Hub
2. Click "Add Project"
3. Select the cloned SaluCity folder
4. Confirm Unity version is 2021.3.21f1
5. Click the project name to open

## 🎯 How to Use

### Development Mode
1. Open the project in Unity Editor
2. Find the `Assets/Scenes` folder in the Project window
3. Double-click the main scene file to open
4. Click the Play button (▶️) to start testing

### Building the Game
1. Open **File** > **Build Settings**
2. Select target platform (PC, Mac, WebGL, etc.)
3. Click **Build** or **Build and Run**
4. Choose output folder and wait for build completion

## 🎮 Gameplay

### Basic Controls
- **Left Mouse Button**: Select and interact
- **Right Mouse Button**: Camera rotation
- **Mouse Wheel**: Zoom in/out
- **WASD Keys**: Move camera (if enabled)

### Game Objectives
- Learn basic principles of healthy city planning
- Experience how different urban facilities affect residents' health
- Deepen understanding through interactive Q&A

## 📁 Project Structure

```
SaluCity/
├── Assets/
│   ├── 3DModels/          # 3D model assets
│   ├── Scenes/            # Game scenes
│   ├── Scripts/           # C# scripts
│   ├── UI/                # User interface assets
│   └── Materials/         # Material files
├── ProjectSettings/       # Unity project settings
├── Packages/             # Unity package configuration
└── README.md             # Project documentation
```

## 🛠️ Development Notes

### Git LFS
This project uses Git LFS to manage large files. If you encounter issues downloading large files, ensure Git LFS is installed:
```bash
git lfs install
git lfs pull
```

### Contributing Guidelines
1. Fork this repository
2. Create a new feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## 🔧 Troubleshooting

### Common Issues
- **Project won't open**: Confirm Unity version is 2021.3.21f1
- **Missing assets**: Run `git lfs pull` to download large files
- **Build errors**: Check target platform settings and required modules are installed

### Performance Optimization
- On low-end devices, consider lowering quality settings
- Disable unnecessary post-processing effects
- Adjust shadow quality settings

## 📞 Support and Contact

If you encounter issues while using the project, please:
1. Check the Troubleshooting section in this README
2. Search for similar issues in GitHub Issues
3. Create a new Issue describing your problem

## 📄 License

This project is licensed under the [MIT License](LICENSE)

---

**Development Team**: Digital Landscapes  
**Project Status**: In Development  
**Last Updated**: 2024