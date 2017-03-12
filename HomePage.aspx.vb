
Partial Class Home_Page
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGV_Click(sender As Object, e As EventArgs) Handles btnGV.Click
        Response.Redirect("QuanlyGiaoVien.aspx")
    End Sub
End Class
