Imports CefSharp
Imports CefSharp.Winform
Public Class tctr

    Private WithEvents browser As WinForms.ChromiumWebBrowser

    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)

        browser = New WinForms.ChromiumWebBrowser("http://localhost/proj/ticketreader/index.php") With {
            .Dock = DockStyle.Fill
        }
        webbrowser.Controls.Add(browser)


    End Sub
End Class
