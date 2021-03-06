Imports System.Data.OleDb
Imports System.Collections
Imports System.ComponentModel
Imports Spire.Xls
Imports Spire.Xls.Core.Spreadsheet

Namespace SplitDataIntoMultipleColumns
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnRun_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRun.Click
			'Create a workbook.
			Dim workbook As New Workbook()

			'Load the file from disk.
			workbook.LoadFromFile("..\..\..\..\..\..\Data\SplitExcelDataIntoMultipleCols.xlsx")

			'Get the first worksheet.
			Dim sheet As Worksheet = workbook.Worksheets(0)

			'Split data into separate columns by the delimited characters �C space.
			Dim splitText() As String = Nothing
			Dim text As String = Nothing
			For i As Integer = 1 To sheet.LastRow - 1
				text = sheet.Range(i + 1, 1).Text
				splitText = text.Split(" "c)
				For j As Integer = 0 To splitText.Length - 1
					sheet.Range(i + 1, 1 + j + 1).Text = splitText(j)
				Next j
			Next i

			Dim result As String = "Result-SplitExcelDataIntoMultipleCols.xlsx"

			'Save to file.
			workbook.SaveToFile(result, ExcelVersion.Version2013)

			'Launch the MS Excel file.
			ExcelDocViewer(result)
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
