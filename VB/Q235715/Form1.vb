Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Namespace Q235715
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
		End Sub

		Private Sub OnProductsViewFocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles productsView.FocusedRowChanged
			productsBindingSource.Position = (CType(sender, ColumnView)).GetDataSourceRowIndex(e.FocusedRowHandle)
		End Sub

		Private Sub OnDataNavigatorPositionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dataNavigator.PositionChanged
			Dim focusedView As ColumnView = CType(gridControl1.FocusedView, ColumnView)
			If focusedView.IsDetailView Then
				focusedView.FocusedRowHandle = focusedView.GetRowHandle((CType(sender, DataNavigator)).Position)
			End If
		End Sub
	End Class
End Namespace