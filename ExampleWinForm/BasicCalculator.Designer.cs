namespace ExampleWinForm
{
    partial class BasicCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SubstractButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(20, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Location = new System.Drawing.Point(17, 27);
            this.CalculationResultText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(338, 20);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Please enter an equation and press enter or = ";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.EqualsButton, 3, 4);
            this.ButtonsPanel.Controls.Add(this.PointButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonsPanel.Controls.Add(this.AddButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonsPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonsPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.SubstractButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonsPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonsPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonsPanel.Controls.Add(this.MultButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonsPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonsPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsPanel.Controls.Add(this.PercentButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.CButton, 1, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(20, 49);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(360, 336);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(84, 61);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(93, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(84, 61);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(183, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(84, 61);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            // 
            // PercentButton
            // 
            this.PercentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentButton.Location = new System.Drawing.Point(273, 3);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(84, 61);
            this.PercentButton.TabIndex = 3;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = true;
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 70);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(84, 61);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(93, 70);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(84, 61);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Location = new System.Drawing.Point(183, 70);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(84, 61);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            // 
            // MultButton
            // 
            this.MultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultButton.Location = new System.Drawing.Point(273, 70);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(84, 61);
            this.MultButton.TabIndex = 7;
            this.MultButton.Text = "X";
            this.MultButton.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 137);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(84, 61);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(93, 137);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(84, 61);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(183, 137);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(84, 61);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            // 
            // SubstractButton
            // 
            this.SubstractButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubstractButton.Location = new System.Drawing.Point(273, 137);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(84, 61);
            this.SubstractButton.TabIndex = 11;
            this.SubstractButton.Text = "-";
            this.SubstractButton.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 204);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(84, 61);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(93, 204);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(84, 61);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(183, 204);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(84, 61);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(273, 204);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 61);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(93, 271);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(84, 62);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            // 
            // PointButton
            // 
            this.PointButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointButton.Location = new System.Drawing.Point(183, 271);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(84, 62);
            this.PointButton.TabIndex = 18;
            this.PointButton.Text = ".";
            this.PointButton.UseVisualStyleBackColor = true;
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Location = new System.Drawing.Point(273, 271);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(84, 62);
            this.EqualsButton.TabIndex = 19;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            // 
            // BasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 404);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BasicCalculator";
            this.Text = "Form1";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SubstractButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button PercentButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button CButton;
    }
}

