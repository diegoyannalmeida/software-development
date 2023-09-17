
Public Class MdiLocadora
    Private Sub MnuCadastroGenero_Click(sender As Object, e As EventArgs) Handles mnuCadastroGenero.Click

        'Dim frmCadGenero = New FrmCadGenero()
        FrmCadGenero.MdiParent = Me
        frmCadGenero.Show()

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
End Class
