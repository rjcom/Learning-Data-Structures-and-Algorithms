﻿namespace AvlTree
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
            this.components = new System.ComponentModel.Container();
            this.breadthFirstTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.postorderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inorderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.preorderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treePictureBox = new System.Windows.Forms.PictureBox();
            this.ctxNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxNodeAddChild = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxNodeDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.treePictureBox)).BeginInit();
            this.ctxNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // breadthFirstTextBox
            // 
            this.breadthFirstTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.breadthFirstTextBox.Location = new System.Drawing.Point(86, 276);
            this.breadthFirstTextBox.Name = "breadthFirstTextBox";
            this.breadthFirstTextBox.ReadOnly = true;
            this.breadthFirstTextBox.Size = new System.Drawing.Size(188, 20);
            this.breadthFirstTextBox.TabIndex = 27;
            this.breadthFirstTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Breadth-First:";
            // 
            // postorderTextBox
            // 
            this.postorderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postorderTextBox.Location = new System.Drawing.Point(86, 250);
            this.postorderTextBox.Name = "postorderTextBox";
            this.postorderTextBox.ReadOnly = true;
            this.postorderTextBox.Size = new System.Drawing.Size(188, 20);
            this.postorderTextBox.TabIndex = 25;
            this.postorderTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Postorder:";
            // 
            // inorderTextBox
            // 
            this.inorderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inorderTextBox.Location = new System.Drawing.Point(86, 224);
            this.inorderTextBox.Name = "inorderTextBox";
            this.inorderTextBox.ReadOnly = true;
            this.inorderTextBox.Size = new System.Drawing.Size(188, 20);
            this.inorderTextBox.TabIndex = 23;
            this.inorderTextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Inorder:";
            // 
            // preorderTextBox
            // 
            this.preorderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preorderTextBox.Location = new System.Drawing.Point(86, 198);
            this.preorderTextBox.Name = "preorderTextBox";
            this.preorderTextBox.ReadOnly = true;
            this.preorderTextBox.Size = new System.Drawing.Size(188, 20);
            this.preorderTextBox.TabIndex = 21;
            this.preorderTextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Preorder:";
            // 
            // treePictureBox
            // 
            this.treePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePictureBox.BackColor = System.Drawing.Color.White;
            this.treePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.treePictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.treePictureBox.Location = new System.Drawing.Point(14, 10);
            this.treePictureBox.Name = "treePictureBox";
            this.treePictureBox.Size = new System.Drawing.Size(260, 182);
            this.treePictureBox.TabIndex = 19;
            this.treePictureBox.TabStop = false;
            this.treePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.treePictureBox_Paint);
            this.treePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treePictureBox_MouseDown);
            this.treePictureBox.Resize += new System.EventHandler(this.treePictureBox_Resize);
            // 
            // ctxNode
            // 
            this.ctxNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxNodeAddChild,
            this.ctxNodeDelete});
            this.ctxNode.Name = "ctxNode";
            this.ctxNode.Size = new System.Drawing.Size(149, 48);
            // 
            // ctxNodeAddChild
            // 
            this.ctxNodeAddChild.Name = "ctxNodeAddChild";
            this.ctxNodeAddChild.Size = new System.Drawing.Size(148, 22);
            this.ctxNodeAddChild.Text = "&Add Child...";
            this.ctxNodeAddChild.Click += new System.EventHandler(this.ctxNodeAddChild_Click);
            // 
            // ctxNodeDelete
            // 
            this.ctxNodeDelete.Name = "ctxNodeDelete";
            this.ctxNodeDelete.Size = new System.Drawing.Size(148, 22);
            this.ctxNodeDelete.Text = "&Delete Node...";
            this.ctxNodeDelete.Click += new System.EventHandler(this.ctxNodeDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 307);
            this.Controls.Add(this.breadthFirstTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postorderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inorderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.preorderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treePictureBox);
            this.Name = "Form1";
            this.Text = "AvlTree";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treePictureBox)).EndInit();
            this.ctxNode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox breadthFirstTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox postorderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inorderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox preorderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox treePictureBox;
        private System.Windows.Forms.ContextMenuStrip ctxNode;
        private System.Windows.Forms.ToolStripMenuItem ctxNodeAddChild;
        private System.Windows.Forms.ToolStripMenuItem ctxNodeDelete;
    }
}

