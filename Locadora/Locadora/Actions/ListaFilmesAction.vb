Imports Locadora.ClassesGenerica

Public Class ListaFilmesAction

	Public Function ListarTodosFilmes(ByRef con As Connection) As List(Of FilmesDTO)

		Try
			Dim resultado = New List(Of FilmesDTO)
			con.Command.CommandText = "Select IdFilme, TituloFilme, AnoLancamento, QtdeMidias, " +
				"ValorLocacao From TbFilmesAluguel order by TituloFilme"

			Dim dt = con.ExecutaComandoDataTable()

			If dt.Rows.Count > 0 Then
				For i As Short = 0 To dt.Rows.Count - 1
					Dim filmes = New FilmesDTO With {
						.IdFilme = dt.Rows(i).Item("IdFilme"),
						.TituloFilme = dt.Rows(i).Item("TituloFilme"),
						.AnoLancamento = dt.Rows(i).Item("AnoLancamento"),
						.QtdeMidias = dt.Rows(i).Item("QtdeMidias"),
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

#Region "Aluguel"
	Public Function ListarFilmesSelecionados(ByRef con As Connection, idFilme As UShort) As List(Of FilmesDTO)
		Try
			Dim resultado = New List(Of FilmesDTO)
			con.Command.Parameters.Add(con.InserirParametro(idFilme, "@IdFilme", DbType.UInt16))
			con.Command.CommandText = "Select idFilme, TituloFilme, AnoLancamento, QtdeMidias, ValorLocacao From " +
				"where IdFilme = @IdFilme TbFilmes Order By TituloFilme"
			Dim dt = con.ExecutaComandoDataTable()
			If dt.Rows.Count > 0 Then
				For i As Short = 0 To dt.Rows.Count - 1
					Dim filmes = New FilmesDTO With {
						.IdFilme = dt.Rows(i).Item("IdFilme"),
						.TituloFilme = dt.Rows(i).Item("TituloFilme"),
						.AnoLancamento = dt.Rows(i).Item("AnoLancamento"),
						.QtdeMidias = dt.Rows(i).Item("QtdeMidias"),
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


#End Region

#Region "Excluir"

	Public Function ExcluirFilmesPorId(ByRef con As Connection, idFilme As UInt16)
		Try
			con.Command.Parameters.Add(con.InserirParametro(idFilme, "@idFilme", DbType.UInt16))

			con.Command.CommandText = "Delete from TbFilmesAluguel where IdFilme = @idFilme"

			con.Command.ExecuteNonQuery()

			Return True

		Catch ex As Exception
			Throw
		End Try


	End Function

	Public Function ExcluirFilmesAluguel(ByRef con As Connection)
		Try
			con.Command.CommandText = "Delete from TbFilmesAluguel"
			con.Command.ExecuteNonQuery()
			Return True

		Catch ex As Exception
			Throw
		End Try

	End Function

#End Region


End Class
