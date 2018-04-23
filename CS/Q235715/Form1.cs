using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace Q235715 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
        }

        private void OnProductsViewFocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            productsBindingSource.Position = ((ColumnView)sender).GetDataSourceRowIndex(e.FocusedRowHandle);
        }

        private void OnDataNavigatorPositionChanged(object sender, EventArgs e) {
            ColumnView focusedView = (ColumnView)gridControl1.FocusedView;
            if (focusedView.IsDetailView) focusedView.FocusedRowHandle = focusedView.GetRowHandle(((DataNavigator)sender).Position);
        }
    }
}