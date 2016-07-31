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
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblArticulosTitulo = New System.Windows.Forms.Label()
        Me.btnAnadirLista = New System.Windows.Forms.Button()
        Me.lblDocumentoTitulo = New System.Windows.Forms.Label()
        Me.lblDocumentoVar = New System.Windows.Forms.Label()
        Me.lblConceptoBusqueda = New System.Windows.Forms.Label()
        Me.lblConceptoVar = New System.Windows.Forms.Label()
        Me.toolTipGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbxArticulos = New System.Windows.Forms.ListBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnQuitarLista = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txbArticuloTexto = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblArticuloTitulo = New System.Windows.Forms.Label()
        Me.lblArticuloVar = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuPrincipal.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
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
        Me.VerListaToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
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
        Me.MenuPrincipal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem1})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuPrincipal.Size = New System.Drawing.Size(1084, 24)
        Me.MenuPrincipal.TabIndex = 0
        Me.MenuPrincipal.Text = "MenuPrincipal"
        '
        'lvwDocumentos
        '
        Me.lvwDocumentos.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lvwDocumentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvwDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwDocumentos.Location = New System.Drawing.Point(3, 16)
        Me.lvwDocumentos.MultiSelect = False
        Me.lvwDocumentos.Name = "lvwDocumentos"
        Me.lvwDocumentos.Size = New System.Drawing.Size(259, 105)
        Me.lvwDocumentos.TabIndex = 1
        Me.lvwDocumentos.UseCompatibleStateImageBehavior = False
        Me.lvwDocumentos.View = System.Windows.Forms.View.List
        '
        'lbxConcepto
        '
        Me.lbxConcepto.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbxConcepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbxConcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxConcepto.FormattingEnabled = True
        Me.lbxConcepto.HorizontalScrollbar = True
        Me.lbxConcepto.Location = New System.Drawing.Point(3, 140)
        Me.lbxConcepto.Name = "lbxConcepto"
        Me.lbxConcepto.ScrollAlwaysVisible = True
        Me.lbxConcepto.Size = New System.Drawing.Size(259, 289)
        Me.lbxConcepto.TabIndex = 2
        '
        'lblDocumento
        '
        Me.lblDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.BackColor = System.Drawing.Color.Transparent
        Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.Location = New System.Drawing.Point(3, 0)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(247, 13)
        Me.lblDocumento.TabIndex = 4
        Me.lblDocumento.Text = "Selecciona el documento en donde quieres buscar"
        '
        'lblConcepto
        '
        Me.lblConcepto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.BackColor = System.Drawing.Color.Transparent
        Me.lblConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(3, 124)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(243, 13)
        Me.lblConcepto.TabIndex = 5
        Me.lblConcepto.Text = "Selecciona el concepto por el cual quieres buscar"
        '
        'lblArticulosTitulo
        '
        Me.lblArticulosTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblArticulosTitulo.AutoSize = True
        Me.lblArticulosTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblArticulosTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulosTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lblArticulosTitulo.Name = "lblArticulosTitulo"
        Me.lblArticulosTitulo.Size = New System.Drawing.Size(201, 13)
        Me.lblArticulosTitulo.TabIndex = 6
        Me.lblArticulosTitulo.Text = "Artículos según los criterios de búsqueda"
        '
        'btnAnadirLista
        '
        Me.btnAnadirLista.BackColor = System.Drawing.Color.DarkGray
        Me.btnAnadirLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAnadirLista.ForeColor = System.Drawing.Color.Crimson
        Me.btnAnadirLista.Location = New System.Drawing.Point(56, 3)
        Me.btnAnadirLista.Name = "btnAnadirLista"
        Me.btnAnadirLista.Size = New System.Drawing.Size(153, 21)
        Me.btnAnadirLista.TabIndex = 8
        Me.btnAnadirLista.Text = "Añadir a la lista"
        Me.btnAnadirLista.UseVisualStyleBackColor = False
        '
        'lblDocumentoTitulo
        '
        Me.lblDocumentoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentoTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lblDocumentoTitulo.Name = "lblDocumentoTitulo"
        Me.lblDocumentoTitulo.Size = New System.Drawing.Size(197, 13)
        Me.lblDocumentoTitulo.TabIndex = 9
        Me.lblDocumentoTitulo.Text = "Documento:"
        '
        'lblDocumentoVar
        '
        Me.lblDocumentoVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentoVar.ForeColor = System.Drawing.Color.Crimson
        Me.lblDocumentoVar.Location = New System.Drawing.Point(3, 13)
        Me.lblDocumentoVar.Name = "lblDocumentoVar"
        Me.lblDocumentoVar.Size = New System.Drawing.Size(197, 37)
        Me.lblDocumentoVar.TabIndex = 10
        Me.lblDocumentoVar.Text = "Ninguno"
        '
        'lblConceptoBusqueda
        '
        Me.lblConceptoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConceptoBusqueda.Location = New System.Drawing.Point(3, 50)
        Me.lblConceptoBusqueda.Name = "lblConceptoBusqueda"
        Me.lblConceptoBusqueda.Size = New System.Drawing.Size(197, 13)
        Me.lblConceptoBusqueda.TabIndex = 11
        Me.lblConceptoBusqueda.Text = "Concepto:"
        '
        'lblConceptoVar
        '
        Me.lblConceptoVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConceptoVar.ForeColor = System.Drawing.Color.Crimson
        Me.lblConceptoVar.Location = New System.Drawing.Point(3, 63)
        Me.lblConceptoVar.Name = "lblConceptoVar"
        Me.lblConceptoVar.Size = New System.Drawing.Size(197, 44)
        Me.lblConceptoVar.TabIndex = 12
        Me.lblConceptoVar.Text = "Ninguno"
        '
        'toolTipGeneral
        '
        Me.toolTipGeneral.AutomaticDelay = 300
        '
        'lbxArticulos
        '
        Me.lbxArticulos.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbxArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbxArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxArticulos.FormattingEnabled = True
        Me.lbxArticulos.HorizontalScrollbar = True
        Me.lbxArticulos.Location = New System.Drawing.Point(3, 16)
        Me.lbxArticulos.Name = "lbxArticulos"
        Me.lbxArticulos.Size = New System.Drawing.Size(253, 294)
        Me.lbxArticulos.TabIndex = 15
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.lblDocumentoTitulo)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblDocumentoVar)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblConceptoBusqueda)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblConceptoVar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(259, 107)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'btnQuitarLista
        '
        Me.btnQuitarLista.BackColor = System.Drawing.Color.DarkGray
        Me.btnQuitarLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuitarLista.ForeColor = System.Drawing.Color.Crimson
        Me.btnQuitarLista.Location = New System.Drawing.Point(321, 3)
        Me.btnQuitarLista.Name = "btnQuitarLista"
        Me.btnQuitarLista.Size = New System.Drawing.Size(153, 21)
        Me.btnQuitarLista.TabIndex = 17
        Me.btnQuitarLista.Text = "Quitar de la lista"
        Me.btnQuitarLista.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txbArticuloTexto
        '
        Me.txbArticuloTexto.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txbArticuloTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txbArticuloTexto.Location = New System.Drawing.Point(3, 24)
        Me.txbArticuloTexto.Name = "txbArticuloTexto"
        Me.txbArticuloTexto.Size = New System.Drawing.Size(530, 372)
        Me.txbArticuloTexto.TabIndex = 19
        Me.txbArticuloTexto.Text = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1084, 438)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txbArticuloTexto, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(545, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(536, 432)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnQuitarLista, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAnadirLista, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 402)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(530, 27)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.lblArticuloTitulo, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblArticuloVar, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(530, 15)
        Me.TableLayoutPanel4.TabIndex = 20
        '
        'lblArticuloTitulo
        '
        Me.lblArticuloTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblArticuloTitulo.AutoSize = True
        Me.lblArticuloTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblArticuloTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticuloTitulo.Location = New System.Drawing.Point(3, 1)
        Me.lblArticuloTitulo.Name = "lblArticuloTitulo"
        Me.lblArticuloTitulo.Size = New System.Drawing.Size(113, 13)
        Me.lblArticuloTitulo.TabIndex = 13
        Me.lblArticuloTitulo.Text = "Artículo seleccionado:"
        '
        'lblArticuloVar
        '
        Me.lblArticuloVar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblArticuloVar.AutoSize = True
        Me.lblArticuloVar.ForeColor = System.Drawing.Color.Crimson
        Me.lblArticuloVar.Location = New System.Drawing.Point(122, 1)
        Me.lblArticuloVar.Name = "lblArticuloVar"
        Me.lblArticuloVar.Size = New System.Drawing.Size(47, 13)
        Me.lblArticuloVar.TabIndex = 14
        Me.lblArticuloVar.Text = "Ninguno"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(274, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.23762!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.76237!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(265, 432)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lblArticulosTitulo, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lbxArticulos, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 116)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(259, 313)
        Me.TableLayoutPanel6.TabIndex = 17
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.lblDocumento, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lvwDocumentos, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.lbxConcepto, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.lblConcepto, 0, 2)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 4
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.5!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.5!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(265, 432)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1084, 462)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.MinimumSize = New System.Drawing.Size(1100, 500)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Leyes y Artículos"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
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
    Friend WithEvents lblDocumento As Label
    Friend WithEvents lblConcepto As Label
    Friend WithEvents lblArticulosTitulo As Label
    Friend WithEvents VerListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAnadirLista As Button
    Friend WithEvents lblDocumentoTitulo As Label
    Friend WithEvents lblDocumentoVar As Label
    Friend WithEvents lblConceptoBusqueda As Label
    Friend WithEvents lblConceptoVar As Label
    Friend WithEvents toolTipGeneral As ToolTip
    Friend WithEvents lbxArticulos As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnQuitarLista As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txbArticuloTexto As RichTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblArticuloTitulo As Label
    Friend WithEvents lblArticuloVar As Label
End Class
