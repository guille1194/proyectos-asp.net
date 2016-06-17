Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Partial Class VB
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindListView()
        End If
    End Sub

    Private Sub BindListView()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                cmd.CommandText = "SELECT CustomerId, ContactName, Country FROM Customers"
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    lvCustomers.DataSource = dt
                    lvCustomers.DataBind()
                End Using
            End Using
        End Using
    End Sub

    Protected Sub OnPagePropertiesChanging(sender As Object, e As PagePropertiesChangingEventArgs)
        TryCast(lvCustomers.FindControl("DataPager1"), DataPager).SetPageProperties(e.StartRowIndex, e.MaximumRows, False)
        Me.BindListView()
    End Sub
End Class

