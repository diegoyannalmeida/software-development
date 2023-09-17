<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MdiLocadora
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
		Me.components = New System.ComponentModel.Container()
		Me.MenuStrip = New System.Windows.Forms.MenuStrip()
		Me.mnuCadastro = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFilmes = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCadastroTitulos = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCadastroGenero = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuTipoDeMidia = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCadClientes = New System.Windows.Forms.ToolStripMenuItem()
		Me.LocaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuGerenciarLocacoes = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusStrip = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.MenuStrip.SuspendLayout()
		Me.StatusStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip
		'
		Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro, Me.LocaçõesToolStripMenuItem})
		Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip.Name = "MenuStrip"
		Me.MenuStrip.Size = New System.Drawing.Size(771, 24)
		Me.MenuStrip.TabIndex = 5
		Me.MenuStrip.Text = "MenuStrip"
		'
		'mnuCadastro
		'
		Me.mnuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFilmes, Me.mnuCadClientes})
		Me.mnuCadastro.Name = "mnuCadastro"
		Me.mnuCadastro.Size = New System.Drawing.Size(66, 20)
		Me.mnuCadastro.Text = "Cadastro"
		'
		'mnuFilmes
		'
		Me.mnuFilmes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastroTitulos, Me.mnuCadastroGenero, Me.mnuTipoDeMidia})
		Me.mnuFilmes.Name = "mnuFilmes"
		Me.mnuFilmes.Size = New System.Drawing.Size(116, 22)
		Me.mnuFilmes.Text = "Filmes"
		'
		'mnuCadastroTitulos
		'
		Me.mnuCadastroTitulos.Name = "mnuCadastroTitulos"
		Me.mnuCadastroTitulos.Size = New System.Drawing.Size(146, 22)
		Me.mnuCadastroTitulos.Text = "Filmes"
		'
		'mnuCadastroGenero
		'
		Me.mnuCadastroGenero.Name = "mnuCadastroGenero"
		Me.mnuCadastroGenero.Size = New System.Drawing.Size(146, 22)
		Me.mnuCadastroGenero.Text = "Gêneros"
		'
		'mnuTipoDeMidia
		'
		Me.mnuTipoDeMidia.Name = "mnuTipoDeMidia"
		Me.mnuTipoDeMidia.Size = New System.Drawing.Size(146, 22)
		Me.mnuTipoDeMidia.Text = "Tipo de Mídia"
		'
		'mnuCadClientes
		'
		Me.mnuCadClientes.Name = "mnuCadClientes"
		Me.mnuCadClientes.Size = New System.Drawing.Size(116, 22)
		Me.mnuCadClientes.Text = "Clientes"
		'
		'LocaçõesToolStripMenuItem
		'
		Me.LocaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGerenciarLocacoes})
		Me.LocaçõesToolStripMenuItem.Name = "LocaçõesToolStripMenuItem"
		Me.LocaçõesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
		Me.LocaçõesToolStripMenuItem.Text = "Locações"
		'
		'mnuGerenciarLocacoes
		'
		Me.mnuGerenciarLocacoes.Name = "mnuGerenciarLocacoes"
		Me.mnuGerenciarLocacoes.Size = New System.Drawing.Size(180, 22)
		Me.mnuGerenciarLocacoes.Text = "Gerenciar Locações"
		'
		'StatusStrip
		'
		Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
		Me.StatusStrip.Location = New System.Drawing.Point(0, 553)
		Me.StatusStrip.Name = "StatusStrip"
		Me.StatusStrip.Size = New System.Drawing.Size(771, 22)
		Me.StatusStrip.TabIndex = 7
		Me.StatusStrip.Text = "StatusStrip"
		'
		'ToolStripStatusLabel
		'
		Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
		Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
		Me.ToolStripStatusLabel.Text = "Status"
		'
		'ImageList1
		'
		Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
		Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		'
		'MdiLocadora
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Locadora.My.Resources.Resources.Interior_of_last_Blockbuster_Video
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(771, 575)
		Me.Controls.Add(Me.MenuStrip)
		Me.Controls.Add(Me.StatusStrip)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip
		Me.Name = "MdiLocadora"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Sistema de Gerenciamento de Locadora - SisGeLoc"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.MenuStrip.ResumeLayout(False)
		Me.MenuStrip.PerformLayout()
		Me.StatusStrip.ResumeLayout(False)
		Me.StatusStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
	Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
	Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
	Friend WithEvents mnuCadastro As ToolStripMenuItem
	Friend WithEvents mnuFilmes As ToolStripMenuItem
	Friend WithEvents mnuCadClientes As ToolStripMenuItem
	Friend WithEvents ImageList1 As ImageList
	Friend WithEvents LocaçõesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents mnuGerenciarLocacoes As ToolStripMenuItem
	Friend WithEvents mnuCadastroTitulos As ToolStripMenuItem
	Friend WithEvents mnuCadastroGenero As ToolStripMenuItem
	Friend WithEvents mnuTipoDeMidia As ToolStripMenuItem
End Class
