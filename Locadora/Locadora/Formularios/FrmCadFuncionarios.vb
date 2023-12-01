Imports Locadora.ClassesGenerica
Public Class FrmCadFuncionarios
    Private Sub BtSalvarClick(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim con As New Connection()
        Dim nome As String = txtNomeCad.Text.ToUpper()
        Dim login As String = txtUsuarioCad.Text
        Dim senha As String = txtSenhaCad.Text

        Dim cpf As String = txtCadastroCpf.Text.Replace(".", "").Replace("-", "")
        If Not ValidarCampos() Then
            Return
        End If

        If VerificarCpfCadastrado(cpf, con) Then
            MessageBox.Show("CPF já cadastrado. Por favor, insira um CPF válido.", "CPF já cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf VerificarLogin(login, con) Then
            MessageBox.Show("Login já cadastrado. Por favor, tente cadastrar outro login.", "Login já existe!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim isAdmin As Boolean = rbAdmSim.Checked

        Try
            With con
                .Command.Parameters.Clear()
                .Command.Parameters.Add(.InserirParametro(nome, "@nomeFuncionario", DbType.String))
                .Command.Parameters.Add(.InserirParametro(cpf, "@cpf", DbType.String))
                .Command.Parameters.Add(.InserirParametro(login, "@login", DbType.String))
                .Command.Parameters.Add(.InserirParametro(senha, "@senha", DbType.String))
                .Command.Parameters.Add(.InserirParametro(isAdmin, "@isAdmin", DbType.Boolean))

                .Command.CommandText = "INSERT INTO TbFuncionarios (NomeFuncionario, Cpf, Login, Senha, IsAdmin) " &
                                       "VALUES (@nomeFuncionario, @cpf, @login, @senha, @isAdmin)"
                .Command.ExecuteNonQuery()

                MessageBox.Show("Funcionário cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao cadastrar o funcionário. Detalhes: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function VerificarCpfCadastrado(cpf As String, con As Connection) As Boolean
        Try
            If con Is Nothing Then
                ' Lida com a situação em que a conexão é nula
                MessageBox.Show("A conexão com o banco de dados não está disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If con.Command Is Nothing Then
                ' Lida com a situação em que o comando é nulo
                MessageBox.Show("O comando de banco de dados não está disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            ' Aqui, você pode adicionar um novo bloco de verificação
            If con.Command.Connection.State = ConnectionState.Closed Then
                ' Abra a conexão se ela estiver fechada
                con.OpenConnection()
            End If

            With con
                .Command.Parameters.Clear()
                .Command.Parameters.Add(.InserirParametro(cpf, "@cpf", DbType.String))

                .Command.CommandText = "SELECT COUNT(*) FROM TbFuncionarios WHERE Cpf = @cpf"
                Dim count As Integer = CInt(.Command.ExecuteScalar())
                ' Verifica o valor retornado
                If count = 1 Then
                    Return True
                ElseIf count = 0 Then
                    Return False
                Else
                    ' Lida com a situação em que o resultado não é 0 nem 1 (erro ou dados inconsistentes)
                    MessageBox.Show("Resultado inesperado ao verificar o CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao verificar o CPF. Detalhes: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function VerificarLogin(login As String, con As Connection) As Boolean
        Try
            With con
                .Command.Parameters.Clear()
                .Command.Parameters.Add(.InserirParametro(login, "@Login", DbType.String))

                .Command.CommandText = "SELECT COUNT(*) FROM TbFuncionarios WHERE Login = @Login"
                Dim count As Integer = CInt(.Command.ExecuteScalar())

                Return count > 0
            End With
        Catch ex As Exception
            MessageBox.Show("Usuário já cadastrado. Detalhes: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Private Sub BtExcluirClick(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim con As New Connection()
        Dim cpf As String = txtExcluirCpf.Text.Replace("-", "").Replace(".", "")
        Dim login As String = txtUsuarioExcluir.Text

        If Not ValidarCamposExcluir() Then
            Return
        End If

        Try

            con.OpenConnection()

            If MessageBox.Show("Tem certeza de que deseja excluir este funcionário?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                With con
                    .Command.Parameters.Clear()
                    .Command.Parameters.Add(.InserirParametro(cpf, "@cpf", DbType.String))
                    .Command.Parameters.Add(.InserirParametro(login, "@login", DbType.String))

                    .Command.CommandText = "DELETE FROM TbFuncionarios WHERE Cpf = @cpf and Login = @login"
                    Dim rowsAffected As Integer = .Command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Funcionário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Limpa os campos após a exclusão bem-sucedida
                        txtExcluirCpf.Clear()
                        txtUsuarioExcluir.Clear()
                    Else
                        MessageBox.Show("Nenhum funcionário foi excluído. Verifique o CPF e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao excluir o funcionário. Detalhes: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            con.CloseConnection()
        End Try
    End Sub


    Private Sub FrmCadFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ObjFunctions = New Funcoes(Me)
        ObjFunctions.AtribuirEventos(Me)
    End Sub
    Private Function ValidarCampos() As Boolean

        If String.IsNullOrWhiteSpace(txtNomeCad.Text) Then
            MessageBox.Show("Por favor, preencha o campo 'Nome'.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim cpf As String = txtCadastroCpf.Text.Replace(".", "").Replace("-", "")
        If String.IsNullOrWhiteSpace(cpf) Then
            MessageBox.Show("Por favor, preencha o campo 'CPF'.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtUsuarioCad.Text) Then
            MessageBox.Show("Por favor, preencha o campo 'Login'.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtSenhaCad.Text) Then
            MessageBox.Show("Por favor, preencha o campo 'Senha'.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If cpf.Length < 11 Then
            MessageBox.Show("CPF inválido. Por favor, insira um CPF válido.", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Function ValidarCamposExcluir() As Boolean

        If String.IsNullOrWhiteSpace(txtUsuarioExcluir.Text) Then
            MessageBox.Show("Por favor, preencha o campo 'Usuário'.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim cpf As String = txtExcluirCpf.Text.Replace(".", "").Replace("-", "")
        If String.IsNullOrWhiteSpace(cpf) Then
            MessageBox.Show("Por favor, preencha o campo 'CPF'.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If       
        Return True
    End Function

End Class