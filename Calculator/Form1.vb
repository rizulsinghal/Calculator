Public Class Form1
    Dim opChk As Integer = 0
    Dim result As Long = 0
    Dim count As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "1"
        ElseIf count = 2 Then
            TextBox1.Text = "1"
            count = 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "2"
        ElseIf count = 2 Then
            TextBox1.Text = "2"
            count = 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "3"
        ElseIf count = 2 Then
            TextBox1.Text = "3"
            count = 1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "4"
        ElseIf count = 2 Then
            TextBox1.Text = "4"
            count = 1
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "5"
        ElseIf count = 2 Then
            TextBox1.Text = "5"
            count = 1
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "6"
        ElseIf count = 2 Then
            TextBox1.Text = "6"
            count = 1
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "7"
        ElseIf count = 2 Then
            TextBox1.Text = "7"
            count = 1
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "8"
        ElseIf count = 2 Then
            TextBox1.Text = "8"
            count = 1
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "9"
        ElseIf count = 2 Then
            TextBox1.Text = "9"
            count = 1
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If ChkLen() And count = 1 Then
            TextBox1.Text += "0"
        ElseIf count = 2 Then
            TextBox1.Text = "0"
            count = 1
        End If
    End Sub

    Private Sub ButtonClr_Click(sender As Object, e As EventArgs) Handles ButtonClr.Click
        TextBox1.Text = ""
        result = 0
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If ChkLen0() Then
            opChk = 1
            result += MainWrk()
        End If
    End Sub

    Private Sub ButtonSub_Click(sender As Object, e As EventArgs) Handles ButtonSub.Click
        If ChkLen0() Then
            opChk = 2
            result += MainWrk()
        End If
    End Sub

    Private Sub ButtonMul_Click(sender As Object, e As EventArgs) Handles ButtonMul.Click
        If ChkLen0() Then
            opChk = 3
            result += MainWrk()
        End If
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        If ChkLen0() Then
            opChk = 4
            result += MainWrk()
        End If
    End Sub

    Private Sub ButtonEql_Click(sender As Object, e As EventArgs) Handles ButtonEql.Click
        If opChk = 0 Then
            If ChkLen0() Then
                Dim a As Integer = CInt(TextBox1.Text())
                TextBox1.Text = CStr(a + 1)
            End If
        Else
            If ChkLen0() Then
                count = 2
                Dim n As Integer = CInt(TextBox1.Text())
                Dim ch As Integer = opChk
                opChk = 0
                If ch = 1 Then
                    result += n
                ElseIf ch = 2 Then
                    result -= n
                ElseIf ch = 3 Then
                    result *= n
                ElseIf ch = 4 Then
                    result /= n
                Else
                    MsgBox("Enter Number")
                End If
                TextBox1.Text = CStr(result)
                result = 0
            End If
        End If
    End Sub

    Function ChkLen() As Boolean
        If Len(TextBox1.Text) = 10 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function ChkLen0() As Boolean
        If Len(TextBox1.Text) = 0 Then
            MsgBox("Enter Number")
            Return False
        Else
            Return True
        End If
    End Function

    Function MainWrk() As Integer
        Dim n As Long
        n = CInt(TextBox1.Text())
        TextBox1.Text = ""
        Return n
    End Function

End Class
