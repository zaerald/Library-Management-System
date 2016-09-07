Imports MySql.Data.MySqlClient

Public Class frmFaculty

    Dim conn As New MySqlConnection

    Dim currentID As String
    Dim isUpdate As Boolean
    Dim isAdd As Boolean

    Private Sub updateDGV()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        With cmd
            .Connection = conn
            .CommandText = "SELECT * FROM tblfaculty"
        End With
        dr = cmd.ExecuteReader

        ' populate dgv
        Dim columns() As String = {"ID", "First Name", "Last Name", "Gender"}
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
        Dim columns() As String = {"ID", "First Name", "Last Name", "Gender"}
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

    Private Sub clearFields()
        txtFacultyID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboGender.SelectedIndex = -1
        cboGender.Text = ""
    End Sub

    Private Sub enableFields(ByVal b As Boolean)
        txtFacultyID.Enabled = b
        txtFirstName.Enabled = b
        txtLastName.Enabled = b
        cboGender.Enabled = b
    End Sub

    Private Sub frmFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = ToolZ.getConnection()

        updateDGV()
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

        ' reset ocmponents
        cboSearchInput.Text = ""
        cboSearchInput.Items.Clear()
        updateDGV()
        If cboSearch.SelectedIndex = -1 Then
            cboSearchInput.Enabled = False
            Exit Sub
        End If
        cboSearchInput.Enabled = True
        Select Case cboSearch.SelectedIndex
            Case 1
                ' id
                updateSearchInput("SELECT facid FROM tblfaculty")
            Case 2
                ' first name
                updateSearchInput("SELECT firstname FROM tblfaculty")
            Case 3
                ' last name
                updateSearchInput("SELECT lastname FROM tblfaculty")
            Case 4
                ' gender
                cboSearchInput.DropDownStyle = ComboBoxStyle.DropDownList
                cboSearchInput.FlatStyle = FlatStyle.Flat
                cboSearchInput.Items.Clear()
                cboSearchInput.Items.Add("Male")
                cboSearchInput.Items.Add("Female")
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
                updateDGV("SELECT * FROM tblfaculty WHERE facid='" & cboSearchInput.Text & "'")
            Case 1
                ' first name
                updateDGV("SELECT * FROM tblfaculty WHERE firstname='" & cboSearchInput.Text & "'")
            Case 2
                ' last name
                updateDGV("SELECT * FROM tblfaculty WHERE lastname='" & cboSearchInput.Text & "'")
            Case 3
                ' gender
                updateDGV("SELECT * FROM tblfaculty WHERE gender='" & cboSearchInput.Text & "'")
        End Select
    End Sub

    Private Sub txtFacultyID_Enter(sender As Object, e As EventArgs) Handles txtFacultyID.Enter
        txtFacultyID.SelectAll()
    End Sub

    Private Sub txtFirstName_Enter(sender As Object, e As EventArgs) Handles txtFirstName.Enter
        txtFirstName.SelectAll()
    End Sub

    Private Sub txtLastName_Enter(sender As Object, e As EventArgs) Handles txtLastName.Enter
        txtLastName.SelectAll()
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' validate
        If txtFacultyID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or
            cboGender.SelectedIndex = -1 Then
            MsgBox("Please fill up all fields")
            Exit Sub
        End If

        Dim cmd As New MySqlCommand

        ' save and update
        With cmd
            .Connection = conn
            If isUpdate And Not isAdd Then
                .CommandText = "UPDATE tblfaculty set facid=?id, firstname=?fn, lastname=?ln, gender=?g WHERE facid=?curid"
                .Parameters.AddWithValue("curid", currentID)
            ElseIf isAdd And Not isUpdate
                .CommandText = "INSERT INTO tblfaculty VALUES(?id, ?fn, ?ln, ?g)"
            End If

            .Parameters.AddWithValue("id", txtFacultyID.Text)
            .Parameters.AddWithValue("fn", txtFirstName.Text)
            .Parameters.AddWithValue("ln", txtLastName.Text)
            .Parameters.AddWithValue("g", cboGender.Text)
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

    Private Sub txtFacultyID_Validated(sender As Object, e As EventArgs) Handles txtFacultyID.Validated

        If Not txtFacultyID.Text = "" Then
            ' check if id is in valid format

            If Not txtFacultyID.Text.Length = 8 Or Not IsNumeric(txtFacultyID.Text) Then
                MsgBox("Faculty ID is not a valid format (xxxxxxxx)")
                txtFacultyID.Focus()
                txtFacultyID.SelectAll()
            End If

            ' check if id already exists
            Dim c As New MySqlCommand
            Dim dr As MySqlDataReader
            currentID = dgv.Item(0, dgv.CurrentRow.Index).Value

            Dim doesExists As Boolean = False
            With c
                .Connection = conn
                .CommandText = "SELECT facid FROM tblfaculty"
            End With
            dr = c.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If isUpdate Then
                        If dr.Item(0) = txtFacultyID.Text And Not txtFacultyID.Text = currentID Then
                            doesExists = True
                        End If
                    Else
                        If dr.Item(0) = txtFacultyID.Text Then
                            doesExists = True
                        End If
                    End If

                End While
            End If
            dr.Close()
            If doesExists Then
                MsgBox("Faculty ID already exists!")
                txtFacultyID.Focus()
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        clearFields()
        resetSearch()

        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Cancel"

            Dim index As Integer = dgv.CurrentRow.Index

            txtFacultyID.Text = dgv.Item(0, index).Value
            txtFirstName.Text = dgv.Item(1, index).Value
            txtLastName.Text = dgv.Item(2, index).Value
            cboGender.Text = dgv.Item(3, index).Value

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

        Dim opt As MsgBoxResult = MsgBox("Are you sure you want to delete this faculty?", vbYesNo + vbQuestion, "Delete")
        If opt = vbYes Then
            Dim cmd As New MySqlCommand

            currentID = dgv.Item(0, dgv.CurrentRow.Index).Value

            With cmd
                .Connection = conn
                .CommandText = "DELETE FROM tblfaculty WHERE facid='" & currentID & "'"
                .ExecuteNonQuery()
            End With
            updateDGV()
            MsgBox("Faculty deleted successfully.")
        End If
    End Sub
End Class