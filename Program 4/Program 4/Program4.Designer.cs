namespace Program_4
{
    partial class Program4
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
            this.originZipLabel = new System.Windows.Forms.Label();
            this.destinationZipLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.destinZipTextBox = new System.Windows.Forms.TextBox();
            this.originZipTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.packageInfoLabel = new System.Windows.Forms.Label();
            this.packageListbox = new System.Windows.Forms.ListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.fromButton = new System.Windows.Forms.Button();
            this.toButton = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // originZipLabel
            // 
            this.originZipLabel.AutoSize = true;
            this.originZipLabel.Location = new System.Drawing.Point(3, 39);
            this.originZipLabel.Name = "originZipLabel";
            this.originZipLabel.Size = new System.Drawing.Size(55, 13);
            this.originZipLabel.TabIndex = 0;
            this.originZipLabel.Text = "Origin Zip:";
            // 
            // destinationZipLabel
            // 
            this.destinationZipLabel.AutoSize = true;
            this.destinationZipLabel.Location = new System.Drawing.Point(0, 71);
            this.destinationZipLabel.Name = "destinationZipLabel";
            this.destinationZipLabel.Size = new System.Drawing.Size(81, 13);
            this.destinationZipLabel.TabIndex = 1;
            this.destinationZipLabel.Text = "Destination Zip:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(3, 101);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Length:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(3, 127);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(0, 154);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(43, 98);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(68, 20);
            this.lengthTextBox.TabIndex = 5;
            // 
            // destinZipTextBox
            // 
            this.destinZipTextBox.Location = new System.Drawing.Point(87, 71);
            this.destinZipTextBox.Name = "destinZipTextBox";
            this.destinZipTextBox.Size = new System.Drawing.Size(50, 20);
            this.destinZipTextBox.TabIndex = 6;
            // 
            // originZipTextBox
            // 
            this.originZipTextBox.Location = new System.Drawing.Point(55, 36);
            this.originZipTextBox.Name = "originZipTextBox";
            this.originZipTextBox.Size = new System.Drawing.Size(56, 20);
            this.originZipTextBox.TabIndex = 7;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(43, 125);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(68, 20);
            this.widthTextBox.TabIndex = 8;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(43, 151);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(68, 20);
            this.heightTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 198);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add Package";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // packageInfoLabel
            // 
            this.packageInfoLabel.AutoSize = true;
            this.packageInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.packageInfoLabel.Location = new System.Drawing.Point(6, 9);
            this.packageInfoLabel.Name = "packageInfoLabel";
            this.packageInfoLabel.Size = new System.Drawing.Size(107, 15);
            this.packageInfoLabel.TabIndex = 11;
            this.packageInfoLabel.Text = "Package Information";
            // 
            // packageListbox
            // 
            this.packageListbox.FormattingEnabled = true;
            this.packageListbox.Location = new System.Drawing.Point(143, 11);
            this.packageListbox.Name = "packageListbox";
            this.packageListbox.Size = new System.Drawing.Size(137, 108);
            this.packageListbox.TabIndex = 12;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(143, 127);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(137, 23);
            this.detailsButton.TabIndex = 13;
            this.detailsButton.Text = "Package Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // fromButton
            // 
            this.fromButton.Location = new System.Drawing.Point(143, 164);
            this.fromButton.Name = "fromButton";
            this.fromButton.Size = new System.Drawing.Size(137, 23);
            this.fromButton.TabIndex = 14;
            this.fromButton.Text = "Send from UofL";
            this.fromButton.UseVisualStyleBackColor = true;
            this.fromButton.Click += new System.EventHandler(this.fromButton_Click);
            // 
            // toButton
            // 
            this.toButton.Location = new System.Drawing.Point(143, 198);
            this.toButton.Name = "toButton";
            this.toButton.Size = new System.Drawing.Size(137, 23);
            this.toButton.TabIndex = 15;
            this.toButton.Text = "Send to UofL";
            this.toButton.UseVisualStyleBackColor = true;
            this.toButton.Click += new System.EventHandler(this.toButton_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(0, 174);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 16;
            this.weightLabel.Text = "Weight:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(43, 174);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(68, 20);
            this.weightTextBox.TabIndex = 17;
            // 
            // Program4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.toButton);
            this.Controls.Add(this.fromButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.packageListbox);
            this.Controls.Add(this.packageInfoLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.originZipTextBox);
            this.Controls.Add(this.destinZipTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destinationZipLabel);
            this.Controls.Add(this.originZipLabel);
            this.Name = "Program4";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originZipLabel;
        private System.Windows.Forms.Label destinationZipLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox destinZipTextBox;
        private System.Windows.Forms.TextBox originZipTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label packageInfoLabel;
        private System.Windows.Forms.ListBox packageListbox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button fromButton;
        private System.Windows.Forms.Button toButton;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
    }
}

