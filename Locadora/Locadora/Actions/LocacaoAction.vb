Imports Locadora.ClassesGenerica

Public Class LocacaoAction

#Region "CRUD"

#Region "Salvar"
	Public Function SalvarAluguel(ByRef con As Connection, filme As FilmesDTO, cliente As ClienteDTO, locacao As LocacaoDTO)
		Try
			With con
				.Command.Parameters.Clear()



				.Command.Parameters.Add(.InserirParametro(filme.IdFilme, "@idFilme", DbType.UInt16))
				.Command.Parameters.Add(.InserirParametro(filme.ValorLocacao, "@ValorLocacao", DbType.Double))
				.Command.Parameters.Add(.InserirParametro(cliente.IdCliente, "@IdCliente", DbType.UInt16))
				.Command.Parameters.Add(.InserirParametro(locacao.DataEntrega, "@DataEntrega", DbType.Date))
				.Command.Parameters.Add(.InserirParametro(locacao.DataRetirada, "@DataRetirada", DbType.Date))
				.Command.Parameters.Add(.InserirParametro(locacao.DiasAluguel, "@DiasAluguel", DbType.UInt16))

				.Command.CommandText = "Select QtdeEstoque from TbFilmes where idfilme = @idfilme"
				Dim dt = .ExecutaComandoDataTable()

				Dim qtdeEstoque = dt.Rows(0).Item("qtdeEstoque")

				If qtdeEstoque = 0 Then
					MsgBox("Filme indisponível no estoque", MsgBoxStyle.Exclamation)
				Else
					.Command.CommandText = "Insert Into TbLocacao (idFilme,idCliente, ValorLocacao, DataRetirada, DataEntrega, DiasAluguel) " +
					"Values (@idFilme, @IdCliente, @ValorLocacao, @DataRetirada, @DataEntrega,@DiasAluguel)"
					.Command.ExecuteNonQuery()

					Dim estoque = New FilmesAction().RemoveFilmeEstoque(con, filme.IdFilme, 1)
				End If




			End With

			Return True
		Catch ex As Exception
			Throw
		End Try

	End Function


	Public Function SalvarFilmeReservado(ByRef con As Connection, filmes As List(Of FilmesDTO))

		Try
			With con
				.Command.Parameters.Clear()

				.Command.CommandText = "Select IdFilme,TituloFilme from tbfilmesaluguel"
				Dim dt = .ExecutaComandoDataTable()
				Dim sql = "Insert Into tbfilmesaluguel (IdFilme,TituloFilme,AnoLancamento,TipoMidia,QtdeMidias,ValorLocacao) " +
							"Values (@idFilme,@tituloFilme,@anoLancamento,@tipoMidia,@qtdeMidias,@valorLocacao)"

				If dt.Rows.Count > 0 AndAlso dt.Rows(0).Item("IdFilme") > 0 Then

					.Command.CommandText = "Delete from tbfilmesaluguel"
					.Command.ExecuteNonQuery()

					For i As Short = 0 To filmes.Count - 1
						.Command.Parameters.Clear()
						.Command.Parameters.Add(.InserirParametro(filmes(i).IdFilme, "@idFilme", DbType.UInt16))
						.Command.Parameters.Add(.InserirParametro(filmes(i).TituloFilme, "@tituloFilme", DbType.String))
						.Command.Parameters.Add(.InserirParametro(filmes(i).AnoLancamento, "@anoLancamento", DbType.UInt16))
						.Command.Parameters.Add(.InserirParametro(filmes(i).TipoMidia, "@TipoMidia", DbType.String))
						.Command.Parameters.Add(.InserirParametro(filmes(i).QtdeMidias, "@qtdeMidias", DbType.UInt16))
						.Command.Parameters.Add(.InserirParametro(filmes(i).ValorLocacao, "@valorLocacao", DbType.Double))

						.Command.CommandText = sql

						.Command.ExecuteNonQuery()
					Next

				Else
					For i As Short = 0 To filmes.Count - 1
						.Command.Parameters.Clear()
						.Command.Parameters.Add(.InserirParametro(filmes(i).IdFilme, "@idFilme", DbType.UInt16))
						.Command.Parameters.Add(.InserirParametro(filmes(i).TituloFilme, "@tituloFilme", DbType.String))
						.Command.Parameters.Add(.InserirParametro(filmes(i).AnoLancamento, "@anoLancamento", DbType.UInt16))
						.Command.Parameters.Add(.InserirParametro(filmes(i).TipoMidia, "@TipoMidia", DbType.String))
						.Command.Parameters.Add(.InserirParametro(filmes(i).QtdeMidias, "@qtdeMidias", DbType.UInt16))
						.Command.Parameters.Add(.InserirParametro(filmes(i).ValorLocacao, "@valorLocacao", DbType.Double))

						.Command.CommandText = sql

						.Command.ExecuteNonQuery()
					Next

				End If
			End With


			Return True

		Catch ex As Exception
			Throw
		End Try

	End Function

	Public Function SalvarSaldoCliente(ByRef con As Connection, cpf As String, saldo As Double)
		Try
			With con
				.Command.Parameters.Clear()
				.Command.Parameters.Add(.InserirParametro(cpf, "@cpf", DbType.String))
				.Command.Parameters.Add(.InserirParametro(saldo, "@saldo", DbType.Double))

				.Command.CommandText = "Select Saldo,cpf from tbcliente where cpf = @cpf"
				Dim dt = .ExecutaComandoDataTable()
				Dim sql As String
				Dim cliente = New ClienteDTO

				If dt.Rows(0).Item("Cpf") <> 0 Then
					sql = "Update tbcliente Set Saldo = @saldo where Cpf = @cpf"
				Else
					sql = "Insert into TbSaldo (Cpf,Saldo) values (@cpf,@saldo)"
				End If

				.Command.CommandText = sql
				.Command.ExecuteNonQuery()

				Return True
			End With

		Catch ex As Exception
			Throw
		End Try


	End Function

	Public Function SalvarHistoricoLocacaoCliente(ByRef con As Connection, cpf As String, filme As LocacaoDTO, idcliente As UShort)
		Try
			With con

				.Command.Parameters.Clear()
				.Command.Parameters.Add(.InserirParametro(cpf, "@cpf", DbType.String))
				.Command.Parameters.Add(.InserirParametro(idcliente, "@idCliente", DbType.UInt16))
				.Command.Parameters.Add(.InserirParametro(filme.IdFilme, "@idFilme", DbType.UInt16))
				.Command.Parameters.Add(.InserirParametro(filme.DataRetirada, "@dataRetirada", DbType.Date))
				.Command.Parameters.Add(.InserirParametro(filme.DataEntrega, "@dataEntrega", DbType.Date))
				.Command.Parameters.Add(.InserirParametro(filme.ValorLocacao, "@valorLocacao", DbType.Double))

				.Command.CommandText = "Insert into TbHistoricoLocacao (Cpf,IdFilme,DataRetirada,DataEntrega,valorLocacao)" +
					" values (@cpf,@idFilme,@dataRetirada,@dataEntrega,@valorLocacao)"
				.Command.ExecuteNonQuery()

				.Command.CommandText = "Delete from Tblocacao where idFilme = @idFilme and idcliente = @idcliente"
				.Command.ExecuteNonQuery()

				Dim estoque = New FilmesAction().AdicionaFilmeEstoque(con, filme.IdFilme, 1)

				Return True
			End With
		Catch ex As Exception
			Throw
		End Try
	End Function

#End Region

#Region "Listar"


#Region "Listar Clientes"
	Public Function ListarTodosClientesComFilmes(ByRef con As Connection) As List(Of ClienteDTO)

		Try
			With con
				.Command.CommandText = "Select tbcliente.IdCliente, Nome, Cpf " +
					"from tbcliente inner join tblocacao " +
					"on tbcliente.IdCliente = tblocacao.idcliente " +
					"group by nome"

				Dim dt = .ExecutaComandoDataTable()
				Dim lista = New List(Of ClienteDTO)

				If dt.Rows.Count > 0 Then
					For i As Short = 0 To dt.Rows.Count - 1
						Dim cliente = New ClienteDTO With {
							.IdCliente = dt.Rows(i).Item("idCliente"),
							.Nome = dt.Rows(i).Item("Nome"),
							.Cpf = dt.Rows(i).Item("Cpf")
						}
						lista.Add(cliente)
					Next
				End If

				Return lista

			End With
		Catch ex As Exception
			Throw
		End Try

	End Function

	Public Function ListarClientesComFilmesPorCpf(ByRef con As Connection, cpf As String) As List(Of ClienteDTO)
		Try
			With con
				.Command.Parameters.Add(.InserirParametro(cpf, "@cpf", DbType.String))
				Dim lista = New List(Of ClienteDTO)

				.Command.CommandText = "Select Tbcliente.Idcliente,Nome,Cpf From Tbcliente " +
					"Inner Join Tblocacao On Tblocacao.Idcliente = Tbcliente.Idcliente " +
					"Where (Cpf Like '%' @cpf '%') Group By Nome;"

				Dim dt = .ExecutaComandoDataTable()

				If dt.Rows.Count > 0 Then
					For i As Short = 0 To dt.Rows.Count - 1
						Dim cliente = New ClienteDTO With {
							.IdCliente = dt.Rows(i).Item("IdCliente"),
							.Nome = dt.Rows(i).Item("Nome"),
							.Cpf = dt.Rows(i).Item("Cpf")
						}
						lista.Add(cliente)
					Next
				End If
				Return lista
			End With
		Catch ex As Exception
			Throw
		End Try

	End Function


	Public Function ObterClienteComFilmesPorId(ByRef con As Connection, idcliente As UShort) As ClienteDTO

		Try
			With con
				.Command.Parameters.Clear()
				.Command.Parameters.Add(.InserirParametro(idcliente, "@idcliente", DbType.UInt16))

				.Command.CommandText = "Select tbcliente.IdCliente, Nome, Cpf " +
					"from tbcliente inner join tblocacao " +
					"on tbcliente.IdCliente = tblocacao.idcliente where tblocacao.idCliente = @idCliente " +
					"group by nome"

				Dim dt = .ExecutaComandoDataTable()

				Dim cliente = New ClienteDTO With {
							.IdCliente = dt.Rows(0).Item("idCliente"),
							.Nome = dt.Rows(0).Item("Nome"),
							.Cpf = dt.Rows(0).Item("Cpf")
						}

				Return cliente
			End With
		Catch ex As Exception
			Throw
		End Try

	End Function

#End Region

#Region "Listar Filmes"
	Public Function ListarFilmesReservados(ByRef con As Connection) As List(Of FilmesDTO)

		Try
			Dim lista = New List(Of FilmesDTO)
			con.Command.CommandText = "Select IdFilme,TituloFilme,AnoLancamento,TipoMidia,QtdeMidias,ValorLocacao " +
				"From tbfilmesaluguel Order By TituloFilme"

			Dim dt = con.ExecutaComandoDataTable()

			If dt.Rows.Count > 0 Then
				For i As Short = 0 To dt.Rows.Count - 1
					Dim filme = New FilmesDTO With {
						.IdFilme = dt.Rows(i).Item("idFilme"),
						.TituloFilme = dt.Rows(i).Item("TituloFilme"),
						.AnoLancamento = dt.Rows(i).Item("AnoLancamento"),
						.TipoMidia = dt.Rows(i).Item("TipoMidia"),
						.QtdeMidias = dt.Rows(i).Item("QtdeMidias"),
						.ValorLocacao = dt.Rows(i).Item("ValorLocacao")
						}
					lista.Add(filme)
				Next
			End If
			Return lista

		Catch ex As Exception
			Throw

		End Try

	End Function

	Public Function ListarFilmesAlugadosPorCliente(ByRef con As Connection, idCliente As UShort) As List(Of LocacaoDTO)

		Try
			With con
				.Command.Parameters.Clear()
				.Command.Parameters.Add(.InserirParametro(idCliente, "@idCliente", DbType.UInt16))

				.Command.CommandText = "select tbfilmes.IdFilme,TituloFilme,AnoLancamento," +
					"tbfilmes.ValorLocacao, QtdeMidias, tblocacao.DataRetirada, tblocacao.DataEntrega" +
					" from tbfilmes inner join tblocacao on tbfilmes.IdFilme = tblocacao.IDFILME " +
					"where tblocacao.IdCliente = @idCliente group by TituloFilme order by TituloFilme;"

				Dim dt = .ExecutaComandoDataTable()
				Dim lista = New List(Of LocacaoDTO)

				If dt.Rows.Count > 0 Then
					For i As Short = 0 To dt.Rows.Count - 1
						Dim filme = New LocacaoDTO With {
							.IdFilme = dt.Rows(i).Item("idFilme"),
							.TituloFilme = dt.Rows(i).Item("TituloFilme"),
							.AnoLancamento = dt.Rows(i).Item("AnoLancamento"),
							.QtdeMidias = dt.Rows(i).Item("QtdeMidias"),
							.ValorLocacao = dt.Rows(i).Item("ValorLocacao"),
							.DataRetirada = dt.Rows(i).Item("DataRetirada"),
							.DataEntrega = dt.Rows(i).Item("DataEntrega")
						}
						lista.Add(filme)
					Next
				End If

				Return lista

			End With

		Catch ex As Exception
			Throw
		End Try

	End Function

	Public Function ListarFilmesAlugados(con As Connection) As List(Of LocacaoDTO)
		Try
			With con
				.Command.CommandText = "select tblocacao.idcliente,TituloFilme,tbfilmes.idfilme," +
					"dataretirada,dataentrega from tblocacao inner join tbfilmes" +
					" on tblocacao.IdFilme = tbfilmes.IdFilme group by TituloFilme;"

				Dim dt = .ExecutaComandoDataTable()

				Dim lista = New List(Of LocacaoDTO)

				For i As Short = 0 To dt.Rows.Count - 1
					Dim locacao = New LocacaoDTO()
					With locacao
						.IdCliente = dt.Rows(i).Item("IdCliente")
						.IdFilme = dt.Rows(i).Item("IdFilme")
						.TituloFilme = dt.Rows(i).Item("TituloFilme")
						.DataRetirada = dt.Rows(i).Item("DataRetirada")
						.DataEntrega = dt.Rows(i).Item("DataEntrega")
					End With
					lista.Add(locacao)
				Next
				Return lista
			End With
		Catch ex As Exception
			Throw
		End Try


	End Function

#End Region



#End Region


#Region "Calculos e valores"

	Public Function SomarTotalLocacaoAluguel(ByRef con As Connection)
		Try
			con.Command.CommandText = "select Sum(ValorLocacao) From tbfilmesaluguel"
			Dim dt = con.ExecutaComandoDataTable()
			If IsDBNull(dt.Rows(0).Item("Sum(ValorLocacao)")) Then
				Return "0.0"

			ElseIf dt.Rows(0).Item("Sum(ValorLocacao)") > 0 Then
				Dim resultado As Double
				resultado = dt.Rows(0).Item("Sum(ValorLocacao)")
				Return resultado

			Else Return "0.0"

			End If

		Catch ex As Exception
			Throw
		End Try


	End Function

	Public Function ObterValorEDataDevolucao(ByRef con As Connection, idCliente As UShort, idFilme As UShort) As LocacaoDTO
		Try
			With con

				.Command.Parameters.Clear()
				.Command.Parameters.Add(.InserirParametro(idCliente, "@idCliente", DbType.UInt16))
				.Command.Parameters.Add(.InserirParametro(idFilme, "@idFilme", DbType.UInt16))
				Dim locacao = New LocacaoDTO
				.Command.CommandText = "select ValorLocacao,DataEntrega From tblocacao " +
					"where idCliente = @idCliente and idFilme = @idFilme"
				Dim dt = .ExecutaComandoDataTable()

				locacao.ValorLocacao = dt.Rows(0).Item("ValorLocacao")
				locacao.DataEntrega = dt.Rows(0).Item("DataEntrega")

				Return locacao

			End With


		Catch ex As Exception
			Throw
		End Try


	End Function

	Public Function ObterSaldoCliente(ByRef con As Connection, cpf As String) As ClienteDTO
		With con
			.Command.Parameters.Clear()
			.Command.Parameters.Add(.InserirParametro(cpf, "@cpf", DbType.String))
			Dim cliente = New ClienteDTO()
			.Command.CommandText = "Select Saldo from tbcliente " +
				"where cpf = @cpf"

			Dim dt = .ExecutaComandoDataTable()
			If dt.Rows.Count > 0 Then
				cliente.Saldo = dt.Rows(0).Item("saldo")
			End If
			Return cliente
		End With

	End Function



#End Region

#Region "Excluir"

	Public Function ExcluirFilmes(ByRef con As Connection, idFilme As UShort)
		Try
			With con
				.Command.Parameters.Add(.InserirParametro(idFilme, "@idFilme", DbType.UInt16))
				.Command.CommandText = "Delete from tbfilmesaluguel where IdFilme = @IdFilme"
				.Command.ExecuteNonQuery()
			End With

			Return True

		Catch ex As Exception
			Throw
		End Try

	End Function

#End Region


#End Region


	Public Function PreencheComboDias(ByRef combo As ComboBox)
		Try
			combo.Items.Clear()
			combo.Items.Add("")
			Dim lista = New List(Of Integer)
			For i As Short = 0 To 30
				lista.Add(i)
			Next
			lista.Sort()
			combo.DataSource = lista
			Return combo
		Catch ex As Exception
			Throw
		End Try

	End Function




End Class
