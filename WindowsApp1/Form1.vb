Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.Database1DataSet.Customers)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUnos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub CustomersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomersDataGridView.CellContentClick

    End Sub

    Private Sub UcenikID_TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtUcenik.TextChanged

    End Sub

    Private Sub ImeTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtIme.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonUnos.Click
        If (txtIme.Text) Then





    End Sub

    Private Sub ButtonBrisanje_Click(sender As Object, e As EventArgs) Handles ButtonBrisanje.Click

    End Sub

    Private Sub ButtonIzmjena_Click(sender As Object, e As EventArgs) Handles ButtonIzmjena.Click

    End Sub
End Class
