# Thread Practice Files and Examples

In this folder, you will find practice files and examples related to **Threads** and **Tasks** in asynchronous programming.

---

## 1. Threads

### Threading Basics

- **Introduction to Threading**
- **Creating Threads using** `threading.Thread`
  - Starting and joining threads

### What is Threading?

1. Threading is a form of **asynchronous programming**.
2. It allows **multiple threads to run concurrently**.
3. It improves responsiveness, especially in:
   - Web access  
   - File operations  
   - Image processing  
   - WCF (Windows Communication Foundation) programming  

---

## 2. Task

### What is a Task?

- A **Task** represents an **asynchronous operation**.
- It allows operations to run in the background or in parallel without blocking the main thread.

### Key Features of Tasks:

- Efficient management using the **thread pool**
- Can be created with:
  - `Task.Run(...)`
  - `Task.Factory.StartNew(...)`

---

### How to Call Async Methods

- Use the **`async` keyword** to define asynchronous methods.
  - These methods typically return a `Task` or `Task<T>`.
- Use the **`await` keyword** to:
  - Wait for a method's result **without blocking the calling thread**
  - Allow the thread to perform other work while awaiting

#### Example Behavior:

> `await` tells the program:  
> "Pause this method until the file is read,  
> but **do not block the thread** — the thread is free to do other work."

- If `await` is **not used**, the call stack **moves on to the next statement immediately**.

#### Common Await Patterns:

```csharp
	await Task.WhenAll(t1, t2); // Waits for all tasks to complete
	await Task.WhenAny(tasks);  // Continues when any one task completes
```

## Examples
In the tasks.cs file, you will find examples demonstrating the use of `Task` and `async/await` patterns.
### First example :

two tasks reading files and  processing the data in parallel. 
then writing the results of the first task to finish to console screen.
writing the status of the two tasks to console screen.

### 2nd example :
#### Async JSON File Operations Example
This C# console application demonstrates how to:
read and write JSON data to a file using asynchronous methods.
steps:
- Create a directory if it doesn't exist.
- Define a list of `Account` objects with `Name` and `Balance`.
- Serialize the list to JSON and **asynchronously save** it to a file.
- **Asynchronously read** the JSON data from the file.
- Deserialize the JSON back into a list of accounts.
- Print account details to the console.

The code uses `async` and `await` to perform file I/O operations without blocking the main thread, improving responsiveness and scalability.
if the data was more larger , without async and await the application would be blocked until the file operations are completed.
```csharp


---
Thread vs Task

| Feature            | Thread                                      | Task                                                  |
|--------------------|----------------------------------------------|--------------------------------------------------------|
| **Definition**     | A low-level OS-managed unit of execution     | A high-level abstraction representing asynchronous work |
| **Creation**       | `new Thread(() => { ... })`                  | `Task.Run(() => { ... })` or `Task.Factory.StartNew(...)` |
| **Resource Usage** | Creates a new system thread (heavier)        | Uses the thread pool (lighter)                        |
| **Scheduling**     | Manually controlled                          | Managed by the .NET Task Scheduler                    |
| **Use Case**       | Long-running or dedicated background work    | Short tasks, parallel computations, async operations  |
| **Scalability**    | Limited scalability (one thread per task)    | Highly scalable (thread pool reuse)                  |
| **Blocking**       | Can block calling thread                     | Can be awaited without blocking                       |
| **Error Handling** | Try/catch within the thread's method         | Structured via `await`, `.ContinueWith`, etc.         |
| **Ease of Use**    | More control but more complexity             | Easier to write and maintain asynchronous code         |


