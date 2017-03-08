

Public Class frmHome
    Public Delegate Sub hienthi(str As String)
    Public Event xylyhienthi As hienthi

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RaiseEvent xylyhienthi(lblname.Text)
    End Sub



    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If MessageBox.Show("You want exit program?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
            Me.Dispose()
        End If
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        Dim frmlogin As New frmLogin
        frmlogin.ShowDialog()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnsv.Click

    End Sub


    Private Sub LabelX3_Click(sender As Object, e As EventArgs) Handles LabelX3.Click, lblquyen.Click

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim frm As New frmLogin
        frm.ShowDialog()

    End Sub

End Class