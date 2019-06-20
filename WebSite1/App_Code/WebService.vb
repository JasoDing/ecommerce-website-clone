Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data
Imports System.Configuration
Imports PubClass
Imports System.Data.SqlClient
' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
'<System.Web.Script.Services.ScriptService()> _


<WebService(Namespace:="http://tempuri.org/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<System.Web.Script.Services.ScriptService()>
Public Class WebService
    Inherits System.Web.Services.WebService

    'Public Function UserInfo() As DataTable
    '    Dim constr As String = ConfigurationManager.ConnectionStrings("userLogin").ConnectionString
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("SELECT * FROM Users")
    '            Using sda As New SqlDataAdapter()
    '                cmd.Connection = con
    '                sda.SelectCommand = cmd
    '                Using dt As New DataTable()
    '                    dt.TableName = "Users"
    '                    sda.Fill(dt)
    '                    Return dt
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Function

    <WebMethod(Description:="get info")>
    Public Function get_User_Profile(ByVal person_id As String, ByVal username As String, ByVal password As String, ByVal last_name As String, ByVal first_name As String, ByVal email As String, ByVal address As String, ByVal city As String, ByVal errormsg As String) As List(Of user_profile)

        Dim User_Profile As List(Of user_profile) = New List(Of user_profile)

        Dim user As user_profile = New user_profile

        Dim SQLstr As String = ""

        SQLstr = "SELECT * FROM Users"
        Dim user_id As String = ""
        Dim user_username As String = ""
        Dim user_password As String = ""
        Dim user_last_name As String = ""
        Dim user_first_name As String = ""
        Dim user_email As String = ""
        Dim user_address As String = ""
        Dim user_city As String = ""


        SelectMultipleBySQL(SQLstr, "userLogin", 8, user_id, user_username, user_password, user_last_name, user_first_name, user_email, user_address, user_city)

        Dim user_info As New user_profile
        user_info.person_id = user_id
        user_info.username = user_username
        user_info.password = user_password
        user_info.last_name = user_last_name
        user_info.first_name = user_first_name
        user_info.email_address = user_email
        user_info.address = user_address
        user_info.city = user_city

        User_Profile.Add(user_info)

        Return User_Profile



    End Function

    <WebMethod(Description:="update info")>
    Public Function update_User_Profile(ByVal person_id As String, ByVal username As String, ByVal password As String, ByVal last_name As String, ByVal first_name As String, ByVal email As String, ByVal address As String, ByVal city As String, ByVal errormsg As String) As List(Of user_profile)

    End Function
    Public Shared Sub ASPNET_MsgBoxAlert(ByVal Message As String)

        System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & vbCrLf)

        System.Web.HttpContext.Current.Response.Write("alert(""" & Message & """)" & vbCrLf)

        System.Web.HttpContext.Current.Response.Write("</SCRIPT>")

    End Sub

    Public Shared Sub SelectMultipleBySQL(ByVal SQLStr As String, ByVal ConnStr As String, ByVal ParaCount As Integer, Optional ByRef Rtn1 As String = "", Optional ByRef Rtn2 As String = "", Optional ByRef Rtn3 As String = "", Optional ByRef Rtn4 As String = "", Optional ByRef Rtn5 As String = "", Optional ByRef Rtn6 As String = "", Optional ByRef Rtn7 As String = "", Optional ByRef Rtn8 As String = "", Optional ByRef Rtn9 As String = "", Optional ByRef Rtn10 As String = "", Optional ByRef Rtn11 As String = "", Optional ByRef Rtn12 As String = "", Optional ByRef Rtn13 As String = "", Optional ByRef Rtn14 As String = "", Optional ByRef Rtn15 As String = "", Optional ByRef Rtn16 As String = "", Optional ByRef Rtn17 As String = "", Optional ByRef Rtn18 As String = "", Optional ByRef Rtn19 As String = "", Optional ByRef Rtn20 As String = "", Optional ByRef Rtn21 As String = "", Optional ByRef Rtn22 As String = "", Optional ByRef Rtn23 As String = "", Optional ByRef Rtn24 As String = "", Optional ByRef Rtn25 As String = "")

        Dim rootWebConfig As System.Configuration.Configuration
        Dim RtnVal As String = ""
        SQLStr = SQLStr.Replace("--", "")
        'If SQLStr.Contains("--") Then
        '    Exit Sub
        'End If

        rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/")

        If (0 < rootWebConfig.ConnectionStrings.ConnectionStrings.Count) Then
            Dim connString As System.Configuration.ConnectionStringSettings
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings(ConnStr)

            Using connection As New SqlConnection(connString.ConnectionString)
                connection.Open()
                Dim command As New SqlCommand(SQLStr, connection)
                command.CommandTimeout = 100
                Try
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim i As Integer = 1
                        Rtn1 = IIf(reader(0) Is DBNull.Value, "", reader(0))
                        i += 1
                        If i <= ParaCount Then Rtn2 = IIf(reader(1) Is DBNull.Value, "", reader(1))
                        i += 1
                        If i <= ParaCount Then Rtn3 = IIf(reader(2) Is DBNull.Value, "", reader(2))
                        i += 1
                        If i <= ParaCount Then Rtn4 = IIf(reader(3) Is DBNull.Value, "", reader(3))
                        i += 1
                        If i <= ParaCount Then Rtn5 = IIf(reader(4) Is DBNull.Value, "", reader(4))
                        i += 1
                        If i <= ParaCount Then Rtn6 = IIf(reader(5) Is DBNull.Value, "", reader(5))
                        i += 1
                        If i <= ParaCount Then Rtn7 = IIf(reader(6) Is DBNull.Value, "", reader(6))
                        i += 1
                        If i <= ParaCount Then Rtn8 = IIf(reader(7) Is DBNull.Value, "", reader(7))
                        i += 1
                        If i <= ParaCount Then Rtn9 = IIf(reader(8) Is DBNull.Value, "", reader(8))
                        i += 1
                        If i <= ParaCount Then Rtn10 = IIf(reader(9) Is DBNull.Value, "", reader(9))
                        i += 1
                        If i <= ParaCount Then Rtn11 = IIf(reader(10) Is DBNull.Value, "", reader(10))
                        i += 1
                        If i <= ParaCount Then Rtn12 = IIf(reader(11) Is DBNull.Value, "", reader(11))
                        i += 1
                        If i <= ParaCount Then Rtn13 = IIf(reader(12) Is DBNull.Value, "", reader(12))
                        i += 1
                        If i <= ParaCount Then Rtn14 = IIf(reader(13) Is DBNull.Value, "", reader(13))
                        i += 1
                        If i <= ParaCount Then Rtn15 = IIf(reader(14) Is DBNull.Value, "", reader(14))
                        i += 1
                        If i <= ParaCount Then Rtn16 = IIf(reader(15) Is DBNull.Value, "", reader(15))
                        i += 1
                        If i <= ParaCount Then Rtn17 = IIf(reader(16) Is DBNull.Value, "", reader(16))
                        i += 1
                        If i <= ParaCount Then Rtn18 = IIf(reader(17) Is DBNull.Value, "", reader(17))
                        i += 1
                        If i <= ParaCount Then Rtn19 = IIf(reader(18) Is DBNull.Value, "", reader(18))
                        i += 1
                        If i <= ParaCount Then Rtn20 = IIf(reader(19) Is DBNull.Value, "", reader(19))
                        i += 1
                        If i <= ParaCount Then Rtn21 = IIf(reader(20) Is DBNull.Value, "", reader(20))
                        i += 1
                        If i <= ParaCount Then Rtn22 = IIf(reader(21) Is DBNull.Value, "", reader(21))
                        i += 1
                        If i <= ParaCount Then Rtn23 = IIf(reader(22) Is DBNull.Value, "", reader(22))
                        i += 1
                        If i <= ParaCount Then Rtn24 = IIf(reader(23) Is DBNull.Value, "", reader(23))
                        i += 1
                        If i <= ParaCount Then Rtn25 = IIf(reader(24) Is DBNull.Value, "", reader(24))
                    End If
                    reader.Close()
                Catch except As Exception
                    ASPNET_MsgBoxAlert(except.Message)
                End Try
            End Using

        End If

    End Sub
End Class