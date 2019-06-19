Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
'<System.Web.Script.Services.ScriptService()> _


<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<System.Web.Script.Services.ScriptService()>
Public Class WebService
    Inherits System.Web.Services.WebService


    <WebMethod(Description:="get info")>
    Public Function UserInfo() As DataTable
        Dim constr As String = ConfigurationManager.ConnectionStrings("userLogin").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("SELECT * FROM Users")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        dt.TableName = "Users"
                        sda.Fill(dt)
                        Return dt
                    End Using
                End Using
            End Using
        End Using
    End Function

End Class