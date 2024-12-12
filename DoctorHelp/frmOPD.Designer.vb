<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOPD
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.grdView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelOption = New System.Windows.Forms.Panel()
        Me.btnDelHis = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnShowText = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTestMsgSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTestRemark = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTestName = New System.Windows.Forms.TextBox()
        Me.btnInvestigate = New System.Windows.Forms.Button()
        Me.btnParchaSave = New System.Windows.Forms.Button()
        Me.btnShowParcha = New System.Windows.Forms.Button()
        Me.btnBrowseInvestigate = New System.Windows.Forms.Button()
        Me.btnFileBrowse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GrdHistory = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblmode = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStaffRemark = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboDisease = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.btnShowOpdEntry = New System.Windows.Forms.Button()
        Me.PanelTestText = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grdTestNote = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDocRemark = New System.Windows.Forms.TextBox()
        Me.btnDocRemark = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        CType(Me.grdView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage3.SuspendLayout
        Me.PanelOption.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GrdHistory,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.PanelTestText.SuspendLayout
        CType(Me.grdTestNote,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnAll)
        Me.Panel1.Controls.Add(Me.grdView)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(821, 213)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 319)
        Me.Panel1.TabIndex = 0
        '
        'btnAll
        '
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAll.Location = New System.Drawing.Point(433, 44)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(75, 29)
        Me.btnAll.TabIndex = 26
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = true
        '
        'grdView
        '
        Me.grdView.BackgroundColor = System.Drawing.Color.White
        Me.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdView.Location = New System.Drawing.Point(17, 99)
        Me.grdView.Name = "grdView"
        Me.grdView.Size = New System.Drawing.Size(835, 186)
        Me.grdView.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Search Value"
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSearch.Location = New System.Drawing.Point(341, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 29)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = true
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSearch.Location = New System.Drawing.Point(168, 48)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(158, 22)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search BY"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Items.AddRange(New Object() {"Phone No", "Name"})
        Me.ComboBox1.Location = New System.Drawing.Point(27, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblAmt)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.PanelOption)
        Me.TabPage3.Controls.Add(Me.GrdHistory)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(726, 329)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "History"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'lblAmt
        '
        Me.lblAmt.AutoSize = true
        Me.lblAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAmt.Location = New System.Drawing.Point(139, 302)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(15, 16)
        Me.lblAmt.TabIndex = 6
        Me.lblAmt.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Amount : "
        '
        'PanelOption
        '
        Me.PanelOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(40,Byte),Integer), CType(CType(124,Byte),Integer), CType(CType(172,Byte),Integer))
        Me.PanelOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOption.Controls.Add(Me.GroupBox2)
        Me.PanelOption.Controls.Add(Me.btnDelHis)
        Me.PanelOption.Controls.Add(Me.btnEdit)
        Me.PanelOption.Controls.Add(Me.btnShowText)
        Me.PanelOption.Controls.Add(Me.GroupBox1)
        Me.PanelOption.Controls.Add(Me.btnInvestigate)
        Me.PanelOption.Controls.Add(Me.btnParchaSave)
        Me.PanelOption.Controls.Add(Me.btnShowParcha)
        Me.PanelOption.Controls.Add(Me.btnBrowseInvestigate)
        Me.PanelOption.Controls.Add(Me.btnFileBrowse)
        Me.PanelOption.Controls.Add(Me.PictureBox1)
        Me.PanelOption.Location = New System.Drawing.Point(-4, 53)
        Me.PanelOption.Name = "PanelOption"
        Me.PanelOption.Size = New System.Drawing.Size(727, 219)
        Me.PanelOption.TabIndex = 4
        Me.PanelOption.Visible = false
        '
        'btnDelHis
        '
        Me.btnDelHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelHis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDelHis.ForeColor = System.Drawing.Color.White
        Me.btnDelHis.Location = New System.Drawing.Point(167, 171)
        Me.btnDelHis.Name = "btnDelHis"
        Me.btnDelHis.Size = New System.Drawing.Size(116, 30)
        Me.btnDelHis.TabIndex = 34
        Me.btnDelHis.Text = "Delete"
        Me.btnDelHis.UseVisualStyleBackColor = true
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(36, 171)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(115, 30)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = true
        '
        'btnShowText
        '
        Me.btnShowText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnShowText.ForeColor = System.Drawing.Color.White
        Me.btnShowText.Location = New System.Drawing.Point(167, 134)
        Me.btnShowText.Name = "btnShowText"
        Me.btnShowText.Size = New System.Drawing.Size(116, 30)
        Me.btnShowText.TabIndex = 32
        Me.btnShowText.Text = "Show Text"
        Me.btnShowText.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40,Byte),Integer), CType(CType(124,Byte),Integer), CType(CType(172,Byte),Integer))
        Me.GroupBox1.Controls.Add(Me.btnTestMsgSave)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTestRemark)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTestName)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(303, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 177)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Test Detail"
        '
        'btnTestMsgSave
        '
        Me.btnTestMsgSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(154,Byte),Integer), CType(CType(198,Byte),Integer))
        Me.btnTestMsgSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestMsgSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnTestMsgSave.ForeColor = System.Drawing.Color.White
        Me.btnTestMsgSave.Location = New System.Drawing.Point(56, 142)
        Me.btnTestMsgSave.Name = "btnTestMsgSave"
        Me.btnTestMsgSave.Size = New System.Drawing.Size(65, 22)
        Me.btnTestMsgSave.TabIndex = 32
        Me.btnTestMsgSave.Text = "Save"
        Me.btnTestMsgSave.UseVisualStyleBackColor = false
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(16, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Remark"
        '
        'txtTestRemark
        '
        Me.txtTestRemark.Location = New System.Drawing.Point(19, 71)
        Me.txtTestRemark.Multiline = true
        Me.txtTestRemark.Name = "txtTestRemark"
        Me.txtTestRemark.Size = New System.Drawing.Size(160, 62)
        Me.txtTestRemark.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(20, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Test"
        '
        'txtTestName
        '
        Me.txtTestName.Location = New System.Drawing.Point(18, 32)
        Me.txtTestName.Name = "txtTestName"
        Me.txtTestName.Size = New System.Drawing.Size(160, 20)
        Me.txtTestName.TabIndex = 0
        '
        'btnInvestigate
        '
        Me.btnInvestigate.BackColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(154,Byte),Integer), CType(CType(198,Byte),Integer))
        Me.btnInvestigate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvestigate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnInvestigate.ForeColor = System.Drawing.Color.White
        Me.btnInvestigate.Location = New System.Drawing.Point(209, 83)
        Me.btnInvestigate.Name = "btnInvestigate"
        Me.btnInvestigate.Size = New System.Drawing.Size(74, 29)
        Me.btnInvestigate.TabIndex = 30
        Me.btnInvestigate.Text = "Save"
        Me.btnInvestigate.UseVisualStyleBackColor = false
        '
        'btnParchaSave
        '
        Me.btnParchaSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(154,Byte),Integer), CType(CType(198,Byte),Integer))
        Me.btnParchaSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParchaSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnParchaSave.ForeColor = System.Drawing.Color.White
        Me.btnParchaSave.Location = New System.Drawing.Point(209, 27)
        Me.btnParchaSave.Name = "btnParchaSave"
        Me.btnParchaSave.Size = New System.Drawing.Size(74, 29)
        Me.btnParchaSave.TabIndex = 29
        Me.btnParchaSave.Text = "Save"
        Me.btnParchaSave.UseVisualStyleBackColor = false
        '
        'btnShowParcha
        '
        Me.btnShowParcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowParcha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnShowParcha.ForeColor = System.Drawing.Color.White
        Me.btnShowParcha.Location = New System.Drawing.Point(36, 134)
        Me.btnShowParcha.Name = "btnShowParcha"
        Me.btnShowParcha.Size = New System.Drawing.Size(115, 30)
        Me.btnShowParcha.TabIndex = 27
        Me.btnShowParcha.Text = "Show Docs."
        Me.btnShowParcha.UseVisualStyleBackColor = true
        '
        'btnBrowseInvestigate
        '
        Me.btnBrowseInvestigate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseInvestigate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnBrowseInvestigate.ForeColor = System.Drawing.Color.White
        Me.btnBrowseInvestigate.Location = New System.Drawing.Point(36, 83)
        Me.btnBrowseInvestigate.Name = "btnBrowseInvestigate"
        Me.btnBrowseInvestigate.Size = New System.Drawing.Size(167, 29)
        Me.btnBrowseInvestigate.TabIndex = 26
        Me.btnBrowseInvestigate.Text = "Browse Investigation"
        Me.btnBrowseInvestigate.UseVisualStyleBackColor = true
        '
        'btnFileBrowse
        '
        Me.btnFileBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnFileBrowse.ForeColor = System.Drawing.Color.White
        Me.btnFileBrowse.Location = New System.Drawing.Point(36, 27)
        Me.btnFileBrowse.Name = "btnFileBrowse"
        Me.btnFileBrowse.Size = New System.Drawing.Size(167, 29)
        Me.btnFileBrowse.TabIndex = 25
        Me.btnFileBrowse.Text = "Browse Prescription"
        Me.btnFileBrowse.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DoctorHelp.My.Resources.Resources.close1
        Me.PictureBox1.Location = New System.Drawing.Point(706, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'GrdHistory
        '
        Me.GrdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdHistory.Location = New System.Drawing.Point(30, 35)
        Me.GrdHistory.Name = "GrdHistory"
        Me.GrdHistory.Size = New System.Drawing.Size(658, 250)
        Me.GrdHistory.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblmode)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtStaffRemark)
        Me.TabPage1.Controls.Add(Me.txtAmount)
        Me.TabPage1.Controls.Add(Me.btnUpdate)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtRemark)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.ComboDisease)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(726, 329)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "OPD"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'lblmode
        '
        Me.lblmode.AutoSize = true
        Me.lblmode.Location = New System.Drawing.Point(73, 243)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(33, 13)
        Me.lblmode.TabIndex = 8
        Me.lblmode.Text = "mode"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(311, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Staff Remark"
        '
        'txtStaffRemark
        '
        Me.txtStaffRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStaffRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtStaffRemark.Location = New System.Drawing.Point(314, 128)
        Me.txtStaffRemark.Name = "txtStaffRemark"
        Me.txtStaffRemark.Size = New System.Drawing.Size(286, 22)
        Me.txtStaffRemark.TabIndex = 6
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtAmount.Location = New System.Drawing.Point(113, 128)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(165, 22)
        Me.txtAmount.TabIndex = 3
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(266, 184)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 29)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = true
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Doctor Remark"
        '
        'txtRemark
        '
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRemark.Location = New System.Drawing.Point(314, 66)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(286, 22)
        Me.txtRemark.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Disease Type"
        '
        'ComboDisease
        '
        Me.ComboDisease.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ComboDisease.FormattingEnabled = true
        Me.ComboDisease.Location = New System.Drawing.Point(113, 64)
        Me.ComboDisease.Name = "ComboDisease"
        Me.ComboDisease.Size = New System.Drawing.Size(148, 24)
        Me.ComboDisease.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(60, 113)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(734, 355)
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.Visible = false
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Patient Name : "
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = true
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(446, 32)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(16, 24)
        Me.lblPatientName.TabIndex = 3
        Me.lblPatientName.Text = "-"
        '
        'btnShowOpdEntry
        '
        Me.btnShowOpdEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowOpdEntry.Location = New System.Drawing.Point(821, 35)
        Me.btnShowOpdEntry.Name = "btnShowOpdEntry"
        Me.btnShowOpdEntry.Size = New System.Drawing.Size(75, 23)
        Me.btnShowOpdEntry.TabIndex = 4
        Me.btnShowOpdEntry.Text = "OPD Entry"
        Me.btnShowOpdEntry.UseVisualStyleBackColor = true
        '
        'PanelTestText
        '
        Me.PanelTestText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelTestText.Controls.Add(Me.Label11)
        Me.PanelTestText.Controls.Add(Me.grdTestNote)
        Me.PanelTestText.Controls.Add(Me.PictureBox2)
        Me.PanelTestText.Location = New System.Drawing.Point(60, -182)
        Me.PanelTestText.Name = "PanelTestText"
        Me.PanelTestText.Size = New System.Drawing.Size(683, 289)
        Me.PanelTestText.TabIndex = 5
        Me.PanelTestText.Visible = false
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.Location = New System.Drawing.Point(310, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Test Details"
        '
        'grdTestNote
        '
        Me.grdTestNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTestNote.Location = New System.Drawing.Point(31, 50)
        Me.grdTestNote.Name = "grdTestNote"
        Me.grdTestNote.Size = New System.Drawing.Size(616, 223)
        Me.grdTestNote.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DoctorHelp.My.Resources.Resources.close1
        Me.PictureBox2.Location = New System.Drawing.Point(661, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = false
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDocRemark)
        Me.GroupBox2.Controls.Add(Me.txtDocRemark)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(515, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 174)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Doctor Remark"
        '
        'txtDocRemark
        '
        Me.txtDocRemark.Location = New System.Drawing.Point(16, 29)
        Me.txtDocRemark.Multiline = true
        Me.txtDocRemark.Name = "txtDocRemark"
        Me.txtDocRemark.Size = New System.Drawing.Size(160, 101)
        Me.txtDocRemark.TabIndex = 3
        '
        'btnDocRemark
        '
        Me.btnDocRemark.BackColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(154,Byte),Integer), CType(CType(198,Byte),Integer))
        Me.btnDocRemark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDocRemark.ForeColor = System.Drawing.Color.White
        Me.btnDocRemark.Location = New System.Drawing.Point(65, 139)
        Me.btnDocRemark.Name = "btnDocRemark"
        Me.btnDocRemark.Size = New System.Drawing.Size(65, 22)
        Me.btnDocRemark.TabIndex = 33
        Me.btnDocRemark.Text = "Save"
        Me.btnDocRemark.UseVisualStyleBackColor = false
        '
        'frmOPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(237,Byte),Integer), CType(CType(247,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1225, 533)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTestText)
        Me.Controls.Add(Me.btnShowOpdEntry)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOPD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OPD Management"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.grdView,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage3.ResumeLayout(false)
        Me.TabPage3.PerformLayout
        Me.PanelOption.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GrdHistory,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.PanelTestText.ResumeLayout(false)
        Me.PanelTestText.PerformLayout
        CType(Me.grdTestNote,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents grdView As DataGridView
    Friend WithEvents btnAll As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboDisease As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents GrdHistory As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents PanelOption As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnShowParcha As Button
    Friend WithEvents btnBrowseInvestigate As Button
    Friend WithEvents btnFileBrowse As Button
    Friend WithEvents btnInvestigate As Button
    Friend WithEvents btnParchaSave As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnShowOpdEntry As Button
    Friend WithEvents lblAmt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStaffRemark As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTestRemark As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTestName As TextBox
    Friend WithEvents btnTestMsgSave As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnShowText As Button
    Friend WithEvents PanelTestText As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents grdTestNote As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents lblmode As Label
    Friend WithEvents btnDelHis As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDocRemark As Button
    Friend WithEvents txtDocRemark As TextBox
End Class
