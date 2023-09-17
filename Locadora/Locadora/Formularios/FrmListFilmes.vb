Imports Locadora.ClassesGenerica

Public Class FrmListFilmes
	ReadOnly ObjFunction As New Funcoes()

#Region "Código Principal"
	Private Sub FrmListFilmesLoad(sender As Object, e As EventArgs) Handles MyBase.Load
		ConfiguraGridListaFilmes()
		ListarTodosFilmes()
		ObjFunction.AtribuirEventos(Me)

	End Sub
#Region "Configurações da grid"
	Private Sub ConfiguraGridListaFilmes()
		Try
			With grdListaFilmes
				.Rows.Clear()
				.Columns.Clear()

				.Columns.Add(New DataGridViewCheckBoxColumn)
				.Columns.Add(New DataGridViewTextBoxColumn)
				.Columns.Add(New DataGridViewTextBoxColumn)
				.Columns.Add(New DataGridViewTextBoxColumn)
				.Columns.Add(New DataGridViewTextBoxColumn)
				.Columns.Add(New DataGridViewTextBoxColumn)

				.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
				.AutoResizeColumns()


				.Columns(0).Name = "Selecionar"
				.Columns(1).Name = "IdFilme"
				.Columns(2).Name = "TituloFilme"
				.Columns(3).Name = "AnoLancamento"
				.Columns(4).Name = "QtdeMidias"
				.Columns(5).Name = "ValorLocacao"

				.Columns("Selecionar").HeaderText = "Selecionar"
				.Columns("IdFilme").HeaderText = "Cód. do Filme"
				.Columns("TituloFilme").HeaderText = "Título do Filme"
				.Columns("AnoLancamento").HeaderText = "Ano de Lançamento"
				.Columns("QtdeMidias").HeaderText = "Quantidade de mídias"
				.Columns("ValorLocacao").HeaderText = "Valor da locação"

				.Columns("Selecionar").Width = 80
				.Columns("IdFilme").Width = 50
				.Columns("TituloFilme").Width = 300
				.Columns("AnoLancamento").Width = 100
				.Columns("QtdeMidias").Width = 100
				.Columns("ValorLocacao").Width = 100

				.Columns("Selecionar").ReadOnly = False
				.Columns("IdFilme").ReadOnly = True
				.Columns("TituloFilme").ReadOnly = True
				.Columns("AnoLancamento").ReadOnly = True
				.Columns("QtdeMidias").ReadOnly = True
				.Columns("ValorLocacao").ReadOnly = True

				.Columns("Selecionar").Visible = True
				.Columns("IdFilme").Visible = True
				.Columns("TituloFilme").Visible = True
				.Columns("AnoLancamento").Visible = True
				.Columns("QtdeMidias").Visible = True
				.Columns("ValorLocacao").Visible = True
			End With
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try
	End Sub

	Private Sub CarregaGridListarFilmes()
		With grdListaFilmes
			.Rows.Clear()
		End With
	End Sub
#End Region

	Private Sub ListarTodosFilmes()
		Try
			With grdListaFilmes
				.Rows.Clear()
				Dim con = New Connection()
				con.OpenConnection()

				Dim lista = New FilmesAction().ListarTodosFilmes(con)

				con.CloseConnection()

				If lista.Count > 0 Then
					For i As Short = 0 To lista.Count - 1
						.Rows.Add()

						Dim filmes = lista(i)

						.Item("idFilme", i).Value = filmes.IdFilme
						.Item("TituloFilme", i).Value = filmes.TituloFilme
						.Item("AnoLancamento", i).Value = filmes.AnoLancamento
						.Item("QtdeMidias", i).Value = filmes.QtdeMidias
						.Item("ValorLocacao", i).Value = ObjFunction.FormataNumero(filmes.ValorLocacao, 2)
					Next
				End If
			End With
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try
	End Sub

	Private Sub AdicionarFilmesSelecionados()
		Try
			Dim lista = New List(Of FilmesDTO)
			With grdListaFilmes
				Dim con = New Connection()
				Dim idfilme As Short
				Dim filmeLocado = New LocacaoAction()
				con.OpenConnection()
				For i As Short = 0 To grdListaFilmes.Rows.Count - 1
					idfilme = .Item("idFilme", i).Value
					Dim filme = New FilmesAction().ListarIndividualPorId(con, idfilme)
					If .Item("Selecionar", i).Value Then
						lista.Add(filme)
					End If
				Next
				filmeLocado.SalvarFilmeReservado(con, lista)

				con.CloseConnection()
			End With

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try

	End Sub
#End Region


#Region "Botoes"
	Private Sub BtnCancelarClick(sender As Object, e As EventArgs) Handles btnCancelar.Click
		Close()

	End Sub

	Private Sub BtnAdicionarFilmeClick(sender As Object, e As EventArgs) Handles btnAdicionarFilme.Click

		Try
			AdicionarFilmesSelecionados()
			Dim frmCadLocacoes = New FrmCadLocacoes
			Dim objFunctions As New Funcoes()
			Dim con = New Connection()
			Dim listaFilmesAction = New ListaFilmesAction
			Dim objForm As Form

			For Each objForm In MdiLocadora.MdiChildren
				If objForm.Name.ToUpper = "FRMCADLOCACOES" Then
					objForm.Close()
				End If
			Next
			'

			frmCadLocacoes.MdiParent = MdiLocadora
			frmCadLocacoes.Show()
			frmCadLocacoes.Focus()
			frmCadLocacoes.tbpLocacoes.SelectedTab = frmCadLocacoes.tbpAluguel

			Close()

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try

	End Sub

	Private Sub TxtNomeFilmeConsultaTextChanged(sender As Object, e As EventArgs) Handles txtNomeFilmeConsulta.TextChanged
		With grdListaFilmes
			If txtNomeFilmeConsulta.Text.Trim <> "" Then
				Dim con = New Connection()
				Dim nomeFilme = txtNomeFilmeConsulta.Text.Trim
				Dim lista = New FilmesAction().ListarTodosFilmesPorNome(con, txtNomeFilmeConsulta.Text)
				Dim filme = New FilmesDTO
				.Rows.Clear()

				For i As Short = 0 To lista.Count - 1

					.Rows.Add()
					filme = lista(i)

					.Item("idFilme", i).Value = filme.IdFilme
					.Item("TituloFilme", i).Value = filme.TituloFilme
					.Item("AnoLancamento", i).Value = filme.AnoLancamento
					.Item("QtdeMidias", i).Value = filme.QtdeMidias
					.Item("ValorLocacao", i).Value = filme.ValorLocacao
				Next

			End If


		End With

	End Sub


#End Region


End Class