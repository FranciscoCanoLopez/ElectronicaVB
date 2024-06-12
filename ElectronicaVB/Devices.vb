Namespace Electronica
    Friend Class Device
        Implements IWarranty

        ' Properties
        Public ReadOnly Property Category As String ' Read-only
        Public Property Price As Decimal ' Read and write

        ' Constructor
        Public Sub New(category As String, price As Decimal)
            Me.Category = category
            Me.Price = price
        End Sub

        ' Public method to display device information
        Public Overridable Sub DisplayInfo()
            Console.WriteLine($"Category: {Category}, Price: {Price}")
        End Sub

        ' Method to return warranty information
        Public Overridable Function GetWarrantyInfo() As String Implements IWarranty.GetWarrantyInfo
            Return "Default warranty information"
        End Function
    End Class
End Namespace
