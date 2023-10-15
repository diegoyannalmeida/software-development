Imports Locadora.ClassesGenerica


Public Class FilmesAction


    Public Function SalvarFilme(ByRef con As Connection, filme As FilmesDTO)

        Try
            Dim sql As String
            con.Command.Parameters.Clear()

            con.Command.Parameters.Add(con.InserirParametro(filme.TituloFilme, "@TituloFilme", DbType.String))
            con.Command.Parameters.Add(con.InserirParametro(filme.Genero, "@Genero", DbType.String))
            con.Command.Parameters.Add(con.InserirParametro(filme.AnoLancamento, "@AnoLancamento", DbType.String))
            con.Command.Parameters.Add(con.InserirParametro(filme.Duracao, "@Duracao", DbType.UInt16))
            con.Command.Parameters.Add(con.InserirParametro(filme.QtdeMidias, "@QtdeMidias", DbType.UInt16))
            con.Command.Parameters.Add(con.InserirParametro(filme.QtdeEstoque, "@QtdeEstoque", DbType.UInt16))
            con.Command.Parameters.Add(con.InserirParametro(filme.ValorLocacao, "@ValorLocacao", DbType.Double))
            con.Command.Parameters.Add(con.InserirParametro(filme.TipoMidia, "@TipoMidia", DbType.String))


            If filme.IdFilme > 0 Then
                sql = "Update TbFilmes Set TituloFilme = @TituloFilme, Genero = @Genero, " +
                "AnoLancamento = @AnoLancamento, Duracao = @Duracao, QtdeMidias = @QtdeMidias,QtdeEstoque = @QtdeEstoque," +
                "ValorLocacao = @ValorLocacao,TipoMidia = @TipoMidia Where TituloFilme = @TituloFilme And AnoLancamento = @AnoLancamento"

            Else
                sql = "Insert Into TbFilmes (TituloFilme, Genero, AnoLancamento,Duracao,QtdeMidias, QtdeEstoque,TipoMidia, ValorLocacao) Values " +
                "(@TituloFilme, @Genero, @AnoLancamento,@Duracao,@QtdeMidias,@QtdeEstoque,@TipoMidia, @ValorLocacao)"

            End If

            con.Command.CommandText = sql
            con.Command.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function AdicionaFilmeEstoque(ByRef con As Connection, idFilme As UShort, quantidade As UShort)
        Try
            With con
                .Command.Parameters.Clear()
                .Command.Parameters.Add(.InserirParametro(idFilme, "@idFilme", DbType.UInt16))
                .Command.CommandText = "Select QtdeEstoque from TbFilmes where idFilme = @idFilme"

                Dim dt = .ExecutaComandoDataTable()

                If dt.Rows.Count > 0 Then
                    Dim estoqueAtual = dt.Rows(0).Item("QtdeEstoque")
                    quantidade += estoqueAtual
                    .Command.Parameters.Add(.InserirParametro(quantidade, "@quantidade", DbType.UInt16))
                    .Command.CommandText = "Update TbFilmes set QtdeEstoque = @quantidade where " +
                        "idFilme = @idFilme"
                    .Command.ExecuteNonQuery()
                End If
                Return quantidade
            End With

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function ListarTodosFilmes(ByRef con As Connection) As List(Of FilmesDTO)
        Try
            Dim resultado = New List(Of FilmesDTO)
            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select IdFilme, TituloFilme, AnoLancamento, QtdeMidias, Genero, " +
                "ValorLocacao From TbFilmes Order By TituloFilme"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                For i As Short = 0 To dt.Rows.Count - 1
                    Dim filmes = New FilmesDTO With {
                        .IdFilme = dt.Rows(i).Item("IdFilme"),
                        .TituloFilme = dt.Rows(i).Item("TituloFilme"),
                        .AnoLancamento = dt.Rows(i).Item("AnoLancamento"),
                        .QtdeMidias = dt.Rows(i).Item("QtdeMidias"),
                        .Genero = dt.Rows(i).Item("Genero"),
                        .ValorLocacao = dt.Rows(i).Item("ValorLocacao")
                        }

                    resultado.Add(filmes)
                Next
            End If

            Return resultado

        Catch ex As Exception
            Throw
        End Try

    End Function
    Public Function ListarTodosFilmesPorNome(ByRef con As Connection, titulo As String) As List(Of FilmesDTO)
        Try
            Dim resultado = New List(Of FilmesDTO)
            con.Command.Parameters.Clear()
            con.Command.Parameters.Add(con.InserirParametro(titulo, "@titulo", DbType.String))
            con.Command.CommandText = "Select IdFilme, TituloFilme, AnoLancamento, QtdeMidias, Genero, " +
                "ValorLocacao From TbFilmes Where (TituloFilme Like '%' @titulo '%') Order By TituloFilme"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                For i As Short = 0 To dt.Rows.Count - 1
                    Dim filmes = New FilmesDTO With {
                        .IdFilme = dt.Rows(i).Item("IdFilme"),
                        .TituloFilme = dt.Rows(i).Item("TituloFilme"),
                        .AnoLancamento = dt.Rows(i).Item("AnoLancamento"),
                        .QtdeMidias = dt.Rows(i).Item("QtdeMidias"),
                        .Genero = dt.Rows(i).Item("Genero"),
                        .ValorLocacao = dt.Rows(i).Item("ValorLocacao")
                        }
                    resultado.Add(filmes)
                Next
            End If

            Return resultado

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function ListaraPorGenero(ByRef con As Connection, ByVal genero As String) As List(Of FilmesDTO)

        Try
            Dim resultado = New List(Of FilmesDTO)
            con.Command.Parameters.Clear()
            con.Command.Parameters.Add(con.InserirParametro(genero, "@Genero", DbType.String))

            con.Command.CommandText = "Select IdFilme,TituloFilme,Genero,AnoLancamento From TbFilmes" +
                " Where Genero Like ('%' @Genero '%')"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then
                For i As Short = 0 To dt.Rows.Count - 1
                    Dim filme = New FilmesDTO With {
                        .IdFilme = dt.Rows(i).Item("IdFilme"),
                        .TituloFilme = dt.Rows(i).Item("TituloFilme"),
                        .Genero = dt.Rows(i).Item("Genero"),
                        .AnoLancamento = dt.Rows(i).Item("AnoLancamento")
                        }
                    resultado.Add(filme)
                Next

            End If

            Return resultado

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function ListarIndividualPorTitulo(ByRef con As Connection, ByVal tituloDoFilme As String) As FilmesDTO
        Try
            Dim filme = New FilmesDTO
            con.Command.Parameters.Clear()

            con.Command.Parameters.Add(con.InserirParametro(tituloDoFilme, "@TituloFilme", DbType.String))

            con.Command.CommandText = "Select IdFilme, TituloFilme, Genero, AnoLancamento,Duracao,QtdeMidias," +
                "ValorLocacao, TipoMidia, QtdeEstoque From TbFilmes Where (TituloFilme Like '%' @TituloFilme '%')"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then

                With filme
                    .IdFilme = dt.Rows(0).Item("IdFilme")
                    .TituloFilme = dt.Rows(0).Item("TituloFilme")
                    .Genero = dt.Rows(0).Item("Genero")
                    .AnoLancamento = dt.Rows(0).Item("AnoLancamento")
                    .Duracao = dt.Rows(0).Item("Duracao")
                    .QtdeMidias = dt.Rows(0).Item("QtdeMidias")
                    .ValorLocacao = dt.Rows(0).Item("ValorLocacao")
                    .TipoMidia = dt.Rows(0).Item("TipoMidia")
                    .QtdeEstoque = dt.Rows(0).Item("QtdeEstoque")

                End With

            End If

            Return filme

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function ListarIndividualPorId(ByRef con As Connection, ByRef idFilme As UInt16) As FilmesDTO
        Try
            Dim filme = New FilmesDTO

            con.Command.Parameters.Clear()

            con.Command.Parameters.Add(con.InserirParametro(idFilme, "@IdFilme", DbType.UInt16))

            con.Command.CommandText = "Select IdFilme, TituloFilme, Genero, AnoLancamento,Duracao,QtdeMidias,ValorLocacao, " +
                "TipoMidia, QtdeEstoque From TbFilmes Where IdFilme = @IdFilme"

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then

                With filme
                    .IdFilme = dt.Rows(0).Item("IdFilme")
                    .TituloFilme = dt.Rows(0).Item("TituloFilme")
                    .Genero = dt.Rows(0).Item("Genero")
                    .AnoLancamento = dt.Rows(0).Item("AnoLancamento")
                    .Duracao = dt.Rows(0).Item("Duracao")
                    .QtdeMidias = dt.Rows(0).Item("QtdeMidias")
                    .ValorLocacao = dt.Rows(0).Item("ValorLocacao")
                    .TipoMidia = dt.Rows(0).Item("TipoMidia")
                    .QtdeEstoque = dt.Rows(0).Item("QtdeEstoque")


                End With

            End If

            Return filme

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function RemoveFilmeEstoque(ByRef con As Connection, idFilme As UShort, quantidade As UShort)
        Try
            With con
                .Command.Parameters.Clear()
                .Command.Parameters.Add(.InserirParametro(idFilme, "@idFilme", DbType.UInt16))

                .Command.CommandText = "Select QtdeEstoque from TbFilmes where idFilme = @idFilme"

                Dim dt = .ExecutaComandoDataTable()

                If dt.Rows.Count > 0 Then
                    Dim estoqueAtual = dt.Rows(0).Item("QtdeEstoque")
                    If estoqueAtual > quantidade Then
                        quantidade = estoqueAtual - quantidade
                        .Command.Parameters.Add(.InserirParametro(quantidade, "@quantidade", DbType.UInt16))
                        .Command.CommandText = "Update TbFilmes set QtdeEstoque = @quantidade where " +
                            "idFilme = @idFilme"
                        .Command.ExecuteNonQuery()
                    Else
                        MsgBox("O estoque não pode ser menor que zero!", MsgBoxStyle.Exclamation)
                    End If

                End If
                Return quantidade
            End With

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function ExcluirCadastro(ByRef con As Connection, ByVal idFilme As UInt16) As Boolean
        Try
            con.Command.Parameters.Add(con.InserirParametro(idFilme, "@IdFilme", DbType.UInt16))
            con.Command.CommandText = "Delete From TbFilmes Where IdFilme = @IdFilme"
            con.Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw
        End Try



    End Function

End Class
