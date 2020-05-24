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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1173, 307)
        Me.Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(518, 98)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(141, 161)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(399, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(381, 453)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Historic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(467, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "JustinClicks.com"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 28
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(474, 468)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(222, 59)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "Login"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2TextBox1.BorderRadius = 22
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2TextBox1.DefaultText = "UserName"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.SystemColors.Window
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(421, 303)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.SelectionStart = 8
        Me.Guna2TextBox1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(335, 46)
        Me.Guna2TextBox1.TabIndex = 3
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.AutoRoundedCorners = True
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.White
        Me.Guna2TextBox2.BorderRadius = 21
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2TextBox2.DefaultText = "Password"
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Location = New System.Drawing.Point(421, 379)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.SelectionStart = 8
        Me.Guna2TextBox2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Size = New System.Drawing.Size(335, 45)
        Me.Guna2TextBox2.TabIndex = 4
        Me.Guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.AnimationSpeed = 0.1!
        Me.Guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CircleProgressBar1.FillOffset = 21
        Me.Guna2CircleProgressBar1.FillThickness = 5
        Me.Guna2CircleProgressBar1.Font = New System.Drawing.Font("Segoe UI Symbol", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(635, 468)
        Me.Guna2CircleProgressBar1.Maximum = 300
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Cyan
        Me.Guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Guna2CircleProgressBar1.ProgressOffset = 20
        Me.Guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.Guna2CircleProgressBar1.ProgressThickness = 4
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.ShadowDecoration.Parent = Me.Guna2CircleProgressBar1
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(61, 59)
        Me.Guna2CircleProgressBar1.TabIndex = 5
        Me.Guna2CircleProgressBar1.UseTransparentBackground = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 5500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1173, 682)
        Me.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JustInClicks.com (Login Page)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
