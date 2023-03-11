Public Class Form1
    Dim prcCappuccino As Single = 2.0
    Dim prcExpresso As Single = 2.25
    Dim prcLatte As Single = 1.75
    Dim prcIced As Single = 2.5

    Dim perTax As Single = 0.08

    Dim statOrderCount As Integer = 0
    Dim statTotalSales As Single = 0
    Dim statAverage As Single = 0

    Dim dueTotal As Single

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim quantity As Integer = 0
        Dim tax As Single = 0
        'Check if quantity is not 0
        If Val(txtQuantity.Text) <= 0 Then
            txtQuantity.Text = "Input a number."
            Return
        Else
            quantity = Val(txtQuantity.Text)
        End If
        'Determine Cup Price
        Dim cupPrice = getCupPrice()

        'Multiply by quantity
        Dim totalCupPrice = quantity * cupPrice


        'Get tax if needed
        If chkTax.Checked Then
            tax = cFindTax(totalCupPrice)
        End If

        'Add tax to item total (If needed)
        dueTotal = totalCupPrice + tax
        'Diplay values.

        lblItemAmount.Text = cupPrice
        lblSubTotal.Text = totalCupPrice
        lblTax.Text = tax
        lblTotal.Text = dueTotal
    End Sub
    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        'Clear the coffee selections
        optCappuccino.Checked = False
        optExpresso.Checked = False
        optLatte.Checked = False
        optIcedLatte.Checked = False
        optIcedCappuccino.Checked = False

        'Clear the quantity and item price.
        txtQuantity.Text = ""
        lblItemAmount.Text = ""

        'Disable the takeout checkbox
        chkTax.Checked = False

        'Set focus to quantity
        txtQuantity.Select()
    End Sub
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        'Clear the previous order
        cmdClear_Click(sender, New System.EventArgs())

        'Accumulate the total and count
        statOrderCount = statOrderCount + 1
        statTotalSales = statTotalSales + dueTotal

        'Set subtotal and total to 0.
        lblSubTotal.Text = 0
        lblTax.Text = 0
        lblTotal.Text = 0

    End Sub
    Private Sub mnuFileSummary_Click(sender As Object, e As EventArgs) Handles mnuFileSummary.Click
        MsgBox("Average Sales: " & statTotalSales / statOrderCount & vbNewLine & "Total Sales: " & statTotalSales & vbNewLine & "Total Orders: " & statOrderCount, vbInformation, "Summary")
    End Sub
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        End
    End Sub
    Private Sub mnuEditCalc_Click(sender As Object, e As EventArgs) Handles mnuEditCalc.Click
        cmdCalculate_Click(sender, New System.EventArgs())
    End Sub
    Private Sub mnuEditClear_Click(sender As Object, e As EventArgs) Handles mnuEditClear.Click
        cmdClear_Click(sender, New System.EventArgs())
    End Sub

    'Functions
    Private Function getCupPrice()
        If optCappuccino.Checked Then
            Return prcCappuccino
        ElseIf optExpresso.Checked Then
            Return prcExpresso
        ElseIf optLatte.Checked Then
            Return prcLatte
        ElseIf optIcedLatte.Checked Or optIcedCappuccino.Checked Then
            Return prcIced
        End If
    End Function

    Private Function cFindTax(price As Integer)
        Return price * perTax
    End Function
End Class
