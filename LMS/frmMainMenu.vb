Public Class frmMainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    ' click events
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click, lblSignOut.Click
        Dim opt As MsgBoxResult = MsgBox("Are you sure you want to Sign Out?", vbQuestion + vbYesNo, "Sign Out")
        If opt = vbYes Then
            Me.Dispose()
            frmLogin.Show()
        End If
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click, lblTransactions.Click
        frmTransaction.Show()
        Me.Hide()
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click, lblBooks.Click
        frmBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click, lblStudents.Click
        frmStudent.Show()
        Me.Hide()
    End Sub
    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click, lblFaculty.Click
        frmFaculty.Show()
        Me.Hide()
    End Sub

    ' mouse enter and leave events
    Private Sub btnSignOut_MouseEnter(sender As Object, e As EventArgs) Handles btnSignOut.MouseEnter, lblSignOut.MouseEnter
        btnSignOut.Image = My.Resources.signouthover
    End Sub

    Private Sub btnSignOut_MouseLeave(sender As Object, e As EventArgs) Handles btnSignOut.MouseLeave, lblSignOut.MouseLeave
        btnSignOut.Image = My.Resources.signoutwhite
    End Sub

    Private Sub btnTransactions_MouseEnter(sender As Object, e As EventArgs) Handles btnTransactions.MouseEnter, lblTransactions.MouseEnter
        btnTransactions.BackColor = Color.FromArgb(231, 76, 60)
        lblTransactions.BackColor = Color.FromArgb(231, 76, 60)
    End Sub

    Private Sub btnTransactions_MouseLeave(sender As Object, e As EventArgs) Handles btnTransactions.MouseLeave, lblTransactions.MouseLeave
        btnTransactions.BackColor = Color.FromArgb(192, 57, 43)
        lblTransactions.BackColor = Color.FromArgb(192, 57, 43)
    End Sub

    Private Sub btnBooks_MouseEnter(sender As Object, e As EventArgs) Handles btnBooks.MouseEnter, lblBooks.MouseEnter
        btnBooks.BackColor = Color.FromArgb(46, 204, 113)
        lblBooks.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub btnBooks_MouseLeave(sender As Object, e As EventArgs) Handles btnBooks.MouseLeave, lblBooks.MouseLeave
        btnBooks.BackColor = Color.FromArgb(39, 174, 96)
        lblBooks.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub btnStudents_MouseEnter(sender As Object, e As EventArgs) Handles btnStudents.MouseEnter, lblStudents.MouseEnter
        btnStudents.BackColor = Color.FromArgb(52, 152, 219)
        lblStudents.BackColor = Color.FromArgb(52, 152, 219)
    End Sub

    Private Sub btnStudents_MouseLeave(sender As Object, e As EventArgs) Handles btnStudents.MouseLeave, lblStudents.MouseLeave
        btnStudents.BackColor = Color.FromArgb(41, 128, 185)
        lblStudents.BackColor = Color.FromArgb(41, 128, 185)
    End Sub

    Private Sub btnFaculties_MouseEnter(sender As Object, e As EventArgs) Handles btnFaculty.MouseEnter, lblFaculty.MouseEnter
        btnFaculty.BackColor = Color.FromArgb(155, 89, 182)
        lblFaculty.BackColor = Color.FromArgb(155, 89, 182)
    End Sub

    Private Sub btnFaculties_MouseLeave(sender As Object, e As EventArgs) Handles btnFaculty.MouseLeave, lblFaculty.MouseLeave
        btnFaculty.BackColor = Color.FromArgb(142, 68, 173)
        lblFaculty.BackColor = Color.FromArgb(142, 68, 173)
    End Sub

    Private Sub btnUtilities_MouseEnter(sender As Object, e As EventArgs) Handles btnUtilities.MouseEnter, lblUtilities.MouseEnter
        btnUtilities.BackColor = Color.FromArgb(243, 156, 18)
        lblUtilities.BackColor = Color.FromArgb(243, 156, 18)
    End Sub

    Private Sub btnUtilities_MouseLeave(sender As Object, e As EventArgs) Handles btnUtilities.MouseLeave, lblUtilities.MouseLeave
        btnUtilities.BackColor = Color.FromArgb(230, 126, 34)
        lblUtilities.BackColor = Color.FromArgb(230, 126, 34)
    End Sub

    Private Sub btnUtilities_Click(sender As Object, e As EventArgs) Handles btnUtilities.Click
        frmUtilities.Show()
        Me.Hide()
    End Sub
End Class