Imports Locadora.ClassesGenerica

Public Class FrmListClientes
	Private Sub FrmListClientesLoad(sender As Object, e As EventArgs) Handles MyBase.Load
		ConfiguraGridListaClientes()
		ListarTodosClientes()
	End Sub
#Region "Configurações da grid"
	Private Sub ConfiguraGridListaClientes()
		Try
			With grdListaClientes
				.Rows.Clear()
				.Columns.Clear()

				.Columns.Add(New DataGridViewButtonColumn())
				.Columns.Add(New DataGridViewTextBoxColumn())
				.Columns.Add(New DataGridViewTextBoxColumn())
				.Columns.Add(New DataGridViewTextBoxColumn())

				.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
				.AutoResizeColumns()

				.Columns(0).Name = "Selecionar"
				.Columns(1).Name = "IdCliente"
				.Columns(2).Name = "Nome"
				.Columns(3).Name = "Cpf"

				.Columns("Selecionar").HeaderText = ""
				.Columns("IdCliente").HeaderText = "Cód. Cliente"
				.Columns("Nome").HeaderText = "Nome"
				.Columns("Cpf").HeaderText = "CPF"

				.Columns("Selecionar").Width = 80
				.Columns("IdCliente").Width = 50
				.Columns("Nome").Width = 430
				.Columns("Cpf").Width = 130

				.Columns("Selecionar").ReadOnly = True
				.Columns("IdCliente").ReadOnly = True
				.Columns("Nome").ReadOnly = True
				.Columns("Cpf").ReadOnly = True

				.Columns("Selecionar").Visible = True
				.Columns("IdCliente").Visible = True
				.Columns("Nome").Visible = True
				.Columns("Cpf").Visible = True
			End With

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try
	End Sub

	Private Sub CarregaGridListarClientes()
		With grdListaClientes
			.Rows.Clear()
		End With
	End Sub

#End Region


	Private Sub ListarTodosClientes()
		Try
			With grdListaClientes
				.Rows.Clear()

				Dim con = New Connection()
				con.OpenConnection()

				Dim lista = New ClienteAction().ListarTodos(con)
				con.CloseConnection()

				If lista.Count > 0 Then
					For i As Short = 0 To lista.Count - 1
						.Rows.Add()

						Dim cliente = lista(i)
						.Item("Selecionar", i).Value = "Selecionar"
						.Item("IdCliente", i).Value = cliente.IdCliente
						.Item("Nome", i).Value = cliente.Nome
						.Item("Cpf", i).Value = cliente.Cpf

					Next
				End If
				FrmCadLocacoes.Hide()
			End With

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)

		End Try

	End Sub


	Private Sub BtnCancelarClick(sender As Object, e As EventArgs) Handles btnCancelar.Click
		Close()
	End Sub




	Private Sub GrdListaClientesAdicionarClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdListaClientes.CellClick
		Try
			If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

			With grdListaClientes
				If .Columns(e.ColumnIndex).Name = "Selecionar" Then
					Dim con = New Connection
					Dim form As FrmCadLocacoes
					Dim cpf As String
					Dim ObjForm As New Form()

					cpf = .Item("Cpf", e.RowIndex).Value
					con.OpenConnection()
					Dim cliente = New ClienteAction().Detalhar(con, cpf)
					Dim salvarCliente = New ListaClientesAction().SalvarClienteAluguel(con, cliente)

					con.CloseConnection()

					For Each ObjForm In MdiLocadora.MdiChildren
						If ObjForm.Name.ToUpper = "FRMCADLOCACOES" Then

							form = ObjForm

							form.txtNomeClienteLocacao.Text = salvarCliente.Nome
							form.txtCpfClienteLocacao.Text = salvarCliente.Cpf
							form.txtCodClienteLocacao.Text = salvarCliente.IdCliente
							form.tbpLocacoes.SelectedTab = form.tbpAluguel

							Exit For
						End If
					Next

					Close()


				End If
			End With

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try

	End Sub

	Private Sub TxtCpfConsultaTextChanged(sender As Object, e As EventArgs) Handles txtCpfConsulta.TextChanged

		Try
			With grdListaClientes
				If txtCpfConsulta.Text.Trim <> "" Then
					Dim con = New Connection()
					Dim cpf = txtCpfConsulta.Text.Trim
					Dim lista = New ClienteAction().ListarTodosPorCPF(con, cpf)
					Dim cliente = New ClienteDTO
					.Rows.Clear()

					For i As Short = 0 To lista.Count - 1

						.Rows.Add()
						cliente = lista(i)
						.Item("Selecionar", i).Value = "Selecionar"
						.Item("IdCliente", i).Value = cliente.IdCliente
						.Item("Nome", i).Value = cliente.Nome
						.Item("Cpf", i).Value = cliente.Cpf
					Next
				End If
			End With
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try


	End Sub
End Class