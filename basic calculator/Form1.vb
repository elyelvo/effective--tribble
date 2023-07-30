Imports System.CodeDom.Compiler

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click, btnadd.Click
        Dim num1, num2, result As Integer
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        result = num1 + num2

        btnresult.Text = result


    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Dim num1, num2, result As Integer
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        result = num1 - num2

        btnresult.Text = result
    End Sub

    Private Sub btnmult_Click(sender As Object, e As EventArgs) Handles btnmult.Click

        Dim num1, num2, result As Integer
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        result = num1 * num2

        btnresult.Text = result
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        Dim num1, num2, result As Integer
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        result = num1 / num2

        btnresult.Text = result


    End Sub

    Private Sub btnmod_Click(sender As Object, e As EventArgs) Handles btnmod.Click
        Dim num1, num2, result As Integer
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum1.Text)
        result = num1 Mod num2

        btnresult.Text = result
    End Sub
End Class
