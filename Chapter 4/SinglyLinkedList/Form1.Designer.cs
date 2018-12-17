namespace SinglyLinkedList
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
            this.addTopButton = new System.Windows.Forms.Button();
            this.addBottomButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.removeBottomButton = new System.Windows.Forms.Button();
            this.removeTopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value:";
            // 
            // addTopButton
            // 
            this.addTopButton.Location = new System.Drawing.Point(118, 12);
            this.addTopButton.Name = "addTopButton";
            this.addTopButton.Size = new System.Drawing.Size(95, 23);
            this.addTopButton.TabIndex = 1;
            this.addTopButton.Text = "Add At Top";
            this.addTopButton.UseVisualStyleBackColor = true;
            this.addTopButton.Click += new System.EventHandler(this.addTopButton_Click);
            // 
            // addBottomButton
            // 
            this.addBottomButton.Location = new System.Drawing.Point(118, 41);
            this.addBottomButton.Name = "addBottomButton";
            this.addBottomButton.Size = new System.Drawing.Size(95, 23);
            this.addBottomButton.TabIndex = 2;
            this.addBottomButton.Text = "Add At Bottom";
            this.addBottomButton.UseVisualStyleBackColor = true;
            this.addBottomButton.Click += new System.EventHandler(this.addBottomButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(55, 14);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(57, 20);
            this.valueTextBox.TabIndex = 0;
            // 
            // valuesListBox
            // 
            this.valuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.IntegralHeight = false;
            this.valuesListBox.Location = new System.Drawing.Point(12, 70);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(301, 110);
            this.valuesListBox.TabIndex = 3;
            // 
            // removeBottomButton
            // 
            this.removeBottomButton.Location = new System.Drawing.Point(219, 41);
            this.removeBottomButton.Name = "removeBottomButton";
            this.removeBottomButton.Size = new System.Drawing.Size(95, 23);
            this.removeBottomButton.TabIndex = 5;
            this.removeBottomButton.Text = "Remove Bottom";
            this.removeBottomButton.UseVisualStyleBackColor = true;
            this.removeBottomButton.Click += new System.EventHandler(this.removeBottomButton_Click);
            // 
            // removeTopButton
            // 
            this.removeTopButton.Location = new System.Drawing.Point(219, 12);
            this.removeTopButton.Name = "removeTopButton";
            this.removeTopButton.Size = new System.Drawing.Size(95, 23);
            this.removeTopButton.TabIndex = 4;
            this.removeTopButton.Text = "Remove Top";
            this.removeTopButton.UseVisualStyleBackColor = true;
            this.removeTopButton.Click += new System.EventHandler(this.removeTopButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.addTopButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 192);
            this.Controls.Add(this.removeBottomButton);
            this.Controls.Add(this.removeTopButton);
            this.Controls.Add(this.valuesListBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.addBottomButton);
            this.Controls.Add(this.addTopButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SinglyLinkedList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTopButton;
        private System.Windows.Forms.Button addBottomButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Button removeBottomButton;
        private System.Windows.Forms.Button removeTopButton;
    }
}

