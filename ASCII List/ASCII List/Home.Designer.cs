namespace ASCII_List
{
    partial class Home
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.listView1 = new System.Windows.Forms.ListView();
            this.BIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OCT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DEC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HEX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHAR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MEAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制当前选中行的ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二进制值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.八进制值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.十进制值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.十六进制值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空标记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCII扩展ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.复制CToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.二进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.八进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.十进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.十六进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助LToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.帮助文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BIN,
            this.OCT,
            this.DEC,
            this.HEX,
            this.CHAR,
            this.MEAN});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(582, 518);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // BIN
            // 
            this.BIN.Text = "BIN";
            this.BIN.Width = 89;
            // 
            // OCT
            // 
            this.OCT.Text = "OCT";
            this.OCT.Width = 49;
            // 
            // DEC
            // 
            this.DEC.Text = "DEC";
            this.DEC.Width = 52;
            // 
            // HEX
            // 
            this.HEX.Text = "HEX";
            this.HEX.Width = 56;
            // 
            // CHAR
            // 
            this.CHAR.Text = "字符";
            this.CHAR.Width = 119;
            // 
            // MEAN
            // 
            this.MEAN.Text = "释义";
            this.MEAN.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制当前选中行的ToolStripMenuItem,
            this.清空标记ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            // 
            // 复制当前选中行的ToolStripMenuItem
            // 
            this.复制当前选中行的ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.二进制值ToolStripMenuItem,
            this.八进制值ToolStripMenuItem,
            this.十进制值ToolStripMenuItem,
            this.十六进制值ToolStripMenuItem});
            this.复制当前选中行的ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.复制当前选中行的ToolStripMenuItem.Name = "复制当前选中行的ToolStripMenuItem";
            this.复制当前选中行的ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.复制当前选中行的ToolStripMenuItem.Text = "复制选中行";
            // 
            // 二进制值ToolStripMenuItem
            // 
            this.二进制值ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.二进制值ToolStripMenuItem.Name = "二进制值ToolStripMenuItem";
            this.二进制值ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.二进制值ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.二进制值ToolStripMenuItem.Text = "二进制值";
            this.二进制值ToolStripMenuItem.Click += new System.EventHandler(this.二进制值ToolStripMenuItem_Click);
            // 
            // 八进制值ToolStripMenuItem
            // 
            this.八进制值ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.八进制值ToolStripMenuItem.Name = "八进制值ToolStripMenuItem";
            this.八进制值ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.八进制值ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.八进制值ToolStripMenuItem.Text = "八进制值";
            this.八进制值ToolStripMenuItem.Click += new System.EventHandler(this.八进制值ToolStripMenuItem_Click);
            // 
            // 十进制值ToolStripMenuItem
            // 
            this.十进制值ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.十进制值ToolStripMenuItem.Name = "十进制值ToolStripMenuItem";
            this.十进制值ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.十进制值ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.十进制值ToolStripMenuItem.Text = "十进制值";
            this.十进制值ToolStripMenuItem.Click += new System.EventHandler(this.十进制值ToolStripMenuItem_Click);
            // 
            // 十六进制值ToolStripMenuItem
            // 
            this.十六进制值ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.十六进制值ToolStripMenuItem.Name = "十六进制值ToolStripMenuItem";
            this.十六进制值ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.十六进制值ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.十六进制值ToolStripMenuItem.Text = "十六进制值";
            this.十六进制值ToolStripMenuItem.Click += new System.EventHandler(this.十六进制值ToolStripMenuItem_Click);
            // 
            // 清空标记ToolStripMenuItem
            // 
            this.清空标记ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.清空标记ToolStripMenuItem.Name = "清空标记ToolStripMenuItem";
            this.清空标记ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.清空标记ToolStripMenuItem.Text = "清空标记";
            this.清空标记ToolStripMenuItem.Click += new System.EventHandler(this.清空标记ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripSeparator,
            this.复制CToolStripButton,
            this.toolStripSeparator2,
            this.帮助LToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(582, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.转换ToolStripMenuItem,
            this.aSCII扩展ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 22);
            this.toolStripDropDownButton1.Text = "功能";
            // 
            // 转换ToolStripMenuItem
            // 
            this.转换ToolStripMenuItem.Name = "转换ToolStripMenuItem";
            this.转换ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.转换ToolStripMenuItem.Text = "转换";
            this.转换ToolStripMenuItem.Click += new System.EventHandler(this.转换ToolStripMenuItem_Click);
            // 
            // aSCII扩展ToolStripMenuItem
            // 
            this.aSCII扩展ToolStripMenuItem.Name = "aSCII扩展ToolStripMenuItem";
            this.aSCII扩展ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aSCII扩展ToolStripMenuItem.Text = "ASCII扩展";
            this.aSCII扩展ToolStripMenuItem.Click += new System.EventHandler(this.aSCII扩展ToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "快速查询";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "ASCII",
            "0-9",
            "a-z",
            "A-Z",
            "字符",
            "控制字符(通信专用字符)",
            "退格",
            "制表",
            "换行",
            "回车"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.ToolTipText = "请选择筛查条件";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // 复制CToolStripButton
            // 
            this.复制CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.复制CToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.二进制ToolStripMenuItem,
            this.八进制ToolStripMenuItem,
            this.十进制ToolStripMenuItem,
            this.十六进制ToolStripMenuItem});
            this.复制CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripButton.Image")));
            this.复制CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripButton.Name = "复制CToolStripButton";
            this.复制CToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.复制CToolStripButton.Text = "复制(&C)";
            // 
            // 二进制ToolStripMenuItem
            // 
            this.二进制ToolStripMenuItem.Name = "二进制ToolStripMenuItem";
            this.二进制ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.二进制ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.二进制ToolStripMenuItem.Text = "二进制";
            this.二进制ToolStripMenuItem.Click += new System.EventHandler(this.二进制ToolStripMenuItem_Click);
            // 
            // 八进制ToolStripMenuItem
            // 
            this.八进制ToolStripMenuItem.Name = "八进制ToolStripMenuItem";
            this.八进制ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.八进制ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.八进制ToolStripMenuItem.Text = "八进制";
            this.八进制ToolStripMenuItem.Click += new System.EventHandler(this.八进制ToolStripMenuItem_Click);
            // 
            // 十进制ToolStripMenuItem
            // 
            this.十进制ToolStripMenuItem.Name = "十进制ToolStripMenuItem";
            this.十进制ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.十进制ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.十进制ToolStripMenuItem.Text = "十进制";
            this.十进制ToolStripMenuItem.Click += new System.EventHandler(this.十进制ToolStripMenuItem_Click);
            // 
            // 十六进制ToolStripMenuItem
            // 
            this.十六进制ToolStripMenuItem.Name = "十六进制ToolStripMenuItem";
            this.十六进制ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.十六进制ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.十六进制ToolStripMenuItem.Text = "十六进制";
            this.十六进制ToolStripMenuItem.Click += new System.EventHandler(this.十六进制ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // 帮助LToolStripButton
            // 
            this.帮助LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.帮助LToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助文档ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助LToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("帮助LToolStripButton.Image")));
            this.帮助LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.帮助LToolStripButton.Name = "帮助LToolStripButton";
            this.帮助LToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.帮助LToolStripButton.Text = "帮助(&L)";
            // 
            // 帮助文档ToolStripMenuItem
            // 
            this.帮助文档ToolStripMenuItem.Name = "帮助文档ToolStripMenuItem";
            this.帮助文档ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.帮助文档ToolStripMenuItem.Text = "帮助文档";
            this.帮助文档ToolStripMenuItem.Click += new System.EventHandler(this.帮助文档ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(582, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(149, 17);
            this.toolStripStatusLabel1.Text = "ASCII List Version 0.0.1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 571);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASCII LIST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BIN;
        private System.Windows.Forms.ColumnHeader OCT;
        private System.Windows.Forms.ColumnHeader DEC;
        private System.Windows.Forms.ColumnHeader HEX;
        private System.Windows.Forms.ColumnHeader CHAR;
        private System.Windows.Forms.ColumnHeader MEAN;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制当前选中行的ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二进制值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 八进制值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 十进制值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 十六进制值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 转换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCII扩展ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空标记ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton 帮助LToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 帮助文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton 复制CToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 二进制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 八进制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 十进制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 十六进制ToolStripMenuItem;
    }
}

