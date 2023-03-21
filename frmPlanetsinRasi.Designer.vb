<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanetsinRasi
    Inherits System.Windows.Forms.Form

    ''Form overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Try
    '        If disposing AndAlso components IsNot Nothing Then
    '            components.Dispose()
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub

    ''Required by the Windows Form Designer
    'Private components As System.ComponentModel.IContainer

    ''NOTE: The following procedure is required by the Windows Form Designer
    ''It can be modified using the Windows Form Designer.  
    ''Do not modify it using the code editor.
    '<System.Diagnostics.DebuggerStepThrough()>
    'Private Sub InitializeComponent()
    '    components = New System.ComponentModel.Container
    '    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    '    Me.ClientSize = New System.Drawing.Size(800, 450)
    '    Me.Text = "frmPlanetsinRasi"
    'End Sub
    '***********
    '<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    'Partial Class Form1
    '    Inherits System.Windows.Forms.Form

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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgdEphemeris = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpHMS = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lb6 = New System.Windows.Forms.ListBox()
        Me.lb7 = New System.Windows.Forms.ListBox()
        Me.lb8 = New System.Windows.Forms.ListBox()
        Me.lb9 = New System.Windows.Forms.ListBox()
        Me.lb11 = New System.Windows.Forms.ListBox()
        Me.lb3 = New System.Windows.Forms.ListBox()
        Me.lb2 = New System.Windows.Forms.ListBox()
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.lb12 = New System.Windows.Forms.ListBox()
        Me.lb4 = New System.Windows.Forms.ListBox()
        Me.lb10 = New System.Windows.Forms.ListBox()
        Me.lb5 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1474, 787)
        Me.SplitContainer1.SplitterDistance = 449
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        '
        'dgdEphemeris
        '
        Me.dgdEphemeris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdEphemeris.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdEphemeris.Location = New System.Drawing.Point(0, 115)
        Me.dgdEphemeris.Name = "dgdEphemeris"
        Me.dgdEphemeris.Size = New System.Drawing.Size(449, 672)
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
        Me.Panel1.Size = New System.Drawing.Size(449, 115)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(168, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Start Time"
        '
        'dtpHMS
        '
        Me.dtpHMS.CustomFormat = "hh:mm:ss tt"
        Me.dtpHMS.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.dtpHMS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHMS.Location = New System.Drawing.Point(184, 32)
        Me.dtpHMS.Name = "dtpHMS"
        Me.dtpHMS.Size = New System.Drawing.Size(128, 33)
        Me.dtpHMS.TabIndex = 3
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(203, 83)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(111, 27)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(15, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Year"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(31, 32)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(82, 33)
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
        Me.TableLayoutPanel1.Controls.Add(Me.lb6, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lb7, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lb8, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lb9, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lb11, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lb3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb12, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb4, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lb10, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lb5, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1022, 787)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lb6
        '
        Me.lb6.BackColor = System.Drawing.Color.Cornsilk
        Me.lb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb6.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb6.FormattingEnabled = True
        Me.lb6.ItemHeight = 20
        Me.lb6.Location = New System.Drawing.Point(765, 588)
        Me.lb6.Margin = New System.Windows.Forms.Padding(0)
        Me.lb6.Name = "lb6"
        Me.lb6.Size = New System.Drawing.Size(257, 199)
        Me.lb6.TabIndex = 15
        '
        'lb7
        '
        Me.lb7.BackColor = System.Drawing.Color.LavenderBlush
        Me.lb7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb7.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb7.FormattingEnabled = True
        Me.lb7.ItemHeight = 20
        Me.lb7.Location = New System.Drawing.Point(510, 588)
        Me.lb7.Margin = New System.Windows.Forms.Padding(0)
        Me.lb7.Name = "lb7"
        Me.lb7.Size = New System.Drawing.Size(255, 199)
        Me.lb7.TabIndex = 14
        '
        'lb8
        '
        Me.lb8.BackColor = System.Drawing.Color.Cornsilk
        Me.lb8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb8.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb8.FormattingEnabled = True
        Me.lb8.ItemHeight = 20
        Me.lb8.Location = New System.Drawing.Point(255, 588)
        Me.lb8.Margin = New System.Windows.Forms.Padding(0)
        Me.lb8.Name = "lb8"
        Me.lb8.Size = New System.Drawing.Size(255, 199)
        Me.lb8.TabIndex = 13
        '
        'lb9
        '
        Me.lb9.BackColor = System.Drawing.Color.LavenderBlush
        Me.lb9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb9.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb9.FormattingEnabled = True
        Me.lb9.ItemHeight = 20
        Me.lb9.Location = New System.Drawing.Point(0, 588)
        Me.lb9.Margin = New System.Windows.Forms.Padding(0)
        Me.lb9.Name = "lb9"
        Me.lb9.Size = New System.Drawing.Size(255, 199)
        Me.lb9.TabIndex = 12
        '
        'lb11
        '
        Me.lb11.BackColor = System.Drawing.Color.LavenderBlush
        Me.lb11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb11.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb11.FormattingEnabled = True
        Me.lb11.ItemHeight = 20
        Me.lb11.Location = New System.Drawing.Point(0, 196)
        Me.lb11.Margin = New System.Windows.Forms.Padding(0)
        Me.lb11.Name = "lb11"
        Me.lb11.Size = New System.Drawing.Size(255, 196)
        Me.lb11.TabIndex = 4
        '
        'lb3
        '
        Me.lb3.BackColor = System.Drawing.Color.LavenderBlush
        Me.lb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb3.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb3.FormattingEnabled = True
        Me.lb3.ItemHeight = 20
        Me.lb3.Location = New System.Drawing.Point(765, 0)
        Me.lb3.Margin = New System.Windows.Forms.Padding(0)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(257, 196)
        Me.lb3.TabIndex = 3
        '
        'lb2
        '
        Me.lb2.BackColor = System.Drawing.Color.Cornsilk
        Me.lb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb2.FormattingEnabled = True
        Me.lb2.ItemHeight = 20
        Me.lb2.Location = New System.Drawing.Point(510, 0)
        Me.lb2.Margin = New System.Windows.Forms.Padding(0)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(255, 196)
        Me.lb2.TabIndex = 2
        '
        'lb1
        '
        Me.lb1.BackColor = System.Drawing.Color.LavenderBlush
        Me.lb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.FormattingEnabled = True
        Me.lb1.ItemHeight = 20
        Me.lb1.Location = New System.Drawing.Point(255, 0)
        Me.lb1.Margin = New System.Windows.Forms.Padding(0)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(255, 196)
        Me.lb1.TabIndex = 1
        '
        'lb12
        '
        Me.lb12.BackColor = System.Drawing.Color.Cornsilk
        Me.lb12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb12.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb12.FormattingEnabled = True
        Me.lb12.ItemHeight = 20
        Me.lb12.Location = New System.Drawing.Point(0, 0)
        Me.lb12.Margin = New System.Windows.Forms.Padding(0)
        Me.lb12.Name = "lb12"
        Me.lb12.Size = New System.Drawing.Size(255, 196)
        Me.lb12.TabIndex = 0
        '
        'lb4
        '
        Me.lb4.BackColor = System.Drawing.Color.Cornsilk
        Me.lb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb4.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb4.FormattingEnabled = True
        Me.lb4.ItemHeight = 20
        Me.lb4.Location = New System.Drawing.Point(765, 196)
        Me.lb4.Margin = New System.Windows.Forms.Padding(0)
        Me.lb4.Name = "lb4"
        Me.lb4.Size = New System.Drawing.Size(257, 196)
        Me.lb4.TabIndex = 5
        '
        'lb10
        '
        Me.lb10.BackColor = System.Drawing.Color.Cornsilk
        Me.lb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb10.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb10.FormattingEnabled = True
        Me.lb10.ItemHeight = 20
        Me.lb10.Location = New System.Drawing.Point(0, 392)
        Me.lb10.Margin = New System.Windows.Forms.Padding(0)
        Me.lb10.Name = "lb10"
        Me.lb10.Size = New System.Drawing.Size(255, 196)
        Me.lb10.TabIndex = 6
        '
        'lb5
        '
        Me.lb5.BackColor = System.Drawing.Color.LavenderBlush
        Me.lb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb5.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb5.FormattingEnabled = True
        Me.lb5.ItemHeight = 20
        Me.lb5.Location = New System.Drawing.Point(765, 392)
        Me.lb5.Margin = New System.Windows.Forms.Padding(0)
        Me.lb5.Name = "lb5"
        Me.lb5.Size = New System.Drawing.Size(257, 196)
        Me.lb5.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(258, 196)
        Me.Label1.Name = "Label1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label1, 2)
        Me.Label1.Size = New System.Drawing.Size(504, 392)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        '
        'frmPlanetsinRasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1474, 787)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmPlanetsinRasi"
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
    Friend WithEvents lb6 As ListBox
    Friend WithEvents lb7 As ListBox
    Friend WithEvents lb8 As ListBox
    Friend WithEvents lb9 As ListBox
    Friend WithEvents lb11 As ListBox
    Friend WithEvents lb3 As ListBox
    Friend WithEvents lb2 As ListBox
    Friend WithEvents lb1 As ListBox
    Friend WithEvents lb12 As ListBox
    Friend WithEvents lb4 As ListBox
    Friend WithEvents lb10 As ListBox
    Friend WithEvents lb5 As ListBox
    Friend WithEvents Label1 As Label
        Friend WithEvents btnSubmit As Button
        Friend WithEvents Label3 As Label
        Friend WithEvents dtpHMS As DateTimePicker
    End Class
