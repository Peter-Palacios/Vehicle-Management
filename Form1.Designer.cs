
namespace Assignment6._2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CarGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblVin = new System.Windows.Forms.Label();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboMake = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarGrid
            // 
            this.CarGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.CarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGrid.GridColor = System.Drawing.Color.Firebrick;
            this.CarGrid.Location = new System.Drawing.Point(130, 29);
            this.CarGrid.Name = "CarGrid";
            this.CarGrid.Size = new System.Drawing.Size(600, 219);
            this.CarGrid.TabIndex = 0;
            this.CarGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarGrid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.comboMake);
            this.groupBox1.Controls.Add(this.DateTimePickerYear);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.lblMake);
            this.groupBox1.Controls.Add(this.lblVin);
            this.groupBox1.Controls.Add(this.txtVin);
            this.groupBox1.Location = new System.Drawing.Point(0, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Info";
            // 
            // DateTimePickerYear
            // 
            this.DateTimePickerYear.Location = new System.Drawing.Point(194, 165);
            this.DateTimePickerYear.Name = "DateTimePickerYear";
            this.DateTimePickerYear.Size = new System.Drawing.Size(111, 20);
            this.DateTimePickerYear.TabIndex = 7;
            this.DateTimePickerYear.Value = new System.DateTime(2022, 2, 16, 14, 46, 23, 0);
            this.DateTimePickerYear.Validating += new System.ComponentModel.CancelEventHandler(this.DateTimePickerYear_Validating);
            this.DateTimePickerYear.Validated += new System.EventHandler(this.DateTimePickerYear_Validated);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(194, 200);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(194, 124);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(111, 20);
            this.txtModel.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Forte", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(75, 207);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 14);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Forte", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(75, 171);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 14);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Forte", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(75, 124);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 14);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model";
            this.lblModel.Click += new System.EventHandler(this.lblModel_Click);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Forte", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(75, 82);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(45, 14);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Font = new System.Drawing.Font("Forte", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVin.Location = new System.Drawing.Point(75, 43);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(35, 14);
            this.lblVin.TabIndex = 1;
            this.lblVin.Text = "VIN";
            this.lblVin.Click += new System.EventHandler(this.lblVin_Click);
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(194, 37);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(111, 20);
            this.txtVin.TabIndex = 0;
            this.txtVin.Validating += new System.ComponentModel.CancelEventHandler(this.txtVin_Validating);
            this.txtVin.Validated += new System.EventHandler(this.txtVin_Validated);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(397, 442);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New Car";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(397, 500);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 38);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Record";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(587, 442);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(72, 38);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select to Update";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(587, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(495, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboMake
            // 
            this.comboMake.FormattingEnabled = true;
            this.comboMake.Location = new System.Drawing.Point(194, 79);
            this.comboMake.Name = "comboMake";
            this.comboMake.Size = new System.Drawing.Size(111, 21);
            this.comboMake.TabIndex = 7;
            this.comboMake.SelectedIndexChanged += new System.EventHandler(this.comboMake_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(924, 550);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CarGrid);
            this.Name = "Form1";
            this.Text = "Vehicle Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CarGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker DateTimePickerYear;
        private System.Windows.Forms.ComboBox comboMake;
    }
}

