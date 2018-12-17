namespace TriangularArray
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
            this.label1 = new System.Windows.Forms.Label();
            this.numRowsTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Rows:";
            // 
            // numRowsTextBox
            // 
            this.numRowsTextBox.Location = new System.Drawing.Point(65, 14);
            this.numRowsTextBox.Name = "numRowsTextBox";
            this.numRowsTextBox.Size = new System.Drawing.Size(55, 20);
            this.numRowsTextBox.TabIndex = 0;
            this.numRowsTextBox.Text = "4";
            this.numRowsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(171, 12);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = " Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // rowTextBox
            // 
            this.rowTextBox.Location = new System.Drawing.Point(65, 66);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(55, 20);
            this.rowTextBox.TabIndex = 2;
            this.rowTextBox.Text = "3";
            this.rowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Row:";
            // 
            // columnTextBox
            // 
            this.columnTextBox.Location = new System.Drawing.Point(65, 92);
            this.columnTextBox.Name = "columnTextBox";
            this.columnTextBox.Size = new System.Drawing.Size(55, 20);
            this.columnTextBox.TabIndex = 3;
            this.columnTextBox.Text = "2";
            this.columnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Column:";
            // 
            // setButton
            // 
            this.setButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setButton.Enabled = false;
            this.setButton.Location = new System.Drawing.Point(171, 64);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 5;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // getButton
            // 
            this.getButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getButton.Enabled = false;
            this.getButton.Location = new System.Drawing.Point(171, 93);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(75, 23);
            this.getButton.TabIndex = 6;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(65, 118);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(55, 20);
            this.valueTextBox.TabIndex = 4;
            this.valueTextBox.Text = "(3, 2)";
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Value:";
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.IntegralHeight = false;
            this.valuesListBox.Location = new System.Drawing.Point(12, 144);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(234, 96);
            this.valuesListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 252);
            this.Controls.Add(this.valuesListBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.columnTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.numRowsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TriangularArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numRowsTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox rowTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox columnTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox valuesListBox;
    }
}

