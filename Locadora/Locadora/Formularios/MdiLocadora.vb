
Public Class MdiLocadora


#Region "Propriedades"
    Private _botoesAtivados As Boolean = False
    Public Property BotoesAtivados As Boolean
        Get
            Return _botoesAtivados
        End Get
        Set(value As Boolean)
            _botoesAtivados = value
            ' Ative/desative os botões conforme o estado
            mnuCadastro.Enabled = _botoesAtivados
            mnuLocacoes.Enabled = _botoesAtivados
        End Set
    End Property

    Private _isAdmin As Boolean = False

    Public Property IsAdmin As Boolean
        Get
            Return _isAdmin
        End Get
        Set(value As Boolean)
            _isAdmin = value

            mnuCadastrarFuncionarios.Visible = _isAdmin
        End Set
    End Property

#End Region
    Private Sub MdiLocadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FrmLogin = New FrmLogin With {
       .MdiParent = Me
       }
        mnuCadastro.Enabled = False
        mnuLocacoes.Enabled = False

        FrmLogin.Show()
    End Sub
    Private Sub MnuCadastroGenero_Click(sender As Object, e As EventArgs) Handles mnuCadastroGenero.Click

        'Dim frmCadGenero = New FrmCadGenero()
        FrmCadGenero.MdiParent = Me
        FrmCadGenero.Show()

    End Sub


    Private Sub CadastrarClientes_Click(sender As Object, e As EventArgs) Handles mnuCadClientes.Click
        Dim frmCadCliente = New FrmCadCliente With {
            .MdiParent = Me
        }
        frmCadCliente.Show()

    End Sub

    Private Sub CadastrarFilmesClick(sender As Object, e As EventArgs) Handles mnuCadastroTitulos.Click
        Dim FrmCadFilmes = New FrmCadFilmes With {
            .MdiParent = Me
        }
        FrmCadFilmes.Show()


    End Sub
    Private Sub CadastrarTipoDeMidiaClick(sender As Object, e As EventArgs) Handles mnuTipoDeMidia.Click
        FrmCadMidia.MdiParent = Me
        FrmCadMidia.Show()

    End Sub

    Private Sub GerenciarLocacoesClick(sender As Object, e As EventArgs) Handles mnuGerenciarLocacoes.Click
        Dim FrmCadLocacoes = New FrmCadLocacoes With {
            .MdiParent = Me
        }

        FrmCadLocacoes.Show()

    End Sub
    Private Sub DeslogarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeslogarToolStripMenuItem.Click

        For Each form In Me.MdiChildren
            form.Close()
        Next

        Dim FrmLogin As New FrmLogin With {
            .MdiParent = Me
        }
        FrmLogin.Show()

        mnuCadastro.Enabled = False
        mnuLocacoes.Enabled = False
    End Sub
   
    Private Sub CadastrarToolStripMenuItemClick(sender As Object, e As EventArgs) Handles CadastrarToolStripMenuItem.Click
          Dim FrmCadFuncionarios = New FrmCadFuncionarios With {
            .MdiParent = Me
        }
        FrmCadFuncionarios.Show
    End Sub
End Class
