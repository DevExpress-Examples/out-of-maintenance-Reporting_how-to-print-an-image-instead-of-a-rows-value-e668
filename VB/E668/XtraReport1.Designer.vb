Imports Microsoft.VisualBasic
Imports System
Namespace E668
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
            Me.nwindDataSet1 = New E668.nwindDataSet
            Me.categoriesTableAdapter = New E668.nwindDataSetTableAdapters.CategoriesTableAdapter
            Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
            Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
            CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.Detail.HeightF = 24.04167!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrLabel1
            '
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(52.08333!, 0.0!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(339.5833!, 24.04167!)
            Me.xrLabel1.Text = "xrLabel1"
            '
            'TopMargin
            '
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'BottomMargin
            '
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'nwindDataSet1
            '
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'categoriesTableAdapter
            '
            Me.categoriesTableAdapter.ClearBeforeFill = True
            '
            'XrPictureBox1
            '
            Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(26.04167!, 0.0!)
            Me.XrPictureBox1.Name = "XrPictureBox1"
            Me.XrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(51.74999!, 35.00001!)
            Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            '
            'GroupHeader2
            '
            Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1})
            Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader2.HeightF = 35.00001!
            Me.GroupHeader2.Name = "GroupHeader2"
            '
            'XtraReport1
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2})
            Me.DataAdapter = Me.categoriesTableAdapter
            Me.DataMember = "Categories"
            Me.DataSource = Me.nwindDataSet1
            Me.Version = "10.1"
            CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As E668.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
	End Class
End Namespace
