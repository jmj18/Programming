namespace LibraryItems
{
    partial class EditBook
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
            this.editBookComboBox = new System.Windows.Forms.ComboBox();
            this.editBookLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editBookComboBox
            // 
            this.editBookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editBookComboBox.FormattingEnabled = true;
            this.editBookComboBox.Location = new System.Drawing.Point(211, 40);
            this.editBookComboBox.Name = "editBookComboBox";
            this.editBookComboBox.Size = new System.Drawing.Size(196, 21);
            this.editBookComboBox.TabIndex = 0;
            // 
            // editBookLabel
            // 
            this.editBookLabel.AutoSize = true;
            this.editBookLabel.Location = new System.Drawing.Point(12, 43);
            this.editBookLabel.Name = "editBookLabel";
            this.editBookLabel.Size = new System.Drawing.Size(193, 13);
            this.editBookLabel.TabIndex = 1;
            this.editBookLabel.Text = "Choose the book you would like to edit:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(109, 76);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(211, 76);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 111);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.editBookLabel);
            this.Controls.Add(this.editBookComboBox);
            this.Name = "EditBook";
            this.Text = "EditBook";
            this.Load += new System.EventHandler(this.EditBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox editBookComboBox;
        private System.Windows.Forms.Label editBookLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}