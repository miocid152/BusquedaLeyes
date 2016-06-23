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
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.lvwDocumentos = New System.Windows.Forms.ListView()
        Me.lbxConcepto = New System.Windows.Forms.ListBox()
        Me.clbArticulos = New System.Windows.Forms.CheckedListBox()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.lblArticulos = New System.Windows.Forms.Label()
        Me.txbArticulo = New System.Windows.Forms.TextBox()
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
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Otros..."
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
        Me.MenuPrincipal.Size = New System.Drawing.Size(922, 24)
        Me.MenuPrincipal.TabIndex = 0
        Me.MenuPrincipal.Text = "MenuPrincipal"
        '
        'lvwDocumentos
        '
        Me.lvwDocumentos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lvwDocumentos.FullRowSelect = True
        Me.lvwDocumentos.GridLines = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        ListViewItem5.StateImageIndex = 0
        Me.lvwDocumentos.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        Me.lvwDocumentos.Location = New System.Drawing.Point(5, 51)
        Me.lvwDocumentos.MultiSelect = False
        Me.lvwDocumentos.Name = "lvwDocumentos"
        Me.lvwDocumentos.Size = New System.Drawing.Size(270, 105)
        Me.lvwDocumentos.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwDocumentos.TabIndex = 1
        Me.lvwDocumentos.UseCompatibleStateImageBehavior = False
        Me.lvwDocumentos.View = System.Windows.Forms.View.List
        '
        'lbxConcepto
        '
        Me.lbxConcepto.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbxConcepto.FormattingEnabled = True
        Me.lbxConcepto.Items.AddRange(New Object() {"Becas", "Estilo de vida", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más", "Más"})
        Me.lbxConcepto.Location = New System.Drawing.Point(6, 203)
        Me.lbxConcepto.Name = "lbxConcepto"
        Me.lbxConcepto.Size = New System.Drawing.Size(270, 108)
        Me.lbxConcepto.TabIndex = 2
        '
        'clbArticulos
        '
        Me.clbArticulos.FormattingEnabled = True
        Me.clbArticulos.Items.AddRange(New Object() {"Artículo 1", "Artículo 2", "Artículo 3", "Artículo 4", "Artículo 5", "Artículo 6", "Artículo 7", "Artículo 8", "Artículo 9", "Artículo 10", "Artículo 11", "Artículo 12", "Artículo 13", "Artículo 14", "Artículo 15", "Artículo 16", "Artículo 17", "Artículo 18", "Artículo 19", "Artículo 20", "Artículo 21", "Artículo 22", "Artículo 23", "Artículo 24", "Artículo 25", "Artículo 26", "Artículo 27"})
        Me.clbArticulos.Location = New System.Drawing.Point(290, 51)
        Me.clbArticulos.Name = "clbArticulos"
        Me.clbArticulos.Size = New System.Drawing.Size(200, 259)
        Me.clbArticulos.TabIndex = 3
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Location = New System.Drawing.Point(8, 36)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(247, 13)
        Me.lblDocumento.TabIndex = 4
        Me.lblDocumento.Text = "Selecciona el documento en donde quieres buscar"
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Location = New System.Drawing.Point(8, 186)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(243, 13)
        Me.lblConcepto.TabIndex = 5
        Me.lblConcepto.Text = "Selecciona el concepto por el cual quieres buscar"
        '
        'lblArticulos
        '
        Me.lblArticulos.AutoSize = True
        Me.lblArticulos.Location = New System.Drawing.Point(289, 32)
        Me.lblArticulos.Name = "lblArticulos"
        Me.lblArticulos.Size = New System.Drawing.Size(201, 13)
        Me.lblArticulos.TabIndex = 6
        Me.lblArticulos.Text = "Artículos según los criterios de búsqueda"
        '
        'txbArticulo
        '
        Me.txbArticulo.Location = New System.Drawing.Point(496, 51)
        Me.txbArticulo.Multiline = True
        Me.txbArticulo.Name = "txbArticulo"
        Me.txbArticulo.Size = New System.Drawing.Size(414, 259)
        Me.txbArticulo.TabIndex = 7
        Me.txbArticulo.Text = resources.GetString("txbArticulo.Text")
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 352)
        Me.Controls.Add(Me.txbArticulo)
        Me.Controls.Add(Me.lblArticulos)
        Me.Controls.Add(Me.lblConcepto)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.clbArticulos)
        Me.Controls.Add(Me.lbxConcepto)
        Me.Controls.Add(Me.lvwDocumentos)
        Me.Controls.Add(Me.MenuPrincipal)
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
    Friend WithEvents lblArticulos As Label
    Friend WithEvents txbArticulo As TextBox
End Class
