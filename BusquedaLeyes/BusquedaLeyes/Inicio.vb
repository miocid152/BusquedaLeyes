Imports System.Data.SQLite


Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarConceptoBusqueda()
        CargarTooltips()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwDocumentos.SelectedIndexChanged
        If lvwDocumentos.SelectedItems.Count > 0 Then lblDocumentoVar.Text = lvwDocumentos.SelectedItems(0).SubItems(0).Text
        'MsgBox("Indice: '" & lvwDocumentos.SelectedIndices.Item(0) & "' Texto: '" & lvwDocumentos.SelectedItems(0).SubItems(0).Text)
    End Sub

    Public Sub CargarConceptoBusqueda()

        Dim utf8 As System.Text.Encoding = System.Text.Encoding.UTF8
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

    Public Sub CargarTooltips()

        Me.toolTipGeneral.IsBalloon = True
        'TOOLTIP CONCEPTO DE BUSQUEDA
        Me.toolTipGeneral.SetToolTip(lbxConcepto, "Selecciona un concepto de búsqueda")
        'TOOLTIP DOCUMENTO
        Me.toolTipGeneral.SetToolTip(lvwDocumentos, "Selecciona un documento")
        'TOOLTIP ARTICULO
        Me.toolTipGeneral.SetToolTip(clbArticulos, "Selecciona un artículo o ley")

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
        'MsgBox("El id es: '" & lbxConcepto.SelectedIndex & "' Su valor es: '" & lbxConcepto.SelectedValue & "' y el texto es: " & lbxConcepto.GetItemText(lbxConcepto.SelectedItem))
    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        'MÉNU AYUDA>ACERCA DE, ABRE EL FORM SI NO ESTA ABIERTO O CAMBIA EL FOCO A EL SI YA ESTA ABIERTO
        showFormActiveOrInactive(AcercaDe)
    End Sub

    Private Sub btnAnadirLista_Click(sender As Object, e As EventArgs) Handles btnAnadirLista.Click
        'MsgBox(clbArticulos.CheckedItems.Item(0))
        For Each itemChecked In clbArticulos.CheckedItems
            MsgBox("Seleccionado el artículo: '" & itemChecked.ToString())
        Next
    End Sub

    Private Sub clbArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbArticulos.SelectedIndexChanged
        lblArticuloVar.Text = clbArticulos.SelectedItem.ToString()
    End Sub
End Class