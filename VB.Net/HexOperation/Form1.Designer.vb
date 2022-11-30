<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.txtfile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtvalue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtreplace = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.btn_replace = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtfile
        '
        Me.txtfile.Location = New System.Drawing.Point(99, 26)
        Me.txtfile.Name = "txtfile"
        Me.txtfile.Size = New System.Drawing.Size(196, 20)
        Me.txtfile.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Location : "
        '
        'txtvalue
        '
        Me.txtvalue.Location = New System.Drawing.Point(99, 52)
        Me.txtvalue.Name = "txtvalue"
        Me.txtvalue.Size = New System.Drawing.Size(145, 20)
        Me.txtvalue.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Original String : "
        '
        'txtreplace
        '
        Me.txtreplace.Location = New System.Drawing.Point(99, 78)
        Me.txtreplace.Name = "txtreplace"
        Me.txtreplace.Size = New System.Drawing.Size(145, 20)
        Me.txtreplace.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Replaced String :"
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(301, 24)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(75, 23)
        Me.btn_browse.TabIndex = 2
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'btn_replace
        '
        Me.btn_replace.Location = New System.Drawing.Point(301, 76)
        Me.btn_replace.Name = "btn_replace"
        Me.btn_replace.Size = New System.Drawing.Size(75, 23)
        Me.btn_replace.TabIndex = 2
        Me.btn_replace.Text = "Replace"
        Me.btn_replace.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 132)
        Me.Controls.Add(Me.btn_replace)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtreplace)
        Me.Controls.Add(Me.txtvalue)
        Me.Controls.Add(Me.txtfile)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hex Operation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtfile As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtvalue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtreplace As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_browse As Button
    Friend WithEvents btn_replace As Button
End Class
