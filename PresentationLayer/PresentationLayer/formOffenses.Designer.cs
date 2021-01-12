namespace PresentationLayer
{
    partial class formOffenses
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPoliceman = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVehicle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.dataGridViewOffense = new System.Windows.Forms.DataGridView();
            this.dataGridViewPolicemen = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicemen)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 31);
            this.label6.TabIndex = 34;
            this.label6.Text = "Vozila";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 31);
            this.label5.TabIndex = 33;
            this.label5.Text = "Policajci";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Prekršaji";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPoliceman
            // 
            this.textBoxPoliceman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPoliceman.Location = new System.Drawing.Point(427, 433);
            this.textBoxPoliceman.Name = "textBoxPoliceman";
            this.textBoxPoliceman.Size = new System.Drawing.Size(207, 29);
            this.textBoxPoliceman.TabIndex = 3;
            this.textBoxPoliceman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID Policajca";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxVehicle
            // 
            this.textBoxVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicle.Location = new System.Drawing.Point(427, 352);
            this.textBoxVehicle.Name = "textBoxVehicle";
            this.textBoxVehicle.Size = new System.Drawing.Size(207, 29);
            this.textBoxVehicle.TabIndex = 2;
            this.textBoxVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID Vozila";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Datum prekršaja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.AllowUserToAddRows = false;
            this.dataGridViewVehicles.AllowUserToDeleteRows = false;
            this.dataGridViewVehicles.AllowUserToResizeColumns = false;
            this.dataGridViewVehicles.AllowUserToResizeRows = false;
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(458, 48);
            this.dataGridViewVehicles.MultiSelect = false;
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.ReadOnly = true;
            this.dataGridViewVehicles.RowHeadersVisible = false;
            this.dataGridViewVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVehicles.Size = new System.Drawing.Size(411, 169);
            this.dataGridViewVehicles.TabIndex = 25;
            this.dataGridViewVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVehicles_CellClick);
            // 
            // dataGridViewOffense
            // 
            this.dataGridViewOffense.AllowUserToAddRows = false;
            this.dataGridViewOffense.AllowUserToDeleteRows = false;
            this.dataGridViewOffense.AllowUserToResizeColumns = false;
            this.dataGridViewOffense.AllowUserToResizeRows = false;
            this.dataGridViewOffense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffense.Location = new System.Drawing.Point(12, 262);
            this.dataGridViewOffense.MultiSelect = false;
            this.dataGridViewOffense.Name = "dataGridViewOffense";
            this.dataGridViewOffense.ReadOnly = true;
            this.dataGridViewOffense.RowHeadersVisible = false;
            this.dataGridViewOffense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOffense.Size = new System.Drawing.Size(380, 206);
            this.dataGridViewOffense.TabIndex = 24;
            this.dataGridViewOffense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOffense_CellClick);
            // 
            // dataGridViewPolicemen
            // 
            this.dataGridViewPolicemen.AllowUserToAddRows = false;
            this.dataGridViewPolicemen.AllowUserToDeleteRows = false;
            this.dataGridViewPolicemen.AllowUserToResizeColumns = false;
            this.dataGridViewPolicemen.AllowUserToResizeRows = false;
            this.dataGridViewPolicemen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolicemen.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewPolicemen.MultiSelect = false;
            this.dataGridViewPolicemen.Name = "dataGridViewPolicemen";
            this.dataGridViewPolicemen.ReadOnly = true;
            this.dataGridViewPolicemen.RowHeadersVisible = false;
            this.dataGridViewPolicemen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPolicemen.Size = new System.Drawing.Size(414, 169);
            this.dataGridViewPolicemen.TabIndex = 23;
            this.dataGridViewPolicemen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPolicemen_CellClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(686, 331);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(190, 50);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(11)))), ((int)(((byte)(238)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(686, 244);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(190, 50);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Firebrick;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(686, 412);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(190, 50);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Nazad";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(407, 285);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker.TabIndex = 1;
            // 
            // formOffenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(903, 480);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPoliceman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVehicle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVehicles);
            this.Controls.Add(this.dataGridViewOffense);
            this.Controls.Add(this.dataGridViewPolicemen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formOffenses";
            this.Text = "Prekrsaj";
            this.Load += new System.EventHandler(this.formOffenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicemen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPoliceman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.DataGridView dataGridViewOffense;
        private System.Windows.Forms.DataGridView dataGridViewPolicemen;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}