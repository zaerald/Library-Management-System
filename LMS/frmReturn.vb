Imports MySql.Data.MySqlClient

Public Class frmReturn

    Dim conn As New MySqlConnection

    Dim isLoaded As Boolean
    Dim isSelected As Boolean

    Private Sub updateDGV()

        dgv.Font = New Font("Arial", 10, FontStyle.Regular)

        ' reset dgv
        dgv.Columns.Clear()
        dgv.Rows.Clear()

        ' add columns
        Dim columns() As String = {"Borrow ID", "Borrow Date", "Due Date", "Accession No.", "ISBN", "Title", "Borrower ID", "Name"}
        For i As Integer = 0 To columns.Length - 1
            dgv.Columns.Add(i, columns(i))
        Next

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        With cmd
            .Connection = conn
            .CommandText = "SELECT b.borrow_id, b.dateborrowed, b.duedate, ba.accession_no, bs.ISBN, bs.title, s.studid, CONCAT(s.firstname, ' ',s.lastname) FROM tblborrow b, tblbooks bs, tblstudent s, tblbookaccession ba WHERE b.book_acc = ba.accession_no AND ba.book_id = bs.book_id AND b.borrower_id = s.studid UNION 
                            SELECT b.borrow_id, b.dateborrowed, b.duedate, ba.accession_no, bs.ISBN, bs.title, f.facid, CONCAT(f.firstname, ' ',f.lastname) FROM tblborrow b, tblbooks bs, tblfaculty f, tblbookaccession ba WHERE b.book_acc = ba.accession_no AND ba.book_id = bs.book_id AND b.borrower_id = f.facid"
        End With
        dr = cmd.ExecuteReader
        'ToolZ.updateDataGridView(dgv, dr, columns)
        If dr.HasRows Then
            While dr.Read
                Dim brwD As Date = dr.Item(1)
                Dim dueD As Date = dr.Item(2)

                dgv.Rows.Add(dr.Item(0), brwD.ToString("ddd. MMMM dd"), dueD.ToString("ddd. MMMM dd"), dr.Item(3), dr.Item(4), dr.Item(5), dr.Item(6), dr.Item(7))
            End While
        End If


        dr.Close()
        dgv.Sort(dgv.Columns(0), ComponentModel.ListSortDirection.Ascending)
        dgv.CurrentCell = Nothing
        If dgv.RowCount > 0 Then
            dgv.Rows(0).Selected = True
        End If
    End Sub

    Private Sub updateAccessionCombo()

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        cboAccession.Items.Clear()
        cboAccession.AutoCompleteCustomSource.Clear()
        With cmd
            .Connection = conn
            .CommandText = "SELECT book_acc FROM tblborrow"
        End With
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboAccession.Items.Add(dr.Item(0))
                cboAccession.AutoCompleteCustomSource.Add(dr.Item(0))
            End While
        End If

        dr.Close()
    End Sub

    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = ToolZ.getConnection

        updateDGV()
        updateAccessionCombo()
        isLoaded = True
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

        isSelected = True
        If Not isLoaded Then
            cboAccession.Text = dgv.Item(3, dgv.CurrentRow.Index).Value
            dtpDueDate.Value = dgv.Item(2, dgv.CurrentRow.Index).Value
        End If
        isLoaded = False

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

    Private Sub cboAccession_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccession.SelectedIndexChanged, cboAccession.Validated

        If (Not cboAccession.Text = "" Or Not cboAccession.SelectedIndex = -1) And Not isSelected Then
            Dim accNo As String
            ' set selection
            For i As Integer = 0 To dgv.RowCount - 1
                accNo = dgv.Item(3, i).Value
                If accNo = cboAccession.Text Then
                    dgv.CurrentCell = Nothing
                    dgv.Rows(i).Selected = True
                    dtpDueDate.Value = dgv.Item(2, i).Value
                    Exit For
                End If
            Next
        End If

        If Not cboAccession.Text = "" Then
            Dim isValid As Boolean
            isValid = False
            ' check if valid
            For i As Integer = 0 To cboAccession.Items.Count - 1
                If cboAccession.Text = cboAccession.Items(i).ToString Then
                    isValid = True
                    Exit For
                End If
            Next
            If Not isValid Then
                MsgBox("Please select a valid accession number.")
                cboAccession.Focus()
                Exit Sub
            End If
        End If

        isLoaded = False
        isSelected = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If cboAccession.Text = "" Or cboAccession.SelectedIndex = -1 Then
            MsgBox("Please select an accession number.")
            Exit Sub
        End If

        If dtpReturn.Value < dtpDueDate.Value Then
            MsgBox("Invalid Return Date.")
            dtpReturn.Focus()
            Exit Sub
        End If

        Dim curIndex As Integer
        curIndex = dgv.CurrentRow.Index
        Dim bID As String = dgv.Item(0, curIndex).Value
        Dim accNo As String = dgv.Item(3, curIndex).Value
        Dim brwDate As Date = dgv.Item(1, curIndex).Value
        Dim dueDate As Date = dgv.Item(2, curIndex).Value

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .CommandText = "INSERT INTO tblreturn VALUES(?bID, ?dbrw, ?dd, ?dr, ?bacc, ?brwID)"
            .Parameters.AddWithValue("bID", bID)
            .Parameters.AddWithValue("dbrw", brwDate.ToString("yyyy-MM-dd"))
            .Parameters.AddWithValue("dd", dueDate.ToString("yyyy-MM-dd"))
            .Parameters.AddWithValue("dr", Format(dtpReturn.Value, "yyyy-MM-dd"))
            .Parameters.AddWithValue("bacc", accNo)
            .Parameters.AddWithValue("brwID", dgv.Item(6, curIndex).Value)
            .ExecuteNonQuery()

            ' update book
            .CommandText = "UPDATE tblbookaccession SET available = 1 WHERE accession_no = '" & accNo & "'"
            .ExecuteNonQuery()

            ' delete borrow
            .CommandText = "DELETE FROM tblborrow WHERE borrow_id = " & bID
            .ExecuteNonQuery()

        End With

        updateDGV()
        MsgBox("Returned.")
    End Sub
End Class