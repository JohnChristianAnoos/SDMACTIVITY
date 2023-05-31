Public Class Serial
    Private Sub Serial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.AppStat = "Trial Version" Then
            If My.Settings.LoadCount < 0 Then
                Serialform.ShowDialog()
            End If

            Me.Text = My.Settings.AppStat & " : Count - " & My.Settings.LoadCount
            My.Settings.LoadCount -= 1
            My.Settings.Save()

        Else
            Me.Text = My.Settings.AppStat
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ShowDialog()
        Me.Dispose()
    End Sub
End Class