Imports System.Data.SqlClient

Public Class Form1

    Public Sub CargaDataProcedure(Instruccion, Tabla, DataGridView)
        Dim oda As New SqlDataAdapter
        Dim ods As New DataSet
        Dim datos As String
        Dim query As String

        datos = ""

        If Len(datos) = 0 Then
            query = Instruccion
            oda = New SqlDataAdapter(query, conn)  'Ejecutar la query (consulta) en la BD a la que apunta conn
            ods.Tables.Add(Tabla)         'Generar tabla en memoria
            oda.Fill(ods.Tables(Tabla))   'Poblar tabla
            DataGridView.DataSource = ods.Tables(Tabla)
            DataGridView.Visible = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()

        CargaDataProcedure("EXECUTE MostrarDepositos", "Deposito", DGV_Depositos)
    End Sub

End Class
