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
            Me.detailView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.mainView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colText = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInfo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDetail = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.dataNavigator = New DevExpress.XtraEditors.DataNavigator()
            Me.detailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ProductIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.CategoryIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.NameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.InfoTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.StateCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.ItemForProductID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCategoryID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForInfo = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForState = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.detailView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType(Me.detailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CategoryIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.InfoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StateCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForProductID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' detailView
            ' 
            Me.detailView.GridControl = Me.gridControl1
            Me.detailView.Name = "detailView"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.recordBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            gridLevelNode1.LevelTemplate = Me.detailView
            gridLevelNode1.RelationName = "Details"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.mainView
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(450, 392)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.mainView, Me.detailView})
            ' 
            ' recordBindingSource
            ' 
            Me.recordBindingSource.DataSource = GetType(Q235715.Record)
            ' 
            ' mainView
            ' 
            Me.mainView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colParentID, Me.colText, Me.colInfo, Me.colValue, Me.colDt, Me.colState, Me.colImage, Me.colDetail})
            Me.mainView.GridControl = Me.gridControl1
            Me.mainView.Name = "mainView"
            Me.mainView.OptionsBehavior.Editable = False
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colParentID
            ' 
            Me.colParentID.FieldName = "ParentID"
            Me.colParentID.Name = "colParentID"
            Me.colParentID.Visible = True
            Me.colParentID.VisibleIndex = 1
            ' 
            ' colText
            ' 
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            Me.colText.VisibleIndex = 2
            ' 
            ' colInfo
            ' 
            Me.colInfo.FieldName = "Info"
            Me.colInfo.Name = "colInfo"
            Me.colInfo.Visible = True
            Me.colInfo.VisibleIndex = 3
            ' 
            ' colValue
            ' 
            Me.colValue.FieldName = "Value"
            Me.colValue.Name = "colValue"
            Me.colValue.Visible = True
            Me.colValue.VisibleIndex = 4
            ' 
            ' colDt
            ' 
            Me.colDt.FieldName = "Dt"
            Me.colDt.Name = "colDt"
            Me.colDt.Visible = True
            Me.colDt.VisibleIndex = 5
            ' 
            ' colState
            ' 
            Me.colState.FieldName = "State"
            Me.colState.Name = "colState"
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 6
            ' 
            ' colImage
            ' 
            Me.colImage.FieldName = "Image"
            Me.colImage.Name = "colImage"
            Me.colImage.Visible = True
            Me.colImage.VisibleIndex = 7
            ' 
            ' colDetail
            ' 
            Me.colDetail.FieldName = "Detail"
            Me.colDetail.Name = "colDetail"
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
            Me.dataLayoutControl1.Controls.Add(Me.CategoryIDSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.IDTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.NameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.InfoTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.StateCheckEdit)
            Me.dataLayoutControl1.DataSource = Me.detailBindingSource
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForProductID, Me.ItemForCategoryID})
            Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(314, 392)
            Me.dataLayoutControl1.TabIndex = 0
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' dataNavigator
            ' 
            Me.dataNavigator.DataSource = Me.detailBindingSource
            Me.dataNavigator.Location = New System.Drawing.Point(5, 368)
            Me.dataNavigator.Name = "dataNavigator"
            Me.dataNavigator.Size = New System.Drawing.Size(304, 19)
            Me.dataNavigator.StyleController = Me.dataLayoutControl1
            Me.dataNavigator.TabIndex = 1
            Me.dataNavigator.Text = "dataNavigator1"
            Me.dataNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin
            ' 
            ' detailBindingSource
            ' 
            Me.detailBindingSource.DataMember = "Details"
            Me.detailBindingSource.DataSource = Me.recordBindingSource
            ' 
            ' ProductIDSpinEdit
            ' 
            Me.ProductIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.ProductIDSpinEdit.Location = New System.Drawing.Point(0, 0)
            Me.ProductIDSpinEdit.Name = "ProductIDSpinEdit"
            Me.ProductIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.ProductIDSpinEdit.Size = New System.Drawing.Size(0, 20)
            Me.ProductIDSpinEdit.StyleController = Me.dataLayoutControl1
            Me.ProductIDSpinEdit.TabIndex = 4
            ' 
            ' CategoryIDSpinEdit
            ' 
            Me.CategoryIDSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.CategoryIDSpinEdit.Location = New System.Drawing.Point(0, 0)
            Me.CategoryIDSpinEdit.Name = "CategoryIDSpinEdit"
            Me.CategoryIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.CategoryIDSpinEdit.Size = New System.Drawing.Size(0, 20)
            Me.CategoryIDSpinEdit.StyleController = Me.dataLayoutControl1
            Me.CategoryIDSpinEdit.TabIndex = 6
            ' 
            ' IDTextEdit
            ' 
            Me.IDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.detailBindingSource, "ID", True))
            Me.IDTextEdit.Location = New System.Drawing.Point(32, 2)
            Me.IDTextEdit.Name = "IDTextEdit"
            Me.IDTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.IDTextEdit.Properties.Mask.EditMask = "N0"
            Me.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.IDTextEdit.Size = New System.Drawing.Size(280, 20)
            Me.IDTextEdit.StyleController = Me.dataLayoutControl1
            Me.IDTextEdit.TabIndex = 7
            ' 
            ' NameTextEdit
            ' 
            Me.NameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.detailBindingSource, "Name", True))
            Me.NameTextEdit.Location = New System.Drawing.Point(32, 26)
            Me.NameTextEdit.Name = "NameTextEdit"
            Me.NameTextEdit.Size = New System.Drawing.Size(280, 20)
            Me.NameTextEdit.StyleController = Me.dataLayoutControl1
            Me.NameTextEdit.TabIndex = 8
            ' 
            ' InfoTextEdit
            ' 
            Me.InfoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.detailBindingSource, "Info", True))
            Me.InfoTextEdit.Location = New System.Drawing.Point(32, 50)
            Me.InfoTextEdit.Name = "InfoTextEdit"
            Me.InfoTextEdit.Size = New System.Drawing.Size(280, 20)
            Me.InfoTextEdit.StyleController = Me.dataLayoutControl1
            Me.InfoTextEdit.TabIndex = 9
            ' 
            ' StateCheckEdit
            ' 
            Me.StateCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.detailBindingSource, "State", True))
            Me.StateCheckEdit.Location = New System.Drawing.Point(32, 74)
            Me.StateCheckEdit.Name = "StateCheckEdit"
            Me.StateCheckEdit.Properties.Caption = "State"
            Me.StateCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.StateCheckEdit.Size = New System.Drawing.Size(280, 19)
            Me.StateCheckEdit.StyleController = Me.dataLayoutControl1
            Me.StateCheckEdit.TabIndex = 10
            ' 
            ' ItemForProductID
            ' 
            Me.ItemForProductID.Control = Me.ProductIDSpinEdit
            Me.ItemForProductID.CustomizationFormText = "Product ID"
            Me.ItemForProductID.Location = New System.Drawing.Point(0, 0)
            Me.ItemForProductID.Name = "ItemForProductID"
            Me.ItemForProductID.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForProductID.Size = New System.Drawing.Size(0, 0)
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
            Me.layoutControlGroup1.Size = New System.Drawing.Size(314, 392)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForID, Me.ItemForName, Me.ItemForInfo, Me.ItemForState, Me.layoutControlItem1, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(314, 392)
            ' 
            ' ItemForID
            ' 
            Me.ItemForID.Control = Me.IDTextEdit
            Me.ItemForID.Location = New System.Drawing.Point(0, 0)
            Me.ItemForID.Name = "ItemForID"
            Me.ItemForID.Size = New System.Drawing.Size(314, 24)
            Me.ItemForID.Text = "ID"
            Me.ItemForID.TextSize = New System.Drawing.Size(27, 13)
            ' 
            ' ItemForName
            ' 
            Me.ItemForName.Control = Me.NameTextEdit
            Me.ItemForName.Location = New System.Drawing.Point(0, 24)
            Me.ItemForName.Name = "ItemForName"
            Me.ItemForName.Size = New System.Drawing.Size(314, 24)
            Me.ItemForName.Text = "Name"
            Me.ItemForName.TextSize = New System.Drawing.Size(27, 13)
            ' 
            ' ItemForInfo
            ' 
            Me.ItemForInfo.Control = Me.InfoTextEdit
            Me.ItemForInfo.Location = New System.Drawing.Point(0, 48)
            Me.ItemForInfo.Name = "ItemForInfo"
            Me.ItemForInfo.Size = New System.Drawing.Size(314, 24)
            Me.ItemForInfo.Text = "Info"
            Me.ItemForInfo.TextSize = New System.Drawing.Size(27, 13)
            ' 
            ' ItemForState
            ' 
            Me.ItemForState.Control = Me.StateCheckEdit
            Me.ItemForState.Location = New System.Drawing.Point(0, 72)
            Me.ItemForState.Name = "ItemForState"
            Me.ItemForState.Size = New System.Drawing.Size(314, 23)
            Me.ItemForState.Text = "State"
            Me.ItemForState.TextSize = New System.Drawing.Size(27, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.dataNavigator
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 363)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem1.Size = New System.Drawing.Size(314, 29)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 95)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(314, 268)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(776, 392)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.detailView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mainView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType(Me.detailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CategoryIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.InfoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StateCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForProductID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForState, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private mainView As DevExpress.XtraGrid.Views.Grid.GridView
        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
        Private ProductIDSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private CategoryIDSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private ItemForProductID As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForCategoryID As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents dataNavigator As DevExpress.XtraEditors.DataNavigator
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private recordBindingSource As System.Windows.Forms.BindingSource
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colParentID As DevExpress.XtraGrid.Columns.GridColumn
        Private colText As DevExpress.XtraGrid.Columns.GridColumn
        Private colInfo As DevExpress.XtraGrid.Columns.GridColumn
        Private colValue As DevExpress.XtraGrid.Columns.GridColumn
        Private colDt As DevExpress.XtraGrid.Columns.GridColumn
        Private colState As DevExpress.XtraGrid.Columns.GridColumn
        Private colImage As DevExpress.XtraGrid.Columns.GridColumn
        Private colDetail As DevExpress.XtraGrid.Columns.GridColumn
        Private IDTextEdit As DevExpress.XtraEditors.TextEdit
        Private detailBindingSource As System.Windows.Forms.BindingSource
        Private NameTextEdit As DevExpress.XtraEditors.TextEdit
        Private InfoTextEdit As DevExpress.XtraEditors.TextEdit
        Private StateCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private ItemForID As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForName As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForInfo As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForState As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents detailView As DevExpress.XtraGrid.Views.Grid.GridView
    End Class
End Namespace

