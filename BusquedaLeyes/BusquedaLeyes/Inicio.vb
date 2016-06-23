Imports System.Data.SQLite

Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarConceptoBusqueda1()


    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwDocumentos.SelectedIndexChanged

    End Sub

    Public Sub CargarConceptoBusqueda1()
        Dim utf8 As New System.Text.UTF8Encoding()

        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.db; Version=3; UTF8Encoding=True;")
        conn.Open()
        Dim sql As String = "Select * From CONCEPTOS_BUSQUEDAS"
        Dim da As New SQLiteDataAdapter(sql, conn)
        Dim t As New Data.DataTable

        da.Fill(t)
        conn.Close()
        'MsgBox(t.Rows(2).Item(1))
        lbxConcepto.ValueMember = "id_busquedas"
        lbxConcepto.DisplayMember = "concepto"
        lbxConcepto.DataSource = t
    End Sub

    Public Sub CargarConceptoBusqueda()
        Dim connectionString As String = "Data Source=busquedaLCM.db; Version=3; UTF8Encoding=True;"
        Dim mSQL As String = "Select * From CONCEPTOS_BUSQUEDAS"
        Dim dt As DataTable = Nothing
        Dim ds As New DataSet
        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(mSQL, con)
                    con.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(ds)
                        dt = ds.Tables(0)
                    End Using

                End Using
                con.Close()
            End Using
            lbxConcepto.Items.Clear()
            lbxConcepto.ValueMember = "id_busquedas"
            lbxConcepto.DisplayMember = "concepto"
            lbxConcepto.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub lbxConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxConcepto.SelectedIndexChanged
        'MsgBox(lbxConcepto.SelectedIndex)
        'MsgBox(lbxConcepto.SelectedValue)
        'MsgBox(lbxConcepto.GetItemText(lbxConcepto.SelectedItem))

    End Sub
End Class
