namespace WindowsFormsApplication1
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
            this.ActinicBox = new System.Windows.Forms.GroupBox();
            this.ActinicTextBox = new System.Windows.Forms.RichTextBox();
            this.ActinicPictureBox = new System.Windows.Forms.PictureBox();
            this.SageBox = new System.Windows.Forms.GroupBox();
            this.SageTextBox = new System.Windows.Forms.RichTextBox();
            this.SagePictureBox = new System.Windows.Forms.PictureBox();
            this.UpdatedProductsGrid = new System.Windows.Forms.DataGridView();
            this.ReadButton = new System.Windows.Forms.Button();
            this.ProductBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ActinicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActinicPictureBox)).BeginInit();
            this.SageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatedProductsGrid)).BeginInit();
            this.ProductBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActinicBox
            // 
            this.ActinicBox.Controls.Add(this.ActinicTextBox);
            this.ActinicBox.Controls.Add(this.ActinicPictureBox);
            this.ActinicBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ActinicBox.Location = new System.Drawing.Point(12, 12);
            this.ActinicBox.Name = "ActinicBox";
            this.ActinicBox.Size = new System.Drawing.Size(200, 89);
            this.ActinicBox.TabIndex = 0;
            this.ActinicBox.TabStop = false;
            this.ActinicBox.Text = "Actinic Stock Levels (.csv)";
            // 
            // ActinicTextBox
            // 
            this.ActinicTextBox.AutoWordSelection = true;
            this.ActinicTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ActinicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActinicTextBox.Location = new System.Drawing.Point(86, 19);
            this.ActinicTextBox.Name = "ActinicTextBox";
            this.ActinicTextBox.ReadOnly = true;
            this.ActinicTextBox.ShowSelectionMargin = true;
            this.ActinicTextBox.Size = new System.Drawing.Size(108, 64);
            this.ActinicTextBox.TabIndex = 1;
            this.ActinicTextBox.Text = "";
            // 
            // ActinicPictureBox
            // 
            this.ActinicPictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ActinicPictureBox.Location = new System.Drawing.Point(6, 19);
            this.ActinicPictureBox.Name = "ActinicPictureBox";
            this.ActinicPictureBox.Size = new System.Drawing.Size(64, 64);
            this.ActinicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ActinicPictureBox.TabIndex = 1;
            this.ActinicPictureBox.TabStop = false;
            this.ActinicPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ActinicPictureBox_DragDrop);
            this.ActinicPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ActinicPictureBox_DragEnter);
            // 
            // SageBox
            // 
            this.SageBox.Controls.Add(this.SageTextBox);
            this.SageBox.Controls.Add(this.SagePictureBox);
            this.SageBox.ForeColor = System.Drawing.Color.Green;
            this.SageBox.Location = new System.Drawing.Point(233, 12);
            this.SageBox.Name = "SageBox";
            this.SageBox.Size = new System.Drawing.Size(200, 89);
            this.SageBox.TabIndex = 1;
            this.SageBox.TabStop = false;
            this.SageBox.Text = "Sage Stock Levels (.xls)";
            // 
            // SageTextBox
            // 
            this.SageTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SageTextBox.Location = new System.Drawing.Point(86, 19);
            this.SageTextBox.Name = "SageTextBox";
            this.SageTextBox.ReadOnly = true;
            this.SageTextBox.Size = new System.Drawing.Size(108, 64);
            this.SageTextBox.TabIndex = 3;
            this.SageTextBox.Text = "";
            // 
            // SagePictureBox
            // 
            this.SagePictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SagePictureBox.Location = new System.Drawing.Point(6, 19);
            this.SagePictureBox.Name = "SagePictureBox";
            this.SagePictureBox.Size = new System.Drawing.Size(64, 64);
            this.SagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SagePictureBox.TabIndex = 2;
            this.SagePictureBox.TabStop = false;
            this.SagePictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SagePictureBox_DragDrop);
            this.SagePictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.SagePictureBox_DragEnter);
            // 
            // UpdatedProductsGrid
            // 
            this.UpdatedProductsGrid.AllowUserToAddRows = false;
            this.UpdatedProductsGrid.AllowUserToDeleteRows = false;
            this.UpdatedProductsGrid.AllowUserToResizeColumns = false;
            this.UpdatedProductsGrid.AllowUserToResizeRows = false;
            this.UpdatedProductsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UpdatedProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdatedProductsGrid.Location = new System.Drawing.Point(7, 19);
            this.UpdatedProductsGrid.Name = "UpdatedProductsGrid";
            this.UpdatedProductsGrid.ReadOnly = true;
            this.UpdatedProductsGrid.RowHeadersVisible = false;
            this.UpdatedProductsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UpdatedProductsGrid.Size = new System.Drawing.Size(268, 168);
            this.UpdatedProductsGrid.TabIndex = 2;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(281, 19);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(134, 23);
            this.ReadButton.TabIndex = 3;
            this.ReadButton.Text = "Read New Stock Levels";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // ProductBox
            // 
            this.ProductBox.Controls.Add(this.SaveButton);
            this.ProductBox.Controls.Add(this.TextBox);
            this.ProductBox.Controls.Add(this.UpdatedProductsGrid);
            this.ProductBox.Controls.Add(this.ReadButton);
            this.ProductBox.Location = new System.Drawing.Point(12, 127);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(421, 193);
            this.ProductBox.TabIndex = 4;
            this.ProductBox.TabStop = false;
            this.ProductBox.Text = "Updated Products";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(281, 159);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(134, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save To Desktop";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Location = new System.Drawing.Point(281, 48);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(134, 105);
            this.TextBox.TabIndex = 5;
            this.TextBox.Text = "";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 328);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.SageBox);
            this.Controls.Add(this.ActinicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Stock Uploader";
            this.ActinicBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActinicPictureBox)).EndInit();
            this.SageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatedProductsGrid)).EndInit();
            this.ProductBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ActinicBox;
        private System.Windows.Forms.PictureBox ActinicPictureBox;
        private System.Windows.Forms.RichTextBox ActinicTextBox;
        private System.Windows.Forms.GroupBox SageBox;
        private System.Windows.Forms.PictureBox SagePictureBox;
        private System.Windows.Forms.RichTextBox SageTextBox;
        private System.Windows.Forms.DataGridView UpdatedProductsGrid;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.GroupBox ProductBox;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button SaveButton;

    }
}

