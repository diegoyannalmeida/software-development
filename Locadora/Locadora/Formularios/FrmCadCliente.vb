Imports Locadora.ClassesGenerica


Public Class FrmCadCliente

	Dim ObjFunctions As Funcoes

	Private Sub FrmCadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ObjFunctions = New Funcoes(Me)
		ObjFunctions.AtribuirEventos(Me)
		Call ConfiguraGridPesquisa()
		Call CarregaGridPesquisa()
		ObjFunctions.PreencheUf(txtComboUf)

	End Sub

	Private Sub SalvarCadastroCliente()
		Try
			objFunctions = New Funcoes()

			If Not ValidaFormulario() Then
				Exit Sub
			End If


			Dim continuar = MsgBox("Tem certeza que deseja salvar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar")
			If MsgBoxResult.Yes Then


				Dim cliente = New ClienteDTO With {
					.Nome = txtNome.Text.Trim.ToString.ToUpper(),
					.Sexo = txtSexo.Text.Trim.ToString.ToUpper(),
					.DataNascimento = CDate(txtDataNascimento.Text.Trim).ToString("yyyy-MM-dd"),
					.Cpf = objFunctions.LimpaFormatacao(txtCadastroCpf.Text.Trim),
					.Rg = txtRg.Text.Trim,
					.Logradouro = txtLogradouro.Text.Trim.ToString.ToUpper(),
					.NrCasa = txtNumero.Text.Trim,
					.Complemento = txtComplemento.Text.Trim.ToString.ToUpper(),
					.Cep = objFunctions.LimpaFormatacao(txtCEP.Text.Trim),
					.Bairro = txtBairro.Text.Trim.ToString.ToUpper(),
					.Cidade = txtCidade.Text.Trim.ToString.ToUpper(),
					.Uf = txtComboUf.Text.Trim.ToString.ToUpper(),
					.Residencial = objFunctions.LimpaFormatacao(txtTelefoneResidencial.Text.Trim),
					.Celular = objFunctions.LimpaFormatacao(txtCelular.Text.Trim),
					.Saldo = txtSaldo.Text.Trim
				}

				Dim con = New Connection()
				Dim clienteAction = New ClienteAction
				con.OpenConnection()
				Dim resultado = clienteAction.SalvarCliente(con, cliente)

				con.CloseConnection()

				If resultado = True Then
					MsgBox("Cliente cadastrado com sucesso", MsgBoxStyle.Information)

					objFunctions.LimpaCampos(Me)
				End If

			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try

	End Sub
	Private Sub ConfiguraGridPesquisa()

		Try
			With grdPesquisarCliente

				.Rows.Clear()
				.Columns.Clear()

				.Columns.Add(New DataGridViewButtonColumn())
				.Columns.Add(New DataGridViewTextBoxColumn())
				.Columns.Add(New DataGridViewTextBoxColumn())
				.Columns.Add(New DataGridViewTextBoxColumn())

				.Columns(0).Name = "Exibir"
				.Columns(1).Name = "IdCliente"
				.Columns(2).Name = "Nome"
				.Columns(3).Name = "Cpf"

				.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
				.AutoResizeColumns()

				.Columns("Exibir").HeaderText = ""
				.Columns("IdCliente").HeaderText = "Cód. Cliente"
				.Columns("Nome").HeaderText = "Nome"
				.Columns("Cpf").HeaderText = "Cpf"

				.Columns("Exibir").Width = 70
				.Columns("IdCliente").Width = 50
				.Columns("Nome").Width = 430
				.Columns("Cpf").Width = 130

				.Columns("Exibir").ReadOnly = True
				.Columns("IdCliente").ReadOnly = True
				.Columns("Nome").ReadOnly = True
				.Columns("Cpf").ReadOnly = True

				.Columns("Exibir").Visible = True
				.Columns("IdCliente").Visible = True
				.Columns("Nome").Visible = True
				.Columns("Cpf").Visible = True

			End With

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try


	End Sub

	Private Sub CarregaGridPesquisa()
		With grdPesquisarCliente
			.Rows.Clear()

		End With

	End Sub

	Private Sub CarregaPesquisaIndividual()
		Try

			If txtCpfPesquisa.Text.Trim <> "" Then
				With grdPesquisarCliente
					Dim con = New Connection()
					con.OpenConnection()

					Dim cpf = txtCpfPesquisa.Text.Trim
					Dim listar = New ClienteAction().ListarIndividualPorCpf(con, cpf)


					.Rows.Clear()
					.Rows.Add()
					.Item("Exibir", 0).Value = "Exibir"
					.Item("IdCliente", 0).Value = listar.IdCliente
					.Item("Nome", 0).Value = listar.Nome
					.Item("Cpf", 0).Value = listar.Cpf

					con.CloseConnection()
				End With
			ElseIf txtCodClientePesquisa.Text.Trim <> "" Then
				With grdPesquisarCliente
					Dim con = New Connection()
					con.OpenConnection()

					Dim idcliente = txtCodClientePesquisa.Text.Trim
					Dim listar = New ClienteAction().ListarIndividualPorId(con, idcliente)
					.Rows.Clear()
					.Rows.Add()
					.Item("Exibir", 0).Value = "Exibir"
					.Item("IdCliente", 0).Value = listar.IdCliente
					.Item("Nome", 0).Value = listar.Nome
					.Item("Cpf", 0).Value = listar.Cpf

					con.CloseConnection()
				End With
			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try

	End Sub
	Private Sub CarregaPesquisarGeral()
    Try
        If txtCodClientePesquisa.Text.Trim = "" AndAlso txtCpfPesquisa.Text.Trim = "" Then
            With grdPesquisarCliente
                .Rows.Clear()

                Dim con = New Connection()
                con.OpenConnection()

                Dim l = New ClienteAction().ListarTodos(con)

                con.CloseConnection()

                If l.Count > 0 Then
                    For i As Short = 0 To l.Count - 1
                        .Rows.Add()

                        Dim cliente = l(i)
                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdCliente", i).Value = If(Not Convert.IsDBNull(cliente.IdCliente), cliente.IdCliente.ToString(), String.Empty)
                        .Item("Nome", i).Value = If(Not Convert.IsDBNull(cliente.Nome), cliente.Nome.ToString(), String.Empty)
                        .Item("Cpf", i).Value = If(Not Convert.IsDBNull(cliente.Cpf), cliente.Cpf.ToString(), String.Empty)
                    Next
                End If
            End With
        End If

    Catch ex As Exception
        MsgBox("Ocorreu um erro ao carregar os dados: " & ex.Message, MsgBoxStyle.Critical)
    End Try
End Sub


	Private Sub ExcluirCadastro()
		Try
			If txtCadastroCpf.Text.Trim = "" Then
				MsgBox("Selecione o cadastro que deseja excluir!", MsgBoxStyle.Exclamation)
				Exit Sub
			End If

			Dim confirmar = MsgBox("Deseja realmente excluir esse cadastro?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)

			If confirmar = MsgBoxResult.Yes Then
				Dim con = New Connection

				con.OpenConnection()

				Dim excluir = New ClienteAction().ExcluirCadastro(con, txtCadastroCpf.Text.Trim)

				con.CloseConnection()

				If excluir = True Then
					MsgBox("Operação realizada com sucesso", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)


					objFunctions.LimpaCampos(Me)
				End If

			End If
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)

		End Try


	End Sub
	Private Function ValidaFormulario() As Boolean
		Try


			If txtNome.Text.Trim = "" Or IsNumeric(txtNome.Text.Trim) Then
				MsgBox("Insira um nome válido!", MsgBoxStyle.Exclamation)
				txtNome.Focus()
				Return False
			End If
			If txtDataNascimento.Text.Trim = "" Then
				MsgBox("Insira a data de nascimento do cliente!", MsgBoxStyle.Exclamation)
				txtDataNascimento.Focus()
				Return False
			End If
			If txtCadastroCpf.Text.Trim = "" Then
				MsgBox("Insira o Cpf do cliente!", MsgBoxStyle.Exclamation)
				txtCadastroCpf.Focus()
				Return False

			End If

			If txtSexo.Text.ToUpper <> "F" And txtSexo.Text.ToUpper <> "M" Then
				MsgBox("Insira o sexo do cliente corretamente! (M ou F)", MsgBoxStyle.Exclamation)
				txtSexo.Focus()
				Return False
			End If
			If IsNumeric(txtSexo.Text.Trim) Then
				MsgBox("Insura um sexo válido!", MsgBoxStyle.Exclamation)
				Return False
			End If
			If txtLogradouro.Text.Trim = "" Or IsNumeric(txtLogradouro.Text) Then
				MsgBox("Insira o endereço do cliente!", MsgBoxStyle.Exclamation)
				txtLogradouro.Focus()
				Return False
			End If
			If txtNumero.Text.Trim = "" Or Not IsNumeric(txtNumero.Text.Trim) Then
				MsgBox("Insira o número da residência do cliente!", MsgBoxStyle.Exclamation)
				txtNumero.Focus()
				Return False
			End If


			If txtBairro.Text.ToUpper = "" Or IsNumeric(txtBairro.Text.Trim) Then
				MsgBox("Insira o bairro!", MsgBoxStyle.Exclamation)
				txtBairro.Focus()
				Return False
			End If
			If txtCidade.Text.Trim = "" Or IsNumeric(txtCidade.Text.Trim) Then
				MsgBox("Insira a cidade de residência do cliente!", MsgBoxStyle.Exclamation)
				txtCidade.Focus()
				Return False
			End If
			If txtCelular.Text.Trim = "" AndAlso txtTelefoneResidencial.Text.Trim = "" Then
				MsgBox("Insira um telefone ou celular para contato!", MsgBoxStyle.Exclamation)
				txtCelular.Focus()
				Return False
			End If

			Return True
		Catch ex As Exception
			Throw
		End Try
	End Function



	Private Sub BtnExcluirCadastroClick(sender As Object, e As EventArgs) Handles btnExcluirCadastro.Click

		ExcluirCadastro()

	End Sub

	Private Sub BtnCadClienteSalvarClick(send As Object, e As EventArgs) Handles btnCadClienteSalvar.Click
		SalvarCadastroCliente()

	End Sub

	Private Sub BtnPesquisarClientes(sender As Object, e As EventArgs) Handles btnPesquisarCliente.Click

		CarregaPesquisaIndividual()
		CarregaPesquisarGeral()

	End Sub


	Private Sub BtnLimparPesquisaClick(sender As Object, e As EventArgs) Handles btnLimparPesquisa.Click

		grdPesquisarCliente.Rows.Clear()
		objFunctions.LimpaCampos(Me)

	End Sub

	Private Sub BtnCancelarCadastroClick(sender As Object, e As EventArgs) Handles btnCadClienteCancelar.Click
		Me.Close()

	End Sub

	Private Sub BtnLimparCadastroClick(sender As Object, e As EventArgs) Handles btnLimparCadastro.Click
		objFunctions.LimpaCampos(Me)
	End Sub

	Private Sub GrdPesquisarClienteCellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdPesquisarCliente.CellClick
		Try
			If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

			With grdPesquisarCliente
				If .Columns(e.ColumnIndex).Name = "Exibir" Then
					Dim con = New Connection
					Dim cpf As String

					cpf = .Item("Cpf", e.RowIndex).Value

					Dim cliente = New ClienteAction().Detalhar(con, cpf)


					txtNome.Text = cliente.Nome
					txtSexo.Text = cliente.Sexo
					txtDataNascimento.Text = cliente.DataNascimento
					txtCadastroCpf.Text = ObjFunctions.FormataCadastro(cliente.Cpf)
					txtRg.Text = cliente.Rg
					txtLogradouro.Text = cliente.Logradouro
					txtNumero.Text = cliente.NrCasa
					txtComplemento.Text = cliente.Complemento
					txtCEP.Text = ObjFunctions.FormataCep(cliente.Cep)
					txtBairro.Text = cliente.Bairro
					txtCidade.Text = cliente.Cidade
					txtComboUf.Text = cliente.Uf
					txtTelefoneResidencial.Text = cliente.Residencial
					txtCelular.Text = ObjFunctions.Formatar(cliente.Celular, Funcoes.TipoFormato.Telefone)
					txtSaldo.Text = cliente.Saldo

					tbpClientes.SelectedTab = tbpCadastroCliente
					ObjFunctions.AtribuirEventos(Me)



				End If
			End With
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try

	End Sub




End Class