Namespace DXApplication206
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
            Me.customGridControl1 = New DXApplication206.CustomGridControl()
            Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New DXApplication206.nwindDataSet()
            Me.customGridView1 = New DXApplication206.CustomGridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShippedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipVia = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipRegion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ordersTableAdapter = New DXApplication206.nwindDataSetTableAdapters.OrdersTableAdapter()
            Me.order_DetailsTableAdapter1 = New DXApplication206.nwindDataSetTableAdapters.Order_DetailsTableAdapter()
            DirectCast(Me.customGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.customGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' customGridControl1
            ' 
            Me.customGridControl1.DataSource = Me.ordersBindingSource
            Me.customGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.customGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.customGridControl1.MainView = Me.customGridView1
            Me.customGridControl1.Name = "customGridControl1"
            Me.customGridControl1.Size = New System.Drawing.Size(733, 283)
            Me.customGridControl1.TabIndex = 0
            Me.customGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.customGridView1})
            ' 
            ' ordersBindingSource
            ' 
            Me.ordersBindingSource.DataMember = "Orders"
            Me.ordersBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' customGridView1
            ' 
            Me.customGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colRequiredDate, Me.colShippedDate, Me.colShipVia, Me.colFreight, Me.colShipName, Me.colShipAddress, Me.colShipCity, Me.colShipRegion, Me.colShipPostalCode, Me.colShipCountry})
            Me.customGridView1.GridControl = Me.customGridControl1
            Me.customGridView1.Name = "customGridView1"
            ' 
            ' colOrderID
            ' 
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.Visible = True
            Me.colOrderID.VisibleIndex = 0
            ' 
            ' colCustomerID
            ' 
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.Visible = True
            Me.colCustomerID.VisibleIndex = 1
            ' 
            ' colEmployeeID
            ' 
            Me.colEmployeeID.FieldName = "EmployeeID"
            Me.colEmployeeID.Name = "colEmployeeID"
            Me.colEmployeeID.Visible = True
            Me.colEmployeeID.VisibleIndex = 2
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 3
            ' 
            ' colRequiredDate
            ' 
            Me.colRequiredDate.FieldName = "RequiredDate"
            Me.colRequiredDate.Name = "colRequiredDate"
            Me.colRequiredDate.Visible = True
            Me.colRequiredDate.VisibleIndex = 4
            ' 
            ' colShippedDate
            ' 
            Me.colShippedDate.FieldName = "ShippedDate"
            Me.colShippedDate.Name = "colShippedDate"
            Me.colShippedDate.Visible = True
            Me.colShippedDate.VisibleIndex = 5
            ' 
            ' colShipVia
            ' 
            Me.colShipVia.FieldName = "ShipVia"
            Me.colShipVia.Name = "colShipVia"
            Me.colShipVia.Visible = True
            Me.colShipVia.VisibleIndex = 6
            ' 
            ' colFreight
            ' 
            Me.colFreight.FieldName = "Freight"
            Me.colFreight.Name = "colFreight"
            Me.colFreight.Visible = True
            Me.colFreight.VisibleIndex = 7
            ' 
            ' colShipName
            ' 
            Me.colShipName.FieldName = "ShipName"
            Me.colShipName.Name = "colShipName"
            Me.colShipName.Visible = True
            Me.colShipName.VisibleIndex = 8
            ' 
            ' colShipAddress
            ' 
            Me.colShipAddress.FieldName = "ShipAddress"
            Me.colShipAddress.Name = "colShipAddress"
            Me.colShipAddress.Visible = True
            Me.colShipAddress.VisibleIndex = 9
            ' 
            ' colShipCity
            ' 
            Me.colShipCity.FieldName = "ShipCity"
            Me.colShipCity.Name = "colShipCity"
            Me.colShipCity.Visible = True
            Me.colShipCity.VisibleIndex = 10
            ' 
            ' colShipRegion
            ' 
            Me.colShipRegion.FieldName = "ShipRegion"
            Me.colShipRegion.Name = "colShipRegion"
            Me.colShipRegion.Visible = True
            Me.colShipRegion.VisibleIndex = 11
            ' 
            ' colShipPostalCode
            ' 
            Me.colShipPostalCode.FieldName = "ShipPostalCode"
            Me.colShipPostalCode.Name = "colShipPostalCode"
            Me.colShipPostalCode.Visible = True
            Me.colShipPostalCode.VisibleIndex = 12
            ' 
            ' colShipCountry
            ' 
            Me.colShipCountry.FieldName = "ShipCountry"
            Me.colShipCountry.Name = "colShipCountry"
            Me.colShipCountry.Visible = True
            Me.colShipCountry.VisibleIndex = 13
            ' 
            ' ordersTableAdapter
            ' 
            Me.ordersTableAdapter.ClearBeforeFill = True
            ' 
            ' order_DetailsTableAdapter1
            ' 
            Me.order_DetailsTableAdapter1.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(733, 283)
            Me.Controls.Add(Me.customGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.customGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.customGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private customGridControl1 As CustomGridControl
        Private customGridView1 As CustomGridView
        Private nwindDataSet As nwindDataSet
        Private ordersBindingSource As System.Windows.Forms.BindingSource
        Private ordersTableAdapter As nwindDataSetTableAdapters.OrdersTableAdapter
        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
        Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colShippedDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colShipVia As DevExpress.XtraGrid.Columns.GridColumn
        Private colFreight As DevExpress.XtraGrid.Columns.GridColumn
        Private colShipName As DevExpress.XtraGrid.Columns.GridColumn
        Private colShipAddress As DevExpress.XtraGrid.Columns.GridColumn
        Private colShipCity As DevExpress.XtraGrid.Columns.GridColumn
        Private colShipRegion As DevExpress.XtraGrid.Columns.GridColumn
        Private colShipPostalCode As DevExpress.XtraGrid.Columns.GridColumn
        Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn
        Private order_DetailsTableAdapter1 As nwindDataSetTableAdapters.Order_DetailsTableAdapter
    End Class
End Namespace

