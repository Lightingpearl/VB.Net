Imports System.Data.SqlClient
Imports System.Data
Imports Utilities




Partial Class QuanlyGiaoVien
    Inherits System.Web.UI.Page

    Public Function loadpage() As DataSet
        Dim s As String = "Data Source=Y;Initial Catalog=QLSV;Integrated Security=True"
        Dim conn As New SqlConnection(s)
        Dim da As New SqlDataAdapter("select * from GiaoVien", conn)
        Dim ds As New DataSet
        conn.Open()
        da.Fill(ds)
        conn.Close()
        Return ds
    End Function

    Public Function loadcbx(ByVal MaKhoa As String) As DataSet
        Dim s As String = "Data Source=Y;Initial Catalog=QLSV;Integrated Security=True"
        Dim conn As New SqlConnection(s)
        Dim da As New SqlDataAdapter("select * from GiaoVien", conn)
        Dim ds As New DataSet
        conn.Open()
        da.Fill(ds)
        conn.Close()
        Return ds
    End Function


    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub



    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim a As New QuanlyGiaoVien
        GridView1.DataSource = a.loadpage.Tables(0)
        DropDownList1.DataSource = a.loadcbx("MaKhoa").Tables(0)
    End Sub



    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub
End Class
