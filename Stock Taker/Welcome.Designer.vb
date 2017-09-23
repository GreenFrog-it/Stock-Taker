<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnListedProd = New System.Windows.Forms.Button()
        Me.btnSupplies = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Font = New System.Drawing.Font("Liberation Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(136, 54)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(847, 191)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAccounts
        '
        Me.btnAccounts.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAccounts.Location = New System.Drawing.Point(136, 445)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(240, 67)
        Me.btnAccounts.TabIndex = 1
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnHelp.Location = New System.Drawing.Point(136, 297)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(240, 67)
        Me.btnHelp.TabIndex = 2
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnExit.Location = New System.Drawing.Point(743, 297)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(240, 67)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit Application"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnListedProd
        '
        Me.btnListedProd.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnListedProd.Location = New System.Drawing.Point(743, 445)
        Me.btnListedProd.Name = "btnListedProd"
        Me.btnListedProd.Size = New System.Drawing.Size(240, 67)
        Me.btnListedProd.TabIndex = 4
        Me.btnListedProd.Text = "Listed Products"
        Me.btnListedProd.UseVisualStyleBackColor = False
        '
        'btnSupplies
        '
        Me.btnSupplies.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSupplies.Location = New System.Drawing.Point(433, 445)
        Me.btnSupplies.Name = "btnSupplies"
        Me.btnSupplies.Size = New System.Drawing.Size(240, 67)
        Me.btnSupplies.TabIndex = 5
        Me.btnSupplies.Text = "Supplies"
        Me.btnSupplies.UseVisualStyleBackColor = False
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1106, 570)
        Me.Controls.Add(Me.btnSupplies)
        Me.Controls.Add(Me.btnListedProd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnAccounts)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Welcome"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnListedProd As Button
    Friend WithEvents btnSupplies As Button
End Class
