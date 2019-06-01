// Implementation of function to get the n-st number of a Fibonnaci sequence in Kotlin

fun fibo(n: Int) : Int {
    return if (n <= 1) n else (fibo(n-1) + fibo(n-2))
}

fun main(){
    println("Fibonacci Sequence\n")

    // Print the 20 first numbers of the Fibonacci Sequence
    for (i in 0..20){
        println("index - $i \t value = " + fibo(i))
    }
}