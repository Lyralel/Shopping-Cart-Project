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
        Me.lstShelf = New System.Windows.Forms.ListBox()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstShelf
        '
        Me.lstShelf.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstShelf.FormattingEnabled = True
        Me.lstShelf.Location = New System.Drawing.Point(12, 25)
        Me.lstShelf.Name = "lstShelf"
        Me.lstShelf.Size = New System.Drawing.Size(145, 134)
        Me.lstShelf.TabIndex = 0
        Me.lstShelf.TabStop = False
        '
        'lstCart
        '
        Me.lstCart.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.Location = New System.Drawing.Point(238, 25)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(141, 134)
        Me.lstCart.TabIndex = 1
        Me.lstCart.TabStop = False
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(161, 90)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "<<&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(161, 61)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add>>"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTotals
        '
        Me.lblTotals.Location = New System.Drawing.Point(382, 25)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(173, 71)
        Me.lblTotals.TabIndex = 4
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(473, 122)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(40, 37)
        Me.btnBuy.TabIndex = 3
        Me.btnBuy.Text = "&Buy"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(519, 122)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 37)
        Me.btnExit.TabIndex = 6
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cart"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "DVDs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(386, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Customer ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(385, 122)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(82, 20)
        Me.txtCustomerID.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(567, 171)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.lblTotals)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.lstShelf)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Name = "Form1"
        Me.Text = "Shopping Cart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstShelf As ListBox
    Friend WithEvents lstCart As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblTotals As Label
    Friend WithEvents btnBuy As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerID As TextBox
End Class
