Public Class Welcome
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim frmHelp As New HelpForm
        Me.Hide()
        frmHelp.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        Dim frmAcct As New Accounts
        Me.Hide()
        frmAcct.Show()
    End Sub

    Private Sub btnSupplies_Click(sender As Object, e As EventArgs) Handles btnSupplies.Click
        Dim frmSupp As New Supplies
        Me.Hide()
        frmSupp.Show()
    End Sub

    Private Sub btnListedProd_Click(sender As Object, e As EventArgs) Handles btnListedProd.Click
        Dim frmListPro As New ListedProducts
        Me.Hide()
        frmListPro.Show()

    End Sub
End Class