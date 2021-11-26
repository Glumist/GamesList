namespace GamesList.Forms
{
    partial class FormMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.colBundleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.msGroups = new System.Windows.Forms.MenuStrip();
            this.tscbGroup = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiGroupAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGroupEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGroupDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.colGameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameHave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGameReady = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGameStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGameNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGamesPlatforms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsGames = new System.Windows.Forms.ToolStrip();
            this.tsbGameAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbGameEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbGameDelete = new System.Windows.Forms.ToolStripButton();
            this.tssGameMove = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGameUp = new System.Windows.Forms.ToolStripButton();
            this.tsbGameDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGameExclusives = new System.Windows.Forms.ToolStripButton();
            this.tsbChosen = new System.Windows.Forms.ToolStripButton();
            this.tsbGameStarted = new System.Windows.Forms.ToolStripButton();
            this.tstbFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tslFilterIcon = new System.Windows.Forms.ToolStripLabel();
            this.tsbBuyList = new System.Windows.Forms.ToolStripButton();
            this.ssGames = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslGamesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslReadyGamesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pEmpty = new System.Windows.Forms.Panel();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pRight = new System.Windows.Forms.Panel();
            this.ucGame = new GamesList.Forms.UserControlGame();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.msGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            this.tsGames.SuspendLayout();
            this.ssGames.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.pRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AllowUserToResizeRows = false;
            this.dgvGroups.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.ColumnHeadersVisible = false;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBundleName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroups.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGroups.Location = new System.Drawing.Point(0, 39);
            this.dgvGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGroups.MultiSelect = false;
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(315, 848);
            this.dgvGroups.TabIndex = 1;
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.dgvGroups_SelectionChanged);
            // 
            // colBundleName
            // 
            this.colBundleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBundleName.DataPropertyName = "Name";
            this.colBundleName.HeaderText = "Название";
            this.colBundleName.Name = "colBundleName";
            this.colBundleName.ReadOnly = true;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart.Location = new System.Drawing.Point(0, 887);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(315, 305);
            this.chart.TabIndex = 2;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // msGroups
            // 
            this.msGroups.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbGroup,
            this.tsmiGroupAdd,
            this.tsmiGroupEdit,
            this.tsmiGroupDelete});
            this.msGroups.Location = new System.Drawing.Point(0, 0);
            this.msGroups.Name = "msGroups";
            this.msGroups.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msGroups.Size = new System.Drawing.Size(315, 39);
            this.msGroups.TabIndex = 0;
            this.msGroups.Text = "menuStrip1";
            // 
            // tscbGroup
            // 
            this.tscbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbGroup.Items.AddRange(new object[] {
            "Наборы",
            "Платформы",
            "Жанры"});
            this.tscbGroup.Name = "tscbGroup";
            this.tscbGroup.Size = new System.Drawing.Size(180, 33);
            this.tscbGroup.SelectedIndexChanged += new System.EventHandler(this.TscbGroup_SelectedIndexChanged);
            // 
            // tsmiGroupAdd
            // 
            this.tsmiGroupAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGroupAdd.Image = global::GamesList.Properties.Resources.IconPlus;
            this.tsmiGroupAdd.Name = "tsmiGroupAdd";
            this.tsmiGroupAdd.Size = new System.Drawing.Size(36, 33);
            this.tsmiGroupAdd.Text = "Добавить";
            this.tsmiGroupAdd.Click += new System.EventHandler(this.tsmiGroupAdd_Click);
            // 
            // tsmiGroupEdit
            // 
            this.tsmiGroupEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGroupEdit.Image = global::GamesList.Properties.Resources.IconEdit;
            this.tsmiGroupEdit.Name = "tsmiGroupEdit";
            this.tsmiGroupEdit.Size = new System.Drawing.Size(36, 33);
            this.tsmiGroupEdit.Text = "Редактировать";
            this.tsmiGroupEdit.Click += new System.EventHandler(this.tsmiGroupEdit_Click);
            // 
            // tsmiGroupDelete
            // 
            this.tsmiGroupDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGroupDelete.Image = global::GamesList.Properties.Resources.action_delete_sharp_thick;
            this.tsmiGroupDelete.Name = "tsmiGroupDelete";
            this.tsmiGroupDelete.Size = new System.Drawing.Size(36, 33);
            this.tsmiGroupDelete.Text = "Удалить";
            this.tsmiGroupDelete.Click += new System.EventHandler(this.tsmiGroupDelete_Click);
            // 
            // dgvGames
            // 
            this.dgvGames.AllowUserToAddRows = false;
            this.dgvGames.AllowUserToDeleteRows = false;
            this.dgvGames.AllowUserToResizeRows = false;
            this.dgvGames.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGameName,
            this.colGameDate,
            this.colGameHave,
            this.colGameReady,
            this.colGameStatus,
            this.colGameNumber,
            this.colGamesPlatforms});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGames.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGames.Location = new System.Drawing.Point(315, 31);
            this.dgvGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGames.MultiSelect = false;
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.RowHeadersVisible = false;
            this.dgvGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGames.Size = new System.Drawing.Size(1177, 1131);
            this.dgvGames.TabIndex = 0;
            this.dgvGames.SelectionChanged += new System.EventHandler(this.dgvGames_SelectionChanged);
            // 
            // colGameName
            // 
            this.colGameName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGameName.DataPropertyName = "Name";
            this.colGameName.HeaderText = "Название";
            this.colGameName.Name = "colGameName";
            this.colGameName.ReadOnly = true;
            // 
            // colGameDate
            // 
            this.colGameDate.DataPropertyName = "Date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGameDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colGameDate.HeaderText = "Дата";
            this.colGameDate.Name = "colGameDate";
            this.colGameDate.ReadOnly = true;
            // 
            // colGameHave
            // 
            this.colGameHave.DataPropertyName = "Have";
            this.colGameHave.HeaderText = "В наличии";
            this.colGameHave.Name = "colGameHave";
            this.colGameHave.ReadOnly = true;
            this.colGameHave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGameHave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGameHave.Width = 65;
            // 
            // colGameReady
            // 
            this.colGameReady.DataPropertyName = "Ready";
            this.colGameReady.HeaderText = "Готова";
            this.colGameReady.Name = "colGameReady";
            this.colGameReady.ReadOnly = true;
            this.colGameReady.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGameReady.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGameReady.Width = 50;
            // 
            // colGameStatus
            // 
            this.colGameStatus.DataPropertyName = "Status";
            this.colGameStatus.HeaderText = "Статус";
            this.colGameStatus.Name = "colGameStatus";
            this.colGameStatus.ReadOnly = true;
            this.colGameStatus.Width = 90;
            // 
            // colGameNumber
            // 
            this.colGameNumber.DataPropertyName = "Number";
            this.colGameNumber.HeaderText = "Номер";
            this.colGameNumber.Name = "colGameNumber";
            this.colGameNumber.ReadOnly = true;
            this.colGameNumber.Visible = false;
            this.colGameNumber.Width = 50;
            // 
            // colGamesPlatforms
            // 
            this.colGamesPlatforms.DataPropertyName = "PlatformsString";
            this.colGamesPlatforms.HeaderText = "Платформы";
            this.colGamesPlatforms.Name = "colGamesPlatforms";
            this.colGamesPlatforms.ReadOnly = true;
            this.colGamesPlatforms.Width = 150;
            // 
            // tsGames
            // 
            this.tsGames.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGames.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsGames.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGameAdd,
            this.tsbGameEdit,
            this.tsbGameDelete,
            this.tssGameMove,
            this.tsbGameUp,
            this.tsbGameDown,
            this.toolStripSeparator2,
            this.tsbGameExclusives,
            this.tsbChosen,
            this.tsbGameStarted,
            this.tstbFilter,
            this.tslFilterIcon,
            this.tsbBuyList});
            this.tsGames.Location = new System.Drawing.Point(315, 0);
            this.tsGames.Name = "tsGames";
            this.tsGames.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsGames.Size = new System.Drawing.Size(1177, 31);
            this.tsGames.TabIndex = 3;
            this.tsGames.Text = "toolStrip1";
            // 
            // tsbGameAdd
            // 
            this.tsbGameAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGameAdd.Image = global::GamesList.Properties.Resources.IconPlus;
            this.tsbGameAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGameAdd.Name = "tsbGameAdd";
            this.tsbGameAdd.Size = new System.Drawing.Size(28, 28);
            this.tsbGameAdd.Text = "Добавить";
            this.tsbGameAdd.Click += new System.EventHandler(this.tsbGameAdd_Click);
            // 
            // tsbGameEdit
            // 
            this.tsbGameEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGameEdit.Image = global::GamesList.Properties.Resources.IconEdit;
            this.tsbGameEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGameEdit.Name = "tsbGameEdit";
            this.tsbGameEdit.Size = new System.Drawing.Size(28, 28);
            this.tsbGameEdit.Text = "Редактировать";
            this.tsbGameEdit.Visible = false;
            this.tsbGameEdit.Click += new System.EventHandler(this.tsbGameEdit_Click);
            // 
            // tsbGameDelete
            // 
            this.tsbGameDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGameDelete.Image = global::GamesList.Properties.Resources.action_delete_sharp_thick;
            this.tsbGameDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGameDelete.Name = "tsbGameDelete";
            this.tsbGameDelete.Size = new System.Drawing.Size(28, 28);
            this.tsbGameDelete.Text = "Удалить";
            this.tsbGameDelete.Click += new System.EventHandler(this.tsbGameDelete_Click);
            // 
            // tssGameMove
            // 
            this.tssGameMove.Name = "tssGameMove";
            this.tssGameMove.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbGameUp
            // 
            this.tsbGameUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGameUp.Image = global::GamesList.Properties.Resources.IconUp;
            this.tsbGameUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGameUp.Name = "tsbGameUp";
            this.tsbGameUp.Size = new System.Drawing.Size(28, 28);
            this.tsbGameUp.Text = "Вверх";
            this.tsbGameUp.Click += new System.EventHandler(this.tsbGameUp_Click);
            // 
            // tsbGameDown
            // 
            this.tsbGameDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGameDown.Image = global::GamesList.Properties.Resources.IconDown;
            this.tsbGameDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGameDown.Name = "tsbGameDown";
            this.tsbGameDown.Size = new System.Drawing.Size(28, 28);
            this.tsbGameDown.Text = "Вниз";
            this.tsbGameDown.Click += new System.EventHandler(this.tsbGameDown_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbGameExclusives
            // 
            this.tsbGameExclusives.CheckOnClick = true;
            this.tsbGameExclusives.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGameExclusives.Image = global::GamesList.Properties.Resources.IconExclusive;
            this.tsbGameExclusives.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGameExclusives.Name = "tsbGameExclusives";
            this.tsbGameExclusives.Size = new System.Drawing.Size(28, 28);
            this.tsbGameExclusives.Text = "Эксклюзивы";
            this.tsbGameExclusives.CheckedChanged += new System.EventHandler(this.tsbExclusives_CheckedChanged);
            // 
            // tsbChosen
            // 
            this.tsbChosen.CheckOnClick = true;
            this.tsbChosen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChosen.Image = global::GamesList.Properties.Resources.IconThis;
            this.tsbChosen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChosen.Name = "tsbChosen";
            this.tsbChosen.Size = new System.Drawing.Size(28, 28);
            this.tsbChosen.Text = "Игры платформы";
            this.tsbChosen.Click += new System.EventHandler(this.tsbChosen_Click);
            // 
            // tsbGameStarted
            // 
            this.tsbGameStarted.CheckOnClick = true;
            this.tsbGameStarted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGameStarted.Image = global::GamesList.Properties.Resources.IconPlay;
            this.tsbGameStarted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGameStarted.Name = "tsbGameStarted";
            this.tsbGameStarted.Size = new System.Drawing.Size(28, 28);
            this.tsbGameStarted.Text = "Начатые";
            this.tsbGameStarted.CheckedChanged += new System.EventHandler(this.tsbGameStarted_CheckedChanged);
            // 
            // tstbFilter
            // 
            this.tstbFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbFilter.Name = "tstbFilter";
            this.tstbFilter.Size = new System.Drawing.Size(148, 31);
            this.tstbFilter.ToolTipText = "Фильтр";
            this.tstbFilter.TextChanged += new System.EventHandler(this.tstbFilter_TextChanged);
            // 
            // tslFilterIcon
            // 
            this.tslFilterIcon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslFilterIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslFilterIcon.Image = global::GamesList.Properties.Resources.IconFilter;
            this.tslFilterIcon.Name = "tslFilterIcon";
            this.tslFilterIcon.Size = new System.Drawing.Size(24, 28);
            this.tslFilterIcon.Text = "Фильтр";
            this.tslFilterIcon.ToolTipText = "Фильтр";
            // 
            // tsbBuyList
            // 
            this.tsbBuyList.CheckOnClick = true;
            this.tsbBuyList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuyList.Image = global::GamesList.Properties.Resources.IconCart;
            this.tsbBuyList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuyList.Name = "tsbBuyList";
            this.tsbBuyList.Size = new System.Drawing.Size(28, 28);
            this.tsbBuyList.Text = "Ожидают покупки";
            this.tsbBuyList.CheckedChanged += new System.EventHandler(this.tsbBuyList_CheckedChanged);
            // 
            // ssGames
            // 
            this.ssGames.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssGames.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslGamesCount,
            this.toolStripStatusLabel2,
            this.tsslReadyGamesCount});
            this.ssGames.Location = new System.Drawing.Point(315, 1162);
            this.ssGames.Name = "ssGames";
            this.ssGames.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ssGames.Size = new System.Drawing.Size(1177, 30);
            this.ssGames.SizingGrip = false;
            this.ssGames.TabIndex = 2;
            this.ssGames.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 25);
            this.toolStripStatusLabel1.Text = "Всего:";
            // 
            // tsslGamesCount
            // 
            this.tsslGamesCount.Name = "tsslGamesCount";
            this.tsslGamesCount.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 25);
            this.toolStripStatusLabel2.Text = "Готовых:";
            // 
            // tsslReadyGamesCount
            // 
            this.tsslReadyGamesCount.Name = "tsslReadyGamesCount";
            this.tsslReadyGamesCount.Size = new System.Drawing.Size(0, 25);
            // 
            // pEmpty
            // 
            this.pEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEmpty.Location = new System.Drawing.Point(0, 0);
            this.pEmpty.Name = "pEmpty";
            this.pEmpty.Size = new System.Drawing.Size(364, 1192);
            this.pEmpty.TabIndex = 1;
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.dgvGroups);
            this.pLeft.Controls.Add(this.msGroups);
            this.pLeft.Controls.Add(this.chart);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(315, 1192);
            this.pLeft.TabIndex = 2;
            // 
            // pRight
            // 
            this.pRight.Controls.Add(this.ucGame);
            this.pRight.Controls.Add(this.pEmpty);
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(1492, 0);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(364, 1192);
            this.pRight.TabIndex = 3;
            // 
            // ucGame
            // 
            this.ucGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGame.Location = new System.Drawing.Point(0, 0);
            this.ucGame.MinimumSize = new System.Drawing.Size(300, 0);
            this.ucGame.Name = "ucGame";
            this.ucGame.Size = new System.Drawing.Size(364, 1192);
            this.ucGame.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1856, 1192);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.ssGames);
            this.Controls.Add(this.tsGames);
            this.Controls.Add(this.pRight);
            this.Controls.Add(this.pLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msGroups;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Список игр";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.msGroups.ResumeLayout(false);
            this.msGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            this.tsGames.ResumeLayout(false);
            this.tsGames.PerformLayout();
            this.ssGames.ResumeLayout(false);
            this.ssGames.PerformLayout();
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            this.pRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBundleName;
        private System.Windows.Forms.MenuStrip msGroups;
        private System.Windows.Forms.ToolStripComboBox tscbGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiGroupAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiGroupEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiGroupDelete;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.StatusStrip ssGames;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslGamesCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslReadyGamesCount;
        private System.Windows.Forms.ToolStrip tsGames;
        private System.Windows.Forms.ToolStripButton tsbGameAdd;
        private System.Windows.Forms.ToolStripButton tsbGameEdit;
        private System.Windows.Forms.ToolStripButton tsbGameDelete;
        private System.Windows.Forms.ToolStripSeparator tssGameMove;
        private System.Windows.Forms.ToolStripButton tsbGameUp;
        private System.Windows.Forms.ToolStripButton tsbGameDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbGameExclusives;
        private System.Windows.Forms.ToolStripButton tsbGameStarted;
        private System.Windows.Forms.ToolStripTextBox tstbFilter;
        private System.Windows.Forms.ToolStripLabel tslFilterIcon;
        private System.Windows.Forms.ToolStripButton tsbBuyList;
        private System.Windows.Forms.ToolStripButton tsbChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGameHave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGameReady;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGameNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGamesPlatforms;
        private System.Windows.Forms.Panel pEmpty;
        private UserControlGame ucGame;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pRight;
    }
}

