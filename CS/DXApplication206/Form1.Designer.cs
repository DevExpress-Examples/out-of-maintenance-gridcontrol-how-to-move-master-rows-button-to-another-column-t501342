namespace DXApplication206 {
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
            this.customGridControl1 = new DXApplication206.CustomGridControl();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new DXApplication206.nwindDataSet();
            this.customGridView1 = new DXApplication206.CustomGridView();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShippedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipVia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersTableAdapter = new DXApplication206.nwindDataSetTableAdapters.OrdersTableAdapter();
            this.order_DetailsTableAdapter1 = new DXApplication206.nwindDataSetTableAdapters.Order_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customGridControl1
            // 
            this.customGridControl1.DataSource = this.ordersBindingSource;
            this.customGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGridControl1.Location = new System.Drawing.Point(0, 0);
            this.customGridControl1.MainView = this.customGridView1;
            this.customGridControl1.Name = "customGridControl1";
            this.customGridControl1.Size = new System.Drawing.Size(733, 283);
            this.customGridControl1.TabIndex = 0;
            this.customGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView1});
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customGridView1
            // 
            this.customGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID,
            this.colCustomerID,
            this.colEmployeeID,
            this.colOrderDate,
            this.colRequiredDate,
            this.colShippedDate,
            this.colShipVia,
            this.colFreight,
            this.colShipName,
            this.colShipAddress,
            this.colShipCity,
            this.colShipRegion,
            this.colShipPostalCode,
            this.colShipCountry});
            this.customGridView1.GridControl = this.customGridControl1;
            this.customGridView1.Name = "customGridView1";
            // 
            // colOrderID
            // 
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.Visible = true;
            this.colOrderID.VisibleIndex = 0;
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 1;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 2;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 3;
            // 
            // colRequiredDate
            // 
            this.colRequiredDate.FieldName = "RequiredDate";
            this.colRequiredDate.Name = "colRequiredDate";
            this.colRequiredDate.Visible = true;
            this.colRequiredDate.VisibleIndex = 4;
            // 
            // colShippedDate
            // 
            this.colShippedDate.FieldName = "ShippedDate";
            this.colShippedDate.Name = "colShippedDate";
            this.colShippedDate.Visible = true;
            this.colShippedDate.VisibleIndex = 5;
            // 
            // colShipVia
            // 
            this.colShipVia.FieldName = "ShipVia";
            this.colShipVia.Name = "colShipVia";
            this.colShipVia.Visible = true;
            this.colShipVia.VisibleIndex = 6;
            // 
            // colFreight
            // 
            this.colFreight.FieldName = "Freight";
            this.colFreight.Name = "colFreight";
            this.colFreight.Visible = true;
            this.colFreight.VisibleIndex = 7;
            // 
            // colShipName
            // 
            this.colShipName.FieldName = "ShipName";
            this.colShipName.Name = "colShipName";
            this.colShipName.Visible = true;
            this.colShipName.VisibleIndex = 8;
            // 
            // colShipAddress
            // 
            this.colShipAddress.FieldName = "ShipAddress";
            this.colShipAddress.Name = "colShipAddress";
            this.colShipAddress.Visible = true;
            this.colShipAddress.VisibleIndex = 9;
            // 
            // colShipCity
            // 
            this.colShipCity.FieldName = "ShipCity";
            this.colShipCity.Name = "colShipCity";
            this.colShipCity.Visible = true;
            this.colShipCity.VisibleIndex = 10;
            // 
            // colShipRegion
            // 
            this.colShipRegion.FieldName = "ShipRegion";
            this.colShipRegion.Name = "colShipRegion";
            this.colShipRegion.Visible = true;
            this.colShipRegion.VisibleIndex = 11;
            // 
            // colShipPostalCode
            // 
            this.colShipPostalCode.FieldName = "ShipPostalCode";
            this.colShipPostalCode.Name = "colShipPostalCode";
            this.colShipPostalCode.Visible = true;
            this.colShipPostalCode.VisibleIndex = 12;
            // 
            // colShipCountry
            // 
            this.colShipCountry.FieldName = "ShipCountry";
            this.colShipCountry.Name = "colShipCountry";
            this.colShipCountry.Visible = true;
            this.colShipCountry.VisibleIndex = 13;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 283);
            this.Controls.Add(this.customGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGridControl customGridControl1;
        private CustomGridView customGridView1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private nwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShippedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShipVia;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colShipName;
        private DevExpress.XtraGrid.Columns.GridColumn colShipAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCity;
        private DevExpress.XtraGrid.Columns.GridColumn colShipRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colShipPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCountry;
        private nwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
    }
}

