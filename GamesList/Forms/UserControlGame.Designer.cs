namespace GamesList.Forms
{
    partial class UserControlGame
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.msBundles = new System.Windows.Forms.MenuStrip();
            this.tsmiBundleAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBundleDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBundles = new System.Windows.Forms.DataGridView();
            this.msPlatforms = new System.Windows.Forms.MenuStrip();
            this.tsmiPlatformAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlatformEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlatformDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlatformUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlatformDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApplyDefaultStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPlatforms = new System.Windows.Forms.DataGridView();
            this.msGenres = new System.Windows.Forms.MenuStrip();
            this.tsmiGenreAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenreDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatformHave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPlatformStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBundleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.msBundles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBundles)).BeginInit();
            this.msPlatforms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).BeginInit();
            this.msGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(4, 37);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(413, 26);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(4, 184);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(413, 28);
            this.cbStatus.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Статус";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(4, 110);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(413, 26);
            this.dtpDate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата";
            // 
            // tbComment
            // 
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComment.Location = new System.Drawing.Point(4, 25);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(408, 86);
            this.tbComment.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Комментарий";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dgvGenres, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.msGenres, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dgvPlatforms, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.msPlatforms, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgvBundles, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.msBundles, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbComment, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 220);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 718);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // msBundles
            // 
            this.msBundles.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msBundles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBundleAdd,
            this.tsmiBundleDelete});
            this.msBundles.Location = new System.Drawing.Point(0, 116);
            this.msBundles.Name = "msBundles";
            this.msBundles.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msBundles.Size = new System.Drawing.Size(416, 34);
            this.msBundles.TabIndex = 16;
            this.msBundles.Text = "menuStrip1";
            // 
            // tsmiBundleAdd
            // 
            this.tsmiBundleAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiBundleAdd.Image = global::GamesList.Properties.Resources.IconPlus;
            this.tsmiBundleAdd.Name = "tsmiBundleAdd";
            this.tsmiBundleAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiBundleAdd.Text = "Добавить";
            this.tsmiBundleAdd.Click += new System.EventHandler(this.tsmiBundleAdd_Click);
            // 
            // tsmiBundleDelete
            // 
            this.tsmiBundleDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiBundleDelete.Image = global::GamesList.Properties.Resources.action_delete_sharp_thick;
            this.tsmiBundleDelete.Name = "tsmiBundleDelete";
            this.tsmiBundleDelete.Size = new System.Drawing.Size(36, 28);
            this.tsmiBundleDelete.Text = "Удалить";
            this.tsmiBundleDelete.Click += new System.EventHandler(this.tsmiBundleDelete_Click);
            // 
            // dgvBundles
            // 
            this.dgvBundles.AllowUserToAddRows = false;
            this.dgvBundles.AllowUserToDeleteRows = false;
            this.dgvBundles.AllowUserToResizeRows = false;
            this.dgvBundles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBundles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBundles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBundleName});
            this.dgvBundles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBundles.Location = new System.Drawing.Point(4, 155);
            this.dgvBundles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBundles.MultiSelect = false;
            this.dgvBundles.Name = "dgvBundles";
            this.dgvBundles.ReadOnly = true;
            this.dgvBundles.RowHeadersVisible = false;
            this.dgvBundles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBundles.Size = new System.Drawing.Size(408, 140);
            this.dgvBundles.TabIndex = 17;
            // 
            // msPlatforms
            // 
            this.msPlatforms.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msPlatforms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlatformAdd,
            this.tsmiPlatformEdit,
            this.tsmiPlatformDelete,
            this.tsmiPlatformUp,
            this.tsmiPlatformDown,
            this.tsmiApplyDefaultStatus});
            this.msPlatforms.Location = new System.Drawing.Point(0, 300);
            this.msPlatforms.Name = "msPlatforms";
            this.msPlatforms.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msPlatforms.Size = new System.Drawing.Size(416, 34);
            this.msPlatforms.TabIndex = 18;
            this.msPlatforms.Text = "menuStrip1";
            // 
            // tsmiPlatformAdd
            // 
            this.tsmiPlatformAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformAdd.Image = global::GamesList.Properties.Resources.IconPlus;
            this.tsmiPlatformAdd.Name = "tsmiPlatformAdd";
            this.tsmiPlatformAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiPlatformAdd.Text = "Добавить";
            this.tsmiPlatformAdd.Click += new System.EventHandler(this.tsmiPlatformAdd_Click);
            // 
            // tsmiPlatformEdit
            // 
            this.tsmiPlatformEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformEdit.Image = global::GamesList.Properties.Resources.IconEdit;
            this.tsmiPlatformEdit.Name = "tsmiPlatformEdit";
            this.tsmiPlatformEdit.Size = new System.Drawing.Size(36, 28);
            this.tsmiPlatformEdit.Text = "Редактировать";
            this.tsmiPlatformEdit.Click += new System.EventHandler(this.tsmiPlatformEdit_Click);
            // 
            // tsmiPlatformDelete
            // 
            this.tsmiPlatformDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformDelete.Image = global::GamesList.Properties.Resources.action_delete_sharp_thick;
            this.tsmiPlatformDelete.Name = "tsmiPlatformDelete";
            this.tsmiPlatformDelete.Size = new System.Drawing.Size(36, 28);
            this.tsmiPlatformDelete.Text = "Удалить";
            this.tsmiPlatformDelete.Click += new System.EventHandler(this.tsmiPlatformDelete_Click);
            // 
            // tsmiPlatformUp
            // 
            this.tsmiPlatformUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformUp.Image = global::GamesList.Properties.Resources.IconUp;
            this.tsmiPlatformUp.Name = "tsmiPlatformUp";
            this.tsmiPlatformUp.Size = new System.Drawing.Size(36, 28);
            this.tsmiPlatformUp.Text = "Вверх";
            this.tsmiPlatformUp.Click += new System.EventHandler(this.tsmiPlatformUp_Click);
            // 
            // tsmiPlatformDown
            // 
            this.tsmiPlatformDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformDown.Image = global::GamesList.Properties.Resources.IconDown;
            this.tsmiPlatformDown.Name = "tsmiPlatformDown";
            this.tsmiPlatformDown.Size = new System.Drawing.Size(36, 28);
            this.tsmiPlatformDown.Text = "Вниз";
            this.tsmiPlatformDown.Click += new System.EventHandler(this.tsmiPlatformDown_Click);
            // 
            // tsmiApplyDefaultStatus
            // 
            this.tsmiApplyDefaultStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiApplyDefaultStatus.Image = global::GamesList.Properties.Resources.IconApply;
            this.tsmiApplyDefaultStatus.Name = "tsmiApplyDefaultStatus";
            this.tsmiApplyDefaultStatus.Size = new System.Drawing.Size(36, 28);
            this.tsmiApplyDefaultStatus.Text = "Применить статус по умолчанию";
            this.tsmiApplyDefaultStatus.Click += new System.EventHandler(this.tsmiApplyDefaultStatus_Click);
            // 
            // dgvPlatforms
            // 
            this.dgvPlatforms.AllowUserToAddRows = false;
            this.dgvPlatforms.AllowUserToDeleteRows = false;
            this.dgvPlatforms.AllowUserToResizeRows = false;
            this.dgvPlatforms.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPlatforms.ColumnHeadersHeight = 28;
            this.dgvPlatforms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlatforms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colPlatformHave,
            this.colPlatformStatus});
            this.dgvPlatforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlatforms.Location = new System.Drawing.Point(4, 339);
            this.dgvPlatforms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPlatforms.MultiSelect = false;
            this.dgvPlatforms.Name = "dgvPlatforms";
            this.dgvPlatforms.ReadOnly = true;
            this.dgvPlatforms.RowHeadersVisible = false;
            this.dgvPlatforms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlatforms.Size = new System.Drawing.Size(408, 190);
            this.dgvPlatforms.TabIndex = 19;
            // 
            // msGenres
            // 
            this.msGenres.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msGenres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGenreAdd,
            this.tsmiGenreDelete});
            this.msGenres.Location = new System.Drawing.Point(0, 534);
            this.msGenres.Name = "msGenres";
            this.msGenres.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msGenres.Size = new System.Drawing.Size(416, 34);
            this.msGenres.TabIndex = 20;
            this.msGenres.Text = "menuStrip1";
            // 
            // tsmiGenreAdd
            // 
            this.tsmiGenreAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGenreAdd.Image = global::GamesList.Properties.Resources.IconPlus;
            this.tsmiGenreAdd.Name = "tsmiGenreAdd";
            this.tsmiGenreAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiGenreAdd.Text = "Добавить";
            this.tsmiGenreAdd.Click += new System.EventHandler(this.tsmiGenreAdd_Click);
            // 
            // tsmiGenreDelete
            // 
            this.tsmiGenreDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGenreDelete.Image = global::GamesList.Properties.Resources.action_delete_sharp_thick;
            this.tsmiGenreDelete.Name = "tsmiGenreDelete";
            this.tsmiGenreDelete.Size = new System.Drawing.Size(36, 28);
            this.tsmiGenreDelete.Text = "Удалить";
            this.tsmiGenreDelete.Click += new System.EventHandler(this.tsmiGenreDelete_Click);
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.AllowUserToResizeRows = false;
            this.dgvGenres.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenres.Location = new System.Drawing.Point(4, 573);
            this.dgvGenres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGenres.MultiSelect = false;
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.ReadOnly = true;
            this.dgvGenres.RowHeadersVisible = false;
            this.dgvGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenres.Size = new System.Drawing.Size(408, 140);
            this.dgvGenres.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Platform";
            this.dataGridViewTextBoxColumn1.HeaderText = "Платформа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colPlatformHave
            // 
            this.colPlatformHave.DataPropertyName = "Have";
            this.colPlatformHave.HeaderText = "В наличии";
            this.colPlatformHave.Name = "colPlatformHave";
            this.colPlatformHave.ReadOnly = true;
            this.colPlatformHave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPlatformHave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colPlatformStatus
            // 
            this.colPlatformStatus.DataPropertyName = "GameStatusString";
            this.colPlatformStatus.HeaderText = "Статус";
            this.colPlatformStatus.Name = "colPlatformStatus";
            this.colPlatformStatus.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Жанр";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // colBundleName
            // 
            this.colBundleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBundleName.DataPropertyName = "Bundle";
            this.colBundleName.HeaderText = "Набор";
            this.colBundleName.Name = "colBundleName";
            this.colBundleName.ReadOnly = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOk.Location = new System.Drawing.Point(146, 946);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(112, 35);
            this.btOk.TabIndex = 17;
            this.btOk.Text = "Сохранить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // UserControlGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGame";
            this.Size = new System.Drawing.Size(421, 990);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.msBundles.ResumeLayout(false);
            this.msBundles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBundles)).EndInit();
            this.msPlatforms.ResumeLayout(false);
            this.msPlatforms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).EndInit();
            this.msGenres.ResumeLayout(false);
            this.msGenres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip msBundles;
        private System.Windows.Forms.ToolStripMenuItem tsmiBundleAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiBundleDelete;
        private System.Windows.Forms.DataGridView dgvBundles;
        private System.Windows.Forms.MenuStrip msPlatforms;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplyDefaultStatus;
        private System.Windows.Forms.DataGridView dgvPlatforms;
        private System.Windows.Forms.MenuStrip msGenres;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenreAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenreDelete;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPlatformHave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatformStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBundleName;
        private System.Windows.Forms.Button btOk;
    }
}
