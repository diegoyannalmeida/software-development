Imports Locadora.ClassesGenerica

Public Class ListaClientesAction

	Public Function SalvarClienteAluguel(con As Connection, cliente As ClienteDTO)
		Try

			con.Command.Parameters.Clear()

			con.Command.Parameters.Add(con.InserirParametro(cliente.IdCliente, "@idCliente", DbType.String))
			con.Command.Parameters.Add(con.InserirParametro(cliente.Nome, "@nome", DbType.String))
			con.Command.Parameters.Add(con.InserirParametro(cliente.Cpf, "@cpf", DbType.String))


			con.Command.CommandText = "Select IdCliente, Nome, Cpf from tbClienteAluguel"

			Dim sql = "Insert into tbClienteAluguel (IdCliente, Nome, Cpf) " +
				"Values (@idCliente, @nome, @cpf)"

			Dim dt = con.ExecutaComandoDataTable()

			If dt.Rows.Count > 0 Then

				con.Command.CommandText = "Delete from tbclientealuguel"
				con.Command.ExecuteNonQuery()

				con.Command.CommandText = sql
				con.Command.ExecuteNonQuery()
			Else

				con.Command.CommandText = sql
				con.Command.ExecuteNonQuery()

			End If
			Return cliente

		Catch ex As Exception
			Throw
		End Try

	End Function
	Public Function ListarTodosClientes(ByRef con As Connection, cpf As ClienteDTO) As List(Of ClienteDTO)
		Try
			Dim resultado = New List(Of ClienteDTO)
			con.Command.Parameters.Add(con.InserirParametro(cpf, "@Cpf", DbType.String))
			con.Command.CommandText = "Select IdCliente, Nome, Cpf from TbCliente where Cpf = @Cpf Order By Nome"
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

	Public Function ListarClientesSalvos(ByRef con As Connection) As ClienteDTO
		Try
			con.Command.CommandText = "Select Idcliente, Nome, Cpf from tbClienteAluguel"
			con.Command.ExecuteNonQuery()
			Dim cliente = New ClienteDTO
			Dim dt = con.ExecutaComandoDataTable()

			If dt.Rows.Count > 0 Then
				With cliente
					.IdCliente = dt.Rows(0).Item("IdCliente")
					.Nome = dt.Rows(0).Item("Nome")
					.Cpf = dt.Rows(0).Item("CPF")

				End With
			End If

			Return cliente
		Catch ex As Exception
			Throw
		End Try

	End Function

	Public Function ExcluirClientesAluguel(ByRef con As Connection)
		Try
			con.Command.CommandText = "Delete from tbclientealuguel"

			con.Command.ExecuteNonQuery()

			Return True

		Catch ex As Exception
			Throw
		End Try
	End Function

End Class
