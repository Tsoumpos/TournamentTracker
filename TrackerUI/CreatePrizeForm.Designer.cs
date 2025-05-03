namespace TrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            createPrizeLabel.ForeColor = Color.FromArgb(21, 153, 255);
            createPrizeLabel.Location = new Point(12, 9);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(209, 50);
            createPrizeLabel.TabIndex = 12;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(228, 88);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(194, 35);
            placeNumberValue.TabIndex = 14;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(13, 88);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 13;
            placeNumberLabel.Text = "Place Number";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(228, 192);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(194, 35);
            prizeAmountValue.TabIndex = 16;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            prizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            prizeAmountLabel.Location = new Point(13, 192);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(176, 37);
            prizeAmountLabel.TabIndex = 15;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(228, 140);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(194, 35);
            placeNameValue.TabIndex = 18;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(13, 140);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 17;
            placeNameLabel.Text = "Place Name";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(228, 320);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(194, 35);
            prizePercentageValue.TabIndex = 20;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            prizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePercentageLabel.Location = new Point(13, 320);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(212, 37);
            prizePercentageLabel.TabIndex = 19;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(183, 261);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(64, 37);
            orLabel.TabIndex = 21;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(139, 403);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(211, 66);
            createPrizeButton.TabIndex = 22;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(470, 522);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}