﻿Imports System.Data.SQLite


Public Class Inicio



    Public Shared llave As String


    'Inicio de carga de funciones
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modoParametros()
        CargarConceptoBusqueda()
        CargarTooltips()
        CargarListaDocumento()
        btnAnadirLista.Enabled = False
        btnQuitarLista.Enabled = False


    End Sub

    'metodo para leer parametros al iniciar
    Private Sub modoParametros()
        Dim argumento As String
        If Environment.GetCommandLineArgs.Length > 1 Then
            argumento = Environment.GetCommandLineArgs(1)
            Dim list As IList(Of String) = New List(Of String)(argumento.Split(New String() {"|"}, StringSplitOptions.None))

            If list.Count > 2 Then
                If Not (list.Item(0).ToString.Equals("ejecutar") And
                    list.Item(1).ToString.Equals(DateTime.Now.ToString("dd/MM/yyyy")) And
                     list.Item(2).ToString.Equals("ON")) Then
                    Me.Close()
                End If
                llave = list.Item(3) & "|" &
                        list.Item(4) & "|" &
                        list.Item(5) & "|" &
                        list.Item(6)
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub

    'menu salir
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Carga de articulos para la Seleccion de documento
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
                If lbxConcepto.SelectedValue = 1 Then
                    CargarListaArticulosLeyes(1, "Select id_leyes,noArticulo,documento From DATOS")
                Else
                    CargarListaArticulosLeyes(1, "Select id_leyes,noArticulo,documento From DATOS where id_leyes in (select FK_id_leyes from DATOS_CONCEPTOBUSQUEDA where FK_id_busqueda = " & lbxConcepto.SelectedValue & ")")
                End If
            Else
                If lbxConcepto.SelectedValue = 1 Then
                    CargarListaArticulosLeyes(0, "Select id_leyes,noArticulo,documento From DATOS where documento = '" & documento & "'")
                Else
                    CargarListaArticulosLeyes(0, "Select id_leyes,noArticulo,documento From DATOS where documento = '" & documento & "' and id_leyes in (select FK_id_leyes from DATOS_CONCEPTOBUSQUEDA where FK_id_busqueda = " & lbxConcepto.SelectedValue & ")")
                End If
            End If
            lbxArticulos.ClearSelected()
        End If
        changeselectedItemcolour()
    End Sub

    'Cambio de colores para la seleccion de listview
    Public Sub changeselectedItemcolour()
        Try
            'Get currently selected items index value
            Dim i = lvwDocumentos.Items.Item(lvwDocumentos.SelectedIndices(0)).Index

            Dim k As Integer = 0

            'loop entire list and reset colors
            While k <= lvwDocumentos.Items.Count - 1
                'lvwDocumentos.Items(k).BackColor = Color.Transparent 'Color.FromArgb(40, 40, 40)
                lvwDocumentos.Items(k).ForeColor = Color.Black 'Color.LightGray
                k = k + 1
                lvwDocumentos.Items(i).ForeColor = Color.White
            End While

            'set the selected items color
            Try
                'lvwDocumentos.Items(i).BackColor = Color.Blue 'SystemColors.Highlight
                'lvwDocumentos.Items(i).ForeColor = Color.Blue
                'lvwDocumentos.Items(i).Focused = True
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try

    End Sub


    'Carga la lista de concepto busqueda
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

    'Meotodo que cargala listade los documentos
    Public Sub CargarListaDocumento()
        lvwDocumentos.Items.Clear()
        lvwDocumentos.Items.Add("Constitución política de los Estados Unidos Mexicanos")
        lvwDocumentos.Items.Add("Ley federal del trabajo")
        lvwDocumentos.Items.Add("Contrato Ley")
        lvwDocumentos.Items.Add("Acuerdo para la modernización integral de la ind. azu.")
        lvwDocumentos.Items.Add("Plan rector")
        lvwDocumentos.Items.Add("Todos")
        'lvwDocumentos.Sort("ASD")
    End Sub


    'Metodo que es llamado por  Carga de articulos para la Seleccion de documento para generar la lista de articulos
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
                If banTodos = 1 Then
                    _dt.Rows.Add({row("id_leyes"), acronimos(row("documento")) & "   " & row("noArticulo")})
                Else
                    _dt.Rows.Add({row("id_leyes"), row("noArticulo")})
                End If
            End If
        Next

        _dt.DefaultView.Sort = "nombreArticulo ASC"
        conn.Close()

        lbxArticulos.ValueMember = "id_leyes"
        lbxArticulos.DisplayMember = "nombreArticulo"
        lbxArticulos.DataSource = _dt


    End Sub

    'Metodo para cargar acronimo cuano se selcciona Todos en la lista documentos
    Private Function acronimos(acronimo As String) As String
        Dim retorno As String
        retorno = " "
        If acronimo.Equals("CON") Then
            retorno = "CONST"
        End If
        If acronimo.Equals("ACM") Then
            retorno = "ACMOD"
        End If
        If acronimo.Equals("COL") Then
            retorno = "CL"
        End If
        If acronimo.Equals("LFT") Then
            retorno = "LFT"
        End If
        If acronimo.Equals("PLR") Then
            retorno = "PLANR"
        End If
        Return retorno
    End Function

    'Metodo para cargar los de tips a cada lista
    Public Sub CargarTooltips()
        Me.toolTipGeneral.IsBalloon = True
        'TOOLTIP CONCEPTO DE BUSQUEDA
        Me.toolTipGeneral.SetToolTip(lbxConcepto, "Selecciona un concepto de búsqueda")
        'TOOLTIP DOCUMENTO
        Me.toolTipGeneral.SetToolTip(lvwDocumentos, "Selecciona un documento")
        'ToolTip ARTICULO
        Me.toolTipGeneral.SetToolTip(lbxArticulos, "Selecciona un artículo o ley")

    End Sub

    'Metodo para verificar la existencia de la ventana abierta en cualquier formulario diferente al inicial
    Public Function isFormActive(_form As Form) As Boolean
        'RECIBE UN FORM Y CHECA SI YA SE ENCUENTRA ABIERTO. DEVUELVE BOOLEAN
        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return True
            End If
        Next

        Return False

    End Function
    'Carga la ventana de cualquier formulario diferent al inical
    Public Sub showFormActiveOrInactive(_form As Form)
        'FUNCION QUE RECIBE UN FORM QUE INTENTARÁ ABRIR EN CASO DE QUE ESTÉ CERRADO O MOSTRARLO SI YA ESTÁ ABIERTO
        If Not isFormActive(_form) Then
            _form.Show()
        Else
            _form.Focus()
        End If
    End Sub

    'Metodo para cargar articulos por concepto por libro, este metodo llama al metodo  Carga de articulos para la Seleccion de documento
    Private Sub lbxConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxConcepto.SelectedIndexChanged
        lblConceptoVar.Text = lbxConcepto.GetItemText(lbxConcepto.SelectedItem)
        Me.ListView1_SelectedIndexChanged(sender, e)
        'MsgBox(lbxConcepto.SelectedValue)
        'MsgBox("El id es: '" & lbxConcepto.SelectedIndex & "' Su valor es: '" & lbxConcepto.SelectedValue & "' y el texto es: " & lbxConcepto.GetItemText(lbxConcepto.SelectedItem))
    End Sub

    'Cargala ventana de MiLista
    Private Sub VerListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListaToolStripMenuItem.Click
        showFormActiveOrInactive(Listap)
    End Sub

    'MÉNU AYUDA>ACERCA DE, ABRE EL FORM SI NO ESTA ABIERTO O CAMBIA EL FOCO A EL SI YA ESTA ABIERTO
    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        showFormActiveOrInactive(AcercaDe)
    End Sub

    'Metodo ejecutado por el boton añadir lista, añade el articulo a mi lista activando la bandera
    Private Sub btnAnadirLista_Click(sender As Object, e As EventArgs) Handles btnAnadirLista.Click
        agregarQuitarLista(1, lbxArticulos.SelectedValue)
        habilitarDeshabilitarBTN(lbxArticulos.SelectedValue)
        'MsgBox(clbArticulos.CheckedItems.Item(0))
        'For Each itemChecked In clbArticulos.CheckedItems
        'MsgBox("Seleccionado el artículo: '" & itemChecked.ToString())
        'Next
    End Sub

    'Metodo ejecutado por el boton quitar de la lista, quita el articulo de mi lista desactivado la bandera
    Private Sub btnQuitarLista_Click(sender As Object, e As EventArgs) Handles btnQuitarLista.Click
        agregarQuitarLista(0, lbxArticulos.SelectedValue)
        habilitarDeshabilitarBTN(lbxArticulos.SelectedValue)
    End Sub

    'Metodo que muestra el artiulo eleccionado en el label
    Private Sub lbxArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxArticulos.SelectedIndexChanged
        lblArticuloVar.Text = lbxArticulos.GetItemText(lbxArticulos.SelectedItem)
        If lblArticuloVar.Text.Equals("") Then
            lblArticuloVar.Text = "Ninguno"
        End If
        cargarContenido(lbxArticulos.SelectedValue)
        habilitarDeshabilitarBTN(lbxArticulos.SelectedValue)

    End Sub

    'Metodo que carga el contenido del articulo seleccionado
    Private Sub cargarContenido(id_leyes As Integer)
        Dim Sql = "Select FK_id_leyes,contenido From ContenidoDatos where FK_id_leyes = " & id_leyes
        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        conn.Open()

        Dim da As New SQLiteDataAdapter(Sql, conn)
        Dim t As New Data.DataTable
        da.Fill(t)
        conn.Close()
        txbArticuloTexto.ResetText()
        For Each row As DataRow In t.Rows
            txbArticuloTexto.Rtf = (row("contenido"))
        Next
    End Sub

    'Metodo que habilita o deshabilita los botones de añadir o quitar de mi lista segun la bandera del articulo
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
    'Metodo que elimina o agrega la bandera al articulo para mi lista
    Private Sub agregarQuitarLista(bandera As Integer, id_leyes As Integer)
        Dim conn As New SQLiteConnection("Data Source=busquedaLCM.sqlite; Version=3; UseUTF8Encoding=True;")
        Dim Sql = "UPDATE DATOS SET bandera_Vista = " & bandera & " WHERE id_leyes = " & id_leyes

        Dim Command = New SQLiteCommand(Sql, conn)
        conn.Open()
        Command.ExecuteNonQuery()
        conn.Close()
    End Sub

    'Metoo para no quitar el focus  de la ventana abierta
    Private Sub Inicio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If isFormActive(AcercaDe) Then
            showFormActiveOrInactive(AcercaDe)
        End If

        If isFormActive(Listap) Then
            showFormActiveOrInactive(Listap)
        End If
    End Sub



End Class