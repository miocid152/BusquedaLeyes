Imports System.Data.SQLite

Public Class Listap



    Public Sub CargarListaArticulosLeyes()
        'MsgBox(sql)

        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        conn.Open()
        Dim Sql = "Select noArticulo,id_leyes From DATOS where bandera_Vista = 1"
        Dim da As New SQLiteDataAdapter(Sql, conn)
        Dim t As New Data.DataTable

        da.Fill(t)
        conn.Close()

        lbxArticulosLista.ValueMember = "id_leyes"
        lbxArticulosLista.DisplayMember = "noArticulo"
        lbxArticulosLista.DataSource = t


    End Sub



    Private Sub Listap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaArticulosLeyes()
    End Sub


End Class