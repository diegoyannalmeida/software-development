<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadFilmes
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
		Me.tbpFilmes = New System.Windows.Forms.TabControl()
		Me.tbpPesquisaFilmes = New System.Windows.Forms.TabPage()
		Me.lbId = New System.Windows.Forms.Label()
		Me.txtPesquisaId = New System.Windows.Forms.TextBox()
		Me.grdPesquisaFilmes = New System.Windows.Forms.DataGridView()
		Me.cmbPesquisaGenero = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtPesquisaNome = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnPesquisarFilme = New System.Windows.Forms.Button()
		Me.btnLimparCosulta = New System.Windows.Forms.Button()
		Me.tbpCadastroFilmes = New System.Windows.Forms.TabPage()
		Me.cmbTipoDeMidia = New System.Windows.Forms.ComboBox()
		Me.txtQtdeMidias = New System.Windows.Forms.TextBox()
		Me.txtDuracao = New System.Windows.Forms.TextBox()
		Me.btnExcluirCadastro = New System.Windows.Forms.Button()
		Me.btnLimparTelaCadastro = New System.Windows.Forms.Button()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.cmbGenero = New System.Windows.Forms.ComboBox()
		Me.txtAnoLancamento = New System.Windows.Forms.TextBox()
		Me.lbNomeFilme = New System.Windows.Forms.Label()
		Me.txtTituloFilme = New System.Windows.Forms.TextBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtValorlocacao = New System.Windows.Forms.TextBox()
		Me.lbTipoMidias = New System.Windows.Forms.Label()
		Me.lbQtdFitas = New System.Windows.Forms.Label()
		Me.lbIdFilme = New System.Windows.Forms.Label()
		Me.txtIdFilme = New System.Windows.Forms.TextBox()
		Me.lbEstoqueAtualCadastro = New System.Windows.Forms.Label()
		Me.txtQtdeEstoqueCadastro = New System.Windows.Forms.TextBox()
		Me.lbDuracao = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lbEstoqueInicial = New System.Windows.Forms.Label()
		Me.lbGenero = New System.Windows.Forms.Label()
		Me.txtQtdeEstoqueInicial = New System.Windows.Forms.TextBox()
		Me.tbpEstoque = New System.Windows.Forms.TabPage()
		Me.gpbBotoesEstoque = New System.Windows.Forms.GroupBox()
		Me.btnCancelarEstoque = New System.Windows.Forms.Button()
		Me.gpbListaEstoque = New System.Windows.Forms.GroupBox()
		Me.grdEstoque = New System.Windows.Forms.DataGridView()
		Me.gpbDadosEstoque = New System.Windows.Forms.GroupBox()
		Me.btnEstoqueRemover = New System.Windows.Forms.Button()
		Me.btnEstoqueAdicionar = New System.Windows.Forms.Button()
		Me.lbQtdeEstoque = New System.Windows.Forms.Label()
		Me.lbQtdeAtualizarEstoque = New System.Windows.Forms.Label()
		Me.txtEstoqueAtual = New System.Windows.Forms.TextBox()
		Me.txtAtualizaQuantidadeEstoque = New System.Windows.Forms.TextBox()
		Me.tbpFilmes.SuspendLayout()
		Me.tbpPesquisaFilmes.SuspendLayout()
		CType(Me.grdPesquisaFilmes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.tbpCadastroFilmes.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.tbpEstoque.SuspendLayout()
		Me.gpbBotoesEstoque.SuspendLayout()
		Me.gpbListaEstoque.SuspendLayout()
		CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gpbDadosEstoque.SuspendLayout()
		Me.SuspendLayout()
		'
		'tbpFilmes
		'
		Me.tbpFilmes.Controls.Add(Me.tbpPesquisaFilmes)
		Me.tbpFilmes.Controls.Add(Me.tbpCadastroFilmes)
		Me.tbpFilmes.Controls.Add(Me.tbpEstoque)
		Me.tbpFilmes.Location = New System.Drawing.Point(12, 12)
		Me.tbpFilmes.Name = "tbpFilmes"
		Me.tbpFilmes.SelectedIndex = 0
		Me.tbpFilmes.Size = New System.Drawing.Size(756, 503)
		Me.tbpFilmes.TabIndex = 0
		'
		'tbpPesquisaFilmes
		'
		Me.tbpPesquisaFilmes.Controls.Add(Me.lbId)
		Me.tbpPesquisaFilmes.Controls.Add(Me.txtPesquisaId)
		Me.tbpPesquisaFilmes.Controls.Add(Me.grdPesquisaFilmes)
		Me.tbpPesquisaFilmes.Controls.Add(Me.cmbPesquisaGenero)
		Me.tbpPesquisaFilmes.Controls.Add(Me.Label3)
		Me.tbpPesquisaFilmes.Controls.Add(Me.Label1)
		Me.tbpPesquisaFilmes.Controls.Add(Me.txtPesquisaNome)
		Me.tbpPesquisaFilmes.Controls.Add(Me.GroupBox1)
		Me.tbpPesquisaFilmes.Location = New System.Drawing.Point(4, 22)
		Me.tbpPesquisaFilmes.Name = "tbpPesquisaFilmes"
		Me.tbpPesquisaFilmes.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpPesquisaFilmes.Size = New System.Drawing.Size(748, 477)
		Me.tbpPesquisaFilmes.TabIndex = 1
		Me.tbpPesquisaFilmes.Text = "Pesquisa"
		Me.tbpPesquisaFilmes.UseVisualStyleBackColor = True
		'
		'lbId
		'
		Me.lbId.AutoSize = True
		Me.lbId.Location = New System.Drawing.Point(552, 2)
		Me.lbId.Name = "lbId"
		Me.lbId.Size = New System.Drawing.Size(110, 13)
		Me.lbId.TabIndex = 12
		Me.lbId.Text = "Código para Pesquisa"
		'
		'txtPesquisaId
		'
		Me.txtPesquisaId.Location = New System.Drawing.Point(551, 18)
		Me.txtPesquisaId.MaxLength = 4
		Me.txtPesquisaId.Name = "txtPesquisaId"
		Me.txtPesquisaId.Size = New System.Drawing.Size(100, 20)
		Me.txtPesquisaId.TabIndex = 2
		'
		'grdPesquisaFilmes
		'
		Me.grdPesquisaFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdPesquisaFilmes.Location = New System.Drawing.Point(6, 83)
		Me.grdPesquisaFilmes.Name = "grdPesquisaFilmes"
		Me.grdPesquisaFilmes.RowHeadersVisible = False
		Me.grdPesquisaFilmes.Size = New System.Drawing.Size(730, 369)
		Me.grdPesquisaFilmes.TabIndex = 10
		'
		'cmbPesquisaGenero
		'
		Me.cmbPesquisaGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPesquisaGenero.FormattingEnabled = True
		Me.cmbPesquisaGenero.Location = New System.Drawing.Point(372, 18)
		Me.cmbPesquisaGenero.Name = "cmbPesquisaGenero"
		Me.cmbPesquisaGenero.Size = New System.Drawing.Size(173, 21)
		Me.cmbPesquisaGenero.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(369, 1)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(112, 13)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Gênero para Pesquisa"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(7, 2)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 13)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Nome para Pesquisa"
		'
		'txtPesquisaNome
		'
		Me.txtPesquisaNome.Location = New System.Drawing.Point(6, 19)
		Me.txtPesquisaNome.MaxLength = 100
		Me.txtPesquisaNome.Name = "txtPesquisaNome"
		Me.txtPesquisaNome.Size = New System.Drawing.Size(360, 20)
		Me.txtPesquisaNome.TabIndex = 1
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnPesquisarFilme)
		Me.GroupBox1.Controls.Add(Me.btnLimparCosulta)
		Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(739, 76)
		Me.GroupBox1.TabIndex = 13
		Me.GroupBox1.TabStop = False
		'
		'btnPesquisarFilme
		'
		Me.btnPesquisarFilme.Location = New System.Drawing.Point(3, 47)
		Me.btnPesquisarFilme.Name = "btnPesquisarFilme"
		Me.btnPesquisarFilme.Size = New System.Drawing.Size(103, 23)
		Me.btnPesquisarFilme.TabIndex = 3
		Me.btnPesquisarFilme.Text = "Pesquisar"
		Me.btnPesquisarFilme.UseVisualStyleBackColor = True
		'
		'btnLimparCosulta
		'
		Me.btnLimparCosulta.Location = New System.Drawing.Point(112, 47)
		Me.btnLimparCosulta.Name = "btnLimparCosulta"
		Me.btnLimparCosulta.Size = New System.Drawing.Size(103, 23)
		Me.btnLimparCosulta.TabIndex = 4
		Me.btnLimparCosulta.Text = "Limpar Pesquisa"
		Me.btnLimparCosulta.UseVisualStyleBackColor = True
		'
		'tbpCadastroFilmes
		'
		Me.tbpCadastroFilmes.Controls.Add(Me.cmbTipoDeMidia)
		Me.tbpCadastroFilmes.Controls.Add(Me.txtQtdeMidias)
		Me.tbpCadastroFilmes.Controls.Add(Me.txtDuracao)
		Me.tbpCadastroFilmes.Controls.Add(Me.btnExcluirCadastro)
		Me.tbpCadastroFilmes.Controls.Add(Me.btnLimparTelaCadastro)
		Me.tbpCadastroFilmes.Controls.Add(Me.btnSalvar)
		Me.tbpCadastroFilmes.Controls.Add(Me.btnCancelar)
		Me.tbpCadastroFilmes.Controls.Add(Me.cmbGenero)
		Me.tbpCadastroFilmes.Controls.Add(Me.txtAnoLancamento)
		Me.tbpCadastroFilmes.Controls.Add(Me.lbNomeFilme)
		Me.tbpCadastroFilmes.Controls.Add(Me.txtTituloFilme)
		Me.tbpCadastroFilmes.Controls.Add(Me.GroupBox2)
		Me.tbpCadastroFilmes.Location = New System.Drawing.Point(4, 22)
		Me.tbpCadastroFilmes.Name = "tbpCadastroFilmes"
		Me.tbpCadastroFilmes.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpCadastroFilmes.Size = New System.Drawing.Size(748, 477)
		Me.tbpCadastroFilmes.TabIndex = 0
		Me.tbpCadastroFilmes.Text = "Cadastro"
		Me.tbpCadastroFilmes.UseVisualStyleBackColor = True
		'
		'cmbTipoDeMidia
		'
		Me.cmbTipoDeMidia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTipoDeMidia.FormattingEnabled = True
		Me.cmbTipoDeMidia.Location = New System.Drawing.Point(123, 76)
		Me.cmbTipoDeMidia.Name = "cmbTipoDeMidia"
		Me.cmbTipoDeMidia.Size = New System.Drawing.Size(121, 21)
		Me.cmbTipoDeMidia.TabIndex = 4
		'
		'txtQtdeMidias
		'
		Me.txtQtdeMidias.Location = New System.Drawing.Point(250, 77)
		Me.txtQtdeMidias.MaxLength = 2
		Me.txtQtdeMidias.Name = "txtQtdeMidias"
		Me.txtQtdeMidias.Size = New System.Drawing.Size(76, 20)
		Me.txtQtdeMidias.TabIndex = 4
		'
		'txtDuracao
		'
		Me.txtDuracao.Location = New System.Drawing.Point(21, 76)
		Me.txtDuracao.MaxLength = 3
		Me.txtDuracao.Name = "txtDuracao"
		Me.txtDuracao.Size = New System.Drawing.Size(96, 20)
		Me.txtDuracao.TabIndex = 4
		'
		'btnExcluirCadastro
		'
		Me.btnExcluirCadastro.Location = New System.Drawing.Point(399, 425)
		Me.btnExcluirCadastro.Name = "btnExcluirCadastro"
		Me.btnExcluirCadastro.Size = New System.Drawing.Size(75, 23)
		Me.btnExcluirCadastro.TabIndex = 5
		Me.btnExcluirCadastro.Text = "Excluir"
		Me.btnExcluirCadastro.UseVisualStyleBackColor = True
		'
		'btnLimparTelaCadastro
		'
		Me.btnLimparTelaCadastro.Location = New System.Drawing.Point(499, 425)
		Me.btnLimparTelaCadastro.Name = "btnLimparTelaCadastro"
		Me.btnLimparTelaCadastro.Size = New System.Drawing.Size(75, 23)
		Me.btnLimparTelaCadastro.TabIndex = 6
		Me.btnLimparTelaCadastro.Text = "Limpar"
		Me.btnLimparTelaCadastro.UseVisualStyleBackColor = True
		'
		'btnSalvar
		'
		Me.btnSalvar.Location = New System.Drawing.Point(661, 407)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(75, 59)
		Me.btnSalvar.TabIndex = 8
		Me.btnSalvar.Text = "Salvar"
		Me.btnSalvar.UseVisualStyleBackColor = True
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(580, 425)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.btnCancelar.TabIndex = 7
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = True
		'
		'cmbGenero
		'
		Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbGenero.FormattingEnabled = True
		Me.cmbGenero.Location = New System.Drawing.Point(407, 32)
		Me.cmbGenero.MaxDropDownItems = 10
		Me.cmbGenero.Name = "cmbGenero"
		Me.cmbGenero.Size = New System.Drawing.Size(224, 21)
		Me.cmbGenero.TabIndex = 2
		'
		'txtAnoLancamento
		'
		Me.txtAnoLancamento.Location = New System.Drawing.Point(637, 33)
		Me.txtAnoLancamento.MaxLength = 4
		Me.txtAnoLancamento.Name = "txtAnoLancamento"
		Me.txtAnoLancamento.Size = New System.Drawing.Size(96, 20)
		Me.txtAnoLancamento.TabIndex = 4
		'
		'lbNomeFilme
		'
		Me.lbNomeFilme.AutoSize = True
		Me.lbNomeFilme.Location = New System.Drawing.Point(18, 16)
		Me.lbNomeFilme.Name = "lbNomeFilme"
		Me.lbNomeFilme.Size = New System.Drawing.Size(77, 13)
		Me.lbNomeFilme.TabIndex = 1
		Me.lbNomeFilme.Text = "Título do Filme"
		'
		'txtTituloFilme
		'
		Me.txtTituloFilme.Location = New System.Drawing.Point(21, 33)
		Me.txtTituloFilme.MaxLength = 100
		Me.txtTituloFilme.Name = "txtTituloFilme"
		Me.txtTituloFilme.Size = New System.Drawing.Size(380, 20)
		Me.txtTituloFilme.TabIndex = 0
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.txtValorlocacao)
		Me.GroupBox2.Controls.Add(Me.lbTipoMidias)
		Me.GroupBox2.Controls.Add(Me.lbQtdFitas)
		Me.GroupBox2.Controls.Add(Me.lbIdFilme)
		Me.GroupBox2.Controls.Add(Me.txtIdFilme)
		Me.GroupBox2.Controls.Add(Me.lbEstoqueAtualCadastro)
		Me.GroupBox2.Controls.Add(Me.txtQtdeEstoqueCadastro)
		Me.GroupBox2.Controls.Add(Me.lbDuracao)
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.lbEstoqueInicial)
		Me.GroupBox2.Controls.Add(Me.lbGenero)
		Me.GroupBox2.Controls.Add(Me.txtQtdeEstoqueInicial)
		Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(733, 145)
		Me.GroupBox2.TabIndex = 33
		Me.GroupBox2.TabStop = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(425, 53)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(87, 13)
		Me.Label6.TabIndex = 41
		Me.Label6.Text = "Valor da locação"
		'
		'txtValorlocacao
		'
		Me.txtValorlocacao.Location = New System.Drawing.Point(428, 71)
		Me.txtValorlocacao.MaxLength = 2
		Me.txtValorlocacao.Name = "txtValorlocacao"
		Me.txtValorlocacao.Size = New System.Drawing.Size(96, 20)
		Me.txtValorlocacao.TabIndex = 4
		'
		'lbTipoMidias
		'
		Me.lbTipoMidias.AutoSize = True
		Me.lbTipoMidias.Location = New System.Drawing.Point(114, 53)
		Me.lbTipoMidias.Name = "lbTipoMidias"
		Me.lbTipoMidias.Size = New System.Drawing.Size(73, 13)
		Me.lbTipoMidias.TabIndex = 13
		Me.lbTipoMidias.Text = "Tipo de Mídia"
		'
		'lbQtdFitas
		'
		Me.lbQtdFitas.AutoSize = True
		Me.lbQtdFitas.Location = New System.Drawing.Point(241, 53)
		Me.lbQtdFitas.Name = "lbQtdFitas"
		Me.lbQtdFitas.Size = New System.Drawing.Size(83, 13)
		Me.lbQtdFitas.TabIndex = 12
		Me.lbQtdFitas.Text = "Qtde. de Mídias"
		'
		'lbIdFilme
		'
		Me.lbIdFilme.AutoSize = True
		Me.lbIdFilme.Location = New System.Drawing.Point(12, 102)
		Me.lbIdFilme.Name = "lbIdFilme"
		Me.lbIdFilme.Size = New System.Drawing.Size(56, 13)
		Me.lbIdFilme.TabIndex = 39
		Me.lbIdFilme.Text = "Cód. Filme"
		Me.lbIdFilme.Visible = False
		'
		'txtIdFilme
		'
		Me.txtIdFilme.Location = New System.Drawing.Point(15, 119)
		Me.txtIdFilme.Name = "txtIdFilme"
		Me.txtIdFilme.ReadOnly = True
		Me.txtIdFilme.Size = New System.Drawing.Size(100, 20)
		Me.txtIdFilme.TabIndex = 38
		Me.txtIdFilme.Visible = False
		'
		'lbEstoqueAtualCadastro
		'
		Me.lbEstoqueAtualCadastro.AutoSize = True
		Me.lbEstoqueAtualCadastro.Location = New System.Drawing.Point(527, 53)
		Me.lbEstoqueAtualCadastro.Name = "lbEstoqueAtualCadastro"
		Me.lbEstoqueAtualCadastro.Size = New System.Drawing.Size(73, 13)
		Me.lbEstoqueAtualCadastro.TabIndex = 37
		Me.lbEstoqueAtualCadastro.Text = "Estoque Atual"
		'
		'txtQtdeEstoqueCadastro
		'
		Me.txtQtdeEstoqueCadastro.Location = New System.Drawing.Point(530, 71)
		Me.txtQtdeEstoqueCadastro.MaxLength = 2
		Me.txtQtdeEstoqueCadastro.Name = "txtQtdeEstoqueCadastro"
		Me.txtQtdeEstoqueCadastro.ReadOnly = True
		Me.txtQtdeEstoqueCadastro.Size = New System.Drawing.Size(76, 20)
		Me.txtQtdeEstoqueCadastro.TabIndex = 4
		'
		'lbDuracao
		'
		Me.lbDuracao.AutoSize = True
		Me.lbDuracao.Location = New System.Drawing.Point(12, 53)
		Me.lbDuracao.Name = "lbDuracao"
		Me.lbDuracao.Size = New System.Drawing.Size(94, 13)
		Me.lbDuracao.TabIndex = 10
		Me.lbDuracao.Text = "Duração (Minutos)"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(628, 10)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(99, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Ano de lançamento"
		'
		'lbEstoqueInicial
		'
		Me.lbEstoqueInicial.AutoSize = True
		Me.lbEstoqueInicial.Location = New System.Drawing.Point(323, 53)
		Me.lbEstoqueInicial.Name = "lbEstoqueInicial"
		Me.lbEstoqueInicial.Size = New System.Drawing.Size(76, 13)
		Me.lbEstoqueInicial.TabIndex = 35
		Me.lbEstoqueInicial.Text = "Estoque Inicial"
		'
		'lbGenero
		'
		Me.lbGenero.AutoSize = True
		Me.lbGenero.Location = New System.Drawing.Point(398, 10)
		Me.lbGenero.Name = "lbGenero"
		Me.lbGenero.Size = New System.Drawing.Size(42, 13)
		Me.lbGenero.TabIndex = 3
		Me.lbGenero.Text = "Gênero"
		'
		'txtQtdeEstoqueInicial
		'
		Me.txtQtdeEstoqueInicial.Location = New System.Drawing.Point(326, 69)
		Me.txtQtdeEstoqueInicial.MaxLength = 2
		Me.txtQtdeEstoqueInicial.Name = "txtQtdeEstoqueInicial"
		Me.txtQtdeEstoqueInicial.Size = New System.Drawing.Size(96, 20)
		Me.txtQtdeEstoqueInicial.TabIndex = 4
		'
		'tbpEstoque
		'
		Me.tbpEstoque.Controls.Add(Me.gpbBotoesEstoque)
		Me.tbpEstoque.Controls.Add(Me.gpbListaEstoque)
		Me.tbpEstoque.Controls.Add(Me.gpbDadosEstoque)
		Me.tbpEstoque.Location = New System.Drawing.Point(4, 22)
		Me.tbpEstoque.Name = "tbpEstoque"
		Me.tbpEstoque.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpEstoque.Size = New System.Drawing.Size(748, 477)
		Me.tbpEstoque.TabIndex = 2
		Me.tbpEstoque.Text = "Estoque"
		Me.tbpEstoque.UseVisualStyleBackColor = True
		'
		'gpbBotoesEstoque
		'
		Me.gpbBotoesEstoque.Controls.Add(Me.btnCancelarEstoque)
		Me.gpbBotoesEstoque.Location = New System.Drawing.Point(6, 216)
		Me.gpbBotoesEstoque.Name = "gpbBotoesEstoque"
		Me.gpbBotoesEstoque.Size = New System.Drawing.Size(736, 255)
		Me.gpbBotoesEstoque.TabIndex = 2
		Me.gpbBotoesEstoque.TabStop = False
		'
		'btnCancelarEstoque
		'
		Me.btnCancelarEstoque.Location = New System.Drawing.Point(655, 208)
		Me.btnCancelarEstoque.Name = "btnCancelarEstoque"
		Me.btnCancelarEstoque.Size = New System.Drawing.Size(75, 23)
		Me.btnCancelarEstoque.TabIndex = 0
		Me.btnCancelarEstoque.Text = "Cancelar"
		Me.btnCancelarEstoque.UseVisualStyleBackColor = True
		'
		'gpbListaEstoque
		'
		Me.gpbListaEstoque.Controls.Add(Me.grdEstoque)
		Me.gpbListaEstoque.Location = New System.Drawing.Point(6, 110)
		Me.gpbListaEstoque.Name = "gpbListaEstoque"
		Me.gpbListaEstoque.Size = New System.Drawing.Size(736, 106)
		Me.gpbListaEstoque.TabIndex = 1
		Me.gpbListaEstoque.TabStop = False
		'
		'grdEstoque
		'
		Me.grdEstoque.AllowUserToAddRows = False
		Me.grdEstoque.AllowUserToDeleteRows = False
		Me.grdEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdEstoque.Location = New System.Drawing.Point(6, 11)
		Me.grdEstoque.Name = "grdEstoque"
		Me.grdEstoque.ReadOnly = True
		Me.grdEstoque.RowHeadersVisible = False
		Me.grdEstoque.Size = New System.Drawing.Size(724, 89)
		Me.grdEstoque.TabIndex = 0
		'
		'gpbDadosEstoque
		'
		Me.gpbDadosEstoque.Controls.Add(Me.btnEstoqueRemover)
		Me.gpbDadosEstoque.Controls.Add(Me.btnEstoqueAdicionar)
		Me.gpbDadosEstoque.Controls.Add(Me.lbQtdeEstoque)
		Me.gpbDadosEstoque.Controls.Add(Me.lbQtdeAtualizarEstoque)
		Me.gpbDadosEstoque.Controls.Add(Me.txtEstoqueAtual)
		Me.gpbDadosEstoque.Controls.Add(Me.txtAtualizaQuantidadeEstoque)
		Me.gpbDadosEstoque.Location = New System.Drawing.Point(6, 15)
		Me.gpbDadosEstoque.Name = "gpbDadosEstoque"
		Me.gpbDadosEstoque.Size = New System.Drawing.Size(736, 100)
		Me.gpbDadosEstoque.TabIndex = 0
		Me.gpbDadosEstoque.TabStop = False
		'
		'btnEstoqueRemover
		'
		Me.btnEstoqueRemover.Location = New System.Drawing.Point(155, 71)
		Me.btnEstoqueRemover.Name = "btnEstoqueRemover"
		Me.btnEstoqueRemover.Size = New System.Drawing.Size(100, 23)
		Me.btnEstoqueRemover.TabIndex = 5
		Me.btnEstoqueRemover.Text = "Remover"
		Me.btnEstoqueRemover.UseVisualStyleBackColor = True
		'
		'btnEstoqueAdicionar
		'
		Me.btnEstoqueAdicionar.Location = New System.Drawing.Point(9, 71)
		Me.btnEstoqueAdicionar.Name = "btnEstoqueAdicionar"
		Me.btnEstoqueAdicionar.Size = New System.Drawing.Size(97, 23)
		Me.btnEstoqueAdicionar.TabIndex = 4
		Me.btnEstoqueAdicionar.Text = "Adicionar"
		Me.btnEstoqueAdicionar.UseVisualStyleBackColor = True
		'
		'lbQtdeEstoque
		'
		Me.lbQtdeEstoque.AutoSize = True
		Me.lbQtdeEstoque.Location = New System.Drawing.Point(152, 16)
		Me.lbQtdeEstoque.Name = "lbQtdeEstoque"
		Me.lbQtdeEstoque.Size = New System.Drawing.Size(73, 13)
		Me.lbQtdeEstoque.TabIndex = 3
		Me.lbQtdeEstoque.Text = "Estoque Atual"
		'
		'lbQtdeAtualizarEstoque
		'
		Me.lbQtdeAtualizarEstoque.AutoSize = True
		Me.lbQtdeAtualizarEstoque.Location = New System.Drawing.Point(6, 16)
		Me.lbQtdeAtualizarEstoque.Name = "lbQtdeAtualizarEstoque"
		Me.lbQtdeAtualizarEstoque.Size = New System.Drawing.Size(62, 13)
		Me.lbQtdeAtualizarEstoque.TabIndex = 2
		Me.lbQtdeAtualizarEstoque.Text = "Quantidade"
		'
		'txtEstoqueAtual
		'
		Me.txtEstoqueAtual.Location = New System.Drawing.Point(155, 32)
		Me.txtEstoqueAtual.Name = "txtEstoqueAtual"
		Me.txtEstoqueAtual.ReadOnly = True
		Me.txtEstoqueAtual.Size = New System.Drawing.Size(100, 20)
		Me.txtEstoqueAtual.TabIndex = 1
		'
		'txtAtualizaQuantidadeEstoque
		'
		Me.txtAtualizaQuantidadeEstoque.Location = New System.Drawing.Point(6, 32)
		Me.txtAtualizaQuantidadeEstoque.Name = "txtAtualizaQuantidadeEstoque"
		Me.txtAtualizaQuantidadeEstoque.Size = New System.Drawing.Size(100, 20)
		Me.txtAtualizaQuantidadeEstoque.TabIndex = 0
		'
		'FrmCadFilmes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(775, 527)
		Me.Controls.Add(Me.tbpFilmes)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "FrmCadFilmes"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cadastro de títulos"
		Me.tbpFilmes.ResumeLayout(False)
		Me.tbpPesquisaFilmes.ResumeLayout(False)
		Me.tbpPesquisaFilmes.PerformLayout()
		CType(Me.grdPesquisaFilmes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.tbpCadastroFilmes.ResumeLayout(False)
		Me.tbpCadastroFilmes.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.tbpEstoque.ResumeLayout(False)
		Me.gpbBotoesEstoque.ResumeLayout(False)
		Me.gpbListaEstoque.ResumeLayout(False)
		CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gpbDadosEstoque.ResumeLayout(False)
		Me.gpbDadosEstoque.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tbpFilmes As TabControl
	Friend WithEvents tbpCadastroFilmes As TabPage
	Friend WithEvents tbpPesquisaFilmes As TabPage
	Friend WithEvents lbNomeFilme As Label
	Friend WithEvents txtTituloFilme As TextBox
	Friend WithEvents cmbGenero As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtAnoLancamento As TextBox
	Friend WithEvents lbGenero As Label
	Friend WithEvents txtPesquisaNome As TextBox
	Friend WithEvents grdPesquisaFilmes As DataGridView
	Friend WithEvents cmbPesquisaGenero As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents btnSalvar As Button
	Friend WithEvents btnCancelar As Button
	Friend WithEvents btnPesquisarFilme As Button
	Friend WithEvents btnLimparCosulta As Button
	Friend WithEvents btnExcluirCadastro As Button
	Friend WithEvents btnLimparTelaCadastro As Button
	Friend WithEvents lbQtdFitas As Label
	Friend WithEvents txtQtdeMidias As TextBox
	Friend WithEvents lbDuracao As Label
	Friend WithEvents txtDuracao As TextBox
	Friend WithEvents cmbTipoDeMidia As ComboBox
	Friend WithEvents lbTipoMidias As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents lbEstoqueInicial As Label
	Friend WithEvents txtQtdeEstoqueInicial As TextBox
	Friend WithEvents lbId As Label
	Friend WithEvents txtPesquisaId As TextBox
	Friend WithEvents lbEstoqueAtualCadastro As Label
	Friend WithEvents txtQtdeEstoqueCadastro As TextBox
	Friend WithEvents lbIdFilme As Label
	Friend WithEvents txtIdFilme As TextBox
	Friend WithEvents tbpEstoque As TabPage
	Friend WithEvents Label6 As Label
	Friend WithEvents txtValorlocacao As TextBox
	Friend WithEvents gpbBotoesEstoque As GroupBox
	Friend WithEvents btnCancelarEstoque As Button
	Friend WithEvents gpbListaEstoque As GroupBox
	Friend WithEvents grdEstoque As DataGridView
	Friend WithEvents gpbDadosEstoque As GroupBox
	Friend WithEvents btnEstoqueRemover As Button
	Friend WithEvents btnEstoqueAdicionar As Button
	Friend WithEvents lbQtdeEstoque As Label
	Friend WithEvents lbQtdeAtualizarEstoque As Label
	Friend WithEvents txtEstoqueAtual As TextBox
	Friend WithEvents txtAtualizaQuantidadeEstoque As TextBox
End Class
