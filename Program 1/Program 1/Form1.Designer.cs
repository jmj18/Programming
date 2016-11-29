namespace Program_1
{
    partial class program1
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
            this.squareFeetLabel = new System.Windows.Forms.Label();
            this.squareFeetTextbox = new System.Windows.Forms.TextBox();
            this.desiredCoatsLabel = new System.Windows.Forms.Label();
            this.desiredCoatsTextbox = new System.Windows.Forms.TextBox();
            this.pricePerGallonLabel = new System.Windows.Forms.Label();
            this.pricePerGallonTextbox = new System.Windows.Forms.TextBox();
            this.totalSquareFeetLabel = new System.Windows.Forms.Label();
            this.totalSqFtOutputLabel = new System.Windows.Forms.Label();
            this.gallonsRequiredLabel = new System.Windows.Forms.Label();
            this.gallonsRequiredOutputLabel = new System.Windows.Forms.Label();
            this.hoursRequiredLabel = new System.Windows.Forms.Label();
            this.hourRequiredOutputLabel = new System.Windows.Forms.Label();
            this.costOfPaintLabel = new System.Windows.Forms.Label();
            this.costOfPaintOutputLabel = new System.Windows.Forms.Label();
            this.costOfLaborLabel = new System.Windows.Forms.Label();
            this.costOfLaborOutputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // squareFeetLabel
            // 
            this.squareFeetLabel.AutoSize = true;
            this.squareFeetLabel.Location = new System.Drawing.Point(12, 20);
            this.squareFeetLabel.Name = "squareFeetLabel";
            this.squareFeetLabel.Size = new System.Drawing.Size(126, 13);
            this.squareFeetLabel.TabIndex = 0;
            this.squareFeetLabel.Text = "Square Ft of Wall Space:";
            // 
            // squareFeetTextbox
            // 
            this.squareFeetTextbox.Location = new System.Drawing.Point(144, 17);
            this.squareFeetTextbox.Name = "squareFeetTextbox";
            this.squareFeetTextbox.Size = new System.Drawing.Size(100, 20);
            this.squareFeetTextbox.TabIndex = 1;
            // 
            // desiredCoatsLabel
            // 
            this.desiredCoatsLabel.AutoSize = true;
            this.desiredCoatsLabel.Location = new System.Drawing.Point(23, 47);
            this.desiredCoatsLabel.Name = "desiredCoatsLabel";
            this.desiredCoatsLabel.Size = new System.Drawing.Size(115, 13);
            this.desiredCoatsLabel.TabIndex = 2;
            this.desiredCoatsLabel.Text = "Desired Coats of Paint:";
            // 
            // desiredCoatsTextbox
            // 
            this.desiredCoatsTextbox.Location = new System.Drawing.Point(144, 44);
            this.desiredCoatsTextbox.Name = "desiredCoatsTextbox";
            this.desiredCoatsTextbox.Size = new System.Drawing.Size(100, 20);
            this.desiredCoatsTextbox.TabIndex = 3;
            // 
            // pricePerGallonLabel
            // 
            this.pricePerGallonLabel.AutoSize = true;
            this.pricePerGallonLabel.Location = new System.Drawing.Point(13, 74);
            this.pricePerGallonLabel.Name = "pricePerGallonLabel";
            this.pricePerGallonLabel.Size = new System.Drawing.Size(125, 13);
            this.pricePerGallonLabel.TabIndex = 4;
            this.pricePerGallonLabel.Text = "Price Per Gallon of Paint:";
            // 
            // pricePerGallonTextbox
            // 
            this.pricePerGallonTextbox.Location = new System.Drawing.Point(144, 70);
            this.pricePerGallonTextbox.Name = "pricePerGallonTextbox";
            this.pricePerGallonTextbox.Size = new System.Drawing.Size(100, 20);
            this.pricePerGallonTextbox.TabIndex = 5;
            // 
            // totalSquareFeetLabel
            // 
            this.totalSquareFeetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSquareFeetLabel.Location = new System.Drawing.Point(72, 98);
            this.totalSquareFeetLabel.Name = "totalSquareFeetLabel";
            this.totalSquareFeetLabel.Size = new System.Drawing.Size(122, 18);
            this.totalSquareFeetLabel.TabIndex = 6;
            this.totalSquareFeetLabel.Text = "Total sq ft to be painted:";
            // 
            // totalSqFtOutputLabel
            // 
            this.totalSqFtOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqFtOutputLabel.Location = new System.Drawing.Point(200, 93);
            this.totalSqFtOutputLabel.Name = "totalSqFtOutputLabel";
            this.totalSqFtOutputLabel.Size = new System.Drawing.Size(61, 23);
            this.totalSqFtOutputLabel.TabIndex = 7;
            // 
            // gallonsRequiredLabel
            // 
            this.gallonsRequiredLabel.AutoSize = true;
            this.gallonsRequiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsRequiredLabel.Location = new System.Drawing.Point(12, 125);
            this.gallonsRequiredLabel.Name = "gallonsRequiredLabel";
            this.gallonsRequiredLabel.Size = new System.Drawing.Size(182, 13);
            this.gallonsRequiredLabel.TabIndex = 8;
            this.gallonsRequiredLabel.Text = "Number of Gallons of Paint Required:";
            // 
            // gallonsRequiredOutputLabel
            // 
            this.gallonsRequiredOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsRequiredOutputLabel.Location = new System.Drawing.Point(200, 124);
            this.gallonsRequiredOutputLabel.Name = "gallonsRequiredOutputLabel";
            this.gallonsRequiredOutputLabel.Size = new System.Drawing.Size(61, 24);
            this.gallonsRequiredOutputLabel.TabIndex = 9;
            // 
            // hoursRequiredLabel
            // 
            this.hoursRequiredLabel.AutoSize = true;
            this.hoursRequiredLabel.Location = new System.Drawing.Point(58, 151);
            this.hoursRequiredLabel.Name = "hoursRequiredLabel";
            this.hoursRequiredLabel.Size = new System.Drawing.Size(136, 13);
            this.hoursRequiredLabel.TabIndex = 10;
            this.hoursRequiredLabel.Text = "Number of Hours Required:";
            // 
            // hourRequiredOutputLabel
            // 
            this.hourRequiredOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hourRequiredOutputLabel.Location = new System.Drawing.Point(200, 151);
            this.hourRequiredOutputLabel.Name = "hourRequiredOutputLabel";
            this.hourRequiredOutputLabel.Size = new System.Drawing.Size(61, 23);
            this.hourRequiredOutputLabel.TabIndex = 11;
            // 
            // costOfPaintLabel
            // 
            this.costOfPaintLabel.AutoSize = true;
            this.costOfPaintLabel.Location = new System.Drawing.Point(0, 186);
            this.costOfPaintLabel.Name = "costOfPaintLabel";
            this.costOfPaintLabel.Size = new System.Drawing.Size(70, 13);
            this.costOfPaintLabel.TabIndex = 12;
            this.costOfPaintLabel.Text = "Cost of Paint:";
            // 
            // costOfPaintOutputLabel
            // 
            this.costOfPaintOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOfPaintOutputLabel.Location = new System.Drawing.Point(75, 186);
            this.costOfPaintOutputLabel.Name = "costOfPaintOutputLabel";
            this.costOfPaintOutputLabel.Size = new System.Drawing.Size(50, 23);
            this.costOfPaintOutputLabel.TabIndex = 13;
            // 
            // costOfLaborLabel
            // 
            this.costOfLaborLabel.AutoSize = true;
            this.costOfLaborLabel.Location = new System.Drawing.Point(131, 185);
            this.costOfLaborLabel.Name = "costOfLaborLabel";
            this.costOfLaborLabel.Size = new System.Drawing.Size(73, 13);
            this.costOfLaborLabel.TabIndex = 14;
            this.costOfLaborLabel.Text = "Cost of Labor:";
            // 
            // costOfLaborOutputLabel
            // 
            this.costOfLaborOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOfLaborOutputLabel.Location = new System.Drawing.Point(210, 186);
            this.costOfLaborOutputLabel.Name = "costOfLaborOutputLabel";
            this.costOfLaborOutputLabel.Size = new System.Drawing.Size(50, 23);
            this.costOfLaborOutputLabel.TabIndex = 15;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(103, 247);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 16;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(35, 222);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(90, 13);
            this.totalCostLabel.TabIndex = 17;
            this.totalCostLabel.Text = "Total Cost of Job:";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(131, 221);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostOutputLabel.TabIndex = 18;
            // 
            // program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.costOfLaborOutputLabel);
            this.Controls.Add(this.costOfLaborLabel);
            this.Controls.Add(this.costOfPaintOutputLabel);
            this.Controls.Add(this.costOfPaintLabel);
            this.Controls.Add(this.hourRequiredOutputLabel);
            this.Controls.Add(this.hoursRequiredLabel);
            this.Controls.Add(this.gallonsRequiredOutputLabel);
            this.Controls.Add(this.gallonsRequiredLabel);
            this.Controls.Add(this.totalSqFtOutputLabel);
            this.Controls.Add(this.totalSquareFeetLabel);
            this.Controls.Add(this.pricePerGallonTextbox);
            this.Controls.Add(this.pricePerGallonLabel);
            this.Controls.Add(this.desiredCoatsTextbox);
            this.Controls.Add(this.desiredCoatsLabel);
            this.Controls.Add(this.squareFeetTextbox);
            this.Controls.Add(this.squareFeetLabel);
            this.Name = "program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label squareFeetLabel;
        private System.Windows.Forms.TextBox squareFeetTextbox;
        private System.Windows.Forms.Label desiredCoatsLabel;
        private System.Windows.Forms.TextBox desiredCoatsTextbox;
        private System.Windows.Forms.Label pricePerGallonLabel;
        private System.Windows.Forms.TextBox pricePerGallonTextbox;
        private System.Windows.Forms.Label totalSquareFeetLabel;
        private System.Windows.Forms.Label totalSqFtOutputLabel;
        private System.Windows.Forms.Label gallonsRequiredLabel;
        private System.Windows.Forms.Label gallonsRequiredOutputLabel;
        private System.Windows.Forms.Label hoursRequiredLabel;
        private System.Windows.Forms.Label hourRequiredOutputLabel;
        private System.Windows.Forms.Label costOfPaintLabel;
        private System.Windows.Forms.Label costOfPaintOutputLabel;
        private System.Windows.Forms.Label costOfLaborLabel;
        private System.Windows.Forms.Label costOfLaborOutputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
    }
}

