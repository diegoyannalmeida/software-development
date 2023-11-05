<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btEntrar = New System.Windows.Forms.Button()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(50, 50)
        Me.txtUsuario.MaxLength = 50
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(211, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = true
        Me.lblUsuario.Location = New System.Drawing.Point(47, 34)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuário"
        '
        'btEntrar
        '
        Me.btEntrar.Location = New System.Drawing.Point(248, 148)
        Me.btEntrar.Name = "btEntrar"
        Me.btEntrar.Size = New System.Drawing.Size(69, 53)
        Me.btEntrar.TabIndex = 3
        Me.btEntrar.Text = "Entrar"
        Me.btEntrar.UseVisualStyleBackColor = true
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = true
        Me.lblSenha.Location = New System.Drawing.Point(47, 82)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(38, 13)
        Me.lblSenha.TabIndex = 4
        Me.lblSenha.Text = "Senha"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(50, 98)
        Me.txtSenha.MaxLength = 100
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(211, 20)
        Me.txtSenha.TabIndex = 2
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 206)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btEntrar)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = true
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login de Usuário"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btEntrar As Button
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtSenha As TextBox
End Class
