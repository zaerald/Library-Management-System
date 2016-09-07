Imports MySql.Data.MySqlClient
Public Class frmLogin

    Dim conn As New MySqlConnection
    Dim counter As Integer

    ' generated
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set connection
        conn = ToolZ.getConnection()

        Me.AcceptButton = btnLogin
        Me.CancelButton = btnCancel
    End Sub

    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' verify if user input a data
        If txtName.Text = "" And txtPassword.Text = "" Then
            MsgBox("Please fill all the fields.")
            Exit Sub
        End If

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        With cmd
            .Connection = conn
            .CommandText = "SELECT * FROM tbluser WHERE user=?u AND password=?p"
            .Parameters.AddWithValue("u", Trim(txtName.Text))
            .Parameters.AddWithValue("p", Trim(txtPassword.Text))
        End With
        dr = cmd.ExecuteReader

        dr.Read()
        If dr.HasRows Then
            ' success
            Me.Dispose()
            frmMainMenu.Show()
        Else
            MsgBox("Invalid User Name and Password.")
            counter += 1

            If counter = 3 Then
                MsgBox("Too many attempts on accessing the system. System will now exit...")
                End
            End If
        End If
        dr.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.SelectAll()
    End Sub
End Class
