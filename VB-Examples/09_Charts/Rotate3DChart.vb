Imports Spire.Xls

Namespace Rotate3DChart

	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnRun_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRun.Click
			'Create a workbook
			Dim workbook As New Workbook()

			'Load the document from disk
			workbook.LoadFromFile("..\..\..\..\..\..\Data\ChartSample3.xlsx")

			'Get the chart from the first worksheet
			Dim sheet As Worksheet = workbook.Worksheets(0)
			Dim chart As Chart = sheet.Charts(0)

			'X rotation:
			chart.Rotation = 30
			'Y rotation:
			chart.Elevation = 20

			'Save the document
			Dim output As String = "Rotate3DChart.xlsx"
			workbook.SaveToFile(output, ExcelVersion.Version2013)

			'Launch the file
			ExcelDocViewer(output)
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
