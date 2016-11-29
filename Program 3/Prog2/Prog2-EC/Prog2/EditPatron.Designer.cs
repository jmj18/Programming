namespace LibraryItems
{
    partial class EditPatron
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
            this.editPatronComboBox = new System.Windows.Forms.ComboBox();
            this.editPatronLabel = new System.Windows.Forms.Label();
            this.editPatronButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editPatronComboBox
            // 
            this.editPatronComboBox.FormattingEnabled = true;
            this.editPatronComboBox.Location = new System.Drawing.Point(212, 25);
            this.editPatronComboBox.Name = "editPatronComboBox";
            this.editPatronComboBox.Size = new System.Drawing.Size(121, 21);
            this.editPatronComboBox.TabIndex = 0;
            // 
            // editPatronLabel
            // 
            this.editPatronLabel.AutoSize = true;
            this.editPatronLabel.Location = new System.Drawing.Point(12, 28);
            this.editPatronLabel.Name = "editPatronLabel";
            this.editPatronLabel.Size = new System.Drawing.Size(194, 13);
            this.editPatronLabel.TabIndex = 1;
            this.editPatronLabel.Text = "Select the Patron you would like to edit:";
            // 
            // editPatronButton
            // 
            this.editPatronButton.Location = new System.Drawing.Point(105, 59);
            this.editPatronButton.Name = "editPatronButton";
            this.editPatronButton.Size = new System.Drawing.Size(75, 23);
            this.editPatronButton.TabIndex = 2;
            this.editPatronButton.Text = "OK";
            this.editPatronButton.UseVisualStyleBackColor = true;
            this.editPatronButton.Click += new System.EventHandler(this.editPatronButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(212, 59);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 94);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editPatronButton);
            this.Controls.Add(this.editPatronLabel);
            this.Controls.Add(this.editPatronComboBox);
            this.Name = "EditPatron";
            this.Text = "EditPatron";
            this.Load += new System.EventHandler(this.EditPatron_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox editPatronComboBox;
        private System.Windows.Forms.Label editPatronLabel;
        private System.Windows.Forms.Button editPatronButton;
        private System.Windows.Forms.Button cancelButton;
    }
}