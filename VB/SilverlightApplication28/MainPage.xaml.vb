Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Grid

Namespace SilverlightApplication28
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)

			Dim link As New VisualDataNodeLink(CType(gridControl1.View, TableView))
			Dim model As New LinkPreviewModel(link)
			documentPreview1.Model = model
			link.CreateDocument(True)
		End Sub
	End Class
End Namespace
