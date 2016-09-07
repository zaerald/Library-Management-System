Imports MySql.Data.MySqlClient

Public Class frmStudent

    Dim conn As New MySqlConnection

    Dim currentID As String

    Dim isAdd As Boolean
    Dim isUpdate As Boolean

    Private Sub updateDGV()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        With cmd
            .Connection = conn
            .CommandText = "SELECT s.studid, s.firstname, s.lastname, s.gender, ss.description, s.address FROM tblstudent s, tblstudentsection ss WHERE s.section_id = ss.section_id"
        End With
        dr = cmd.ExecuteReader

        ' populate dgv
        Dim columns() As String = {"ID", "First Name", "Last Name", "Gender", "Section", "Address"}
        ToolZ.updateDataGridView(dgv, dr, columns)
        dr.Close()
    End Sub

    Private Sub updateDGV(ByVal command As String)
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        With cmd
            .Connection = conn
            .CommandText = command
        End With
        dr = cmd.ExecuteReader

        ' populate dgv
        Dim columns() As String = {"ID", "First Name", "Last Name", "Gender", "Section", "Address"}
        ToolZ.updateDataGridView(dgv, dr, columns)
        dr.Close()
    End Sub

    Private Sub updateSectionCombo()

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        With cmd
            .Connection = conn
            .CommandText = "SELECT description FROM tblstudentsection"
        End With
        dr = cmd.ExecuteReader

        cboSection.Items.Clear()
        cboSection.AutoCompleteCustomSource.Clear()
        If dr.HasRows Then
            While dr.Read
                cboSection.Items.Add(dr.Item(0))
                cboSection.AutoCompleteCustomSource.Add(dr.Item(0))
            End While
        End If
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

    Private Sub clearFields()
        txtStudentID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboGender.SelectedIndex = -1
        cboSection.Text = ""
        cboSection.SelectedIndex = -1
        txtAddress.Text = ""
    End Sub

    Private Sub enableFields(ByVal b As Boolean)
        txtStudentID.Enabled = b
        txtFirstName.Enabled = b
        txtLastName.Enabled = b
        cboGender.Enabled = b
        cboSection.Enabled = b
        txtAddress.Enabled = b
    End Sub

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = ToolZ.getConnection()

        updateDGV()
        updateSectionCombo()

        enableFields(False)
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click, lblGoBack.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnGoBack_MouseEnter(sender As Object, e As EventArgs) Handles btnGoBack.MouseEnter, lblGoBack.MouseEnter
        btnGoBack.Image = My.Resources.backhover
    End Sub

    Private Sub btnGoBack_MouseLeave(sender As Object, e As EventArgs) Handles btnGoBack.MouseLeave, lblGoBack.MouseLeave
        btnGoBack.Image = My.Resources.back
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

    Private Sub dgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEnter, dgv.CellDoubleClick

        Dim index As Integer = dgv.CurrentRow.Index
        dgv.Rows(index).Selected = True

        enableFields(False)
        btnSave.Enabled = False
        btnClear.Enabled = False
        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
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
                ' id
                updateSearchInput("SELECT studid FROM tblstudent")
            Case 2
                ' first name
                updateSearchInput("SELECT firstname FROM tblstudent")
            Case 3
                ' last name
                updateSearchInput("SELECT lastname FROM tblstudent")
            Case 4
                ' gender
                cboSearchInput.DropDownStyle = ComboBoxStyle.DropDownList
                cboSearchInput.FlatStyle = FlatStyle.Flat
                cboSearchInput.Items.Clear()
                cboSearchInput.Items.Add("Male")
                cboSearchInput.Items.Add("Female")
            Case 5
                ' section
                updateSearchInput("SELECT description FROM tblstudentsection")
        End Select
    End Sub

    Private Sub cboSearchInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchInput.SelectedIndexChanged, cboSearchInput.TextChanged
        If cboSearchInput.SelectedIndex = -1 And cboSearchInput.Text = "" Then
            updateDGV()
            Exit Sub
        End If

        Select Case cboSearch.SelectedIndex
            Case 0
                ' id
                updateDGV("SELECT s.studid, s.firstname, s.lastname, s.gender, ss.description, s.address FROM tblstudent s, tblstudentsection ss WHERE s.section_id = ss.section_id AND s.studid = '" & cboSearchInput.Text & "'")
            Case 1
                ' first name
                updateDGV("SELECT s.studid, s.firstname, s.lastname, s.gender, ss.description, s.address FROM tblstudent s, tblstudentsection ss WHERE s.section_id = ss.section_id AND s.firstname = '" & cboSearchInput.Text & "'")
            Case 2
                ' last name
                updateDGV("SELECT s.studid, s.firstname, s.lastname, s.gender, ss.description, s.address FROM tblstudent s, tblstudentsection ss WHERE s.section_id = ss.section_id AND s.lastname = '" & cboSearchInput.Text & "'")
            Case 3
                ' gender
                updateDGV("SELECT s.studid, s.firstname, s.lastname, s.gender, ss.description, s.address FROM tblstudent s, tblstudentsection ss WHERE s.section_id = ss.section_id AND s.gender = '" & cboSearchInput.Text & "'")
            Case 4
                ' section
                updateDGV("SELECT s.studid, s.firstname, s.lastname, s.gender, ss.description, s.address FROM tblstudent s, tblstudentsection ss WHERE s.section_id = ss.section_id AND ss.description = '" & cboSearchInput.Text & "'")
        End Select
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        clearFields()
        resetSearch()

        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Cancel"

            btnSave.Enabled = True
            btnClear.Enabled = True
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            enableFields(True)
            dgv.Enabled = False
            isAdd = True
        ElseIf btnAdd.Text = "Cancel"
            btnAdd.Text = "Add"

            btnSave.Enabled = False
            btnClear.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            enableFields(False)
            dgv.Enabled = True
            isAdd = False
        End If
    End Sub

    Private Sub txtStudentID_Enter(sender As Object, e As EventArgs) Handles txtStudentID.Enter
        txtStudentID.SelectAll()
    End Sub

    Private Sub txtFirstName_Enter(sender As Object, e As EventArgs) Handles txtFirstName.Enter, txtAddress.Enter
        txtFirstName.SelectAll()
    End Sub

    Private Sub txtLastName_Enter(sender As Object, e As EventArgs) Handles txtLastName.Enter
        txtLastName.SelectAll()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        clearFields()
        resetSearch()

        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Cancel"

            Dim index As Integer = dgv.CurrentRow.Index

            txtStudentID.Text = dgv.Item(0, index).Value
            txtFirstName.Text = dgv.Item(1, index).Value
            txtLastName.Text = dgv.Item(2, index).Value
            cboGender.Text = dgv.Item(3, index).Value
            cboSection.Text = dgv.Item(4, index).Value
            txtAddress.Text = dgv.Item(5, index).Value

            currentID = dgv.Item(0, index).Value

            enableFields(True)
            btnClear.Enabled = False
            btnSave.Enabled = True
            btnAdd.Enabled = False
            btnDelete.Enabled = False
            dgv.Enabled = False


            isUpdate = True
        ElseIf btnUpdate.Text = "Cancel"
            btnUpdate.Text = "Update"

            enableFields(False)
            btnClear.Enabled = False
            btnSave.Enabled = False
            btnAdd.Enabled = True
            btnDelete.Enabled = True
            dgv.Enabled = True
            isUpdate = False
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        resetSearch()

        Dim opt As MsgBoxResult = MsgBox("Are you sure you want to delete this student?", vbYesNo + vbQuestion, "Delete")
        If opt = vbYes Then
            Dim cmd As New MySqlCommand

            currentID = dgv.Item(0, dgv.CurrentRow.Index).Value

            With cmd
                .Connection = conn
                .CommandText = "DELETE FROM tblstudent WHERE studid='" & currentID & "'"
                .ExecuteNonQuery()
            End With
            updateDGV()
            MsgBox("Student deleted successfully.")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' validate
        If txtStudentID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or
            cboGender.SelectedIndex = -1 Or cboSection.SelectedIndex = -1 Or txtAddress.Text = "" Then
            MsgBox("Please fill up all fields")
            Exit Sub
        End If

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        'get id of section

        Dim sectionID As Integer
        With cmd
            .Connection = conn
            .CommandText = "SELECT section_id FROM tblstudentsection WHERE description = '" & cboSection.Text & "'"
        End With
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            sectionID = dr.Item(0)
        End If

        dr.Close()
        ' save and update
        With cmd
            .Connection = conn
            If isUpdate And Not isAdd Then
                .CommandText = "UPDATE tblstudent set studid=?id, firstname=?fn, lastname=?ln, gender=?g, section_id=?sid, address=?add WHERE studid=?curid"
                .Parameters.AddWithValue("curid", currentID)
            ElseIf isAdd And Not isUpdate
                .CommandText = "INSERT INTO tblstudent VALUES(?id, ?fn, ?ln, ?g, ?sid, ?add)"
            End If

            .Parameters.AddWithValue("id", txtStudentID.Text)
            .Parameters.AddWithValue("fn", txtFirstName.Text)
            .Parameters.AddWithValue("ln", txtLastName.Text)
            .Parameters.AddWithValue("g", cboGender.Text)
            .Parameters.AddWithValue("sid", sectionID)
            .Parameters.AddWithValue("add", txtAddress.Text)
            .ExecuteNonQuery()
        End With

        updateDGV()
        clearFields()
        dgv.Enabled = True

        btnSave.Enabled = False
        btnClear.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnAdd.Text = "Add"
        btnUpdate.Text = "Update"
        isUpdate = False
        isAdd = False

        MsgBox("Success!")
    End Sub

    Private Sub txtFirstName_Validated(sender As Object, e As EventArgs) Handles txtFirstName.Validated
        txtFirstName.Text = ToolZ.upperCaseFirst(txtFirstName.Text)
    End Sub

    Private Sub txtLastName_Validated(sender As Object, e As EventArgs) Handles txtLastName.Validated
        txtLastName.Text = ToolZ.upperCaseFirst(txtLastName.Text)
    End Sub

    Private Sub cboSection_Validated(sender As Object, e As EventArgs) Handles cboSection.Validated

        If Not cboSection.Text = "" And cboSection.SelectedIndex = -1 Then

            Dim opt As MsgBoxResult = MsgBox(cboSection.Text & " is not on the list." & Environment.NewLine & "Do you want to add it on the list?", vbYesNo + vbQuestion)
            If opt = vbYes Then
                Dim selected As String = ToolZ.upperCaseFirst(cboSection.Text)
                Dim cmd As New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = "INSERT INTO tblstudentsection(description) VALUES(?des)"
                    .Parameters.AddWithValue("des", selected)
                    .ExecuteNonQuery()
                End With
                updateSectionCombo()
                cboSection.Text = selected
            ElseIf opt = vbNo
                cboSection.Focus()
                cboSection.SelectAll()
            End If
        End If

    End Sub

    Private Sub txtStudentID_Validated(sender As Object, e As EventArgs) Handles txtStudentID.Validated

        If Not txtStudentID.Text = "" Then
            ' check if id is in valid format
            Dim isValid As Boolean = True
            If txtStudentID.Text.Length = 10 Then
                If Not IsNumeric(txtStudentID.Text.Substring(0, 7)) Or
                    Not IsNumeric(txtStudentID.Text.Substring(8, 2)) Or
                    Not txtStudentID.Text.Substring(7, 1) = "-" Then
                    isValid = False
                End If
            Else
                isValid = False
            End If

            If Not isValid Then
                MsgBox("Student ID is not a valid format (xxxxxxx-xx)")
                txtStudentID.Focus()
                txtStudentID.SelectAll()
            End If

            ' check if id already exists
            Dim c As New MySqlCommand
            Dim dr As MySqlDataReader
            currentID = dgv.Item(0, dgv.CurrentRow.Index).Value

            Dim doesExists As Boolean = False
            With c
                .Connection = conn
                .CommandText = "SELECT studid FROM tblstudent"
            End With
            dr = c.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If isUpdate Then
                        If dr.Item(0) = txtStudentID.Text And Not txtStudentID.Text = currentID Then
                            doesExists = True
                        End If
                    Else
                        If dr.Item(0) = txtStudentID.Text Then
                            doesExists = True
                        End If
                    End If

                End While
            End If
            dr.Close()
            If doesExists Then
                MsgBox("Student ID already exists!")
                txtStudentID.Focus()
                Exit Sub
            End If
        End If

    End Sub

End Class