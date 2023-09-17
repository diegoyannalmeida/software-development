Imports Locadora.ClassesGenerica

Public Class ClienteAction


    Public Function SalvarCliente(ByRef con As Connection, cliente As ClienteDTO)

        Dim sql As String
        Try
            With cliente

                con.Command.Parameters.Add(con.InserirParametro(.IdCliente, "@idcliente", DbType.UInt16))
                con.Command.Parameters.Add(con.InserirParametro(.Nome, "@nome", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.DataNascimento, "@nascimento", DbType.Date))
                con.Command.Parameters.Add(con.InserirParametro(.Sexo, "@sexo", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Cpf, "@cpf", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Rg, "@rg", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Logradouro, "@logradouro", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.NrCasa, "@nrCasa", DbType.UInt16))
                con.Command.Parameters.Add(con.InserirParametro(.Complemento, "@complemento", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Cep, "@cep", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Bairro, "@bairro", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Cidade, "@cidade", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Uf, "@uf", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Residencial, "@residencial", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Celular, "@celular", DbType.String))
                con.Command.Parameters.Add(con.InserirParametro(.Saldo, "@saldo", DbType.Double))

                con.Command.CommandText = "Select Cpf From TbCliente where Cpf = @cpf"
                Dim dt = con.ExecutaComandoDataTable()

                If dt.Rows.Count > 0 Then
                    Return MsgBox("Já existe um cliente com esse CPF cadastrado no sistema!", MsgBoxStyle.Exclamation)
                    Exit Function
                Else
                    If .IdCliente > 0 Then
                        sql = "Update TbCliente Set Nome = @nome, Nascimento = @nascimento, Sexo = @sexo, Cpf = @cpf, Rg = @rg, Logradouro = logradouro," +
                            "Numero = @nrCasa, Complemento = @complemento, Cep = @cep, Bairro = @bairro, Cidade = @cidade, Uf = @uf," +
                            "TelefoneResidencial = @Residencial,Celular = @celular Where IdCliente=@IdCliente"


                    Else
                        sql = "Insert Into TbCliente (Nome,Nascimento,Sexo,Cpf,Rg,Logradouro,Numero,Complemento,Cep,Bairro,Cidade,Uf,TelefoneResidencial,Celular,Saldo)" +
                            "Values (@nome,@nascimento,@sexo,@cpf,@rg,@logradouro,@nrCasa,@complemento,@cep,@bairro,@cidade,@uf,@residencial,@celular,@saldo)"
                    End If
                End If

                con.Command.CommandText = sql
                con.Command.ExecuteNonQuery()
                Return True

            End With
        Catch ex As Exception
            Throw
        End Try

    End Function



    Public Function ListarTodos(ByRef con As Connection) As List(Of ClienteDTO)
        Try
            Dim resultado = New List(Of ClienteDTO)

            con.Command.CommandText = "Select IdCliente, Nome, Cpf From TbCliente Order By Nome"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                For i As Short = 0 To dt.Rows.Count - 1
                    Dim cliente = New ClienteDTO()

                    If Not Convert.IsDBNull(dt.Rows(i).Item("IdCliente")) Then
                        cliente.IdCliente = Convert.ToUInt16(dt.Rows(i).Item("IdCliente"))
                    End If

                    If Not Convert.IsDBNull(dt.Rows(i).Item("Nome")) Then
                        cliente.Nome = Convert.ToString(dt.Rows(i).Item("Nome"))
                    End If

                    If Not Convert.IsDBNull(dt.Rows(i).Item("Cpf")) Then
                        cliente.Cpf = Convert.ToString(dt.Rows(i).Item("Cpf"))
                    End If

                    resultado.Add(cliente)
                Next
            End If

            Return resultado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodosPorCPF(ByRef con As Connection, cpf As String) As List(Of ClienteDTO)
        Try
            Dim resultado = New List(Of ClienteDTO)
            con.Command.Parameters.Add(con.InserirParametro(cpf, "@cpf", DbType.String))

            con.Command.CommandText = "Select IdCliente,Nome,Cpf From TbCliente " +
                "Where (cpf like '%' @cpf '%') Order By Nome"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim cliente = New ClienteDTO With {
                        .IdCliente = dt.Rows(i).Item("IdCliente"),
                        .Nome = dt.Rows(i).Item("Nome"),
                        .Cpf = dt.Rows(i).Item("Cpf")
                        }

                    resultado.Add(cliente)
                Next

            End If
            Return resultado

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function ListarIndividualPorCpf(ByRef con As Connection, cpf As String) As ClienteDTO

        Try
            Dim cliente = New ClienteDTO

            con.Command.Parameters.Add(con.InserirParametro(cpf, "@Cpf", DbType.String))

            con.Command.CommandText = "Select IdCliente, Nome, Cpf From TbCliente " +
                "Where (Cpf Like '%' @Cpf '%')"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then

                cliente.IdCliente = dt.Rows(0).Item("IdCliente")
                cliente.Nome = dt.Rows(0).Item("Nome")
                cliente.Cpf = dt.Rows(0).Item("Cpf")
            End If


            Return cliente

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function ListarIndividualPorId(ByRef con As Connection, IdCliente As UInt16) As ClienteDTO

        Try
            Dim cliente = New ClienteDTO

            con.Command.Parameters.Add(con.InserirParametro(IdCliente, "@IdCliente", DbType.String))

            con.Command.CommandText = "Select IdCliente, Nome, Cpf From TbCliente " +
                "Where IdCliente = @IdCliente"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                With cliente
                    .IdCliente = dt.Rows(0).Item("IdCliente")
                    .Nome = dt.Rows(0).Item("Nome")
                    .Cpf = dt.Rows(0).Item("Cpf")
                End With

            End If


            Return cliente

        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function Detalhar(ByRef con As Connection, ByRef cpf As String) As ClienteDTO

        Try
            Dim cliente = New ClienteDTO
            con.Command.Parameters.Add(con.InserirParametro(cpf, "@cpf", DbType.String))

            con.Command.CommandText = "select idCliente,Nome,Sexo,Nascimento,cpf,Rg,Logradouro, " +
            "Numero,Complemento,Cep,Bairro,Cidade,Uf,TelefoneResidencial, Celular,Saldo " +
            "From TbCliente Where (tbcliente.cpf like '%' @cpf '%')"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                With cliente
                    .Nome = dt.Rows(0).Item("Nome").ToString()
                    .Sexo = dt.Rows(0).Item("Sexo").ToString()
                    .DataNascimento = dt.Rows(0).Item("Nascimento").ToString()
                    .Cpf = dt.Rows(0).Item("Cpf").ToString()
                    .Rg = dt.Rows(0).Item("Rg").ToString()
                    .Logradouro = dt.Rows(0).Item("Logradouro").ToString()
                    .NrCasa = dt.Rows(0).Item("Numero").ToString()
                    .Complemento = dt.Rows(0).Item("Complemento").ToString()
                    .Cep = dt.Rows(0).Item("Cep").ToString()
                    .Bairro = dt.Rows(0).Item("Bairro").ToString()
                    .Cidade = dt.Rows(0).Item("Cidade").ToString()
                    .Uf = dt.Rows(0).Item("Uf").ToString()
                    .Residencial = dt.Rows(0).Item("TelefoneResidencial").ToString()
                    .Celular = dt.Rows(0).Item("Celular").ToString()
                    .IdCliente = dt.Rows(0).Item("idCliente").ToString()
                    .Saldo = dt.Rows(0).Item("saldo").ToString()

                End With


            End If

            Return cliente

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function ExcluirCadastro(ByRef con As Connection, ByVal cpf As String) As Boolean
        Try
            cpf = cpf.Replace(".", "").Replace("-", "")

            With con
                .Command.Parameters.Add(.InserirParametro(cpf, "@Cpf", DbType.String))
                .Command.CommandText = "SET SQL_SAFE_UPDATES = 0"

                .Command.CommandText = "DELETE FROM tbCliente WHERE REPLACE(Cpf, '.', '') = @Cpf"

                .Command.ExecuteNonQuery()
            End With

            Return True

        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
