# Fibonacci Implementations
This project shows forms to implement a recursive function to get the n-st number of a Fibonacci sequence in the below programming languages.

Each source code also contains a main function to call the Fibonacci function 20 times.

## Languages
* Python
* VBA
* Kotlin
* Java
* Scala
* Javascript

### Python
```python
# Implementation of function to get the n-st number of a Fibonnaci sequence in Python 

def fibo(n):
    if n <= 1:
        return n
    else:
        return (fibo(n-1) + fibo(n-2))

if __name__ == '__main__':
    print('Fibonacci Sequence\n')

    # Print the 20 first numbers of the Fibonacci Sequence
    for x in range(21):
        print('index - {} \t value = {}'.format(x, fibo(x)))
```

### VBA
```vb
' Implementation of function to get the n-st number of a Fibonnaci sequence in VBA

Option Explicit
Public Function fibo(n As Integer) As Integer
    If (n <= 1) Then
        fibo = n
    Else
        fibo = (fibo(n - 1) + fibo(n - 2))
    End If
End Function

Public Sub main()
    Dim i As Integer
    Debug.Print "Fibonacci Sequence" & vbNewLine
    
    ' Print the 20 first numbers of the Fibonacci Sequence 
    For i = 0 To 20
        Debug.Print "index - " & i & vbTab & " value = " & CStr(fibo(i))
    Next i
End Sub
```

### Kotlin
```kotlin
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
```

### Java
```java
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
```