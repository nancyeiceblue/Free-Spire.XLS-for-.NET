Imports System.Data.OleDb
Imports System.Collections
Imports System.ComponentModel

Imports Spire.Xls

Namespace SparkLine
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub btnRun_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRun.Click
			'Load a Workbook from disk
			Dim workbook As New Workbook()
			workbook.LoadFromFile("..\..\..\..\..\..\Data\SparkLine.xlsx")

			'Get the first sheet
			Dim sheet As Worksheet = workbook.Worksheets(0)

			'Add sparkline
			Dim sparklineGroup As SparklineGroup = sheet.SparklineGroups.AddGroup(SparklineType.Line)
			Dim sparklines As SparklineCollection = sparklineGroup.Add()
			sparklines.Add(sheet("A2:D2"), sheet("E2"))
			sparklines.Add(sheet("A3:D3"), sheet("E3"))
			sparklines.Add(sheet("A4:D4"), sheet("E4"))
			sparklines.Add(sheet("A5:D5"), sheet("E5"))
			sparklines.Add(sheet("A6:D6"), sheet("E6"))
			sparklines.Add(sheet("A7:D7"), sheet("E7"))
			sparklines.Add(sheet("A8:D8"), sheet("E8"))
			sparklines.Add(sheet("A9:D9"), sheet("E9"))
			sparklines.Add(sheet("A10:D10"), sheet("E10"))
			sparklines.Add(sheet("A11:D11"), sheet("E11"))

			'Save and Launch
			workbook.SaveToFile("Output.xlsx",ExcelVersion.Version2010)
			ExcelDocViewer("Output.xlsx")
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
