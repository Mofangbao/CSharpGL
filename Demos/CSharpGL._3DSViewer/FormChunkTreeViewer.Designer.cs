﻿namespace CSharpGL._3DSViewer
{
    partial class FormChunkTreeViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChunkTreeViewer));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印预览VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重复RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkHideUndefinedChunks = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(12, 56);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(463, 490);
            this.treeView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.toolStripSeparator,
            this.保存SToolStripMenuItem,
            this.另存为AToolStripMenuItem,
            this.toolStripSeparator1,
            this.打印PToolStripMenuItem,
            this.打印预览VToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripMenuItem.Image")));
            this.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            this.新建NToolStripMenuItem.Visible = false;
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripMenuItem.Image")));
            this.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(191, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripMenuItem.Image")));
            this.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Visible = false;
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            this.另存为AToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // 打印PToolStripMenuItem
            // 
            this.打印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印PToolStripMenuItem.Image")));
            this.打印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印PToolStripMenuItem.Name = "打印PToolStripMenuItem";
            this.打印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印PToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.打印PToolStripMenuItem.Text = "打印(&P)";
            this.打印PToolStripMenuItem.Visible = false;
            // 
            // 打印预览VToolStripMenuItem
            // 
            this.打印预览VToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印预览VToolStripMenuItem.Image")));
            this.打印预览VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印预览VToolStripMenuItem.Name = "打印预览VToolStripMenuItem";
            this.打印预览VToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.打印预览VToolStripMenuItem.Text = "打印预览(&V)";
            this.打印预览VToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤消UToolStripMenuItem,
            this.重复RToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪切TToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全选AToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            this.编辑EToolStripMenuItem.Visible = false;
            // 
            // 撤消UToolStripMenuItem
            // 
            this.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem";
            this.撤消UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤消UToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.撤消UToolStripMenuItem.Text = "撤消(&U)";
            // 
            // 重复RToolStripMenuItem
            // 
            this.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem";
            this.重复RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.重复RToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.重复RToolStripMenuItem.Text = "重复(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切TToolStripMenuItem.Image")));
            this.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripMenuItem.Image")));
            this.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripMenuItem.Image")));
            this.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.全选AToolStripMenuItem.Text = "全选(&A)";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自定义CToolStripMenuItem,
            this.选项OToolStripMenuItem,
            this.导出文本ToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 自定义CToolStripMenuItem
            // 
            this.自定义CToolStripMenuItem.Name = "自定义CToolStripMenuItem";
            this.自定义CToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.自定义CToolStripMenuItem.Text = "自定义(&C)";
            this.自定义CToolStripMenuItem.Visible = false;
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            this.选项OToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.选项OToolStripMenuItem.Text = "选项(&O)";
            this.选项OToolStripMenuItem.Visible = false;
            // 
            // 导出文本ToolStripMenuItem
            // 
            this.导出文本ToolStripMenuItem.Name = "导出文本ToolStripMenuItem";
            this.导出文本ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.导出文本ToolStripMenuItem.Text = "导出文本(&T)";
            this.导出文本ToolStripMenuItem.Click += new System.EventHandler(this.导出文本ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜索SToolStripMenuItem,
            this.toolStripSeparator5,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            this.帮助HToolStripMenuItem.Visible = false;
            // 
            // 内容CToolStripMenuItem
            // 
            this.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem";
            this.内容CToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.内容CToolStripMenuItem.Text = "内容(&C)";
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.索引IToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜索SToolStripMenuItem
            // 
            this.搜索SToolStripMenuItem.Name = "搜索SToolStripMenuItem";
            this.搜索SToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.搜索SToolStripMenuItem.Text = "搜索(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.关于AToolStripMenuItem.Text = "关于(&A)...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "*.3ds|*.3ds";
            // 
            // chkHideUndefinedChunks
            // 
            this.chkHideUndefinedChunks.AutoSize = true;
            this.chkHideUndefinedChunks.Enabled = false;
            this.chkHideUndefinedChunks.Location = new System.Drawing.Point(12, 31);
            this.chkHideUndefinedChunks.Name = "chkHideUndefinedChunks";
            this.chkHideUndefinedChunks.Size = new System.Drawing.Size(197, 19);
            this.chkHideUndefinedChunks.TabIndex = 2;
            this.chkHideUndefinedChunks.Text = "Hide Undefined Chunks";
            this.chkHideUndefinedChunks.UseVisualStyleBackColor = true;
            this.chkHideUndefinedChunks.CheckedChanged += new System.EventHandler(this.chkHideUndefinedChunks_CheckedChanged);
            // 
            // FormChunkTreeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 558);
            this.Controls.Add(this.chkHideUndefinedChunks);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChunkTreeViewer";
            this.Text = "3DS Chunk Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 打印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤消UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重复RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkHideUndefinedChunks;
        private System.Windows.Forms.ToolStripMenuItem 导出文本ToolStripMenuItem;
    }
}