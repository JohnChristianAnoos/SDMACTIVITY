Public Class Serialform
    Private Sub Serialform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If My.Settings.SerialKey = TextBox1.Text Then
            My.Settings.AppStat = "Full Version"
            My.Settings.Save()
            Me.Close()

        Else
            MsgBox("Invalid SerialKey!", vbExclamation + MessageBoxButtons.RetryCancel)
        End If
    End Sub

    Private Sub Serialform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class