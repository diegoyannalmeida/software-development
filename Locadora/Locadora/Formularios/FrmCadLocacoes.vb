Imports Locadora.ClassesGenerica



Public Class FrmCadLocacoes
    ReadOnly ObjFunctions As New Funcoes(Me)

    Private Sub FrmCadLocacoesLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim locacaoAction = New LocacaoAction()
        ObjFunctions.AtribuirEventos(Me, "cmbQtdeDias")
        locacaoAction.PreencheComboDias(cmbQtdeDias)
        ConfiguraGridAlugueis()
        ConfiguraGridPesquisa()
        CarregaGridPesquisa()
        ConfiguraGridListaDevolucao()
        CarregaGridListarDevolucao()
        ListarFilmesParaAlugar()
        ListarClientesAluguel()
        txtDataDaRetiradaLocacao.Text = Date.Now.ToString("dd/MM/yyyy")
        txtDataEntregaDevolucao.Text = Date.Now().ToString("dd/MM/yyyy")
        txtJurosDevolucao.Text = 0

    End Sub




#Region "Configurações da Grid"
#Region "Grid da tab Alugueis"
    Private Sub ConfiguraGridAlugueis()

        Try

            With grdListaAlugueis
                .Rows.Clear()
                .Columns.Clear()

                .Columns.Add(New DataGridViewButtonColumn)
                .Columns.Add(New DataGridViewTextBoxColumn)
                .Columns.Add(New DataGridViewTextBoxColumn)
                .Columns.Add(New DataGridViewTextBoxColumn)
                .Columns.Add(New DataGridViewTextBoxColumn)
                .Columns.Add(New DataGridViewTextBoxColumn)

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()

                .Columns(0).Name = "Remover"
                .Columns(1).Name = "IdFilme"
                .Columns(2).Name = "TituloFilme"
                .Columns(3).Name = "AnoLancamento"
                .Columns(4).Name = "QtdeMidias"
                .Columns(5).Name = "ValorLocacao"

                .Columns("ValorLocacao").ValueType = GetType(Double)

                .Columns("Remover").HeaderText = "Remover"
                .Columns("IdFilme").HeaderText = "Cód. Filme"
                .Columns("TituloFilme").HeaderText = "Título do Filme"
                .Columns("AnoLancamento").HeaderText = "Ano de lançamento"
                .Columns("QtdeMidias").HeaderText = "Quantidade de mídias"
                .Columns("ValorLocacao").HeaderText = "Valor da locação"

                .Columns("Remover").Width = 80
                .Columns("IdFilme").Width = 80
                .Columns("TituloFilme").Width = 300
                .Columns("AnoLancamento").Width = 100
                .Columns("QtdeMidias").Width = 100
                .Columns("ValorLocacao").Width = 100

                .Columns("Remover").ReadOnly = True
                .Columns("IdFilme").ReadOnly = True
                .Columns("TituloFilme").ReadOnly = True
                .Columns("AnoLancamento").ReadOnly = True
                .Columns("QtdeMidias").ReadOnly = True
                .Columns("ValorLocacao").ReadOnly = True

                .Columns("Remover").Visible = True
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

    Private Sub CarregaGridListaAlugueis()
        With grdListaAlugueis
            .Rows.Clear()
        End With
    End Sub
#End Region

#Region "Grid da tab Devolução"

    Private Sub ConfiguraGridListaDevolucao()
        Try
            With grdListaDevolucao
                .Rows.Clear()
                .Columns.Clear()

                .Columns.Add(New DataGridViewCheckBoxColumn)
                .Columns.Add(New DataGridViewTextBoxColumn)
                .Columns.Add(New DataGridViewTextBoxColumn)
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
                .Columns(5).Name = "DataRetirada"
                .Columns(6).Name = "PrevisaoEntrega"
                .Columns(7).Name = "ValorLocacao"


                .Columns("Selecionar").HeaderText = "Selecionar"
                .Columns("IdFilme").HeaderText = "Cód. Filme"
                .Columns("TituloFilme").HeaderText = "Título do Filme"
                .Columns("AnoLancamento").HeaderText = "Ano de Lançamento"
                .Columns("QtdeMidias").HeaderText = "Quantidade de mídias"
                .Columns("DataRetirada").HeaderText = "Data da retirada"
                .Columns("PrevisaoEntrega").HeaderText = "Previsão de entrega"
                .Columns("ValorLocacao").HeaderText = "Valor da locação"

                .Columns("Selecionar").Width = 60
                .Columns("IdFilme").Width = 60
                .Columns("TituloFilme").Width = 250
                .Columns("AnoLancamento").Width = 80
                .Columns("QtdeMidias").Width = 80
                .Columns("DataRetirada").Width = 80
                .Columns("PrevisaoEntrega").Width = 80
                .Columns("ValorLocacao").Width = 80

                .Columns("Selecionar").ReadOnly = False
                .Columns("IdFilme").ReadOnly = True
                .Columns("TituloFilme").ReadOnly = True
                .Columns("AnoLancamento").ReadOnly = True
                .Columns("QtdeMidias").ReadOnly = True
                .Columns("DataRetirada").ReadOnly = True
                .Columns("PrevisaoEntrega").ReadOnly = True
                .Columns("ValorLocacao").ReadOnly = True

                .Columns("Selecionar").Visible = True
                .Columns("IdFilme").Visible = True
                .Columns("TituloFilme").Visible = True
                .Columns("AnoLancamento").Visible = True
                .Columns("QtdeMidias").Visible = True
                .Columns("DataRetirada").Visible = True
                .Columns("PrevisaoEntrega").Visible = True
                .Columns("ValorLocacao").Visible = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub CarregaGridListarDevolucao()
        With grdListaDevolucao
            .Rows.Clear()
        End With
    End Sub

#End Region

#Region "Grid da tab pesquisa"

    Private Sub ConfiguraGridPesquisa()
        With grdPesquisarLocacoes
            .Columns.Clear()
            .Rows.Clear()

            .Columns.Add(New DataGridViewTextBoxColumn)
            .Columns.Add(New DataGridViewTextBoxColumn)
            .Columns.Add(New DataGridViewTextBoxColumn)
            .Columns.Add(New DataGridViewTextBoxColumn)
            .Columns.Add(New DataGridViewTextBoxColumn)
            .Columns.Add(New DataGridViewTextBoxColumn)


            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()


            .Columns(0).Name = "IdFilme"
            .Columns(1).Name = "TituloFilme"
            .Columns(2).Name = "Cliente"
            .Columns(3).Name = "Cpf"
            .Columns(4).Name = "DataRetirada"
            .Columns(5).Name = "DataEntrega"



            .Columns("idFilme").HeaderText = "Cód. Filme"
            .Columns("TituloFilme").HeaderText = "Título do Filme"
            .Columns("Cliente").HeaderText = "Cliente"
            .Columns("Cpf").HeaderText = "CPF"
            .Columns("DataRetirada").HeaderText = "Data da Retirada"
            .Columns("DataEntrega").HeaderText = "Data da Entrega"


            .Columns("idFilme").Width = 50
            .Columns("TituloFilme").Width = 200
            .Columns("Cliente").Width = 150
            .Columns("Cpf").Width = 100
            .Columns("DataRetirada").Width = 80
            .Columns("DataEntrega").Width = 80



            .Columns("idFilme").ReadOnly = True
            .Columns("TituloFilme").ReadOnly = True
            .Columns("Cliente").ReadOnly = True
            .Columns("Cpf").ReadOnly = True
            .Columns("DataRetirada").ReadOnly = True
            .Columns("DataEntrega").ReadOnly = True


            .Columns("idFilme").Visible = True
            .Columns("TituloFilme").Visible = True
            .Columns("Cliente").Visible = True
            .Columns("Cpf").Visible = True
            .Columns("DataRetirada").Visible = True
            .Columns("DataEntrega").Visible = True

        End With

    End Sub

    Private Sub CarregaGridPesquisa()
        With grdPesquisarLocacoes
            .Rows.Clear()
        End With

    End Sub


#End Region

#End Region

#Region "CRUD"

#Region "Salvar"
    Private Sub SalvarAluguel()
        Try
            Dim locacaoAction = New LocacaoAction()
            Dim listaFilmesAction = New ListaFilmesAction()
            If txtDataDaRetiradaLocacao.Text <> "" Then
                Dim continuar = MsgBox("Deseja salvar a locação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar")
                If MsgBoxResult.Yes Then

                    Dim filme = New FilmesDTO
                    Dim cliente = New ClienteDTO
                    Dim locacao = New LocacaoDTO
                    Dim con = New Connection()
                    Dim listaClienteAction = New ListaClientesAction()

                    For i As Short = 0 To grdListaAlugueis.Rows.Count - 1

                        With cliente
                            .Nome = txtNomeClienteLocacao.Text.Trim.ToUpper()
                            .Cpf = txtCpfClienteLocacao.Text.Trim
                            .IdCliente = txtCodClienteLocacao.Text.Trim
                        End With


                        With grdListaAlugueis
                            filme.IdFilme = .Item("idFilme", i).Value
                            filme.TituloFilme = .Item("TituloFilme", i).Value
                            filme.AnoLancamento = .Item("AnoLancamento", i).Value
                            filme.QtdeMidias = .Item("QtdeMidias", i).Value
                            filme.ValorLocacao = .Item("ValorLocacao", i).Value
                        End With
                        With locacao
                            .DataEntrega = CDate(txtDataDeEntregaLocacao.Text.Trim).ToString("yyyy-MM-dd")
                            .DataRetirada = CDate(txtDataDaRetiradaLocacao.Text.Trim).ToString("yyyy-MM-dd")
                            .DiasAluguel = cmbQtdeDias.Text
                        End With

                        con.OpenConnection()
                        locacaoAction.SalvarAluguel(con, filme, cliente, locacao)

                    Next
                    listaFilmesAction.ExcluirFilmesAluguel(con)
                    listaClienteAction.ExcluirClientesAluguel(con)
                    con.CloseConnection()
                    MsgBox("Locação adicionada com sucesso!", MsgBoxStyle.Information)
                    ListarFilmesParaAlugar()
                    ObjFunctions.LimpaCampos(Me)

                End If
            Else
                MsgBox("Insira uma data de retirada válida!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub SalvarHistoricoLocacao()
        Try
            If txtDataEntregaDevolucao.Text <> "" Then
                If txtCodClienteDevolucao.Text <> "" Then
                    Dim con = New Connection()
                    Dim locacaoAction = New LocacaoAction()
                    Dim cpf = txtCpfClienteDevolucao.Text.Trim
                    Dim idCliente = txtCodClienteDevolucao.Text.Trim
                    Dim filmes = locacaoAction.ListarFilmesAlugadosPorCliente(con, idCliente)
                    Dim saldoAtual As Double = Val(txtValorSaldoFinalDevolucao.Text)
                    con.OpenConnection()
                    For i As Short = 0 To filmes.Count - 1
                        If grdListaDevolucao.Item("Selecionar", i).Value Then
                            locacaoAction.SalvarHistoricoLocacaoCliente(con, cpf, filmes(i), idCliente)
                        End If
                    Next
                    With grdListaDevolucao
                        Dim lista = locacaoAction.ListarFilmesAlugadosPorCliente(con, idCliente)
                        locacaoAction.SalvarSaldoCliente(con, cpf, saldoAtual)

                        .Rows.Clear()
                        If lista.Count > 0 Then
                            For i As Short = 0 To lista.Count - 1
                                Dim filme = lista(i)


                                .Rows.Add()

                                .Item("IdFilme", i).Value = filme.IdFilme
                                .Item("TituloFilme", i).Value = filme.TituloFilme
                                .Item("AnoLancamento", i).Value = filme.AnoLancamento
                                .Item("QtdeMidias", i).Value = filme.QtdeMidias
                                .Item("DataRetirada", i).Value = filme.DataRetirada.ToString("dd/MM/yyyy")
                                .Item("PrevisaoEntrega", i).Value = filme.DataEntrega.ToString("dd/MM/yyyy")
                                .Item("ValorLocacao", i).Value = ObjFunctions.FormataNumero(filme.ValorLocacao, 2)

                            Next
                            Dim saldo = locacaoAction.ObterSaldoCliente(con, cpf).Saldo
                            txtSaldoAtualCliente.Text = Val(saldo)
                        Else
                            .Rows.Clear()
                            .Rows.Add()
                            ObjFunctions.LimpaCampos(Me)

                        End If
                    End With

                    con.CloseConnection()
                    MsgBox("Devolução realizada com sucesso!", MsgBoxStyle.Information)
                    ObjFunctions.LimpaCampos(txtValorPagoDevolucao)

                Else
                    MsgBox("Selecione um cliente!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Else
                MsgBox("Insira uma data de entrega válida!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
#End Region

#Region "Listar"
    Private Sub ListarFilmesParaAlugar()
        Try
            With grdListaAlugueis
                .Rows.Clear()
                Dim con = New Connection()
                con.OpenConnection()
                Dim lista = New ListaFilmesAction().ListarTodosFilmes(con)
                con.CloseConnection()

                If lista.Count > 0 Then
                    For i As Short = 0 To lista.Count - 1
                        .Rows.Add()
                        Dim filme = lista(i)
                        .Item("Remover", i).Value = "Remover"
                        .Item("IdFilme", i).Value = filme.IdFilme
                        .Item("TituloFilme", i).Value = filme.TituloFilme
                        .Item("AnoLancamento", i).Value = filme.AnoLancamento
                        .Item("QtdeMidias", i).Value = filme.QtdeMidias
                        .Item("ValorLocacao", i).Value = ObjFunctions.FormataNumero(filme.ValorLocacao, 2)
                    Next
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub




    Private Sub ListarTodosClientes()
        Try
            Dim ObjForm As New Form()
            Dim ListarClientes = New FrmListClientes()

            For Each ObjForm In MdiLocadora.MdiChildren
                If ObjForm.Name.ToUpper = "FRMLISTCLIENTES" Then
                    ObjForm.Close()
                End If
            Next

            ListarClientes.MdiParent = MdiLocadora
            ListarClientes.Show()
            ListarClientes.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub ListarFilmesReservados()

        Try
            Dim ObjForm As New Form()
            Dim ListarFilmesReservados = New FrmListFilmes()


            For Each ObjForm In MdiLocadora.MdiChildren
                If ObjForm.Name.ToUpper = "FRMLISTFILMES" Then
                    ObjForm.Close()
                End If
            Next

            ListarFilmesReservados.MdiParent = MdiLocadora
            ListarFilmesReservados.Show()
            ListarFilmesReservados.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ListarFilmesAlugados()
        Try
            Dim con = New Connection
            Dim lista = New LocacaoAction().ListarFilmesAlugados(con)

            With grdPesquisarLocacoes
                .Rows.Clear()

                If lista.Count > 0 Then
                    con.OpenConnection()
                    For i As Short = 0 To lista.Count - 1
                        .Rows.Add()
                        Dim locacao = lista(i)
                        Dim Cliente = New LocacaoAction().ObterClienteComFilmesPorId(con, locacao.IdCliente)
                        .Item("idFilme", i).Value = locacao.IdFilme
                        .Item("TituloFilme", i).Value = locacao.TituloFilme
                        .Item("Cliente", i).Value = Cliente.Nome
                        .Item("Cpf", i).Value = Cliente.Cpf
                        .Item("DataRetirada", i).Value = locacao.DataRetirada.ToString("dd/MM/yyyy")
                        .Item("DataEntrega", i).Value = locacao.DataEntrega.ToString("dd/MM/yyyy")
                    Next
                    con.CloseConnection()

                End If


            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ListarClientesLocacao()
        Try

            Dim frmListaClientes = New FrmListClientesComFilmes
            frmListaClientes.MdiParent = MdiLocadora
            frmListaClientes.Show()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ListarClientesAluguel()
        Try
            Dim con = New Connection()
            con.OpenConnection()
            Dim cliente = New ListaClientesAction().ListarClientesSalvos(con)
            con.CloseConnection()

            txtNomeClienteLocacao.Text = cliente.Nome
            txtCpfClienteLocacao.Text = cliente.Cpf
            txtCodClienteLocacao.Text = cliente.IdCliente

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

#End Region

#Region "Excluir"
    Private Sub ExcluirFilmesListaAluguel()
        Try
            Dim con = New Connection()
            con.OpenConnection()
            Dim listaFilmeAction = New ListaFilmesAction().ExcluirFilmesAluguel(con)
            con.CloseConnection()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ExcluirClientesAluguel()
        Try
            Dim con = New Connection()
            con.OpenConnection()
            Dim listaClienteAction = New ListaClientesAction()

            listaClienteAction.ExcluirClientesAluguel(con)

            con.CloseConnection()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DevolverFilmesAluguel()
        Try
            Dim con = New Connection()
            Dim locacaoAction = New LocacaoAction()
            con.OpenConnection()
            With grdListaDevolucao
                For i As Short = 0 To .Rows.Count - 1
                    If .Item("Selecionar", i).Value Then
                        Dim idfilme = .Item("idFilme", i).Value
                        locacaoAction.ExcluirFilmes(con, idfilme)
                    End If
                Next
                MsgBox("Filmes devoldidos com sucesso!")

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

#End Region



    Private Sub PreencheDataPrevistaEntrega()
        Try
            If cmbQtdeDias.Text <> "" Then

                If txtDataDaRetiradaLocacao.Text <> "" Then
                    Dim dataRetirada As Date = txtDataDaRetiradaLocacao.Text
                    Dim cmbDias As Double = cmbQtdeDias.Text

                    Dim dataEntrega = dataRetirada.AddDays(cmbDias)
                    txtDataDeEntregaLocacao.Text = dataEntrega.ToString("dd/MM/yyyy")

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CalculaValorTotalAluguel()
        Try
            Dim con = New Connection
            con.OpenConnection()
            Dim locacaoAction = New LocacaoAction
            ObjFunctions.LimpaCampos(txtValorTotalLocacao)
            Dim valor = locacaoAction.SomarTotalLocacaoAluguel(con)

            If cmbQtdeDias.Text <> "" Then
                Dim qtdeDias As Double = cmbQtdeDias.Text
                Dim valorTotal = qtdeDias * valor
                txtValorTotalLocacao.Text = valorTotal
                txtValorTotalLocacao.Text = ObjFunctions.FormataNumero(txtValorTotalLocacao.Text, 2)

            Else
                txtValorTotalLocacao.Text = "0.0"
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub


#End Region

#Region "Botões e OnClickEvents"
    Private Sub BtnListarFilmesPesquisaClick(sender As Object, e As EventArgs) Handles btnListarFilmesPesquisa.Click
        ' listar todos os filmes alugados e classificados por ordem de filmes
        ListarFilmesAlugados()

    End Sub

    Private Sub BtnListarClientesPesquisaClick(sender As Object, e As EventArgs)
        ListarTodosClientes()

    End Sub

    Private Sub BtnBuscarClientesLocacaoClick(sender As Object, e As EventArgs) Handles btnBuscarClientesLocacao.Click
        ListarTodosClientes()

    End Sub

    Private Sub BtnBuscarFilmesLocação_Click(sender As Object, e As EventArgs) Handles btnBuscarFilmesLocação.Click
        ListarFilmesReservados()
    End Sub

    Private Sub BtnBuscarFilmesDevolucao_Click(sender As Object, e As EventArgs)
        ListarFilmesReservados()

    End Sub
    Private Sub BtnListarClientesDevolucaoClick(sender As Object, e As EventArgs)
        ListarTodosClientes()
    End Sub

    Private Sub BtnLimparAluguelClick(sender As Object, e As EventArgs) Handles btnLimparAluguel.Click
        ObjFunctions.LimpaCampos(Me)
        ExcluirClientesAluguel()
        ExcluirFilmesListaAluguel()
        ListarClientesAluguel()
        ListarFilmesParaAlugar()


    End Sub

    Private Sub BtnCancelarAluguelClick(sender As Object, e As EventArgs) Handles btnCancelarAluguel.Click
        Close()
    End Sub

    Private Sub BtnSalvarAluguelClick(sender As Object, e As EventArgs) Handles btnSalvarAluguel.Click
        SalvarAluguel()
    End Sub

    Private Sub GrdListaAlugueisCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdListaAlugueis.CellContentClick
        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
            With grdListaAlugueis
                If .Columns(e.ColumnIndex).Name = "Remover" Then
                    Dim con = New Connection
                    Dim idFilme As Short = .Item("idFilme", e.RowIndex).Value
                    Dim listaFilmeAction = New ListaFilmesAction()

                    con.OpenConnection()
                    listaFilmeAction.ExcluirFilmesPorId(con, idFilme)
                    con.CloseConnection()
                    ListarFilmesParaAlugar()


                End If
            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub CmbQtdeDiasTextChanged(sender As Object, e As EventArgs) Handles cmbQtdeDias.TextChanged
        PreencheDataPrevistaEntrega()
        CalculaValorTotalAluguel()
    End Sub

    Private Sub GrdListaDevolucaoCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdListaDevolucao.CellContentClick
        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

            With grdListaDevolucao
                If .Columns(e.ColumnIndex).Name = "Selecionar" Then
                    Dim idFilme As Short = .Item("idFilme", e.RowIndex).Value
                    Dim con = New Connection
                    Dim idCliente = txtCodClienteDevolucao.Text
                    Dim valorTotal As Double
                    Dim juros As Double
                    Dim dataDif As Double
                    .EndEdit()

                    For i As Short = 0 To .Rows.Count - 1

                        If .Item("Selecionar", i).Value Then


                            idFilme = .Item("idFilme", i).Value

                            Dim filme = New LocacaoAction().ObterValorEDataDevolucao(con, idCliente, idFilme)

                            If filme.DataEntrega < Date.Now Then
                                dataDif = Date.Now.Subtract(filme.DataEntrega).Days
                                juros += (filme.ValorLocacao * dataDif)
                                txtJurosDevolucao.Text = juros
                            End If
                            valorTotal += filme.ValorLocacao
                            valorTotal = Date.Now.Subtract(filme.DataRetirada).Days * valorTotal
                        End If

                    Next
                    txtJurosDevolucao.Text = juros
                    txtValorTotalDevolucao.Text = valorTotal

                    txtValorTotalDevolucao.Text = ObjFunctions.FormataNumero(txtValorTotalDevolucao.Text, 2)
                    txtJurosDevolucao.Text = ObjFunctions.FormataNumero(txtJurosDevolucao.Text, 2)

                    txtValorTotalDevolucao.Focus()

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BtnBuscarClienteLocacaoClick(sender As Object, e As EventArgs) Handles btnBuscarClienteLocacao.Click
        ListarClientesLocacao()
    End Sub

#Region "Cálculos"
    Private Sub TxtValorPagoDevolucaoTextChanged(sender As Object, e As EventArgs) Handles txtValorPagoDevolucao.TextChanged
        Try
            Dim totalPagar As Double = txtValorTotalPagarDevolucao.Text
            Dim saldoFinal As Double
            If totalPagar > 0 Then
                Dim valorPago As Double = txtValorPagoDevolucao.Text
                Dim saldoAtual As Double = txtSaldoAtualCliente.Text


                If chbUsarSaldo.Checked Then
                    saldoFinal = Val(valorPago - totalPagar)
                Else
                    saldoFinal = Val(valorPago - totalPagar) + saldoAtual
                End If


                txtValorSaldoFinalDevolucao.Text = Val(saldoFinal)

                txtValorSaldoFinalDevolucao.Text = ObjFunctions.FormataNumero(txtValorSaldoFinalDevolucao.Text, 2)
            Else Exit Sub
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtValorTotalDevolucaoTextChanged(sender As Object, e As EventArgs) Handles txtValorTotalDevolucao.TextChanged
        Try


            Dim valorTotal = Val(txtValorTotalDevolucao.Text)

            Dim saldoFinal As Double

            Dim saldoAtualizado As Double = Val(txtSaldoAtualCliente.Text)

            Dim valorPago As Double = Val(txtValorPagoDevolucao.Text)

            Dim jurosDevolucao As Double = Val(txtJurosDevolucao.Text)

            Dim totalPagar As Double


            If chbUsarSaldo.Checked Then
                totalPagar = Val(valorTotal + jurosDevolucao) - Val(saldoAtualizado)
                saldoFinal = valorPago - totalPagar
            Else
                totalPagar = Val(valorTotal + jurosDevolucao)
                saldoFinal = Val(valorPago - totalPagar + saldoAtualizado)
            End If

            txtValorSaldoFinalDevolucao.Text = saldoFinal

            txtValorTotalPagarDevolucao.Text = totalPagar

            txtValorTotalPagarDevolucao.Text = ObjFunctions.FormataNumero(txtValorTotalPagarDevolucao.Text, 2)

            txtValorSaldoFinalDevolucao.Text = ObjFunctions.FormataNumero(txtValorSaldoFinalDevolucao.Text, 2)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub TxtSaldoAtualClienteTextChanged(sender As Object, e As EventArgs) Handles txtSaldoAtualCliente.TextChanged
        Try
            If Val(txtSaldoAtualCliente.Text) < 0 Then
                txtSaldoAtualCliente.BackColor = Color.Tomato
            Else
                txtSaldoAtualCliente.BackColor = Color.GreenYellow
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub ChbUsarSaldoCheckedChanged(sender As Object, e As EventArgs) Handles chbUsarSaldo.CheckedChanged

        Dim saldoAtual = Val(txtSaldoAtualCliente.Text)
        Dim valorTotal = Val(txtValorTotalDevolucao.Text)
        Dim TotalPagar As Double
        Dim Juros As Double = Val(txtJurosDevolucao.Text)
        Dim saldoFinal As Double
        Dim valorPago As Double = Val(txtValorPagoDevolucao.Text)


        If chbUsarSaldo.Checked Then
            TotalPagar = valorTotal - saldoAtual + Juros
            saldoFinal = Val(valorPago - TotalPagar)
        Else
            TotalPagar = valorTotal + Juros
            saldoFinal = Val(valorPago - TotalPagar) + saldoAtual
        End If


        txtValorSaldoFinalDevolucao.Text = saldoFinal
        txtValorTotalPagarDevolucao.Text = Val(TotalPagar)

        txtValorTotalPagarDevolucao.Text = ObjFunctions.FormataNumero(txtValorTotalPagarDevolucao.Text, 2)

    End Sub

#End Region

    Private Sub BtnDevolverClick(sender As Object, e As EventArgs) Handles btnDevolver.Click

        SalvarHistoricoLocacao()
    End Sub



    Private Sub TxtSaldoFinalDevolucaoTextChanged(sender As Object, e As EventArgs) Handles txtValorSaldoFinalDevolucao.TextChanged
        Dim saldoFinal As Double = txtValorSaldoFinalDevolucao.Text

        If saldoFinal > 0 Then
            txtValorSaldoFinalDevolucao.BackColor = Color.GreenYellow
        Else
            txtValorSaldoFinalDevolucao.BackColor = Color.Tomato
        End If
    End Sub

    Private Sub TxtDataDaRetiradaLocacaoTextChanged(sender As Object, e As EventArgs) Handles txtDataDaRetiradaLocacao.TextChanged
        PreencheDataPrevistaEntrega()
    End Sub

    Private Sub BtnLimparPesquisaClick(sender As Object, e As EventArgs) Handles btnLimparPesquisa.Click
        ObjFunctions.LimpaCampos(Me)

    End Sub

    Private Sub TxtValorTotalPagarDevolucaoTextChanged(sender As Object, e As EventArgs) Handles txtValorTotalPagarDevolucao.TextChanged

        txtValorTotalPagarDevolucao.Text = ObjFunctions.FormataNumero(txtValorTotalPagarDevolucao.Text, 2)

    End Sub























#End Region


End Class