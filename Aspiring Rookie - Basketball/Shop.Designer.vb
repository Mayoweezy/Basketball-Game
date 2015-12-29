<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shop
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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ButItems = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBankShop = New System.Windows.Forms.TextBox()
        Me.ButBuy = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 95)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(228, 289)
        Me.CheckedListBox1.TabIndex = 0
        '
        'ButItems
        '
        Me.ButItems.Location = New System.Drawing.Point(324, 23)
        Me.ButItems.Name = "ButItems"
        Me.ButItems.Size = New System.Drawing.Size(73, 35)
        Me.ButItems.TabIndex = 1
        Me.ButItems.Text = "Items Owned"
        Me.ButItems.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bank"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lifestyle"
        '
        'TxtBankShop
        '
        Me.TxtBankShop.Location = New System.Drawing.Point(47, 9)
        Me.TxtBankShop.Name = "TxtBankShop"
        Me.TxtBankShop.Size = New System.Drawing.Size(212, 20)
        Me.TxtBankShop.TabIndex = 4
        '
        'ButBuy
        '
        Me.ButBuy.Location = New System.Drawing.Point(281, 95)
        Me.ButBuy.Name = "ButBuy"
        Me.ButBuy.Size = New System.Drawing.Size(116, 52)
        Me.ButBuy.TabIndex = 6
        Me.ButBuy.Text = "Buy"
        Me.ButBuy.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(60, 45)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(216, 27)
        Me.ProgressBar1.TabIndex = 7
        '
        'Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 396)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ButBuy)
        Me.Controls.Add(Me.TxtBankShop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButItems)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Name = "Shop"
        Me.Text = "Shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents ButItems As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtBankShop As System.Windows.Forms.TextBox
    Friend WithEvents ButBuy As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
