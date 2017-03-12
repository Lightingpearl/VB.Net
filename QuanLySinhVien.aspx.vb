Imports System.Data
Imports System.Data.SqlClient


Partial Class DanhsachSV
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'tạo kết nối và mở kết nối
        If conn Is Nothing Then
            conn = New SqlConnection("Data Source=Y;Initial Catalog=Qlhs;Integrated Security=True")
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        'tạo đối tượng lệnh'

        Dim cmd As New SqlCommand("Select * From DMLop,DMSV where DMLop.MaLop = DMSV.MaLop and DMLop.TenLop=@tenlop", conn)

        '   cmd.Parameters.AddWithValue ("@malop",Me.DropDownList1.SelectedIttem )
        'tạo dataAdapter
        Dim da As New SqlDataAdapter(cmd)
        'Tao data table hoac dataset va fill dl vao dt hoa ds

        Dim dt As New DataTable
        da.Fill(dt)
        ' Gan du lieu len doi tuong hien thi

        ' Me.TenLop.DataSource = dt







    End Sub


    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
