
### Data parallel processing:
Data parallel processing is a technique that allows you to perform operations on large datasets concurrently, improving performance and responsiveness.
In this example, we demonstrate how to use the `Parallel.ForEach` and  `Parallel.For` method to process a collection of data in parallel.

### For loop vs Parallel.For:  
| Parallel.For | for | 
|----------------|----------------|
|Runs iterations in parallel using multiple threads.|Runs sequentially|
|Can significantly speed up CPU-bound tasks on multicore systems.|May be slower for CPU-intensive operations
|Order of execution is not guaranteed.| Ideal for tasks that depend on order or shared state.|
|Not suitable if iterations depend on each other or modify shared state without synchronization. | iterations depend on each other |
|iteration count is large |itereation ocunt is small|
|cant break in the middle of the loop |can break in the middle of the loop|

## 1st  example :
This example demonstrates the difference between parallel for and for loop in case of shared data .


### Task.WhenAny()  vs Task.WhenAll():
| Task.WhenAny | Task.WhenAll |
|----------------|----------------|
|Returns when any of the provided tasks completes.|Returns when all of the provided tasks complete.|
|Can be used to handle the first completed task.|Used to wait for all tasks to complete before proceeding.|
|Useful for scenarios where you want to take action on the first completed task.|Useful when you need to ensure all tasks have completed before proceeding.|
|used when you want to perform an action as soon as any of tasks finishes | making multiple api calls or processing |

## 2nd  example :

2nd example demonstrates how to use the `Task.WhenAny` and `Task.WhenAll` 
methods to handle multiple asynchronous operations efficiently.

Each task fetches data content from a URL and processes ,displays the result.

in case of usage of `Task.WhenAll` , the code fetches data from multiple URLs concurrently and processes the results and after all tasks and sites data are fetched , data is displayed.
in case of usage of  `Task.WhenAny`,the code fetches data from multiple URLs concurrently processes the results . Once one task finishes , data of this site is displayed.

