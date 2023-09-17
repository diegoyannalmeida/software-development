Imports Locadora.ClassesGenerica

Public Class GeneroAction

    Public Function Salvar(ByRef con As Connection, ByVal genero As GeneroDTO) As Boolean

        Try

            con.Command.Parameters.Add(con.InserirParametro(genero.Nome, "@nome", DbType.String))

            Dim sql As String

            If genero.IdGenero > 0 Then

                sql = "Update tbGenero Set nome=@nome Where idGenero=@idGenero"

                con.Command.Parameters.Add(con.InserirParametro(genero.IdGenero, "@idGenero", DbType.UInt16))


            Else
                sql = "Insert Into tbGenero (nome) Values (@nome)"
            End If

            con.Command.CommandText = sql

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Listar(ByRef con As Connection) As List(Of GeneroDTO)

        Try

            Dim lista = New List(Of GeneroDTO)

            Dim sql = "Select idGenero, nome" +
                " From tbGenero" +
                " Order by nome"

            con.Command.CommandText = sql

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim genero = New GeneroDTO With {
                        .IdGenero = dt.Rows(i).Item("idGenero"),
                        .Nome = dt.Rows(i).Item("nome")
                    }

                    lista.Add(genero)

                Next

            End If

            Return lista

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Detalhar(ByRef con As Connection, ByVal idGenero As UInt16) As GeneroDTO

        Try

            Dim genero = New GeneroDTO

            con.Command.Parameters.Add(con.InserirParametro(idGenero, "@idGenero", DbType.UInt16))

            Dim sql = "Select idGenero, nome" +
                " From tbGenero" +
                " Where idGenero=@idGenero"

            con.Command.CommandText = sql

            Dim dt = con.ExecutaComandoDataTable()

            If dt.Rows.Count > 0 Then

                genero.IdGenero = dt.Rows(0).Item("idGenero")
                genero.Nome = dt.Rows(0).Item("nome")

            End If

            Return genero

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idGenero As UInt16) As Boolean

        Try

            con.Command.Parameters.Add(con.InserirParametro(idGenero, "@idGenero", DbType.UInt16))

            Dim sql = "Delete From tbGenero" +
                " Where idGenero=@idGenero"

            con.Command.CommandText = sql

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Sub PreencheCombo(ByRef con As Connection, ByRef combo As ComboBox)
        Try
            Dim listaGenero = Listar(con)

            listaGenero.Insert(0, New GeneroDTO())

            With combo
                .DataSource = listaGenero
                .ValueMember = "idGenero"
                .DisplayMember = "nome"
            End With

        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
