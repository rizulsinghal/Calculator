Public Class Form1
    Dim opChk As Integer = 0
    Dim result As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ChkLen() Then
            TextBox1.Text += "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ChkLen() Then
            TextBox1.Text += "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ChkLen() Then
            TextBox1.Text += "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ChkLen() Then
            TextBox1.Text += "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ChkLen() Then
            TextBox1.Text += "5"
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ChkLen() Then
            TextBox1.Text += "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ChkLen() Then
            TextBox1.Text += "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ChkLen() Then
            TextBox1.Text += "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ChkLen() Then
            TextBox1.Text += "9"
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If ChkLen() Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub ButtonClr_Click(sender As Object, e As EventArgs) Handles ButtonClr.Click
        TextBox1.Text = ""
        result = 0
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        opChk = 1
        result += MainWrk()
    End Sub

    Private Sub ButtonSub_Click(sender As Object, e As EventArgs) Handles ButtonSub.Click
        opChk = 2
        result += MainWrk()
    End Sub

    Private Sub ButtonMul_Click(sender As Object, e As EventArgs) Handles ButtonMul.Click
        opChk = 3
        result += MainWrk()
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        opChk = 4
        result += MainWrk()
    End Sub

    Private Sub ButtonEql_Click(sender As Object, e As EventArgs) Handles ButtonEql.Click
        Dim n As Integer = CInt(TextBox1.Text())
        If opChk = 1 Then
            result += n
        ElseIf opChk = 2 Then
            result -= n
        ElseIf opChk = 3 Then
            result *= n
        ElseIf opChk = 4 Then
            result /= n
        Else
            MsgBox("Enter Number")
        End If
        TextBox1.Text = CStr(result)
    End Sub

    Function ChkLen() As Boolean
        If Len(TextBox1.Text) = 10 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function MainWrk() As Integer
        Dim n As Integer
        n = CInt(TextBox1.Text())
        TextBox1.Text = ""
        Return n
    End Function

End Class
