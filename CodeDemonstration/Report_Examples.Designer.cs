namespace CodeDemonstration
{
    partial class Report_Examples
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Finance Application";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(61, 129);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(227, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // caculatorToolStripMenuItem
            // 
            this.caculatorToolStripMenuItem.Name = "caculatorToolStripMenuItem";
            this.caculatorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.caculatorToolStripMenuItem.Text = "Caculator";
            this.caculatorToolStripMenuItem.Click += new System.EventHandler(this.startButton_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseImagesToolStripMenuItem,
            this.itemNamesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viewToolStripMenuItem.Text = "Views";
            // 
            // warehouseImagesToolStripMenuItem
            // 
            this.warehouseImagesToolStripMenuItem.Name = "warehouseImagesToolStripMenuItem";
            this.warehouseImagesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.warehouseImagesToolStripMenuItem.Text = "Warehouse Images";
            this.warehouseImagesToolStripMenuItem.Click += new System.EventHandler(this.warehouseImagesToolStripMenuItem_Click);
            // 
            // itemNamesToolStripMenuItem
            // 
            this.itemNamesToolStripMenuItem.Name = "itemNamesToolStripMenuItem";
            this.itemNamesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemNamesToolStripMenuItem.Text = "Item Names";
            this.itemNamesToolStripMenuItem.Click += new System.EventHandler(this.itemNamesToolStripMenuItem_Click);
            // 
            // Report_Examples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Report_Examples";
            this.Text = "Finance System";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem caculatorToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem warehouseImagesToolStripMenuItem;
        private ToolStripMenuItem itemNamesToolStripMenuItem;
    }
}