Public Class ListedProducts

    Dim binding_source As New BindingSource()
    Dim data_table As New DataTable()
    Dim data_adapter As New SqlClient.SqlDataAdapter()

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Me.DataGridView1.DataSource = Me.binding_source

        Dim conString As String = My.Settings.ListedStockConnectionString

        Dim con As New SqlClient.SqlConnection(conString)

        con.Open()

        MessageBox.Show("Connection Opened")

        data_adapter = New SqlClient.SqlDataAdapter("SELECT * FROM tbl_ListedProdcuts", con)

        Dim cb As New SqlClient.SqlCommandBuilder(data_adapter)
        data_adapter.Fill(data_table)
        binding_source.DataSource = data_table
        con.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.data_adapter.Update(CType(Me.binding_source.DataSource, DataTable))

        MessageBox.Show("Database Updated")
    End Sub

    Private Sub btnSupplies_Click(sender As Object, e As EventArgs) Handles btnSupplies.Click
        Me.Hide()
        Supplies.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Welcome.Show()
    End Sub
End Class