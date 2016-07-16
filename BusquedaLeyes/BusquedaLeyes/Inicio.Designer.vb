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
        Me.txbArticuloTexto222 = New System.Windows.Forms.TextBox()
        Me.btnAnadirLista = New System.Windows.Forms.Button()
        Me.lblDocumentoTitulo = New System.Windows.Forms.Label()
        Me.lblDocumentoVar = New System.Windows.Forms.Label()
        Me.lblConceptoBusqueda = New System.Windows.Forms.Label()
        Me.lblConceptoVar = New System.Windows.Forms.Label()
        Me.toolTipGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblArticuloTitulo = New System.Windows.Forms.Label()
        Me.lblArticuloVar = New System.Windows.Forms.Label()
        Me.lbxArticulos = New System.Windows.Forms.ListBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnQuitarLista = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txbArticuloTexto = New System.Windows.Forms.RichTextBox()
        Me.MenuPrincipal.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
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
        Me.lvwDocumentos.Location = New System.Drawing.Point(11, 52)
        Me.lvwDocumentos.MultiSelect = False
        Me.lvwDocumentos.Name = "lvwDocumentos"
        Me.lvwDocumentos.Size = New System.Drawing.Size(269, 107)
        Me.lvwDocumentos.TabIndex = 1
        Me.lvwDocumentos.UseCompatibleStateImageBehavior = False
        Me.lvwDocumentos.View = System.Windows.Forms.View.List
        '
        'lbxConcepto
        '
        Me.lbxConcepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbxConcepto.FormattingEnabled = True
        Me.lbxConcepto.HorizontalScrollbar = True
        Me.lbxConcepto.Location = New System.Drawing.Point(11, 186)
        Me.lbxConcepto.Name = "lbxConcepto"
        Me.lbxConcepto.ScrollAlwaysVisible = True
        Me.lbxConcepto.Size = New System.Drawing.Size(268, 225)
        Me.lbxConcepto.TabIndex = 2
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.Location = New System.Drawing.Point(19, 36)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(247, 13)
        Me.lblDocumento.TabIndex = 4
        Me.lblDocumento.Text = "Selecciona el documento en donde quieres buscar"
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(19, 173)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(243, 13)
        Me.lblConcepto.TabIndex = 5
        Me.lblConcepto.Text = "Selecciona el concepto por el cual quieres buscar"
        '
        'lblArticulosTitulo
        '
        Me.lblArticulosTitulo.AutoSize = True
        Me.lblArticulosTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulosTitulo.Location = New System.Drawing.Point(285, 173)
        Me.lblArticulosTitulo.Name = "lblArticulosTitulo"
        Me.lblArticulosTitulo.Size = New System.Drawing.Size(201, 13)
        Me.lblArticulosTitulo.TabIndex = 6
        Me.lblArticulosTitulo.Text = "Artículos según los criterios de búsqueda"
        '
        'txbArticuloTexto222
        '
        Me.txbArticuloTexto222.Location = New System.Drawing.Point(496, 51)
        Me.txbArticuloTexto222.Multiline = True
        Me.txbArticuloTexto222.Name = "txbArticuloTexto222"
        Me.txbArticuloTexto222.ReadOnly = True
        Me.txbArticuloTexto222.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txbArticuloTexto222.Size = New System.Drawing.Size(410, 334)
        Me.txbArticuloTexto222.TabIndex = 7
        Me.txbArticuloTexto222.Text = resources.GetString("txbArticuloTexto222.Text")
        '
        'btnAnadirLista
        '
        Me.btnAnadirLista.Location = New System.Drawing.Point(734, 391)
        Me.btnAnadirLista.Name = "btnAnadirLista"
        Me.btnAnadirLista.Size = New System.Drawing.Size(111, 23)
        Me.btnAnadirLista.TabIndex = 8
        Me.btnAnadirLista.Text = "Añadir a la lista"
        Me.btnAnadirLista.UseVisualStyleBackColor = True
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
        'lblArticuloTitulo
        '
        Me.lblArticuloTitulo.AutoSize = True
        Me.lblArticuloTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticuloTitulo.Location = New System.Drawing.Point(496, 35)
        Me.lblArticuloTitulo.Name = "lblArticuloTitulo"
        Me.lblArticuloTitulo.Size = New System.Drawing.Size(113, 13)
        Me.lblArticuloTitulo.TabIndex = 13
        Me.lblArticuloTitulo.Text = "Artículo seleccionado:"
        '
        'lblArticuloVar
        '
        Me.lblArticuloVar.AutoSize = True
        Me.lblArticuloVar.Location = New System.Drawing.Point(604, 35)
        Me.lblArticuloVar.Name = "lblArticuloVar"
        Me.lblArticuloVar.Size = New System.Drawing.Size(47, 13)
        Me.lblArticuloVar.TabIndex = 14
        Me.lblArticuloVar.Text = "Ninguno"
        '
        'lbxArticulos
        '
        Me.lbxArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbxArticulos.FormattingEnabled = True
        Me.lbxArticulos.HorizontalScrollbar = True
        Me.lbxArticulos.Location = New System.Drawing.Point(285, 186)
        Me.lbxArticulos.Name = "lbxArticulos"
        Me.lbxArticulos.Size = New System.Drawing.Size(205, 225)
        Me.lbxArticulos.TabIndex = 15
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.lblDocumentoTitulo)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblDocumentoVar)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblConceptoBusqueda)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblConceptoVar)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(285, 51)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(205, 108)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'btnQuitarLista
        '
        Me.btnQuitarLista.Location = New System.Drawing.Point(520, 391)
        Me.btnQuitarLista.Name = "btnQuitarLista"
        Me.btnQuitarLista.Size = New System.Drawing.Size(111, 23)
        Me.btnQuitarLista.TabIndex = 17
        Me.btnQuitarLista.Text = "Quitar de la lista"
        Me.btnQuitarLista.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txbArticuloTexto
        '
        Me.txbArticuloTexto.Location = New System.Drawing.Point(499, 52)
        Me.txbArticuloTexto.Name = "txbArticuloTexto"
        Me.txbArticuloTexto.Size = New System.Drawing.Size(387, 331)
        Me.txbArticuloTexto.TabIndex = 19
        Me.txbArticuloTexto.Text = ""
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(931, 426)
        Me.Controls.Add(Me.txbArticuloTexto)
        Me.Controls.Add(Me.btnQuitarLista)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lbxArticulos)
        Me.Controls.Add(Me.lblArticuloVar)
        Me.Controls.Add(Me.lblArticuloTitulo)
        Me.Controls.Add(Me.btnAnadirLista)
        Me.Controls.Add(Me.txbArticuloTexto222)
        Me.Controls.Add(Me.lblArticulosTitulo)
        Me.Controls.Add(Me.lblConcepto)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.lbxConcepto)
        Me.Controls.Add(Me.lvwDocumentos)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Leyes y Artículos"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents txbArticuloTexto222 As TextBox
    Friend WithEvents VerListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAnadirLista As Button
    Friend WithEvents lblDocumentoTitulo As Label
    Friend WithEvents lblDocumentoVar As Label
    Friend WithEvents lblConceptoBusqueda As Label
    Friend WithEvents lblConceptoVar As Label
    Friend WithEvents toolTipGeneral As ToolTip
    Friend WithEvents lblArticuloTitulo As Label
    Friend WithEvents lblArticuloVar As Label
    Friend WithEvents lbxArticulos As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnQuitarLista As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txbArticuloTexto As RichTextBox
End Class
