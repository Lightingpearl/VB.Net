<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnlogin = New DevComponents.DotNetBar.ButtonX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.txtpassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblpw = New DevComponents.DotNetBar.LabelX()
        Me.lblusername = New DevComponents.DotNetBar.LabelX()
        Me.txtusername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnexit = New DevComponents.DotNetBar.ButtonX()
        Me.btnreset = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnlogin.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnlogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnlogin.Location = New System.Drawing.Point(632, 293)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(99, 40)
        Me.btnlogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "Login"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'txtpassword
        '
        '
        '
        '
        Me.txtpassword.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtpassword.Border.Class = "TextBoxBorder"
        Me.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtpassword.Location = New System.Drawing.Point(534, 253)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.PreventEnterBeep = True
        Me.txtpassword.Size = New System.Drawing.Size(197, 20)
        Me.txtpassword.TabIndex = 1
        '
        'lblpw
        '
        '
        '
        '
        Me.lblpw.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblpw.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpw.Location = New System.Drawing.Point(405, 253)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblpw.Size = New System.Drawing.Size(123, 23)
        Me.lblpw.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.lblpw.TabIndex = 2
        Me.lblpw.Text = "Password"
        '
        'lblusername
        '
        '
        '
        '
        Me.lblusername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblusername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(405, 213)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblusername.Size = New System.Drawing.Size(123, 23)
        Me.lblusername.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.lblusername.TabIndex = 4
        Me.lblusername.Text = "Username"
        '
        'txtusername
        '
        '
        '
        '
        Me.txtusername.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtusername.Border.Class = "TextBoxBorder"
        Me.txtusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtusername.Location = New System.Drawing.Point(534, 213)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PreventEnterBeep = True
        Me.txtusername.Size = New System.Drawing.Size(197, 20)
        Me.txtusername.TabIndex = 3
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.Image = Global.WindowsApplication1.My.Resources.Resources.tải_xuống
        Me.ReflectionImage1.Location = New System.Drawing.Point(12, 89)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(276, 276)
        Me.ReflectionImage1.TabIndex = 5
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.LabelX1.ForeColor = System.Drawing.Color.Chocolate
        Me.LabelX1.Location = New System.Drawing.Point(0, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.ControlLight
        Me.LabelX1.Size = New System.Drawing.Size(810, 83)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "Quan lý Sinh Viên"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnexit
        '
        Me.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnexit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnexit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(706, 376)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(104, 35)
        Me.btnexit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnexit.TabIndex = 7
        Me.btnexit.Text = "Exit"
        '
        'btnreset
        '
        Me.btnreset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnreset.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnreset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(470, 293)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(95, 40)
        Me.btnreset.TabIndex = 0
        Me.btnreset.Text = "Reset"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 423)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ReflectionImage1)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblpw)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.btnlogin)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnlogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents txtpassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblpw As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblusername As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtusername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Public WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnexit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnreset As DevComponents.DotNetBar.ButtonX

End Class
