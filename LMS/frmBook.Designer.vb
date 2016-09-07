<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblGoBack = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pan = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAccession = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.num = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAuthor1 = New System.Windows.Forms.ComboBox()
        Me.panMove = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboAvailability = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numBooks = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPubYear = New System.Windows.Forms.TextBox()
        Me.cboDDC = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboPublisher = New System.Windows.Forms.ComboBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSearchInput = New System.Windows.Forms.ComboBox()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pan.SuspendLayout()
        CType(Me.num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panMove.SuspendLayout()
        CType(Me.numBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txt.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGoBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGoBack
        '
        Me.lblGoBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGoBack.AutoSize = True
        Me.lblGoBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGoBack.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoBack.ForeColor = System.Drawing.Color.White
        Me.lblGoBack.Location = New System.Drawing.Point(917, 85)
        Me.lblGoBack.Name = "lblGoBack"
        Me.lblGoBack.Size = New System.Drawing.Size(85, 21)
        Me.lblGoBack.TabIndex = 9
        Me.lblGoBack.Text = "Go Back"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 136)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(953, 584)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pan)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 564)
        Me.Panel1.TabIndex = 0
        '
        'pan
        '
        Me.pan.AutoScroll = True
        Me.pan.Controls.Add(Me.Label9)
        Me.pan.Controls.Add(Me.Label12)
        Me.pan.Controls.Add(Me.txtAccession)
        Me.pan.Controls.Add(Me.txtISBN)
        Me.pan.Controls.Add(Me.Label3)
        Me.pan.Controls.Add(Me.txtTitle)
        Me.pan.Controls.Add(Me.num)
        Me.pan.Controls.Add(Me.Label2)
        Me.pan.Controls.Add(Me.cboAuthor1)
        Me.pan.Controls.Add(Me.panMove)
        Me.pan.Location = New System.Drawing.Point(3, 3)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(277, 436)
        Me.pan.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Accession"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(4, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 21)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "ISBN"
        '
        'txtAccession
        '
        Me.txtAccession.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccession.Location = New System.Drawing.Point(8, 97)
        Me.txtAccession.MaxLength = 20
        Me.txtAccession.Name = "txtAccession"
        Me.txtAccession.Size = New System.Drawing.Size(232, 27)
        Me.txtAccession.TabIndex = 1
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(8, 34)
        Me.txtISBN.MaxLength = 20
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(232, 27)
        Me.txtISBN.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(8, 160)
        Me.txtTitle.MaxLength = 100
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(232, 27)
        Me.txtTitle.TabIndex = 2
        '
        'num
        '
        Me.num.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(8, 229)
        Me.num.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.num.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        Me.num.Size = New System.Drawing.Size(44, 27)
        Me.num.TabIndex = 2
        Me.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Author"
        '
        'cboAuthor1
        '
        Me.cboAuthor1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAuthor1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboAuthor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAuthor1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAuthor1.Location = New System.Drawing.Point(66, 228)
        Me.cboAuthor1.Name = "cboAuthor1"
        Me.cboAuthor1.Size = New System.Drawing.Size(174, 29)
        Me.cboAuthor1.TabIndex = 3
        '
        'panMove
        '
        Me.panMove.Controls.Add(Me.Label8)
        Me.panMove.Controls.Add(Me.cboAvailability)
        Me.panMove.Controls.Add(Me.Label11)
        Me.panMove.Controls.Add(Me.Label6)
        Me.panMove.Controls.Add(Me.Label4)
        Me.panMove.Controls.Add(Me.numBooks)
        Me.panMove.Controls.Add(Me.Label7)
        Me.panMove.Controls.Add(Me.txtPubYear)
        Me.panMove.Controls.Add(Me.cboDDC)
        Me.panMove.Controls.Add(Me.Label13)
        Me.panMove.Controls.Add(Me.cboPublisher)
        Me.panMove.Controls.Add(Me.cboCategory)
        Me.panMove.Location = New System.Drawing.Point(3, 263)
        Me.panMove.Name = "panMove"
        Me.panMove.Size = New System.Drawing.Size(252, 400)
        Me.panMove.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(7, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 21)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Availability"
        '
        'cboAvailability
        '
        Me.cboAvailability.AutoCompleteCustomSource.AddRange(New String() {"Library Only", "Can be borrowed"})
        Me.cboAvailability.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAvailability.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAvailability.FormattingEnabled = True
        Me.cboAvailability.Items.AddRange(New Object() {"Can be borrowed", "Library Only"})
        Me.cboAvailability.Location = New System.Drawing.Point(11, 289)
        Me.cboAvailability.Name = "cboAvailability"
        Me.cboAvailability.Size = New System.Drawing.Size(226, 29)
        Me.cboAvailability.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(5, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 21)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "DDC"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Publisher"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 21)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Published Year"
        '
        'numBooks
        '
        Me.numBooks.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numBooks.Location = New System.Drawing.Point(144, 338)
        Me.numBooks.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numBooks.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBooks.Name = "numBooks"
        Me.numBooks.Size = New System.Drawing.Size(93, 27)
        Me.numBooks.TabIndex = 35
        Me.numBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBooks.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 21)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "No. Of Books"
        '
        'txtPubYear
        '
        Me.txtPubYear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPubYear.Location = New System.Drawing.Point(11, 224)
        Me.txtPubYear.Name = "txtPubYear"
        Me.txtPubYear.Size = New System.Drawing.Size(226, 27)
        Me.txtPubYear.TabIndex = 33
        '
        'cboDDC
        '
        Me.cboDDC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDDC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboDDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDDC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDDC.FormattingEnabled = True
        Me.cboDDC.Location = New System.Drawing.Point(11, 98)
        Me.cboDDC.Name = "cboDDC"
        Me.cboDDC.Size = New System.Drawing.Size(226, 29)
        Me.cboDDC.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(5, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 21)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Category"
        '
        'cboPublisher
        '
        Me.cboPublisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPublisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPublisher.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPublisher.FormattingEnabled = True
        Me.cboPublisher.Location = New System.Drawing.Point(11, 158)
        Me.cboPublisher.Name = "cboPublisher"
        Me.cboPublisher.Size = New System.Drawing.Size(226, 29)
        Me.cboPublisher.TabIndex = 32
        '
        'cboCategory
        '
        Me.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCategory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(11, 33)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(226, 29)
        Me.cboCategory.TabIndex = 30
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(27, 479)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(232, 28)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Enabled = False
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(27, 513)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(232, 28)
        Me.btnClear.TabIndex = 37
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txt.Controls.Add(Me.btnUpdate)
        Me.txt.Controls.Add(Me.btnDelete)
        Me.txt.Controls.Add(Me.dgv)
        Me.txt.Controls.Add(Me.Label5)
        Me.txt.Controls.Add(Me.cboSearchInput)
        Me.txt.Controls.Add(Me.cboSearch)
        Me.txt.Controls.Add(Me.btnAdd)
        Me.txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt.Location = New System.Drawing.Point(310, 10)
        Me.txt.Margin = New System.Windows.Forms.Padding(10)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(633, 564)
        Me.txt.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(341, 513)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(131, 28)
        Me.btnUpdate.TabIndex = 39
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(492, 513)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 28)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(19, 58)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(604, 434)
        Me.dgv.TabIndex = 9
        Me.dgv.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Track", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Search by:"
        '
        'cboSearchInput
        '
        Me.cboSearchInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSearchInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboSearchInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboSearchInput.BackColor = System.Drawing.Color.White
        Me.cboSearchInput.Enabled = False
        Me.cboSearchInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSearchInput.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchInput.FormattingEnabled = True
        Me.cboSearchInput.Items.AddRange(New Object() {"Student ID", "First Name", "Last Name", "Gender"})
        Me.cboSearchInput.Location = New System.Drawing.Point(301, 13)
        Me.cboSearchInput.Name = "cboSearchInput"
        Me.cboSearchInput.Size = New System.Drawing.Size(322, 29)
        Me.cboSearchInput.TabIndex = 42
        '
        'cboSearch
        '
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"", "ISBN", "Accession", "Title", "Availability"})
        Me.cboSearch.Location = New System.Drawing.Point(129, 13)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(166, 29)
        Me.cboSearch.TabIndex = 41
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(190, 513)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(131, 28)
        Me.btnAdd.TabIndex = 38
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Books"
        '
        'btnGoBack
        '
        Me.btnGoBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGoBack.BackColor = System.Drawing.Color.Transparent
        Me.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoBack.Image = Global.LMS.My.Resources.Resources.back
        Me.btnGoBack.Location = New System.Drawing.Point(929, 25)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(60, 60)
        Me.btnGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGoBack.TabIndex = 8
        Me.btnGoBack.TabStop = False
        '
        'frmBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblGoBack)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        CType(Me.num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panMove.ResumeLayout(False)
        Me.panMove.PerformLayout()
        CType(Me.numBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txt.ResumeLayout(False)
        Me.txt.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGoBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGoBack As Label
    Friend WithEvents btnGoBack As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txt As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cboSearchInput As ComboBox
    Private WithEvents num As NumericUpDown
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPubYear As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents numBooks As NumericUpDown
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents cboAuthor1 As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents pan As Panel
    Friend WithEvents panMove As Panel
    Friend WithEvents cboPublisher As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboAvailability As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboDDC As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAccession As TextBox
End Class
