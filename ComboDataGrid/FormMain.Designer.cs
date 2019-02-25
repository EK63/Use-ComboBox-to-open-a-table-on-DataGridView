namespace ComboData
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPickList = new System.Windows.Forms.Label();
            this.cboSelectFruit = new System.Windows.Forms.ComboBox();
            this.lblPickListValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPickListDescription = new System.Windows.Forms.Label();
            this.tblPickListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picklistDataSet = new ComboData.PicklistDataSet();
            this.tblPickListTableAdapter = new ComboData.PicklistDataSetTableAdapters.tblPickListTableAdapter();
            this.lblPickListFileName = new System.Windows.Forms.Label();
            this.dgvUtilityTable = new System.Windows.Forms.DataGridView();
            this.tblMelonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picklistDataSet1 = new ComboData.PicklistDataSet1();
            this.tblMelonTableAdapter = new ComboData.PicklistDataSet1TableAdapters.tblMelonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblPickListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picklistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilityTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMelonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picklistDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPickList
            // 
            this.lblPickList.AutoSize = true;
            this.lblPickList.Location = new System.Drawing.Point(27, 27);
            this.lblPickList.Name = "lblPickList";
            this.lblPickList.Size = new System.Drawing.Size(143, 13);
            this.lblPickList.TabIndex = 0;
            this.lblPickList.Text = "Please choose a picklist item";
            // 
            // cboSelectFruit
            // 
            this.cboSelectFruit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectFruit.FormattingEnabled = true;
            this.cboSelectFruit.Location = new System.Drawing.Point(176, 24);
            this.cboSelectFruit.Name = "cboSelectFruit";
            this.cboSelectFruit.Size = new System.Drawing.Size(207, 21);
            this.cboSelectFruit.TabIndex = 1;
            this.cboSelectFruit.SelectionChangeCommitted += new System.EventHandler(this.cboSelectFruit_Select);
            // 
            // lblPickListValue
            // 
            this.lblPickListValue.AutoSize = true;
            this.lblPickListValue.Location = new System.Drawing.Point(27, 311);
            this.lblPickListValue.Name = "lblPickListValue";
            this.lblPickListValue.Size = new System.Drawing.Size(75, 13);
            this.lblPickListValue.TabIndex = 2;
            this.lblPickListValue.Text = "Combo choice";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(810, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblPickListDescription
            // 
            this.lblPickListDescription.AutoSize = true;
            this.lblPickListDescription.Location = new System.Drawing.Point(27, 334);
            this.lblPickListDescription.Name = "lblPickListDescription";
            this.lblPickListDescription.Size = new System.Drawing.Size(96, 13);
            this.lblPickListDescription.TabIndex = 4;
            this.lblPickListDescription.Text = "Combo Description";
            // 
            // tblPickListBindingSource
            // 
            this.tblPickListBindingSource.DataMember = "tblPickList";
            this.tblPickListBindingSource.DataSource = this.picklistDataSet;
            // 
            // picklistDataSet
            // 
            this.picklistDataSet.DataSetName = "PicklistDataSet";
            this.picklistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPickListTableAdapter
            // 
            this.tblPickListTableAdapter.ClearBeforeFill = true;
            // 
            // lblPickListFileName
            // 
            this.lblPickListFileName.AutoSize = true;
            this.lblPickListFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPickListBindingSource, "dbPickListFileName", true));
            this.lblPickListFileName.Location = new System.Drawing.Point(27, 361);
            this.lblPickListFileName.Name = "lblPickListFileName";
            this.lblPickListFileName.Size = new System.Drawing.Size(125, 13);
            this.lblPickListFileName.TabIndex = 5;
            this.lblPickListFileName.Text = "New Table to be opened";
            // 
            // dgvUtilityTable
            // 
            this.dgvUtilityTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilityTable.Location = new System.Drawing.Point(453, 24);
            this.dgvUtilityTable.Name = "dgvUtilityTable";
            this.dgvUtilityTable.Size = new System.Drawing.Size(432, 344);
            this.dgvUtilityTable.TabIndex = 6;
            // 
            // tblMelonBindingSource
            // 
            this.tblMelonBindingSource.DataMember = "tblMelon";
            this.tblMelonBindingSource.DataSource = this.picklistDataSet1;
            // 
            // picklistDataSet1
            // 
            this.picklistDataSet1.DataSetName = "PicklistDataSet1";
            this.picklistDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMelonTableAdapter
            // 
            this.tblMelonTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 425);
            this.Controls.Add(this.dgvUtilityTable);
            this.Controls.Add(this.lblPickListFileName);
            this.Controls.Add(this.lblPickListDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPickListValue);
            this.Controls.Add(this.cboSelectFruit);
            this.Controls.Add(this.lblPickList);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPickListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picklistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilityTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMelonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picklistDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPickList;
        private System.Windows.Forms.ComboBox cboSelectFruit;
        private System.Windows.Forms.Label lblPickListValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPickListDescription;
        private PicklistDataSet picklistDataSet;
        private System.Windows.Forms.BindingSource tblPickListBindingSource;
        private PicklistDataSetTableAdapters.tblPickListTableAdapter tblPickListTableAdapter;
        private System.Windows.Forms.Label lblPickListFileName;
        private System.Windows.Forms.DataGridView dgvUtilityTable;
        private PicklistDataSet1 picklistDataSet1;
        private System.Windows.Forms.BindingSource tblMelonBindingSource;
        private PicklistDataSet1TableAdapters.tblMelonTableAdapter tblMelonTableAdapter;
    }
}

