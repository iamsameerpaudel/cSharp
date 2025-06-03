console.log("First")

setTimeout(()=>{console.log("Sixth")},100)

Promise.resolve().then(()=>{console.log("Third")})

setTimeout(()=>{console.log("Fifth")},10)

console.log("Second")

Promise.resolve().then(()=>{console.log("Fourth")})

// Output: First Second Third Fourth Fifth Sixth
