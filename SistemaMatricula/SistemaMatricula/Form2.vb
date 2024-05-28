Imports System.Data.OleDb
Public Class frmBuscar

    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim kaka As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=F:\PROGRAMACION\SISTEMA MATRICULA\BASE DE DATOS\Matricula.mdb")
        Try
            kaka.Open()
            MsgBox("Registro Encontrado", , "Buscar")

            Dim query = "Select * from ALUMNO where Nombre Like '" & txtBuscar.Text & "%'"
            Dim koko As New OleDbDataAdapter(query, kaka)
            Dim vs As New DataTable
            koko.Fill(vs)
            DataGridView1.DataSource = vs
        Catch ex As Exception
            MsgBox("No se encontro por: " & ex.Message)

        End Try
    End Sub

    Private Sub btnGrafica_Click(sender As Object, e As EventArgs) Handles btnGrafica.Click
        frmGrafica.Show()
    End Sub
End Class