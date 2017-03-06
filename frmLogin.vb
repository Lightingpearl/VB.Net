Imports System.Data.SqlClient
Public Class frmLogin


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'Application.Exit()
        Me.Close()

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If txtusername.Text = "" Or txtpassword.Text = ""
                MessageBox.Show("Username or Password not blank!!", "No entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                Dim connection As New SqlConnection("Data Source=Y;Initial Catalog=QLSV;Integrated Security=True")
                Dim comman As New SqlCommand(" Select * from Phanquyen where username=@UN and password=@PW", connection)
                comman.Parameters.Add("@UN", SqlDbType.NVarChar).Value = txtusername.Text
                comman.Parameters.Add("@PW", SqlDbType.VarChar).Value = txtpassword.Text
                Dim adapter As New SqlDataAdapter(comman)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() <= 0 Then
                    MessageBox.Show("Username or Password are Invaild")
                Else
                    MessageBox.Show("Login Successfully ")
                    Dim home As New frmHome
                    Me.Hide()
                    home.ShowDialog()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Something wrong !!!", "No entry",MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusername.Focus()


    End Sub
End Class
