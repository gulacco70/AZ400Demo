<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTest
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
        Me.btAvvia = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btAvvia
        '
        Me.btAvvia.Location = New System.Drawing.Point(217, 128)
        Me.btAvvia.Name = "btAvvia"
        Me.btAvvia.Size = New System.Drawing.Size(75, 23)
        Me.btAvvia.TabIndex = 0
        Me.btAvvia.Text = "Avvia"
        Me.btAvvia.UseVisualStyleBackColor = True
        '
        'FrmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 282)
        Me.Controls.Add(Me.btAvvia)
        Me.Name = "FrmTest"
        Me.Text = "Test"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btAvvia As Button
End Class
