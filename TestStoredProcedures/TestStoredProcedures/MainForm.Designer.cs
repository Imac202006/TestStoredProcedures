using System.Windows.Forms;

namespace TestStoredProcedures
{
    partial class MainForm
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
            this.BrandTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ManufactureDtPicker = new System.Windows.Forms.DateTimePicker();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ErrorMsgTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearErrMsgBtn = new System.Windows.Forms.Button();
            this.DataGVCar = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVCar)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandTxtBox
            // 
            this.BrandTxtBox.Location = new System.Drawing.Point(113, 15);
            this.BrandTxtBox.Name = "BrandTxtBox";
            this.BrandTxtBox.Size = new System.Drawing.Size(200, 20);
            this.BrandTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(113, 41);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(200, 20);
            this.NameTxtBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manufacture Date";
            // 
            // ManufactureDtPicker
            // 
            this.ManufactureDtPicker.Location = new System.Drawing.Point(113, 67);
            this.ManufactureDtPicker.Name = "ManufactureDtPicker";
            this.ManufactureDtPicker.Size = new System.Drawing.Size(200, 20);
            this.ManufactureDtPicker.TabIndex = 5;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(265, 93);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(48, 23);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(174, 93);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ErrorMsgTxtBox
            // 
            this.ErrorMsgTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorMsgTxtBox.Location = new System.Drawing.Point(332, 31);
            this.ErrorMsgTxtBox.Multiline = true;
            this.ErrorMsgTxtBox.Name = "ErrorMsgTxtBox";
            this.ErrorMsgTxtBox.ReadOnly = true;
            this.ErrorMsgTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorMsgTxtBox.Size = new System.Drawing.Size(382, 56);
            this.ErrorMsgTxtBox.TabIndex = 8;
            this.ErrorMsgTxtBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Error Message";
            // 
            // ClearErrMsgBtn
            // 
            this.ClearErrMsgBtn.Location = new System.Drawing.Point(591, 93);
            this.ClearErrMsgBtn.Name = "ClearErrMsgBtn";
            this.ClearErrMsgBtn.Size = new System.Drawing.Size(123, 23);
            this.ClearErrMsgBtn.TabIndex = 10;
            this.ClearErrMsgBtn.Text = "Clear Error Message";
            this.ClearErrMsgBtn.UseVisualStyleBackColor = true;
            this.ClearErrMsgBtn.Click += new System.EventHandler(this.ClearErrMsgBtn_Click);
            // 
            // DataGVCar
            // 
            this.DataGVCar.AllowUserToAddRows = false;
            this.DataGVCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVCar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGVCar.Location = new System.Drawing.Point(12, 122);
            this.DataGVCar.MultiSelect = false;
            this.DataGVCar.Name = "DataGVCar";
            this.DataGVCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGVCar.Size = new System.Drawing.Size(702, 404);
            this.DataGVCar.TabIndex = 11;
            this.DataGVCar.CellClick += this.DataGVCar_SelectionChanged;
            this.DataGVCar.ReadOnly = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(93, 93);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 12;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(12, 93);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 538);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DataGVCar);
            this.Controls.Add(this.ClearErrMsgBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ErrorMsgTxtBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ManufactureDtPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrandTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGVCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox BrandTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ManufactureDtPicker;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox ErrorMsgTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearErrMsgBtn;
        private System.Windows.Forms.DataGridView DataGVCar;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

