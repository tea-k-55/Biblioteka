namespace biblioteka
{
    partial class OAplikaciji
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Glavna Forma");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Forma Analiza");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Forma O aplikaciji");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Uputstvo", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Primer 1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Primer 2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Test primeri", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("O autoru");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Glavna Forma";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Forma Analiza";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Forma O aplikaciji";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Uputstvo";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Primer 1";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Primer 2";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Test primeri";
            treeNode8.Name = "Node9";
            treeNode8.Text = "O autoru";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(191, 351);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(191, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(324, 351);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // OAplikaciji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 351);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OAplikaciji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OAplikaciji";
            this.Load += new System.EventHandler(this.OAplikaciji_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}