<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaction
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
        Me.lblReport = New System.Windows.Forms.Label()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.lblBorrow = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.PictureBox()
        Me.btnBorrow = New System.Windows.Forms.PictureBox()
        Me.btnMainMenu = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(307, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Transactions"
        '
        'lblMainMenu
        '
        Me.lblMainMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMainMenu.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.White
        Me.lblMainMenu.Location = New System.Drawing.Point(511, 93)
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
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblReport, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblReturn, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBorrow, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReport, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReturn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBorrow, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(72, 150)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(455, 159)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'lblReport
        '
        Me.lblReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReport.Font = New System.Drawing.Font("Track", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.ForeColor = System.Drawing.Color.White
        Me.lblReport.Location = New System.Drawing.Point(327, 127)
        Me.lblReport.Margin = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(103, 32)
        Me.lblReport.TabIndex = 7
        Me.lblReport.Text = "Book Report"
        Me.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReturn
        '
        Me.lblReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReturn.Font = New System.Drawing.Font("Track", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturn.ForeColor = System.Drawing.Color.White
        Me.lblReturn.Location = New System.Drawing.Point(176, 127)
        Me.lblReturn.Margin = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(101, 32)
        Me.lblReturn.TabIndex = 6
        Me.lblReturn.Text = "Return Book"
        Me.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBorrow
        '
        Me.lblBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBorrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBorrow.Font = New System.Drawing.Font("Track", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrow.ForeColor = System.Drawing.Color.White
        Me.lblBorrow.Location = New System.Drawing.Point(25, 127)
        Me.lblBorrow.Margin = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.lblBorrow.Name = "lblBorrow"
        Me.lblBorrow.Size = New System.Drawing.Size(101, 32)
        Me.lblBorrow.TabIndex = 4
        Me.lblBorrow.Text = "Borrow Book"
        Me.lblBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReport.Image = Global.LMS.My.Resources.Resources.report
        Me.btnReport.Location = New System.Drawing.Point(327, 3)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(25, 3, 25, 0)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(103, 124)
        Me.btnReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnReport.TabIndex = 3
        Me.btnReport.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReturn.Image = Global.LMS.My.Resources.Resources._return
        Me.btnReturn.Location = New System.Drawing.Point(176, 3)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(25, 3, 25, 0)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(101, 124)
        Me.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.TabStop = False
        '
        'btnBorrow
        '
        Me.btnBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBorrow.Image = Global.LMS.My.Resources.Resources.borrow
        Me.btnBorrow.Location = New System.Drawing.Point(25, 3)
        Me.btnBorrow.Margin = New System.Windows.Forms.Padding(25, 3, 25, 0)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(101, 124)
        Me.btnBorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBorrow.TabIndex = 1
        Me.btnBorrow.TabStop = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainMenu.Image = Global.LMS.My.Resources.Resources.mainmenu
        Me.btnMainMenu.Location = New System.Drawing.Point(530, 33)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(60, 60)
        Me.btnMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMainMenu.TabIndex = 5
        Me.btnMainMenu.TabStop = False
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 360)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMainMenu As Label
    Friend WithEvents btnMainMenu As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblReport As Label
    Friend WithEvents lblReturn As Label
    Friend WithEvents lblBorrow As Label
    Friend WithEvents btnReport As PictureBox
    Friend WithEvents btnReturn As PictureBox
    Friend WithEvents btnBorrow As PictureBox
End Class
