Public Class Form1
    'Initializing some essential variables towards processing a cusomter's order
    'A parallel array is also initialized alongside of the DVDs list box or lstShelf
    Dim dblPrices = New Double() {10, 20, 30.99, 5.99, 5, 25.99, 29.99, 30.0, 20, 20}
    Dim dblSubTotal As Double = 0
    Dim intShipping As Integer = 0
    Dim dblTaxRate As Double = 0.04
    Dim Tax As Double
    Dim dblTotal As Double
    Dim strID As String

    'Upon application startup this event reads all data within the listDVDs.txt file
    'and puts it into lstShelf
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileIn As IO.StreamReader

        If IO.File.Exists("listDVDs.txt") Then

            fileIn = IO.File.OpenText("listDVDs.txt")
            Do Until fileIn.Peek = -1
                lstShelf.Items.Add(fileIn.ReadLine)
            Loop
            fileIn.Close()

        End If

    End Sub
    'Clicking this button updates several variables depedning on the selected index from lstShelf
    'the lstShelf index is then used on a parallel array to get the cost of the DVD
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            lstCart.Items.Add(lstShelf.SelectedItem)
            dblSubTotal += dblPrices(lstShelf.SelectedIndex)

            Tax = dblTaxRate * dblSubTotal

            If (intShipping <> 5) Then
                intShipping += 1
            End If

            dblTotal = dblSubTotal + Tax + intShipping

            lblTotals.Text = "SubTotal: " & dblSubTotal.ToString("C2") & vbNewLine & "Tax: " & Tax.ToString("C2") & vbNewLine & "Shipping: " & intShipping.ToString("C2") & vbNewLine & Space(5) & "Total: " & dblTotal.ToString("C2")

        Catch ex As Exception
            lblTotals.Text = "ERROR NO ITEM SELECTED"
        End Try

    End Sub
    'This click event activates, when a valid id is input, a StreamWriter object which then
    'writes the subtotal, total, tax, and shipping variables into a text document called customerReceipts
    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click

        Dim outFile As IO.StreamWriter

        If txtCustomerID.Text.Length = 4 Then

            strID = txtCustomerID.Text

            outFile = IO.File.AppendText("customerReceipts.txt")

            outFile.WriteLine(strID & Space(12) & dblTotal.ToString("C2") & Space(13 - dblTotal.ToString.Length) & dblSubTotal.ToString("C2") & Space(14 - dblSubTotal.ToString.Length) & Tax & Space(10 - Tax.ToString.Length) & intShipping)

            outFile.Close()

            dblSubTotal = 0
            Tax = 0
            dblTotal = 0
            intShipping = 0
            lblTotals.Text = ""
            txtCustomerID.Text = ""
            lstCart.Items.Clear()

        Else

            lblTotals.Text = "PLEASE ENTER CUSTOMER ID THAT IS 4 CHARACTERS LONG"

        End If

    End Sub

    'Closes the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Does the opposite of the btnAdd click event by reversing the changes btnAdd made towards 
    'the subtotal, tax,  shipping, and total variables
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try

            dblSubTotal -= dblPrices(lstShelf.Items.IndexOf(lstCart.SelectedItem))
            lstCart.Items.RemoveAt(lstCart.SelectedIndex)

            Tax = dblTaxRate * dblSubTotal

            If (intShipping <= 5 And intShipping > 0) Then
                intShipping -= 1
            End If

            dblTotal = dblSubTotal + Tax + intShipping

            lblTotals.Text = "SubTotal: " & dblSubTotal.ToString("C2") & vbNewLine & "Tax: " & Tax.ToString("C2") & vbNewLine & "Shipping: " & intShipping.ToString("C2") & vbNewLine & "       Total: " & dblTotal.ToString("C2")

        Catch ex As Exception

            lblTotals.Text = "ERROR NO ITEM SELECTED"

        End Try
    End Sub
End Class
