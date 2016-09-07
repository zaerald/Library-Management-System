Public Class frmTransaction
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click, lblMainMenu.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click, lblBorrow.Click
        frmBorrow.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click, lblReturn.Click
        frmReturn.Show()
        Me.Hide()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click, lblReport.Click
        frmBookReport.Show()
        Me.Hide()
    End Sub

    ' enter and leave events
    Private Sub btnMainMenu_MouseEnter(sender As Object, e As EventArgs) Handles btnMainMenu.MouseEnter, lblMainMenu.MouseEnter
        btnMainMenu.Image = My.Resources.mainmenuhover
    End Sub

    Private Sub btnMainMenu_MouseLeave(sender As Object, e As EventArgs) Handles btnMainMenu.MouseLeave, lblMainMenu.MouseLeave
        btnMainMenu.Image = My.Resources.mainmenu
    End Sub

    Private Sub btnBorrow_MouseEnter(sender As Object, e As EventArgs) Handles btnBorrow.MouseEnter, lblBorrow.MouseEnter
        btnBorrow.BackColor = Color.FromArgb(52, 152, 219)
        lblBorrow.BackColor = Color.FromArgb(52, 152, 219)
    End Sub

    Private Sub btnBorrow_MouseLeave(sender As Object, e As EventArgs) Handles btnBorrow.MouseLeave, lblBorrow.MouseLeave
        btnBorrow.BackColor = Color.FromArgb(41, 128, 185)
        lblBorrow.BackColor = Color.FromArgb(41, 128, 185)
    End Sub

    Private Sub btnReturn_MouseEnter(sender As Object, e As EventArgs) Handles btnReturn.MouseEnter, lblReturn.MouseEnter
        btnReturn.BackColor = Color.FromArgb(46, 204, 113)
        lblReturn.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub btnReturn_MouseLeave(sender As Object, e As EventArgs) Handles btnReturn.MouseLeave, lblReturn.MouseLeave
        btnReturn.BackColor = Color.FromArgb(39, 174, 96)
        lblReturn.BackColor = Color.FromArgb(39, 174, 96)
    End Sub

    Private Sub btnReport_MouseEnter(sender As Object, e As EventArgs) Handles btnReport.MouseEnter, lblReport.MouseEnter
        btnReport.BackColor = Color.FromArgb(155, 89, 182)
        lblReport.BackColor = Color.FromArgb(155, 89, 182)
    End Sub

    Private Sub btnReport_MouseLeave(sender As Object, e As EventArgs) Handles btnReport.MouseLeave, lblReport.MouseLeave
        btnReport.BackColor = Color.FromArgb(142, 68, 173)
        lblReport.BackColor = Color.FromArgb(142, 68, 173)
    End Sub


End Class