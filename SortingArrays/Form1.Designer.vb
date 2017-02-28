<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrSorting
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
        Me.btnInsertion = New System.Windows.Forms.Button
        Me.tbBefore = New System.Windows.Forms.TextBox
        Me.btnSelection = New System.Windows.Forms.Button
        Me.btnBubble = New System.Windows.Forms.Button
        Me.tbAfter = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnInsertion
        '
        Me.btnInsertion.Location = New System.Drawing.Point(157, 26)
        Me.btnInsertion.Name = "btnInsertion"
        Me.btnInsertion.Size = New System.Drawing.Size(149, 23)
        Me.btnInsertion.TabIndex = 0
        Me.btnInsertion.Text = "Сортування вставками >>"
        Me.btnInsertion.UseVisualStyleBackColor = True
        '
        'tbBefore
        '
        Me.tbBefore.Location = New System.Drawing.Point(12, 26)
        Me.tbBefore.Multiline = True
        Me.tbBefore.Name = "tbBefore"
        Me.tbBefore.Size = New System.Drawing.Size(139, 81)
        Me.tbBefore.TabIndex = 1
        '
        'btnSelection
        '
        Me.btnSelection.Location = New System.Drawing.Point(157, 55)
        Me.btnSelection.Name = "btnSelection"
        Me.btnSelection.Size = New System.Drawing.Size(149, 23)
        Me.btnSelection.TabIndex = 2
        Me.btnSelection.Text = "Сортування вибором >>"
        Me.btnSelection.UseVisualStyleBackColor = True
        '
        'btnBubble
        '
        Me.btnBubble.Location = New System.Drawing.Point(157, 84)
        Me.btnBubble.Name = "btnBubble"
        Me.btnBubble.Size = New System.Drawing.Size(149, 23)
        Me.btnBubble.TabIndex = 3
        Me.btnBubble.Text = "Метод бульбашки >>"
        Me.btnBubble.UseVisualStyleBackColor = True
        '
        'tbAfter
        '
        Me.tbAfter.Location = New System.Drawing.Point(312, 26)
        Me.tbAfter.Multiline = True
        Me.tbAfter.Name = "tbAfter"
        Me.tbAfter.Size = New System.Drawing.Size(139, 81)
        Me.tbAfter.TabIndex = 4
        '
        'frmArrSorting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 145)
        Me.Controls.Add(Me.tbAfter)
        Me.Controls.Add(Me.btnBubble)
        Me.Controls.Add(Me.btnSelection)
        Me.Controls.Add(Me.tbBefore)
        Me.Controls.Add(Me.btnInsertion)
        Me.Name = "frmArrSorting"
        Me.Text = "Сортування"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInsertion As System.Windows.Forms.Button
    Friend WithEvents tbBefore As System.Windows.Forms.TextBox
    Friend WithEvents btnSelection As System.Windows.Forms.Button
    Friend WithEvents btnBubble As System.Windows.Forms.Button
    Friend WithEvents tbAfter As System.Windows.Forms.TextBox

End Class
