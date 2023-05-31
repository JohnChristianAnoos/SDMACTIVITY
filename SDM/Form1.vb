Public Class Form1
    Dim yspeed As Integer = 0
    Dim gravity As Integer = 4
    Dim building(1) As PictureBox
    Dim topbuilding(1) As PictureBox
    Dim Form1(1) As PictureBox
    Dim gapbuilding As Integer = 470
    Dim buildingSpeed As Single = 3.5
    Dim score As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer1.Enabled = True
        CreateBuilding(1)
        CreateTopBuilding(1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        yspeed += gravity
        Helicopter.Top += yspeed
        For i = 0 To 1
            building(i).Left -= buildingSpeed
            topbuilding(i).Left -= buildingSpeed
            If Collision(building(i), Helicopter) = True Or (Collision(topbuilding(i), Helicopter) = True) Then
                Application.Exit()
            End If

            If building(i).Left < 0 Then
                building(i).Left += 400
                topbuilding(i).Left += 400
                building(i).Top = 70 + 290 * Rnd()
                topbuilding(i).Top = building(i).Top - gapbuilding
            End If

        Next

    End Sub

    Private Sub CreateBuilding(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BorderStyle = BorderStyle.FixedSingle
            temp.BackColor = Color.Green
            temp.Top = 70 + 290 * Rnd()
            temp.Left = (i * 200) + 300
            building(i) = temp
            building(i).Visible = True
        Next
    End Sub

    Private Sub CreateTopBuilding(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BorderStyle = BorderStyle.FixedSingle
            temp.BackColor = Color.Green
            temp.Top = building(i).Top - gapbuilding
            temp.Left = (i * 200) + 300
            topbuilding(i) = temp
            topbuilding(i).Visible = True
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            yspeed = -15
        End If
    End Sub

    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.top And
            Object2.Top + Object2.Height >= Object1.Top And
            Object1.Left + Object1.Width >= Object2.Left And
            Object2.Left + Object2.Width >= Object1.Left And Object1.visible = True And Object2.visible = True Then
            Collided = True

        End If
        Return Collided
    End Function
End Class
