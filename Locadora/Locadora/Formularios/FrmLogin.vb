Imports Locadora.ClassesGenerica

Public Class FrmLogin
    Private Sub BtEntrarClick(sender As Object, e As EventArgs) Handles btEntrar.Click
        Dim login As String = txtUsuario.Text
        Dim senha As String = txtSenha.Text
        Dim con As New Connection
        Dim funcionario As FuncionarioDTO = ValidarLogin(login, senha, con)

        If funcionario IsNot Nothing Then
            Me.Close()
            MdiLocadora.BotoesAtivados = True
            MdiLocadora.IsAdmin = funcionario.IsAdmin
        End If

    End Sub

    Public Function ValidarLogin(login As String, senha As String, ByRef con As Connection) As FuncionarioDTO
        Try
            With con
                .Command.Parameters.Clear()
                .Command.Parameters.Add(.InserirParametro(login, "@login", DbType.String))
                .Command.Parameters.Add(.InserirParametro(senha, "@senha", DbType.String))

                .Command.CommandText = "SELECT * FROM tbFuncionarios WHERE Login = @login AND Senha = @senha"

                Dim dt As DataTable = .ExecutaComandoDataTable()

                If dt.Rows.Count > 0 Then
                    Dim funcionario As New FuncionarioDTO With {
                        .IdCadastro = CUInt(dt.Rows(0).Item("IdCadastro")),
                        .Nome = dt.Rows(0).Item("NomeFuncionario").ToString(),
                        .IsAdmin = dt.Rows(0).Item("IsAdmin")
                    }
                    Return funcionario
                Else
                    MessageBox.Show("Usuário ou senha incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return Nothing
                End If
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
