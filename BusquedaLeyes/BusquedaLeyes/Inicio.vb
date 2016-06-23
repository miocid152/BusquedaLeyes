﻿Imports System.Data.SQLite

Public Class Inicio
    Shared documento As String
    Shared concepto As String

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
        If lvwDocumentos.SelectedItems.Count > 0 Then lblDocumentoVar.Text = lvwDocumentos.SelectedItems(0).SubItems(0).Text
        'MsgBox("Indice: '" & lvwDocumentos.SelectedIndices.Item(0) & "' Texto: '" & lvwDocumentos.SelectedItems(0).SubItems(0).Text)
    End Sub

    Public Sub CargarConceptoBusqueda1()
        'Dim utf8 As New System.Text.UTF8Encoding()
        Dim utf8 As System.Text.Encoding = System.Text.Encoding.UTF8
        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.db; Version=3; UseUTF8Encoding=True;")
        conn.Open()
        Dim sql As String = "Select * From CONCEPTOS_BUSQUEDAS"
        Dim da As New SQLiteDataAdapter(sql, conn)
        Dim t As New Data.DataTable

        da.Fill(t)
        conn.Close()
        Dim texto As String = t.Rows(2).Item(1)
        'MsgBox(texto)
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
        lblConceptoVar.Text = lbxConcepto.GetItemText(lbxConcepto.SelectedItem)
        'MsgBox("El id es: '" & lbxConcepto.SelectedIndex & "' Su valor es: '" & lbxConcepto.SelectedValue & "' y el texto es: " & lbxConcepto.GetItemText(lbxConcepto.SelectedItem))
    End Sub

    Private Sub VerListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListaToolStripMenuItem.Click

    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        Dim acercaDe As New AcercaDe
        acercaDe.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnadirLista.Click
        'MsgBox(clbArticulos.CheckedItems.Item(0))
        For Each itemChecked In clbArticulos.CheckedItems
            MsgBox("Seleccionado el artículo: '" & itemChecked.ToString())
        Next
    End Sub
End Class