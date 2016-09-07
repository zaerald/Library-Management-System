Imports MySql.Data.MySqlClient
Module ToolZ

    Public Const SYS_ADD As Integer = 0
    Public Const SYS_UPD As Integer = 0
    Public Const SYS_DEL As Integer = 0

    Public Function getConnection() As MySqlConnection
        Dim conn As New MySqlConnection
        Try
            conn.ConnectionString = "server=localhost; userid=root; password=; database=dblms;"
            conn.Open()
            Console.WriteLine("Connected!")
        Catch ex As Exception
            MsgBox("The database is not opened.")
        End Try

        Return conn
    End Function

    Public Sub updateDataGridView(ByRef dgv As DataGridView, ByRef dataReader As MySqlDataReader, ByVal columns As String())
        dgv.Font = New Font("Arial", 10, FontStyle.Regular)

        ' reset dgv
        dgv.Columns.Clear()
        dgv.Rows.Clear()

        ' add columns
        For i As Integer = 0 To columns.Length - 1
            dgv.Columns.Add(i, columns(i))
        Next


        ' add rows
        Dim row As Integer = 0
        While dataReader.Read()
            dgv.Rows.Add()
            For i As Integer = 0 To columns.Length - 1
                dgv.Item(i, row).Value = dataReader.Item(i)
            Next

            ' set colors 
            Dim rowColor As Color
            If row Mod 2 = 0 Then
                rowColor = Color.LightGray
            Else
                rowColor = Color.White
            End If
            dgv.Rows(row).DefaultCellStyle.BackColor = rowColor

            row = row + 1
        End While

        If dgv.RowCount > 0 Then
            dgv.Rows(0).Selected = True
        End If

        dataReader.Close()
    End Sub

    Public Function upperCaseFirst(ByVal s As String) As String
        If Not s = "" Then
            s = s.Substring(0, 1).ToUpper & s.Substring(1, s.Length - 1)
        End If
        Return s
    End Function

End Module
