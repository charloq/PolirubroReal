Public Class frmCargarCliente
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Me.ClientesTableAdapter.Insert(NombreTextBox.Text, DomicilioTextBox.Text, TelefonoTextBox.Text)
            Console.WriteLine(Me.ClientesTableAdapter.GetData.Rows.Count)
            MessageBox.Show("Se ha cargado un nuevo Cliente", "Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ClientesTableAdapter.Fill(Me.PolirubroRealDBDataSet1.Clientes)
        Catch

        End Try
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PolirubroRealDBDataSet1)

    End Sub

    Private Sub frmCargarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PolirubroRealDBDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.PolirubroRealDBDataSet1.Clientes)

    End Sub
End Class