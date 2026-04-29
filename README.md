# **Learning C# – Concepts Covered in This Repository**

This repository documents my learning journey through C# and .NET.  
Each folder represents a focused topic I explored, with hands‑on examples and experiments.

---

## **📘 Topics Learned So Far**

### **1. Delegates (WEEK 1)**
- Basics of delegates and method references  
- `Action`, `Func`, and custom delegates  
- Callback patterns and flexible method invocation  

---

### **2. Threads (WEEK 2)**
- Creating and managing threads  
- Thread lifecycle and synchronization  
- Understanding race conditions  

---

### **3. Tasks & TPL (WEEK 3)**
- Difference between **Threads** and **Tasks**  
- Using the **Task Parallel Library (TPL)**  
- Data parallelism with `Parallel.For`, `Parallel.ForEach`, and `Parallel.Invoke`  

---

### **4. Advanced Delegates (WEEK 4)**
- Multicast delegates  
- Delegate chaining  
- Real‑world usage patterns  

---

### **5. Deep Copy vs Shallow Copy**
- How objects behave in memory  
- Implementing deep copy using constructors, manual cloning, or serialization  
- Understanding reference vs value duplication  

---

### **6. Inheritance & Polymorphism**
- Base and derived classes  
- Method overriding vs hiding  
- Runtime polymorphism and flexible design  

---

### **7. Records**
- Immutable data types in C#  
- Value‑based equality  
- Positional records and `with` expressions  

---

### **8. IComparable Interface**
- Implementing custom sorting logic  
- `IComparable\Person.cs` - Implements the `IComparable` interface to allow custom sorting and comparison for `Person` objects based on their age.
- `IComparable\program.cs` - Demonstrates how to compare `Person` objects using the `CompareTo` method and print detailed results via the enhanced `printConsoleMessages` function.

- Folder includes:  
  - `IComparable/Person.cs` — Implements `IComparable<Person>`  
  - `IComparable/program.cs` — Demonstrates comparisons and console output  

---

### **9. Null Handling in C#**
*(Inspired by the video you’re watching)*  
- Nullable value types (`int?`)  
- Nullable reference types (`string?`)  
- Null‑conditional operator (`?.`)  
- Null‑coalescing operator (`??`)  
- Null‑coalescing assignment (`??=`)  
- Null‑forgiving operator (`!`)  
- Nullable annotation context (`#nullable enable`)  

---

### **10. Entity Framework (EntityFrameworkSolution)**
- EF Core setup  
- DbContext configuration  
- Migrations  
- Basic CRUD operations  

---

## **📁 Repository Structure**

```
AdvancedDelegates-WEEK4/
DeepCopy vs ShallowCopy/
Delegates-WEEK1/
EntityFrameworkSolution/
IComparable/
Null/
Polymorphism/
Records/
TPL-WEEK3/
Threads-WEEK2/
Inheritance/


```

---

## **🎯 Purpose**
This repo is a structured learning space where each concept is isolated into its own folder, making it easy to focus, test, and revisit topics as needed.

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





