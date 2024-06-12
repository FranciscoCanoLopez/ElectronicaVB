Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Xml
Imports Newtonsoft.Json
Imports OfficeOpenXml
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Xceed.Words.NET
Imports TableXceed = Xceed.Document.NET.Table
Imports DocumentXceed = Xceed.Document.NET.Document

Namespace Electronica
    Partial Public Class F
        Inherits Form
        Private ReadOnly basePath As String = "C:\Users\volub\source\repos\Electronica\Dispositivos\" ' dirección donde se ubican los a vender

        Public Sub New()
            InitializeComponent()
            ' Se configura la listview de carrito de compras
            listView1.View = View.Details
            Dim columnType As New ColumnHeader() With {
                .Text = "Type",
                .Width = 100
            }
            Dim columnBrandModel As New ColumnHeader() With {
                .Text = "Brand and Model",
                .Width = 200
            }
            Dim columnPrice As New ColumnHeader() With {
                .Text = "Price",
                .Width = 100
            }
            kart.Columns.Add(columnType)
            kart.Columns.Add(columnBrandModel)
            kart.Columns.Add(columnPrice)

            ' Se configura la lista de historial de ventas
            SalesHistory.View = View.Details
            SalesHistory.Columns.Add("Purchase Date and Time", 200)
            SalesHistory.Columns.Add("Purchased Devices", 400)
            SalesHistory.Columns.Add("Total Purchase", 100)

        End Sub

        ' Combobox para opciones
        Private Sub CBoptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoptions.SelectedIndexChanged
            Dim category As String = CBoptions.SelectedItem.ToString()
            LoadContent(category)
        End Sub

        ' Carga los datos de la opción seleccionada
        Private Sub LoadContent(category As String)
            Dim filename = String.Empty

            Select Case category
                Case "Cell Phones"
                    filename = Path.Combine(basePath, "Cell Phones.txt")
                Case "Computers"
                    filename = Path.Combine(basePath, "Computers.txt")
                Case "Tablets"
                    filename = Path.Combine(basePath, "Tablets.txt")
            End Select

            If Not String.IsNullOrEmpty(filename) Then
                Try
                    Dim lines As String() = File.ReadAllLines(filename)
                    listView1.Columns.Clear()
                    listView1.Items.Clear()
                    listView1.View = View.List
                    Dim column As New ColumnHeader() With {
                        .Width = 150,
                        .TextAlign = HorizontalAlignment.Center
                    }
                    listView1.Columns.Add(column)

                    For i As Integer = 1 To lines.Length - 1
                        Dim data As String() = lines(i).Split(","c)
                        Dim item As New ListViewItem(data(0))
                        listView1.Items.Add(item)
                    Next
                Catch ex As FileNotFoundException
                    listView1.Items.Clear()
                    listView1.Columns.Clear()
                    listView1.Columns.Add("Error")
                    listView1.Items.Add($"No se encontró el archivo para {category}")
                End Try
            End If
        End Sub

        ' Muestra los datos del dispositivo seleccionado
        Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
            If listView1.SelectedItems.Count > 0 Then
                Dim selectedItem As String = listView1.SelectedItems(0).Text

                Dim category As String = CBoptions.SelectedItem.ToString()
                Dim filename As String = Path.Combine(basePath & category & ".txt")
                If File.Exists(filename) Then
                    Try
                        Dim lines As String() = File.ReadAllLines(filename)
                        For Each line As String In lines
                            Dim data As String() = line.Split(","c)
                            If data(0) = selectedItem Then
                                If category = "Cell Phones" Then
                                    Dim cellPhone = New CellPhone(category, data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7), Decimal.Parse(data(8)))
                                    label1.Text = "Type: " & cellPhone.Category
                                    label2.Text = "Brand and Model: " & cellPhone.BrandAndModel
                                    label3.Text = "Screen: " & cellPhone.Screen
                                    label4.Text = "Processor: " & cellPhone.Processor
                                    label5.Text = "RAM: " & cellPhone.RAM
                                    label6.Text = "Storage: " & cellPhone.Storage
                                    label7.Text = "Main Camera: " & cellPhone.MainCamera
                                    label8.Text = "Front Camera: " & cellPhone.FrontCamera
                                    label9.Text = "Battery: " & cellPhone.Battery
                                    label10.Text = "Price(USD): $" & cellPhone.Price
                                    lblWarrenty.Text = $"Warrenty: {cellPhone.GetWarrantyInfo()}"
                                ElseIf category = "Computers" Then
                                    Dim computer = New Computer(category, data(0), data(1), data(2), data(3), data(4), data(5), data(6), Decimal.Parse(data(8)))
                                    label1.Text = "Type: " & computer.Category
                                    label2.Text = "Brand and Model: " & computer.BrandAndModel
                                    label3.Text = "Screen: " & computer.Screen
                                    label4.Text = "Processor: " & computer.Processor
                                    label5.Text = "RAM: " & computer.RAM
                                    label6.Text = "Storage: " & computer.Storage
                                    label7.Text = "Graphics: " & computer.Graphics
                                    label8.Text = "Operating System: " & computer.OperatingSystem
                                    label9.Text = ""
                                    label10.Text = "Price(USD): $" & computer.Price
                                    lblWarrenty.Text = $"Warrenty: {computer.GetWarrantyInfo()}"
                                ElseIf category = "Tablets" Then
                                    Dim tablet = New Tablet(category, data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7), Decimal.Parse(data(8)))
                                    label1.Text = "Type: " & tablet.Category
                                    label2.Text = "Brand and Model: " & tablet.BrandAndModel
                                    label3.Text = "Screen: " & tablet.Screen
                                    label4.Text = "Processor: " & tablet.Processor
                                    label5.Text = "RAM: " & tablet.RAM
                                    label6.Text = "Storage: " & tablet.Storage
                                    label7.Text = "Main Camera: " & tablet.MainCamera
                                    label8.Text = "Front Camera: " & tablet.FrontCamera
                                    label9.Text = "Battery: " & tablet.Battery
                                    label10.Text = "Price(USD): $" & tablet.Price
                                    lblWarrenty.Text = $"Warrenty: {tablet.GetWarrantyInfo()}"
                                End If
                                Exit For
                            End If
                        Next
                    Catch ex As Exception
                        MessageBox.Show("Error al leer el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("No se encontró el archivo: " & filename, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub
        ' Agrega el dispositivo seleccionado al carrito
        Private Sub BtnAddToKart_Click(sender As Object, e As EventArgs) Handles btnAddToKart.Click
            If listView1.SelectedItems.Count > 0 Then
                Dim selectedItem As String = listView1.SelectedItems(0).Text

                Dim category As String = CBoptions.SelectedItem.ToString()

                Dim filename As String = Path.Combine(basePath & category & ".txt")
                If File.Exists(filename) Then
                    Try
                        Dim lines As String() = File.ReadAllLines(filename)
                        For Each line As String In lines
                            Dim data As String() = line.Split(","c)
                            If data(0) = selectedItem Then
                                ' Agrega los datos a la ListView "kart"
                                Dim item As New ListViewItem(category) ' Tipo
                                item.SubItems.Add(data(0))
                                item.SubItems.Add(data(8))
                                kart.Items.Add(item)
                                UpdateTotalPrice()
                                Exit For
                            End If
                        Next
                    Catch ex As Exception
                        MessageBox.Show("Error al leer el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("No se encontró el archivo: " & filename, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Por favor, seleccione un elemento para agregar al carrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        ' Actualiza precio al agregar o eliminar dispositivos al carrito
        Private Sub UpdateTotalPrice()
            Dim totalPrice As Decimal = 0
            For Each item As ListViewItem In kart.Items
                Dim priceString As String = item.SubItems(2).Text

                ' Elimina caracteres no numéricos
                priceString = MyRegex().Replace(priceString, "")

                Try
                    Dim price As Decimal = Decimal.Parse(priceString, CultureInfo.InvariantCulture)
                    totalPrice += price
                Catch ex As FormatException
                    MessageBox.Show("Error al convertir el precio: " & ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next

            ' Muestra la suma total en la label
            lblTotalPrice.Text = "Total Price: $" & totalPrice.ToString("0.00")
        End Sub

        ' Remueve el dispositivo seleccionado del carrito
        Private Sub BtnRemoveFromKart_Click(sender As Object, e As EventArgs) Handles btnRemoveFromKart.Click
            For Each item As ListViewItem In kart.SelectedItems
                kart.Items.Remove(item)
            Next
            UpdateTotalPrice()
        End Sub

        ' Agrega fecha y hora, dispositivos comprados y el precio total a pagar
        Private Sub BtnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
            ' Combina los datos de los dispositivos comprados en un solo string
            Dim purchasedDevices As String = String.Join(", ", kart.Items.Cast(Of ListViewItem)().Select(Function(item) item.SubItems(1).Text))

            ' Crea una nueva fila con la fecha, los dispositivos comprados y el precio total
            Dim newItem As New ListViewItem(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            newItem.SubItems.Add(purchasedDevices)
            newItem.SubItems.Add(lblTotalPrice.Text)

            SalesHistory.Items.Add(newItem)

            kart.Items.Clear()
            UpdateTotalPrice()

            MessageBox.Show("Compra realizada con éxito.", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        ' Botones para exportar a diferentes formatos
        Private Sub BtnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
            Dim folderPath As String = "C:\Users\volub\source\repos\Electronica\Sales History\Excel"
            Directory.CreateDirectory(folderPath)

            Using sfd As New SaveFileDialog()
                sfd.Filter = "Excel Files|*.xlsx"
                sfd.Title = "Save Sales History to Excel"
                sfd.InitialDirectory = folderPath

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = sfd.FileName

                    Try
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
                        Using package As New ExcelPackage()
                            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Sales History")

                            worksheet.Cells(1, 1).Value = "Purchase Date and Time"
                            worksheet.Cells(1, 2).Value = "Purchased Devices"
                            worksheet.Cells(1, 3).Value = "Total Purchase"

                            For i As Integer = 0 To SalesHistory.Items.Count - 1
                                worksheet.Cells(i + 2, 1).Value = SalesHistory.Items(i).Text
                                worksheet.Cells(i + 2, 2).Value = SalesHistory.Items(i).SubItems(1).Text
                                worksheet.Cells(i + 2, 3).Value = SalesHistory.Items(i).SubItems(2).Text
                            Next

                            Dim fi As New FileInfo(filePath)
                            package.SaveAs(fi)

                            MessageBox.Show("Historial de ventas exportado a Excel con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Abrir el archivo exportado
                            Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub

        Private Sub BtnExportToPDF_Click(sender As Object, e As EventArgs) Handles btnExportToPDF.Click
            Dim folderPath As String = "C:\Users\volub\source\repos\Electronica\Sales History\PDF"
            Directory.CreateDirectory(folderPath)

            Using sfd As New SaveFileDialog()
                sfd.Filter = "PDF Files|*.pdf"
                sfd.Title = "Save Sales History to PDF"
                sfd.InitialDirectory = folderPath

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = sfd.FileName

                    Try
                        Using fs As FileStream = New FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None)
                            Dim doc As Document = New Document(PageSize.A4, 10, 10, 10, 10)

                            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, fs)
                            doc.Open()

                            ' Agregar contenido al documento PDF
                            Dim table As PdfPTable = New PdfPTable(3)
                            table.WidthPercentage = 100
                            table.SetWidths(New Single() {2, 5, 2})

                            table.AddCell("Purchase Date and Time")
                            table.AddCell("Purchased Devices")
                            table.AddCell("Total Purchase")

                            For Each item As ListViewItem In SalesHistory.Items
                                table.AddCell(item.Text)
                                table.AddCell(item.SubItems(1).Text)
                                table.AddCell(item.SubItems(2).Text)
                            Next

                            doc.Add(table)
                            doc.Close()

                            MessageBox.Show("Historial de ventas exportado a PDF con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Abrir el archivo exportado
                            Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error al exportar a PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub

        Private Sub BtnExportToWord_Click(sender As Object, e As EventArgs) Handles btnExportToWord.Click
            Dim folderPath As String = "C:\Users\volub\source\repos\Electronica\Sales History\Word"
            Directory.CreateDirectory(folderPath) ' Asegurar que el directorio existe

            Using sfd As New SaveFileDialog()
                sfd.Filter = "Word Documents|*.docx"
                sfd.Title = "Save Sales History to Word"
                sfd.InitialDirectory = folderPath

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = sfd.FileName

                    Try
                        Using doc As DocX = DocX.Create(filePath)
                            Dim table = doc.AddTable(SalesHistory.Items.Count + 1, 3)
                            table.Rows(0).Cells(0).Paragraphs(0).Append("Purchase Date and Time")
                            table.Rows(0).Cells(1).Paragraphs(0).Append("Purchased Devices")
                            table.Rows(0).Cells(2).Paragraphs(0).Append("Total Purchase")

                            For i As Integer = 0 To SalesHistory.Items.Count - 1
                                table.Rows(i + 1).Cells(0).Paragraphs(0).Append(SalesHistory.Items(i).Text)
                                table.Rows(i + 1).Cells(1).Paragraphs(0).Append(SalesHistory.Items(i).SubItems(1).Text)
                                table.Rows(i + 1).Cells(2).Paragraphs(0).Append(SalesHistory.Items(i).SubItems(2).Text)
                            Next

                            doc.InsertTable(table)
                            doc.Save()

                            MessageBox.Show("Historial de ventas exportado a Word con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Abrir el archivo exportado
                            Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error al exportar a Word: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub

        Private Sub BtnExportToXML_Click(sender As Object, e As EventArgs) Handles btnExportToXML.Click
            Dim folderPath As String = "C:\Users\volub\source\repos\Electronica\Sales History\XML"
            Directory.CreateDirectory(folderPath)

            Using sfd As New SaveFileDialog()
                sfd.Filter = "XML Files|*.xml"
                sfd.Title = "Save Sales History to XML"
                sfd.InitialDirectory = folderPath

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = sfd.FileName

                    Try
                        Dim xmlDoc As New XmlDocument()
                        Dim root As XmlElement = xmlDoc.CreateElement("SalesHistory")

                        For Each item As ListViewItem In SalesHistory.Items
                            Dim purchaseNode As XmlElement = xmlDoc.CreateElement("Purchase")

                            Dim dateTimeNode As XmlElement = xmlDoc.CreateElement("DateTime")
                            dateTimeNode.InnerText = item.Text
                            purchaseNode.AppendChild(dateTimeNode)

                            Dim devicesNode As XmlElement = xmlDoc.CreateElement("Devices")
                            devicesNode.InnerText = item.SubItems(1).Text
                            purchaseNode.AppendChild(devicesNode)

                            Dim totalPriceNode As XmlElement = xmlDoc.CreateElement("TotalPrice")
                            totalPriceNode.InnerText = item.SubItems(2).Text
                            purchaseNode.AppendChild(totalPriceNode)

                            root.AppendChild(purchaseNode)
                        Next

                        xmlDoc.AppendChild(root)
                        xmlDoc.Save(filePath)

                        MessageBox.Show("Historial de ventas exportado a XML con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Abrir el archivo exportado
                        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
                    Catch ex As Exception
                        MessageBox.Show("Error al exportar a XML: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub

        Private Sub BtnExportToJson_Click(sender As Object, e As EventArgs) Handles btnExportToJson.Click
            Dim folderPath As String = "C:\Users\volub\source\repos\Electronica\Sales History\Json"
            Directory.CreateDirectory(folderPath)

            Using sfd As New SaveFileDialog()
                sfd.Filter = "JSON Files|*.json"
                sfd.Title = "Save Sales History to JSON"
                sfd.InitialDirectory = folderPath

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = sfd.FileName

                    Try
                        Dim salesHistoryList = SalesHistory.Items.Cast(Of ListViewItem)().Select(Function(item) New With {
                    .DateTime = item.Text,
                    .Devices = item.SubItems(1).Text,
                    .TotalPrice = item.SubItems(2).Text
                })

                        Dim json As String = JsonConvert.SerializeObject(salesHistoryList, Newtonsoft.Json.Formatting.Indented)
                        File.WriteAllText(filePath, json)

                        MessageBox.Show("Historial de ventas exportado a JSON con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Abrir el archivo exportado
                        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
                    Catch ex As Exception
                        MessageBox.Show("Error al exportar a JSON: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub

        Private Sub BtnExportToTXT_Click(sender As Object, e As EventArgs) Handles BtnExportToTXT.Click
            Dim folderPath As String = "C:\Users\volub\source\repos\Electronica\Sales History\TXT"
            Directory.CreateDirectory(folderPath)

            Using sfd As New SaveFileDialog()
                sfd.Filter = "Text Files|*.txt"
                sfd.Title = "Save Sales History to Text"
                sfd.InitialDirectory = folderPath

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = sfd.FileName

                    Try
                        Using writer As StreamWriter = New StreamWriter(filePath)
                            ' Escribir la línea de encabezado
                            writer.WriteLine("Purchase Date and Time" & vbTab & "Purchased Devices" & vbTab & "Total Purchase")

                            ' Escribir las líneas de datos
                            For Each item As ListViewItem In SalesHistory.Items
                                Dim dateTime As String = item.Text
                                Dim devices As String = item.SubItems(1).Text
                                Dim totalPrice As String = item.SubItems(2).Text

                                writer.WriteLine($"{dateTime}{vbTab}{devices}{vbTab}{totalPrice}")
                            Next

                            MessageBox.Show("Historial de ventas exportado a texto con éxito.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Abrir el archivo exportado
                            Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error al exportar a texto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub

        <GeneratedRegex("[^0-9.]")>
        Private Shared Function MyRegex() As Regex
            Return New Regex("[^0-9.]")
        End Function


    End Class
End Namespace
