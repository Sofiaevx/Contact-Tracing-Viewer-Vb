<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTVForm
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
        Me.DisplayRichTbox = New System.Windows.Forms.RichTextBox()
        Me.SearchTextbox = New System.Windows.Forms.TextBox()
        Me.SNBtn = New System.Windows.Forms.Button()
        Me.SDBtn = New System.Windows.Forms.Button()
        Me.SABtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DisplayRichTbox
        '
        Me.DisplayRichTbox.Location = New System.Drawing.Point(12, 12)
        Me.DisplayRichTbox.Name = "DisplayRichTbox"
        Me.DisplayRichTbox.ReadOnly = True
        Me.DisplayRichTbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.DisplayRichTbox.Size = New System.Drawing.Size(350, 273)
        Me.DisplayRichTbox.TabIndex = 0
        Me.DisplayRichTbox.Text = ""
        '
        'SearchTextbox
        '
        Me.SearchTextbox.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextbox.Location = New System.Drawing.Point(13, 305)
        Me.SearchTextbox.Name = "SearchTextbox"
        Me.SearchTextbox.Size = New System.Drawing.Size(350, 25)
        Me.SearchTextbox.TabIndex = 1
        '
        'SNBtn
        '
        Me.SNBtn.BackColor = System.Drawing.Color.White
        Me.SNBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SNBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SNBtn.Location = New System.Drawing.Point(12, 366)
        Me.SNBtn.Name = "SNBtn"
        Me.SNBtn.Size = New System.Drawing.Size(114, 38)
        Me.SNBtn.TabIndex = 2
        Me.SNBtn.TabStop = False
        Me.SNBtn.Text = "Search by name"
        Me.SNBtn.UseVisualStyleBackColor = False
        '
        'SDBtn
        '
        Me.SDBtn.BackColor = System.Drawing.Color.White
        Me.SDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SDBtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDBtn.Location = New System.Drawing.Point(132, 366)
        Me.SDBtn.Name = "SDBtn"
        Me.SDBtn.Size = New System.Drawing.Size(114, 37)
        Me.SDBtn.TabIndex = 3
        Me.SDBtn.TabStop = False
        Me.SDBtn.Text = "Search by date"
        Me.SDBtn.UseVisualStyleBackColor = False
        '
        'SABtn
        '
        Me.SABtn.BackColor = System.Drawing.Color.White
        Me.SABtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SABtn.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SABtn.Location = New System.Drawing.Point(270, 366)
        Me.SABtn.Name = "SABtn"
        Me.SABtn.Size = New System.Drawing.Size(92, 37)
        Me.SABtn.TabIndex = 4
        Me.SABtn.TabStop = False
        Me.SABtn.Text = "Show all"
        Me.SABtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ex. Dela Cruz, Juan or 10/06/2022"
        '
        'CTVForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(375, 419)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SABtn)
        Me.Controls.Add(Me.SDBtn)
        Me.Controls.Add(Me.SNBtn)
        Me.Controls.Add(Me.SearchTextbox)
        Me.Controls.Add(Me.DisplayRichTbox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTVForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracing Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayRichTbox As RichTextBox
    Friend WithEvents SearchTextbox As TextBox
    Friend WithEvents SNBtn As Button
    Friend WithEvents SDBtn As Button
    Friend WithEvents SABtn As Button
    Friend WithEvents Label1 As Label
End Class
