Imports Locadora.ClassesGenerica

Public Class MidiaAction


	Public Function SalvarMidia(ByRef con As Connection, midia As MidiasDTO)

		Dim sql As String

		Try

			con.Command.Parameters.Add(con.InserirParametro(midia.IdMidia, "@IdMidia", DbType.UInt16))
			con.Command.Parameters.Add(con.InserirParametro(midia.TipoMidia, "@TipoMidia", DbType.String))

			If midia.IdMidia > 0 Then
				sql = "Update TbMidia Set TipoMidia = @TipoMidia Where IdMidia = @IdMidia"

			Else
				sql = "Insert Into TbMidia (TipoMidia) Values (@TipoMidia)"
			End If
			con.Command.CommandText = sql
			con.Command.ExecuteNonQuery()
			Return True

		Catch ex As Exception
			Throw
		End Try


	End Function


	Public Function ListarMidias(ByRef con As Connection) As List(Of MidiasDTO)
		Try
			Dim lista = New List(Of MidiasDTO)

			con.Command.CommandText = "Select IdMidia, TipoMidia From TbMidia Order By TipoMidia"
			Dim dt = con.ExecutaComandoDataTable()

			If dt.Rows.Count > 0 Then
				For i As Short = 0 To dt.Rows.Count - 1
					'
					Dim midia = New MidiasDTO With {
						.IdMidia = Val(dt.Rows(i).Item("IdMidia")),
						.TipoMidia = dt.Rows(i).Item("TipoMidia")
					}

					lista.Add(midia)

				Next
			End If
			Return lista

		Catch ex As Exception
			Throw
		End Try
	End Function

	Public Function ListarIndividualPorTipo(ByRef con As Connection, ByVal TipoMidia As String) As MidiasDTO

		Try
			Dim midia = New MidiasDTO
			con.Command.Parameters.Add(con.InserirParametro(TipoMidia, "@TipoMidia", DbType.String))

			con.Command.CommandText = "Select IdMidia, TipoMidia From TbMidia Where " +
				"(TipoMidia Like '%' @TipoMidia '%')"

			Dim dt = con.ExecutaComandoDataTable()

			If dt.Rows.Count > 0 Then
				midia.IdMidia = dt.Rows(0).Item("IdMidia")
				midia.TipoMidia = dt.Rows(0).Item("TipoMidia")
			End If

			Return midia


		Catch ex As Exception
			Throw
		End Try

	End Function

	Public Function ListarIndividualPorId(ByRef con As Connection, ByVal idMidia As UInt16) As MidiasDTO
		Try
			Dim midia = New MidiasDTO
			con.Command.Parameters.Add(con.InserirParametro(idMidia, "@IdMidia", DbType.UInt16))
			con.Command.CommandText = "Select IdMidia, TipoMidia From TbMidia Where " +
				"IdMidia = @IdMidia"

			Dim dt = con.ExecutaComandoDataTable()

			If dt.Rows.Count > 0 Then
				midia.IdMidia = dt.Rows(0).Item("IdMidia")
				midia.TipoMidia = dt.Rows(0).Item("TipoMidia")
			End If

			Return midia

		Catch ex As Exception
			Throw
		End Try


	End Function

	Public Function ExcluirMidia(ByRef con As Connection, idMidia As UInt16)
		Try
			con.Command.Parameters.Add(con.InserirParametro(idMidia, "@IdMidia", DbType.UInt16))
			con.Command.CommandText = "Delete From TbMidia Where IdMidia = @IdMidia"
			con.Command.ExecuteNonQuery()
			Return True

		Catch ex As Exception
			Throw
		End Try

	End Function

	Public Sub PreencherCombo(ByRef con As Connection, ByRef combo As ComboBox)
		Try
			Dim listaMidias = ListarMidias(con)
			listaMidias.Insert(0, New MidiasDTO())


			With combo
				.DataSource = listaMidias
				.ValueMember = "idMidia"
				.DisplayMember = "tipoMidia"
			End With

		Catch ex As Exception
			Throw
		End Try

	End Sub

End Class
