<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadCliente
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
        Me.tbpPesquisaCliente = New System.Windows.Forms.TabPage()
        Me.btnPesquisarCliente = New System.Windows.Forms.Button()
        Me.txtCpfPesquisa = New System.Windows.Forms.TextBox()
        Me.txtCodClientePesquisa = New System.Windows.Forms.TextBox()
        Me.lbCodPesquisa = New System.Windows.Forms.Label()
        Me.btnLimparPesquisa = New System.Windows.Forms.Button()
        Me.lbCpfPesquisa = New System.Windows.Forms.Label()
        Me.grdPesquisarCliente = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbpCadastroCliente = New System.Windows.Forms.TabPage()
        Me.btnLimparCadastro = New System.Windows.Forms.Button()
        Me.btnExcluirCadastro = New System.Windows.Forms.Button()
        Me.txtComboUf = New System.Windows.Forms.ComboBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtDataNascimento = New System.Windows.Forms.TextBox()
        Me.txtRg = New System.Windows.Forms.TextBox()
        Me.txtCadastroCpf = New System.Windows.Forms.TextBox()
        Me.txtTelefoneResidencial = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbNAscimento = New System.Windows.Forms.Label()
        Me.lbRg = New System.Windows.Forms.Label()
        Me.lbCpf = New System.Windows.Forms.Label()
        Me.lbCelular = New System.Windows.Forms.Label()
        Me.btnCadClienteCancelar = New System.Windows.Forms.Button()
        Me.btnCadClienteSalvar = New System.Windows.Forms.Button()
        Me.lbUf = New System.Windows.Forms.Label()
        Me.lbCidade = New System.Windows.Forms.Label()
        Me.lbBairro = New System.Windows.Forms.Label()
        Me.lbTelResidencial = New System.Windows.Forms.Label()
        Me.lbCep = New System.Windows.Forms.Label()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.tbLogradouro = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lbSaldoInicial = New System.Windows.Forms.Label()
        Me.tbpClientes = New System.Windows.Forms.TabControl()
        Me.tbpPesquisaCliente.SuspendLayout()
        CType(Me.grdPesquisarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpCadastroCliente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tbpClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpPesquisaCliente
        '
        Me.tbpPesquisaCliente.Controls.Add(Me.btnPesquisarCliente)
        Me.tbpPesquisaCliente.Controls.Add(Me.txtCpfPesquisa)
        Me.tbpPesquisaCliente.Controls.Add(Me.txtCodClientePesquisa)
        Me.tbpPesquisaCliente.Controls.Add(Me.lbCodPesquisa)
        Me.tbpPesquisaCliente.Controls.Add(Me.btnLimparPesquisa)
        Me.tbpPesquisaCliente.Controls.Add(Me.lbCpfPesquisa)
        Me.tbpPesquisaCliente.Controls.Add(Me.grdPesquisarCliente)
        Me.tbpPesquisaCliente.Controls.Add(Me.GroupBox1)
        Me.tbpPesquisaCliente.Location = New System.Drawing.Point(4, 22)
        Me.tbpPesquisaCliente.Name = "tbpPesquisaCliente"
        Me.tbpPesquisaCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPesquisaCliente.Size = New System.Drawing.Size(744, 473)
        Me.tbpPesquisaCliente.TabIndex = 1
        Me.tbpPesquisaCliente.Text = "Pesquisa"
        Me.tbpPesquisaCliente.UseVisualStyleBackColor = True
        '
        'btnPesquisarCliente
        '
        Me.btnPesquisarCliente.Location = New System.Drawing.Point(6, 57)
        Me.btnPesquisarCliente.Name = "btnPesquisarCliente"
        Me.btnPesquisarCliente.Size = New System.Drawing.Size(103, 23)
        Me.btnPesquisarCliente.TabIndex = 3
        Me.btnPesquisarCliente.Text = "Pesquisar"
        Me.btnPesquisarCliente.UseVisualStyleBackColor = True
        '
        'txtCpfPesquisa
        '
        Me.txtCpfPesquisa.Location = New System.Drawing.Point(6, 31)
        Me.txtCpfPesquisa.MaxLength = 11
        Me.txtCpfPesquisa.Name = "txtCpfPesquisa"
        Me.txtCpfPesquisa.Size = New System.Drawing.Size(336, 20)
        Me.txtCpfPesquisa.TabIndex = 0
        '
        'txtCodClientePesquisa
        '
        Me.txtCodClientePesquisa.Location = New System.Drawing.Point(348, 31)
        Me.txtCodClientePesquisa.MaxLength = 4
        Me.txtCodClientePesquisa.Name = "txtCodClientePesquisa"
        Me.txtCodClientePesquisa.Size = New System.Drawing.Size(100, 20)
        Me.txtCodClientePesquisa.TabIndex = 1
        '
        'lbCodPesquisa
        '
        Me.lbCodPesquisa.AutoSize = True
        Me.lbCodPesquisa.Location = New System.Drawing.Point(345, 15)
        Me.lbCodPesquisa.Name = "lbCodPesquisa"
        Me.lbCodPesquisa.Size = New System.Drawing.Size(99, 13)
        Me.lbCodPesquisa.TabIndex = 2
        Me.lbCodPesquisa.Text = "Cód. para Pesquisa"
        '
        'btnLimparPesquisa
        '
        Me.btnLimparPesquisa.Location = New System.Drawing.Point(115, 57)
        Me.btnLimparPesquisa.Name = "btnLimparPesquisa"
        Me.btnLimparPesquisa.Size = New System.Drawing.Size(103, 23)
        Me.btnLimparPesquisa.TabIndex = 8
        Me.btnLimparPesquisa.Text = "Limpar Pesquisa"
        Me.btnLimparPesquisa.UseVisualStyleBackColor = True
        '
        'lbCpfPesquisa
        '
        Me.lbCpfPesquisa.AutoSize = True
        Me.lbCpfPesquisa.Location = New System.Drawing.Point(6, 12)
        Me.lbCpfPesquisa.Name = "lbCpfPesquisa"
        Me.lbCpfPesquisa.Size = New System.Drawing.Size(94, 13)
        Me.lbCpfPesquisa.TabIndex = 3
        Me.lbCpfPesquisa.Text = "Cpf Para Pesquisa"
        '
        'grdPesquisarCliente
        '
        Me.grdPesquisarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPesquisarCliente.Location = New System.Drawing.Point(9, 105)
        Me.grdPesquisarCliente.Name = "grdPesquisarCliente"
        Me.grdPesquisarCliente.RowHeadersVisible = False
        Me.grdPesquisarCliente.Size = New System.Drawing.Size(729, 339)
        Me.grdPesquisarCliente.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 84)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'tbpCadastroCliente
        '
        Me.tbpCadastroCliente.Controls.Add(Me.btnLimparCadastro)
        Me.tbpCadastroCliente.Controls.Add(Me.btnExcluirCadastro)
        Me.tbpCadastroCliente.Controls.Add(Me.txtComboUf)
        Me.tbpCadastroCliente.Controls.Add(Me.txtComplemento)
        Me.tbpCadastroCliente.Controls.Add(Me.txtDataNascimento)
        Me.tbpCadastroCliente.Controls.Add(Me.txtRg)
        Me.tbpCadastroCliente.Controls.Add(Me.txtCadastroCpf)
        Me.tbpCadastroCliente.Controls.Add(Me.txtTelefoneResidencial)
        Me.tbpCadastroCliente.Controls.Add(Me.txtCidade)
        Me.tbpCadastroCliente.Controls.Add(Me.txtBairro)
        Me.tbpCadastroCliente.Controls.Add(Me.txtCelular)
        Me.tbpCadastroCliente.Controls.Add(Me.txtNumero)
        Me.tbpCadastroCliente.Controls.Add(Me.txtCEP)
        Me.tbpCadastroCliente.Controls.Add(Me.txtSexo)
        Me.tbpCadastroCliente.Controls.Add(Me.txtLogradouro)
        Me.tbpCadastroCliente.Controls.Add(Me.txtNome)
        Me.tbpCadastroCliente.Controls.Add(Me.Label1)
        Me.tbpCadastroCliente.Controls.Add(Me.lbNAscimento)
        Me.tbpCadastroCliente.Controls.Add(Me.lbRg)
        Me.tbpCadastroCliente.Controls.Add(Me.lbCpf)
        Me.tbpCadastroCliente.Controls.Add(Me.lbCelular)
        Me.tbpCadastroCliente.Controls.Add(Me.btnCadClienteCancelar)
        Me.tbpCadastroCliente.Controls.Add(Me.btnCadClienteSalvar)
        Me.tbpCadastroCliente.Controls.Add(Me.lbUf)
        Me.tbpCadastroCliente.Controls.Add(Me.lbCidade)
        Me.tbpCadastroCliente.Controls.Add(Me.lbBairro)
        Me.tbpCadastroCliente.Controls.Add(Me.lbTelResidencial)
        Me.tbpCadastroCliente.Controls.Add(Me.lbCep)
        Me.tbpCadastroCliente.Controls.Add(Me.lbNumero)
        Me.tbpCadastroCliente.Controls.Add(Me.lbSexo)
        Me.tbpCadastroCliente.Controls.Add(Me.tbLogradouro)
        Me.tbpCadastroCliente.Controls.Add(Me.lbNome)
        Me.tbpCadastroCliente.Controls.Add(Me.GroupBox2)
        Me.tbpCadastroCliente.Location = New System.Drawing.Point(4, 22)
        Me.tbpCadastroCliente.Name = "tbpCadastroCliente"
        Me.tbpCadastroCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCadastroCliente.Size = New System.Drawing.Size(744, 473)
        Me.tbpCadastroCliente.TabIndex = 0
        Me.tbpCadastroCliente.Text = "Cadastro"
        Me.tbpCadastroCliente.UseVisualStyleBackColor = True
        '
        'btnLimparCadastro
        '
        Me.btnLimparCadastro.Location = New System.Drawing.Point(496, 428)
        Me.btnLimparCadastro.Name = "btnLimparCadastro"
        Me.btnLimparCadastro.Size = New System.Drawing.Size(75, 23)
        Me.btnLimparCadastro.TabIndex = 14
        Me.btnLimparCadastro.Text = "Limpar"
        Me.btnLimparCadastro.UseVisualStyleBackColor = True
        '
        'btnExcluirCadastro
        '
        Me.btnExcluirCadastro.Location = New System.Drawing.Point(388, 428)
        Me.btnExcluirCadastro.Name = "btnExcluirCadastro"
        Me.btnExcluirCadastro.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirCadastro.TabIndex = 16
        Me.btnExcluirCadastro.Text = "Excluir"
        Me.btnExcluirCadastro.UseVisualStyleBackColor = True
        '
        'txtComboUf
        '
        Me.txtComboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtComboUf.FormattingEnabled = True
        Me.txtComboUf.Location = New System.Drawing.Point(639, 147)
        Me.txtComboUf.Name = "txtComboUf"
        Me.txtComboUf.Size = New System.Drawing.Size(94, 21)
        Me.txtComboUf.TabIndex = 10
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(545, 108)
        Me.txtComplemento.MaxLength = 20
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(188, 20)
        Me.txtComplemento.TabIndex = 7
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Location = New System.Drawing.Point(21, 69)
        Me.txtDataNascimento.MaxLength = 8
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(164, 20)
        Me.txtDataNascimento.TabIndex = 1
        '
        'txtRg
        '
        Me.txtRg.Location = New System.Drawing.Point(415, 69)
        Me.txtRg.MaxLength = 9
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(218, 20)
        Me.txtRg.TabIndex = 3
        '
        'txtCadastroCpf
        '
        Me.txtCadastroCpf.Location = New System.Drawing.Point(191, 69)
        Me.txtCadastroCpf.MaxLength = 14
        Me.txtCadastroCpf.Name = "txtCadastroCpf"
        Me.txtCadastroCpf.Size = New System.Drawing.Size(218, 20)
        Me.txtCadastroCpf.TabIndex = 2
        '
        'txtTelefoneResidencial
        '
        Me.txtTelefoneResidencial.Location = New System.Drawing.Point(496, 186)
        Me.txtTelefoneResidencial.MaxLength = 13
        Me.txtTelefoneResidencial.Name = "txtTelefoneResidencial"
        Me.txtTelefoneResidencial.Size = New System.Drawing.Size(237, 20)
        Me.txtTelefoneResidencial.TabIndex = 13
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(348, 147)
        Me.txtCidade.MaxLength = 20
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(285, 20)
        Me.txtCidade.TabIndex = 9
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(22, 147)
        Me.txtBairro.MaxLength = 20
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(320, 20)
        Me.txtBairro.TabIndex = 8
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(253, 186)
        Me.txtCelular.MaxLength = 14
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(237, 20)
        Me.txtCelular.TabIndex = 12
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(453, 108)
        Me.txtNumero.MaxLength = 8
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(86, 20)
        Me.txtNumero.TabIndex = 6
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(21, 186)
        Me.txtCEP.MaxLength = 9
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(226, 20)
        Me.txtCEP.TabIndex = 11
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(639, 69)
        Me.txtSexo.MaxLength = 1
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(94, 20)
        Me.txtSexo.TabIndex = 4
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(21, 108)
        Me.txtLogradouro.MaxLength = 150
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(426, 20)
        Me.txtLogradouro.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNome.Location = New System.Drawing.Point(21, 29)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(712, 20)
        Me.txtNome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(545, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Complemento"
        '
        'lbNAscimento
        '
        Me.lbNAscimento.AutoSize = True
        Me.lbNAscimento.Location = New System.Drawing.Point(19, 53)
        Me.lbNAscimento.Name = "lbNAscimento"
        Me.lbNAscimento.Size = New System.Drawing.Size(104, 13)
        Me.lbNAscimento.TabIndex = 28
        Me.lbNAscimento.Text = "Data de Nascimento"
        '
        'lbRg
        '
        Me.lbRg.AutoSize = True
        Me.lbRg.Location = New System.Drawing.Point(415, 53)
        Me.lbRg.Name = "lbRg"
        Me.lbRg.Size = New System.Drawing.Size(23, 13)
        Me.lbRg.TabIndex = 26
        Me.lbRg.Text = "RG"
        '
        'lbCpf
        '
        Me.lbCpf.AutoSize = True
        Me.lbCpf.Location = New System.Drawing.Point(188, 52)
        Me.lbCpf.Name = "lbCpf"
        Me.lbCpf.Size = New System.Drawing.Size(27, 13)
        Me.lbCpf.TabIndex = 25
        Me.lbCpf.Text = "CPF"
        '
        'lbCelular
        '
        Me.lbCelular.AutoSize = True
        Me.lbCelular.Location = New System.Drawing.Point(253, 170)
        Me.lbCelular.Name = "lbCelular"
        Me.lbCelular.Size = New System.Drawing.Size(39, 13)
        Me.lbCelular.TabIndex = 22
        Me.lbCelular.Text = "Celular"
        '
        'btnCadClienteCancelar
        '
        Me.btnCadClienteCancelar.Location = New System.Drawing.Point(577, 428)
        Me.btnCadClienteCancelar.Name = "btnCadClienteCancelar"
        Me.btnCadClienteCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCadClienteCancelar.TabIndex = 15
        Me.btnCadClienteCancelar.Text = "Cancelar"
        Me.btnCadClienteCancelar.UseVisualStyleBackColor = True
        '
        'btnCadClienteSalvar
        '
        Me.btnCadClienteSalvar.Location = New System.Drawing.Point(658, 408)
        Me.btnCadClienteSalvar.Name = "btnCadClienteSalvar"
        Me.btnCadClienteSalvar.Size = New System.Drawing.Size(75, 59)
        Me.btnCadClienteSalvar.TabIndex = 17
        Me.btnCadClienteSalvar.Text = "Salvar"
        Me.btnCadClienteSalvar.UseVisualStyleBackColor = True
        '
        'lbUf
        '
        Me.lbUf.AutoSize = True
        Me.lbUf.Location = New System.Drawing.Point(636, 131)
        Me.lbUf.Name = "lbUf"
        Me.lbUf.Size = New System.Drawing.Size(18, 13)
        Me.lbUf.TabIndex = 18
        Me.lbUf.Text = "Uf"
        '
        'lbCidade
        '
        Me.lbCidade.AutoSize = True
        Me.lbCidade.Location = New System.Drawing.Point(345, 131)
        Me.lbCidade.Name = "lbCidade"
        Me.lbCidade.Size = New System.Drawing.Size(40, 13)
        Me.lbCidade.TabIndex = 16
        Me.lbCidade.Text = "Cidade"
        '
        'lbBairro
        '
        Me.lbBairro.AutoSize = True
        Me.lbBairro.Location = New System.Drawing.Point(19, 131)
        Me.lbBairro.Name = "lbBairro"
        Me.lbBairro.Size = New System.Drawing.Size(34, 13)
        Me.lbBairro.TabIndex = 14
        Me.lbBairro.Text = "Bairro"
        '
        'lbTelResidencial
        '
        Me.lbTelResidencial.AutoSize = True
        Me.lbTelResidencial.Location = New System.Drawing.Point(493, 170)
        Me.lbTelResidencial.Name = "lbTelResidencial"
        Me.lbTelResidencial.Size = New System.Drawing.Size(107, 13)
        Me.lbTelResidencial.TabIndex = 12
        Me.lbTelResidencial.Text = "Telefone Residencial"
        '
        'lbCep
        '
        Me.lbCep.AutoSize = True
        Me.lbCep.Location = New System.Drawing.Point(19, 170)
        Me.lbCep.Name = "lbCep"
        Me.lbCep.Size = New System.Drawing.Size(26, 13)
        Me.lbCep.TabIndex = 11
        Me.lbCep.Text = "Cep"
        '
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.Location = New System.Drawing.Point(459, 92)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(44, 13)
        Me.lbNumero.TabIndex = 8
        Me.lbNumero.Text = "Número"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = True
        Me.lbSexo.Location = New System.Drawing.Point(636, 52)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(60, 13)
        Me.lbSexo.TabIndex = 7
        Me.lbSexo.Text = "Sexo (M/F)"
        '
        'tbLogradouro
        '
        Me.tbLogradouro.AutoSize = True
        Me.tbLogradouro.Location = New System.Drawing.Point(19, 92)
        Me.tbLogradouro.Name = "tbLogradouro"
        Me.tbLogradouro.Size = New System.Drawing.Size(61, 13)
        Me.tbLogradouro.TabIndex = 5
        Me.tbLogradouro.Text = "Logradouro"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Location = New System.Drawing.Point(18, 13)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 1
        Me.lbNome.Text = "Nome"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSaldo)
        Me.GroupBox2.Controls.Add(Me.lbSaldoInicial)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(733, 257)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(15, 222)
        Me.txtSaldo.MaxLength = 4
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(102, 20)
        Me.txtSaldo.TabIndex = 13
        '
        'lbSaldoInicial
        '
        Me.lbSaldoInicial.AutoSize = True
        Me.lbSaldoInicial.Location = New System.Drawing.Point(12, 206)
        Me.lbSaldoInicial.Name = "lbSaldoInicial"
        Me.lbSaldoInicial.Size = New System.Drawing.Size(34, 13)
        Me.lbSaldoInicial.TabIndex = 33
        Me.lbSaldoInicial.Text = "Saldo"
        '
        'tbpClientes
        '
        Me.tbpClientes.Controls.Add(Me.tbpPesquisaCliente)
        Me.tbpClientes.Controls.Add(Me.tbpCadastroCliente)
        Me.tbpClientes.Location = New System.Drawing.Point(12, 12)
        Me.tbpClientes.Name = "tbpClientes"
        Me.tbpClientes.SelectedIndex = 0
        Me.tbpClientes.Size = New System.Drawing.Size(752, 499)
        Me.tbpClientes.TabIndex = 0
        '
        'FrmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 523)
        Me.Controls.Add(Me.tbpClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmCadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.tbpPesquisaCliente.ResumeLayout(False)
        Me.tbpPesquisaCliente.PerformLayout()
        CType(Me.grdPesquisarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpCadastroCliente.ResumeLayout(False)
        Me.tbpCadastroCliente.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tbpClientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbpPesquisaCliente As TabPage
	Friend WithEvents btnLimparPesquisa As Button
	Friend WithEvents lbCpfPesquisa As Label
	Friend WithEvents btnPesquisarCliente As Button
	Friend WithEvents grdPesquisarCliente As DataGridView
	Friend WithEvents txtCpfPesquisa As TextBox
	Friend WithEvents tbpCadastroCliente As TabPage
	Friend WithEvents txtComplemento As TextBox
	Friend WithEvents txtDataNascimento As TextBox
	Friend WithEvents txtRg As TextBox
	Friend WithEvents txtCadastroCpf As TextBox
	Friend WithEvents txtTelefoneResidencial As TextBox
	Friend WithEvents txtCidade As TextBox
	Friend WithEvents txtBairro As TextBox
	Friend WithEvents txtCelular As TextBox
	Friend WithEvents txtNumero As TextBox
	Friend WithEvents txtCEP As TextBox
	Friend WithEvents txtSexo As TextBox
	Friend WithEvents txtLogradouro As TextBox
	Friend WithEvents txtNome As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lbNAscimento As Label
	Friend WithEvents lbRg As Label
	Friend WithEvents lbCpf As Label
	Friend WithEvents lbCelular As Label
	Friend WithEvents btnCadClienteCancelar As Button
	Friend WithEvents btnCadClienteSalvar As Button
	Friend WithEvents lbUf As Label
	Friend WithEvents lbCidade As Label
	Friend WithEvents lbBairro As Label
	Friend WithEvents lbTelResidencial As Label
	Friend WithEvents lbCep As Label
	Friend WithEvents lbNumero As Label
	Friend WithEvents lbSexo As Label
	Friend WithEvents tbLogradouro As Label
	Friend WithEvents lbNome As Label
	Friend WithEvents tbpClientes As TabControl
	Friend WithEvents txtComboUf As ComboBox
	Friend WithEvents btnExcluirCadastro As Button
	Friend WithEvents btnLimparCadastro As Button
	Friend WithEvents lbCodPesquisa As Label
	Friend WithEvents txtCodClientePesquisa As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents txtSaldo As TextBox
	Friend WithEvents lbSaldoInicial As Label
End Class
