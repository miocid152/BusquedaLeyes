<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listap))
        Me.lbxArticulosLista = New System.Windows.Forms.ListBox()
        Me.lblArticulosTituloLista = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.cbxListaDocumento = New System.Windows.Forms.ComboBox()
        Me.txbArticuloTextoLista = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbxArticulosLista
        '
        Me.lbxArticulosLista.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbxArticulosLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbxArticulosLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxArticulosLista.FormattingEnabled = True
        Me.lbxArticulosLista.HorizontalScrollbar = True
        Me.lbxArticulosLista.Location = New System.Drawing.Point(3, 43)
        Me.lbxArticulosLista.Name = "lbxArticulosLista"
        Me.lbxArticulosLista.Size = New System.Drawing.Size(314, 338)
        Me.lbxArticulosLista.TabIndex = 20
        '
        'lblArticulosTituloLista
        '
        Me.lblArticulosTituloLista.AutoSize = True
        Me.lblArticulosTituloLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblArticulosTituloLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulosTituloLista.Location = New System.Drawing.Point(3, 27)
        Me.lblArticulosTituloLista.Name = "lblArticulosTituloLista"
        Me.lblArticulosTituloLista.Size = New System.Drawing.Size(314, 13)
        Me.lblArticulosTituloLista.TabIndex = 16
        Me.lblArticulosTituloLista.Text = "Artículos según los criterios de búsqueda"
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.DarkGray
        Me.btnQuitar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuitar.ForeColor = System.Drawing.Color.Crimson
        Me.btnQuitar.Location = New System.Drawing.Point(3, 387)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(314, 30)
        Me.btnQuitar.TabIndex = 21
        Me.btnQuitar.Text = "QuitarArticulo"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'cbxListaDocumento
        '
        Me.cbxListaDocumento.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cbxListaDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxListaDocumento.FormattingEnabled = True
        Me.cbxListaDocumento.Location = New System.Drawing.Point(3, 3)
        Me.cbxListaDocumento.Name = "cbxListaDocumento"
        Me.cbxListaDocumento.Size = New System.Drawing.Size(314, 21)
        Me.cbxListaDocumento.TabIndex = 22
        '
        'txbArticuloTextoLista
        '
        Me.txbArticuloTextoLista.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txbArticuloTextoLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txbArticuloTextoLista.Location = New System.Drawing.Point(3, 3)
        Me.txbArticuloTextoLista.Name = "txbArticuloTextoLista"
        Me.txbArticuloTextoLista.Size = New System.Drawing.Size(596, 414)
        Me.txbArticuloTextoLista.TabIndex = 23
        Me.txbArticuloTextoLista.Text = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(934, 426)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txbArticuloTextoLista, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(329, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 420.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(602, 420)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.cbxListaDocumento, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnQuitar, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.lblArticulosTituloLista, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbxArticulosLista, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.58823!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.411765!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(320, 420)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Listap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(934, 426)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 465)
        Me.Name = "Listap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista Personal"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbxArticulosLista As ListBox
    Friend WithEvents lblArticulosTituloLista As Label
    Friend WithEvents btnQuitar As Button
    Friend WithEvents cbxListaDocumento As ComboBox
    Friend WithEvents txbArticuloTextoLista As RichTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
End Class
