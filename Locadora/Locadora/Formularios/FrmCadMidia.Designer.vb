<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadMidia
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
		Me.tbpCadMidia = New System.Windows.Forms.TabControl()
		Me.tbpCadastroMidia = New System.Windows.Forms.TabPage()
		Me.lbIdMidia = New System.Windows.Forms.Label()
		Me.txtIdMidia = New System.Windows.Forms.TextBox()
		Me.btnExcluirMidia = New System.Windows.Forms.Button()
		Me.btnLimparCadastro = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.btnSalvarMidia = New System.Windows.Forms.Button()
		Me.txtTipoDeMidia = New System.Windows.Forms.TextBox()
		Me.tbpPesquisaMidia = New System.Windows.Forms.TabPage()
		Me.btnLimparCosulta = New System.Windows.Forms.Button()
		Me.btnConsultarFilme = New System.Windows.Forms.Button()
		Me.grdConsultaMidia = New System.Windows.Forms.DataGridView()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtConsultaTipoDeMidia = New System.Windows.Forms.TextBox()
		Me.tbpCadMidia.SuspendLayout()
		Me.tbpCadastroMidia.SuspendLayout()
		Me.tbpPesquisaMidia.SuspendLayout()
		CType(Me.grdConsultaMidia, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tbpCadMidia
		'
		Me.tbpCadMidia.Controls.Add(Me.tbpCadastroMidia)
		Me.tbpCadMidia.Controls.Add(Me.tbpPesquisaMidia)
		Me.tbpCadMidia.Location = New System.Drawing.Point(12, 12)
		Me.tbpCadMidia.Name = "tbpCadMidia"
		Me.tbpCadMidia.SelectedIndex = 0
		Me.tbpCadMidia.Size = New System.Drawing.Size(509, 210)
		Me.tbpCadMidia.TabIndex = 0
		'
		'tbpCadastroMidia
		'
		Me.tbpCadastroMidia.Controls.Add(Me.lbIdMidia)
		Me.tbpCadastroMidia.Controls.Add(Me.txtIdMidia)
		Me.tbpCadastroMidia.Controls.Add(Me.btnExcluirMidia)
		Me.tbpCadastroMidia.Controls.Add(Me.btnLimparCadastro)
		Me.tbpCadastroMidia.Controls.Add(Me.Label1)
		Me.tbpCadastroMidia.Controls.Add(Me.btnCancelar)
		Me.tbpCadastroMidia.Controls.Add(Me.btnSalvarMidia)
		Me.tbpCadastroMidia.Controls.Add(Me.txtTipoDeMidia)
		Me.tbpCadastroMidia.Location = New System.Drawing.Point(4, 22)
		Me.tbpCadastroMidia.Name = "tbpCadastroMidia"
		Me.tbpCadastroMidia.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpCadastroMidia.Size = New System.Drawing.Size(501, 184)
		Me.tbpCadastroMidia.TabIndex = 0
		Me.tbpCadastroMidia.Text = "Cadastro"
		Me.tbpCadastroMidia.UseVisualStyleBackColor = True
		'
		'lbIdMidia
		'
		Me.lbIdMidia.AutoSize = True
		Me.lbIdMidia.Location = New System.Drawing.Point(22, 46)
		Me.lbIdMidia.Name = "lbIdMidia"
		Me.lbIdMidia.Size = New System.Drawing.Size(59, 13)
		Me.lbIdMidia.TabIndex = 7
		Me.lbIdMidia.Text = "Cód. Mídia"
		Me.lbIdMidia.Visible = False
		'
		'txtIdMidia
		'
		Me.txtIdMidia.Location = New System.Drawing.Point(22, 62)
		Me.txtIdMidia.Name = "txtIdMidia"
		Me.txtIdMidia.ReadOnly = True
		Me.txtIdMidia.Size = New System.Drawing.Size(100, 20)
		Me.txtIdMidia.TabIndex = 2
		Me.txtIdMidia.Visible = False
		'
		'btnExcluirMidia
		'
		Me.btnExcluirMidia.Location = New System.Drawing.Point(22, 137)
		Me.btnExcluirMidia.Name = "btnExcluirMidia"
		Me.btnExcluirMidia.Size = New System.Drawing.Size(75, 23)
		Me.btnExcluirMidia.TabIndex = 2
		Me.btnExcluirMidia.Text = "Excluir"
		Me.btnExcluirMidia.UseVisualStyleBackColor = True
		'
		'btnLimparCadastro
		'
		Me.btnLimparCadastro.Location = New System.Drawing.Point(258, 137)
		Me.btnLimparCadastro.Name = "btnLimparCadastro"
		Me.btnLimparCadastro.Size = New System.Drawing.Size(75, 23)
		Me.btnLimparCadastro.TabIndex = 2
		Me.btnLimparCadastro.Text = "Limpar"
		Me.btnLimparCadastro.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(22, 4)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Tipo de Mídia"
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(339, 137)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.btnCancelar.TabIndex = 2
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = True
		'
		'btnSalvarMidia
		'
		Me.btnSalvarMidia.Location = New System.Drawing.Point(420, 118)
		Me.btnSalvarMidia.Name = "btnSalvarMidia"
		Me.btnSalvarMidia.Size = New System.Drawing.Size(75, 60)
		Me.btnSalvarMidia.TabIndex = 2
		Me.btnSalvarMidia.Text = "Salvar"
		Me.btnSalvarMidia.UseVisualStyleBackColor = True
		'
		'txtTipoDeMidia
		'
		Me.txtTipoDeMidia.Location = New System.Drawing.Point(22, 20)
		Me.txtTipoDeMidia.MaxLength = 50
		Me.txtTipoDeMidia.Name = "txtTipoDeMidia"
		Me.txtTipoDeMidia.Size = New System.Drawing.Size(461, 20)
		Me.txtTipoDeMidia.TabIndex = 0
		'
		'tbpPesquisaMidia
		'
		Me.tbpPesquisaMidia.Controls.Add(Me.btnLimparCosulta)
		Me.tbpPesquisaMidia.Controls.Add(Me.btnConsultarFilme)
		Me.tbpPesquisaMidia.Controls.Add(Me.grdConsultaMidia)
		Me.tbpPesquisaMidia.Controls.Add(Me.Label2)
		Me.tbpPesquisaMidia.Controls.Add(Me.txtConsultaTipoDeMidia)
		Me.tbpPesquisaMidia.Location = New System.Drawing.Point(4, 22)
		Me.tbpPesquisaMidia.Name = "tbpPesquisaMidia"
		Me.tbpPesquisaMidia.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpPesquisaMidia.Size = New System.Drawing.Size(501, 184)
		Me.tbpPesquisaMidia.TabIndex = 1
		Me.tbpPesquisaMidia.Text = "Pesquisa"
		Me.tbpPesquisaMidia.UseVisualStyleBackColor = True
		'
		'btnLimparCosulta
		'
		Me.btnLimparCosulta.Location = New System.Drawing.Point(115, 44)
		Me.btnLimparCosulta.Name = "btnLimparCosulta"
		Me.btnLimparCosulta.Size = New System.Drawing.Size(103, 23)
		Me.btnLimparCosulta.TabIndex = 2
		Me.btnLimparCosulta.Text = "Limpar Pesquisa"
		Me.btnLimparCosulta.UseVisualStyleBackColor = True
		'
		'btnConsultarFilme
		'
		Me.btnConsultarFilme.Location = New System.Drawing.Point(6, 44)
		Me.btnConsultarFilme.Name = "btnConsultarFilme"
		Me.btnConsultarFilme.Size = New System.Drawing.Size(103, 23)
		Me.btnConsultarFilme.TabIndex = 2
		Me.btnConsultarFilme.Text = "Pesquisar"
		Me.btnConsultarFilme.UseVisualStyleBackColor = True
		'
		'grdConsultaMidia
		'
		Me.grdConsultaMidia.AllowUserToAddRows = False
		Me.grdConsultaMidia.AllowUserToDeleteRows = False
		Me.grdConsultaMidia.AllowUserToResizeRows = False
		Me.grdConsultaMidia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdConsultaMidia.Location = New System.Drawing.Point(3, 73)
		Me.grdConsultaMidia.Name = "grdConsultaMidia"
		Me.grdConsultaMidia.RowHeadersVisible = False
		Me.grdConsultaMidia.Size = New System.Drawing.Size(492, 105)
		Me.grdConsultaMidia.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(6, 4)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(73, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Tipo de Mídia"
		'
		'txtConsultaTipoDeMidia
		'
		Me.txtConsultaTipoDeMidia.Location = New System.Drawing.Point(6, 20)
		Me.txtConsultaTipoDeMidia.MaxLength = 50
		Me.txtConsultaTipoDeMidia.Name = "txtConsultaTipoDeMidia"
		Me.txtConsultaTipoDeMidia.Size = New System.Drawing.Size(489, 20)
		Me.txtConsultaTipoDeMidia.TabIndex = 2
		'
		'FrmCadMidia
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(533, 234)
		Me.Controls.Add(Me.tbpCadMidia)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "FrmCadMidia"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cadastro de Tipos de Mídia"
		Me.tbpCadMidia.ResumeLayout(False)
		Me.tbpCadastroMidia.ResumeLayout(False)
		Me.tbpCadastroMidia.PerformLayout()
		Me.tbpPesquisaMidia.ResumeLayout(False)
		Me.tbpPesquisaMidia.PerformLayout()
		CType(Me.grdConsultaMidia, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tbpCadMidia As TabControl
	Friend WithEvents tbpCadastroMidia As TabPage
	Friend WithEvents tbpPesquisaMidia As TabPage
	Friend WithEvents txtTipoDeMidia As TextBox
	Friend WithEvents btnCancelar As Button
	Friend WithEvents btnSalvarMidia As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents btnExcluirMidia As Button
	Friend WithEvents btnLimparCadastro As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents txtConsultaTipoDeMidia As TextBox
	Friend WithEvents grdConsultaMidia As DataGridView
	Friend WithEvents btnConsultarFilme As Button
	Friend WithEvents btnLimparCosulta As Button
	Friend WithEvents lbIdMidia As Label
	Friend WithEvents txtIdMidia As TextBox
End Class
