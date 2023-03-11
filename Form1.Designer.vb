<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optIcedCappuccino = New System.Windows.Forms.RadioButton()
        Me.optIcedLatte = New System.Windows.Forms.RadioButton()
        Me.optLatte = New System.Windows.Forms.RadioButton()
        Me.optExpresso = New System.Windows.Forms.RadioButton()
        Me.optCappuccino = New System.Windows.Forms.RadioButton()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.chkTax = New System.Windows.Forms.CheckBox()
        Me.lblItemAmount = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmdClear)
        Me.GroupBox1.Controls.Add(Me.cmdCalculate)
        Me.GroupBox1.Controls.Add(Me.chkTax)
        Me.GroupBox1.Controls.Add(Me.lblItemAmount)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optIcedCappuccino)
        Me.GroupBox2.Controls.Add(Me.optIcedLatte)
        Me.GroupBox2.Controls.Add(Me.optLatte)
        Me.GroupBox2.Controls.Add(Me.optExpresso)
        Me.GroupBox2.Controls.Add(Me.optCappuccino)
        Me.GroupBox2.Location = New System.Drawing.Point(271, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 156)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee Selections"
        '
        'optIcedCappuccino
        '
        Me.optIcedCappuccino.AutoSize = True
        Me.optIcedCappuccino.Location = New System.Drawing.Point(6, 119)
        Me.optIcedCappuccino.Name = "optIcedCappuccino"
        Me.optIcedCappuccino.Size = New System.Drawing.Size(114, 19)
        Me.optIcedCappuccino.TabIndex = 0
        Me.optIcedCappuccino.TabStop = True
        Me.optIcedCappuccino.Text = "Iced Ca&ppuccino"
        Me.optIcedCappuccino.UseVisualStyleBackColor = True
        '
        'optIcedLatte
        '
        Me.optIcedLatte.AutoSize = True
        Me.optIcedLatte.Location = New System.Drawing.Point(6, 94)
        Me.optIcedLatte.Name = "optIcedLatte"
        Me.optIcedLatte.Size = New System.Drawing.Size(76, 19)
        Me.optIcedLatte.TabIndex = 0
        Me.optIcedLatte.TabStop = True
        Me.optIcedLatte.Text = "&Iced Latte"
        Me.optIcedLatte.UseVisualStyleBackColor = True
        '
        'optLatte
        '
        Me.optLatte.AutoSize = True
        Me.optLatte.Location = New System.Drawing.Point(6, 69)
        Me.optLatte.Name = "optLatte"
        Me.optLatte.Size = New System.Drawing.Size(51, 19)
        Me.optLatte.TabIndex = 0
        Me.optLatte.TabStop = True
        Me.optLatte.Text = "La&tte"
        Me.optLatte.UseVisualStyleBackColor = True
        '
        'optExpresso
        '
        Me.optExpresso.AutoSize = True
        Me.optExpresso.Location = New System.Drawing.Point(6, 47)
        Me.optExpresso.Name = "optExpresso"
        Me.optExpresso.Size = New System.Drawing.Size(70, 19)
        Me.optExpresso.TabIndex = 0
        Me.optExpresso.TabStop = True
        Me.optExpresso.Text = "Espress&o"
        Me.optExpresso.UseVisualStyleBackColor = True
        '
        'optCappuccino
        '
        Me.optCappuccino.AutoSize = True
        Me.optCappuccino.Location = New System.Drawing.Point(6, 22)
        Me.optCappuccino.Name = "optCappuccino"
        Me.optCappuccino.Size = New System.Drawing.Size(89, 19)
        Me.optCappuccino.TabIndex = 0
        Me.optCappuccino.TabStop = True
        Me.optCappuccino.Text = "C&appuccino"
        Me.optCappuccino.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(125, 83)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(88, 43)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "C&lear for Next Item"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(31, 83)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalculate.Size = New System.Drawing.Size(88, 43)
        Me.cmdCalculate.TabIndex = 3
        Me.cmdCalculate.Text = "&Calculate Selection"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'chkTax
        '
        Me.chkTax.AutoSize = True
        Me.chkTax.Location = New System.Drawing.Point(31, 58)
        Me.chkTax.Name = "chkTax"
        Me.chkTax.Size = New System.Drawing.Size(72, 19)
        Me.chkTax.TabIndex = 2
        Me.chkTax.Text = "Takeout?"
        Me.chkTax.UseVisualStyleBackColor = True
        '
        'lblItemAmount
        '
        Me.lblItemAmount.Location = New System.Drawing.Point(115, 135)
        Me.lblItemAmount.Name = "lblItemAmount"
        Me.lblItemAmount.Size = New System.Drawing.Size(81, 23)
        Me.lblItemAmount.TabIndex = 1
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(90, 29)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(70, 23)
        Me.txtQuantity.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Item Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantity"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileSummary, Me.mnuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.Size = New System.Drawing.Size(131, 22)
        Me.mnuFileNew.Text = "&New Order"
        '
        'mnuFileSummary
        '
        Me.mnuFileSummary.Name = "mnuFileSummary"
        Me.mnuFileSummary.Size = New System.Drawing.Size(131, 22)
        Me.mnuFileSummary.Text = "&Summary"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(131, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCalc, Me.mnuEditClear, Me.ToolStripMenuItem2, Me.FontToolStripMenuItem, Me.ColortToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'mnuEditCalc
        '
        Me.mnuEditCalc.Name = "mnuEditCalc"
        Me.mnuEditCalc.Size = New System.Drawing.Size(180, 22)
        Me.mnuEditCalc.Text = "Calculate &Selection"
        '
        'mnuEditClear
        '
        Me.mnuEditClear.Name = "mnuEditClear"
        Me.mnuEditClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuEditClear.Text = "C&lear Item"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ColortToolStripMenuItem
        '
        Me.ColortToolStripMenuItem.Name = "ColortToolStripMenuItem"
        Me.ColortToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ColortToolStripMenuItem.Text = "&Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblSubTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 259)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(523, 112)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Due"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(154, 72)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(101, 23)
        Me.lblTotal.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tax (if Takeout)"
        '
        'lblTax
        '
        Me.lblTax.Location = New System.Drawing.Point(154, 44)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(101, 23)
        Me.lblTax.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SubTotal"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Location = New System.Drawing.Point(154, 16)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(101, 23)
        Me.lblSubTotal.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 387)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Kape ni Pepe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chkTax As CheckBox
    Friend WithEvents lblItemAmount As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optExpresso As RadioButton
    Friend WithEvents optCappuccino As RadioButton
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents optIcedCappuccino As RadioButton
    Friend WithEvents optIcedLatte As RadioButton
    Friend WithEvents optLatte As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSubTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTax As TextBox
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileSummary As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEditCalc As ToolStripMenuItem
    Friend WithEvents mnuEditClear As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
