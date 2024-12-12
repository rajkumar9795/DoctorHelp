<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParcha
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
        Me.btnParchaPre = New System.Windows.Forms.Button()
        Me.btnParchaNext = New System.Windows.Forms.Button()
        Me.btnInvestiNext = New System.Windows.Forms.Button()
        Me.btnInvestiPre = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.PictureInvestigation = New System.Windows.Forms.PictureBox()
        Me.PictureParcha = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOPDID = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        CType(Me.PictureInvestigation,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureParcha,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnParchaPre
        '
        Me.btnParchaPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParchaPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnParchaPre.Location = New System.Drawing.Point(332, 512)
        Me.btnParchaPre.Name = "btnParchaPre"
        Me.btnParchaPre.Size = New System.Drawing.Size(75, 29)
        Me.btnParchaPre.TabIndex = 7
        Me.btnParchaPre.Text = "<"
        Me.btnParchaPre.UseVisualStyleBackColor = true
        '
        'btnParchaNext
        '
        Me.btnParchaNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParchaNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnParchaNext.Location = New System.Drawing.Point(413, 512)
        Me.btnParchaNext.Name = "btnParchaNext"
        Me.btnParchaNext.Size = New System.Drawing.Size(75, 29)
        Me.btnParchaNext.TabIndex = 8
        Me.btnParchaNext.Text = ">"
        Me.btnParchaNext.UseVisualStyleBackColor = true
        '
        'btnInvestiNext
        '
        Me.btnInvestiNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvestiNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnInvestiNext.Location = New System.Drawing.Point(827, 512)
        Me.btnInvestiNext.Name = "btnInvestiNext"
        Me.btnInvestiNext.Size = New System.Drawing.Size(75, 29)
        Me.btnInvestiNext.TabIndex = 10
        Me.btnInvestiNext.Text = ">"
        Me.btnInvestiNext.UseVisualStyleBackColor = true
        '
        'btnInvestiPre
        '
        Me.btnInvestiPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvestiPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnInvestiPre.Location = New System.Drawing.Point(746, 512)
        Me.btnInvestiPre.Name = "btnInvestiPre"
        Me.btnInvestiPre.Size = New System.Drawing.Size(75, 29)
        Me.btnInvestiPre.TabIndex = 9
        Me.btnInvestiPre.Text = "<"
        Me.btnInvestiPre.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(207,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 52)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(431, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Patient Document"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Patient Name :"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = true
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(131, 142)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(12, 16)
        Me.lblPatientName.TabIndex = 13
        Me.lblPatientName.Text = "-"
        '
        'PictureInvestigation
        '
        Me.PictureInvestigation.BackgroundImage = Global.DoctorHelp.My.Resources.Resources.noimage
        Me.PictureInvestigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureInvestigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureInvestigation.Location = New System.Drawing.Point(651, 92)
        Me.PictureInvestigation.Name = "PictureInvestigation"
        Me.PictureInvestigation.Size = New System.Drawing.Size(345, 406)
        Me.PictureInvestigation.TabIndex = 1
        Me.PictureInvestigation.TabStop = false
        '
        'PictureParcha
        '
        Me.PictureParcha.BackgroundImage = Global.DoctorHelp.My.Resources.Resources.noimage
        Me.PictureParcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureParcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureParcha.Location = New System.Drawing.Point(232, 92)
        Me.PictureParcha.Name = "PictureParcha"
        Me.PictureParcha.Size = New System.Drawing.Size(345, 406)
        Me.PictureParcha.TabIndex = 0
        Me.PictureParcha.TabStop = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "OPD ID :"
        '
        'lblOPDID
        '
        Me.lblOPDID.AutoSize = true
        Me.lblOPDID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblOPDID.Location = New System.Drawing.Point(132, 195)
        Me.lblOPDID.Name = "lblOPDID"
        Me.lblOPDID.Size = New System.Drawing.Size(12, 16)
        Me.lblOPDID.TabIndex = 15
        Me.lblOPDID.Text = "-"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(940, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Label4.Location = New System.Drawing.Point(337, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Prescription"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Label5.Location = New System.Drawing.Point(777, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Investigation"
        '
        'frmParcha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(234,Byte),Integer), CType(CType(234,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1054, 568)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblOPDID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnInvestiNext)
        Me.Controls.Add(Me.btnInvestiPre)
        Me.Controls.Add(Me.btnParchaNext)
        Me.Controls.Add(Me.btnParchaPre)
        Me.Controls.Add(Me.PictureInvestigation)
        Me.Controls.Add(Me.PictureParcha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmParcha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureInvestigation,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureParcha,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureParcha As PictureBox
    Friend WithEvents PictureInvestigation As PictureBox
    Friend WithEvents btnParchaPre As Button
    Friend WithEvents btnParchaNext As Button
    Friend WithEvents btnInvestiNext As Button
    Friend WithEvents btnInvestiPre As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents lblPatientName As Label
    Friend WithEvents Label3 As Label
    Public WithEvents lblOPDID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
