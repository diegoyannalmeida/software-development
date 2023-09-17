<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListClientesComFilmes
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
		Me.grdListaClientesComFilmes = New System.Windows.Forms.DataGridView()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.txtCpfClienteComFilme = New System.Windows.Forms.TextBox()
		Me.lbNome = New System.Windows.Forms.Label()
		CType(Me.grdListaClientesComFilmes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'grdListaClientesComFilmes
		'
		Me.grdListaClientesComFilmes.AllowUserToAddRows = False
		Me.grdListaClientesComFilmes.AllowUserToDeleteRows = False
		Me.grdListaClientesComFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdListaClientesComFilmes.Location = New System.Drawing.Point(12, 59)
		Me.grdListaClientesComFilmes.Name = "grdListaClientesComFilmes"
		Me.grdListaClientesComFilmes.RowHeadersVisible = False
		Me.grdListaClientesComFilmes.Size = New System.Drawing.Size(751, 428)
		Me.grdListaClientesComFilmes.TabIndex = 2
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(688, 493)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.btnCancelar.TabIndex = 3
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = True
		'
		'txtCpfClienteComFilme
		'
		Me.txtCpfClienteComFilme.Location = New System.Drawing.Point(12, 33)
		Me.txtCpfClienteComFilme.MaxLength = 11
		Me.txtCpfClienteComFilme.Name = "txtCpfClienteComFilme"
		Me.txtCpfClienteComFilme.Size = New System.Drawing.Size(204, 20)
		Me.txtCpfClienteComFilme.TabIndex = 4
		'
		'lbNome
		'
		Me.lbNome.AutoSize = True
		Me.lbNome.Location = New System.Drawing.Point(12, 17)
		Me.lbNome.Name = "lbNome"
		Me.lbNome.Size = New System.Drawing.Size(27, 13)
		Me.lbNome.TabIndex = 5
		Me.lbNome.Text = "CPF"
		'
		'FrmListClientesComFilmes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(779, 531)
		Me.Controls.Add(Me.lbNome)
		Me.Controls.Add(Me.txtCpfClienteComFilme)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.grdListaClientesComFilmes)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "FrmListClientesComFilmes"
		Me.Text = "Clientes com filmes"
		CType(Me.grdListaClientesComFilmes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents grdListaClientesComFilmes As DataGridView
	Friend WithEvents btnCancelar As Button
	Friend WithEvents txtCpfClienteComFilme As TextBox
	Friend WithEvents lbNome As Label
End Class
