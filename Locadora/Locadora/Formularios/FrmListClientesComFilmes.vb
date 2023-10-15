Imports Locadora.ClassesGenerica

Public Class FrmListClientesComFilmes
    ReadOnly ObjFunctions As New Funcoes()
    Private Sub FrmListClientesComFilmesLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfiguraGridListaClientes()
        CarregaGridListarClientes()
        ListarClientesLocacao()
    End Sub


#Region "Configurações da grid"
    Private Sub ConfiguraGridListaClientes()
        Try
            With grdListaClientesComFilmes
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
        With grdListaClientesComFilmes
            .Rows.Clear()
        End With
    End Sub

#End Region

#Region "CRUD"
    Private Sub ListarClientesLocacao()
        Try
            With grdListaClientesComFilmes
                Dim con = New Connection()
                Dim locacaoAction = New LocacaoAction()
                con.OpenConnection()
                Dim lista = locacaoAction.ListarTodosClientesComFilmes(con)
                Dim cliente = New ClienteDTO()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        cliente = lista(i)

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
#End Region

#Region "Botões e OnclickEvents"
    Private Function CalcularValorLocacao(dataRetirada As DateTime, dataEntrega As DateTime, valorBase As Decimal) As Decimal
        ' Calcula a diferença em dias
        Dim diasAluguel As Integer = CInt((dataEntrega - dataRetirada).TotalDays)

        ' Se a diferença for zero, considera como 1 dia
        If diasAluguel = 0 Then
            diasAluguel = 1
        End If

        ' Calcula o valor de locação baseado na quantidade de dias
        Return valorBase * diasAluguel
    End Function

    Private Sub GrdListaClientesAdicionarClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdListaClientesComFilmes.CellClick
        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

            With grdListaClientesComFilmes
                If .Columns(e.ColumnIndex).Name = "Selecionar" Then

                    Dim con = New Connection
                    Dim cpf As String = .Item("Cpf", e.RowIndex).Value

                    con.OpenConnection()
                    Dim cliente = New ClienteAction().Detalhar(con, cpf)
                    Dim saldo = New LocacaoAction().ObterSaldoCliente(con, cpf)
                    Dim lista = New LocacaoAction().ListarFilmesAlugadosPorCliente(con, cliente.IdCliente)
                    con.CloseConnection()

                    For Each frm In MdiLocadora.MdiChildren

                        If frm.Name = "FrmCadLocacoes" Then

                            CType(frm, FrmCadLocacoes).grdListaDevolucao.Rows.Clear()

                            CType(frm, FrmCadLocacoes).txtNomeClienteDevolucao.Text = cliente.Nome
                            CType(frm, FrmCadLocacoes).txtCpfClienteDevolucao.Text = cliente.Cpf
                            CType(frm, FrmCadLocacoes).txtCodClienteDevolucao.Text = cliente.IdCliente
                            CType(frm, FrmCadLocacoes).txtSaldoAtualCliente.Text = saldo.Saldo

                            If lista.Count > 0 Then
                                For i As Short = 0 To lista.Count - 1
                                    Dim filme = lista(i)
                                    Dim valorLocacao As Decimal = CalcularValorLocacao(filme.DataRetirada, filme.DataEntrega, filme.ValorLocacao)

                                    With CType(frm, FrmCadLocacoes).grdListaDevolucao
                                        .Rows.Add()
                                        .Item("IdFilme", i).Value = filme.IdFilme
                                        .Item("TituloFilme", i).Value = filme.TituloFilme
                                        .Item("AnoLancamento", i).Value = filme.AnoLancamento
                                        .Item("QtdeMidias", i).Value = filme.QtdeMidias
                                        .Item("DataRetirada", i).Value = filme.DataRetirada.ToString("dd/MM/yyyy")
                                        .Item("PrevisaoEntrega", i).Value = filme.DataEntrega.ToString("dd/MM/yyyy")
                                        .Item("ValorLocacao", i).Value = ObjFunctions.FormataNumero(valorLocacao, 2)
                                    End With
                                Next
                            End If

                            CType(frm, FrmCadLocacoes).Focus()

                            Close()

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub BtnCancelarClick(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub TxtCpfClienteComFilmeTextChanged(sender As Object, e As EventArgs) Handles txtCpfClienteComFilme.TextChanged
        Try
            If txtCpfClienteComFilme.Text.Trim <> "" Then
                With grdListaClientesComFilmes
                    Dim con = New Connection()
                    Dim cpf = txtCpfClienteComFilme.Text.Trim
                    Dim lista = New LocacaoAction().ListarClientesComFilmesPorCpf(con, cpf)
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
                End With
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub



#End Region




End Class