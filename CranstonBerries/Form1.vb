Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'take whatever percentage increase is in the increase text box and add the 
        'percentage of the sales to the sales, so it increases by however much percentage it is
        lblStrawProSales.Text = (Val(txtStrawInc.Text) * Val(txtStrawSales.Text)) + Val(txtStrawSales.Text)
        lblStrawProSales.Text = Format(lblStrawProSales.Text, "currency")
        lblBlueProSales.Text = (Val(txtBlueInc.Text) * Val(txtBlueSales.Text)) + Val(txtBlueSales.Text)
        lblBlueProSales.Text = Format(lblBlueProSales.Text, "currency")
        lblRaspProSales.Text = (Val(txtRaspInc.Text) * Val(txtRaspSales.Text)) + Val(txtRaspSales.Text)
        lblRaspProSales.Text = Format(lblRaspProSales.Text, "currency")
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBlueInc.Clear()
        txtBlueSales.Clear()
        txtRaspInc.Clear()
        txtRaspSales.Clear()
        txtStrawInc.Clear()
        txtStrawSales.Clear()
        lblBlueProSales.ResetText()
        lblRaspProSales.ResetText()
        lblStrawProSales.ResetText()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnPrint.Visible = False
        PrintForm1.Print()
        btnCalc.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
        btnPrint.Visible = True
    End Sub

End Class
