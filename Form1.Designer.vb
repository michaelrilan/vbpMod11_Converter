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
        Me.resultss = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.input_cad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usd_btn = New System.Windows.Forms.RadioButton()
        Me.euro_btn = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'resultss
        '
        Me.resultss.AutoSize = True
        Me.resultss.Location = New System.Drawing.Point(17, 181)
        Me.resultss.Name = "resultss"
        Me.resultss.Size = New System.Drawing.Size(10, 13)
        Me.resultss.TabIndex = 0
        Me.resultss.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Money Converter"
        '
        'input_cad
        '
        Me.input_cad.Location = New System.Drawing.Point(171, 69)
        Me.input_cad.Name = "input_cad"
        Me.input_cad.Size = New System.Drawing.Size(42, 20)
        Me.input_cad.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter CAD currency to convert:"
        '
        'usd_btn
        '
        Me.usd_btn.AutoSize = True
        Me.usd_btn.Location = New System.Drawing.Point(45, 103)
        Me.usd_btn.Name = "usd_btn"
        Me.usd_btn.Size = New System.Drawing.Size(48, 17)
        Me.usd_btn.TabIndex = 4
        Me.usd_btn.TabStop = True
        Me.usd_btn.Text = "USD"
        Me.usd_btn.UseVisualStyleBackColor = True
        '
        'euro_btn
        '
        Me.euro_btn.AutoSize = True
        Me.euro_btn.Location = New System.Drawing.Point(45, 126)
        Me.euro_btn.Name = "euro_btn"
        Me.euro_btn.Size = New System.Drawing.Size(47, 17)
        Me.euro_btn.TabIndex = 5
        Me.euro_btn.TabStop = True
        Me.euro_btn.Text = "Euro"
        Me.euro_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 272)
        Me.Controls.Add(Me.euro_btn)
        Me.Controls.Add(Me.usd_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.input_cad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.resultss)
        Me.Name = "Form1"
        Me.Text = "vbpMod11_Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resultss As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents input_cad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents usd_btn As RadioButton
    Friend WithEvents euro_btn As RadioButton
End Class
