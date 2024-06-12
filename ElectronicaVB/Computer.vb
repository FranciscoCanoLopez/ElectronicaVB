Namespace Electronica
    Friend Class Computer
        Inherits Device

        ' Properties
        Public Property BrandAndModel As String
        Public Property Screen As String
        Public Property Processor As String
        Public Property RAM As String
        Public Property Storage As String
        Public Property Graphics As String
        Public Property OperatingSystem As String

        ' Constructor
        Public Sub New(type As String, brandAndModel As String, screen As String, processor As String, ram As String, storage As String, graphics As String, operatingSystem As String, price As Decimal)
            MyBase.New(type, price)
            Me.BrandAndModel = brandAndModel
            Me.Screen = screen
            Me.Processor = processor
            Me.RAM = ram
            Me.Storage = storage
            Me.Graphics = graphics
            Me.OperatingSystem = operatingSystem
        End Sub

        ' Method to override the DisplayInfo method in the base class
        Public Overrides Sub DisplayInfo()
            MyBase.DisplayInfo()
            Console.WriteLine($"Brand and Model: {BrandAndModel}, Screen: {Screen}, Processor: {Processor}, RAM: {RAM}, Storage: {Storage}, Graphics: {Graphics}, Operating System: {OperatingSystem}")
        End Sub

        ' Implementation of GetWarrantyInfo method from IWarranty interface
        Public Overrides Function GetWarrantyInfo() As String
            Return "3 years warranty for computers"
        End Function
    End Class
End Namespace
