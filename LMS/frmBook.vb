Imports MySql.Data.MySqlClient

Public Class frmBook

    Dim conn As New MySqlConnection

    Dim cboList As New ArrayList
    Dim numLast As Integer

    Dim isUpdate As Boolean
    Dim isAdd As Boolean
    Dim isSaved As Boolean

    Private Sub updateDGV()

        dgv.Font = New Font("Arial", 10, FontStyle.Regular)
        dgv.Columns.Clear()
        dgv.Rows.Clear()

        ' cols
        Dim columns() As String = {"ISBN", "Accession", "Book ID", "Title", "Author", "Category", "DDC", "Publisher", "Published Year", "Availability"}

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim row As Integer = 0

        With cmd
            .Connection = conn
            .CommandText = "SELECT b.ISBN, ba.accession_no, b.book_id, b.title, GROUP_CONCAT(a.name SEPARATOR ', '), c.category, bc.classification, p.publisher, b.pubyear, av.availability FROM tblbookaccession ba, tblbooks b, tblcategory c, tblbookclassification bc, tblpublisher p, tblavailability av, tblauthor a, tblbookauthor bau WHERE ba.book_id = b.book_id AND b.category_id = c.category_id AND b.ddc = bc.ddc AND b.publisher_id = p.publisher_id AND b.availability_id = av.availability_id AND b.book_id = bau.book_id AND a.author_id = bau.author_id GROUP BY b.book_id"
        End With
        dr = cmd.ExecuteReader
        ToolZ.updateDataGridView(dgv, dr, columns)

        dr.Close()
    End Sub

    Private Sub updateDGV(ByVal command As String)
        dgv.Rows.Clear()

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        With cmd
            .Connection = conn
            .CommandText = command
        End With
        dr = cmd.ExecuteReader

        ' populate dgv
        Dim columns() As String = {"ISBN", "Accession", "Book ID", "Title", "Author", "Category", "DDC", "Publisher", "Published Year", "Availability"}
        ToolZ.updateDataGridView(dgv, dr, columns)
        dr.Close()
    End Sub

    Private Sub updateSearchInput(ByVal command As String)

        cboSearchInput.DropDownStyle = ComboBoxStyle.DropDown
        cboSearchInput.FlatStyle = FlatStyle.Standard

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        cboSearchInput.Items.Clear()
        cboSearchInput.AutoCompleteCustomSource.Clear()
        With cmd
            .Connection = conn
            .CommandText = command
        End With
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboSearchInput.Items.Add(dr.Item(0))
                cboSearchInput.AutoCompleteCustomSource.Add(dr.Item(0))
            End While
        End If
        dr.Close()

    End Sub

    Private Sub resetSearch()
        cboSearch.SelectedIndex = -1
        cboSearch.Text = ""
        cboSearchInput.SelectedIndex = -1
        cboSearchInput.Text = ""
    End Sub

    Private Sub enableFields(ByVal b As Boolean)
        txtTitle.Enabled = b
        cboCategory.Enabled = b
        num.Enabled = b
        cboAuthor1.Enabled = b
        cboPublisher.Enabled = b
        txtPubYear.Enabled = b
        numBooks.Enabled = b
        cboAvailability.Enabled = b
        txtISBN.Enabled = b
        cboDDC.Enabled = b
        txtAccession.Enabled = b
    End Sub


    Private Sub updateCategoryCombo()
        cboCategory.Items.Clear()

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        With cmd
            .Connection = conn
            .CommandText = "SELECT category FROM tblcategory"
        End With
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboCategory.Items.Add(dr.Item(0))
                cboCategory.AutoCompleteCustomSource.Add(dr.Item(0))
            End While
        End If
        dr.Close()

    End Sub

    Private Sub updateDDCCombo()
        cboDDC.Items.Clear()

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        With cmd
            .Connection = conn
            .CommandText = "SELECT classification FROM tblbookclassification"
        End With
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboDDC.Items.Add(dr.Item(0))
                cboDDC.AutoCompleteCustomSource.Add(dr.Item(0))
            End While
        End If
        dr.Close()
    End Sub

    Private Sub updateAuthorCombo()

        If isSaved Then
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then
            Dim cmd As New MySqlCommand
            Dim dr As MySqlDataReader
            With cmd
                .Connection = conn
                .CommandText = "SELECT name FROM tblauthor"
            End With

            For i As Integer = 0 To cboList.Count - 1
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim cbo As New ComboBox
                    cbo = cboList.Item(i)
                    cbo.Items.Clear()
                    cbo.AutoCompleteCustomSource.Clear()
                    While dr.Read
                        cbo.Items.Add(dr.Item(0))
                        cbo.AutoCompleteCustomSource.Add(dr.Item(0))
                    End While
                End If
                dr.Close()
            Next
        End If

    End Sub

    Private Sub updatePublisherCombo()
        cboPublisher.Items.Clear()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        With cmd
            .Connection = conn
            .CommandText = "SELECT publisher FROM tblpublisher"
        End With
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboPublisher.Items.Add(dr.Item(0))
                cboPublisher.AutoCompleteCustomSource.Add(dr.Item(0))
            End While
        End If
        dr.Close()

    End Sub

    Private Sub resetFields()
        txtISBN.Text = ""
        txtAccession.Text = ""
        txtTitle.Text = ""
        cboCategory.SelectedIndex = -1
        ' reset cboauthor
        cboAuthor1.Text = ""
        If num.Value > 1 Then
            While Not num.Value = 1
                num.Value -= 1
            End While
        End If
        cboCategory.SelectedIndex = -1
        cboDDC.SelectedIndex = -1
        cboPublisher.SelectedIndex = -1
        txtPubYear.Text = ""
        cboAvailability.SelectedIndex = -1
        numBooks.Value = 1
    End Sub

    Private Sub frmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = ToolZ.getConnection

        updateDGV()

        enableFields(False)
        cboList.Add(cboAuthor1)
        updateCategoryCombo()
        updateDDCCombo()
        updateAuthorCombo()
        updatePublisherCombo()
    End Sub

    Private Sub cboCategory_Validated(sender As Object, e As EventArgs) Handles cboCategory.Validated

        ' check if user selected from the list
        If cboCategory.SelectedIndex = -1 And Not cboCategory.Text = "" Then
            Dim opt As MsgBoxResult = MsgBox(cboCategory.Text & " is not on the list." & Environment.NewLine & "Do you want to add it on the list?", vbYesNo + vbQuestion)
            If opt = vbYes Then
                Dim selected As String = cboCategory.Text
                selected = (selected.First).ToString.ToUpper & selected.Substring(1, selected.Length - 1)
                Dim cmd As New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = "INSERT INTO tblcategory(category) VALUES(?cat)"
                    .Parameters.AddWithValue("cat", selected)
                    .ExecuteNonQuery()
                End With
                updateCategoryCombo()
                cboCategory.Text = selected
            Else
                cboCategory.SelectAll()
                cboCategory.Focus()
            End If
        End If
    End Sub

    Private Sub cboPublisher_Validated(sender As Object, e As EventArgs) Handles cboPublisher.Validated, cboDDC.Validated
        If cboPublisher.SelectedIndex = -1 And Not cboPublisher.Text = "" Then
            Dim opt As MsgBoxResult = MsgBox(cboPublisher.Text & " is not on the list." & Environment.NewLine & "Do you want to add it on the list?", vbYesNo + vbQuestion)
            If opt = vbYes Then
                Dim selected As String = ToolZ.upperCaseFirst(cboPublisher.Text)
                Dim cmd As New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = "INSERT INTO tblpublisher(publisher) VALUES(?pub)"
                    .Parameters.AddWithValue("pub", selected)
                    .ExecuteNonQuery()
                End With
                updatePublisherCombo()
                cboPublisher.Text = selected
            ElseIf opt = vbNo
                cboPublisher.Focus()
                cboPublisher.SelectAll()
            End If
        End If
    End Sub

    Private Sub cboAuthor_Validated(sender As Object, e As EventArgs) Handles cboAuthor1.Validated

        For i As Integer = 0 To cboList.Count - 1
            Dim cbo As New ComboBox
            cbo = cboList.Item(i)

            Dim isValid As Boolean = False

            If cbo.SelectedIndex = -1 And Not cbo.Text = "" Then

                For j As Integer = 0 To cbo.Items.Count - 1
                    If cbo.Text = cbo.Items(j) Then
                        isValid = True
                        Exit For
                    End If
                Next

                If Not isValid Then
                    Dim opt As MsgBoxResult = MsgBox(cbo.Text & " is not on the list." & Environment.NewLine & "Do you want to add it on the list?", vbYesNo + vbQuestion)
                    If opt = vbYes Then
                        Dim selected As String = cbo.Text
                        selected = (selected.First).ToString.ToUpper & selected.Substring(1, selected.Length - 1)
                        Dim cmd As New MySqlCommand
                        With cmd
                            .Connection = conn
                            .CommandText = "INSERT INTO tblauthor(name) VALUES(?authname)"
                            .Parameters.AddWithValue("authname", selected)
                            .ExecuteNonQuery()
                        End With
                        MsgBox("Added.")
                        updateAuthorCombo()
                        cbo.Text = selected
                    ElseIf opt = vbNo
                        cbo.Focus()
                        cbo.SelectAll()
                    End If
                End If
            End If
        Next


    End Sub

    Private Sub num_ValueChanged(sender As Object, e As EventArgs) Handles num.ValueChanged
        If num.Value > 1 Then
            ' check if num gets higher or lower
            If num.Value > numLast Then ' higher

                Dim cbo As New ComboBox

                With cbo
                    .Name = "cboAuthor" & num.Value
                    .Visible = True
                    .Top = 228 + (35 * (num.Value - 1))
                    .Left = 66
                    .Width = 174
                    .Font = New Font("Century Gothic", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                    .FlatStyle = FlatStyle.Flat
                    .AutoCompleteMode = AutoCompleteMode.Append
                    .AutoCompleteSource = AutoCompleteSource.CustomSource
                    .TabIndex = cboAuthor1.TabIndex + num.Value
                    AddHandler .Validated, AddressOf cboAuthor_Validated
                End With
                cboList.Add(cbo)
                pan.Controls.Add(cbo)
                panMove.Top = panMove.Top + 35

            ElseIf num.Value < numLast ' lower
                ' remove last
                pan.Controls.Remove(cboList.Item(cboList.Count - 1))
                cboList.RemoveAt(cboList.Count - 1)
                panMove.Top -= 35
            End If
        ElseIf num.Value = 1
            numLast = 1
            ' remove all
            For i As Integer = 1 To cboList.Count - 1
                pan.Controls.Remove(cboList.Item(i))
                cboList.RemoveAt(i)
                panMove.Top -= 35
            Next
        End If
        numLast = num.Value
        updateAuthorCombo()
    End Sub

    Private Sub txtPubYear_Validated(sender As Object, e As EventArgs) Handles txtPubYear.Validated
        Dim curYear As Integer
        curYear = Date.Now.Year

        If (Not txtPubYear.Text.Count = 4 And Not txtPubYear.Text = "") Or (Not IsNumeric(txtPubYear.Text) And Not txtPubYear.Text = "") Then
            MsgBox("Published Year is not a valid format.")
            txtPubYear.Focus()
            txtPubYear.SelectAll()

        ElseIf Val(txtPubYear.Text) > curYear And Not txtPubYear.Text = ""
            MsgBox("Published Year is over current year (" & curYear & ")")
            txtPubYear.Focus()
            txtPubYear.SelectAll()
        End If
    End Sub

    Private Sub dgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEnter, dgv.CellDoubleClick
        Dim index As Integer = dgv.CurrentRow.Index
        dgv.Rows(index).Selected = True

        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Enabled = True
        btnSave.Enabled = False

        resetFields()
        enableFields(False)
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        resetFields()
        resetSearch()

        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Cancel"
            enableFields(True)
            btnSave.Enabled = True
            btnClear.Enabled = True
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            dgv.Enabled = False
            dgv.BackgroundColor = Color.SeaGreen
            cboSearch.Enabled = False

            isAdd = True
        ElseIf btnAdd.Text = "Cancel" Then
            btnAdd.Text = "Add"
            enableFields(False)
            btnSave.Enabled = False
            btnClear.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            dgv.Enabled = True
            dgv.BackgroundColor = Color.FromArgb(39, 174, 96)
            cboSearch.Enabled = True

            isAdd = False
            resetFields()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        resetFields()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        resetFields()
        resetSearch()

        If dgv.RowCount > 0 Then
            If btnUpdate.Text = "Update" Then
                btnUpdate.Text = "Cancel"

                ' set text
                Dim id As String
                id = dgv.Item(2, dgv.CurrentRow.Index).Value
                Dim cmd As New MySqlCommand
                Dim dr As MySqlDataReader
                With cmd
                    .Connection = conn
                    .CommandText = "SELECT b.ISBN, ba.accession_no, b.title, c.category, bc.classification, p.publisher, b.pubyear, b.availability_id FROM tblbookaccession ba, tblbooks b, tblcategory c, tblbookclassification bc, tblpublisher p WHERE ba.book_id = b.book_id AND b.category_id = c.category_id AND b.ddc = bc.ddc AND b.publisher_id = p.publisher_id AND b.book_id = " & id
                End With
                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    dr.Read()
                    txtISBN.Text = dr.Item(0)
                    txtAccession.Text = dr.Item(1)
                    txtTitle.Text = dr.Item(2)
                    cboCategory.Text = dr.Item(3)
                    cboDDC.Text = dr.Item(4)
                    cboPublisher.Text = dr.Item(5)
                    txtPubYear.Text = dr.Item(6)
                    cboAvailability.SelectedIndex = dr.Item(7) - 1
                End If

                dr.Close()

                ' author
                Dim authorList As New ArrayList

                With cmd
                    .Connection = conn
                    .CommandText = "SELECT a.name FROM tblbooks b, tblauthor a, tblbookauthor ba WHERE ba.book_id = b.book_id AND ba.author_id = a.author_id AND b.book_id =" & id
                End With

                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    While dr.Read
                        authorList.Add(dr.Item(0))
                    End While
                End If
                dr.Close()
                If authorList.Count > 1 Then
                    For i As Integer = 2 To authorList.Count
                        num.Value += 1
                    Next
                End If

                For i As Integer = 0 To cboList.Count - 1
                    Dim cbo As New ComboBox
                    cbo = cboList.Item(i)
                    cbo.Text = authorList.Item(i)
                Next

                btnSave.Enabled = True
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                dgv.Enabled = False
                cboSearch.Enabled = False

                enableFields(True)

                isUpdate = True
            ElseIf btnUpdate.Text = "Cancel" Then
                btnUpdate.Text = "Update"
                btnSave.Enabled = False
                btnAdd.Enabled = True
                btnDelete.Enabled = True
                dgv.Enabled = True
                cboSearch.Enabled = True

                enableFields(False)
                resetFields()
                isUpdate = False
            End If
        End If



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        isSaved = True

        ' check inputs
        If txtISBN.Text = "" Or txtAccession.Text = "" Or txtTitle.Text = "" Or
            cboAuthor1.Text = "" Or cboCategory.Text = "" Or
            cboDDC.Text = "" Or cboPublisher.Text = "" Or
            txtPubYear.Text = "" Or cboAvailability.Text = "" Then
            MsgBox("Please fill all fields.")
            Exit Sub
        End If

        ' check author
        Dim isValid As Boolean = True
        Dim authorList As New ArrayList
        For i As Integer = 0 To cboList.Count - 1
            Dim cbo As New ComboBox
            cbo = cboList(i)
            authorList.Add(cbo.Text)
        Next
        For i As Integer = 0 To authorList.Count - 1
            For j As Integer = 0 To authorList.Count - 1
                If authorList.Item(i) = authorList.Item(j) And Not i = j Then
                    isValid = False
                    Exit For
                End If
            Next
            If Not isValid Then
                Exit For
            End If
        Next
        If Not isValid Then
            MsgBox("There must be no same authors.")
            Exit Sub
        End If


        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        Dim categoryID As String
        Dim publisherID As String
        Dim availabilityID As String
        Dim ddcID As String
        Dim authorIDList As New ArrayList

        ' get category id
        With cmd
            .Connection = conn
            .CommandText = "Select category_id FROM tblcategory WHERE category = ?cat"
            .Parameters.AddWithValue("cat", cboCategory.Text)
        End With
        dr = cmd.ExecuteReader
        dr.Read()
        categoryID = dr.Item(0)
        dr.Close()

        ' get ddc id
        With cmd
            .Connection = conn
            .CommandText = "Select ddc FROM tblbookclassification WHERE classification = ?Class"
            .Parameters.AddWithValue("class", cboDDC.Text)
        End With
        dr = cmd.ExecuteReader
        dr.Read()
        ddcID = dr.Item(0)
        dr.Close()

        ' get pub id
        With cmd
            .Connection = conn
            .CommandText = "Select publisher_id FROM tblpublisher WHERE publisher = ?pub"
            .Parameters.AddWithValue("pub", cboPublisher.Text)
        End With
        dr = cmd.ExecuteReader
        dr.Read()
        publisherID = dr.Item(0)
        dr.Close()

        ' get availability id
        With cmd
            .Connection = conn
            .CommandText = "Select availability_id FROM tblavailability WHERE availability = ?av"
            .Parameters.AddWithValue("av", cboAvailability.Text)
        End With
        dr = cmd.ExecuteReader
        dr.Read()
        availabilityID = dr.Item(0)
        dr.Close()

        ' get author id
        For i As Integer = 0 To num.Value - 1
            Dim cbo As New ComboBox
            cbo = cboList.Item(i)

            With cmd
                .Connection = conn
                .CommandText = "Select author_id FROM tblauthor WHERE name = '" & cbo.Text & "'"
            End With
            dr = cmd.ExecuteReader
            dr.Read()
            authorIDList.Add(dr.Item(0))
            dr.Close()
        Next

        If isAdd And Not isUpdate Then

            ' save book
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO tblbooks(ISBN, title, category_id, ddc, publisher_id, pubyear, availability_id) " &
                                "VALUES(?sISBN, ?stitle, ?scat, ?sddc, ?spub, ?spuby, ?sav)"
                .Parameters.AddWithValue("sISBN", txtISBN.Text)
                .Parameters.AddWithValue("stitle", txtTitle.Text)
                .Parameters.AddWithValue("scat", categoryID)
                .Parameters.AddWithValue("sddc", ddcID)
                .Parameters.AddWithValue("spub", publisherID)
                .Parameters.AddWithValue("spuby", txtPubYear.Text)
                .Parameters.AddWithValue("sav", availabilityID)
                .ExecuteNonQuery()
            End With

            ' get last id
            Dim lastID As Integer
            With cmd
                .Connection = conn
                .CommandText = "SELECT MAX(book_id) FROM tblbooks"
            End With
            dr = cmd.ExecuteReader
            dr.Read()
            lastID = dr.Item(0)
            dr.Close()


            ' save author
            For i As Integer = 0 To authorIDList.Count - 1
                With cmd
                    .Connection = conn
                    .CommandText = "INSERT INTO tblbookauthor VALUES(" & lastID & ", " & authorIDList.Item(i) & ")"
                    .ExecuteNonQuery()
                End With
            Next

            ' save accession
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO tblbookaccession VALUES(" & txtAccession.Text & ", " & lastID & ", " & cboAvailability.SelectedIndex + 1 & ")"
                .ExecuteNonQuery()
            End With

            btnAdd.Text = "Add"
            isAdd = False
        ElseIf isUpdate And Not isAdd

            Dim id As String
            id = dgv.Item(2, dgv.CurrentRow.Index).Value
            ' save book
            With cmd
                .Connection = conn
                .CommandText = "UPDATE tblbooks SET ISBN = ?uISBN, title = ?utitle, category_id = ?ucat, ddc = ?uddc, publisher_id = ?upub, pubyear = ?upuby, availability_id = ?uav WHERE book_id = " & id
                .Parameters.AddWithValue("uISBN", txtISBN.Text)
                .Parameters.AddWithValue("utitle", txtTitle.Text)
                .Parameters.AddWithValue("ucat", categoryID)
                .Parameters.AddWithValue("uddc", ddcID)
                .Parameters.AddWithValue("upub", publisherID)
                .Parameters.AddWithValue("upuby", txtPubYear.Text)
                .Parameters.AddWithValue("uav", availabilityID)
                .ExecuteNonQuery()
            End With

            ' delete author
            With cmd
                .Connection = conn
                .CommandText = "DELETE FROM tblbookauthor WHERE book_id = " & id
                .ExecuteNonQuery()
            End With

            ' save author
            For i As Integer = 0 To authorIDList.Count - 1
                With cmd
                    .Connection = conn
                    .CommandText = "INSERT INTO tblbookauthor VALUES(" & id & ", " & authorIDList.Item(i) & ")"
                    .ExecuteNonQuery()
                End With
            Next

            ' save accession
            With cmd
                .Connection = conn
                .CommandText = "UPDATE tblbookaccession SET accession_no=" & txtAccession.Text & ", available = " & cboAvailability.SelectedIndex + 1 & " WHERE book_id = " & id
                .ExecuteNonQuery()
            End With


            btnUpdate.Text = "Update"
            isUpdate = False
        End If


        updateDGV()
        dgv.Enabled = True
        cboSearch.Enabled = True
        MsgBox("Saved")
        isSaved = False
        resetFields()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        resetFields()
        resetSearch()

        If dgv.RowCount > 0 Then
            Dim opt As MsgBoxResult = MsgBox("Are you sure you want To delete this book record?", vbYesNo + vbCritical, "Delete Book Record")
            If opt = vbYes Then

                Dim cmd As New MySqlCommand
                Dim id As String = dgv.Item(2, dgv.CurrentRow.Index).Value

                ' delete accession
                With cmd
                    .Connection = conn
                    .CommandText = "DELETE FROM tblbookaccession WHERE book_id = " & id
                    .ExecuteNonQuery()
                End With

                ' delete author
                With cmd
                    .Connection = conn
                    .CommandText = "DELETE FROM tblbookauthor WHERE book_id = " & id
                    .ExecuteNonQuery()
                End With

                ' delete book
                With cmd
                    .Connection = conn
                    .CommandText = "DELETE FROM tblbooks WHERE book_id = " & id
                    .ExecuteNonQuery()
                End With
                updateDGV()
                MsgBox("Deleted!")
            End If
        End If

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click, lblGoBack.Click
        frmMainMenu.Show()
        Me.Dispose()
    End Sub

    Private Sub btnGoBack_MouseEnter(sender As Object, e As EventArgs) Handles btnGoBack.MouseEnter, lblGoBack.MouseLeave
        btnGoBack.Image = My.Resources.backhover
    End Sub

    Private Sub btnGoBack_MouseLeave(sender As Object, e As EventArgs) Handles btnGoBack.MouseLeave, lblGoBack.MouseLeave
        btnGoBack.Image = My.Resources.back
    End Sub

    Private Sub txtAccession_Validated(sender As Object, e As EventArgs) Handles txtAccession.Validated
        If Not txtAccession.Text = "" And Not IsNumeric(txtAccession.Text) Then
            MsgBox("Accession must be number.")
            txtAccession.Focus()
            txtAccession.SelectAll()
            Exit Sub
        End If

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        With cmd
            .Connection = conn
            .CommandText = "Select accession_no FROM tblbookaccession"
        End With
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If txtAccession.Text = dr.Item(0) Then
                    MsgBox("Accession Number already exists.")
                    txtAccession.Focus()
                    txtAccession.Select()
                End If
            End While
        End If
        dr.Close()

    End Sub

    Private Sub txtTitle_Validated(sender As Object, e As EventArgs) Handles txtTitle.Validated
        txtTitle.Text = ToolZ.upperCaseFirst(txtTitle.Text)
    End Sub

    Private Sub cboSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearch.SelectedIndexChanged

        ' reset components
        cboSearchInput.Text = ""
        cboSearchInput.Items.Clear()
        updateDGV()
        If cboSearch.SelectedIndex = -1 Or cboSearch.SelectedIndex = 0 Then
            cboSearchInput.Enabled = False
            Exit Sub
        End If
        cboSearchInput.Enabled = True

        Select Case cboSearch.SelectedIndex
            Case 1
                ' ISBN
                updateSearchInput("SELECT ISBN FROM tblbooks")
            Case 2
                ' Accession
                updateSearchInput("SELECT accession_no FROM tblbookaccession")
            Case 3
                ' title
                updateSearchInput("SELECT title FROM tblbooks")
            Case 4
                ' availability
                cboSearchInput.DropDownStyle = ComboBoxStyle.DropDownList
                cboSearchInput.FlatStyle = FlatStyle.Flat
                cboSearchInput.Items.Clear()
                cboSearchInput.Items.Add("Can be borrowed")
                cboSearchInput.Items.Add("Library Only")
        End Select
    End Sub

    Private Sub cboSearchInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchInput.SelectedIndexChanged, cboSearchInput.TextChanged
        If cboSearchInput.SelectedIndex = -1 And cboSearchInput.Text = "" Then
            updateDGV()
            Exit Sub
        End If

        Select Case cboSearch.SelectedIndex
            Case 1
                ' ISBN
                updateDGV("SELECT b.ISBN, ba.accession_no, b.book_id, b.title, GROUP_CONCAT(a.name SEPARATOR ', '), c.category, bc.classification, p.publisher, b.pubyear, av.availability FROM tblbookaccession ba, tblbooks b, tblcategory c, tblbookclassification bc, tblpublisher p, tblavailability av, tblauthor a, tblbookauthor bau WHERE ba.book_id = b.book_id AND b.category_id = c.category_id AND b.ddc = bc.ddc AND b.publisher_id = p.publisher_id AND b.availability_id = av.availability_id AND b.book_id = bau.book_id AND a.author_id = bau.author_id AND b.ISBN = '" & cboSearchInput.Text & "' GROUP BY b.book_id ")
            Case 2
                ' Accession 
                updateDGV("SELECT b.ISBN, ba.accession_no, b.book_id, b.title, GROUP_CONCAT(a.name SEPARATOR ', '), c.category, bc.classification, p.publisher, b.pubyear, av.availability FROM tblbookaccession ba, tblbooks b, tblcategory c, tblbookclassification bc, tblpublisher p, tblavailability av, tblauthor a, tblbookauthor bau WHERE ba.book_id = b.book_id AND b.category_id = c.category_id AND b.ddc = bc.ddc AND b.publisher_id = p.publisher_id AND b.availability_id = av.availability_id AND b.book_id = bau.book_id AND a.author_id = bau.author_id AND ba.accession_no = " & cboSearchInput.Text & " GROUP BY b.book_id ")
            Case 3
                ' title
                updateDGV("SELECT b.ISBN, ba.accession_no, b.book_id, b.title, GROUP_CONCAT(a.name SEPARATOR ', '), c.category, bc.classification, p.publisher, b.pubyear, av.availability FROM tblbookaccession ba, tblbooks b, tblcategory c, tblbookclassification bc, tblpublisher p, tblavailability av, tblauthor a, tblbookauthor bau WHERE ba.book_id = b.book_id AND b.category_id = c.category_id AND b.ddc = bc.ddc AND b.publisher_id = p.publisher_id AND b.availability_id = av.availability_id AND b.book_id = bau.book_id AND a.author_id = bau.author_id AND b.title = '" & cboSearchInput.Text & "' GROUP BY b.book_id ")
            Case 4
                ' availability
                updateDGV("SELECT b.ISBN, ba.accession_no, b.book_id, b.title, GROUP_CONCAT(a.name SEPARATOR ', '), c.category, bc.classification, p.publisher, b.pubyear, av.availability FROM tblbookaccession ba, tblbooks b, tblcategory c, tblbookclassification bc, tblpublisher p, tblavailability av, tblauthor a, tblbookauthor bau WHERE ba.book_id = b.book_id AND b.category_id = c.category_id AND b.ddc = bc.ddc AND b.publisher_id = p.publisher_id AND b.availability_id = av.availability_id AND b.book_id = bau.book_id AND a.author_id = bau.author_id AND av.availability = '" & cboSearchInput.Text & "' GROUP BY b.book_id ")
        End Select
    End Sub

End Class