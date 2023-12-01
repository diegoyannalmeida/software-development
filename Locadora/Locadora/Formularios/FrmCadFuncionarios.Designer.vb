<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFuncionarios
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tblCadastro = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbAdmSim = New System.Windows.Forms.RadioButton()
        Me.rbAdmNao = New System.Windows.Forms.RadioButton()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSenhaCad = New System.Windows.Forms.TextBox()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.txtUsuarioCad = New System.Windows.Forms.TextBox()
        Me.lbCpf = New System.Windows.Forms.Label()
        Me.txtCadastroCpf = New System.Windows.Forms.TextBox()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.txtNomeCad = New System.Windows.Forms.TextBox()
        Me.tbpExcluir = New System.Windows.Forms.TabPage()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btCancelarExcluir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuarioExcluir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExcluirCpf = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout
        Me.tblCadastro.SuspendLayout
        Me.tbpExcluir.SuspendLayout
        Me.SuspendLayout
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tblCadastro)
        Me.TabControl1.Controls.Add(Me.tbpExcluir)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(471, 208)
        Me.TabControl1.TabIndex = 0
        '
        'tblCadastro
        '
        Me.tblCadastro.Controls.Add(Me.Label3)
        Me.tblCadastro.Controls.Add(Me.rbAdmSim)
        Me.tblCadastro.Controls.Add(Me.rbAdmNao)
        Me.tblCadastro.Controls.Add(Me.btSalvar)
        Me.tblCadastro.Controls.Add(Me.btCancelar)
        Me.tblCadastro.Controls.Add(Me.Label4)
        Me.tblCadastro.Controls.Add(Me.txtSenhaCad)
        Me.tblCadastro.Controls.Add(Me.lbUsuario)
        Me.tblCadastro.Controls.Add(Me.txtUsuarioCad)
        Me.tblCadastro.Controls.Add(Me.lbCpf)
        Me.tblCadastro.Controls.Add(Me.txtCadastroCpf)
        Me.tblCadastro.Controls.Add(Me.lbNome)
        Me.tblCadastro.Controls.Add(Me.txtNomeCad)
        Me.tblCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tblCadastro.Name = "tblCadastro"
        Me.tblCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tblCadastro.Size = New System.Drawing.Size(463, 182)
        Me.tblCadastro.TabIndex = 0
        Me.tblCadastro.Text = "Cadastrar"
        Me.tblCadastro.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(338, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Administrador"
        '
        'rbAdmSim
        '
        Me.rbAdmSim.AutoSize = true
        Me.rbAdmSim.Location = New System.Drawing.Point(341, 79)
        Me.rbAdmSim.Name = "rbAdmSim"
        Me.rbAdmSim.Size = New System.Drawing.Size(42, 17)
        Me.rbAdmSim.TabIndex = 20
        Me.rbAdmSim.TabStop = true
        Me.rbAdmSim.Text = "Sim"
        Me.rbAdmSim.UseVisualStyleBackColor = true
        '
        'rbAdmNao
        '
        Me.rbAdmNao.AutoSize = true
        Me.rbAdmNao.Location = New System.Drawing.Point(389, 79)
        Me.rbAdmNao.Name = "rbAdmNao"
        Me.rbAdmNao.Size = New System.Drawing.Size(45, 17)
        Me.rbAdmNao.TabIndex = 19
        Me.rbAdmNao.TabStop = true
        Me.rbAdmNao.Text = "Não"
        Me.rbAdmNao.UseVisualStyleBackColor = true
        '
        'btSalvar
        '
        Me.btSalvar.Location = New System.Drawing.Point(382, 149)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btSalvar.TabIndex = 6
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.UseVisualStyleBackColor = true
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(9, 149)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 5
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(169, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Senha"
        '
        'txtSenhaCad
        '
        Me.txtSenhaCad.Location = New System.Drawing.Point(169, 78)
        Me.txtSenhaCad.MaxLength = 100
        Me.txtSenhaCad.Name = "txtSenhaCad"
        Me.txtSenhaCad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaCad.Size = New System.Drawing.Size(154, 20)
        Me.txtSenhaCad.TabIndex = 4
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = true
        Me.lbUsuario.Location = New System.Drawing.Point(9, 59)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lbUsuario.TabIndex = 15
        Me.lbUsuario.Text = "Usuário"
        '
        'txtUsuarioCad
        '
        Me.txtUsuarioCad.Location = New System.Drawing.Point(9, 78)
        Me.txtUsuarioCad.MaxLength = 50
        Me.txtUsuarioCad.Name = "txtUsuarioCad"
        Me.txtUsuarioCad.Size = New System.Drawing.Size(154, 20)
        Me.txtUsuarioCad.TabIndex = 3
        '
        'lbCpf
        '
        Me.lbCpf.AutoSize = true
        Me.lbCpf.Location = New System.Drawing.Point(280, 11)
        Me.lbCpf.Name = "lbCpf"
        Me.lbCpf.Size = New System.Drawing.Size(27, 13)
        Me.lbCpf.TabIndex = 13
        Me.lbCpf.Text = "CPF"
        '
        'txtCadastroCpf
        '
        Me.txtCadastroCpf.Location = New System.Drawing.Point(280, 30)
        Me.txtCadastroCpf.MaxLength = 14
        Me.txtCadastroCpf.Name = "txtCadastroCpf"
        Me.txtCadastroCpf.Size = New System.Drawing.Size(154, 20)
        Me.txtCadastroCpf.TabIndex = 2
        '
        'lbNome
        '
        Me.lbNome.AutoSize = true
        Me.lbNome.Location = New System.Drawing.Point(6, 11)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(35, 13)
        Me.lbNome.TabIndex = 11
        Me.lbNome.Text = "Nome"
        '
        'txtNomeCad
        '
        Me.txtNomeCad.Location = New System.Drawing.Point(6, 30)
        Me.txtNomeCad.MaxLength = 200
        Me.txtNomeCad.Name = "txtNomeCad"
        Me.txtNomeCad.Size = New System.Drawing.Size(268, 20)
        Me.txtNomeCad.TabIndex = 1
        '
        'tbpExcluir
        '
        Me.tbpExcluir.Controls.Add(Me.btExcluir)
        Me.tbpExcluir.Controls.Add(Me.btCancelarExcluir)
        Me.tbpExcluir.Controls.Add(Me.Label1)
        Me.tbpExcluir.Controls.Add(Me.txtUsuarioExcluir)
        Me.tbpExcluir.Controls.Add(Me.Label2)
        Me.tbpExcluir.Controls.Add(Me.txtExcluirCpf)
        Me.tbpExcluir.Location = New System.Drawing.Point(4, 22)
        Me.tbpExcluir.Name = "tbpExcluir"
        Me.tbpExcluir.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpExcluir.Size = New System.Drawing.Size(463, 182)
        Me.tbpExcluir.TabIndex = 1
        Me.tbpExcluir.Text = "Excluir"
        Me.tbpExcluir.UseVisualStyleBackColor = true
        '
        'btExcluir
        '
        Me.btExcluir.Location = New System.Drawing.Point(379, 153)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btExcluir.TabIndex = 21
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.UseVisualStyleBackColor = true
        '
        'btCancelarExcluir
        '
        Me.btCancelarExcluir.Location = New System.Drawing.Point(6, 153)
        Me.btCancelarExcluir.Name = "btCancelarExcluir"
        Me.btCancelarExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btCancelarExcluir.TabIndex = 20
        Me.btCancelarExcluir.Text = "Cancelar"
        Me.btCancelarExcluir.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Usuário"
        '
        'txtUsuarioExcluir
        '
        Me.txtUsuarioExcluir.Location = New System.Drawing.Point(6, 29)
        Me.txtUsuarioExcluir.Name = "txtUsuarioExcluir"
        Me.txtUsuarioExcluir.Size = New System.Drawing.Size(154, 20)
        Me.txtUsuarioExcluir.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(166, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "CPF"
        '
        'txtExcluirCpf
        '
        Me.txtExcluirCpf.Location = New System.Drawing.Point(166, 29)
        Me.txtExcluirCpf.MaxLength = 11
        Me.txtExcluirCpf.Name = "txtExcluirCpf"
        Me.txtExcluirCpf.Size = New System.Drawing.Size(154, 20)
        Me.txtExcluirCpf.TabIndex = 16
        '
        'FrmCadFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 223)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmCadFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadFuncionarios"
        Me.TabControl1.ResumeLayout(false)
        Me.tblCadastro.ResumeLayout(false)
        Me.tblCadastro.PerformLayout
        Me.tbpExcluir.ResumeLayout(false)
        Me.tbpExcluir.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tblCadastro As TabPage
    Friend WithEvents tbpExcluir As TabPage
    Friend WithEvents btSalvar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSenhaCad As TextBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents txtUsuarioCad As TextBox
    Friend WithEvents lbCpf As Label
    Friend WithEvents txtCadastroCpf As TextBox
    Friend WithEvents lbNome As Label
    Friend WithEvents txtNomeCad As TextBox
    Friend WithEvents btExcluir As Button
    Friend WithEvents btCancelarExcluir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuarioExcluir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtExcluirCpf As TextBox
    Friend WithEvents rbAdmNao As RadioButton
    Friend WithEvents rbAdmSim As RadioButton
    Friend WithEvents Label3 As Label
End Class
