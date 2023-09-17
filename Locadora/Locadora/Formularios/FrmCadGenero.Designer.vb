<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadGenero
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
		Me.tbpGeral = New System.Windows.Forms.TabControl()
		Me.TabCadastro = New System.Windows.Forms.TabPage()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnExcluir = New System.Windows.Forms.Button()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.txtNome = New System.Windows.Forms.TextBox()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TabPesquisa = New System.Windows.Forms.TabPage()
		Me.btnPesquisar = New System.Windows.Forms.Button()
		Me.grdGenero = New System.Windows.Forms.DataGridView()
		Me.tbpGeral.SuspendLayout()
		Me.TabCadastro.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.TabPesquisa.SuspendLayout()
		CType(Me.grdGenero, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tbpGeral
		'
		Me.tbpGeral.Controls.Add(Me.TabCadastro)
		Me.tbpGeral.Controls.Add(Me.TabPesquisa)
		Me.tbpGeral.Location = New System.Drawing.Point(8, 5)
		Me.tbpGeral.Name = "tbpGeral"
		Me.tbpGeral.SelectedIndex = 0
		Me.tbpGeral.Size = New System.Drawing.Size(513, 215)
		Me.tbpGeral.TabIndex = 0
		'
		'TabCadastro
		'
		Me.TabCadastro.Controls.Add(Me.GroupBox1)
		Me.TabCadastro.Location = New System.Drawing.Point(4, 22)
		Me.TabCadastro.Name = "TabCadastro"
		Me.TabCadastro.Padding = New System.Windows.Forms.Padding(3)
		Me.TabCadastro.Size = New System.Drawing.Size(505, 189)
		Me.TabCadastro.TabIndex = 1
		Me.TabCadastro.Text = "Cadastro"
		Me.TabCadastro.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnExcluir)
		Me.GroupBox1.Controls.Add(Me.btnSalvar)
		Me.GroupBox1.Controls.Add(Me.txtNome)
		Me.GroupBox1.Controls.Add(Me.txtCodigo)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(485, 179)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		'
		'btnExcluir
		'
		Me.btnExcluir.Location = New System.Drawing.Point(157, 135)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(157, 24)
		Me.btnExcluir.TabIndex = 5
		Me.btnExcluir.Text = "Excluir"
		Me.btnExcluir.UseVisualStyleBackColor = True
		'
		'btnSalvar
		'
		Me.btnSalvar.Location = New System.Drawing.Point(157, 85)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(157, 24)
		Me.btnSalvar.TabIndex = 4
		Me.btnSalvar.Text = "Salvar"
		Me.btnSalvar.UseVisualStyleBackColor = True
		'
		'txtNome
		'
		Me.txtNome.Location = New System.Drawing.Point(102, 32)
		Me.txtNome.MaxLength = 60
		Me.txtNome.Name = "txtNome"
		Me.txtNome.Size = New System.Drawing.Size(362, 20)
		Me.txtNome.TabIndex = 3
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(19, 32)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.ReadOnly = True
		Me.txtCodigo.Size = New System.Drawing.Size(68, 20)
		Me.txtCodigo.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(99, 16)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Nome"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(16, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(40, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Código"
		'
		'TabPesquisa
		'
		Me.TabPesquisa.Controls.Add(Me.btnPesquisar)
		Me.TabPesquisa.Controls.Add(Me.grdGenero)
		Me.TabPesquisa.Location = New System.Drawing.Point(4, 22)
		Me.TabPesquisa.Name = "TabPesquisa"
		Me.TabPesquisa.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPesquisa.Size = New System.Drawing.Size(505, 189)
		Me.TabPesquisa.TabIndex = 0
		Me.TabPesquisa.Text = "Pesquisa"
		Me.TabPesquisa.UseVisualStyleBackColor = True
		'
		'btnPesquisar
		'
		Me.btnPesquisar.Location = New System.Drawing.Point(360, 7)
		Me.btnPesquisar.Name = "btnPesquisar"
		Me.btnPesquisar.Size = New System.Drawing.Size(129, 24)
		Me.btnPesquisar.TabIndex = 1
		Me.btnPesquisar.Text = "Pesquisar"
		Me.btnPesquisar.UseVisualStyleBackColor = True
		'
		'grdGenero
		'
		Me.grdGenero.AllowUserToAddRows = False
		Me.grdGenero.AllowUserToDeleteRows = False
		Me.grdGenero.AllowUserToResizeRows = False
		Me.grdGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdGenero.Location = New System.Drawing.Point(6, 35)
		Me.grdGenero.Name = "grdGenero"
		Me.grdGenero.RowHeadersVisible = False
		Me.grdGenero.Size = New System.Drawing.Size(493, 148)
		Me.grdGenero.TabIndex = 0
		'
		'FrmCadGenero
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(526, 232)
		Me.Controls.Add(Me.tbpGeral)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "FrmCadGenero"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cadastro de Gênero"
		Me.tbpGeral.ResumeLayout(False)
		Me.TabCadastro.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.TabPesquisa.ResumeLayout(False)
		CType(Me.grdGenero, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tbpGeral As TabControl
    Friend WithEvents TabPesquisa As TabPage
    Friend WithEvents TabCadastro As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grdGenero As DataGridView
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnExcluir As Button
End Class
