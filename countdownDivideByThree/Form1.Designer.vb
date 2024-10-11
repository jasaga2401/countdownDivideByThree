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
        Me.txtStartingNumber = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblStartingNumber = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtStartingNumber
        '
        Me.txtStartingNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartingNumber.Location = New System.Drawing.Point(90, 193)
        Me.txtStartingNumber.Name = "txtStartingNumber"
        Me.txtStartingNumber.Size = New System.Drawing.Size(253, 38)
        Me.txtStartingNumber.TabIndex = 0
        Me.txtStartingNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(90, 259)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(253, 51)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblStartingNumber
        '
        Me.lblStartingNumber.AutoSize = True
        Me.lblStartingNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartingNumber.Location = New System.Drawing.Point(86, 162)
        Me.lblStartingNumber.Name = "lblStartingNumber"
        Me.lblStartingNumber.Size = New System.Drawing.Size(133, 20)
        Me.lblStartingNumber.TabIndex = 2
        Me.lblStartingNumber.Text = "Starting number:"
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 29
        Me.lstResults.Location = New System.Drawing.Point(384, 44)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(369, 381)
        Me.lstResults.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.lblStartingNumber)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtStartingNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStartingNumber As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents lblStartingNumber As Label
    Friend WithEvents lstResults As ListBox
End Class
