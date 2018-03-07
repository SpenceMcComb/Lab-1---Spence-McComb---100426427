<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUserInput = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUnitsShipped = New System.Windows.Forms.TextBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUserInput
        '
        Me.lblUserInput.Location = New System.Drawing.Point(64, 21)
        Me.lblUserInput.Name = "lblUserInput"
        Me.lblUserInput.Size = New System.Drawing.Size(34, 13)
        Me.lblUserInput.TabIndex = 0
        Me.lblUserInput.Text = "&Units:"
        Me.lblUserInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(217, 21)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(35, 13)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(104, 18)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(75, 20)
        Me.txtUserInput.TabIndex = 1
        Me.ToolTips.SetToolTip(Me.txtUserInput, "Enter the daily units shipped here.")
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverage.Location = New System.Drawing.Point(42, 168)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(210, 23)
        Me.lblAverage.TabIndex = 0
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblAverage, "The result of the average calculation.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(23, 194)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.ToolTips.SetToolTip(Me.btnEnter, "Calulates the average of the 7 entires.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(104, 194)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.ToolTips.SetToolTip(Me.btnReset, "Resets the form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(188, 194)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.ToolTips.SetToolTip(Me.btnExit, "Exits the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtUnitsShipped
        '
        Me.txtUnitsShipped.Location = New System.Drawing.Point(42, 44)
        Me.txtUnitsShipped.Multiline = True
        Me.txtUnitsShipped.Name = "txtUnitsShipped"
        Me.txtUnitsShipped.Size = New System.Drawing.Size(210, 121)
        Me.txtUnitsShipped.TabIndex = 0
        Me.txtUnitsShipped.TabStop = False
        Me.ToolTips.SetToolTip(Me.txtUnitsShipped, "Previous days' shipped units.")
        '
        'frmLab1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(292, 224)
        Me.Controls.Add(Me.txtUnitsShipped)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUserInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLab1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped Per Week"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserInput As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtUnitsShipped As TextBox
    Friend WithEvents ToolTips As ToolTip
End Class
