<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnsv = New DevComponents.DotNetBar.ButtonX()
        Me.btngv = New DevComponents.DotNetBar.ButtonX()
        Me.btnexit = New DevComponents.DotNetBar.ButtonX()
        Me.btnkhoa = New DevComponents.DotNetBar.ButtonX()
        Me.btnmon = New DevComponents.DotNetBar.ButtonX()
        Me.btnlogout = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.lblname = New DevComponents.DotNetBar.LabelX()
        Me.lblquyen = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.LabelX1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.LabelX1.Location = New System.Drawing.Point(0, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.ControlText
        Me.LabelX1.Size = New System.Drawing.Size(1008, 57)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Home"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX1.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me.LabelX1.VerticalTextTopUp = False
        '
        'btnsv
        '
        Me.btnsv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsv.Location = New System.Drawing.Point(135, 220)
        Me.btnsv.Name = "btnsv"
        Me.btnsv.Size = New System.Drawing.Size(117, 45)
        Me.btnsv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnsv.TabIndex = 2
        Me.btnsv.Text = "Quan ly SV"
        '
        'btngv
        '
        Me.btngv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btngv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btngv.Location = New System.Drawing.Point(327, 220)
        Me.btngv.Name = "btngv"
        Me.btngv.Size = New System.Drawing.Size(117, 45)
        Me.btngv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btngv.TabIndex = 2
        Me.btngv.Text = "Quan Ly GV"
        '
        'btnexit
        '
        Me.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnexit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnexit.Location = New System.Drawing.Point(879, 413)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(117, 45)
        Me.btnexit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Exit"
        '
        'btnkhoa
        '
        Me.btnkhoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnkhoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnkhoa.Location = New System.Drawing.Point(528, 220)
        Me.btnkhoa.Name = "btnkhoa"
        Me.btnkhoa.Size = New System.Drawing.Size(117, 45)
        Me.btnkhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnkhoa.TabIndex = 2
        Me.btnkhoa.Text = "Quan Ly Khoa"
        '
        'btnmon
        '
        Me.btnmon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnmon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnmon.Location = New System.Drawing.Point(738, 220)
        Me.btnmon.Name = "btnmon"
        Me.btnmon.Size = New System.Drawing.Size(117, 45)
        Me.btnmon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnmon.TabIndex = 2
        Me.btnmon.Text = "Quan Ly Mon"
        '
        'btnlogout
        '
        Me.btnlogout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnlogout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnlogout.Location = New System.Drawing.Point(921, 63)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 23)
        Me.btnlogout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "Logout"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 63)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Username"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 92)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Authorities"
        '
        'lblname
        '
        '
        '
        '
        Me.lblname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblname.Location = New System.Drawing.Point(93, 63)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(75, 23)
        Me.lblname.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblname.TabIndex = 4
        '
        'lblquyen
        '
        '
        '
        '
        Me.lblquyen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblquyen.Location = New System.Drawing.Point(93, 92)
        Me.lblquyen.Name = "lblquyen"
        Me.lblquyen.Size = New System.Drawing.Size(75, 23)
        Me.lblquyen.SymbolColor = System.Drawing.Color.Aqua
        Me.lblquyen.TabIndex = 5
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 469)
        Me.Controls.Add(Me.lblquyen)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnmon)
        Me.Controls.Add(Me.btnkhoa)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btngv)
        Me.Controls.Add(Me.btnsv)
        Me.Controls.Add(Me.LabelX1)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnsv As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btngv As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnexit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnkhoa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnmon As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnlogout As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblname As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblquyen As DevComponents.DotNetBar.LabelX
End Class
