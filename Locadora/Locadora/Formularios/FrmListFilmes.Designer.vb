<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListFilmes
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
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.grdListaFilmes = New System.Windows.Forms.DataGridView()
		Me.btnAdicionarFilme = New System.Windows.Forms.Button()
		Me.gbpFilmes = New System.Windows.Forms.GroupBox()
		Me.txtNomeFilmeConsulta = New System.Windows.Forms.TextBox()
		Me.lbNomeFilme = New System.Windows.Forms.Label()
		CType(Me.grdListaFilmes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbpFilmes.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(607, 492)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.btnCancelar.TabIndex = 1
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = True
		'
		'grdListaFilmes
		'
		Me.grdListaFilmes.AllowUserToAddRows = False
		Me.grdListaFilmes.AllowUserToDeleteRows = False
		Me.grdListaFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdListaFilmes.Location = New System.Drawing.Point(12, 104)
		Me.grdListaFilmes.Name = "grdListaFilmes"
		Me.grdListaFilmes.RowHeadersVisible = False
		Me.grdListaFilmes.Size = New System.Drawing.Size(751, 382)
		Me.grdListaFilmes.TabIndex = 1
		'
		'btnAdicionarFilme
		'
		Me.btnAdicionarFilme.Location = New System.Drawing.Point(688, 492)
		Me.btnAdicionarFilme.Name = "btnAdicionarFilme"
		Me.btnAdicionarFilme.Size = New System.Drawing.Size(75, 23)
		Me.btnAdicionarFilme.TabIndex = 2
		Me.btnAdicionarFilme.Text = "Adicionar"
		Me.btnAdicionarFilme.UseVisualStyleBackColor = True
		'
		'gbpFilmes
		'
		Me.gbpFilmes.Controls.Add(Me.lbNomeFilme)
		Me.gbpFilmes.Controls.Add(Me.txtNomeFilmeConsulta)
		Me.gbpFilmes.Location = New System.Drawing.Point(12, 12)
		Me.gbpFilmes.Name = "gbpFilmes"
		Me.gbpFilmes.Size = New System.Drawing.Size(751, 86)
		Me.gbpFilmes.TabIndex = 3
		Me.gbpFilmes.TabStop = False
		Me.gbpFilmes.Text = "Consulta"
		'
		'txtNomeFilmeConsulta
		'
		Me.txtNomeFilmeConsulta.Location = New System.Drawing.Point(6, 43)
		Me.txtNomeFilmeConsulta.MaxLength = 150
		Me.txtNomeFilmeConsulta.Name = "txtNomeFilmeConsulta"
		Me.txtNomeFilmeConsulta.Size = New System.Drawing.Size(459, 20)
		Me.txtNomeFilmeConsulta.TabIndex = 0
		'
		'lbNomeFilme
		'
		Me.lbNomeFilme.AutoSize = True
		Me.lbNomeFilme.Location = New System.Drawing.Point(7, 24)
		Me.lbNomeFilme.Name = "lbNomeFilme"
		Me.lbNomeFilme.Size = New System.Drawing.Size(77, 13)
		Me.lbNomeFilme.TabIndex = 1
		Me.lbNomeFilme.Text = "Nome do Filme"
		'
		'FrmListFilmes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(775, 527)
		Me.Controls.Add(Me.gbpFilmes)
		Me.Controls.Add(Me.btnAdicionarFilme)
		Me.Controls.Add(Me.grdListaFilmes)
		Me.Controls.Add(Me.btnCancelar)
		Me.Name = "FrmListFilmes"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Filmes"
		CType(Me.grdListaFilmes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbpFilmes.ResumeLayout(False)
		Me.gbpFilmes.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnCancelar As Button
	Friend WithEvents grdListaFilmes As DataGridView
	Friend WithEvents btnAdicionarFilme As Button
	Friend WithEvents gbpFilmes As GroupBox
	Friend WithEvents lbNomeFilme As Label
	Friend WithEvents txtNomeFilmeConsulta As TextBox
End Class
