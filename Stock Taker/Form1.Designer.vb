<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TypeLabel As System.Windows.Forms.Label
        Dim DetailLabel As System.Windows.Forms.Label
        Dim Stock_NumberLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Me.ProductsDataSet = New Stock_Taker.ProductsDataSet()
        Me.Sheet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sheet1TableAdapter = New Stock_Taker.ProductsDataSetTableAdapters.Sheet1TableAdapter()
        Me.TableAdapterManager = New Stock_Taker.ProductsDataSetTableAdapters.TableAdapterManager()
        Me.Sheet1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Sheet1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.DetailTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        TypeLabel = New System.Windows.Forms.Label()
        DetailLabel = New System.Windows.Forms.Label()
        Stock_NumberLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sheet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sheet1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sheet1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductsDataSet
        '
        Me.ProductsDataSet.DataSetName = "ProductsDataSet"
        Me.ProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sheet1BindingSource
        '
        Me.Sheet1BindingSource.DataMember = "Sheet1"
        Me.Sheet1BindingSource.DataSource = Me.ProductsDataSet
        '
        'Sheet1TableAdapter
        '
        Me.Sheet1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Sheet1TableAdapter = Me.Sheet1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Stock_Taker.ProductsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sheet1BindingNavigator
        '
        Me.Sheet1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Sheet1BindingNavigator.BindingSource = Me.Sheet1BindingSource
        Me.Sheet1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Sheet1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Sheet1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Sheet1BindingNavigatorSaveItem})
        Me.Sheet1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Sheet1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Sheet1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Sheet1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Sheet1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Sheet1BindingNavigator.Name = "Sheet1BindingNavigator"
        Me.Sheet1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Sheet1BindingNavigator.Size = New System.Drawing.Size(463, 25)
        Me.Sheet1BindingNavigator.TabIndex = 0
        Me.Sheet1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Sheet1BindingNavigatorSaveItem
        '
        Me.Sheet1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Sheet1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Sheet1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Sheet1BindingNavigatorSaveItem.Name = "Sheet1BindingNavigatorSaveItem"
        Me.Sheet1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Sheet1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(25, 38)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 1
        TypeLabel.Text = "Type:"
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(87, 35)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(171, 20)
        Me.TypeTextBox.TabIndex = 2
        '
        'DetailLabel
        '
        DetailLabel.AutoSize = True
        DetailLabel.Location = New System.Drawing.Point(25, 82)
        DetailLabel.Name = "DetailLabel"
        DetailLabel.Size = New System.Drawing.Size(37, 13)
        DetailLabel.TabIndex = 3
        DetailLabel.Text = "Detail:"
        '
        'DetailTextBox
        '
        Me.DetailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Detail", True))
        Me.DetailTextBox.Location = New System.Drawing.Point(87, 82)
        Me.DetailTextBox.Name = "DetailTextBox"
        Me.DetailTextBox.Size = New System.Drawing.Size(171, 20)
        Me.DetailTextBox.TabIndex = 4
        '
        'Stock_NumberLabel
        '
        Stock_NumberLabel.AutoSize = True
        Stock_NumberLabel.Location = New System.Drawing.Point(12, 134)
        Stock_NumberLabel.Name = "Stock_NumberLabel"
        Stock_NumberLabel.Size = New System.Drawing.Size(78, 13)
        Stock_NumberLabel.TabIndex = 5
        Stock_NumberLabel.Text = "Stock Number:"
        '
        'Stock_NumberTextBox
        '
        Me.Stock_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Stock Number", True))
        Me.Stock_NumberTextBox.Location = New System.Drawing.Point(115, 134)
        Me.Stock_NumberTextBox.Name = "Stock_NumberTextBox"
        Me.Stock_NumberTextBox.Size = New System.Drawing.Size(143, 20)
        Me.Stock_NumberTextBox.TabIndex = 6
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(25, 192)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 7
        CostLabel.Text = "Cost:"
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sheet1BindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(115, 192)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(143, 20)
        Me.CostTextBox.TabIndex = 8
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(314, 35)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(123, 34)
        Me.ButtonLoad.TabIndex = 9
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 261)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Stock_NumberLabel)
        Me.Controls.Add(Me.Stock_NumberTextBox)
        Me.Controls.Add(DetailLabel)
        Me.Controls.Add(Me.DetailTextBox)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(Me.Sheet1BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sheet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sheet1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sheet1BindingNavigator.ResumeLayout(False)
        Me.Sheet1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductsDataSet As ProductsDataSet
    Friend WithEvents Sheet1BindingSource As BindingSource
    Friend WithEvents Sheet1TableAdapter As ProductsDataSetTableAdapters.Sheet1TableAdapter
    Friend WithEvents TableAdapterManager As ProductsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sheet1BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Sheet1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents DetailTextBox As TextBox
    Friend WithEvents Stock_NumberTextBox As TextBox
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents ButtonLoad As Button
End Class
