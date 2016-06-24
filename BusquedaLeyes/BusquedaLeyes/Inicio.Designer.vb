<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Acuerdo para la modernización integral de la ind. azu.")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Constitución política de los Estados Unidos Mexicanos")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Contrato Ley")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Ley federal del trabajo")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Plan rector")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Todos")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.lvwDocumentos = New System.Windows.Forms.ListView()
        Me.lbxConcepto = New System.Windows.Forms.ListBox()
        Me.clbArticulos = New System.Windows.Forms.CheckedListBox()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblArticulosTitulo = New System.Windows.Forms.Label()
        Me.txbArticuloTexto = New System.Windows.Forms.TextBox()
        Me.btnAnadirLista = New System.Windows.Forms.Button()
        Me.lblDocumentoTitulo = New System.Windows.Forms.Label()
        Me.lblDocumentoVar = New System.Windows.Forms.Label()
        Me.lblConceptoBusqueda = New System.Windows.Forms.Label()
        Me.lblConceptoVar = New System.Windows.Forms.Label()
        Me.toolTipGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblArticuloTitulo = New System.Windows.Forms.Label()
        Me.lblArticuloVar = New System.Windows.Forms.Label()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerListaToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Mi Lista"
        '
        'VerListaToolStripMenuItem
        '
        Me.VerListaToolStripMenuItem.Name = "VerListaToolStripMenuItem"
        Me.VerListaToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.VerListaToolStripMenuItem.Text = "&Ver lista"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerManualToolStripMenuItem, Me.AcercaDeToolStripMenuItem1})
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem1.Text = "A&yuda"
        '
        'VerManualToolStripMenuItem
        '
        Me.VerManualToolStripMenuItem.Name = "VerManualToolStripMenuItem"
        Me.VerManualToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VerManualToolStripMenuItem.Text = "Ver &Manual"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem1.Text = "A&cerca de..."
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem1})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuPrincipal.Size = New System.Drawing.Size(931, 24)
        Me.MenuPrincipal.TabIndex = 0
        Me.MenuPrincipal.Text = "MenuPrincipal"
        '
        'lvwDocumentos
        '
        Me.lvwDocumentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvwDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwDocumentos.HideSelection = False
        ListViewItem1.Checked = True
        ListViewItem1.StateImageIndex = 1
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.Checked = True
        ListViewItem6.StateImageIndex = 1
        Me.lvwDocumentos.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lvwDocumentos.Location = New System.Drawing.Point(11, 52)
        Me.lvwDocumentos.MultiSelect = False
        Me.lvwDocumentos.Name = "lvwDocumentos"
        Me.lvwDocumentos.Size = New System.Drawing.Size(269, 107)
        Me.lvwDocumentos.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwDocumentos.TabIndex = 1
        Me.lvwDocumentos.UseCompatibleStateImageBehavior = False
        Me.lvwDocumentos.View = System.Windows.Forms.View.List
        '
        'lbxConcepto
        '
        Me.lbxConcepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbxConcepto.FormattingEnabled = True
        Me.lbxConcepto.HorizontalScrollbar = True
        Me.lbxConcepto.Items.AddRange(New Object() {"Becas", "Estilo de vida", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más"})
        Me.lbxConcepto.Location = New System.Drawing.Point(11, 212)
        Me.lbxConcepto.Name = "lbxConcepto"
        Me.lbxConcepto.ScrollAlwaysVisible = True
        Me.lbxConcepto.Size = New System.Drawing.Size(268, 199)
        Me.lbxConcepto.TabIndex = 2
        '
        'clbArticulos
        '
        Me.clbArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clbArticulos.FormattingEnabled = True
        Me.clbArticulos.Items.AddRange(New Object() {"Artículo 1", "Artículo 2", "Artículo 3", "Artículo 4", "Artículo 5", "Artículo 6", "Artículo 7", "Artículo 8", "Artículo 9", "Artículo 10", "Artículo 11", "Artículo 12", "Artículo 13", "Artículo 14", "Artículo 15", "Artículo 16", "Artículo 17", "Artículo 18", "Artículo 19", "Artículo 20", "Artículo 21", "Artículo 22", "Artículo 23", "Artículo 24", "Artículo 25", "Artículo 26", "Artículo 27"})
        Me.clbArticulos.Location = New System.Drawing.Point(285, 156)
        Me.clbArticulos.Name = "clbArticulos"
        Me.clbArticulos.Size = New System.Drawing.Size(200, 229)
        Me.clbArticulos.TabIndex = 3
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Location = New System.Drawing.Point(19, 36)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(247, 13)
        Me.lblDocumento.TabIndex = 4
        Me.lblDocumento.Text = "Selecciona el documento en donde quieres buscar"
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Location = New System.Drawing.Point(19, 196)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(243, 13)
        Me.lblConcepto.TabIndex = 5
        Me.lblConcepto.Text = "Selecciona el concepto por el cual quieres buscar"
        '
        'lblArticulosTitulo
        '
        Me.lblArticulosTitulo.AutoSize = True
        Me.lblArticulosTitulo.Location = New System.Drawing.Point(282, 35)
        Me.lblArticulosTitulo.Name = "lblArticulosTitulo"
        Me.lblArticulosTitulo.Size = New System.Drawing.Size(201, 13)
        Me.lblArticulosTitulo.TabIndex = 6
        Me.lblArticulosTitulo.Text = "Artículos según los criterios de búsqueda"
        '
        'txbArticuloTexto
        '
        Me.txbArticuloTexto.Location = New System.Drawing.Point(496, 51)
        Me.txbArticuloTexto.Multiline = True
        Me.txbArticuloTexto.Name = "txbArticuloTexto"
        Me.txbArticuloTexto.ReadOnly = True
        Me.txbArticuloTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txbArticuloTexto.Size = New System.Drawing.Size(410, 363)
        Me.txbArticuloTexto.TabIndex = 7
        Me.txbArticuloTexto.Text = resources.GetString("txbArticuloTexto.Text")
        '
        'btnAnadirLista
        '
        Me.btnAnadirLista.Location = New System.Drawing.Point(331, 391)
        Me.btnAnadirLista.Name = "btnAnadirLista"
        Me.btnAnadirLista.Size = New System.Drawing.Size(111, 23)
        Me.btnAnadirLista.TabIndex = 8
        Me.btnAnadirLista.Text = "Añadir a la lista"
        Me.btnAnadirLista.UseVisualStyleBackColor = True
        '
        'lblDocumentoTitulo
        '
        Me.lblDocumentoTitulo.AutoSize = True
        Me.lblDocumentoTitulo.Location = New System.Drawing.Point(282, 61)
        Me.lblDocumentoTitulo.Name = "lblDocumentoTitulo"
        Me.lblDocumentoTitulo.Size = New System.Drawing.Size(65, 13)
        Me.lblDocumentoTitulo.TabIndex = 9
        Me.lblDocumentoTitulo.Text = "Documento:"
        '
        'lblDocumentoVar
        '
        Me.lblDocumentoVar.Location = New System.Drawing.Point(344, 61)
        Me.lblDocumentoVar.Name = "lblDocumentoVar"
        Me.lblDocumentoVar.Size = New System.Drawing.Size(136, 35)
        Me.lblDocumentoVar.TabIndex = 10
        Me.lblDocumentoVar.Text = "- - - -"
        '
        'lblConceptoBusqueda
        '
        Me.lblConceptoBusqueda.AutoSize = True
        Me.lblConceptoBusqueda.Location = New System.Drawing.Point(282, 96)
        Me.lblConceptoBusqueda.Name = "lblConceptoBusqueda"
        Me.lblConceptoBusqueda.Size = New System.Drawing.Size(56, 13)
        Me.lblConceptoBusqueda.TabIndex = 11
        Me.lblConceptoBusqueda.Text = "Concepto:"
        '
        'lblConceptoVar
        '
        Me.lblConceptoVar.Location = New System.Drawing.Point(344, 96)
        Me.lblConceptoVar.Name = "lblConceptoVar"
        Me.lblConceptoVar.Size = New System.Drawing.Size(136, 58)
        Me.lblConceptoVar.TabIndex = 12
        Me.lblConceptoVar.Text = "- - - -"
        '
        'toolTipGeneral
        '
        Me.toolTipGeneral.AutomaticDelay = 300
        '
        'lblArticuloTitulo
        '
        Me.lblArticuloTitulo.AutoSize = True
        Me.lblArticuloTitulo.Location = New System.Drawing.Point(496, 35)
        Me.lblArticuloTitulo.Name = "lblArticuloTitulo"
        Me.lblArticuloTitulo.Size = New System.Drawing.Size(113, 13)
        Me.lblArticuloTitulo.TabIndex = 13
        Me.lblArticuloTitulo.Text = "Artículo seleccionado:"
        '
        'lblArticuloVar
        '
        Me.lblArticuloVar.AutoSize = True
        Me.lblArticuloVar.Location = New System.Drawing.Point(616, 35)
        Me.lblArticuloVar.Name = "lblArticuloVar"
        Me.lblArticuloVar.Size = New System.Drawing.Size(47, 13)
        Me.lblArticuloVar.TabIndex = 14
        Me.lblArticuloVar.Text = "Ninguno"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 426)
        Me.Controls.Add(Me.lblArticuloVar)
        Me.Controls.Add(Me.lblArticuloTitulo)
        Me.Controls.Add(Me.lblConceptoVar)
        Me.Controls.Add(Me.lblConceptoBusqueda)
        Me.Controls.Add(Me.lblDocumentoVar)
        Me.Controls.Add(Me.lblDocumentoTitulo)
        Me.Controls.Add(Me.btnAnadirLista)
        Me.Controls.Add(Me.txbArticuloTexto)
        Me.Controls.Add(Me.lblArticulosTitulo)
        Me.Controls.Add(Me.lblConcepto)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.clbArticulos)
        Me.Controls.Add(Me.lbxConcepto)
        Me.Controls.Add(Me.lvwDocumentos)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Name = "Inicio"
        Me.Text = "Busqueda de Leyes y Artículos"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VerManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents lvwDocumentos As ListView
    Friend WithEvents lbxConcepto As ListBox
    Friend WithEvents clbArticulos As CheckedListBox
    Friend WithEvents lblDocumento As Label
    Friend WithEvents lblConcepto As Label
    Friend WithEvents lblArticulosTitulo As Label
    Friend WithEvents txbArticuloTexto As TextBox
    Friend WithEvents VerListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAnadirLista As Button
    Friend WithEvents lblDocumentoTitulo As Label
    Friend WithEvents lblDocumentoVar As Label
    Friend WithEvents lblConceptoBusqueda As Label
    Friend WithEvents lblConceptoVar As Label
    Friend WithEvents toolTipGeneral As ToolTip
    Friend WithEvents lblArticuloTitulo As Label
    Friend WithEvents lblArticuloVar As Label
End Class
