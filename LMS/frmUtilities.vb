Public Class frmUtilities

    Dim dueday As Integer
    Dim bookSLimit As Integer
    Dim bookFLimit As Integer

    Dim isSaved As Boolean

    Private Sub frmUtilities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dueday = My.Settings.DueDays
        bookSLimit = My.Settings.SBookLimit
        bookFLimit = My.Settings.FBookLimit

        lblDue.Text = dueday
        lblSLimit.Text = bookSLimit
        lblFLimit.Text = bookFLimit
        isSaved = True
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click, lblMainMenu.Click
        If Not isSaved Then
            Dim opt As MsgBoxResult = MsgBox("Any unsaved changes will be lost. " & vbNewLine & "Do you want to save the changes you've made?", vbYesNo + vbQuestion, "Save")
            If opt = vbYes Then
                btnSave_Click(sender, e)
            End If
        End If

        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click, lblSave.Click
        My.Settings.DueDays = dueday
        My.Settings.SBookLimit = bookSLimit
        My.Settings.FBookLimit = bookFLimit
        isSaved = True
        MsgBox("Saved!")
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click, lblBorrow.Click
        frmBorrow.Show()
        Me.Hide()
    End Sub


    ' enter and leave events
    Private Sub btnMainMenu_MouseEnter(sender As Object, e As EventArgs) Handles btnMainMenu.MouseEnter, lblMainMenu.MouseEnter
        btnMainMenu.Image = My.Resources.mainmenuhover
    End Sub

    Private Sub btnMainMenu_MouseLeave(sender As Object, e As EventArgs) Handles btnMainMenu.MouseLeave, lblMainMenu.MouseLeave
        btnMainMenu.Image = My.Resources.mainmenu
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles btnSave.MouseEnter, lblSave.MouseEnter
        btnSave.Image = My.Resources.save_btn
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave, lblSave.MouseLeave
        btnSave.Image = My.Resources.save_btn_small
    End Sub

    Private Sub btnBorrow_MouseEnter(sender As Object, e As EventArgs) Handles btnBorrow.MouseEnter, lblBorrow.MouseEnter
        btnBorrow.BackColor = Color.FromArgb(26, 188, 156)
        lblBorrow.BackColor = Color.FromArgb(26, 188, 156)
    End Sub

    Private Sub btnBorrow_MouseLeave(sender As Object, e As EventArgs) Handles btnBorrow.MouseLeave, lblBorrow.MouseLeave
        btnBorrow.BackColor = Color.FromArgb(22, 160, 133)
        lblBorrow.BackColor = Color.FromArgb(22, 160, 133)
    End Sub

    ' Student Due Days

    Private Sub lblDueDays_MouseEnter(sender As Object, e As EventArgs) Handles lblDueDays.MouseEnter, panDueDays.MouseEnter, lblDue.MouseEnter
        panDueDays.BackColor = Color.FromArgb(243, 156, 18)
        lblDueDays.BackColor = Color.FromArgb(243, 156, 18)
    End Sub

    Private Sub lblDueDays_MouseLeave(sender As Object, e As EventArgs) Handles lblDueDays.MouseLeave, panDueDays.MouseLeave, lblDue.MouseLeave
        panDueDays.BackColor = Color.FromArgb(230, 126, 34)
        lblDueDays.BackColor = Color.FromArgb(230, 126, 34)
    End Sub

    Private Sub btnUpDue_MouseEnter(sender As Object, e As EventArgs) Handles btnUpDue.MouseEnter
        lblDueDays_MouseEnter(sender, e)
        btnUpDue.Image = My.Resources.arrow_up
    End Sub

    Private Sub btnUpDue_MouseLeave(sender As Object, e As EventArgs) Handles btnUpDue.MouseLeave
        lblDueDays_MouseLeave(sender, e)
        btnUpDue.Image = My.Resources.arrow_up_small
    End Sub

    Private Sub btnDownDue_MouseEnter(sender As Object, e As EventArgs) Handles btnDownDue.MouseEnter
        lblDueDays_MouseEnter(sender, e)
        btnDownDue.Image = My.Resources.arrow_down
    End Sub

    Private Sub btnDownDue_MouseLeave(sender As Object, e As EventArgs) Handles btnDownDue.MouseLeave
        lblDueDays_MouseLeave(sender, e)
        btnDownDue.Image = My.Resources.arrow_down_small
    End Sub

    Private Sub btnUpDue_Click(sender As Object, e As EventArgs) Handles btnUpDue.Click
        dueday += 1
        If dueday > 99 Then
            dueday = 99
        End If
        lblDue.Text = dueday
        isSaved = False
    End Sub

    Private Sub btnDownDue_Click(sender As Object, e As EventArgs) Handles btnDownDue.Click
        dueday -= 1
        If dueday < 1 Then
            dueday = 1
        End If
        lblDue.Text = dueday
        isSaved = False
    End Sub


    ' Student Book Limit
    Private Sub lblStudentBookLimit_MouseEnter(sender As Object, e As EventArgs) Handles lblStudentBookLimit.MouseEnter, panBookSLimit.MouseEnter, lblSLimit.MouseEnter
        panBookSLimit.BackColor = Color.FromArgb(231, 76, 60)
        lblStudentBookLimit.BackColor = Color.FromArgb(231, 76, 60)
    End Sub

    Private Sub lblStudentBookLimit_MouseLeave(sender As Object, e As EventArgs) Handles lblStudentBookLimit.MouseLeave, panBookSLimit.MouseLeave, lblSLimit.MouseLeave
        panBookSLimit.BackColor = Color.FromArgb(192, 57, 43)
        lblStudentBookLimit.BackColor = Color.FromArgb(192, 57, 43)
    End Sub

    Private Sub btnUpSLimit_MouseEnter(sender As Object, e As EventArgs) Handles btnUpSLimit.MouseEnter
        lblStudentBookLimit_MouseEnter(sender, e)
        btnUpSLimit.Image = My.Resources.arrow_up
    End Sub

    Private Sub btnUpSLimit_MouseLeave(sender As Object, e As EventArgs) Handles btnUpSLimit.MouseLeave
        lblStudentBookLimit_MouseLeave(sender, e)
        btnUpSLimit.Image = My.Resources.arrow_up_small
    End Sub

    Private Sub btnDownSLimit_MouseEnter(sender As Object, e As EventArgs) Handles btnDownSLimit.MouseEnter
        lblStudentBookLimit_MouseEnter(sender, e)
        btnDownSLimit.Image = My.Resources.arrow_down
    End Sub

    Private Sub btnDownSLimit_MouseLeave(sender As Object, e As EventArgs) Handles btnDownSLimit.MouseLeave
        lblStudentBookLimit_MouseLeave(sender, e)
        btnDownSLimit.Image = My.Resources.arrow_down_small
    End Sub

    Private Sub btnUpSLimit_Click(sender As Object, e As EventArgs) Handles btnUpSLimit.Click
        bookSLimit += 1
        If bookSLimit > 99 Then
            bookSLimit = 99
        End If
        lblSLimit.Text = bookSLimit
        isSaved = False
    End Sub

    Private Sub btnDownSLimit_Click(sender As Object, e As EventArgs) Handles btnDownSLimit.Click
        bookSLimit -= 1
        If bookSLimit < 1 Then
            bookSLimit = 1
        End If
        lblSLimit.Text = bookSLimit
        isSaved = False
    End Sub


    ' Faculty Book Limit
    Private Sub lblFacultyBookLimit_MouseEnter(sender As Object, e As EventArgs) Handles lblFacultyBookLimit.MouseEnter, panBookFLimit.MouseEnter, lblFLimit.MouseEnter
        panBookFLimit.BackColor = Color.FromArgb(155, 89, 182)
        lblFacultyBookLimit.BackColor = Color.FromArgb(155, 89, 182)
    End Sub

    Private Sub lblFacultyBookLimit_MouseLeave(sender As Object, e As EventArgs) Handles lblFacultyBookLimit.MouseLeave, panBookFLimit.MouseLeave, lblFLimit.MouseLeave
        panBookFLimit.BackColor = Color.FromArgb(142, 68, 173)
        lblFacultyBookLimit.BackColor = Color.FromArgb(142, 68, 173)
    End Sub

    Private Sub btnUpFLimit_MouseEnter(sender As Object, e As EventArgs) Handles btnUpFLimit.MouseEnter
        lblFacultyBookLimit_MouseEnter(sender, e)
        btnUpFLimit.Image = My.Resources.arrow_up
    End Sub

    Private Sub btnUpFLimit_MouseLeave(sender As Object, e As EventArgs) Handles btnUpFLimit.MouseLeave
        lblFacultyBookLimit_MouseLeave(sender, e)
        btnUpFLimit.Image = My.Resources.arrow_up_small
    End Sub

    Private Sub btnDownFLimit_MouseEnter(sender As Object, e As EventArgs) Handles btnDownFLimit.MouseEnter
        lblFacultyBookLimit_MouseEnter(sender, e)
        btnDownFLimit.Image = My.Resources.arrow_down
    End Sub

    Private Sub btnDownFLimit_MouseLeave(sender As Object, e As EventArgs) Handles btnDownFLimit.MouseLeave
        lblFacultyBookLimit_MouseLeave(sender, e)
        btnDownFLimit.Image = My.Resources.arrow_down_small
    End Sub

    Private Sub btnUpFLimit_Click(sender As Object, e As EventArgs) Handles btnUpFLimit.Click
        bookFLimit += 1
        If bookFLimit > 99 Then
            bookFLimit = 99
        End If
        lblFLimit.Text = bookFLimit
        isSaved = False
    End Sub

    Private Sub btnDownFLimit_Click(sender As Object, e As EventArgs) Handles btnDownFLimit.Click
        bookFLimit -= 1
        If bookFLimit < 1 Then
            bookFLimit = 1
        End If
        lblFLimit.Text = bookFLimit
        isSaved = False
    End Sub

End Class