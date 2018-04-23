Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace E668
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XrPictureBox1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrPictureBox1.BeforePrint
			Dim ms As New MemoryStream(CType(GetCurrentColumnValue("Picture"), Byte ()))
			CType(sender, XRPictureBox).Image = Image.FromStream(ms)
		End Sub

	End Class
End Namespace
