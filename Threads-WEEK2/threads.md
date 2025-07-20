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

### 3rd example :
#### Async JSON Object Deserialization and HTTP Requests  Example
In this example we learn how to access web resources asynchronously using the HttpClient class.  and how to make asynchronous API calls to retrieve data from a REST API and process the response.

The HttpClient class in C# is designed for asynchronous use, allowing nonblocking calls to web resources.
The HttpClient class includes asynchronous methods like GetAsync, PostAsync, PutAsync, DeleteAsync, and SendAsync.
A single instance of HttpClient should be reused for multiple requests to improve performance and resource management.

The code uses `async` and `await` to perform file I/O operations without blocking the main thread, improving responsiveness and scalability.
if the data was more larger , without async and await the application would be blocked until the file operations are completed.

```
Thread vs Task :

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

```

## Accessing web resources by usage of asynchronous api calls using  HTTPClient:

httpclient is a class that allows you to make asynchronous HTTP requests. It is part of the System.Net.Http namespace and provides methods for sending HTTP requests and receiving HTTP responses.
#### methods inide httpclient class:
GetAsync:	Sends a GET request to the specified URI and returns the response as a string.
PostAsync:	Sends a POST request to the specified URI with the given content and returns the response as a string.
PutAsync:	PUT method completely replaces whatever currently exists at the target URL with something else. With this method, you can create a new resource or overwrite an existing one given you know the exact Request-URI , Sends a PUT request to the specified URI with the given content and returns the response as a string.

DeleteAsync: Sends a DELETE request to the specified URI and returns the response as a string.
SendAsync:	Sends an HTTP request with the specified HttpRequestMessage and returns the response as a string.
