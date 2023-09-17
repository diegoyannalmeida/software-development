Imports Locadora.ClassesGenerica

Public Class FrmCadMidia
	Dim objFunctions As Funcoes

	Private Sub FrmCadMidiaLoad(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim con As New Connection()
		objFunctions = New Funcoes(Me)
		objFunctions.AtribuirEventos(Me)
		ConfiguraGridPesquisa()

	End Sub

	Private Sub SalvarNovoTipoDeMidia()
		Try
			objFunctions = New Funcoes()

			Dim continuar = MsgBox("Tem certeza que deseja cadastrar esse tipo de mídea?", MsgBoxStyle.YesNo)

			If MsgBoxResult.Yes Then
				Dim midia = New MidiasDTO With {
					.TipoMidia = txtTipoDeMidia.Text.Trim
				}

				Dim con = New Connection()
				Dim midiaAction = New MidiaAction
				con.OpenConnection()
				Dim resultado = midiaAction.SalvarMidia(con, midia)
				con.CloseConnection()

				If resultado = True Then
					MsgBox("Tipo de mídia cadastrado com sucesso!", MsgBoxStyle.Information)
					objFunctions.LimpaCampos(Me)
				End If

			End If


		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try
	End Sub

	Private Sub ConfiguraGridPesquisa()
		Try
			With grdConsultaMidia
				.Rows.Clear()
				.Columns.Clear()

				.Columns.Add(New DataGridViewButtonColumn())
				.Columns.Add(New DataGridViewTextBoxColumn())
				.Columns.Add(New DataGridViewTextBoxColumn())

				.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
				.AutoResizeColumns()

				.Columns(0).Name = "Exibir"
				.Columns(1).Name = "IdMidia"
				.Columns(2).Name = "TipoMidia"

				.Columns("Exibir").HeaderText = "Exibir"
				.Columns("IdMidia").HeaderText = "Cód. Mídia"
				.Columns("TipoMidia").HeaderText = "Tipo De Mídia"

				.Columns("Exibir").Width = 70
				.Columns("IdMidia").Width = 50
				.Columns("TipoMidia").Width = 300

				.Columns("Exibir").ReadOnly = True
				.Columns("IdMidia").ReadOnly = True
				.Columns("TipoMidia").ReadOnly = True

				.Columns("Exibir").Visible = True
				.Columns("IdMidia").Visible = True
				.Columns("TipoMidia").Visible = True

			End With
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try
	End Sub

	Private Sub CarregarPesquisarTodos()
		Try
			If txtConsultaTipoDeMidia.Text.Trim = "" Then
				With grdConsultaMidia
					.Rows.Clear()
					Dim con = New Connection()
					con.OpenConnection()
					Dim l = New MidiaAction().ListarMidias(con)
					con.CloseConnection()
					If l.Count > 0 Then
						For i As Short = 0 To l.Count - 1
							.Rows.Add()
							Dim midia = l(i)
							.Item("Exibir", i).Value = "Exibir"
							.Item("IdMidia", i).Value = midia.IdMidia
							.Item("TipoMidia", i).Value = midia.TipoMidia

						Next
					End If
				End With
			End If
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try
	End Sub

	Private Sub CarregaPesquisaIndividual()
		Try
			If txtConsultaTipoDeMidia.Text.Trim <> "" Then
				With grdConsultaMidia
					Dim con = New Connection()
					con.OpenConnection()
					Dim TipoMidia = txtConsultaTipoDeMidia.Text.Trim
					Dim listar = New MidiaAction().ListarIndividualPorTipo(con, txtConsultaTipoDeMidia.Text)
					.Rows.Clear()
					.Rows.Add()
					.Item("Exibir", 0).Value = "Exibir"
					.Item("IdMidia", 0).Value = listar.IdMidia
					.Item("TipoMidia", 0).Value = listar.TipoMidia
					con.CloseConnection()

				End With
			End If

		Catch ex As Exception
			Throw
		End Try

	End Sub

	Private Sub CarregaGridPesquisa()
		With grdConsultaMidia
			.Rows.Clear()
		End With
	End Sub

	Private Sub ExibirCadastroMidia()
		Try
			If txtConsultaTipoDeMidia.Text.Trim = "" Then
				MsgBox("Insira um dado válido para consulta", MsgBoxStyle.Exclamation)
				Exit Sub
			End If

			With grdConsultaMidia
				CarregaPesquisaIndividual()
				Dim con = New Connection
				Dim idMidia As UShort
				idMidia = .Item(0, 0).Value
				Dim midia = New MidiaAction().ListarIndividualPorId(con, idMidia)
				txtTipoDeMidia.Text = midia.TipoMidia
			End With

		Catch ex As Exception
			MsgBox(ex.Message(MsgBoxStyle.Critical))
		End Try
	End Sub

	Private Sub ExcluirCadastro()
		Try
			If txtIdMidia.Text = "" Then
				MsgBox("Selecione o tipo de mídia que deseja excluir!", MsgBoxStyle.Exclamation)
				Exit Sub
			End If
			Dim confirmar = MsgBox("Deseja realmente excluir esse cadastro?", MsgBoxStyle.YesNo)

			If confirmar = MsgBoxResult.Yes Then
				Dim con = New Connection
				con.OpenConnection()

				Dim excluir = New MidiaAction().ExcluirMidia(con, txtIdMidia.Text)

				con.CloseConnection()

				If excluir = True Then
					MsgBox("Tipo de mídia excluido com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
					objFunctions.LimpaCampos(Me)
				End If
			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try

	End Sub

	Private Sub BtnSalvarMidia_Click(sender As Object, e As EventArgs) Handles btnSalvarMidia.Click
		SalvarNovoTipoDeMidia()
	End Sub

	Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		Me.Close()
	End Sub

	Private Sub BtnLimparCadastro_Click(sender As Object, e As EventArgs) Handles btnLimparCadastro.Click
		objFunctions.LimpaCampos(Me)
	End Sub

	Private Sub BtnExcluirMidia_Click(sender As Object, e As EventArgs) Handles btnExcluirMidia.Click
		ExcluirCadastro()
	End Sub

	Private Sub BtnConsultarFilme_Click(sender As Object, e As EventArgs) Handles btnConsultarFilme.Click
		CarregarPesquisarTodos()
		CarregaPesquisaIndividual()

	End Sub

	Private Sub BtnLimparCosulta_Click(sender As Object, e As EventArgs) Handles btnLimparCosulta.Click
		objFunctions.LimpaCampos(Me)
	End Sub

	Private Sub GrdConsultaMidia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdConsultaMidia.CellClick
		Try
			If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

			With grdConsultaMidia
				If .Columns(e.ColumnIndex).Name = "Exibir" Then

					Dim con = New Connection
					Dim idMidia As UShort

					idMidia = .Item("IdMidia", e.RowIndex).Value

					Dim midia = New MidiaAction().ListarIndividualPorId(con, idMidia)
					txtIdMidia.Text = midia.IdMidia
					txtTipoDeMidia.Text = midia.TipoMidia
					tbpCadMidia.SelectedTab = tbpCadastroMidia
				End If
			End With
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try

	End Sub
End Class