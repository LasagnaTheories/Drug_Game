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
        Me.lsvwInventory = New System.Windows.Forms.ListView()
        Me.colDrug = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsvwCityPrices = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblCity = New System.Windows.Forms.Label()
        Me.btnRandomizePrices = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCleanMoney = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddCleanMoney = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.btnNextDay = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lsvwFloor = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddSlot = New System.Windows.Forms.Button()
        Me.txtAddMoney = New System.Windows.Forms.TextBox()
        Me.lblTestHoursLeft = New System.Windows.Forms.Label()
        Me.lblHoursLeft = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnWait1 = New System.Windows.Forms.Button()
        Me.btnWait6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddMoney
        '
        Me.btnAddMoney.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMoney.ForeColor = System.Drawing.Color.White
        Me.btnAddMoney.Location = New System.Drawing.Point(247, 367)
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
        Me.Label1.Location = New System.Drawing.Point(12, 25)
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
        Me.lblMoney.Location = New System.Drawing.Point(91, 25)
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
        Me.btnRemoveMoney.Location = New System.Drawing.Point(350, 367)
        Me.btnRemoveMoney.Name = "btnRemoveMoney"
        Me.btnRemoveMoney.Size = New System.Drawing.Size(97, 23)
        Me.btnRemoveMoney.TabIndex = 0
        Me.btnRemoveMoney.Text = "Remove Money"
        Me.btnRemoveMoney.UseVisualStyleBackColor = False
        '
        'lsvwInventory
        '
        Me.lsvwInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDrug, Me.colQty})
        Me.lsvwInventory.Location = New System.Drawing.Point(215, 115)
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
        Me.Label2.Location = New System.Drawing.Point(215, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Dead Nigger Storage"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lsvwCityPrices
        '
        Me.lsvwCityPrices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.lsvwCityPrices.Location = New System.Drawing.Point(25, 115)
        Me.lsvwCityPrices.Name = "lsvwCityPrices"
        Me.lsvwCityPrices.Size = New System.Drawing.Size(174, 196)
        Me.lsvwCityPrices.TabIndex = 5
        Me.lsvwCityPrices.UseCompatibleStateImageBehavior = False
        Me.lsvwCityPrices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Drug"
        Me.ColumnHeader1.Width = 83
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price"
        Me.ColumnHeader2.Width = 45
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Qty"
        Me.ColumnHeader4.Width = 38
        '
        'lblCity
        '
        Me.lblCity.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblCity.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.White
        Me.lblCity.Location = New System.Drawing.Point(25, 94)
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
        Me.btnRandomizePrices.Location = New System.Drawing.Point(247, 338)
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
        Me.Label3.Location = New System.Drawing.Point(17, 42)
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
        Me.lblCleanMoney.Location = New System.Drawing.Point(91, 42)
        Me.lblCleanMoney.Name = "lblCleanMoney"
        Me.lblCleanMoney.Size = New System.Drawing.Size(0, 13)
        Me.lblCleanMoney.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(60, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Double click to buy"
        '
        'btnAddCleanMoney
        '
        Me.btnAddCleanMoney.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddCleanMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCleanMoney.ForeColor = System.Drawing.Color.White
        Me.btnAddCleanMoney.Location = New System.Drawing.Point(247, 396)
        Me.btnAddCleanMoney.Name = "btnAddCleanMoney"
        Me.btnAddCleanMoney.Size = New System.Drawing.Size(97, 37)
        Me.btnAddCleanMoney.TabIndex = 0
        Me.btnAddCleanMoney.Text = "Add Clean Money"
        Me.btnAddCleanMoney.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(60, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Day:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDay.Location = New System.Drawing.Point(91, 9)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(0, 13)
        Me.lblDay.TabIndex = 1
        '
        'btnNextDay
        '
        Me.btnNextDay.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnNextDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextDay.ForeColor = System.Drawing.Color.White
        Me.btnNextDay.Location = New System.Drawing.Point(25, 338)
        Me.btnNextDay.Name = "btnNextDay"
        Me.btnNextDay.Size = New System.Drawing.Size(97, 23)
        Me.btnNextDay.TabIndex = 0
        Me.btnNextDay.Text = "Next Day"
        Me.btnNextDay.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(-190, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Double click to sell"
        '
        'lsvwFloor
        '
        Me.lsvwFloor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.lsvwFloor.Location = New System.Drawing.Point(405, 115)
        Me.lsvwFloor.Name = "lsvwFloor"
        Me.lsvwFloor.Size = New System.Drawing.Size(174, 196)
        Me.lsvwFloor.TabIndex = 5
        Me.lsvwFloor.UseCompatibleStateImageBehavior = False
        Me.lsvwFloor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Drug"
        Me.ColumnHeader3.Width = 83
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Price"
        Me.ColumnHeader6.Width = 45
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Time"
        Me.ColumnHeader5.Width = 42
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(405, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "The Floor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnAddSlot
        '
        Me.btnAddSlot.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSlot.ForeColor = System.Drawing.Color.White
        Me.btnAddSlot.Location = New System.Drawing.Point(585, 221)
        Me.btnAddSlot.Name = "btnAddSlot"
        Me.btnAddSlot.Size = New System.Drawing.Size(97, 23)
        Me.btnAddSlot.TabIndex = 0
        Me.btnAddSlot.Text = "Add Slot"
        Me.btnAddSlot.UseVisualStyleBackColor = False
        '
        'txtAddMoney
        '
        Me.txtAddMoney.Location = New System.Drawing.Point(141, 367)
        Me.txtAddMoney.Name = "txtAddMoney"
        Me.txtAddMoney.Size = New System.Drawing.Size(100, 20)
        Me.txtAddMoney.TabIndex = 7
        '
        'lblTestHoursLeft
        '
        Me.lblTestHoursLeft.AutoSize = True
        Me.lblTestHoursLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTestHoursLeft.Location = New System.Drawing.Point(612, 124)
        Me.lblTestHoursLeft.Name = "lblTestHoursLeft"
        Me.lblTestHoursLeft.Size = New System.Drawing.Size(0, 13)
        Me.lblTestHoursLeft.TabIndex = 1
        '
        'lblHoursLeft
        '
        Me.lblHoursLeft.AutoSize = True
        Me.lblHoursLeft.Location = New System.Drawing.Point(12, 9)
        Me.lblHoursLeft.Name = "lblHoursLeft"
        Me.lblHoursLeft.Size = New System.Drawing.Size(0, 13)
        Me.lblHoursLeft.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(255, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Double click to sell"
        '
        'btnWait1
        '
        Me.btnWait1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnWait1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWait1.ForeColor = System.Drawing.Color.White
        Me.btnWait1.Location = New System.Drawing.Point(585, 140)
        Me.btnWait1.Name = "btnWait1"
        Me.btnWait1.Size = New System.Drawing.Size(97, 23)
        Me.btnWait1.TabIndex = 0
        Me.btnWait1.Text = "Wait 1h"
        Me.btnWait1.UseVisualStyleBackColor = False
        '
        'btnWait6
        '
        Me.btnWait6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnWait6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWait6.ForeColor = System.Drawing.Color.White
        Me.btnWait6.Location = New System.Drawing.Point(585, 169)
        Me.btnWait6.Name = "btnWait6"
        Me.btnWait6.Size = New System.Drawing.Size(97, 23)
        Me.btnWait6.TabIndex = 0
        Me.btnWait6.Text = "Wait 6h"
        Me.btnWait6.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(741, 521)
        Me.Controls.Add(Me.lblHoursLeft)
        Me.Controls.Add(Me.txtAddMoney)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lsvwCityPrices)
        Me.Controls.Add(Me.lsvwFloor)
        Me.Controls.Add(Me.lsvwInventory)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblCleanMoney)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblTestHoursLeft)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemoveMoney)
        Me.Controls.Add(Me.btnWait6)
        Me.Controls.Add(Me.btnWait1)
        Me.Controls.Add(Me.btnAddSlot)
        Me.Controls.Add(Me.btnNextDay)
        Me.Controls.Add(Me.btnRandomizePrices)
        Me.Controls.Add(Me.btnAddCleanMoney)
        Me.Controls.Add(Me.btnAddMoney)
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
    Friend WithEvents lsvwInventory As System.Windows.Forms.ListView
    Friend WithEvents colDrug As System.Windows.Forms.ColumnHeader
    Friend WithEvents colQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsvwCityPrices As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents btnRandomizePrices As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCleanMoney As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddCleanMoney As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents btnNextDay As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lsvwFloor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddSlot As System.Windows.Forms.Button
    Friend WithEvents txtAddMoney As System.Windows.Forms.TextBox
    Friend WithEvents lblTestHoursLeft As System.Windows.Forms.Label
    Friend WithEvents lblHoursLeft As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnWait1 As System.Windows.Forms.Button
    Friend WithEvents btnWait6 As System.Windows.Forms.Button

End Class
