<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListClientes
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
		Me.grdListaClientes = New System.Windows.Forms.DataGridView()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.btnNovoCliente = New System.Windows.Forms.Button()
		Me.gpbDados = New System.Windows.Forms.GroupBox()
		Me.txtCpfConsulta = New System.Windows.Forms.TextBox()
		Me.lbCpf = New System.Windows.Forms.Label()
		CType(Me.grdListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gpbDados.SuspendLayout()
		Me.SuspendLayout()
		'
		'grdListaClientes
		'
		Me.grdListaClientes.AllowUserToAddRows = False
		Me.grdListaClientes.AllowUserToDeleteRows = False
		Me.grdListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdListaClientes.Location = New System.Drawing.Point(12, 97)
		Me.grdListaClientes.Name = "grdListaClientes"
		Me.grdListaClientes.RowHeadersVisible = False
		Me.grdListaClientes.Size = New System.Drawing.Size(751, 390)
		Me.grdListaClientes.TabIndex = 1
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(676, 492)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(87, 23)
		Me.btnCancelar.TabIndex = 2
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = True
		'
		'btnNovoCliente
		'
		Me.btnNovoCliente.Location = New System.Drawing.Point(794, 524)
		Me.btnNovoCliente.Name = "btnNovoCliente"
		Me.btnNovoCliente.Size = New System.Drawing.Size(75, 23)
		Me.btnNovoCliente.TabIndex = 3
		Me.btnNovoCliente.Text = "Novo"
		Me.btnNovoCliente.UseVisualStyleBackColor = True
		'
		'gpbDados
		'
		Me.gpbDados.Controls.Add(Me.lbCpf)
		Me.gpbDados.Controls.Add(Me.txtCpfConsulta)
		Me.gpbDados.Location = New System.Drawing.Point(12, 12)
		Me.gpbDados.Name = "gpbDados"
		Me.gpbDados.Size = New System.Drawing.Size(751, 79)
		Me.gpbDados.TabIndex = 4
		Me.gpbDados.TabStop = False
		'
		'txtCpfConsulta
		'
		Me.txtCpfConsulta.Location = New System.Drawing.Point(7, 38)
		Me.txtCpfConsulta.MaxLength = 11
		Me.txtCpfConsulta.Name = "txtCpfConsulta"
		Me.txtCpfConsulta.Size = New System.Drawing.Size(264, 20)
		Me.txtCpfConsulta.TabIndex = 0
		'
		'lbCpf
		'
		Me.lbCpf.AutoSize = True
		Me.lbCpf.Location = New System.Drawing.Point(7, 19)
		Me.lbCpf.Name = "lbCpf"
		Me.lbCpf.Size = New System.Drawing.Size(95, 13)
		Me.lbCpf.TabIndex = 1
		Me.lbCpf.Text = "CPF para Consulta"
		'
		'FrmListClientes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(775, 527)
		Me.Controls.Add(Me.gpbDados)
		Me.Controls.Add(Me.btnNovoCliente)
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.grdListaClientes)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "FrmListClientes"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Clientes"
		CType(Me.grdListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gpbDados.ResumeLayout(False)
		Me.gpbDados.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents grdListaClientes As DataGridView
	Friend WithEvents btnCancelar As Button
	Friend WithEvents btnNovoCliente As Button
	Friend WithEvents gpbDados As GroupBox
	Friend WithEvents lbCpf As Label
	Friend WithEvents txtCpfConsulta As TextBox
End Class
