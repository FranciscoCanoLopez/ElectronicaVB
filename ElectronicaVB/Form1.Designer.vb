Namespace Electronica
    Partial Public Class F
        Inherits Form

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnAddToKart = New Button()
            Me.CBoptions = New ComboBox()
            Me.listView1 = New ListView()
            Me.lbOptions = New Label()
            Me.label1 = New Label()
            Me.label2 = New Label()
            Me.label3 = New Label()
            Me.label4 = New Label()
            Me.label5 = New Label()
            Me.label6 = New Label()
            Me.label7 = New Label()
            Me.label8 = New Label()
            Me.label9 = New Label()
            Me.label10 = New Label()
            Me.kart = New ListView()
            Me.label11 = New Label()
            Me.lblTotalPrice = New Label()
            Me.btnRemoveFromKart = New Button()
            Me.btnBuy = New Button()
            Me.SalesHistory = New ListView()
            Me.lbSaleshistory = New Label()
            Me.btnExportToExcel = New Button()
            Me.btnExportToWord = New Button()
            Me.btnExportToPDF = New Button()
            Me.label12 = New Label()
            Me.btnExportToXML = New Button()
            Me.btnExportToJson = New Button()
            Me.btnExportToTXT = New Button()
            Me.lblWarrenty = New Label()
            Me.SuspendLayout()
            ' 
            ' btnAddToKart
            ' 
            Me.btnAddToKart.BackColor = Color.LightSeaGreen
            Me.btnAddToKart.FlatAppearance.BorderColor = Color.White
            Me.btnAddToKart.FlatStyle = FlatStyle.Popup
            Me.btnAddToKart.Location = New Point(53, 381)
            Me.btnAddToKart.Name = "btnAddToKart"
            Me.btnAddToKart.Size = New Size(199, 35)
            Me.btnAddToKart.TabIndex = 0
            Me.btnAddToKart.Text = "Add To Kart"
            Me.btnAddToKart.UseVisualStyleBackColor = False
            ' 
            ' CBoptions
            ' 
            Me.CBoptions.BackColor = Color.LightSeaGreen
            Me.CBoptions.FlatStyle = FlatStyle.Popup
            Me.CBoptions.FormattingEnabled = True
            Me.CBoptions.Items.AddRange(New Object() {"Cell Phones", "Computers", "Tablets"})
            Me.CBoptions.Location = New Point(53, 77)
            Me.CBoptions.Name = "CBoptions"
            Me.CBoptions.Size = New Size(199, 28)
            Me.CBoptions.TabIndex = 1
            ' 
            ' listView1
            ' 
            Me.listView1.BackColor = Color.Aquamarine
            Me.listView1.Location = New Point(53, 111)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New Size(199, 264)
            Me.listView1.TabIndex = 2
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = View.Details
            ' 
            ' lbOptions
            ' 
            Me.lbOptions.AutoSize = True
            Me.lbOptions.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
            Me.lbOptions.Location = New Point(90, 28)
            Me.lbOptions.Name = "lbOptions"
            Me.lbOptions.Size = New Size(108, 35)
            Me.lbOptions.TabIndex = 4
            Me.lbOptions.Text = "Options"
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label1.Location = New Point(273, 85)
            Me.label1.Name = "label1"
            Me.label1.Size = New Size(51, 25)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Type"
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label2.Location = New Point(273, 111)
            Me.label2.Name = "label2"
            Me.label2.Size = New Size(156, 25)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Brand and Model"
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label3.Location = New Point(273, 141)
            Me.label3.Name = "label3"
            Me.label3.Size = New Size(68, 25)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Screen"
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label4.Location = New Point(276, 171)
            Me.label4.Name = "label4"
            Me.label4.Size = New Size(93, 25)
            Me.label4.TabIndex = 8
            Me.label4.Text = "Processor"
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label5.Location = New Point(276, 200)
            Me.label5.Name = "label5"
            Me.label5.Size = New Size(52, 25)
            Me.label5.TabIndex = 9
            Me.label5.Text = "RAM"
            ' 
            ' label6
            ' 
            Me.label6.AutoSize = True
            Me.label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label6.Location = New Point(276, 232)
            Me.label6.Name = "label6"
            Me.label6.Size = New Size(76, 25)
            Me.label6.TabIndex = 10
            Me.label6.Text = "Storage"
            ' 
            ' label7
            ' 
            Me.label7.AutoSize = True
            Me.label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label7.Location = New Point(276, 263)
            Me.label7.Name = "label7"
            Me.label7.Size = New Size(121, 25)
            Me.label7.TabIndex = 11
            Me.label7.Text = "Main Camera"
            ' 
            ' label8
            ' 
            Me.label8.AutoSize = True
            Me.label8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label8.Location = New Point(276, 292)
            Me.label8.Name = "label8"
            Me.label8.Size = New Size(124, 25)
            Me.label8.TabIndex = 12
            Me.label8.Text = "Front Camera"
            ' 
            ' label9
            ' 
            Me.label9.AutoSize = True
            Me.label9.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label9.Location = New Point(276, 324)
            Me.label9.Name = "label9"
            Me.label9.Size = New Size(73, 25)
            Me.label9.TabIndex = 13
            Me.label9.Text = "Battery"
            ' 
            ' label10
            ' 
            Me.label10.AutoSize = True
            Me.label10.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.label10.Location = New Point(276, 355)
            Me.label10.Name = "label10"
            Me.label10.Size = New Size(53, 25)
            Me.label10.TabIndex = 14
            Me.label10.Text = "Price"
            ' 
            ' kart
            ' 
            Me.kart.BackColor = Color.Aquamarine
            Me.kart.Location = New Point(633, 85)
            Me.kart.Name = "kart"
            Me.kart.Size = New Size(456, 243)
            Me.kart.TabIndex = 15
            Me.kart.UseCompatibleStateImageBehavior = False
            Me.kart.View = View.Details
            ' 
            ' label11
            ' 
            Me.label11.AutoSize = True
            Me.label11.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
            Me.label11.Location = New Point(844, 38)
            Me.label11.Name = "label11"
            Me.label11.Size = New Size(65, 35)
            Me.label11.TabIndex = 16
            Me.label11.Text = "Kart"
            ' 
            ' lblTotalPrice
            ' 
            Me.lblTotalPrice.AutoSize = True
            Me.lblTotalPrice.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.lblTotalPrice.Location = New Point(1113, 85)
            Me.lblTotalPrice.Name = "lblTotalPrice"
            Me.lblTotalPrice.Size = New Size(57, 25)
            Me.lblTotalPrice.TabIndex = 17
            Me.lblTotalPrice.Text = "Price:"
            ' 
            ' btnRemoveFromKart
            ' 
            Me.btnRemoveFromKart.BackColor = Color.LightSeaGreen
            Me.btnRemoveFromKart.FlatStyle = FlatStyle.Popup
            Me.btnRemoveFromKart.Location = New Point(1095, 146)
            Me.btnRemoveFromKart.Name = "btnRemoveFromKart"
            Me.btnRemoveFromKart.Size = New Size(199, 29)
            Me.btnRemoveFromKart.TabIndex = 18
            Me.btnRemoveFromKart.Text = "Remove from kart"
            Me.btnRemoveFromKart.UseVisualStyleBackColor = False
            ' 
            ' btnBuy
            ' 
            Me.btnBuy.BackColor = Color.LightSeaGreen
            Me.btnBuy.FlatStyle = FlatStyle.Popup
            Me.btnBuy.Location = New Point(1095, 111)
            Me.btnBuy.Name = "btnBuy"
            Me.btnBuy.Size = New Size(199, 29)
            Me.btnBuy.TabIndex = 19
            Me.btnBuy.Text = "Buy"
            Me.btnBuy.UseVisualStyleBackColor = False
            ' 
            ' SalesHistory
            ' 
            Me.SalesHistory.BackColor = Color.Aquamarine
            Me.SalesHistory.Location = New Point(53, 446)
            Me.SalesHistory.Name = "SalesHistory"
            Me.SalesHistory.Size = New Size(1018, 259)
            Me.SalesHistory.TabIndex = 20
            Me.SalesHistory.UseCompatibleStateImageBehavior = False
            Me.SalesHistory.View = View.Details
            ' 
            ' lbSaleshistory
            ' 
            Me.lbSaleshistory.AutoSize = True
            Me.lbSaleshistory.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
            Me.lbSaleshistory.Location = New Point(482, 407)
            Me.lbSaleshistory.Name = "lbSaleshistory"
            Me.lbSaleshistory.Size = New Size(163, 35)
            Me.lbSaleshistory.TabIndex = 21
            Me.lbSaleshistory.Text = "Sales history"
            ' 
            ' btnExportToExcel
            ' 
            Me.btnExportToExcel.BackColor = Color.LightSeaGreen
            Me.btnExportToExcel.FlatStyle = FlatStyle.Popup
            Me.btnExportToExcel.Location = New Point(1087, 460)
            Me.btnExportToExcel.Name = "btnExportToExcel"
            Me.btnExportToExcel.Size = New Size(261, 29)
            Me.btnExportToExcel.TabIndex = 22
            Me.btnExportToExcel.Text = "Export to Excel"
            Me.btnExportToExcel.UseVisualStyleBackColor = False
            ' 
            ' btnExportToWord
            ' 
            Me.btnExportToWord.BackColor = Color.LightSeaGreen
            Me.btnExportToWord.FlatStyle = FlatStyle.Popup
            Me.btnExportToWord.Location = New Point(1087, 495)
            Me.btnExportToWord.Name = "btnExportToWord"
            Me.btnExportToWord.Size = New Size(261, 29)
            Me.btnExportToWord.TabIndex = 23
            Me.btnExportToWord.Text = "Export to Word"
            Me.btnExportToWord.UseVisualStyleBackColor = False
            ' 
            ' btnExportToPDF
            ' 
            Me.btnExportToPDF.BackColor = Color.LightSeaGreen
            Me.btnExportToPDF.FlatStyle = FlatStyle.Popup
            Me.btnExportToPDF.Location = New Point(1087, 530)
            Me.btnExportToPDF.Name = "btnExportToPDF"
            Me.btnExportToPDF.Size = New Size(261, 29)
            Me.btnExportToPDF.TabIndex = 24
            Me.btnExportToPDF.Text = "Export to PDF"
            Me.btnExportToPDF.UseVisualStyleBackColor = False
            ' 
            ' label12
            ' 
            Me.label12.AutoSize = True
            Me.label12.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
            Me.label12.Location = New Point(1135, 407)
            Me.label12.Name = "label12"
            Me.label12.Size = New Size(159, 35)
            Me.label12.TabIndex = 25
            Me.label12.Text = "Save history"
            ' 
            ' btnExportToXML
            ' 
            Me.btnExportToXML.BackColor = Color.LightSeaGreen
            Me.btnExportToXML.FlatStyle = FlatStyle.Popup
            Me.btnExportToXML.Location = New Point(1087, 565)
            Me.btnExportToXML.Name = "btnExportToXML"
            Me.btnExportToXML.Size = New Size(261, 29)
            Me.btnExportToXML.TabIndex = 26
            Me.btnExportToXML.Text = "Export to XML"
            Me.btnExportToXML.UseVisualStyleBackColor = False
            ' 
            ' btnExportToJson
            ' 
            Me.btnExportToJson.BackColor = Color.LightSeaGreen
            Me.btnExportToJson.FlatStyle = FlatStyle.Popup
            Me.btnExportToJson.Location = New Point(1087, 600)
            Me.btnExportToJson.Name = "btnExportToJson"
            Me.btnExportToJson.Size = New Size(261, 29)
            Me.btnExportToJson.TabIndex = 27
            Me.btnExportToJson.Text = "Export to Json"
            Me.btnExportToJson.UseVisualStyleBackColor = False
            ' 
            ' btnExportToTXT
            ' 
            Me.btnExportToTXT.BackColor = Color.LightSeaGreen
            Me.btnExportToTXT.FlatStyle = FlatStyle.Popup
            Me.btnExportToTXT.Location = New Point(1087, 635)
            Me.btnExportToTXT.Name = "btnExportToTXT"
            Me.btnExportToTXT.Size = New Size(261, 29)
            Me.btnExportToTXT.TabIndex = 28
            Me.btnExportToTXT.Text = "Export to TXT"
            Me.btnExportToTXT.UseVisualStyleBackColor = False
            ' 
            ' lblWarrenty
            ' 
            Me.lblWarrenty.AutoSize = True
            Me.lblWarrenty.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
            Me.lblWarrenty.Location = New Point(276, 384)
            Me.lblWarrenty.Name = "lblWarrenty"
            Me.lblWarrenty.Size = New Size(88, 25)
            Me.lblWarrenty.TabIndex = 29
            Me.lblWarrenty.Text = "Warrenty"
            ' 
            ' F
            ' 
            Me.AutoScaleDimensions = New SizeF(8.0F, 20.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = Color.PaleTurquoise
            Me.ClientSize = New Size(1412, 717)
            Me.Controls.Add(Me.lblWarrenty)
            Me.Controls.Add(Me.btnExportToTXT)
            Me.Controls.Add(Me.btnExportToJson)
            Me.Controls.Add(Me.btnExportToXML)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.btnExportToPDF)
            Me.Controls.Add(Me.btnExportToWord)
            Me.Controls.Add(Me.btnExportToExcel)
            Me.Controls.Add(Me.lbSaleshistory)
            Me.Controls.Add(Me.SalesHistory)
            Me.Controls.Add(Me.btnBuy)
            Me.Controls.Add(Me.btnRemoveFromKart)
            Me.Controls.Add(Me.lblTotalPrice)
            Me.Controls.Add(Me.label11)
            Me.Controls.Add(Me.kart)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.lbOptions)
            Me.Controls.Add(Me.listView1)
            Me.Controls.Add(Me.CBoptions)
            Me.Controls.Add(Me.btnAddToKart)
            Me.Name = "F"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents btnAddToKart As Button
        Private WithEvents CBoptions As ComboBox
        Private WithEvents listView1 As ListView
        Private lbOptions As Label
        Private label1 As Label
        Private label2 As Label
        Private label3 As Label
        Private label4 As Label
        Private label5 As Label
        Private label6 As Label
        Private label7 As Label
        Private label8 As Label
        Private label9 As Label
        Private label10 As Label
        Private kart As ListView
        Private label11 As Label
        Private lblTotalPrice As Label
        Private WithEvents btnRemoveFromKart As Button
        Private WithEvents btnBuy As Button
        Private SalesHistory As ListView
        Private lbSaleshistory As Label
        Private WithEvents btnExportToExcel As Button
        Private WithEvents btnExportToWord As Button
        Private WithEvents btnExportToPDF As Button
        Private label12 As Label
        Private WithEvents btnExportToXML As Button
        Private WithEvents btnExportToJson As Button
        Private WithEvents btnExportToTXT As Button
        Private lblWarrenty As Label
    End Class
End Namespace

