namespace LibraryManager
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Okunmuş");
            TreeNode treeNode2 = new TreeNode("Okunmamış");
            TreeNode treeNode3 = new TreeNode("Bekleyen");
            TreeNode treeNode4 = new TreeNode("Dilekçeler", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            tvPetitions = new TreeView();
            btnUnselectAll = new Button();
            btnMarkAll = new Button();
            btnSelectAll = new Button();
            dgvPetitions = new DataGridView();
            cms = new ContextMenuStrip(components);
            chooseAllToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPetitions).BeginInit();
            cms.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvPetitions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnUnselectAll);
            splitContainer1.Panel2.Controls.Add(btnMarkAll);
            splitContainer1.Panel2.Controls.Add(btnSelectAll);
            splitContainer1.Panel2.Controls.Add(dgvPetitions);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 155;
            splitContainer1.TabIndex = 1;
            // 
            // tvPetitions
            // 
            tvPetitions.Dock = DockStyle.Fill;
            tvPetitions.ItemHeight = 30;
            tvPetitions.Location = new Point(0, 0);
            tvPetitions.Name = "tvPetitions";
            treeNode1.Name = "readPetition";
            treeNode1.Text = "Okunmuş";
            treeNode2.Name = "nonreadPetition";
            treeNode2.Text = "Okunmamış";
            treeNode3.Name = "pendingPetition";
            treeNode3.Text = "Bekleyen";
            treeNode4.Name = "rootPetition";
            treeNode4.Text = "Dilekçeler";
            tvPetitions.Nodes.AddRange(new TreeNode[] { treeNode4 });
            tvPetitions.Size = new Size(155, 450);
            tvPetitions.TabIndex = 1;
            // 
            // btnUnselectAll
            // 
            btnUnselectAll.Location = new Point(401, 397);
            btnUnselectAll.Name = "btnUnselectAll";
            btnUnselectAll.Size = new Size(170, 41);
            btnUnselectAll.TabIndex = 3;
            btnUnselectAll.Text = "Tüm Seçimleri İptal Et";
            btnUnselectAll.UseVisualStyleBackColor = true;
            btnUnselectAll.Click += btnUnselectAll_Click;
            // 
            // btnMarkAll
            // 
            btnMarkAll.Location = new Point(191, 397);
            btnMarkAll.Name = "btnMarkAll";
            btnMarkAll.Size = new Size(186, 41);
            btnMarkAll.TabIndex = 2;
            btnMarkAll.Text = "Okundu Olarak İşaretle";
            btnMarkAll.UseVisualStyleBackColor = true;
            btnMarkAll.Click += btnMarkAll_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.AutoSize = true;
            btnSelectAll.Location = new Point(69, 397);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(99, 41);
            btnSelectAll.TabIndex = 1;
            btnSelectAll.Text = "Tümünü Seç";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // dgvPetitions
            // 
            dgvPetitions.AllowUserToAddRows = false;
            dgvPetitions.AllowUserToDeleteRows = false;
            dgvPetitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPetitions.BackgroundColor = Color.Silver;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPetitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPetitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetitions.ContextMenuStrip = cms;
            dgvPetitions.Dock = DockStyle.Top;
            dgvPetitions.Location = new Point(0, 0);
            dgvPetitions.Name = "dgvPetitions";
            dgvPetitions.ReadOnly = true;
            dgvPetitions.RowHeadersVisible = false;
            dgvPetitions.RowHeadersWidth = 51;
            dgvPetitions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPetitions.Size = new Size(641, 376);
            dgvPetitions.TabIndex = 0;
            // 
            // cms
            // 
            cms.ImageScalingSize = new Size(20, 20);
            cms.Items.AddRange(new ToolStripItem[] { chooseAllToolStripMenuItem });
            cms.Name = "cms";
            cms.Size = new Size(159, 28);
            cms.Text = "Tümünü Seç";
            // 
            // chooseAllToolStripMenuItem
            // 
            chooseAllToolStripMenuItem.Name = "chooseAllToolStripMenuItem";
            chooseAllToolStripMenuItem.Size = new Size(158, 24);
            chooseAllToolStripMenuItem.Text = "Tümünü Seç";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPetitions).EndInit();
            cms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView tvPetitions;
        private DataGridView dgvPetitions;
        private Button btnMarkAll;
        private Button btnSelectAll;
        private Button btnUnselectAll;
        private ContextMenuStrip cms;
        private ToolStripMenuItem chooseAllToolStripMenuItem;
    }
}