# Event Loop

> JS is a singlethreaded language but still it allows non-blocking asynchronous behaviour.

> Such behaviour is enabed by the Event Loop.

> JS is single threaded, only one piece of code runs at a time, Event loop makes sure that the code runs in the correct order enabling asynchronous programming.

## The main components of the event loop are

- Call stack

- Callback queue

- Microtask queue

- Event Loop

## Working

> Code is run line by line in a single thread in the call stack.

> Some tasks that take time (SetInterval, SetTimeout, Api calls etc.) but instead of blocking the process these tasks are sent to the evevent queue.

> The event loop constantly checks if the call stack is empty and if any task is waiting in the queue.

> If any task is in the queue it moves it to the call stack for execution.

## Tasks in JS

- Synchronous tasks: These tasks are executed immediately in the call stack (eg: function calls, variable declarations etc.)

- Microtasks: High priority async tasks (eg: Promise callbacks)

- Macrotasks: Low priority async tasks (eg: setTimeout, setInterval, DOM events etc.)


## Execution of tasks

>   Execute all synchronous tasks on the call stack
>   Process microtasks in the microtask queue
>   Process first task in the macrotak queue
>   Loop


### Example

```js
console.log(1) //Synchronous task 

setTimeout(()=>{console.log(2)},10) //Macrotask

console.log(3) //Synchronous task

Promise.resolve().then(()=>{console.log(4)}) //Microtask

```

> Output of the above code will be: 1 3 4 2
