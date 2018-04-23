namespace Q235715 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.productsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new Q235715.nwindDataSet();
            this.categoriesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dataNavigator = new DevExpress.XtraEditors.DataNavigator();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ProductNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CategoryIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.QuantityPerUnitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UnitPriceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.UnitsInStockSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ItemForProductID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategoryID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQuantityPerUnit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitsInStock = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.categoriesTableAdapter = new Q235715.nwindDataSetTableAdapters.CategoriesTableAdapter();
            this.productsTableAdapter = new Q235715.nwindDataSetTableAdapters.ProductsTableAdapter();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPerUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityPerUnitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsInStockSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantityPerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsView
            // 
            this.productsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colProductName,
            this.colCategoryID1,
            this.colQuantityPerUnit,
            this.colUnitPrice,
            this.colUnitsInStock});
            this.productsView.GridControl = this.gridControl1;
            this.productsView.Name = "productsView";
            this.productsView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.OnProductsViewFocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.categoriesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.productsView;
            gridLevelNode1.RelationName = "CategoriesProducts";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.categoriesView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(446, 388);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.categoriesView,
            this.productsView});
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesView
            // 
            this.categoriesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colCategoryName,
            this.colDescription});
            this.categoriesView.GridControl = this.gridControl1;
            this.categoriesView.Name = "categoriesView";
            this.categoriesView.OptionsBehavior.Editable = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dataLayoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(776, 392);
            this.splitContainerControl1.SplitterPosition = 450;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.dataNavigator);
            this.dataLayoutControl1.Controls.Add(this.ProductIDSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.ProductNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CategoryIDSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.QuantityPerUnitTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitPriceSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitsInStockSpinEdit);
            this.dataLayoutControl1.DataSource = this.productsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForProductID,
            this.ItemForCategoryID});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(316, 388);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // dataNavigator
            // 
            this.dataNavigator.DataSource = this.productsBindingSource;
            this.dataNavigator.Location = new System.Drawing.Point(6, 364);
            this.dataNavigator.Name = "dataNavigator";
            this.dataNavigator.Size = new System.Drawing.Size(305, 19);
            this.dataNavigator.StyleController = this.dataLayoutControl1;
            this.dataNavigator.TabIndex = 1;
            this.dataNavigator.Text = "dataNavigator1";
            this.dataNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.dataNavigator.PositionChanged += new System.EventHandler(this.OnDataNavigatorPositionChanged);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "CategoriesProducts";
            this.productsBindingSource.DataSource = this.categoriesBindingSource;
            // 
            // ProductIDSpinEdit
            // 
            this.ProductIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoriesBindingSource, "CategoriesProducts.ProductID", true));
            this.ProductIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ProductIDSpinEdit.Location = new System.Drawing.Point(0, 0);
            this.ProductIDSpinEdit.Name = "ProductIDSpinEdit";
            this.ProductIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ProductIDSpinEdit.Size = new System.Drawing.Size(0, 20);
            this.ProductIDSpinEdit.StyleController = this.dataLayoutControl1;
            this.ProductIDSpinEdit.TabIndex = 4;
            // 
            // ProductNameTextEdit
            // 
            this.ProductNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "ProductName", true));
            this.ProductNameTextEdit.Location = new System.Drawing.Point(94, 6);
            this.ProductNameTextEdit.Name = "ProductNameTextEdit";
            this.ProductNameTextEdit.Size = new System.Drawing.Size(217, 20);
            this.ProductNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ProductNameTextEdit.TabIndex = 5;
            // 
            // CategoryIDSpinEdit
            // 
            this.CategoryIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoriesBindingSource, "CategoriesProducts.CategoryID", true));
            this.CategoryIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CategoryIDSpinEdit.Location = new System.Drawing.Point(0, 0);
            this.CategoryIDSpinEdit.Name = "CategoryIDSpinEdit";
            this.CategoryIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CategoryIDSpinEdit.Size = new System.Drawing.Size(0, 20);
            this.CategoryIDSpinEdit.StyleController = this.dataLayoutControl1;
            this.CategoryIDSpinEdit.TabIndex = 6;
            // 
            // QuantityPerUnitTextEdit
            // 
            this.QuantityPerUnitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "QuantityPerUnit", true));
            this.QuantityPerUnitTextEdit.Location = new System.Drawing.Point(94, 37);
            this.QuantityPerUnitTextEdit.Name = "QuantityPerUnitTextEdit";
            this.QuantityPerUnitTextEdit.Size = new System.Drawing.Size(217, 20);
            this.QuantityPerUnitTextEdit.StyleController = this.dataLayoutControl1;
            this.QuantityPerUnitTextEdit.TabIndex = 7;
            // 
            // UnitPriceSpinEdit
            // 
            this.UnitPriceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "UnitPrice", true));
            this.UnitPriceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UnitPriceSpinEdit.Location = new System.Drawing.Point(94, 68);
            this.UnitPriceSpinEdit.Name = "UnitPriceSpinEdit";
            this.UnitPriceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UnitPriceSpinEdit.Size = new System.Drawing.Size(217, 20);
            this.UnitPriceSpinEdit.StyleController = this.dataLayoutControl1;
            this.UnitPriceSpinEdit.TabIndex = 8;
            // 
            // UnitsInStockSpinEdit
            // 
            this.UnitsInStockSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "UnitsInStock", true));
            this.UnitsInStockSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UnitsInStockSpinEdit.Location = new System.Drawing.Point(94, 99);
            this.UnitsInStockSpinEdit.Name = "UnitsInStockSpinEdit";
            this.UnitsInStockSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UnitsInStockSpinEdit.Size = new System.Drawing.Size(217, 20);
            this.UnitsInStockSpinEdit.StyleController = this.dataLayoutControl1;
            this.UnitsInStockSpinEdit.TabIndex = 9;
            // 
            // ItemForProductID
            // 
            this.ItemForProductID.Control = this.ProductIDSpinEdit;
            this.ItemForProductID.CustomizationFormText = "Product ID";
            this.ItemForProductID.Location = new System.Drawing.Point(0, 0);
            this.ItemForProductID.Name = "ItemForProductID";
            this.ItemForProductID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForProductID.Size = new System.Drawing.Size(0, 0);
            this.ItemForProductID.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForProductID.Text = "Product ID";
            this.ItemForProductID.TextSize = new System.Drawing.Size(50, 20);
            // 
            // ItemForCategoryID
            // 
            this.ItemForCategoryID.Control = this.CategoryIDSpinEdit;
            this.ItemForCategoryID.CustomizationFormText = "Category ID";
            this.ItemForCategoryID.Location = new System.Drawing.Point(0, 0);
            this.ItemForCategoryID.Name = "ItemForCategoryID";
            this.ItemForCategoryID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForCategoryID.Size = new System.Drawing.Size(0, 0);
            this.ItemForCategoryID.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForCategoryID.Text = "Category ID";
            this.ItemForCategoryID.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(316, 388);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForProductName,
            this.ItemForQuantityPerUnit,
            this.ItemForUnitPrice,
            this.ItemForUnitsInStock,
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(316, 388);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForProductName
            // 
            this.ItemForProductName.Control = this.ProductNameTextEdit;
            this.ItemForProductName.CustomizationFormText = "Product Name";
            this.ItemForProductName.Location = new System.Drawing.Point(0, 0);
            this.ItemForProductName.Name = "ItemForProductName";
            this.ItemForProductName.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForProductName.Size = new System.Drawing.Size(316, 31);
            this.ItemForProductName.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForProductName.Text = "Product Name";
            this.ItemForProductName.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForQuantityPerUnit
            // 
            this.ItemForQuantityPerUnit.Control = this.QuantityPerUnitTextEdit;
            this.ItemForQuantityPerUnit.CustomizationFormText = "Quantity Per Unit";
            this.ItemForQuantityPerUnit.Location = new System.Drawing.Point(0, 31);
            this.ItemForQuantityPerUnit.Name = "ItemForQuantityPerUnit";
            this.ItemForQuantityPerUnit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForQuantityPerUnit.Size = new System.Drawing.Size(316, 31);
            this.ItemForQuantityPerUnit.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForQuantityPerUnit.Text = "Quantity Per Unit";
            this.ItemForQuantityPerUnit.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForUnitPrice
            // 
            this.ItemForUnitPrice.Control = this.UnitPriceSpinEdit;
            this.ItemForUnitPrice.CustomizationFormText = "Unit Price";
            this.ItemForUnitPrice.Location = new System.Drawing.Point(0, 62);
            this.ItemForUnitPrice.Name = "ItemForUnitPrice";
            this.ItemForUnitPrice.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForUnitPrice.Size = new System.Drawing.Size(316, 31);
            this.ItemForUnitPrice.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForUnitPrice.Text = "Unit Price";
            this.ItemForUnitPrice.TextSize = new System.Drawing.Size(83, 13);
            // 
            // ItemForUnitsInStock
            // 
            this.ItemForUnitsInStock.Control = this.UnitsInStockSpinEdit;
            this.ItemForUnitsInStock.CustomizationFormText = "Units In Stock";
            this.ItemForUnitsInStock.Location = new System.Drawing.Point(0, 93);
            this.ItemForUnitsInStock.Name = "ItemForUnitsInStock";
            this.ItemForUnitsInStock.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.ItemForUnitsInStock.Size = new System.Drawing.Size(316, 31);
            this.ItemForUnitsInStock.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForUnitsInStock.Text = "Units In Stock";
            this.ItemForUnitsInStock.TextSize = new System.Drawing.Size(83, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 124);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.emptySpaceItem1.Size = new System.Drawing.Size(316, 234);
            this.emptySpaceItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataNavigator;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 358);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(316, 30);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // colCategoryID
            // 
            this.colCategoryID.Caption = "CategoryID";
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 0;
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "CategoryName";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colProductID
            // 
            this.colProductID.Caption = "ProductID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "ProductName";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            // 
            // colCategoryID1
            // 
            this.colCategoryID1.Caption = "CategoryID";
            this.colCategoryID1.FieldName = "CategoryID";
            this.colCategoryID1.Name = "colCategoryID1";
            this.colCategoryID1.Visible = true;
            this.colCategoryID1.VisibleIndex = 2;
            // 
            // colQuantityPerUnit
            // 
            this.colQuantityPerUnit.Caption = "QuantityPerUnit";
            this.colQuantityPerUnit.FieldName = "QuantityPerUnit";
            this.colQuantityPerUnit.Name = "colQuantityPerUnit";
            this.colQuantityPerUnit.Visible = true;
            this.colQuantityPerUnit.VisibleIndex = 3;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "UnitPrice";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.Caption = "UnitsInStock";
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.Name = "colUnitsInStock";
            this.colUnitsInStock.Visible = true;
            this.colUnitsInStock.VisibleIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityPerUnitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsInStockSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantityPerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView categoriesView;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Q235715.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SpinEdit ProductIDSpinEdit;
        private DevExpress.XtraEditors.TextEdit ProductNameTextEdit;
        private DevExpress.XtraEditors.SpinEdit CategoryIDSpinEdit;
        private DevExpress.XtraEditors.TextEdit QuantityPerUnitTextEdit;
        private DevExpress.XtraEditors.SpinEdit UnitPriceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit UnitsInStockSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQuantityPerUnit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitsInStock;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DataNavigator dataNavigator;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Q235715.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView productsView;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPerUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;

    }
}

