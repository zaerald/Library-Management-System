Imports MySql.Data.MySqlClient

Public Class frmBorrow

    Dim conn As New MySqlConnection

    Dim borrowID As Integer

    Private Sub updateAccessionCombo()

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        With cmd
            .Connection = conn
            .CommandText = "SELECT accession_no FROM tblbookaccession WHERE available = 1"
        End With
        dr = cmd.ExecuteReader

        cboAccession.Items.Clear()
        cboAccession.AutoCompleteCustomSource.Clear()
        If dr.HasRows Then
            While dr.Read
                cboAccession.Items.Add(dr.Item(0))
                cboAccession.AutoCompleteCustomSource.Add(dr.Item(0))
            End While
        End If

        dr.Close()
    End Sub

    Private Sub clearFields()
        cboBorrowerType.SelectedIndex = -1
        cboBorrowerType.Text = ""
        cboAccession.Text = ""
        cboBorrowerID.Text = ""
        txtISBN.Text = ""
        txtTitle.Text = ""
        txtCategory.Text = ""

        dtpBorrow.Value = Date.Now
        dtpDue.Value = Date.Now
    End Sub

    Private Sub updateBorrowerIDCombo()

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        If cboBorrowerType.SelectedIndex = 0 Then
            With cmd
                .Connection = conn
                .CommandText = "SELECT studid FROM tblstudent"
            End With
        ElseIf cboBorrowerType.SelectedIndex = 1
            With cmd
                .Connection = conn
                .CommandText = "SELECT facid FROM tblfaculty"
            End With
        End If

        dr = cmd.ExecuteReader

        cboBorrowerID.Items.Clear()
        cboBorrowerID.AutoCompleteCustomSource.Clear()
        If dr.HasRows Then
            While dr.Read
                cboBorrowerID.Items.Add(dr.Item(0))
                cboBorrowerID.AutoCompleteCustomSource.Add(dr.Item(0))
            End While
        End If

        dr.Close()

    End Sub

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

    Private Sub frmBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = ToolZ.getConnection

        updateDGV()
        updateAccessionCombo()
    End Sub

    Private Sub enableComboBox(ByVal b As Boolean)
        cboAccession.Enabled = b
        cboBorrowerID.Enabled = b
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim dlgSearch As New SearchDlg
        dlgSearch.cbo.Items.Add("Book ID")
        dlgSearch.cbo.Items.Add("ISBN")
        dlgSearch.cbo.Items.Add("Student ID")
        dlgSearch.cbo.Items.Add("Student Name")
        dlgSearch.cbo.Items.Add("Borrow Number")
        dlgSearch.ShowDialog()

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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' check validations
        If cboBorrowerType.SelectedIndex = -1 Then
            MsgBox("Please select a type of borrower.")
            Exit Sub
        End If

        If cboAccession.SelectedIndex = -1 Or cboAccession.Text = "" Then
            MsgBox("Please select a book.")
            Exit Sub
        End If

        If cboBorrowerID.SelectedIndex = -1 Or cboBorrowerID.Text = "" Then
            MsgBox("Please select a borrower.")
            Exit Sub
        End If

        If dtpBorrow.Value > dtpDue.Value Then
            MsgBox("Invalid due date.")
            dtpDue.Focus()
            Exit Sub
        End If

        Dim cmd As New MySqlCommand

        If Not cboBorrowerType.SelectedIndex = -1 Then

            Dim isValid As Boolean
            isValid = False
            Dim count As Integer

            ' check if student and faculty will exceed its limitation
            With cmd
                .Connection = conn
                .CommandText = "SELECT COUNT(*) FROM tblborrow WHERE borrower_id = '" & cboBorrowerID.Text & "'"
            End With
            count = cmd.ExecuteScalar

            If cboBorrowerType.SelectedIndex = 0 Then
                ' student
                If count < My.Settings.SBookLimit Then
                    isValid = True
                End If
            ElseIf cboBorrowerType.SelectedIndex = 1
                ' faculty
                If count < My.Settings.FBookLimit Then
                    isValid = True
                End If
            End If

            If Not isValid Then
                MsgBox("The borrower will exceed it's limit.")
                clearFields()
                Exit Sub
            End If

            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO tblborrow(book_acc, dateborrowed, duedate, borrower_id) VALUES(?bookacc, ?dateborrowed, ?duedate, ?borrowerid)"
                .Parameters.AddWithValue("bookacc", cboAccession.Text)
                .Parameters.AddWithValue("dateborrowed", Format(dtpBorrow.Value, "yyyy-MM-dd"))
                .Parameters.AddWithValue("duedate", Format(dtpDue.Value, "yyyy-MM-dd"))
                .Parameters.AddWithValue("borrowerid", cboBorrowerID.Text)
                .ExecuteNonQuery()
            End With

            ' update book availability
            With cmd
                .Connection = conn
                .CommandText = "UPDATE tblbookaccession SET available = 0 WHERE accession_no = " & cboAccession.Text
                .ExecuteNonQuery()
            End With
        End If

        updateDGV()
        updateAccessionCombo()
        ' reset accession
        cboAccession.SelectedIndex = -1
        cboAccession.Text = ""
        txtISBN.Text = ""
        txtTitle.Text = ""
        txtCategory.Text = ""

    End Sub

    Private Sub cboBorrowerType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrowerType.SelectedIndexChanged

        cboAccession.Text = ""
        cboAccession.SelectedIndex = -1
        cboBorrowerID.Text = ""
        cboBorrowerID.SelectedIndex = -1
        txtName.Text = ""
        txtISBN.Text = ""
        txtTitle.Text = ""
        txtCategory.Text = ""


        If cboBorrowerType.SelectedIndex = -1 Then
            enableComboBox(False)
            grpBorrower.Text = "Borrower Details"
            lblBorrower.Text = "Borrower ID"
            Exit Sub
        Else
            enableComboBox(True)
        End If

        Select Case cboBorrowerType.SelectedIndex
            Case 0 ' student
                grpBorrower.Text = "Student Details"
                lblBorrower.Text = "Student ID"
                ' student
                dtpBorrow.Value = DateTime.Now
                dtpDue.Value = DateTime.Now.AddDays(My.Settings.DueDays)
                dtpDue.Enabled = False
            Case 1 ' faculty
                grpBorrower.Text = "Faculty Details"
                lblBorrower.Text = "Faculty ID"
                dtpBorrow.Value = DateTime.Now
                dtpDue.Value = DateTime.Now
                dtpDue.Enabled = True
        End Select

        updateBorrowerIDCombo()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
    End Sub

    Private Sub cboAccession_Validated(sender As Object, e As EventArgs) Handles cboAccession.Validated, cboAccession.SelectedIndexChanged

        Dim isValidAccession As Boolean

        If Not cboAccession.Text = "" Then
            isValidAccession = False
            ' compare if valid
            For i As Integer = 0 To cboAccession.Items.Count - 1
                If cboAccession.Text = cboAccession.Items(i).ToString Then
                    isValidAccession = True
                    Exit For
                End If
            Next
            If Not isValidAccession Then
                MsgBox("Please select a valid accession number.")
                cboAccession.Focus()
                Exit Sub
            End If



            Dim cmd As New MySqlCommand
            Dim dr As MySqlDataReader
            With cmd
                .Connection = conn
                .CommandText = "SELECT b.ISBN, b.title, c.category FROM tblbooks b, tblbookaccession ba, tblcategory c WHERE b.book_id = ba.book_id AND b.category_id = c.category_id AND ba.accession_no = " & cboAccession.Text
            End With
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                txtISBN.Text = dr.Item(0)
                txtTitle.Text = dr.Item(1)
                txtCategory.Text = dr.Item(2)
            End If

            dr.Close()
        End If


    End Sub

    Private Sub cboBorrowerID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrowerID.SelectedIndexChanged, cboBorrowerID.Validated

        Dim isValidBorrower As Boolean

        If Not cboBorrowerID.Text = "" Then
            isValidBorrower = False
            For i As Integer = 0 To cboBorrowerID.Items.Count - 1
                If cboBorrowerID.Text = cboBorrowerID.Items(i).ToString Then
                    isValidBorrower = True
                    Exit For
                End If
            Next

            If Not isValidBorrower Then
                MsgBox("Please select a valid borrower ID.")
                cboBorrowerID.Focus()
                Exit Sub
            End If


            Dim cmd As New MySqlCommand

            With cmd
                If cboBorrowerType.SelectedIndex = 0 Then
                    .Connection = conn
                    .CommandText = "SELECT CONCAT(lastname, ', ', firstname) FROM tblstudent WHERE studid = '" & cboBorrowerID.Text & "'"
                ElseIf cboBorrowerType.SelectedIndex = 1
                    .Connection = conn
                    .CommandText = "SELECT CONCAT(lastname, ', ', firstname) FROM tblfaculty WHERE facid = '" & cboBorrowerID.Text & "'"
                End If
            End With
            txtName.Text = cmd.ExecuteScalar
        End If
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim opt As MsgBoxResult = MsgBox("Are you sure you want to delete this borrow transaction?", vbYesNo + vbQuestion, "Delete")

        If opt = vbYes Then
            Dim curIndex As Integer
            Try
                curIndex = dgv.CurrentRow.Index
            Catch ex As Exception
                curIndex = 0
            End Try

            Dim brwID As String
            Dim accNo As String

            brwID = dgv.Item(0, curIndex).Value
            accNo = dgv.Item(3, curIndex).Value

            Dim cmd As New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = "DELETE FROM tblborrow WHERE borrow_id = " & brwID
                .ExecuteNonQuery()
                .CommandText = "UPDATE tblbookaccession SET available = 1 WHERE accession_no = " & accNo
                .ExecuteNonQuery()
            End With
            clearFields()
            updateDGV()
            updateAccessionCombo()
        End If

    End Sub
End Class