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