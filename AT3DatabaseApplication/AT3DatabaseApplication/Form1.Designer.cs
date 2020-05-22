namespace AT3DatabaseApplication
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.cbxSelectTable = new System.Windows.Forms.ComboBox();
            this.lblSelectTable = new System.Windows.Forms.Label();
            this.btnSelectTable = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.gbxTableControls = new System.Windows.Forms.GroupBox();
            this.btnQueryTableDefinition = new System.Windows.Forms.Button();
            this.btnCopyTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.gbxTransaction = new System.Windows.Forms.GroupBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gbxTableControls.SuspendLayout();
            this.gbxTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 281);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1162, 412);
            this.dataGridView.TabIndex = 0;
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSelected.Location = new System.Drawing.Point(698, 240);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(150, 35);
            this.btnUpdateSelected.TabIndex = 1;
            this.btnUpdateSelected.Text = "Update Selected";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // cbxSelectTable
            // 
            this.cbxSelectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectTable.FormattingEnabled = true;
            this.cbxSelectTable.Location = new System.Drawing.Point(12, 44);
            this.cbxSelectTable.Name = "cbxSelectTable";
            this.cbxSelectTable.Size = new System.Drawing.Size(203, 28);
            this.cbxSelectTable.TabIndex = 2;
            // 
            // lblSelectTable
            // 
            this.lblSelectTable.AutoSize = true;
            this.lblSelectTable.Location = new System.Drawing.Point(13, 25);
            this.lblSelectTable.Name = "lblSelectTable";
            this.lblSelectTable.Size = new System.Drawing.Size(70, 13);
            this.lblSelectTable.TabIndex = 3;
            this.lblSelectTable.Text = "Select Table:";
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTable.Location = new System.Drawing.Point(221, 40);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(100, 35);
            this.btnSelectTable.TabIndex = 4;
            this.btnSelectTable.Text = "Select";
            this.btnSelectTable.UseVisualStyleBackColor = true;
            this.btnSelectTable.Click += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1068, 240);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(379, 40);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(129, 35);
            this.btnAddRecord.TabIndex = 6;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(854, 240);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(208, 35);
            this.btnDeleteRecord.TabIndex = 7;
            this.btnDeleteRecord.Text = "Delete Selected Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // gbxTableControls
            // 
            this.gbxTableControls.Controls.Add(this.btnQueryTableDefinition);
            this.gbxTableControls.Controls.Add(this.btnCopyTable);
            this.gbxTableControls.Controls.Add(this.btnDeleteTable);
            this.gbxTableControls.Controls.Add(this.btnCreateTable);
            this.gbxTableControls.Location = new System.Drawing.Point(16, 78);
            this.gbxTableControls.Name = "gbxTableControls";
            this.gbxTableControls.Size = new System.Drawing.Size(154, 197);
            this.gbxTableControls.TabIndex = 8;
            this.gbxTableControls.TabStop = false;
            this.gbxTableControls.Text = "Tables";
            // 
            // btnQueryTableDefinition
            // 
            this.btnQueryTableDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueryTableDefinition.Location = new System.Drawing.Point(6, 140);
            this.btnQueryTableDefinition.Name = "btnQueryTableDefinition";
            this.btnQueryTableDefinition.Size = new System.Drawing.Size(130, 51);
            this.btnQueryTableDefinition.TabIndex = 3;
            this.btnQueryTableDefinition.Text = "Query Table Definition";
            this.btnQueryTableDefinition.UseVisualStyleBackColor = true;
            this.btnQueryTableDefinition.Click += new System.EventHandler(this.btnQueryTableDefinition_Click);
            // 
            // btnCopyTable
            // 
            this.btnCopyTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyTable.Location = new System.Drawing.Point(6, 101);
            this.btnCopyTable.Name = "btnCopyTable";
            this.btnCopyTable.Size = new System.Drawing.Size(130, 35);
            this.btnCopyTable.TabIndex = 2;
            this.btnCopyTable.Text = "Copy Table";
            this.btnCopyTable.UseVisualStyleBackColor = true;
            this.btnCopyTable.Click += new System.EventHandler(this.btnCopyTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTable.Location = new System.Drawing.Point(6, 60);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(130, 35);
            this.btnDeleteTable.TabIndex = 1;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTable.Location = new System.Drawing.Point(6, 19);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(130, 35);
            this.btnCreateTable.TabIndex = 0;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(1057, 9);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(117, 13);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "Ben Szekely 10042443";
            // 
            // gbxTransaction
            // 
            this.gbxTransaction.Controls.Add(this.btnTransaction);
            this.gbxTransaction.Location = new System.Drawing.Point(176, 78);
            this.gbxTransaction.Name = "gbxTransaction";
            this.gbxTransaction.Size = new System.Drawing.Size(145, 92);
            this.gbxTransaction.TabIndex = 10;
            this.gbxTransaction.TabStop = false;
            this.gbxTransaction.Text = "Transactions";
            // 
            // btnTransaction
            // 
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Location = new System.Drawing.Point(6, 19);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(130, 57);
            this.btnTransaction.TabIndex = 4;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 705);
            this.Controls.Add(this.gbxTransaction);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.gbxTableControls);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSelectTable);
            this.Controls.Add(this.lblSelectTable);
            this.Controls.Add(this.cbxSelectTable);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "AT3 Database Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gbxTableControls.ResumeLayout(false);
            this.gbxTransaction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.ComboBox cbxSelectTable;
        private System.Windows.Forms.Label lblSelectTable;
        private System.Windows.Forms.Button btnSelectTable;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.GroupBox gbxTableControls;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnCopyTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnQueryTableDefinition;
        private System.Windows.Forms.GroupBox gbxTransaction;
        private System.Windows.Forms.Button btnTransaction;
    }
}

