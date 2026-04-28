# C# Learning Journey 🚀

A structured, week-by-week curriculum for mastering modern C# features, from fundamental delegates to complex concurrency patterns.

| Week | Focus | Description |
| :--- | :--- | :--- |
| **01** | [Delegates-WEEK1](./Delegates-WEEK1) | Understanding function pointers and basic delegate patterns. |
| **02** | [Threads-WEEK2](./Threads-WEEK2) | Diving into system threading and task-based asynchrony. |
| **03** | [TPL-WEEK3](./TPL-WEEK3) | Exploring the Task Parallel Library and parallel execution. |
| **04** | [AdvancedDelegates-WEEK4](./AdvancedDelegates-WEEK4) | Mastering custom events and `EventHandler<TEventArgs>`. |
| **05** | [IComparable](./IComparable) | Custom sorting and object comparison with `IComparable`. |

## 🛠 Tech Stack
- **Runtime:** .NET 9.0
- **Language:** C# 13.0
- **IDE:** JetBrains Rider / Visual Studio 2022

## 🚀 Getting Started
```powershell
# Get the code
git clone https://github.com/T-King-00/Learning-CSharp.git
cd Learning-CSharp

# Restore and build
dotnet restore
dotnet build

# Run the project
dotnet run
```

> **Note:** This project uses multiple entry points. Check `.csproj` for the active `StartupObject` or toggle `Main` methods as needed.

## 📜 Commands
- `dotnet run` - Execute active module
- `dotnet build` - Compile project
- `dotnet clean` - Remove build artifacts
- `dotnet test` - Run tests (Coming Soon)

---
*Created as part of a structured learning path.*
