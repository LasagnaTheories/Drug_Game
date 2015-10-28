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
        Me.btnAddMoney = New System.Windows.Forms.Button()
        Me.tmrScreenUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.tmrUIRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.btnRemoveMoney = New System.Windows.Forms.Button()
        Me.btnSellWeed = New System.Windows.Forms.Button()
        Me.tmrWeed = New System.Windows.Forms.Timer(Me.components)
        Me.barJob = New System.Windows.Forms.ProgressBar()
        Me.chkRepeatJob = New System.Windows.Forms.CheckBox()
        Me.btnSellWhitePowder = New System.Windows.Forms.Button()
        Me.barJob2 = New System.Windows.Forms.ProgressBar()
        Me.chkRepeatJob2 = New System.Windows.Forms.CheckBox()
        Me.tmrWhitePowder = New System.Windows.Forms.Timer(Me.components)
        Me.btnBuyWeed = New System.Windows.Forms.Button()
        Me.btnBuyWhitePowder = New System.Windows.Forms.Button()
        Me.lsvwInventory = New System.Windows.Forms.ListView()
        Me.colDrug = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWeed = New System.Windows.Forms.Label()
        Me.lblWhitePowder = New System.Windows.Forms.Label()
        Me.lsvwCityPrices = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCity = New System.Windows.Forms.Label()
        Me.btnRandomizePrices = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCleanMoney = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddMoney
        '
        Me.btnAddMoney.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMoney.ForeColor = System.Drawing.Color.White
        Me.btnAddMoney.Location = New System.Drawing.Point(247, 360)
        Me.btnAddMoney.Name = "btnAddMoney"
        Me.btnAddMoney.Size = New System.Drawing.Size(97, 23)
        Me.btnAddMoney.TabIndex = 0
        Me.btnAddMoney.Text = "Add Money"
        Me.btnAddMoney.UseVisualStyleBackColor = False
        '
        'tmrScreenUpdate
        '
        Me.tmrScreenUpdate.Interval = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Whore Money:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.IndianRed
        Me.lblMoney.Location = New System.Drawing.Point(91, 18)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(0, 13)
        Me.lblMoney.TabIndex = 2
        '
        'tmrUIRefresh
        '
        '
        'btnRemoveMoney
        '
        Me.btnRemoveMoney.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRemoveMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveMoney.ForeColor = System.Drawing.Color.White
        Me.btnRemoveMoney.Location = New System.Drawing.Point(350, 360)
        Me.btnRemoveMoney.Name = "btnRemoveMoney"
        Me.btnRemoveMoney.Size = New System.Drawing.Size(97, 23)
        Me.btnRemoveMoney.TabIndex = 0
        Me.btnRemoveMoney.Text = "Remove Money"
        Me.btnRemoveMoney.UseVisualStyleBackColor = False
        '
        'btnSellWeed
        '
        Me.btnSellWeed.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSellWeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSellWeed.ForeColor = System.Drawing.Color.White
        Me.btnSellWeed.Location = New System.Drawing.Point(138, 78)
        Me.btnSellWeed.Name = "btnSellWeed"
        Me.btnSellWeed.Size = New System.Drawing.Size(60, 23)
        Me.btnSellWeed.TabIndex = 0
        Me.btnSellWeed.Text = "Sell"
        Me.btnSellWeed.UseVisualStyleBackColor = False
        '
        'tmrWeed
        '
        '
        'barJob
        '
        Me.barJob.ForeColor = System.Drawing.SystemColors.Desktop
        Me.barJob.Location = New System.Drawing.Point(204, 78)
        Me.barJob.Name = "barJob"
        Me.barJob.Size = New System.Drawing.Size(73, 23)
        Me.barJob.TabIndex = 3
        '
        'chkRepeatJob
        '
        Me.chkRepeatJob.AutoSize = True
        Me.chkRepeatJob.ForeColor = System.Drawing.Color.White
        Me.chkRepeatJob.Location = New System.Drawing.Point(148, 55)
        Me.chkRepeatJob.Name = "chkRepeatJob"
        Me.chkRepeatJob.Size = New System.Drawing.Size(81, 17)
        Me.chkRepeatJob.TabIndex = 4
        Me.chkRepeatJob.Text = "Repeat Job"
        Me.chkRepeatJob.UseVisualStyleBackColor = True
        '
        'btnSellWhitePowder
        '
        Me.btnSellWhitePowder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSellWhitePowder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSellWhitePowder.ForeColor = System.Drawing.Color.White
        Me.btnSellWhitePowder.Location = New System.Drawing.Point(138, 111)
        Me.btnSellWhitePowder.Name = "btnSellWhitePowder"
        Me.btnSellWhitePowder.Size = New System.Drawing.Size(60, 23)
        Me.btnSellWhitePowder.TabIndex = 0
        Me.btnSellWhitePowder.Text = "Sell"
        Me.btnSellWhitePowder.UseVisualStyleBackColor = False
        '
        'barJob2
        '
        Me.barJob2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.barJob2.Location = New System.Drawing.Point(204, 111)
        Me.barJob2.Name = "barJob2"
        Me.barJob2.Size = New System.Drawing.Size(73, 23)
        Me.barJob2.TabIndex = 3
        '
        'chkRepeatJob2
        '
        Me.chkRepeatJob2.AutoSize = True
        Me.chkRepeatJob2.ForeColor = System.Drawing.Color.White
        Me.chkRepeatJob2.Location = New System.Drawing.Point(148, 140)
        Me.chkRepeatJob2.Name = "chkRepeatJob2"
        Me.chkRepeatJob2.Size = New System.Drawing.Size(81, 17)
        Me.chkRepeatJob2.TabIndex = 4
        Me.chkRepeatJob2.Text = "Repeat Job"
        Me.chkRepeatJob2.UseVisualStyleBackColor = True
        '
        'tmrWhitePowder
        '
        '
        'btnBuyWeed
        '
        Me.btnBuyWeed.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBuyWeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuyWeed.ForeColor = System.Drawing.Color.White
        Me.btnBuyWeed.Location = New System.Drawing.Point(72, 78)
        Me.btnBuyWeed.Name = "btnBuyWeed"
        Me.btnBuyWeed.Size = New System.Drawing.Size(60, 23)
        Me.btnBuyWeed.TabIndex = 0
        Me.btnBuyWeed.Text = "Buy"
        Me.btnBuyWeed.UseVisualStyleBackColor = False
        '
        'btnBuyWhitePowder
        '
        Me.btnBuyWhitePowder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBuyWhitePowder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuyWhitePowder.ForeColor = System.Drawing.Color.White
        Me.btnBuyWhitePowder.Location = New System.Drawing.Point(72, 111)
        Me.btnBuyWhitePowder.Name = "btnBuyWhitePowder"
        Me.btnBuyWhitePowder.Size = New System.Drawing.Size(60, 23)
        Me.btnBuyWhitePowder.TabIndex = 0
        Me.btnBuyWhitePowder.Text = "Buy"
        Me.btnBuyWhitePowder.UseVisualStyleBackColor = False
        '
        'lsvwInventory
        '
        Me.lsvwInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDrug, Me.colQty})
        Me.lsvwInventory.Location = New System.Drawing.Point(479, 35)
        Me.lsvwInventory.Name = "lsvwInventory"
        Me.lsvwInventory.Size = New System.Drawing.Size(174, 196)
        Me.lsvwInventory.TabIndex = 5
        Me.lsvwInventory.UseCompatibleStateImageBehavior = False
        Me.lsvwInventory.View = System.Windows.Forms.View.Details
        '
        'colDrug
        '
        Me.colDrug.Text = "Drug"
        Me.colDrug.Width = 120
        '
        'colQty
        '
        Me.colQty.Text = "Qty"
        Me.colQty.Width = 50
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(479, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Inventory"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblWeed
        '
        Me.lblWeed.BackColor = System.Drawing.Color.MediumAquamarine
        Me.lblWeed.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeed.ForeColor = System.Drawing.Color.White
        Me.lblWeed.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblWeed.Location = New System.Drawing.Point(14, 75)
        Me.lblWeed.Name = "lblWeed"
        Me.lblWeed.Size = New System.Drawing.Size(187, 29)
        Me.lblWeed.TabIndex = 7
        Me.lblWeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWhitePowder
        '
        Me.lblWhitePowder.BackColor = System.Drawing.Color.Honeydew
        Me.lblWhitePowder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhitePowder.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblWhitePowder.Location = New System.Drawing.Point(14, 108)
        Me.lblWhitePowder.Name = "lblWhitePowder"
        Me.lblWhitePowder.Size = New System.Drawing.Size(187, 29)
        Me.lblWhitePowder.TabIndex = 7
        Me.lblWhitePowder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsvwCityPrices
        '
        Me.lsvwCityPrices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lsvwCityPrices.Location = New System.Drawing.Point(284, 35)
        Me.lsvwCityPrices.Name = "lsvwCityPrices"
        Me.lsvwCityPrices.Size = New System.Drawing.Size(174, 196)
        Me.lsvwCityPrices.TabIndex = 5
        Me.lsvwCityPrices.UseCompatibleStateImageBehavior = False
        Me.lsvwCityPrices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Drug"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Buy"
        Me.ColumnHeader2.Width = 45
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sell"
        Me.ColumnHeader3.Width = 45
        '
        'lblCity
        '
        Me.lblCity.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblCity.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.White
        Me.lblCity.Location = New System.Drawing.Point(284, 14)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(174, 20)
        Me.lblCity.TabIndex = 6
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnRandomizePrices
        '
        Me.btnRandomizePrices.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRandomizePrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRandomizePrices.ForeColor = System.Drawing.Color.White
        Me.btnRandomizePrices.Location = New System.Drawing.Point(247, 331)
        Me.btnRandomizePrices.Name = "btnRandomizePrices"
        Me.btnRandomizePrices.Size = New System.Drawing.Size(97, 23)
        Me.btnRandomizePrices.TabIndex = 0
        Me.btnRandomizePrices.Text = "Randomize Prices"
        Me.btnRandomizePrices.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(17, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Clean Money:"
        '
        'lblCleanMoney
        '
        Me.lblCleanMoney.AutoSize = True
        Me.lblCleanMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCleanMoney.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblCleanMoney.Location = New System.Drawing.Point(91, 35)
        Me.lblCleanMoney.Name = "lblCleanMoney"
        Me.lblCleanMoney.Size = New System.Drawing.Size(0, 13)
        Me.lblCleanMoney.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(663, 395)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lsvwCityPrices)
        Me.Controls.Add(Me.lsvwInventory)
        Me.Controls.Add(Me.chkRepeatJob2)
        Me.Controls.Add(Me.chkRepeatJob)
        Me.Controls.Add(Me.barJob2)
        Me.Controls.Add(Me.barJob)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblCleanMoney)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemoveMoney)
        Me.Controls.Add(Me.btnSellWhitePowder)
        Me.Controls.Add(Me.btnBuyWhitePowder)
        Me.Controls.Add(Me.btnBuyWeed)
        Me.Controls.Add(Me.btnSellWeed)
        Me.Controls.Add(Me.btnRandomizePrices)
        Me.Controls.Add(Me.btnAddMoney)
        Me.Controls.Add(Me.lblWhitePowder)
        Me.Controls.Add(Me.lblWeed)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Drug Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddMoney As System.Windows.Forms.Button
    Friend WithEvents tmrScreenUpdate As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents tmrUIRefresh As System.Windows.Forms.Timer
    Friend WithEvents btnRemoveMoney As System.Windows.Forms.Button
    Friend WithEvents btnSellWeed As System.Windows.Forms.Button
    Friend WithEvents tmrWeed As System.Windows.Forms.Timer
    Friend WithEvents barJob As System.Windows.Forms.ProgressBar
    Friend WithEvents chkRepeatJob As System.Windows.Forms.CheckBox
    Friend WithEvents btnSellWhitePowder As System.Windows.Forms.Button
    Friend WithEvents barJob2 As System.Windows.Forms.ProgressBar
    Friend WithEvents chkRepeatJob2 As System.Windows.Forms.CheckBox
    Friend WithEvents tmrWhitePowder As System.Windows.Forms.Timer
    Friend WithEvents btnBuyWeed As System.Windows.Forms.Button
    Friend WithEvents btnBuyWhitePowder As System.Windows.Forms.Button
    Friend WithEvents lsvwInventory As System.Windows.Forms.ListView
    Friend WithEvents colDrug As System.Windows.Forms.ColumnHeader
    Friend WithEvents colQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWeed As System.Windows.Forms.Label
    Friend WithEvents lblWhitePowder As System.Windows.Forms.Label
    Friend WithEvents lsvwCityPrices As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRandomizePrices As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCleanMoney As System.Windows.Forms.Label

End Class
