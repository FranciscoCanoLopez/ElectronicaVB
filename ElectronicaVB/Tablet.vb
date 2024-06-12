Namespace Electronica
    Friend Class Tablet
        Inherits Device

        ' Properties
        Public Property BrandAndModel As String
        Public Property Screen As String
        Public Property Processor As String
        Public Property RAM As String
        Public Property Storage As String
        Public Property MainCamera As String
        Public Property FrontCamera As String
        Public Property Battery As String

        ' Constructor
        Public Sub New(type As String, brandAndModel As String, screen As String, processor As String, ram As String, storage As String, mainCamera As String, frontCamera As String, battery As String, price As Decimal)
            MyBase.New(type, price)
            Me.BrandAndModel = brandAndModel
            Me.Screen = screen
            Me.Processor = processor
            Me.RAM = ram
            Me.Storage = storage
            Me.MainCamera = mainCamera
            Me.FrontCamera = frontCamera
            Me.Battery = battery
        End Sub

        ' Method to override the DisplayInfo method in the base class
        Public Overrides Sub DisplayInfo()
            MyBase.DisplayInfo()
            Console.WriteLine($"Brand and Model: {BrandAndModel}, Screen: {Screen}, Processor: {Processor}, RAM: {RAM}, Storage: {Storage}, Main Camera: {MainCamera}, Front Camera: {FrontCamera}, Battery: {Battery}")
        End Sub

        ' Implementation of GetWarrantyInfo method from IWarranty interface
        Public Overrides Function GetWarrantyInfo() As String
            Return "1 year warranty for tablets"
        End Function
    End Class
End Namespace
