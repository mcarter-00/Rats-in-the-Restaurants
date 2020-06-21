<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpTool = New System.Windows.Forms.GroupBox()
        Me.chkTable = New System.Windows.Forms.CheckBox()
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.cmdWriteDataListView = New System.Windows.Forms.Button()
        Me.txtFileData = New System.Windows.Forms.TextBox()
        Me.lblValues = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboColumnValue = New System.Windows.Forms.ComboBox()
        Me.cboColumnName = New System.Windows.Forms.ComboBox()
        Me.cmdReadData = New System.Windows.Forms.Button()
        Me.lstSummaryView = New System.Windows.Forms.ListView()
        Me.lstDataView = New System.Windows.Forms.ListView()
        Me.grpTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTool
        '
        Me.grpTool.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpTool.Controls.Add(Me.chkTable)
        Me.grpTool.Controls.Add(Me.txtTarget)
        Me.grpTool.Controls.Add(Me.cmdWriteDataListView)
        Me.grpTool.Controls.Add(Me.txtFileData)
        Me.grpTool.Controls.Add(Me.lblValues)
        Me.grpTool.Controls.Add(Me.Label1)
        Me.grpTool.Controls.Add(Me.cboColumnValue)
        Me.grpTool.Controls.Add(Me.cboColumnName)
        Me.grpTool.Controls.Add(Me.cmdReadData)
        Me.grpTool.Location = New System.Drawing.Point(12, 9)
        Me.grpTool.Name = "grpTool"
        Me.grpTool.Size = New System.Drawing.Size(179, 522)
        Me.grpTool.TabIndex = 1
        Me.grpTool.TabStop = False
        Me.grpTool.Text = "Filter Tools"
        '
        'chkTable
        '
        Me.chkTable.AutoSize = True
        Me.chkTable.Location = New System.Drawing.Point(17, 115)
        Me.chkTable.Name = "chkTable"
        Me.chkTable.Size = New System.Drawing.Size(89, 17)
        Me.chkTable.TabIndex = 4
        Me.chkTable.Text = "Enable Table"
        Me.chkTable.UseVisualStyleBackColor = True
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(16, 267)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.ReadOnly = True
        Me.txtTarget.Size = New System.Drawing.Size(143, 20)
        Me.txtTarget.TabIndex = 4
        '
        'cmdWriteDataListView
        '
        Me.cmdWriteDataListView.Location = New System.Drawing.Point(16, 303)
        Me.cmdWriteDataListView.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdWriteDataListView.Name = "cmdWriteDataListView"
        Me.cmdWriteDataListView.Size = New System.Drawing.Size(143, 23)
        Me.cmdWriteDataListView.TabIndex = 4
        Me.cmdWriteDataListView.Text = "Write Summary"
        Me.cmdWriteDataListView.UseVisualStyleBackColor = True
        '
        'txtFileData
        '
        Me.txtFileData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileData.Location = New System.Drawing.Point(15, 34)
        Me.txtFileData.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFileData.Name = "txtFileData"
        Me.txtFileData.Size = New System.Drawing.Size(144, 20)
        Me.txtFileData.TabIndex = 3
        '
        'lblValues
        '
        Me.lblValues.AutoSize = True
        Me.lblValues.Location = New System.Drawing.Point(14, 201)
        Me.lblValues.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblValues.Name = "lblValues"
        Me.lblValues.Size = New System.Drawing.Size(75, 13)
        Me.lblValues.TabIndex = 2
        Me.lblValues.Text = "Column Value:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Column Name:"
        '
        'cboColumnValue
        '
        Me.cboColumnValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumnValue.FormattingEnabled = True
        Me.cboColumnValue.Location = New System.Drawing.Point(16, 223)
        Me.cboColumnValue.Margin = New System.Windows.Forms.Padding(2)
        Me.cboColumnValue.Name = "cboColumnValue"
        Me.cboColumnValue.Size = New System.Drawing.Size(144, 21)
        Me.cboColumnValue.TabIndex = 1
        '
        'cboColumnName
        '
        Me.cboColumnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumnName.FormattingEnabled = True
        Me.cboColumnName.Location = New System.Drawing.Point(16, 174)
        Me.cboColumnName.Margin = New System.Windows.Forms.Padding(2)
        Me.cboColumnName.Name = "cboColumnName"
        Me.cboColumnName.Size = New System.Drawing.Size(144, 21)
        Me.cboColumnName.TabIndex = 1
        '
        'cmdReadData
        '
        Me.cmdReadData.Location = New System.Drawing.Point(15, 64)
        Me.cmdReadData.Name = "cmdReadData"
        Me.cmdReadData.Size = New System.Drawing.Size(143, 21)
        Me.cmdReadData.TabIndex = 0
        Me.cmdReadData.Text = "Read Data"
        Me.cmdReadData.UseVisualStyleBackColor = True
        '
        'lstSummaryView
        '
        Me.lstSummaryView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSummaryView.BackgroundImageTiled = True
        Me.lstSummaryView.Location = New System.Drawing.Point(215, 9)
        Me.lstSummaryView.Margin = New System.Windows.Forms.Padding(2)
        Me.lstSummaryView.Name = "lstSummaryView"
        Me.lstSummaryView.Size = New System.Drawing.Size(544, 521)
        Me.lstSummaryView.TabIndex = 3
        Me.lstSummaryView.UseCompatibleStateImageBehavior = False
        Me.lstSummaryView.View = System.Windows.Forms.View.Details
        '
        'lstDataView
        '
        Me.lstDataView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstDataView.BackgroundImageTiled = True
        Me.lstDataView.Location = New System.Drawing.Point(773, 10)
        Me.lstDataView.Margin = New System.Windows.Forms.Padding(2)
        Me.lstDataView.Name = "lstDataView"
        Me.lstDataView.Size = New System.Drawing.Size(544, 521)
        Me.lstDataView.TabIndex = 3
        Me.lstDataView.UseCompatibleStateImageBehavior = False
        Me.lstDataView.View = System.Windows.Forms.View.Details
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 541)
        Me.Controls.Add(Me.lstSummaryView)
        Me.Controls.Add(Me.lstDataView)
        Me.Controls.Add(Me.grpTool)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Team 5 Tool"
        Me.grpTool.ResumeLayout(False)
        Me.grpTool.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTool As GroupBox
    Friend WithEvents cmdReadData As Button
    Friend WithEvents txtFileData As TextBox
    Friend WithEvents lblValues As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboColumnValue As ComboBox
    Friend WithEvents cboColumnName As ComboBox
    Friend WithEvents cmdWriteDataListView As Button
    Friend WithEvents lstSummaryView As ListView
    Friend WithEvents txtTarget As TextBox
    Friend WithEvents chkTable As CheckBox
    Friend WithEvents lstDataView As ListView
End Class
