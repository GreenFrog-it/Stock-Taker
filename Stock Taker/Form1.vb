Public Class Form1
    Private Sub Sheet1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Sheet1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Sheet1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductsDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductsDataSet.Sheet1' table. You can move, or remove it, as needed.
        Me.Sheet1TableAdapter.Fill(Me.ProductsDataSet.Sheet1)

    End Sub

    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        Dim conn As New OleDb.OleDbConnection 'The Connection Object
        Dim dbProvider As String              'Holds The Provider
        Dim dbSource As String                'Holds the Data Source  
        Dim MyDocumentsFolder As String       'Holds the Documents Folder  
        Dim TheDatabase As String             'Holds the Database Name  
        Dim FullDatabasePath As String        'Holds the Database Path
        Dim ds As New DataSet                 'Holds the DataSet Object
        Dim da As OleDb.OleDbDataAdapter      'Holds the DataAdapter Object
        Dim sql As String                     'Holds a SQL String

        'Set Up The Provider
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        'Set the Database and where the database is
        TheDatabase = "/Products.mdb"
        MyDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        FullDatabasePath = MyDocumentsFolder & TheDatabase
        'Set The Datasource
        dbSource = "Data Source=" & FullDatabasePath
        'Set the Connection String
        conn.ConnectionString = dbProvider & dbSource
        'Open The Database
        conn.Open()

        'Store the SQL String
        sql = "SELECT * FROM tblProducts"
        'Pass the SQL String And Connection Object to the Data_Adapter
        da = New OleDb.OleDbDataAdapter(sql, conn)
        MessageBox.Show("Database is now open")
        'Close the Database
        conn.Close()
        MessageBox.Show("Database is now close")


    End Sub
End Class
