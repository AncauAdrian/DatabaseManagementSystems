namespace Lab1Forms
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
            this.personDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.personLabel = new System.Windows.Forms.Label();
            this.vehicleDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // personDataGrid
            // 
            this.personDataGrid.AllowUserToAddRows = false;
            this.personDataGrid.AllowUserToDeleteRows = false;
            this.personDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGrid.Location = new System.Drawing.Point(12, 30);
            this.personDataGrid.Name = "personDataGrid";
            this.personDataGrid.ReadOnly = true;
            this.personDataGrid.Size = new System.Drawing.Size(568, 201);
            this.personDataGrid.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(630, 107);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(150, 45);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // personLabel
            // 
            this.personLabel.AutoSize = true;
            this.personLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personLabel.Location = new System.Drawing.Point(23, 9);
            this.personLabel.Name = "personLabel";
            this.personLabel.Size = new System.Drawing.Size(68, 18);
            this.personLabel.TabIndex = 2;
            this.personLabel.Text = "Persons:";
            // 
            // vehicleDataGrid
            // 
            this.vehicleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGrid.Location = new System.Drawing.Point(12, 311);
            this.vehicleDataGrid.Name = "vehicleDataGrid";
            this.vehicleDataGrid.Size = new System.Drawing.Size(568, 187);
            this.vehicleDataGrid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vehicles:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(630, 397);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 45);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 510);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleDataGrid);
            this.Controls.Add(this.personLabel);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.personDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personDataGrid;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label personLabel;
        private System.Windows.Forms.DataGridView vehicleDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

