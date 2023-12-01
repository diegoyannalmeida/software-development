Imports Locadora.ClassesGenerica


Public Class FrmCadFilmes

    Dim ObjFunctions As Funcoes

    Private Sub FrmCadFilmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New Connection()
        ObjFunctions = New Funcoes(Me)
        ObjFunctions.AtribuirEventos(Me)
        Dim generoAction As New GeneroAction()
        Dim midiaAction As New MidiaAction()
        ConfiguraGridPesquisa()
        ConfiguraGridEstoque()

        midiaAction.PreencherCombo(con, cmbTipoDeMidia)

        generoAction.PreencheCombo(con, cmbGenero)
        generoAction.PreencheCombo(con, cmbPesquisaGenero)


    End Sub
    Private Sub ConfiguraGridPesquisa()

        Try

            With grdPesquisaFilmes
                .Rows.Clear()
                .Columns.Clear()

                .Columns.Add(New DataGridViewButtonColumn())
                .Columns.Add(New DataGridViewButtonColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()

                .Columns(0).Name = "Exibir"
                .Columns(1).Name = "Estoque"
                .Columns(2).Name = "IdFilme"
                .Columns(3).Name = "TituloFilme"
                .Columns(4).Name = "Genero"
                .Columns(5).Name = "AnoLancamento"

                .Columns("Exibir").HeaderText = ""
                .Columns("Estoque").HeaderText = ""
                .Columns("IdFilme").HeaderText = "Cód. Filme"
                .Columns("TituloFilme").HeaderText = "Título do Filme"
                .Columns("Genero").HeaderText = "Gênero"
                .Columns("AnoLancamento").HeaderText = "Ano de Lançamento"

                .Columns("Exibir").Width = 70
                .Columns("Estoque").Width = 70
                .Columns("IdFilme").Width = 50
                .Columns("TituloFilme").Width = 350
                .Columns("Genero").Width = 100
                .Columns("AnoLancamento").Width = 100

                .Columns("Exibir").ReadOnly = True
                .Columns("Estoque").ReadOnly = True
                .Columns("IdFilme").ReadOnly = True
                .Columns("TituloFilme").ReadOnly = True
                .Columns("Genero").ReadOnly = True
                .Columns("AnoLancamento").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("Estoque").Visible = True
                .Columns("IdFilme").Visible = True
                .Columns("TituloFilme").Visible = True
                .Columns("Genero").Visible = True
                .Columns("AnoLancamento").Visible = True

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub
    Private Sub CarregaGridPesquisa()
        With grdPesquisaFilmes
            .Rows.Clear()
        End With

    End Sub

    Private Sub ConfiguraGridEstoque()
        Try
            With grdEstoque

                .Rows.Clear()
                .Columns.Clear()

                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()


                .Columns(0).Name = "IdFilme"
                .Columns(1).Name = "TituloFilme"
                .Columns(2).Name = "Genero"
                .Columns(3).Name = "AnoLancamento"

                .Columns("IdFilme").HeaderText = "Cód. Filme"
                .Columns("TituloFilme").HeaderText = "Título do Filme"
                .Columns("Genero").HeaderText = "Gênero"
                .Columns("AnoLancamento").HeaderText = "Ano de Lançamento"

                .Columns("IdFilme").Width = 50
                .Columns("TituloFilme").Width = 350
                .Columns("Genero").Width = 100
                .Columns("AnoLancamento").Width = 100

                .Columns("IdFilme").ReadOnly = True
                .Columns("TituloFilme").ReadOnly = True
                .Columns("Genero").ReadOnly = True
                .Columns("AnoLancamento").ReadOnly = True

                .Columns("IdFilme").Visible = True
                .Columns("TituloFilme").Visible = True
                .Columns("Genero").Visible = True
                .Columns("AnoLancamento").Visible = True

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub SalvarCadastroFilmes()
        Try

            ObjFunctions = New Funcoes()

            If Not ValidaFormulario() Then
                Exit Sub
            End If

            Dim continuar = MsgBox("Tem certeza que deseja salvar esse filme?", MsgBoxStyle.YesNo)

            If MsgBoxResult.Yes Then

                Dim filmes = New FilmesDTO With {
                    .TituloFilme = txtTituloFilme.Text.Trim.ToString.ToUpper(),
                    .Genero = cmbGenero.Text.Trim.ToString.ToUpper(),
                    .AnoLancamento = txtAnoLancamento.Text.Trim,
                    .Duracao = txtDuracao.Text.Trim,
                    .QtdeMidias = txtQtdeMidias.Text.Trim,
                    .TipoMidia = cmbTipoDeMidia.Text.Trim.ToString(),
                    .ValorLocacao = txtValorlocacao.Text.Trim,
                    .QtdeEstoque = If(String.IsNullOrEmpty(txtQtdeEstoqueInicial.Text.Trim()), txtQtdeEstoqueCadastro.Text.Trim(), txtQtdeEstoqueInicial.Text.Trim())
                }
                If txtIdFilme.Text <> "" Then
                    filmes.IdFilme = Val(txtIdFilme.Text.Trim)
                End If

                Dim con = New Connection()
                Dim filmesAction = New FilmesAction
                con.OpenConnection()
                Dim resultado = filmesAction.SalvarFilme(con, filmes)


                con.CloseConnection()

                If resultado = True Then

                    MsgBox("Filme cadastrado com sucesso!", MsgBoxStyle.Information)
                    ObjFunctions.LimpaCampos(Me)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub AdicionaFilmeEstoque()
        Try
            With grdEstoque
                Dim con = New Connection
                Dim idFilme = .Item("IdFilme", 0).Value
                Dim quantidade = txtAtualizaQuantidadeEstoque.Text
                con.OpenConnection()

                Dim estoqueAtual = New FilmesAction().AdicionaFilmeEstoque(con, idFilme, quantidade)
                con.CloseConnection()
                txtEstoqueAtual.Text = estoqueAtual
                ObjFunctions.LimpaCampos(txtAtualizaQuantidadeEstoque)
                MsgBox("Estoque atualizado com sucesso!", MsgBoxStyle.Information)
            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub RemoveFilmeEstoque()
        Try
            With grdEstoque
                Dim con = New Connection
                Dim idFilme = .Item("IdFilme", 0).Value
                Dim quantidade = txtAtualizaQuantidadeEstoque.Text
                con.OpenConnection()

                Dim estoqueAtual = New FilmesAction().RemoveFilmeEstoque(con, idFilme, quantidade)
                con.CloseConnection()
                txtEstoqueAtual.Text = estoqueAtual
                ObjFunctions.LimpaCampos(txtAtualizaQuantidadeEstoque)
                MsgBox("Estoque atualizado com sucesso!", MsgBoxStyle.Information)
            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CarregarPesquisarTodos()
        Try
            If txtPesquisaId.Text.Trim = "" AndAlso txtPesquisaNome.Text.Trim = "" Then

                With grdPesquisaFilmes
                    .Rows.Clear()
                    Dim con = New Connection()
                    con.OpenConnection()
                    Dim l = New FilmesAction().ListarTodosFilmes(con)
                    con.CloseConnection()
                    If l.Count > 0 Then
                        For i As Short = 0 To l.Count - 1

                            .Rows.Add()

                            Dim filme = l(i)
                            .Item("Exibir", i).Value = "Exibir"
                            .Item("Estoque", i).Value = "Estoque"
                            .Item("IdFilme", i).Value = filme.IdFilme
                            .Item("TituloFilme", i).Value = filme.TituloFilme
                            .Item("Genero", i).Value = filme.Genero
                            .Item("AnoLancamento", i).Value = filme.AnoLancamento

                        Next
                    End If
                End With

            ElseIf cmbPesquisaGenero.Text.Trim <> "" AndAlso txtPesquisaId.Text.Trim = "" Then
                With grdPesquisaFilmes
                    .Rows.Clear()
                    Dim con = New Connection()
                    con.OpenConnection()
                    Dim l = New FilmesAction().ListaraPorGenero(con, cmbPesquisaGenero.Text)
                    con.CloseConnection()

                    If l.Count > 0 Then
                        For i As Short = 0 To l.Count - 1
                            .Rows.Add()
                            Dim filme = l(i)
                            .Item("Exibir", i).Value = "Exibir"
                            .Item("Estoque", i).Value = "Estoque"
                            .Item("IdFilme", i).Value = filme.IdFilme
                            .Item("TituloFilme", i).Value = filme.TituloFilme
                            .Item("Genero", i).Value = filme.Genero
                            .Item("AnoLancamento", i).Value = filme.AnoLancamento
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

            With grdPesquisaFilmes
                Dim con = New Connection()
                con.OpenConnection()
                Dim listar As New FilmesDTO

                Dim nome = txtPesquisaNome.Text.Trim
                If txtPesquisaNome.Text.Trim <> "" Then
                    listar = New FilmesAction().ListarIndividualPorTitulo(con, txtPesquisaNome.Text)
                ElseIf txtPesquisaId.Text.Trim <> "" Then
                    listar = New FilmesAction().ListarIndividualPorId(con, txtPesquisaId.Text)
                End If

                .Rows.Clear()
                .Rows.Add()
                .Item("Exibir", 0).Value = "Exibir"
                .Item("Estoque", 0).Value = "Estoque"
                .Item("IdFilme", 0).Value = listar.IdFilme
                .Item("TituloFilme", 0).Value = listar.TituloFilme
                .Item("Genero", 0).Value = listar.Genero
                .Item("AnoLancamento", 0).Value = listar.AnoLancamento

                con.CloseConnection()

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub ExibirCadastroFilme()
        Try
            If txtPesquisaNome.Text.Trim = "" AndAlso txtPesquisaId.Text.Trim = "" Then
                MsgBox("Insira um dado válido para Pesquisa!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            With grdPesquisaFilmes
                CarregaPesquisaIndividual()
                Dim con = New Connection
                Dim idFilme As UShort
                idFilme = .Item(0, 0).Value
                Dim filme = New FilmesAction().ListarIndividualPorId(con, idFilme)
                txtIdFilme.Text = filme.IdFilme
                txtTituloFilme.Text = filme.TituloFilme
                cmbGenero.Text = filme.Genero
                txtAnoLancamento.Text = filme.AnoLancamento
                txtDuracao.Text = filme.Duracao
                cmbTipoDeMidia.Text = filme.TipoMidia
                txtQtdeMidias.Text = filme.QtdeMidias
                txtQtdeEstoqueCadastro.Text = filme.QtdeEstoque
                tbpFilmes.SelectedTab = tbpCadastroFilmes
            End With

        Catch ex As Exception
            MsgBox(ex.Message(MsgBoxStyle.Critical))
        End Try
    End Sub

    Private Sub ExcluirCadastro()
        Try
            If txtIdFilme.Text = "" Then
                MsgBox("Selecione o cadastro que deseja excluir!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim confirmar = MsgBox("Deseja realmente excluir esse cadastro? ", MsgBoxStyle.YesNo)

            If confirmar = MsgBoxResult.Yes Then
                Dim con = New Connection
                con.OpenConnection()

                Dim excluir = New FilmesAction().ExcluirCadastro(con, txtIdFilme.Text)

                con.CloseConnection()


                If excluir = True Then
                    MsgBox("Filme Excluido com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                    ObjFunctions.LimpaCampos(Me)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnSalvarClick(sender As Object, e As EventArgs) Handles btnSalvar.Click
        SalvarCadastroFilmes()
    End Sub

    Private Sub BtnCancelarClick(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function ValidaFormulario() As Boolean
        If txtTituloFilme.Text.Trim = "" Then
            MsgBox("Preencha o nome do filme", MsgBoxStyle.Exclamation)
            Return False
        End If
        If cmbGenero.Text = "" Then
            MsgBox("Selecione o gênero!", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtAnoLancamento.Text = "" Then
            MsgBox("Preencha o ano de lançamento! ")
            Return False
        End If
        If txtQtdeMidias.Text = "" Then
            MsgBox("Prencha a quantdade de mídias!", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtDuracao.Text = "" Then
            MsgBox("Preencha a duração!", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtQtdeMidias.Text = "" Then
            MsgBox("Preencha a quantidade de mídias!", MsgBoxStyle.Exclamation)
            Return False
        End If
        If txtValorlocacao.Text = "" Then
            MsgBox("Preencha o valor da locação! ", MsgBoxStyle.Exclamation)
            Return False
        End If

        Return True
    End Function

    Private Sub BtnPesquisarFilmeClick(sender As Object, e As EventArgs) Handles btnPesquisarFilme.Click
        CarregaPesquisaIndividual()
        CarregarPesquisarTodos()

    End Sub


    Private Sub BtnExcluirCadastro_Click(sender As Object, e As EventArgs) Handles btnExcluirCadastro.Click
        ExcluirCadastro()
    End Sub

    Private Sub BtnLimparTelaCadastro_Click(sender As Object, e As EventArgs) Handles btnLimparTelaCadastro.Click
        ObjFunctions.LimpaCampos(Me)

    End Sub

    Private Sub BtnExibirCadastro_Click(sender As Object, e As EventArgs)
        ExibirCadastroFilme()
    End Sub

    Private Sub BtnLimparCosulta_Click(sender As Object, e As EventArgs) Handles btnLimparCosulta.Click
        ObjFunctions.LimpaCampos(Me)
        grdPesquisaFilmes.Rows.Clear()
    End Sub

    Private Sub GrdPesquisaFilmesCellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdPesquisaFilmes.CellClick
        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
            With grdPesquisaFilmes
                Dim con = New Connection
                Dim idFilme As UShort

                idFilme = .Item("IdFilme", e.RowIndex).Value
                Dim filme = New FilmesAction().ListarIndividualPorId(con, idFilme)

                If .Columns(e.ColumnIndex).Name = "Exibir" Then


                    txtTituloFilme.Text = filme.TituloFilme
                    cmbGenero.Text = filme.Genero
                    txtAnoLancamento.Text = filme.AnoLancamento
                    txtDuracao.Text = filme.Duracao
                    txtQtdeMidias.Text = filme.QtdeMidias
                    txtIdFilme.Text = filme.IdFilme
                    cmbTipoDeMidia.Text = filme.TipoMidia
                    txtValorlocacao.Text = filme.ValorLocacao
                    txtQtdeEstoqueCadastro.Text = filme.QtdeEstoque
                    tbpFilmes.SelectedTab = tbpCadastroFilmes

                ElseIf .Columns(e.ColumnIndex).Name = "Estoque" Then
                    txtEstoqueAtual.Text = filme.QtdeEstoque
                    tbpFilmes.SelectedTab = tbpEstoque
                    With grdEstoque
                        .Rows.Clear()
                        .Rows.Add()
                        .Item("IdFilme", 0).Value = filme.IdFilme
                        .Item("TituloFilme", 0).Value = filme.TituloFilme
                        .Item("Genero", 0).Value = filme.Genero
                        .Item("AnoLancamento", 0).Value = filme.AnoLancamento
                    End With
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BtnCancelarEstoqueClick(sender As Object, e As EventArgs) Handles btnCancelarEstoque.Click
        Close()
    End Sub

    Private Sub BtnEstoqueAdicionarClick(sender As Object, e As EventArgs) Handles btnEstoqueAdicionar.Click
        AdicionaFilmeEstoque()
    End Sub

    Private Sub BtnEstoqueRemoverClick(sender As Object, e As EventArgs) Handles btnEstoqueRemover.Click
        RemoveFilmeEstoque()
    End Sub
End Class