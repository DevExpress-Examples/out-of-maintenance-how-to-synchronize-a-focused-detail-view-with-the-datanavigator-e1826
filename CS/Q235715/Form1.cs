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
            recordBindingSource.DataSource = DataHelper.GetData(10, 5);
        }

        private void OnDataNavigatorPositionChanged(object sender, EventArgs e) {
            ColumnView focusedView = (ColumnView)gridControl1.FocusedView;
            if(focusedView.IsDetailView)
                focusedView.FocusedRowHandle = focusedView.GetRowHandle(((DataNavigator)sender).Position);
        }

        private void OnFocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            detailBindingSource.Position = ((ColumnView)sender).GetDataSourceRowIndex(e.FocusedRowHandle);
        }
    }
}