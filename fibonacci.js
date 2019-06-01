// Implementation of function to get the n-st number of a Fibonnaci sequence in JavaScript

function fibo(n){
    if (n <= 1) {
        return n;
    } else {
        return (fibo(n-1) + fibo(n-2));
    }
}

function main() {
    console.log("Fibonacci Sequence\n")
    for (int i = 0; i <= 20; i++) {
        console.log("index - " + i + "\t value = " + fibo(i));
    }
}