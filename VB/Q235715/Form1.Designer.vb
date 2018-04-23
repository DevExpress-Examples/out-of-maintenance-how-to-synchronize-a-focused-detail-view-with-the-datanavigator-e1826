Imports Microsoft.VisualBasic
Imports System
Namespace Q235715
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.productsView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Q235715.nwindDataSet()
			Me.categoriesView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
			Me.dataNavigator = New DevExpress.XtraEditors.DataNavigator()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.ProductIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.ProductNameTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.CategoryIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.QuantityPerUnitTextEdit = New DevExpress.XtraEditors.TextEdit()
			Me.UnitPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.UnitsInStockSpinEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.ItemForProductID = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForCategoryID = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.ItemForProductName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForQuantityPerUnit = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ItemForUnitsInStock = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.categoriesTableAdapter = New Q235715.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.productsTableAdapter = New Q235715.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.productsView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dataLayoutControl1.SuspendLayout()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ProductIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CategoryIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.QuantityPerUnitTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.UnitPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.UnitsInStockSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForProductID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForProductName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForQuantityPerUnit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ItemForUnitsInStock, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' productsView
			' 
			Me.productsView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colCategoryID1, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock})
			Me.productsView.GridControl = Me.gridControl1
			Me.productsView.Name = "productsView"
'			Me.productsView.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.OnProductsViewFocusedRowChanged);
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.categoriesBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			gridLevelNode1.LevelTemplate = Me.productsView
			gridLevelNode1.RelationName = "CategoriesProducts"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.categoriesView
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(446, 388)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.categoriesView, Me.productsView})
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesView
			' 
			Me.categoriesView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colCategoryName, Me.colDescription})
			Me.categoriesView.GridControl = Me.gridControl1
			Me.categoriesView.Name = "categoriesView"
			Me.categoriesView.OptionsBehavior.Editable = False
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.gridControl1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.dataLayoutControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(776, 392)
			Me.splitContainerControl1.SplitterPosition = 450
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' dataLayoutControl1
			' 
			Me.dataLayoutControl1.Controls.Add(Me.dataNavigator)
			Me.dataLayoutControl1.Controls.Add(Me.ProductIDSpinEdit)
			Me.dataLayoutControl1.Controls.Add(Me.ProductNameTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.CategoryIDSpinEdit)
			Me.dataLayoutControl1.Controls.Add(Me.QuantityPerUnitTextEdit)
			Me.dataLayoutControl1.Controls.Add(Me.UnitPriceSpinEdit)
			Me.dataLayoutControl1.Controls.Add(Me.UnitsInStockSpinEdit)
			Me.dataLayoutControl1.DataSource = Me.productsBindingSource
			Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForProductID, Me.ItemForCategoryID})
			Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.dataLayoutControl1.Name = "dataLayoutControl1"
			Me.dataLayoutControl1.Root = Me.layoutControlGroup1
			Me.dataLayoutControl1.Size = New System.Drawing.Size(316, 388)
			Me.dataLayoutControl1.TabIndex = 0
			Me.dataLayoutControl1.Text = "dataLayoutControl1"
			' 
			' dataNavigator
			' 
			Me.dataNavigator.DataSource = Me.productsBindingSource
			Me.dataNavigator.Location = New System.Drawing.Point(6, 364)
			Me.dataNavigator.Name = "dataNavigator"
			Me.dataNavigator.Size = New System.Drawing.Size(305, 19)
			Me.dataNavigator.StyleController = Me.dataLayoutControl1
			Me.dataNavigator.TabIndex = 1
			Me.dataNavigator.Text = "dataNavigator1"
			Me.dataNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin
'			Me.dataNavigator.PositionChanged += New System.EventHandler(Me.OnDataNavigatorPositionChanged);
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "CategoriesProducts"
			Me.productsBindingSource.DataSource = Me.categoriesBindingSource
			' 
			' ProductIDSpinEdit
			' 
			Me.ProductIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.categoriesBindingSource, "CategoriesProducts.ProductID", True))
			Me.ProductIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.ProductIDSpinEdit.Location = New System.Drawing.Point(0, 0)
			Me.ProductIDSpinEdit.Name = "ProductIDSpinEdit"
			Me.ProductIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.ProductIDSpinEdit.Size = New System.Drawing.Size(0, 20)
			Me.ProductIDSpinEdit.StyleController = Me.dataLayoutControl1
			Me.ProductIDSpinEdit.TabIndex = 4
			' 
			' ProductNameTextEdit
			' 
			Me.ProductNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "ProductName", True))
			Me.ProductNameTextEdit.Location = New System.Drawing.Point(94, 6)
			Me.ProductNameTextEdit.Name = "ProductNameTextEdit"
			Me.ProductNameTextEdit.Size = New System.Drawing.Size(217, 20)
			Me.ProductNameTextEdit.StyleController = Me.dataLayoutControl1
			Me.ProductNameTextEdit.TabIndex = 5
			' 
			' CategoryIDSpinEdit
			' 
			Me.CategoryIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.categoriesBindingSource, "CategoriesProducts.CategoryID", True))
			Me.CategoryIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.CategoryIDSpinEdit.Location = New System.Drawing.Point(0, 0)
			Me.CategoryIDSpinEdit.Name = "CategoryIDSpinEdit"
			Me.CategoryIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.CategoryIDSpinEdit.Size = New System.Drawing.Size(0, 20)
			Me.CategoryIDSpinEdit.StyleController = Me.dataLayoutControl1
			Me.CategoryIDSpinEdit.TabIndex = 6
			' 
			' QuantityPerUnitTextEdit
			' 
			Me.QuantityPerUnitTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "QuantityPerUnit", True))
			Me.QuantityPerUnitTextEdit.Location = New System.Drawing.Point(94, 37)
			Me.QuantityPerUnitTextEdit.Name = "QuantityPerUnitTextEdit"
			Me.QuantityPerUnitTextEdit.Size = New System.Drawing.Size(217, 20)
			Me.QuantityPerUnitTextEdit.StyleController = Me.dataLayoutControl1
			Me.QuantityPerUnitTextEdit.TabIndex = 7
			' 
			' UnitPriceSpinEdit
			' 
			Me.UnitPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "UnitPrice", True))
			Me.UnitPriceSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.UnitPriceSpinEdit.Location = New System.Drawing.Point(94, 68)
			Me.UnitPriceSpinEdit.Name = "UnitPriceSpinEdit"
			Me.UnitPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.UnitPriceSpinEdit.Size = New System.Drawing.Size(217, 20)
			Me.UnitPriceSpinEdit.StyleController = Me.dataLayoutControl1
			Me.UnitPriceSpinEdit.TabIndex = 8
			' 
			' UnitsInStockSpinEdit
			' 
			Me.UnitsInStockSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.productsBindingSource, "UnitsInStock", True))
			Me.UnitsInStockSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.UnitsInStockSpinEdit.Location = New System.Drawing.Point(94, 99)
			Me.UnitsInStockSpinEdit.Name = "UnitsInStockSpinEdit"
			Me.UnitsInStockSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.UnitsInStockSpinEdit.Size = New System.Drawing.Size(217, 20)
			Me.UnitsInStockSpinEdit.StyleController = Me.dataLayoutControl1
			Me.UnitsInStockSpinEdit.TabIndex = 9
			' 
			' ItemForProductID
			' 
			Me.ItemForProductID.Control = Me.ProductIDSpinEdit
			Me.ItemForProductID.CustomizationFormText = "Product ID"
			Me.ItemForProductID.Location = New System.Drawing.Point(0, 0)
			Me.ItemForProductID.Name = "ItemForProductID"
			Me.ItemForProductID.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.ItemForProductID.Size = New System.Drawing.Size(0, 0)
			Me.ItemForProductID.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.ItemForProductID.Text = "Product ID"
			Me.ItemForProductID.TextSize = New System.Drawing.Size(50, 20)
			' 
			' ItemForCategoryID
			' 
			Me.ItemForCategoryID.Control = Me.CategoryIDSpinEdit
			Me.ItemForCategoryID.CustomizationFormText = "Category ID"
			Me.ItemForCategoryID.Location = New System.Drawing.Point(0, 0)
			Me.ItemForCategoryID.Name = "ItemForCategoryID"
			Me.ItemForCategoryID.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.ItemForCategoryID.Size = New System.Drawing.Size(0, 0)
			Me.ItemForCategoryID.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.ItemForCategoryID.Text = "Category ID"
			Me.ItemForCategoryID.TextSize = New System.Drawing.Size(50, 20)
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(316, 388)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
			Me.layoutControlGroup2.GroupBordersVisible = False
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForProductName, Me.ItemForQuantityPerUnit, Me.ItemForUnitPrice, Me.ItemForUnitsInStock, Me.emptySpaceItem1, Me.layoutControlItem1})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
			Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup2.Size = New System.Drawing.Size(316, 388)
			Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
			Me.layoutControlGroup2.Text = "autoGeneratedGroup0"
			' 
			' ItemForProductName
			' 
			Me.ItemForProductName.Control = Me.ProductNameTextEdit
			Me.ItemForProductName.CustomizationFormText = "Product Name"
			Me.ItemForProductName.Location = New System.Drawing.Point(0, 0)
			Me.ItemForProductName.Name = "ItemForProductName"
			Me.ItemForProductName.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.ItemForProductName.Size = New System.Drawing.Size(316, 31)
			Me.ItemForProductName.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.ItemForProductName.Text = "Product Name"
			Me.ItemForProductName.TextSize = New System.Drawing.Size(83, 13)
			' 
			' ItemForQuantityPerUnit
			' 
			Me.ItemForQuantityPerUnit.Control = Me.QuantityPerUnitTextEdit
			Me.ItemForQuantityPerUnit.CustomizationFormText = "Quantity Per Unit"
			Me.ItemForQuantityPerUnit.Location = New System.Drawing.Point(0, 31)
			Me.ItemForQuantityPerUnit.Name = "ItemForQuantityPerUnit"
			Me.ItemForQuantityPerUnit.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.ItemForQuantityPerUnit.Size = New System.Drawing.Size(316, 31)
			Me.ItemForQuantityPerUnit.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.ItemForQuantityPerUnit.Text = "Quantity Per Unit"
			Me.ItemForQuantityPerUnit.TextSize = New System.Drawing.Size(83, 13)
			' 
			' ItemForUnitPrice
			' 
			Me.ItemForUnitPrice.Control = Me.UnitPriceSpinEdit
			Me.ItemForUnitPrice.CustomizationFormText = "Unit Price"
			Me.ItemForUnitPrice.Location = New System.Drawing.Point(0, 62)
			Me.ItemForUnitPrice.Name = "ItemForUnitPrice"
			Me.ItemForUnitPrice.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.ItemForUnitPrice.Size = New System.Drawing.Size(316, 31)
			Me.ItemForUnitPrice.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.ItemForUnitPrice.Text = "Unit Price"
			Me.ItemForUnitPrice.TextSize = New System.Drawing.Size(83, 13)
			' 
			' ItemForUnitsInStock
			' 
			Me.ItemForUnitsInStock.Control = Me.UnitsInStockSpinEdit
			Me.ItemForUnitsInStock.CustomizationFormText = "Units In Stock"
			Me.ItemForUnitsInStock.Location = New System.Drawing.Point(0, 93)
			Me.ItemForUnitsInStock.Name = "ItemForUnitsInStock"
			Me.ItemForUnitsInStock.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.ItemForUnitsInStock.Size = New System.Drawing.Size(316, 31)
			Me.ItemForUnitsInStock.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.ItemForUnitsInStock.Text = "Units In Stock"
			Me.ItemForUnitsInStock.TextSize = New System.Drawing.Size(83, 13)
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 124)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.emptySpaceItem1.Size = New System.Drawing.Size(316, 234)
			Me.emptySpaceItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.dataNavigator
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 358)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutControlItem1.Size = New System.Drawing.Size(316, 30)
			Me.layoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' colCategoryID
			' 
			Me.colCategoryID.Caption = "CategoryID"
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 0
			' 
			' colCategoryName
			' 
			Me.colCategoryName.Caption = "CategoryName"
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			' 
			' colDescription
			' 
			Me.colDescription.Caption = "Description"
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 2
			' 
			' colProductID
			' 
			Me.colProductID.Caption = "ProductID"
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.Visible = True
			Me.colProductID.VisibleIndex = 0
			' 
			' colProductName
			' 
			Me.colProductName.Caption = "ProductName"
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 1
			' 
			' colCategoryID1
			' 
			Me.colCategoryID1.Caption = "CategoryID"
			Me.colCategoryID1.FieldName = "CategoryID"
			Me.colCategoryID1.Name = "colCategoryID1"
			Me.colCategoryID1.Visible = True
			Me.colCategoryID1.VisibleIndex = 2
			' 
			' colQuantityPerUnit
			' 
			Me.colQuantityPerUnit.Caption = "QuantityPerUnit"
			Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
			Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
			Me.colQuantityPerUnit.Visible = True
			Me.colQuantityPerUnit.VisibleIndex = 3
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.Caption = "UnitPrice"
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 4
			' 
			' colUnitsInStock
			' 
			Me.colUnitsInStock.Caption = "UnitsInStock"
			Me.colUnitsInStock.FieldName = "UnitsInStock"
			Me.colUnitsInStock.Name = "colUnitsInStock"
			Me.colUnitsInStock.Visible = True
			Me.colUnitsInStock.VisibleIndex = 5
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(776, 392)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.productsView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dataLayoutControl1.ResumeLayout(False)
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ProductIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ProductNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CategoryIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.QuantityPerUnitTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.UnitPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.UnitsInStockSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForProductID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForProductName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForQuantityPerUnit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ItemForUnitsInStock, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private categoriesView As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As Q235715.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
		Private ProductIDSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private ProductNameTextEdit As DevExpress.XtraEditors.TextEdit
		Private CategoryIDSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private QuantityPerUnitTextEdit As DevExpress.XtraEditors.TextEdit
		Private UnitPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private UnitsInStockSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private ItemForProductID As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForCategoryID As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private ItemForProductName As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForQuantityPerUnit As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForUnitPrice As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForUnitsInStock As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private WithEvents dataNavigator As DevExpress.XtraEditors.DataNavigator
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As Q235715.nwindDataSetTableAdapters.ProductsTableAdapter
		Private WithEvents productsView As DevExpress.XtraGrid.Views.Grid.GridView
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace

