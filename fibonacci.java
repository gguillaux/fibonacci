// Implementation of function to get the n-st number of a Fibonnaci sequence in Java

class Fibonnaci {
    public static int fibo(int n) {
        if (n <= 1) {
            return n;
        } else {
            return (fibo(n-1) + fibo(n-2));
        }

    }

    public static void main(String[] args) {
        System.out.println("Fibonacci Sequence\n");

        // Print the 20 first numbers of the Fibonacci Sequence
        for (int i = 0; i <= 20; i++) {
            System.out.println("index - " + i + "\t value = " + fibo(i));
        }
    }
}