Imports DevExpress.Diagram.Core
Imports System
Imports System.Windows
Imports System.Windows.Controls

Namespace CustomShapeThemes

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            InitCustomShapeTheme()
        End Sub

        Private Sub InitCustomShapeTheme()
            Dim customShapeThemeDictionary As ResourceDictionary = New ResourceDictionary() With {.Source = New Uri("CustomShapeTheme.xaml", UriKind.Relative)}
            ThemeRegistrator.RegisterThemes(customShapeThemeDictionary, Function(name) name)
            Me.diagramControl.Theme = ThemeRegistrator.GetTheme("MyTheme")
        End Sub
    End Class
End Namespace
