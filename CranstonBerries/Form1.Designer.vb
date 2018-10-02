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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblStraw = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRasp = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblProjSales = New System.Windows.Forms.Label()
        Me.lblProjInc = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtStrawSales = New System.Windows.Forms.TextBox()
        Me.txtStrawInc = New System.Windows.Forms.TextBox()
        Me.txtBlueInc = New System.Windows.Forms.TextBox()
        Me.txtBlueSales = New System.Windows.Forms.TextBox()
        Me.txtRaspInc = New System.Windows.Forms.TextBox()
        Me.txtRaspSales = New System.Windows.Forms.TextBox()
        Me.lblStrawProSales = New System.Windows.Forms.Label()
        Me.lblBlueProSales = New System.Windows.Forms.Label()
        Me.lblRaspProSales = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lblStraw
        '
        Me.lblStraw.AutoSize = True
        Me.lblStraw.Location = New System.Drawing.Point(169, 9)
        Me.lblStraw.Name = "lblStraw"
        Me.lblStraw.Size = New System.Drawing.Size(65, 13)
        Me.lblStraw.TabIndex = 0
        Me.lblStraw.Text = "Strawberries"
        Me.lblStraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Location = New System.Drawing.Point(280, 9)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(59, 13)
        Me.lblBlue.TabIndex = 1
        Me.lblBlue.Text = "Blueberries"
        Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRasp
        '
        Me.lblRasp.AutoSize = True
        Me.lblRasp.Location = New System.Drawing.Point(372, 9)
        Me.lblRasp.Name = "lblRasp"
        Me.lblRasp.Size = New System.Drawing.Size(63, 13)
        Me.lblRasp.TabIndex = 2
        Me.lblRasp.Text = "Raspberries"
        Me.lblRasp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(86, 44)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(33, 13)
        Me.lblSales.TabIndex = 19
        Me.lblSales.Text = "Sales"
        '
        'lblProjSales
        '
        Me.lblProjSales.AutoSize = True
        Me.lblProjSales.Location = New System.Drawing.Point(38, 163)
        Me.lblProjSales.Name = "lblProjSales"
        Me.lblProjSales.Size = New System.Drawing.Size(81, 13)
        Me.lblProjSales.TabIndex = 17
        Me.lblProjSales.Text = "Projected Sales"
        '
        'lblProjInc
        '
        Me.lblProjInc.AutoSize = True
        Me.lblProjInc.Location = New System.Drawing.Point(23, 102)
        Me.lblProjInc.Name = "lblProjInc"
        Me.lblProjInc.Size = New System.Drawing.Size(96, 13)
        Me.lblProjInc.TabIndex = 18
        Me.lblProjInc.Text = "Projected Increase"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(465, 369)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 466
        Me.LineShape2.Y1 = 242
        Me.LineShape2.Y2 = 242
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 153
        Me.LineShape1.X2 = 153
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 367
        '
        'txtStrawSales
        '
        Me.txtStrawSales.Location = New System.Drawing.Point(172, 44)
        Me.txtStrawSales.Name = "txtStrawSales"
        Me.txtStrawSales.Size = New System.Drawing.Size(62, 20)
        Me.txtStrawSales.TabIndex = 4
        '
        'txtStrawInc
        '
        Me.txtStrawInc.Location = New System.Drawing.Point(172, 95)
        Me.txtStrawInc.Name = "txtStrawInc"
        Me.txtStrawInc.Size = New System.Drawing.Size(62, 20)
        Me.txtStrawInc.TabIndex = 5
        '
        'txtBlueInc
        '
        Me.txtBlueInc.Location = New System.Drawing.Point(277, 95)
        Me.txtBlueInc.Name = "txtBlueInc"
        Me.txtBlueInc.Size = New System.Drawing.Size(62, 20)
        Me.txtBlueInc.TabIndex = 7
        '
        'txtBlueSales
        '
        Me.txtBlueSales.Location = New System.Drawing.Point(277, 44)
        Me.txtBlueSales.Name = "txtBlueSales"
        Me.txtBlueSales.Size = New System.Drawing.Size(62, 20)
        Me.txtBlueSales.TabIndex = 6
        '
        'txtRaspInc
        '
        Me.txtRaspInc.Location = New System.Drawing.Point(373, 95)
        Me.txtRaspInc.Name = "txtRaspInc"
        Me.txtRaspInc.Size = New System.Drawing.Size(62, 20)
        Me.txtRaspInc.TabIndex = 9
        '
        'txtRaspSales
        '
        Me.txtRaspSales.Location = New System.Drawing.Point(373, 44)
        Me.txtRaspSales.Name = "txtRaspSales"
        Me.txtRaspSales.Size = New System.Drawing.Size(62, 20)
        Me.txtRaspSales.TabIndex = 8
        '
        'lblStrawProSales
        '
        Me.lblStrawProSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStrawProSales.Location = New System.Drawing.Point(172, 163)
        Me.lblStrawProSales.Name = "lblStrawProSales"
        Me.lblStrawProSales.Size = New System.Drawing.Size(75, 23)
        Me.lblStrawProSales.TabIndex = 10
        '
        'lblBlueProSales
        '
        Me.lblBlueProSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlueProSales.Location = New System.Drawing.Point(277, 163)
        Me.lblBlueProSales.Name = "lblBlueProSales"
        Me.lblBlueProSales.Size = New System.Drawing.Size(75, 23)
        Me.lblBlueProSales.TabIndex = 11
        '
        'lblRaspProSales
        '
        Me.lblRaspProSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRaspProSales.Location = New System.Drawing.Point(373, 163)
        Me.lblRaspProSales.Name = "lblRaspProSales"
        Me.lblRaspProSales.Size = New System.Drawing.Size(75, 23)
        Me.lblRaspProSales.TabIndex = 12
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(360, 305)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(264, 305)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(172, 305)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(41, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 369)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblRaspProSales)
        Me.Controls.Add(Me.lblBlueProSales)
        Me.Controls.Add(Me.lblStrawProSales)
        Me.Controls.Add(Me.txtRaspSales)
        Me.Controls.Add(Me.txtRaspInc)
        Me.Controls.Add(Me.txtBlueSales)
        Me.Controls.Add(Me.txtBlueInc)
        Me.Controls.Add(Me.txtStrawInc)
        Me.Controls.Add(Me.txtStrawSales)
        Me.Controls.Add(Me.lblProjInc)
        Me.Controls.Add(Me.lblProjSales)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.lblRasp)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblStraw)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Projected Sales Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStraw As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblRasp As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblProjSales As Label
    Friend WithEvents lblProjInc As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents txtStrawSales As TextBox
    Friend WithEvents txtStrawInc As TextBox
    Friend WithEvents txtBlueInc As TextBox
    Friend WithEvents txtBlueSales As TextBox
    Friend WithEvents txtRaspInc As TextBox
    Friend WithEvents txtRaspSales As TextBox
    Friend WithEvents lblStrawProSales As Label
    Friend WithEvents lblBlueProSales As Label
    Friend WithEvents lblRaspProSales As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
