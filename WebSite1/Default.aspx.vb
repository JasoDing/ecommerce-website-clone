
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
        End If
    End Sub

    Private Sub BindGrid()
        Dim service As New GetUserInfo.WebService()
        GridView1.DataSource = service.UserInfo()
        GridView1.DataBind()
    End Sub

End Class
