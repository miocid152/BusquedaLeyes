Imports System.Data.SQLite

Public Class Listap
    Dim indexDocumento As Integer


    Public Sub CargarListaArticulosLeyes(banTodos As Integer, sql As String)
        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        conn.Open()
        Dim da As New SQLiteDataAdapter(sql, conn)
        Dim t As New Data.DataTable
        Dim _dt = New Data.DataTable
        With _dt.Columns
            .Add("id_leyes")
            .Add("nombreArticulo")
        End With
        da.Fill(t)


        For Each row As DataRow In t.Rows
            If t.Rows.Count > 0 Then
                '
                If banTodos = 1 Then
                    _dt.Rows.Add({row("id_leyes"), row("documento") & "   " & row("noArticulo")})
                Else
                    _dt.Rows.Add({row("id_leyes"), row("noArticulo")})
                End If
            End If
        Next
        _dt.DefaultView.Sort = "nombreArticulo ASC"

        conn.Close()

        '-----------------------Bueno
        lbxArticulosLista.ValueMember = "id_leyes"
        lbxArticulosLista.DisplayMember = "nombreArticulo"
        lbxArticulosLista.DataSource = _dt


    End Sub



    Private Sub Listap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarListaDocumento()
    End Sub

    Private Sub CargarListaDocumento()
        cbxListaDocumento.Items.Clear()
        cbxListaDocumento.Items.Add("Todos")
        cbxListaDocumento.Items.Add("Acuerdo para la modernización integral de la ind. azu.")
        cbxListaDocumento.Items.Add("Constitución política de los Estados Unidos Mexicanos")
        cbxListaDocumento.Items.Add("Contrato Ley")
        cbxListaDocumento.Items.Add("Ley federal del trabajo")
        cbxListaDocumento.Items.Add("Plan rector")

        indexDocumento = 0
        cbxListaDocumento.SelectedIndex = indexDocumento
    End Sub

    Private Sub cbxListaDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxListaDocumento.SelectedIndexChanged
        indexDocumento = cbxListaDocumento.SelectedIndex
        Dim documento As String
        documento = "Todos"


        If "Constitución política de los Estados Unidos Mexicanos".Equals(
                cbxListaDocumento.SelectedItem.ToString) Then
            documento = "CON"
        End If
        If "Acuerdo para la modernización integral de la ind. azu.".Equals(
                cbxListaDocumento.SelectedItem.ToString) Then
            documento = "ACM"
        End If
        If "Contrato Ley".Equals(
                    cbxListaDocumento.SelectedItem.ToString) Then
            documento = "COL"
        End If
        If "Ley federal del trabajo".Equals(
                cbxListaDocumento.SelectedItem.ToString) Then
            documento = "LFT"
        End If
        If "Plan rector".Equals(
                cbxListaDocumento.SelectedItem.ToString) Then
            documento = "PLR"
        End If

        If "Todos".Equals(
                cbxListaDocumento.SelectedItem.ToString) Then
            'If lbxConcepto.SelectedValue = 1 Then
            CargarListaArticulosLeyes(1, "Select id_leyes,noArticulo,documento From DATOS WHERE bandera_Vista=1")
            'Else
            'CargarListaArticulosLeyes(1, "Select id_leyes,noArticulo,documento From DATOS where id_leyes in (select FK_id_leyes from DATOS_CONCEPTOBUSQUEDA where FK_id_busqueda = " & lbxConcepto.SelectedValue & ")")
            'End If
        Else
            'If lbxConcepto.SelectedValue = 1 Then
            CargarListaArticulosLeyes(0, "Select id_leyes,noArticulo,documento From DATOS where documento = '" & documento & "' and bandera_Vista=1")
            'Else
            'CargarListaArticulosLeyes(0, "Select id_leyes,noArticulo,documento From DATOS where documento = '" & documento & "' and id_leyes in (select FK_id_leyes from DATOS_CONCEPTOBUSQUEDA where FK_id_busqueda = " & lbxConcepto.SelectedValue & ")")
            'End If

        End If
            lbxArticulosLista.ClearSelected()
        'End If
    End Sub

    Private Sub lbxArticulosLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxArticulosLista.SelectedIndexChanged

        cargarContenido(lbxArticulosLista.SelectedValue)
    End Sub

    Private Sub cargarContenido(id_leyes As Integer)
        Dim Sql = "Select FK_id_leyes,contenido From ContenidoDatos where FK_id_leyes = " & id_leyes
        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        conn.Open()

        Dim da As New SQLiteDataAdapter(Sql, conn)
        Dim t As New Data.DataTable
        da.Fill(t)
        conn.Close()
        txbArticuloTextoLista.ResetText()
        For Each row As DataRow In t.Rows
            txbArticuloTextoLista.Rtf = (row("contenido"))
        Next


        'MsgBox("SALIO")
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        agregarQuitarLista(0, lbxArticulosLista.SelectedValue)
        cbxListaDocumento_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub agregarQuitarLista(bandera As Integer, id_leyes As Integer)
        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        Dim Sql = "UPDATE DATOS SET bandera_Vista = " & bandera & " WHERE id_leyes = " & id_leyes

        Dim Command = New SQLiteCommand(Sql, conn)
        conn.Open()
        Command.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub cbxListaDocumento_TextChanged(sender As Object, e As EventArgs) Handles cbxListaDocumento.TextChanged
        If Not cbxListaDocumento.FindString(cbxListaDocumento.Text) >= 0 Then
            cbxListaDocumento.SelectedIndex = indexDocumento
        End If
    End Sub
End Class