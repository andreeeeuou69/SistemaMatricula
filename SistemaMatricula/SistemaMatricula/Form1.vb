Imports System.Data.OleDb

Public Class Form1
    Private Sub btnConexion_Click(sender As Object, e As EventArgs) Handles btnConexion.Click
        Dim kaka As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=F:\PROGRAMACION\SISTEMA MATRICULA\BASE DE DATOS\Matricula.mdb")
        Try
            kaka.Open()
            MsgBox("Conectado")

            Dim query = "Select * from ALUMNO"
            Dim koko As New OleDbDataAdapter(query, kaka)
            Dim vs As New DataTable
            koko.Fill(vs)
            DataGridView1.DataSource = vs
        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscar.Show()
    End Sub
End Class