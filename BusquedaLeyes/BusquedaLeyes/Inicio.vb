Imports System.Data.SQLite


Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarConceptoBusqueda()
        CargarTooltips()
        CargarListaDocumento()
        btnAnadirLista.Enabled = False
        btnQuitarLista.Enabled = False

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwDocumentos.SelectedIndexChanged
        Dim documento As String
        documento = "Todos"
        If lvwDocumentos.SelectedItems.Count > 0 Then
            lblDocumentoVar.Text = lvwDocumentos.SelectedItems(0).SubItems(0).Text

            If "Constitución política de los Estados Unidos Mexicanos".Equals(
                    lvwDocumentos.SelectedItems(0).SubItems(0).Text) Then
                documento = "CON"
            End If
            If "Acuerdo para la modernización integral de la ind. azu.".Equals(
                   lvwDocumentos.SelectedItems(0).SubItems(0).Text) Then
                documento = "ACM"
            End If
            If "Contrato Ley".Equals(
                    lvwDocumentos.SelectedItems(0).SubItems(0).Text) Then
                documento = "COL"
            End If
            If "Ley federal del trabajo".Equals(
                lvwDocumentos.SelectedItems(0).SubItems(0).Text) Then
                documento = "LFT"
            End If
            If "Plan rector".Equals(
                lvwDocumentos.SelectedItems(0).SubItems(0).Text) Then
                documento = "PLR"
            End If
            If "Todos".Equals(
                lvwDocumentos.SelectedItems(0).SubItems(0).Text) Then
                CargarListaArticulosLeyes("Select noArticulo,id_leyes From DATOS")
            Else
                CargarListaArticulosLeyes("Select noArticulo,id_leyes From DATOS where documento = '" & documento & "'")
            End If
            lbxArticulos.ClearSelected()
        End If


        'MsgBox("Indice: '" & lvwDocumentos.SelectedIndices.Item(0) & "' Texto: '" & lvwDocumentos.SelectedItems(0).SubItems(0).Text)
    End Sub

    Public Sub CargarConceptoBusqueda()

        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        conn.Open()
        Dim sql As String = "Select * From CONCEPTOS_BUSQUEDAS"
        Dim da As New SQLiteDataAdapter(sql, conn)
        Dim t As New Data.DataTable

        da.Fill(t)
        conn.Close()

        lbxConcepto.ValueMember = "id_busquedas"
        lbxConcepto.DisplayMember = "concepto"
        lbxConcepto.DataSource = t
        lbxConcepto.SetSelected(0, True)


    End Sub

    Public Sub CargarListaDocumento()
        lvwDocumentos.Items.Clear()
        lvwDocumentos.Items.Add("Todos")
        lvwDocumentos.Items.Add("Acuerdo para la modernización integral de la ind. azu.")
        lvwDocumentos.Items.Add("Constitución política de los Estados Unidos Mexicanos")
        lvwDocumentos.Items.Add("Contrato Ley")
        lvwDocumentos.Items.Add("Ley federal del trabajo")
        lvwDocumentos.Items.Add("Plan rector")
    End Sub

    Public Sub CargarListaArticulosLeyes(sql As String)
        'MsgBox(sql)

        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        conn.Open()

        Dim da As New SQLiteDataAdapter(sql, conn)
        Dim t As New Data.DataTable

        da.Fill(t)
        conn.Close()
        'lbxArticulos.DisplayMember = Nothing
        'lbxArticulos.ValueMember = Nothing
        'lbxArticulos.DataSource = Nothing
        'lbxArticulos.Items.Clear()

        lbxArticulos.ValueMember = "id_leyes"
        lbxArticulos.DisplayMember = "noArticulo"
        lbxArticulos.DataSource = t
        'Pruebas
        'For Each row As DataRow In t.Rows
        ' If t.Rows.Count > 0 Then
        '    MsgBox(row("id_leyes"))
        'Next



    End Sub

    Public Sub CargarTooltips()

        Me.toolTipGeneral.IsBalloon = True
        'TOOLTIP CONCEPTO DE BUSQUEDA
        Me.toolTipGeneral.SetToolTip(lbxConcepto, "Selecciona un concepto de búsqueda")
        'TOOLTIP DOCUMENTO
        Me.toolTipGeneral.SetToolTip(lvwDocumentos, "Selecciona un documento")
        'ToolTip ARTICULO
        Me.toolTipGeneral.SetToolTip(lbxArticulos, "Selecciona un artículo o ley")

    End Sub

    Public Function isFormActive(_form As Form) As Boolean

        'RECIBE UN FORM Y CHECA SI YA SE ENCUENTRA ABIERTO. DEVUELVE BOOLEAN
        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Sub showFormActiveOrInactive(_form As Form)
        'FUNCION QUE RECIBE UN FORM QUE INTENTARÁ ABRIR EN CASO DE QUE ESTÉ CERRADO O MOSTRARLO SI YA ESTÁ ABIERTO
        If Not isFormActive(_form) Then
            _form.Show()
        Else
            _form.Focus()
        End If
    End Sub

    Private Sub lbxConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxConcepto.SelectedIndexChanged
        lblConceptoVar.Text = lbxConcepto.GetItemText(lbxConcepto.SelectedItem)
        'MsgBox(lbxConcepto.SelectedValue)
        'MsgBox("El id es: '" & lbxConcepto.SelectedIndex & "' Su valor es: '" & lbxConcepto.SelectedValue & "' y el texto es: " & lbxConcepto.GetItemText(lbxConcepto.SelectedItem))
    End Sub

    Private Sub VerListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListaToolStripMenuItem.Click
        showFormActiveOrInactive(Listap)
    End Sub


    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        'MÉNU AYUDA>ACERCA DE, ABRE EL FORM SI NO ESTA ABIERTO O CAMBIA EL FOCO A EL SI YA ESTA ABIERTO
        showFormActiveOrInactive(AcercaDe)

    End Sub


    Private Sub btnAnadirLista_Click(sender As Object, e As EventArgs) Handles btnAnadirLista.Click
        agregarQuitarLista(1, lbxArticulos.SelectedValue)
        habilitarDeshabilitarBTN(lbxArticulos.SelectedValue)
        'MsgBox(clbArticulos.CheckedItems.Item(0))
        'For Each itemChecked In clbArticulos.CheckedItems
        'MsgBox("Seleccionado el artículo: '" & itemChecked.ToString())
        'Next
    End Sub

    Private Sub btnQuitarLista_Click(sender As Object, e As EventArgs) Handles btnQuitarLista.Click
        agregarQuitarLista(0, lbxArticulos.SelectedValue)
        habilitarDeshabilitarBTN(lbxArticulos.SelectedValue)
    End Sub

    Private Sub lbxArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxArticulos.SelectedIndexChanged
        lblArticuloVar.Text = lbxArticulos.SelectedValue
        cargarContenido()
        habilitarDeshabilitarBTN(lbxArticulos.SelectedValue)

    End Sub

    Private Sub cargarContenido()

    End Sub
    Private Sub habilitarDeshabilitarBTN(id_leyes As Integer)
        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        conn.Open()
        Dim Sql = "Select bandera_Vista From DATOS where id_leyes = " & id_leyes
        Dim da As New SQLiteDataAdapter(Sql, conn)
        Dim t As New Data.DataTable
        da.Fill(t)
        conn.Close()
        For Each row As DataRow In t.Rows
            If (row("bandera_Vista") = 0) Then
                btnAnadirLista.Enabled = True
                btnQuitarLista.Enabled = False
            Else
                btnAnadirLista.Enabled = False
                btnQuitarLista.Enabled = True
            End If
        Next
    End Sub

    Private Sub agregarQuitarLista(bandera As Integer, id_leyes As Integer)
        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        Dim Sql = "UPDATE DATOS SET bandera_Vista = " & bandera & " WHERE id_leyes = " & id_leyes

        Dim Command = New SQLiteCommand(Sql, conn)
        conn.Open()
        Command.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub Inicio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If isFormActive(AcercaDe) Then
            showFormActiveOrInactive(AcercaDe)
        End If

        If isFormActive(Listap) Then
            showFormActiveOrInactive(Listap)
        End If
    End Sub
End Class