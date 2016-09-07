<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilities
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStudentBookLimit = New System.Windows.Forms.Label()
        Me.lblDueDays = New System.Windows.Forms.Label()
        Me.lblBorrow = New System.Windows.Forms.Label()
        Me.btnBorrow = New System.Windows.Forms.PictureBox()
        Me.panDueDays = New System.Windows.Forms.Panel()
        Me.btnDownDue = New System.Windows.Forms.PictureBox()
        Me.btnUpDue = New System.Windows.Forms.PictureBox()
        Me.lblDue = New System.Windows.Forms.Label()
        Me.panBookSLimit = New System.Windows.Forms.Panel()
        Me.btnDownSLimit = New System.Windows.Forms.PictureBox()
        Me.lblSLimit = New System.Windows.Forms.Label()
        Me.btnUpSLimit = New System.Windows.Forms.PictureBox()
        Me.lblFacultyBookLimit = New System.Windows.Forms.Label()
        Me.panBookFLimit = New System.Windows.Forms.Panel()
        Me.btnDownFLimit = New System.Windows.Forms.PictureBox()
        Me.lblFLimit = New System.Windows.Forms.Label()
        Me.btnUpFLimit = New System.Windows.Forms.PictureBox()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.PictureBox()
        Me.btnMainMenu = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panDueDays.SuspendLayout()
        CType(Me.btnDownDue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpDue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panBookSLimit.SuspendLayout()
        CType(Me.btnDownSLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpSLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panBookFLimit.SuspendLayout()
        CType(Me.btnDownFLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpFLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Utilities"
        '
        'lblMainMenu
        '
        Me.lblMainMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMainMenu.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.White
        Me.lblMainMenu.Location = New System.Drawing.Point(895, 93)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(104, 21)
        Me.lblMainMenu.TabIndex = 6
        Me.lblMainMenu.Text = "Main Menu"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblStudentBookLimit, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDueDays, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBorrow, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBorrow, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.panDueDays, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.panBookSLimit, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFacultyBookLimit, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.panBookFLimit, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 151)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(961, 567)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'lblStudentBookLimit
        '
        Me.lblStudentBookLimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblStudentBookLimit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStudentBookLimit.Font = New System.Drawing.Font("Track", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentBookLimit.ForeColor = System.Drawing.Color.White
        Me.lblStudentBookLimit.Location = New System.Drawing.Point(490, 453)
        Me.lblStudentBookLimit.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblStudentBookLimit.Name = "lblStudentBookLimit"
        Me.lblStudentBookLimit.Size = New System.Drawing.Size(220, 114)
        Me.lblStudentBookLimit.TabIndex = 7
        Me.lblStudentBookLimit.Text = "Student Book Limit"
        Me.lblStudentBookLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDueDays
        '
        Me.lblDueDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblDueDays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDueDays.Font = New System.Drawing.Font("Track", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDays.ForeColor = System.Drawing.Color.White
        Me.lblDueDays.Location = New System.Drawing.Point(250, 453)
        Me.lblDueDays.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblDueDays.Name = "lblDueDays"
        Me.lblDueDays.Size = New System.Drawing.Size(220, 114)
        Me.lblDueDays.TabIndex = 6
        Me.lblDueDays.Text = "Student Due Days"
        Me.lblDueDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBorrow
        '
        Me.lblBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblBorrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBorrow.Font = New System.Drawing.Font("Track", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrow.ForeColor = System.Drawing.Color.White
        Me.lblBorrow.Location = New System.Drawing.Point(10, 453)
        Me.lblBorrow.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblBorrow.Name = "lblBorrow"
        Me.lblBorrow.Size = New System.Drawing.Size(220, 114)
        Me.lblBorrow.TabIndex = 4
        Me.lblBorrow.Text = "User Management"
        Me.lblBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBorrow
        '
        Me.btnBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBorrow.Image = Global.LMS.My.Resources.Resources.borrow
        Me.btnBorrow.Location = New System.Drawing.Point(10, 3)
        Me.btnBorrow.Margin = New System.Windows.Forms.Padding(10, 3, 10, 0)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(220, 450)
        Me.btnBorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBorrow.TabIndex = 1
        Me.btnBorrow.TabStop = False
        '
        'panDueDays
        '
        Me.panDueDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.panDueDays.Controls.Add(Me.btnDownDue)
        Me.panDueDays.Controls.Add(Me.btnUpDue)
        Me.panDueDays.Controls.Add(Me.lblDue)
        Me.panDueDays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panDueDays.ForeColor = System.Drawing.Color.White
        Me.panDueDays.Location = New System.Drawing.Point(250, 3)
        Me.panDueDays.Margin = New System.Windows.Forms.Padding(10, 3, 10, 0)
        Me.panDueDays.Name = "panDueDays"
        Me.panDueDays.Size = New System.Drawing.Size(220, 450)
        Me.panDueDays.TabIndex = 8
        '
        'btnDownDue
        '
        Me.btnDownDue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDownDue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownDue.Image = Global.LMS.My.Resources.Resources.arrow_down_small
        Me.btnDownDue.Location = New System.Drawing.Point(-3, 349)
        Me.btnDownDue.Name = "btnDownDue"
        Me.btnDownDue.Size = New System.Drawing.Size(220, 36)
        Me.btnDownDue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDownDue.TabIndex = 1
        Me.btnDownDue.TabStop = False
        '
        'btnUpDue
        '
        Me.btnUpDue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpDue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpDue.Image = Global.LMS.My.Resources.Resources.arrow_up_small
        Me.btnUpDue.Location = New System.Drawing.Point(3, 62)
        Me.btnUpDue.Name = "btnUpDue"
        Me.btnUpDue.Size = New System.Drawing.Size(219, 36)
        Me.btnUpDue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUpDue.TabIndex = 1
        Me.btnUpDue.TabStop = False
        '
        'lblDue
        '
        Me.lblDue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDue.Font = New System.Drawing.Font("Bebas", 99.74999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDue.Location = New System.Drawing.Point(0, 101)
        Me.lblDue.Name = "lblDue"
        Me.lblDue.Size = New System.Drawing.Size(220, 245)
        Me.lblDue.TabIndex = 0
        Me.lblDue.Text = "99"
        Me.lblDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panBookSLimit
        '
        Me.panBookSLimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.panBookSLimit.Controls.Add(Me.btnDownSLimit)
        Me.panBookSLimit.Controls.Add(Me.lblSLimit)
        Me.panBookSLimit.Controls.Add(Me.btnUpSLimit)
        Me.panBookSLimit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBookSLimit.ForeColor = System.Drawing.Color.White
        Me.panBookSLimit.Location = New System.Drawing.Point(490, 3)
        Me.panBookSLimit.Margin = New System.Windows.Forms.Padding(10, 3, 10, 0)
        Me.panBookSLimit.Name = "panBookSLimit"
        Me.panBookSLimit.Size = New System.Drawing.Size(220, 450)
        Me.panBookSLimit.TabIndex = 9
        '
        'btnDownSLimit
        '
        Me.btnDownSLimit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDownSLimit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownSLimit.Image = Global.LMS.My.Resources.Resources.arrow_down
        Me.btnDownSLimit.Location = New System.Drawing.Point(0, 349)
        Me.btnDownSLimit.Name = "btnDownSLimit"
        Me.btnDownSLimit.Size = New System.Drawing.Size(217, 36)
        Me.btnDownSLimit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDownSLimit.TabIndex = 1
        Me.btnDownSLimit.TabStop = False
        '
        'lblSLimit
        '
        Me.lblSLimit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSLimit.Font = New System.Drawing.Font("Bebas", 99.74999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSLimit.Location = New System.Drawing.Point(3, 101)
        Me.lblSLimit.Name = "lblSLimit"
        Me.lblSLimit.Size = New System.Drawing.Size(218, 245)
        Me.lblSLimit.TabIndex = 0
        Me.lblSLimit.Text = "99"
        Me.lblSLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpSLimit
        '
        Me.btnUpSLimit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpSLimit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpSLimit.Image = Global.LMS.My.Resources.Resources.arrow_up
        Me.btnUpSLimit.Location = New System.Drawing.Point(0, 62)
        Me.btnUpSLimit.Name = "btnUpSLimit"
        Me.btnUpSLimit.Size = New System.Drawing.Size(217, 36)
        Me.btnUpSLimit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUpSLimit.TabIndex = 1
        Me.btnUpSLimit.TabStop = False
        '
        'lblFacultyBookLimit
        '
        Me.lblFacultyBookLimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblFacultyBookLimit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFacultyBookLimit.Font = New System.Drawing.Font("Track", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacultyBookLimit.ForeColor = System.Drawing.Color.White
        Me.lblFacultyBookLimit.Location = New System.Drawing.Point(730, 453)
        Me.lblFacultyBookLimit.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblFacultyBookLimit.Name = "lblFacultyBookLimit"
        Me.lblFacultyBookLimit.Size = New System.Drawing.Size(221, 114)
        Me.lblFacultyBookLimit.TabIndex = 7
        Me.lblFacultyBookLimit.Text = "Faculty Book Limit"
        Me.lblFacultyBookLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panBookFLimit
        '
        Me.panBookFLimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.panBookFLimit.Controls.Add(Me.btnDownFLimit)
        Me.panBookFLimit.Controls.Add(Me.lblFLimit)
        Me.panBookFLimit.Controls.Add(Me.btnUpFLimit)
        Me.panBookFLimit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBookFLimit.ForeColor = System.Drawing.Color.White
        Me.panBookFLimit.Location = New System.Drawing.Point(730, 3)
        Me.panBookFLimit.Margin = New System.Windows.Forms.Padding(10, 3, 10, 0)
        Me.panBookFLimit.Name = "panBookFLimit"
        Me.panBookFLimit.Size = New System.Drawing.Size(221, 450)
        Me.panBookFLimit.TabIndex = 9
        '
        'btnDownFLimit
        '
        Me.btnDownFLimit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDownFLimit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownFLimit.Image = Global.LMS.My.Resources.Resources.arrow_down
        Me.btnDownFLimit.Location = New System.Drawing.Point(0, 349)
        Me.btnDownFLimit.Name = "btnDownFLimit"
        Me.btnDownFLimit.Size = New System.Drawing.Size(222, 36)
        Me.btnDownFLimit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDownFLimit.TabIndex = 1
        Me.btnDownFLimit.TabStop = False
        '
        'lblFLimit
        '
        Me.lblFLimit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFLimit.Font = New System.Drawing.Font("Bebas", 99.74999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFLimit.Location = New System.Drawing.Point(3, 101)
        Me.lblFLimit.Name = "lblFLimit"
        Me.lblFLimit.Size = New System.Drawing.Size(219, 245)
        Me.lblFLimit.TabIndex = 0
        Me.lblFLimit.Text = "99"
        Me.lblFLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpFLimit
        '
        Me.btnUpFLimit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpFLimit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpFLimit.Image = Global.LMS.My.Resources.Resources.arrow_up
        Me.btnUpFLimit.Location = New System.Drawing.Point(0, 62)
        Me.btnUpFLimit.Name = "btnUpFLimit"
        Me.btnUpFLimit.Size = New System.Drawing.Size(221, 36)
        Me.btnUpFLimit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUpFLimit.TabIndex = 1
        Me.btnUpFLimit.TabStop = False
        '
        'lblSave
        '
        Me.lblSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSave.AutoSize = True
        Me.lblSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSave.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.ForeColor = System.Drawing.Color.White
        Me.lblSave.Location = New System.Drawing.Point(826, 93)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(54, 21)
        Me.lblSave.TabIndex = 6
        Me.lblSave.Text = "Save"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Image = Global.LMS.My.Resources.Resources.save_btn_small
        Me.btnSave.Location = New System.Drawing.Point(822, 33)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 60)
        Me.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSave.TabIndex = 5
        Me.btnSave.TabStop = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainMenu.Image = Global.LMS.My.Resources.Resources.mainmenu
        Me.btnMainMenu.Location = New System.Drawing.Point(914, 33)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(60, 60)
        Me.btnMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainMenu.TabIndex = 5
        Me.btnMainMenu.TabStop = False
        '
        'frmUtilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUtilities"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panDueDays.ResumeLayout(False)
        CType(Me.btnDownDue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpDue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panBookSLimit.ResumeLayout(False)
        CType(Me.btnDownSLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpSLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panBookFLimit.ResumeLayout(False)
        CType(Me.btnDownFLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpFLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMainMenu As Label
    Friend WithEvents btnMainMenu As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblStudentBookLimit As Label
    Friend WithEvents lblDueDays As Label
    Friend WithEvents lblBorrow As Label
    Friend WithEvents btnBorrow As PictureBox
    Friend WithEvents panDueDays As Panel
    Friend WithEvents panBookSLimit As Panel
    Friend WithEvents lblDue As Label
    Friend WithEvents lblSLimit As Label
    Friend WithEvents btnUpDue As PictureBox
    Friend WithEvents btnDownDue As PictureBox
    Friend WithEvents btnDownSLimit As PictureBox
    Friend WithEvents btnUpSLimit As PictureBox
    Friend WithEvents btnSave As PictureBox
    Friend WithEvents lblSave As Label
    Friend WithEvents lblFacultyBookLimit As Label
    Friend WithEvents panBookFLimit As Panel
    Friend WithEvents btnDownFLimit As PictureBox
    Friend WithEvents lblFLimit As Label
    Friend WithEvents btnUpFLimit As PictureBox
End Class
