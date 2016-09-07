Imports MySql.Data.MySqlClient

Public Class frmBookReport

    Dim conn As New MySqlConnection

    Private Sub updateDGV()

        dgv.Font = New Font("Arial", 10, FontStyle.Regular)

        ' reset dgv
        dgv.Columns.Clear()
        dgv.Rows.Clear()

        ' add columns
        Dim columns() As String = {"Borrow Date", "Due Date", "Returned Date", "Accession No.", "ISBN", "Title", "Borrower ID", "Name"}
        For i As Integer = 0 To columns.Length - 1
            dgv.Columns.Add(i, columns(i))
        Next

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        With cmd
            .Connection = conn
            .CommandText = "SELECT r.dateborrowed, r.duedate, r.datereturned, ba.accession_no, b.ISBN, b.title, s.studid, CONCAT(s.firstname, ' ', s.lastname) FROM tblreturn r, tblbookaccession ba, tblbooks b, tblstudent s WHERE r.book_acc = ba.accession_no AND ba.book_id = b.book_id AND r.borrower_id = s.studid UNION
SELECT r.dateborrowed, r.duedate, r.datereturned, ba.accession_no, b.ISBN, b.title, f.facid, CONCAT(f.firstname, ' ', f.lastname) FROM tblreturn r, tblbookaccession ba, tblbooks b, tblfaculty f WHERE r.book_acc = ba.accession_no AND ba.book_id = b.book_id AND r.borrower_id = f.facid"
        End With
        dr = cmd.ExecuteReader
        'ToolZ.updateDataGridView(dgv, dr, columns)
        If dr.HasRows Then
            While dr.Read
                Dim brwD As Date = dr.Item(0)
                Dim dueD As Date = dr.Item(1)
                Dim retD As Date = dr.Item(2)

                dgv.Rows.Add(brwD.ToString("ddd. MMMM dd"), dueD.ToString("ddd. MMMM dd"), retD.ToString("ddd. MMMM dd"), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6), dr.Item(7))
            End While
        End If


        dr.Close()
        dgv.Sort(dgv.Columns(0), ComponentModel.ListSortDirection.Ascending)
        dgv.CurrentCell = Nothing
        If dgv.RowCount > 0 Then
            dgv.Rows(0).Selected = True
        End If
    End Sub

    Private Sub frmBookReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = ToolZ.getConnection

        updateDGV()
    End Sub
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click, lblGoBack.Click
        frmTransaction.Show()
        Me.Close()
    End Sub

    Private Sub btnGoBack_MouseEnter(sender As Object, e As EventArgs) Handles btnGoBack.MouseEnter, lblGoBack.MouseEnter
        btnGoBack.Image = My.Resources.backhover
    End Sub

    Private Sub btnGoBack_MouseLeave(sender As Object, e As EventArgs) Handles btnGoBack.MouseLeave, lblGoBack.MouseLeave
        btnGoBack.Image = My.Resources.back
    End Sub

    Private Sub dgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEnter, dgv.CellDoubleClick
        Dim index As Integer = dgv.CurrentRow.Index
        dgv.Rows(index).Selected = True
    End Sub

    Private Sub dgv_Sorted(sender As Object, e As EventArgs) Handles dgv.Sorted
        ' set colors 
        Dim rowColor As Color
        For i As Integer = 0 To dgv.RowCount - 1
            If i Mod 2 = 0 Then
                rowColor = Color.LightGray
            Else
                rowColor = Color.White
            End If
            dgv.Rows(i).DefaultCellStyle.BackColor = rowColor
        Next
    End Sub

End Class