<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgdEphemeris = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox16 = New System.Windows.Forms.ListBox()
        Me.ListBox15 = New System.Windows.Forms.ListBox()
        Me.ListBox14 = New System.Windows.Forms.ListBox()
        Me.ListBox13 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHMS = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgdEphemeris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgdEphemeris)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1284, 628)
        Me.SplitContainer1.SplitterDistance = 393
        Me.SplitContainer1.TabIndex = 0
        '
        'dgdEphemeris
        '
        Me.dgdEphemeris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdEphemeris.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdEphemeris.Location = New System.Drawing.Point(0, 133)
        Me.dgdEphemeris.Name = "dgdEphemeris"
        Me.dgdEphemeris.Size = New System.Drawing.Size(393, 495)
        Me.dgdEphemeris.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpHMS)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 133)
        Me.Panel1.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(237, 96)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(130, 31)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(18, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Year"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NumericUpDown1.Location = New System.Drawing.Point(36, 37)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(96, 33)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LavenderBlush
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox16, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox15, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox14, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox13, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox6, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox8, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(887, 628)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ListBox16
        '
        Me.ListBox16.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox16.FormattingEnabled = True
        Me.ListBox16.ItemHeight = 15
        Me.ListBox16.Location = New System.Drawing.Point(663, 471)
        Me.ListBox16.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox16.Name = "ListBox16"
        Me.ListBox16.Size = New System.Drawing.Size(224, 157)
        Me.ListBox16.TabIndex = 15
        '
        'ListBox15
        '
        Me.ListBox15.BackColor = System.Drawing.Color.LavenderBlush
        Me.ListBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox15.FormattingEnabled = True
        Me.ListBox15.ItemHeight = 15
        Me.ListBox15.Location = New System.Drawing.Point(442, 471)
        Me.ListBox15.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox15.Name = "ListBox15"
        Me.ListBox15.Size = New System.Drawing.Size(221, 157)
        Me.ListBox15.TabIndex = 14
        '
        'ListBox14
        '
        Me.ListBox14.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox14.FormattingEnabled = True
        Me.ListBox14.ItemHeight = 15
        Me.ListBox14.Location = New System.Drawing.Point(221, 471)
        Me.ListBox14.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox14.Name = "ListBox14"
        Me.ListBox14.Size = New System.Drawing.Size(221, 157)
        Me.ListBox14.TabIndex = 13
        '
        'ListBox13
        '
        Me.ListBox13.BackColor = System.Drawing.Color.LavenderBlush
        Me.ListBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox13.FormattingEnabled = True
        Me.ListBox13.ItemHeight = 15
        Me.ListBox13.Location = New System.Drawing.Point(0, 471)
        Me.ListBox13.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox13.Name = "ListBox13"
        Me.ListBox13.Size = New System.Drawing.Size(221, 157)
        Me.ListBox13.TabIndex = 12
        '
        'ListBox5
        '
        Me.ListBox5.BackColor = System.Drawing.Color.LavenderBlush
        Me.ListBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 15
        Me.ListBox5.Location = New System.Drawing.Point(0, 157)
        Me.ListBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(221, 157)
        Me.ListBox5.TabIndex = 4
        '
        'ListBox4
        '
        Me.ListBox4.BackColor = System.Drawing.Color.LavenderBlush
        Me.ListBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 15
        Me.ListBox4.Location = New System.Drawing.Point(663, 0)
        Me.ListBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(224, 157)
        Me.ListBox4.TabIndex = 3
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 15
        Me.ListBox3.Location = New System.Drawing.Point(442, 0)
        Me.ListBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(221, 157)
        Me.ListBox3.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(221, 0)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(221, 157)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(221, 157)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox6
        '
        Me.ListBox6.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 15
        Me.ListBox6.Location = New System.Drawing.Point(663, 157)
        Me.ListBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(224, 157)
        Me.ListBox6.TabIndex = 5
        '
        'ListBox7
        '
        Me.ListBox7.BackColor = System.Drawing.Color.Cornsilk
        Me.ListBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 15
        Me.ListBox7.Location = New System.Drawing.Point(0, 314)
        Me.ListBox7.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(221, 157)
        Me.ListBox7.TabIndex = 6
        '
        'ListBox8
        '
        Me.ListBox8.BackColor = System.Drawing.Color.LavenderBlush
        Me.ListBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 15
        Me.ListBox8.Location = New System.Drawing.Point(663, 314)
        Me.ListBox8.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(224, 157)
        Me.ListBox8.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(224, 157)
        Me.Label1.Name = "Label1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label1, 2)
        Me.Label1.Size = New System.Drawing.Size(436, 314)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        '
        'dtpHMS
        '
        Me.dtpHMS.CustomFormat = "hh:mm:ss tt"
        Me.dtpHMS.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpHMS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHMS.Location = New System.Drawing.Point(237, 37)
        Me.dtpHMS.Name = "dtpHMS"
        Me.dtpHMS.Size = New System.Drawing.Size(127, 33)
        Me.dtpHMS.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(209, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Start Time"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 628)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgdEphemeris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgdEphemeris As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListBox16 As ListBox
    Friend WithEvents ListBox15 As ListBox
    Friend WithEvents ListBox14 As ListBox
    Friend WithEvents ListBox13 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpHMS As DateTimePicker
End Class
