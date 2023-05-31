<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Helicopter = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Helicopter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Helicopter
        '
        Me.Helicopter.BackColor = System.Drawing.Color.Transparent
        Me.Helicopter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Helicopter.Image = CType(resources.GetObject("Helicopter.Image"), System.Drawing.Image)
        Me.Helicopter.Location = New System.Drawing.Point(24, 12)
        Me.Helicopter.Name = "Helicopter"
        Me.Helicopter.Size = New System.Drawing.Size(72, 71)
        Me.Helicopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Helicopter.TabIndex = 0
        Me.Helicopter.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(676, 400)
        Me.Controls.Add(Me.Helicopter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.Helicopter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Helicopter As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
