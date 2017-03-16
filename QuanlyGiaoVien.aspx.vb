Imports System.Data.SqlClient
Imports System.Data

Partial Class QuanlyGiaoVien
    Inherits System.Web.UI.Page


    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim sda As SqlDataAdapter
    Dim ds As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindData()
        End If
    End Sub

    Private Sub BindData()
        con = New SqlConnection(ConfigurationManager.ConnectionStrings("QLSVConnect").ConnectionString)
        con.Open()
        cmd = New SqlCommand("SELECT * from GiaoVien")
        cmd.Connection = con
        sda = New SqlDataAdapter()
        sda.SelectCommand = cmd
        ds = New DataSet
        sda.Fill(ds)
        con.Close()
      
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

        'xtmagv.Text = ds.Tables(0).Rows(1)("MaGV").ToString()
        'xtTenGv.Text = ds.Tables(0).Rows(1)("TenGV").ToString()
        'xtmalop.Text = ds.Tables(0).Rows(0)("Malop").ToString()
        'If Not String.IsNullOrEmpty(ds.Tables(0).Rows(0)("sex").ToString()) Then
        'txtSex.SelectedValue = ds.Tables(0).Rows(0)("sex").ToString()
        'End If
        'tquyen.Text = ds.Tables(0).Rows(0)("Quyen").ToString()
        'xtgioithieu.Text = ds.Tables(0).Rows(0)("GioiThieu").ToString()

        'txtusername.Text = ds.Tables(0).Rows(0)("Username").ToString()

        '       txtmakhoa.Text = ds.Tables(0).Rows(0)("Makhoa").ToString()

        txtmagv.Text = GridView1.SelectedRow.Cells(0).Text
        txtTenGv.Text = GridView1.SelectedRow.Cells(1).Text
        txtdate.Text = GridView1.SelectedRow.Cells(2).Text
        txtmakhoa.Text = GridView1.SelectedRow.Cells(3).Text
        txtmalop.Text = GridView1.SelectedRow.Cells(4).Text
        txtquyen.Text = GridView1.SelectedRow.Cells(5).Text
        txtgioithieu.Text = GridView1.SelectedRow.Cells(6).Text
        txtusername.Text = GridView1.SelectedRow.Cells(7).Text
        txtpass.Text = GridView1.SelectedRow.Cells(8).Text
       
    End Sub

    Protected Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        txtmagv.Text = String.Empty

        txtTenGv.Text = String.Empty
        txtdate.Text = String.Empty
        txtmakhoa.Text = String.Empty
        txtmalop.Text = String.Empty
        txtquyen.Text = String.Empty
        txtgioithieu.Text = String.Empty
        txtusername.Text = String.Empty
        txtpass.Text = String.Empty
    End Sub
End Class
