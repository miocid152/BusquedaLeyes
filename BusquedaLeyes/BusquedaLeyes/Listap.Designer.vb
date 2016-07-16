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
        Me.lblArticuloVarLista = New System.Windows.Forms.Label()
        Me.lblArticuloTituloLita = New System.Windows.Forms.Label()
        Me.lblArticulosTituloLista = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.cbxListaDocumento = New System.Windows.Forms.ComboBox()
        Me.txbArticuloTextoLista = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lbxArticulosLista
        '
        Me.lbxArticulosLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbxArticulosLista.FormattingEnabled = True
        Me.lbxArticulosLista.HorizontalScrollbar = True
        Me.lbxArticulosLista.Location = New System.Drawing.Point(12, 48)
        Me.lbxArticulosLista.Name = "lbxArticulosLista"
        Me.lbxArticulosLista.Size = New System.Drawing.Size(205, 225)
        Me.lbxArticulosLista.TabIndex = 20
        '
        'lblArticuloVarLista
        '
        Me.lblArticuloVarLista.AutoSize = True
        Me.lblArticuloVarLista.Location = New System.Drawing.Point(408, 12)
        Me.lblArticuloVarLista.Name = "lblArticuloVarLista"
        Me.lblArticuloVarLista.Size = New System.Drawing.Size(47, 13)
        Me.lblArticuloVarLista.TabIndex = 19
        Me.lblArticuloVarLista.Text = "Ninguno"
        '
        'lblArticuloTituloLita
        '
        Me.lblArticuloTituloLita.AutoSize = True
        Me.lblArticuloTituloLita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticuloTituloLita.Location = New System.Drawing.Point(300, 12)
        Me.lblArticuloTituloLita.Name = "lblArticuloTituloLita"
        Me.lblArticuloTituloLita.Size = New System.Drawing.Size(113, 13)
        Me.lblArticuloTituloLita.TabIndex = 18
        Me.lblArticuloTituloLita.Text = "Artículo seleccionado:"
        '
        'lblArticulosTituloLista
        '
        Me.lblArticulosTituloLista.AutoSize = True
        Me.lblArticulosTituloLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulosTituloLista.Location = New System.Drawing.Point(12, 32)
        Me.lblArticulosTituloLista.Name = "lblArticulosTituloLista"
        Me.lblArticulosTituloLista.Size = New System.Drawing.Size(201, 13)
        Me.lblArticulosTituloLista.TabIndex = 16
        Me.lblArticulosTituloLista.Text = "Artículos según los criterios de búsqueda"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(15, 279)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(78, 23)
        Me.btnQuitar.TabIndex = 21
        Me.btnQuitar.Text = "QuitarArticulo"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'cbxListaDocumento
        '
        Me.cbxListaDocumento.FormattingEnabled = True
        Me.cbxListaDocumento.Location = New System.Drawing.Point(12, 9)
        Me.cbxListaDocumento.Name = "cbxListaDocumento"
        Me.cbxListaDocumento.Size = New System.Drawing.Size(282, 21)
        Me.cbxListaDocumento.TabIndex = 22
        '
        'txbArticuloTextoLista
        '
        Me.txbArticuloTextoLista.Location = New System.Drawing.Point(303, 28)
        Me.txbArticuloTextoLista.Name = "txbArticuloTextoLista"
        Me.txbArticuloTextoLista.Size = New System.Drawing.Size(605, 343)
        Me.txbArticuloTextoLista.TabIndex = 23
        Me.txbArticuloTextoLista.Text = ""
        '
        'Listap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(931, 426)
        Me.Controls.Add(Me.txbArticuloTextoLista)
        Me.Controls.Add(Me.cbxListaDocumento)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.lbxArticulosLista)
        Me.Controls.Add(Me.lblArticuloVarLista)
        Me.Controls.Add(Me.lblArticuloTituloLita)
        Me.Controls.Add(Me.lblArticulosTituloLista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Listap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista Personal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbxArticulosLista As ListBox
    Friend WithEvents lblArticuloVarLista As Label
    Friend WithEvents lblArticuloTituloLita As Label
    Friend WithEvents lblArticulosTituloLista As Label
    Friend WithEvents btnQuitar As Button
    Friend WithEvents cbxListaDocumento As ComboBox
    Friend WithEvents txbArticuloTextoLista As RichTextBox
End Class
