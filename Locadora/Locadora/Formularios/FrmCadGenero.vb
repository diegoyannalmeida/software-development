Imports Locadora.ClassesGenerica

Public Class FrmCadGenero
    Private Sub FrmCadGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call ConfiguraGrid()


    End Sub

    Private Sub SalvarGenero()
        Try

            If txtNome.Text.Trim = "" Then
                MsgBox("Informe o nome do gênero", MsgBoxStyle.Exclamation)
                txtNome.Focus()
                Exit Sub
            End If

            Dim continuar = MsgBox("Tem certeza que deseja salvar os dados ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar")

            If continuar = MsgBoxResult.Yes Then

                Dim genero = New GeneroDTO

                If IsNumeric(txtCodigo.Text) Then
                    genero.IdGenero = txtCodigo.Text
                End If
                genero.Nome = txtNome.Text.Trim.ToUpper()

                Dim con = New Connection()

                Dim generoAction = New GeneroAction

                con.OpenConnection()

                Dim retorno = generoAction.Salvar(con, genero)

                con.CloseConnection()

                If retorno = True Then

                    MsgBox("Operação realizada com sucesso", MsgBoxStyle.Information)

                    txtCodigo.Text = ""
                    txtNome.Text = ""

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub



    Private Sub ConfiguraGrid()

        Try

            With grdGenero

                .Rows.Clear()
                .Columns.Clear()

                .Columns.Add(New DataGridViewButtonColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoResizeColumns()


                .Columns(0).Name = "Exibir"
                .Columns(1).Name = "IdGenero"
                .Columns(2).Name = "Nome"

                .Columns("Exibir").HeaderText = ""
                .Columns("IdGenero").HeaderText = "ID"
                .Columns("Nome").HeaderText = "Nome"

                .Columns("Exibir").Width = 70
                .Columns("IdGenero").Width = 80
                .Columns("Nome").Width = 300

                .Columns("Exibir").ReadOnly = True
                .Columns("IdGenero").ReadOnly = True
                .Columns("Nome").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("IdGenero").Visible = True
                .Columns("Nome").Visible = True

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub CarregaRegistros()

        Try

            With grdGenero

                .Rows.Clear()

                Dim con = New Connection()

                con.OpenConnection()

                Dim lista = New GeneroAction().Listar(con)

                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        Dim genero = lista(i)

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdGenero", i).Value = genero.IdGenero
                        .Item("Nome", i).Value = genero.Nome

                    Next

                End If

            End With

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Call CarregaRegistros()
    End Sub

    Private Sub GrdGenero_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdGenero.CellClick

        Try

            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

            With grdGenero

                If .Columns(e.ColumnIndex).Name = "Exibir" Then

                    Dim con = New Connection

                    Dim idGenero As UShort

                    idGenero = .Item("IdGenero", e.RowIndex).Value

                    Dim genero = New GeneroAction().Detalhar(con, idGenero)

                    txtCodigo.Text = genero.IdGenero
                    txtNome.Text = genero.Nome

                    tbpGeral.SelectedTab = TabCadastro

                End If

            End With



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Try

            If txtCodigo.Text = "" Then
                MsgBox("Selecione o registro que deseja excluir", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim confirmar = MsgBox("Tem certeza que deseja excluir o registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir")

            If confirmar = MsgBoxResult.Yes Then

                Dim con = New Connection

                con.OpenConnection()

                Dim excluir = New GeneroAction().Excluir(con, txtCodigo.Text)

                con.CloseConnection()

                If excluir = True Then

                    MsgBox("Operação realizada com sucesso", MsgBoxStyle.Information)

                    Call CarregaRegistros()

                    txtCodigo.Text = ""
                    txtNome.Text = ""

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        SalvarGenero()

    End Sub



End Class