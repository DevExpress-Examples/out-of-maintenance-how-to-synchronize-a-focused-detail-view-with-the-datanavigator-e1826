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

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            recordBindingSource.DataSource = DataHelper.GetData(10, 5)
        End Sub

        Private Sub OnDataNavigatorPositionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dataNavigator.PositionChanged
            Dim focusedView As ColumnView = CType(gridControl1.FocusedView, ColumnView)
            If focusedView.IsDetailView Then
                focusedView.FocusedRowHandle = focusedView.GetRowHandle(DirectCast(sender, DataNavigator).Position)
            End If
        End Sub

        Private Sub OnFocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles detailView.FocusedRowChanged
            detailBindingSource.Position = DirectCast(sender, ColumnView).GetDataSourceRowIndex(e.FocusedRowHandle)
        End Sub
    End Class
End Namespace