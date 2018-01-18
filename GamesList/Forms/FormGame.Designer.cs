namespace GamesList.Forms
{
    partial class FormGame
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tcGame = new System.Windows.Forms.TabControl();
            this.tpBundles = new System.Windows.Forms.TabPage();
            this.dgvBundles = new System.Windows.Forms.DataGridView();
            this.colBundleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msBundles = new System.Windows.Forms.MenuStrip();
            this.tpPlatforms = new System.Windows.Forms.TabPage();
            this.dgvPlatforms = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatformHave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPlatformStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msPlatforms = new System.Windows.Forms.MenuStrip();
            this.tpGenres = new System.Windows.Forms.TabPage();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msGenres = new System.Windows.Forms.MenuStrip();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tsmiBundleAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBundleDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlatformAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlatformEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlatformDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlatformUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlatformDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApplyDefaultStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenreAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenreDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tcGame.SuspendLayout();
            this.tpBundles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBundles)).BeginInit();
            this.msBundles.SuspendLayout();
            this.tpPlatforms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).BeginInit();
            this.msPlatforms.SuspendLayout();
            this.tpGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.msGenres.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(12, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(648, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComment.Location = new System.Drawing.Point(12, 112);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(648, 69);
            this.tbComment.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Комментарий";
            // 
            // tcGame
            // 
            this.tcGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcGame.Controls.Add(this.tpBundles);
            this.tcGame.Controls.Add(this.tpPlatforms);
            this.tcGame.Controls.Add(this.tpGenres);
            this.tcGame.Location = new System.Drawing.Point(12, 187);
            this.tcGame.Name = "tcGame";
            this.tcGame.SelectedIndex = 0;
            this.tcGame.Size = new System.Drawing.Size(648, 213);
            this.tcGame.TabIndex = 4;
            // 
            // tpBundles
            // 
            this.tpBundles.Controls.Add(this.dgvBundles);
            this.tpBundles.Controls.Add(this.msBundles);
            this.tpBundles.Location = new System.Drawing.Point(4, 22);
            this.tpBundles.Name = "tpBundles";
            this.tpBundles.Padding = new System.Windows.Forms.Padding(3);
            this.tpBundles.Size = new System.Drawing.Size(640, 187);
            this.tpBundles.TabIndex = 0;
            this.tpBundles.Text = "Наборы";
            this.tpBundles.UseVisualStyleBackColor = true;
            // 
            // dgvBundles
            // 
            this.dgvBundles.AllowUserToAddRows = false;
            this.dgvBundles.AllowUserToDeleteRows = false;
            this.dgvBundles.AllowUserToResizeRows = false;
            this.dgvBundles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBundles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBundles.ColumnHeadersVisible = false;
            this.dgvBundles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBundleName});
            this.dgvBundles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBundles.Location = new System.Drawing.Point(3, 27);
            this.dgvBundles.MultiSelect = false;
            this.dgvBundles.Name = "dgvBundles";
            this.dgvBundles.ReadOnly = true;
            this.dgvBundles.RowHeadersVisible = false;
            this.dgvBundles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBundles.Size = new System.Drawing.Size(634, 157);
            this.dgvBundles.TabIndex = 1;
            // 
            // colBundleName
            // 
            this.colBundleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBundleName.DataPropertyName = "Bundle";
            this.colBundleName.HeaderText = "Название";
            this.colBundleName.Name = "colBundleName";
            this.colBundleName.ReadOnly = true;
            // 
            // msBundles
            // 
            this.msBundles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBundleAdd,
            this.tsmiBundleDelete});
            this.msBundles.Location = new System.Drawing.Point(3, 3);
            this.msBundles.Name = "msBundles";
            this.msBundles.Size = new System.Drawing.Size(634, 24);
            this.msBundles.TabIndex = 0;
            this.msBundles.Text = "menuStrip1";
            // 
            // tpPlatforms
            // 
            this.tpPlatforms.Controls.Add(this.dgvPlatforms);
            this.tpPlatforms.Controls.Add(this.msPlatforms);
            this.tpPlatforms.Location = new System.Drawing.Point(4, 22);
            this.tpPlatforms.Name = "tpPlatforms";
            this.tpPlatforms.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlatforms.Size = new System.Drawing.Size(640, 187);
            this.tpPlatforms.TabIndex = 1;
            this.tpPlatforms.Text = "Платформы";
            this.tpPlatforms.UseVisualStyleBackColor = true;
            // 
            // dgvPlatforms
            // 
            this.dgvPlatforms.AllowUserToAddRows = false;
            this.dgvPlatforms.AllowUserToDeleteRows = false;
            this.dgvPlatforms.AllowUserToResizeRows = false;
            this.dgvPlatforms.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPlatforms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatforms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colPlatformHave,
            this.colPlatformStatus});
            this.dgvPlatforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlatforms.Location = new System.Drawing.Point(3, 27);
            this.dgvPlatforms.MultiSelect = false;
            this.dgvPlatforms.Name = "dgvPlatforms";
            this.dgvPlatforms.ReadOnly = true;
            this.dgvPlatforms.RowHeadersVisible = false;
            this.dgvPlatforms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlatforms.Size = new System.Drawing.Size(634, 157);
            this.dgvPlatforms.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Platform";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
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
            // msPlatforms
            // 
            this.msPlatforms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlatformAdd,
            this.tsmiPlatformEdit,
            this.tsmiPlatformDelete,
            this.tsmiPlatformUp,
            this.tsmiPlatformDown,
            this.tsmiApplyDefaultStatus});
            this.msPlatforms.Location = new System.Drawing.Point(3, 3);
            this.msPlatforms.Name = "msPlatforms";
            this.msPlatforms.Size = new System.Drawing.Size(634, 24);
            this.msPlatforms.TabIndex = 1;
            this.msPlatforms.Text = "menuStrip1";
            // 
            // tpGenres
            // 
            this.tpGenres.Controls.Add(this.dgvGenres);
            this.tpGenres.Controls.Add(this.msGenres);
            this.tpGenres.Location = new System.Drawing.Point(4, 22);
            this.tpGenres.Name = "tpGenres";
            this.tpGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenres.Size = new System.Drawing.Size(640, 187);
            this.tpGenres.TabIndex = 2;
            this.tpGenres.Text = "Жанры";
            this.tpGenres.UseVisualStyleBackColor = true;
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.AllowUserToResizeRows = false;
            this.dgvGenres.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.ColumnHeadersVisible = false;
            this.dgvGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenres.Location = new System.Drawing.Point(3, 27);
            this.dgvGenres.MultiSelect = false;
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.ReadOnly = true;
            this.dgvGenres.RowHeadersVisible = false;
            this.dgvGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenres.Size = new System.Drawing.Size(634, 157);
            this.dgvGenres.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // msGenres
            // 
            this.msGenres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGenreAdd,
            this.tsmiGenreDelete});
            this.msGenres.Location = new System.Drawing.Point(3, 3);
            this.msGenres.Name = "msGenres";
            this.msGenres.Size = new System.Drawing.Size(634, 24);
            this.msGenres.TabIndex = 1;
            this.msGenres.Text = "menuStrip1";
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(339, 406);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOk.Location = new System.Drawing.Point(258, 406);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(492, 72);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(168, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(12, 70);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(474, 21);
            this.cbStatus.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Статус";
            // 
            // tsmiBundleAdd
            // 
            this.tsmiBundleAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiBundleAdd.Image = global::GamesList.Properties.Resources.IconPlus;
            this.tsmiBundleAdd.Name = "tsmiBundleAdd";
            this.tsmiBundleAdd.Size = new System.Drawing.Size(28, 20);
            this.tsmiBundleAdd.Text = "Добавить";
            this.tsmiBundleAdd.Click += new System.EventHandler(this.tsmiBundleAdd_Click);
            // 
            // tsmiBundleDelete
            // 
            this.tsmiBundleDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiBundleDelete.Image = global::GamesList.Properties.Resources.action_delete_sharp_thick;
            this.tsmiBundleDelete.Name = "tsmiBundleDelete";
            this.tsmiBundleDelete.Size = new System.Drawing.Size(28, 20);
            this.tsmiBundleDelete.Text = "Удалить";
            this.tsmiBundleDelete.Click += new System.EventHandler(this.tsmiBundleDelete_Click);
            // 
            // tsmiPlatformAdd
            // 
            this.tsmiPlatformAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformAdd.Image = global::GamesList.Properties.Resources.IconPlus;
            this.tsmiPlatformAdd.Name = "tsmiPlatformAdd";
            this.tsmiPlatformAdd.Size = new System.Drawing.Size(28, 20);
            this.tsmiPlatformAdd.Text = "Добавить";
            this.tsmiPlatformAdd.Click += new System.EventHandler(this.tsmiPlatformAdd_Click);
            // 
            // tsmiPlatformEdit
            // 
            this.tsmiPlatformEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformEdit.Image = global::GamesList.Properties.Resources.IconEdit;
            this.tsmiPlatformEdit.Name = "tsmiPlatformEdit";
            this.tsmiPlatformEdit.Size = new System.Drawing.Size(28, 20);
            this.tsmiPlatformEdit.Text = "Редактировать";
            this.tsmiPlatformEdit.Click += new System.EventHandler(this.tsmiPlatformEdit_Click);
            // 
            // tsmiPlatformDelete
            // 
            this.tsmiPlatformDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformDelete.Image = global::GamesList.Properties.Resources.action_delete_sharp_thick;
            this.tsmiPlatformDelete.Name = "tsmiPlatformDelete";
            this.tsmiPlatformDelete.Size = new System.Drawing.Size(28, 20);
            this.tsmiPlatformDelete.Text = "Удалить";
            this.tsmiPlatformDelete.Click += new System.EventHandler(this.tsmiPlatformDelete_Click);
            // 
            // tsmiPlatformUp
            // 
            this.tsmiPlatformUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformUp.Image = global::GamesList.Properties.Resources.IconUp;
            this.tsmiPlatformUp.Name = "tsmiPlatformUp";
            this.tsmiPlatformUp.Size = new System.Drawing.Size(28, 20);
            this.tsmiPlatformUp.Text = "Вверх";
            this.tsmiPlatformUp.Click += new System.EventHandler(this.tsmiPlatformUp_Click);
            // 
            // tsmiPlatformDown
            // 
            this.tsmiPlatformDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiPlatformDown.Image = global::GamesList.Properties.Resources.IconDown;
            this.tsmiPlatformDown.Name = "tsmiPlatformDown";
            this.tsmiPlatformDown.Size = new System.Drawing.Size(28, 20);
            this.tsmiPlatformDown.Text = "Вниз";
            this.tsmiPlatformDown.Click += new System.EventHandler(this.tsmiPlatformDown_Click);
            // 
            // tsmiApplyDefaultStatus
            // 
            this.tsmiApplyDefaultStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiApplyDefaultStatus.Image = global::GamesList.Properties.Resources.IconApply;
            this.tsmiApplyDefaultStatus.Name = "tsmiApplyDefaultStatus";
            this.tsmiApplyDefaultStatus.Size = new System.Drawing.Size(28, 20);
            this.tsmiApplyDefaultStatus.Text = "Применить статус по умолчанию";
            this.tsmiApplyDefaultStatus.Click += new System.EventHandler(this.tsmiApplyDefaultStatus_Click);
            // 
            // tsmiGenreAdd
            // 
            this.tsmiGenreAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGenreAdd.Image = global::GamesList.Properties.Resources.IconPlus;
            this.tsmiGenreAdd.Name = "tsmiGenreAdd";
            this.tsmiGenreAdd.Size = new System.Drawing.Size(28, 20);
            this.tsmiGenreAdd.Text = "Добавить";
            this.tsmiGenreAdd.Click += new System.EventHandler(this.tsmiGenreAdd_Click);
            // 
            // tsmiGenreDelete
            // 
            this.tsmiGenreDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGenreDelete.Image = global::GamesList.Properties.Resources.action_delete_sharp_thick;
            this.tsmiGenreDelete.Name = "tsmiGenreDelete";
            this.tsmiGenreDelete.Size = new System.Drawing.Size(28, 20);
            this.tsmiGenreDelete.Text = "Удалить";
            this.tsmiGenreDelete.Click += new System.EventHandler(this.tsmiGenreDelete_Click);
            // 
            // FormGame
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(672, 441);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tcGame);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.msBundles;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Игра";
            this.tcGame.ResumeLayout(false);
            this.tpBundles.ResumeLayout(false);
            this.tpBundles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBundles)).EndInit();
            this.msBundles.ResumeLayout(false);
            this.msBundles.PerformLayout();
            this.tpPlatforms.ResumeLayout(false);
            this.tpPlatforms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).EndInit();
            this.msPlatforms.ResumeLayout(false);
            this.msPlatforms.PerformLayout();
            this.tpGenres.ResumeLayout(false);
            this.tpGenres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.msGenres.ResumeLayout(false);
            this.msGenres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tcGame;
        private System.Windows.Forms.TabPage tpBundles;
        private System.Windows.Forms.TabPage tpPlatforms;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TabPage tpGenres;
        private System.Windows.Forms.DataGridView dgvBundles;
        private System.Windows.Forms.MenuStrip msBundles;
        private System.Windows.Forms.ToolStripMenuItem tsmiBundleAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiBundleDelete;
        private System.Windows.Forms.DataGridView dgvPlatforms;
        private System.Windows.Forms.MenuStrip msPlatforms;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformDelete;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.MenuStrip msGenres;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenreAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenreDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBundleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPlatformHave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatformStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlatformDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplyDefaultStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
    }
}