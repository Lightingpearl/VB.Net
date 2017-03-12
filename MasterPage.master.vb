
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim userName As String = Session("UserName").ToString
        lblSession.Text = Session("Username").ToString

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'If Not IsPostBack Then
        'Session.RemoveAll()
        'Session.Clear()
        'Session.Abandon()
        'End If

        Response.Redirect("Login.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Profile.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("EditProfile.aspx")
    End Sub
End Class

