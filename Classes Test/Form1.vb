Option Explicit On
Option Strict On



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CanISeeOthers()
        Form2.SubCanOthersSeeMeForm2()

        Dim Form1Class1 As New Class1

        Form1Class1.SubCanOthersSeeMeClass1()

        Class1.VariableClass1Shared = False

    End Sub

    Public Sub SubCanOthersSeeMeForm1()

    End Sub

End Class
