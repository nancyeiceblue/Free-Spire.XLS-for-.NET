Imports System.Data.OleDb
Imports System.Collections
Imports System.ComponentModel

Imports Spire.Xls

Namespace ToPDF
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub btnRun_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRun.Click
			Using workbook As New Workbook()
				workbook.LoadFromFile("..\..\..\..\..\..\Data\ToPDF.xlsx")
				workbook.ConverterSetting.SheetFitToPage = True
				workbook.SaveToFile("sample.pdf", FileFormat.PDF)
			End Using
			ExcelDocViewer("sample.pdf")
		End Sub

		Private Sub ExcelDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Close()
		End Sub


	End Class
End Namespace
