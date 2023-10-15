<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadLocacoes
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
        Me.tbpDevolucao = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chbUsarSaldo = New System.Windows.Forms.CheckBox()
        Me.lbSaldoCliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaldoAtualCliente = New System.Windows.Forms.TextBox()
        Me.txtCodClienteDevolucao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCpfClienteDevolucao = New System.Windows.Forms.TextBox()
        Me.txtNomeClienteDevolucao = New System.Windows.Forms.TextBox()
        Me.btnBuscarClienteLocacao = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataEntregaDevolucao = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.grdListaDevolucao = New System.Windows.Forms.DataGridView()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lbSaldoDevedor = New System.Windows.Forms.Label()
        Me.txtValorSaldoFinalDevolucao = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtValorPagoDevolucao = New System.Windows.Forms.TextBox()
        Me.lbValorPagar = New System.Windows.Forms.Label()
        Me.txtValorTotalPagarDevolucao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValorTotalDevolucao = New System.Windows.Forms.TextBox()
        Me.txtJurosDevolucao = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancelarDevolucao = New System.Windows.Forms.Button()
        Me.btnDevolver = New System.Windows.Forms.Button()
        Me.tbpAluguel = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelarAluguel = New System.Windows.Forms.Button()
        Me.btnLimparAluguel = New System.Windows.Forms.Button()
        Me.btnSalvarAluguel = New System.Windows.Forms.Button()
        Me.grdListaAlugueis = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbCodCliente = New System.Windows.Forms.Label()
        Me.txtCodClienteLocacao = New System.Windows.Forms.TextBox()
        Me.lbCpfCliente = New System.Windows.Forms.Label()
        Me.lbNomeCliente = New System.Windows.Forms.Label()
        Me.txtCpfClienteLocacao = New System.Windows.Forms.TextBox()
        Me.txtNomeClienteLocacao = New System.Windows.Forms.TextBox()
        Me.btnBuscarFilmesLocação = New System.Windows.Forms.Button()
        Me.btnBuscarClientesLocacao = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbDiasLocados = New System.Windows.Forms.Label()
        Me.cmbQtdeDias = New System.Windows.Forms.ComboBox()
        Me.lbDataDaRetiradaLocacao = New System.Windows.Forms.Label()
        Me.txtDataDaRetiradaLocacao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDataDeEntregaLocacao = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtValorTotalLocacao = New System.Windows.Forms.TextBox()
        Me.tbpPesquisa = New System.Windows.Forms.TabPage()
        Me.grdPesquisarLocacoes = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnListarFilmesPesquisa = New System.Windows.Forms.Button()
        Me.btnLimparPesquisa = New System.Windows.Forms.Button()
        Me.tbpLocacoes = New System.Windows.Forms.TabControl()
        Me.tbpDevolucao.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.grdListaDevolucao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.tbpAluguel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdListaAlugueis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tbpPesquisa.SuspendLayout()
        CType(Me.grdPesquisarLocacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.tbpLocacoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpDevolucao
        '
        Me.tbpDevolucao.Controls.Add(Me.GroupBox7)
        Me.tbpDevolucao.Controls.Add(Me.GroupBox8)
        Me.tbpDevolucao.Controls.Add(Me.GroupBox10)
        Me.tbpDevolucao.Location = New System.Drawing.Point(4, 22)
        Me.tbpDevolucao.Name = "tbpDevolucao"
        Me.tbpDevolucao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDevolucao.Size = New System.Drawing.Size(752, 477)
        Me.tbpDevolucao.TabIndex = 2
        Me.tbpDevolucao.Text = "Devolução"
        Me.tbpDevolucao.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chbUsarSaldo)
        Me.GroupBox7.Controls.Add(Me.lbSaldoCliente)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.txtSaldoAtualCliente)
        Me.GroupBox7.Controls.Add(Me.txtCodClienteDevolucao)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.txtCpfClienteDevolucao)
        Me.GroupBox7.Controls.Add(Me.txtNomeClienteDevolucao)
        Me.GroupBox7.Controls.Add(Me.btnBuscarClienteLocacao)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(741, 83)
        Me.GroupBox7.TabIndex = 40
        Me.GroupBox7.TabStop = False
        '
        'chbUsarSaldo
        '
        Me.chbUsarSaldo.AutoSize = True
        Me.chbUsarSaldo.Location = New System.Drawing.Point(628, 50)
        Me.chbUsarSaldo.Name = "chbUsarSaldo"
        Me.chbUsarSaldo.Size = New System.Drawing.Size(84, 17)
        Me.chbUsarSaldo.TabIndex = 42
        Me.chbUsarSaldo.Text = "Usar Saldo?"
        Me.chbUsarSaldo.UseVisualStyleBackColor = True
        '
        'lbSaldoCliente
        '
        Me.lbSaldoCliente.AutoSize = True
        Me.lbSaldoCliente.Location = New System.Drawing.Point(624, 11)
        Me.lbSaldoCliente.Name = "lbSaldoCliente"
        Me.lbSaldoCliente.Size = New System.Drawing.Size(61, 13)
        Me.lbSaldoCliente.TabIndex = 41
        Me.lbSaldoCliente.Text = "Saldo Atual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(528, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Cód. Cliente"
        '
        'txtSaldoAtualCliente
        '
        Me.txtSaldoAtualCliente.Location = New System.Drawing.Point(627, 27)
        Me.txtSaldoAtualCliente.Name = "txtSaldoAtualCliente"
        Me.txtSaldoAtualCliente.ReadOnly = True
        Me.txtSaldoAtualCliente.Size = New System.Drawing.Size(91, 20)
        Me.txtSaldoAtualCliente.TabIndex = 40
        '
        'txtCodClienteDevolucao
        '
        Me.txtCodClienteDevolucao.Location = New System.Drawing.Point(531, 27)
        Me.txtCodClienteDevolucao.Name = "txtCodClienteDevolucao"
        Me.txtCodClienteDevolucao.ReadOnly = True
        Me.txtCodClienteDevolucao.Size = New System.Drawing.Size(90, 20)
        Me.txtCodClienteDevolucao.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "CPF"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Nome Do Cliente"
        '
        'txtCpfClienteDevolucao
        '
        Me.txtCpfClienteDevolucao.Location = New System.Drawing.Point(353, 27)
        Me.txtCpfClienteDevolucao.Name = "txtCpfClienteDevolucao"
        Me.txtCpfClienteDevolucao.ReadOnly = True
        Me.txtCpfClienteDevolucao.Size = New System.Drawing.Size(172, 20)
        Me.txtCpfClienteDevolucao.TabIndex = 28
        '
        'txtNomeClienteDevolucao
        '
        Me.txtNomeClienteDevolucao.Location = New System.Drawing.Point(9, 27)
        Me.txtNomeClienteDevolucao.Name = "txtNomeClienteDevolucao"
        Me.txtNomeClienteDevolucao.ReadOnly = True
        Me.txtNomeClienteDevolucao.Size = New System.Drawing.Size(338, 20)
        Me.txtNomeClienteDevolucao.TabIndex = 27
        '
        'btnBuscarClienteLocacao
        '
        Me.btnBuscarClienteLocacao.Location = New System.Drawing.Point(9, 53)
        Me.btnBuscarClienteLocacao.Name = "btnBuscarClienteLocacao"
        Me.btnBuscarClienteLocacao.Size = New System.Drawing.Size(102, 23)
        Me.btnBuscarClienteLocacao.TabIndex = 26
        Me.btnBuscarClienteLocacao.Text = "Buscar Cliente"
        Me.btnBuscarClienteLocacao.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.txtDataEntregaDevolucao)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 81)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(741, 68)
        Me.GroupBox8.TabIndex = 38
        Me.GroupBox8.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Data da entrega"
        '
        'txtDataEntregaDevolucao
        '
        Me.txtDataEntregaDevolucao.Location = New System.Drawing.Point(9, 32)
        Me.txtDataEntregaDevolucao.MaxLength = 8
        Me.txtDataEntregaDevolucao.Name = "txtDataEntregaDevolucao"
        Me.txtDataEntregaDevolucao.Size = New System.Drawing.Size(130, 20)
        Me.txtDataEntregaDevolucao.TabIndex = 38
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.grdListaDevolucao)
        Me.GroupBox10.Controls.Add(Me.GroupBox9)
        Me.GroupBox10.Controls.Add(Me.Button1)
        Me.GroupBox10.Controls.Add(Me.btnCancelarDevolucao)
        Me.GroupBox10.Controls.Add(Me.btnDevolver)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(740, 465)
        Me.GroupBox10.TabIndex = 33
        Me.GroupBox10.TabStop = False
        '
        'grdListaDevolucao
        '
        Me.grdListaDevolucao.AllowUserToAddRows = False
        Me.grdListaDevolucao.AllowUserToDeleteRows = False
        Me.grdListaDevolucao.AllowUserToResizeColumns = False
        Me.grdListaDevolucao.AllowUserToResizeRows = False
        Me.grdListaDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdListaDevolucao.Location = New System.Drawing.Point(6, 149)
        Me.grdListaDevolucao.Name = "grdListaDevolucao"
        Me.grdListaDevolucao.RowHeadersVisible = False
        Me.grdListaDevolucao.Size = New System.Drawing.Size(728, 246)
        Me.grdListaDevolucao.TabIndex = 42
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lbSaldoDevedor)
        Me.GroupBox9.Controls.Add(Me.txtValorSaldoFinalDevolucao)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.txtValorPagoDevolucao)
        Me.GroupBox9.Controls.Add(Me.lbValorPagar)
        Me.GroupBox9.Controls.Add(Me.txtValorTotalPagarDevolucao)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.txtValorTotalDevolucao)
        Me.GroupBox9.Controls.Add(Me.txtJurosDevolucao)
        Me.GroupBox9.Location = New System.Drawing.Point(-3, 408)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(507, 44)
        Me.GroupBox9.TabIndex = 41
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Valor Total"
        '
        'lbSaldoDevedor
        '
        Me.lbSaldoDevedor.AutoSize = True
        Me.lbSaldoDevedor.Location = New System.Drawing.Point(366, -2)
        Me.lbSaldoDevedor.Name = "lbSaldoDevedor"
        Me.lbSaldoDevedor.Size = New System.Drawing.Size(59, 13)
        Me.lbSaldoDevedor.TabIndex = 48
        Me.lbSaldoDevedor.Text = "Saldo Final"
        '
        'txtValorSaldoFinalDevolucao
        '
        Me.txtValorSaldoFinalDevolucao.Location = New System.Drawing.Point(369, 14)
        Me.txtValorSaldoFinalDevolucao.MaxLength = 5
        Me.txtValorSaldoFinalDevolucao.Name = "txtValorSaldoFinalDevolucao"
        Me.txtValorSaldoFinalDevolucao.ReadOnly = True
        Me.txtValorSaldoFinalDevolucao.Size = New System.Drawing.Size(84, 20)
        Me.txtValorSaldoFinalDevolucao.TabIndex = 47
        Me.txtValorSaldoFinalDevolucao.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(276, -2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Valor Pago"
        '
        'txtValorPagoDevolucao
        '
        Me.txtValorPagoDevolucao.Location = New System.Drawing.Point(279, 14)
        Me.txtValorPagoDevolucao.MaxLength = 5
        Me.txtValorPagoDevolucao.Name = "txtValorPagoDevolucao"
        Me.txtValorPagoDevolucao.Size = New System.Drawing.Size(84, 20)
        Me.txtValorPagoDevolucao.TabIndex = 45
        Me.txtValorPagoDevolucao.Text = "0"
        '
        'lbValorPagar
        '
        Me.lbValorPagar.AutoSize = True
        Me.lbValorPagar.Location = New System.Drawing.Point(186, -2)
        Me.lbValorPagar.Name = "lbValorPagar"
        Me.lbValorPagar.Size = New System.Drawing.Size(70, 13)
        Me.lbValorPagar.TabIndex = 44
        Me.lbValorPagar.Text = "Total a pagar"
        '
        'txtValorTotalPagarDevolucao
        '
        Me.txtValorTotalPagarDevolucao.Location = New System.Drawing.Point(189, 14)
        Me.txtValorTotalPagarDevolucao.MaxLength = 6
        Me.txtValorTotalPagarDevolucao.Name = "txtValorTotalPagarDevolucao"
        Me.txtValorTotalPagarDevolucao.ReadOnly = True
        Me.txtValorTotalPagarDevolucao.Size = New System.Drawing.Size(84, 20)
        Me.txtValorTotalPagarDevolucao.TabIndex = 43
        Me.txtValorTotalPagarDevolucao.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Juros"
        '
        'txtValorTotalDevolucao
        '
        Me.txtValorTotalDevolucao.Location = New System.Drawing.Point(9, 14)
        Me.txtValorTotalDevolucao.MaxLength = 5
        Me.txtValorTotalDevolucao.Name = "txtValorTotalDevolucao"
        Me.txtValorTotalDevolucao.ReadOnly = True
        Me.txtValorTotalDevolucao.Size = New System.Drawing.Size(84, 20)
        Me.txtValorTotalDevolucao.TabIndex = 42
        Me.txtValorTotalDevolucao.Text = "0"
        '
        'txtJurosDevolucao
        '
        Me.txtJurosDevolucao.Location = New System.Drawing.Point(99, 14)
        Me.txtJurosDevolucao.MaxLength = 5
        Me.txtJurosDevolucao.Name = "txtJurosDevolucao"
        Me.txtJurosDevolucao.ReadOnly = True
        Me.txtJurosDevolucao.Size = New System.Drawing.Size(84, 20)
        Me.txtJurosDevolucao.TabIndex = 40
        Me.txtJurosDevolucao.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Buscar Filme"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancelarDevolucao
        '
        Me.btnCancelarDevolucao.Location = New System.Drawing.Point(578, 422)
        Me.btnCancelarDevolucao.Name = "btnCancelarDevolucao"
        Me.btnCancelarDevolucao.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarDevolucao.TabIndex = 39
        Me.btnCancelarDevolucao.Text = "Cancelar"
        Me.btnCancelarDevolucao.UseVisualStyleBackColor = True
        '
        'btnDevolver
        '
        Me.btnDevolver.Location = New System.Drawing.Point(659, 401)
        Me.btnDevolver.Name = "btnDevolver"
        Me.btnDevolver.Size = New System.Drawing.Size(75, 58)
        Me.btnDevolver.TabIndex = 27
        Me.btnDevolver.Text = "Devolver"
        Me.btnDevolver.UseVisualStyleBackColor = True
        '
        'tbpAluguel
        '
        Me.tbpAluguel.Controls.Add(Me.GroupBox1)
        Me.tbpAluguel.Location = New System.Drawing.Point(4, 22)
        Me.tbpAluguel.Name = "tbpAluguel"
        Me.tbpAluguel.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAluguel.Size = New System.Drawing.Size(752, 477)
        Me.tbpAluguel.TabIndex = 0
        Me.tbpAluguel.Text = "Aluguel"
        Me.tbpAluguel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelarAluguel)
        Me.GroupBox1.Controls.Add(Me.btnLimparAluguel)
        Me.GroupBox1.Controls.Add(Me.btnSalvarAluguel)
        Me.GroupBox1.Controls.Add(Me.grdListaAlugueis)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 465)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnCancelarAluguel
        '
        Me.btnCancelarAluguel.Location = New System.Drawing.Point(497, 419)
        Me.btnCancelarAluguel.Name = "btnCancelarAluguel"
        Me.btnCancelarAluguel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarAluguel.TabIndex = 24
        Me.btnCancelarAluguel.Text = "Cancelar"
        Me.btnCancelarAluguel.UseVisualStyleBackColor = True
        '
        'btnLimparAluguel
        '
        Me.btnLimparAluguel.Location = New System.Drawing.Point(578, 419)
        Me.btnLimparAluguel.Name = "btnLimparAluguel"
        Me.btnLimparAluguel.Size = New System.Drawing.Size(75, 23)
        Me.btnLimparAluguel.TabIndex = 23
        Me.btnLimparAluguel.Text = "Limpar"
        Me.btnLimparAluguel.UseVisualStyleBackColor = True
        '
        'btnSalvarAluguel
        '
        Me.btnSalvarAluguel.Location = New System.Drawing.Point(659, 401)
        Me.btnSalvarAluguel.Name = "btnSalvarAluguel"
        Me.btnSalvarAluguel.Size = New System.Drawing.Size(75, 58)
        Me.btnSalvarAluguel.TabIndex = 21
        Me.btnSalvarAluguel.Text = "Salvar"
        Me.btnSalvarAluguel.UseVisualStyleBackColor = True
        '
        'grdListaAlugueis
        '
        Me.grdListaAlugueis.AllowUserToAddRows = False
        Me.grdListaAlugueis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdListaAlugueis.Location = New System.Drawing.Point(6, 149)
        Me.grdListaAlugueis.Name = "grdListaAlugueis"
        Me.grdListaAlugueis.RowHeadersVisible = False
        Me.grdListaAlugueis.Size = New System.Drawing.Size(728, 242)
        Me.grdListaAlugueis.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbCodCliente)
        Me.GroupBox2.Controls.Add(Me.txtCodClienteLocacao)
        Me.GroupBox2.Controls.Add(Me.lbCpfCliente)
        Me.GroupBox2.Controls.Add(Me.lbNomeCliente)
        Me.GroupBox2.Controls.Add(Me.txtCpfClienteLocacao)
        Me.GroupBox2.Controls.Add(Me.txtNomeClienteLocacao)
        Me.GroupBox2.Controls.Add(Me.btnBuscarFilmesLocação)
        Me.GroupBox2.Controls.Add(Me.btnBuscarClientesLocacao)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(741, 83)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'lbCodCliente
        '
        Me.lbCodCliente.AutoSize = True
        Me.lbCodCliente.Location = New System.Drawing.Point(551, 9)
        Me.lbCodCliente.Name = "lbCodCliente"
        Me.lbCodCliente.Size = New System.Drawing.Size(64, 13)
        Me.lbCodCliente.TabIndex = 32
        Me.lbCodCliente.Text = "Cód. Cliente"
        '
        'txtCodClienteLocacao
        '
        Me.txtCodClienteLocacao.Location = New System.Drawing.Point(554, 27)
        Me.txtCodClienteLocacao.Name = "txtCodClienteLocacao"
        Me.txtCodClienteLocacao.ReadOnly = True
        Me.txtCodClienteLocacao.Size = New System.Drawing.Size(90, 20)
        Me.txtCodClienteLocacao.TabIndex = 31
        '
        'lbCpfCliente
        '
        Me.lbCpfCliente.AutoSize = True
        Me.lbCpfCliente.Location = New System.Drawing.Point(373, 9)
        Me.lbCpfCliente.Name = "lbCpfCliente"
        Me.lbCpfCliente.Size = New System.Drawing.Size(27, 13)
        Me.lbCpfCliente.TabIndex = 30
        Me.lbCpfCliente.Text = "CPF"
        '
        'lbNomeCliente
        '
        Me.lbNomeCliente.AutoSize = True
        Me.lbNomeCliente.Location = New System.Drawing.Point(9, 9)
        Me.lbNomeCliente.Name = "lbNomeCliente"
        Me.lbNomeCliente.Size = New System.Drawing.Size(87, 13)
        Me.lbNomeCliente.TabIndex = 29
        Me.lbNomeCliente.Text = "Nome Do Cliente"
        '
        'txtCpfClienteLocacao
        '
        Me.txtCpfClienteLocacao.Location = New System.Drawing.Point(376, 27)
        Me.txtCpfClienteLocacao.Name = "txtCpfClienteLocacao"
        Me.txtCpfClienteLocacao.ReadOnly = True
        Me.txtCpfClienteLocacao.Size = New System.Drawing.Size(172, 20)
        Me.txtCpfClienteLocacao.TabIndex = 28
        '
        'txtNomeClienteLocacao
        '
        Me.txtNomeClienteLocacao.Location = New System.Drawing.Point(9, 27)
        Me.txtNomeClienteLocacao.Name = "txtNomeClienteLocacao"
        Me.txtNomeClienteLocacao.ReadOnly = True
        Me.txtNomeClienteLocacao.Size = New System.Drawing.Size(363, 20)
        Me.txtNomeClienteLocacao.TabIndex = 27
        '
        'btnBuscarFilmesLocação
        '
        Me.btnBuscarFilmesLocação.Location = New System.Drawing.Point(114, 54)
        Me.btnBuscarFilmesLocação.Name = "btnBuscarFilmesLocação"
        Me.btnBuscarFilmesLocação.Size = New System.Drawing.Size(101, 23)
        Me.btnBuscarFilmesLocação.TabIndex = 25
        Me.btnBuscarFilmesLocação.Text = "Buscar Filme"
        Me.btnBuscarFilmesLocação.UseVisualStyleBackColor = True
        '
        'btnBuscarClientesLocacao
        '
        Me.btnBuscarClientesLocacao.Location = New System.Drawing.Point(6, 54)
        Me.btnBuscarClientesLocacao.Name = "btnBuscarClientesLocacao"
        Me.btnBuscarClientesLocacao.Size = New System.Drawing.Size(102, 23)
        Me.btnBuscarClientesLocacao.TabIndex = 26
        Me.btnBuscarClientesLocacao.Text = "Buscar Cliente"
        Me.btnBuscarClientesLocacao.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbDiasLocados)
        Me.GroupBox3.Controls.Add(Me.cmbQtdeDias)
        Me.GroupBox3.Controls.Add(Me.lbDataDaRetiradaLocacao)
        Me.GroupBox3.Controls.Add(Me.txtDataDaRetiradaLocacao)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtDataDeEntregaLocacao)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(741, 68)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'lbDiasLocados
        '
        Me.lbDiasLocados.AutoSize = True
        Me.lbDiasLocados.Location = New System.Drawing.Point(154, 15)
        Me.lbDiasLocados.Name = "lbDiasLocados"
        Me.lbDiasLocados.Size = New System.Drawing.Size(101, 13)
        Me.lbDiasLocados.TabIndex = 12
        Me.lbDiasLocados.Text = "Quantidade de Dias"
        '
        'cmbQtdeDias
        '
        Me.cmbQtdeDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQtdeDias.FormattingEnabled = True
        Me.cmbQtdeDias.Location = New System.Drawing.Point(154, 31)
        Me.cmbQtdeDias.Name = "cmbQtdeDias"
        Me.cmbQtdeDias.Size = New System.Drawing.Size(121, 21)
        Me.cmbQtdeDias.TabIndex = 11
        '
        'lbDataDaRetiradaLocacao
        '
        Me.lbDataDaRetiradaLocacao.AutoSize = True
        Me.lbDataDaRetiradaLocacao.Location = New System.Drawing.Point(6, 16)
        Me.lbDataDaRetiradaLocacao.Name = "lbDataDaRetiradaLocacao"
        Me.lbDataDaRetiradaLocacao.Size = New System.Drawing.Size(83, 13)
        Me.lbDataDaRetiradaLocacao.TabIndex = 8
        Me.lbDataDaRetiradaLocacao.Text = "Data da retirada"
        '
        'txtDataDaRetiradaLocacao
        '
        Me.txtDataDaRetiradaLocacao.Location = New System.Drawing.Point(6, 32)
        Me.txtDataDaRetiradaLocacao.MaxLength = 8
        Me.txtDataDaRetiradaLocacao.Name = "txtDataDaRetiradaLocacao"
        Me.txtDataDaRetiradaLocacao.Size = New System.Drawing.Size(142, 20)
        Me.txtDataDaRetiradaLocacao.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(278, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Previsão de entrega"
        '
        'txtDataDeEntregaLocacao
        '
        Me.txtDataDeEntregaLocacao.Location = New System.Drawing.Point(281, 32)
        Me.txtDataDeEntregaLocacao.Name = "txtDataDeEntregaLocacao"
        Me.txtDataDeEntregaLocacao.ReadOnly = True
        Me.txtDataDeEntregaLocacao.Size = New System.Drawing.Size(142, 20)
        Me.txtDataDeEntregaLocacao.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtValorTotalLocacao)
        Me.GroupBox4.Location = New System.Drawing.Point(-3, 408)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 44)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valor Total"
        '
        'txtValorTotalLocacao
        '
        Me.txtValorTotalLocacao.Location = New System.Drawing.Point(9, 14)
        Me.txtValorTotalLocacao.Name = "txtValorTotalLocacao"
        Me.txtValorTotalLocacao.ReadOnly = True
        Me.txtValorTotalLocacao.Size = New System.Drawing.Size(142, 20)
        Me.txtValorTotalLocacao.TabIndex = 17
        '
        'tbpPesquisa
        '        
        Me.tbpPesquisa.Controls.Add(Me.grdPesquisarLocacoes)
        Me.tbpPesquisa.Controls.Add(Me.GroupBox5)
        Me.tbpPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.tbpPesquisa.Name = "tbpPesquisa"
        Me.tbpPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPesquisa.Size = New System.Drawing.Size(752, 477)
        Me.tbpPesquisa.TabIndex = 1
        Me.tbpPesquisa.Text = "Pesquisa"
        Me.tbpPesquisa.UseVisualStyleBackColor = True

        'grdPesquisarLocacoes
        '
        Me.grdPesquisarLocacoes.AllowUserToAddRows = False
        Me.grdPesquisarLocacoes.AllowUserToDeleteRows = False
        Me.grdPesquisarLocacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPesquisarLocacoes.Location = New System.Drawing.Point(7, 66)
        Me.grdPesquisarLocacoes.Name = "grdPesquisarLocacoes"
        Me.grdPesquisarLocacoes.ReadOnly = True
        Me.grdPesquisarLocacoes.RowHeadersVisible = False
        Me.grdPesquisarLocacoes.Size = New System.Drawing.Size(739, 405)
        Me.grdPesquisarLocacoes.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnListarFilmesPesquisa)
        Me.GroupBox5.Controls.Add(Me.btnLimparPesquisa)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(741, 54)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        '
        'btnListarFilmesPesquisa
        '
        Me.btnListarFilmesPesquisa.Location = New System.Drawing.Point(6, 19)
        Me.btnListarFilmesPesquisa.Name = "btnListarFilmesPesquisa"
        Me.btnListarFilmesPesquisa.Size = New System.Drawing.Size(130, 23)
        Me.btnListarFilmesPesquisa.TabIndex = 27
        Me.btnListarFilmesPesquisa.Text = "Listar Filmes Alugados"
        Me.btnListarFilmesPesquisa.UseVisualStyleBackColor = True
        '
        'btnLimparPesquisa
        '
        Me.btnLimparPesquisa.Location = New System.Drawing.Point(142, 19)
        Me.btnLimparPesquisa.Name = "btnLimparPesquisa"
        Me.btnLimparPesquisa.Size = New System.Drawing.Size(103, 23)
        Me.btnLimparPesquisa.TabIndex = 18
        Me.btnLimparPesquisa.Text = "Limpar Pesquisa"
        Me.btnLimparPesquisa.UseVisualStyleBackColor = True
        '
        'tbpLocacoes
        '
        Me.tbpLocacoes.Controls.Add(Me.tbpPesquisa)
        Me.tbpLocacoes.Controls.Add(Me.tbpAluguel)
        Me.tbpLocacoes.Controls.Add(Me.tbpDevolucao)
        Me.tbpLocacoes.Location = New System.Drawing.Point(0, 0)
        Me.tbpLocacoes.Name = "tbpLocacoes"
        Me.tbpLocacoes.SelectedIndex = 0
        Me.tbpLocacoes.Size = New System.Drawing.Size(760, 503)
        Me.tbpLocacoes.TabIndex = 0
        Me.tbpLocacoes.TabStop = False
        '
        'FrmCadLocacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 527)
        Me.Controls.Add(Me.tbpLocacoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmCadLocacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locações"
        Me.tbpDevolucao.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.grdListaDevolucao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.tbpAluguel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdListaAlugueis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tbpPesquisa.ResumeLayout(False)
        CType(Me.grdPesquisarLocacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.tbpLocacoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbpDevolucao As TabPage
    Friend WithEvents tbpAluguel As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelarAluguel As Button
    Friend WithEvents btnLimparAluguel As Button
    Friend WithEvents btnSalvarAluguel As Button
    Friend WithEvents txtValorTotalLocacao As TextBox
    Friend WithEvents grdListaAlugueis As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBuscarFilmesLocação As Button
    Friend WithEvents btnBuscarClientesLocacao As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbDataDaRetiradaLocacao As Label
    Friend WithEvents txtDataDaRetiradaLocacao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDataDeEntregaLocacao As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbpPesquisa As TabPage
    Friend WithEvents btnLimparPesquisa As Button
    Friend WithEvents grdPesquisarLocacoes As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnListarFilmesPesquisa As Button
    Friend WithEvents tbpLocacoes As TabControl
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lbNomeCliente As Label
    Friend WithEvents txtCpfClienteLocacao As TextBox
    Friend WithEvents txtNomeClienteLocacao As TextBox
    Friend WithEvents lbCpfCliente As Label
    Friend WithEvents lbCodCliente As Label
    Friend WithEvents txtCodClienteLocacao As TextBox
    Friend WithEvents btnCancelarDevolucao As Button
    Friend WithEvents btnDevolver As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtValorTotalDevolucao As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodClienteDevolucao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCpfClienteDevolucao As TextBox
    Friend WithEvents txtNomeClienteDevolucao As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBuscarClienteLocacao As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lbDiasLocados As Label
    Friend WithEvents cmbQtdeDias As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDataEntregaDevolucao As TextBox
    Friend WithEvents lbValorPagar As Label
    Friend WithEvents txtValorTotalPagarDevolucao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJurosDevolucao As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtValorPagoDevolucao As TextBox
    Friend WithEvents lbSaldoDevedor As Label
    Friend WithEvents txtValorSaldoFinalDevolucao As TextBox
    Friend WithEvents grdListaDevolucao As DataGridView
    Friend WithEvents lbSaldoCliente As Label
    Friend WithEvents txtSaldoAtualCliente As TextBox
    Friend WithEvents chbUsarSaldo As CheckBox
End Class
