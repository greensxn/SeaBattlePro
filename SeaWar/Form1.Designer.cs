namespace SeaWar_GameForm {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbMyCount1Ship = new System.Windows.Forms.Label();
            this.lbMyCount2Ship = new System.Windows.Forms.Label();
            this.lbMyCount3Ship = new System.Windows.Forms.Label();
            this.lbMyCount4Ship = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.lbEnemyCount1Ship = new System.Windows.Forms.Label();
            this.lbEnemyCount2Ship = new System.Windows.Forms.Label();
            this.lbEnemyCount3Ship = new System.Windows.Forms.Label();
            this.lbEnemyCount4Ship = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHint = new System.Windows.Forms.ToolStripMenuItem();
            this.tAI = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmartFinishShip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTurn = new System.Windows.Forms.Label();
            this.pbSearchShip = new System.Windows.Forms.PictureBox();
            this.lbMyTotal = new System.Windows.Forms.Label();
            this.lbEnemyTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnRandShips = new System.Windows.Forms.Button();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchShip)).BeginInit();
            this.panel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMyCount1Ship
            // 
            this.lbMyCount1Ship.AutoSize = true;
            this.lbMyCount1Ship.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbMyCount1Ship.Location = new System.Drawing.Point(86, 632);
            this.lbMyCount1Ship.Name = "lbMyCount1Ship";
            this.lbMyCount1Ship.Size = new System.Drawing.Size(76, 34);
            this.lbMyCount1Ship.TabIndex = 1;
            this.lbMyCount1Ship.Text = "Score";
            // 
            // lbMyCount2Ship
            // 
            this.lbMyCount2Ship.AutoSize = true;
            this.lbMyCount2Ship.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbMyCount2Ship.Location = new System.Drawing.Point(116, 676);
            this.lbMyCount2Ship.Name = "lbMyCount2Ship";
            this.lbMyCount2Ship.Size = new System.Drawing.Size(76, 34);
            this.lbMyCount2Ship.TabIndex = 1;
            this.lbMyCount2Ship.Text = "Score";
            // 
            // lbMyCount3Ship
            // 
            this.lbMyCount3Ship.AutoSize = true;
            this.lbMyCount3Ship.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbMyCount3Ship.Location = new System.Drawing.Point(149, 720);
            this.lbMyCount3Ship.Name = "lbMyCount3Ship";
            this.lbMyCount3Ship.Size = new System.Drawing.Size(76, 34);
            this.lbMyCount3Ship.TabIndex = 1;
            this.lbMyCount3Ship.Text = "Score";
            // 
            // lbMyCount4Ship
            // 
            this.lbMyCount4Ship.AutoSize = true;
            this.lbMyCount4Ship.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbMyCount4Ship.Location = new System.Drawing.Point(182, 764);
            this.lbMyCount4Ship.Name = "lbMyCount4Ship";
            this.lbMyCount4Ship.Size = new System.Drawing.Size(76, 34);
            this.lbMyCount4Ship.TabIndex = 1;
            this.lbMyCount4Ship.Text = "Score";
            // 
            // btnReady
            // 
            this.btnReady.Enabled = false;
            this.btnReady.Font = new System.Drawing.Font("Bradley Hand ITC", 16F);
            this.btnReady.Location = new System.Drawing.Point(498, 748);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(175, 42);
            this.btnReady.TabIndex = 2;
            this.btnReady.Text = "Start Battle";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.StartBattle_Click);
            this.btnReady.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On_KeyDown);
            // 
            // lbEnemyCount1Ship
            // 
            this.lbEnemyCount1Ship.AutoSize = true;
            this.lbEnemyCount1Ship.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbEnemyCount1Ship.Location = new System.Drawing.Point(1029, 632);
            this.lbEnemyCount1Ship.Name = "lbEnemyCount1Ship";
            this.lbEnemyCount1Ship.Size = new System.Drawing.Size(76, 34);
            this.lbEnemyCount1Ship.TabIndex = 1;
            this.lbEnemyCount1Ship.Text = "Score";
            // 
            // lbEnemyCount2Ship
            // 
            this.lbEnemyCount2Ship.AutoSize = true;
            this.lbEnemyCount2Ship.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbEnemyCount2Ship.Location = new System.Drawing.Point(999, 676);
            this.lbEnemyCount2Ship.Name = "lbEnemyCount2Ship";
            this.lbEnemyCount2Ship.Size = new System.Drawing.Size(76, 34);
            this.lbEnemyCount2Ship.TabIndex = 1;
            this.lbEnemyCount2Ship.Text = "Score";
            // 
            // lbEnemyCount3Ship
            // 
            this.lbEnemyCount3Ship.AutoSize = true;
            this.lbEnemyCount3Ship.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbEnemyCount3Ship.Location = new System.Drawing.Point(966, 720);
            this.lbEnemyCount3Ship.Name = "lbEnemyCount3Ship";
            this.lbEnemyCount3Ship.Size = new System.Drawing.Size(76, 34);
            this.lbEnemyCount3Ship.TabIndex = 1;
            this.lbEnemyCount3Ship.Text = "Score";
            // 
            // lbEnemyCount4Ship
            // 
            this.lbEnemyCount4Ship.AutoSize = true;
            this.lbEnemyCount4Ship.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbEnemyCount4Ship.Location = new System.Drawing.Point(933, 764);
            this.lbEnemyCount4Ship.Name = "lbEnemyCount4Ship";
            this.lbEnemyCount4Ship.Size = new System.Drawing.Size(76, 34);
            this.lbEnemyCount4Ship.TabIndex = 1;
            this.lbEnemyCount4Ship.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 24F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(219, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "My field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 24F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(806, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enemy field";
            // 
            // lbNewGame
            // 
            this.lbNewGame.Name = "lbNewGame";
            this.lbNewGame.Size = new System.Drawing.Size(77, 20);
            this.lbNewGame.Text = "New Game";
            this.lbNewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.lbNewGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1474, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On_KeyDown);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHint,
            this.tAI,
            this.tSmartFinishShip,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tHint
            // 
            this.tHint.Checked = true;
            this.tHint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tHint.Name = "tHint";
            this.tHint.Size = new System.Drawing.Size(182, 22);
            this.tHint.Text = "Hint";
            this.tHint.Click += new System.EventHandler(this.HintToolStripMenuItem_Click);
            // 
            // tAI
            // 
            this.tAI.Checked = true;
            this.tAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tAI.Name = "tAI";
            this.tAI.Size = new System.Drawing.Size(182, 22);
            this.tAI.Text = "Artificial Intelligence";
            this.tAI.Click += new System.EventHandler(this.ArtificialIntelligence_Click);
            // 
            // tSmartFinishShip
            // 
            this.tSmartFinishShip.Checked = true;
            this.tSmartFinishShip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tSmartFinishShip.Name = "tSmartFinishShip";
            this.tSmartFinishShip.Size = new System.Drawing.Size(182, 22);
            this.tSmartFinishShip.Text = "Smart Finish Ship";
            this.tSmartFinishShip.Click += new System.EventHandler(this.SmartEnemyShot_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lbTurn
            // 
            this.lbTurn.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbTurn.Location = new System.Drawing.Point(498, 707);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(175, 47);
            this.lbTurn.TabIndex = 1;
            this.lbTurn.Text = "Turn";
            this.lbTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTurn.Visible = false;
            // 
            // pbSearchShip
            // 
            this.pbSearchShip.BackColor = System.Drawing.SystemColors.Control;
            this.pbSearchShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSearchShip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchShip.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchShip.Image")));
            this.pbSearchShip.InitialImage = null;
            this.pbSearchShip.Location = new System.Drawing.Point(541, 656);
            this.pbSearchShip.Margin = new System.Windows.Forms.Padding(0);
            this.pbSearchShip.Name = "pbSearchShip";
            this.pbSearchShip.Size = new System.Drawing.Size(86, 40);
            this.pbSearchShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchShip.TabIndex = 3;
            this.pbSearchShip.TabStop = false;
            this.pbSearchShip.Visible = false;
            this.pbSearchShip.Click += new System.EventHandler(this.PbSearchShip_Click);
            // 
            // lbMyTotal
            // 
            this.lbMyTotal.AutoSize = true;
            this.lbMyTotal.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbMyTotal.Location = new System.Drawing.Point(44, 804);
            this.lbMyTotal.Name = "lbMyTotal";
            this.lbMyTotal.Size = new System.Drawing.Size(76, 34);
            this.lbMyTotal.TabIndex = 1;
            this.lbMyTotal.Text = "Score";
            // 
            // lbEnemyTotal
            // 
            this.lbEnemyTotal.AutoSize = true;
            this.lbEnemyTotal.Font = new System.Drawing.Font("Bradley Hand ITC", 20F);
            this.lbEnemyTotal.Location = new System.Drawing.Point(991, 804);
            this.lbEnemyTotal.Name = "lbEnemyTotal";
            this.lbEnemyTotal.Size = new System.Drawing.Size(76, 34);
            this.lbEnemyTotal.TabIndex = 1;
            this.lbEnemyTotal.Text = "Score";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(50, 633);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(50, 677);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.ForeColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(50, 721);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 30);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.AliceBlue;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel8.ForeColor = System.Drawing.Color.Red;
            this.panel8.Location = new System.Drawing.Point(50, 765);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 30);
            this.panel8.TabIndex = 4;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(83, 677);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AliceBlue;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Location = new System.Drawing.Point(83, 721);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 30);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.AliceBlue;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Location = new System.Drawing.Point(116, 721);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 30);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.AliceBlue;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel7.Location = new System.Drawing.Point(83, 765);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 30);
            this.panel7.TabIndex = 4;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.AliceBlue;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel9.Location = new System.Drawing.Point(116, 765);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(30, 30);
            this.panel9.TabIndex = 4;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.AliceBlue;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel10.Location = new System.Drawing.Point(149, 765);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 30);
            this.panel10.TabIndex = 4;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.AliceBlue;
            this.panel11.Location = new System.Drawing.Point(1093, 633);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(30, 30);
            this.panel11.TabIndex = 4;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.AliceBlue;
            this.panel12.Location = new System.Drawing.Point(1093, 677);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(30, 30);
            this.panel12.TabIndex = 4;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.AliceBlue;
            this.panel13.Location = new System.Drawing.Point(1060, 677);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(30, 30);
            this.panel13.TabIndex = 4;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.AliceBlue;
            this.panel14.Location = new System.Drawing.Point(1060, 721);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(30, 30);
            this.panel14.TabIndex = 4;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.AliceBlue;
            this.panel15.Location = new System.Drawing.Point(1027, 721);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(30, 30);
            this.panel15.TabIndex = 4;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.AliceBlue;
            this.panel16.Location = new System.Drawing.Point(1093, 721);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(30, 30);
            this.panel16.TabIndex = 4;
            this.panel16.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.AliceBlue;
            this.panel17.Location = new System.Drawing.Point(1093, 765);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(30, 30);
            this.panel17.TabIndex = 4;
            this.panel17.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.AliceBlue;
            this.panel18.Location = new System.Drawing.Point(1060, 765);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(30, 30);
            this.panel18.TabIndex = 4;
            this.panel18.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.AliceBlue;
            this.panel19.Location = new System.Drawing.Point(1027, 765);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(30, 30);
            this.panel19.TabIndex = 4;
            this.panel19.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.AliceBlue;
            this.panel20.Location = new System.Drawing.Point(994, 765);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(30, 30);
            this.panel20.TabIndex = 4;
            this.panel20.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // btnRandShips
            // 
            this.btnRandShips.Font = new System.Drawing.Font("Bradley Hand ITC", 16F);
            this.btnRandShips.Location = new System.Drawing.Point(318, 611);
            this.btnRandShips.Name = "btnRandShips";
            this.btnRandShips.Size = new System.Drawing.Size(200, 42);
            this.btnRandShips.TabIndex = 2;
            this.btnRandShips.TabStop = false;
            this.btnRandShips.Text = "Random ships";
            this.btnRandShips.UseVisualStyleBackColor = true;
            this.btnRandShips.Click += new System.EventHandler(this.RandomMyShips_Click);
            this.btnRandShips.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On_KeyDown);
            // 
            // listHistory
            // 
            this.listHistory.BackColor = System.Drawing.Color.Gainsboro;
            this.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHistory.Font = new System.Drawing.Font("Bradley Hand ITC", 18F);
            this.listHistory.FormattingEnabled = true;
            this.listHistory.ItemHeight = 30;
            this.listHistory.Location = new System.Drawing.Point(22, 20);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(245, 660);
            this.listHistory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bradley Hand ITC", 24F);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(1169, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "History of moves";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Gainsboro;
            this.panel21.Controls.Add(this.listHistory);
            this.panel21.Location = new System.Drawing.Point(1176, 88);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(270, 710);
            this.panel21.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 849);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSearchShip);
            this.Controls.Add(this.btnRandShips);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.lbEnemyCount4Ship);
            this.Controls.Add(this.lbMyCount4Ship);
            this.Controls.Add(this.lbEnemyCount3Ship);
            this.Controls.Add(this.lbMyCount3Ship);
            this.Controls.Add(this.lbEnemyCount2Ship);
            this.Controls.Add(this.lbMyCount2Ship);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.lbEnemyCount1Ship);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEnemyTotal);
            this.Controls.Add(this.lbMyTotal);
            this.Controls.Add(this.lbMyCount1Ship);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sea Battle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.On_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchShip)).EndInit();
            this.panel21.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMyCount1Ship;
        private System.Windows.Forms.Label lbMyCount2Ship;
        private System.Windows.Forms.Label lbMyCount3Ship;
        private System.Windows.Forms.Label lbMyCount4Ship;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lbEnemyCount1Ship;
        private System.Windows.Forms.Label lbEnemyCount2Ship;
        private System.Windows.Forms.Label lbEnemyCount3Ship;
        private System.Windows.Forms.Label lbEnemyCount4Ship;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem lbNewGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAI;
        private System.Windows.Forms.ToolStripMenuItem tSmartFinishShip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbSearchShip;
        private System.Windows.Forms.Label lbMyTotal;
        private System.Windows.Forms.Label lbEnemyTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.ToolStripMenuItem tHint;
        private System.Windows.Forms.Button btnRandShips;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel21;
    }
}

