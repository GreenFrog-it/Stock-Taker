Public Class Supplies

    Dim binding_source As New BindingSource()
    Dim data_table As New DataTable()
    Dim data_adapter As New SqlClient.SqlDataAdapter()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Me.DataGridView1.DataSource = Me.binding_source
        Me.DataGridView1.DataSource = binding_source
        Dim conString As String = My.Settings.SuppliesConnectionString
        Dim con As New SqlClient.SqlConnection(conString)

        con.Open()
        MessageBox.Show("Connection Opened")
        data_adapter = New SqlClient.SqlDataAdapter("SELECT * FROM tbl_Supplies", con)
        Dim cb As New SqlClient.SqlCommandBuilder(data_adapter)

        data_adapter.Fill(data_table)
        binding_source.DataSource = data_table

        con.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.data_adapter.Update(CType(Me.binding_source.DataSource, DataTable))
        MessageBox.Show("Table data updated")
    End Sub
End Class