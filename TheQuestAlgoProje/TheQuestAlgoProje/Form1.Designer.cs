namespace TheQuestAlgoProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AttackPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AttackPanelCaption = new System.Windows.Forms.Label();
            this.AttackUp = new System.Windows.Forms.Button();
            this.AttackLeft = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.AttackDown = new System.Windows.Forms.Button();
            this.MovePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MovePanelCaption = new System.Windows.Forms.Label();
            this.HitPointPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerHitPointsCaption = new System.Windows.Forms.Label();
            this.BatHitPointsCaption = new System.Windows.Forms.Label();
            this.GhostHitPointsCaption = new System.Windows.Forms.Label();
            this.GhoulHitPointsCaption = new System.Windows.Forms.Label();
            this.PlayerHitPoints = new System.Windows.Forms.Label();
            this.BatHitPoints = new System.Windows.Forms.Label();
            this.GhostHitPoints = new System.Windows.Forms.Label();
            this.GhoulHitPoints = new System.Windows.Forms.Label();
            this.PlayerSprite = new System.Windows.Forms.PictureBox();
            this.BowSprite = new System.Windows.Forms.PictureBox();
            this.GhostSprite = new System.Windows.Forms.PictureBox();
            this.GhoulSprite = new System.Windows.Forms.PictureBox();
            this.MaceSprite = new System.Windows.Forms.PictureBox();
            this.SwordSprite = new System.Windows.Forms.PictureBox();
            this.BatSprite = new System.Windows.Forms.PictureBox();
            this.RedPotionSprite = new System.Windows.Forms.PictureBox();
            this.BluePotionSprite = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BowInvSprite = new System.Windows.Forms.PictureBox();
            this.MaceInvSprite = new System.Windows.Forms.PictureBox();
            this.SwordInvSprite = new System.Windows.Forms.PictureBox();
            this.BluePotionInvSprite = new System.Windows.Forms.PictureBox();
            this.RedPotionInvSprite = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Minute = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AttackPanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.HitPointPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInvSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // AttackPanel
            // 
            this.AttackPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AttackPanel.ColumnCount = 2;
            this.AttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttackPanel.Controls.Add(this.AttackPanelCaption, 0, 0);
            this.AttackPanel.Controls.Add(this.AttackUp, 0, 1);
            this.AttackPanel.Controls.Add(this.AttackLeft, 0, 2);
            this.AttackPanel.Controls.Add(this.AttackRight, 1, 2);
            this.AttackPanel.Controls.Add(this.AttackDown, 0, 3);
            this.AttackPanel.Location = new System.Drawing.Point(896, 266);
            this.AttackPanel.Name = "AttackPanel";
            this.AttackPanel.RowCount = 4;
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.Size = new System.Drawing.Size(178, 172);
            this.AttackPanel.TabIndex = 18;
            // 
            // AttackPanelCaption
            // 
            this.AttackPanelCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AttackPanelCaption.AutoSize = true;
            this.AttackPanelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackPanelCaption.Location = new System.Drawing.Point(3, 9);
            this.AttackPanelCaption.Name = "AttackPanelCaption";
            this.AttackPanelCaption.Size = new System.Drawing.Size(55, 18);
            this.AttackPanelCaption.TabIndex = 0;
            this.AttackPanelCaption.Text = "Attack";
            // 
            // AttackUp
            // 
            this.AttackUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackPanel.SetColumnSpan(this.AttackUp, 2);
            this.AttackUp.Location = new System.Drawing.Point(58, 47);
            this.AttackUp.Name = "AttackUp";
            this.AttackUp.Size = new System.Drawing.Size(61, 24);
            this.AttackUp.TabIndex = 1;
            this.AttackUp.Text = "U";
            this.AttackUp.UseVisualStyleBackColor = true;
            this.AttackUp.Click += new System.EventHandler(this.AttackUp_Click);
            // 
            // AttackLeft
            // 
            this.AttackLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackLeft.Location = new System.Drawing.Point(14, 91);
            this.AttackLeft.Name = "AttackLeft";
            this.AttackLeft.Size = new System.Drawing.Size(61, 24);
            this.AttackLeft.TabIndex = 2;
            this.AttackLeft.Text = "H";
            this.AttackLeft.UseVisualStyleBackColor = true;
            this.AttackLeft.Click += new System.EventHandler(this.AttackLeft_Click);
            // 
            // AttackRight
            // 
            this.AttackRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackRight.Location = new System.Drawing.Point(103, 91);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(61, 24);
            this.AttackRight.TabIndex = 3;
            this.AttackRight.Text = "K";
            this.AttackRight.UseVisualStyleBackColor = true;
            this.AttackRight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // AttackDown
            // 
            this.AttackDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackPanel.SetColumnSpan(this.AttackDown, 2);
            this.AttackDown.Location = new System.Drawing.Point(58, 136);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(61, 24);
            this.AttackDown.TabIndex = 4;
            this.AttackDown.Text = "J";
            this.AttackDown.UseVisualStyleBackColor = true;
            this.AttackDown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MovePanel.ColumnCount = 2;
            this.MovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MovePanel.Controls.Add(this.MoveUp, 0, 1);
            this.MovePanel.Controls.Add(this.MoveLeft, 0, 2);
            this.MovePanel.Controls.Add(this.MoveRight, 1, 2);
            this.MovePanel.Controls.Add(this.MoveDown, 0, 3);
            this.MovePanel.Controls.Add(this.MovePanelCaption, 0, 0);
            this.MovePanel.Location = new System.Drawing.Point(896, 73);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.RowCount = 4;
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.MovePanel.Size = new System.Drawing.Size(178, 178);
            this.MovePanel.TabIndex = 17;
            // 
            // MoveUp
            // 
            this.MoveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovePanel.SetColumnSpan(this.MoveUp, 2);
            this.MoveUp.Location = new System.Drawing.Point(58, 50);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(61, 24);
            this.MoveUp.TabIndex = 0;
            this.MoveUp.Text = "W";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveLeft.Location = new System.Drawing.Point(14, 96);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(61, 24);
            this.MoveLeft.TabIndex = 1;
            this.MoveLeft.Text = "A";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveRight.Location = new System.Drawing.Point(103, 96);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(61, 24);
            this.MoveRight.TabIndex = 2;
            this.MoveRight.Text = "D";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovePanel.SetColumnSpan(this.MoveDown, 2);
            this.MoveDown.Location = new System.Drawing.Point(58, 142);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(61, 24);
            this.MoveDown.TabIndex = 3;
            this.MoveDown.Text = "S";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // MovePanelCaption
            // 
            this.MovePanelCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MovePanelCaption.AutoSize = true;
            this.MovePanelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovePanelCaption.Location = new System.Drawing.Point(3, 10);
            this.MovePanelCaption.Name = "MovePanelCaption";
            this.MovePanelCaption.Size = new System.Drawing.Size(49, 18);
            this.MovePanelCaption.TabIndex = 4;
            this.MovePanelCaption.Text = "Move";
            // 
            // HitPointPanel
            // 
            this.HitPointPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HitPointPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HitPointPanel.ColumnCount = 2;
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.HitPointPanel.Controls.Add(this.PlayerHitPointsCaption, 0, 0);
            this.HitPointPanel.Controls.Add(this.BatHitPointsCaption, 0, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPointsCaption, 0, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPointsCaption, 0, 3);
            this.HitPointPanel.Controls.Add(this.PlayerHitPoints, 1, 0);
            this.HitPointPanel.Controls.Add(this.BatHitPoints, 1, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPoints, 1, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPoints, 1, 3);
            this.HitPointPanel.Location = new System.Drawing.Point(896, 484);
            this.HitPointPanel.Name = "HitPointPanel";
            this.HitPointPanel.RowCount = 4;
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.Size = new System.Drawing.Size(178, 134);
            this.HitPointPanel.TabIndex = 19;
            // 
            // PlayerHitPointsCaption
            // 
            this.PlayerHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPointsCaption.AutoSize = true;
            this.PlayerHitPointsCaption.Location = new System.Drawing.Point(4, 10);
            this.PlayerHitPointsCaption.Name = "PlayerHitPointsCaption";
            this.PlayerHitPointsCaption.Size = new System.Drawing.Size(36, 13);
            this.PlayerHitPointsCaption.TabIndex = 0;
            this.PlayerHitPointsCaption.Text = "Player";
            // 
            // BatHitPointsCaption
            // 
            this.BatHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPointsCaption.AutoSize = true;
            this.BatHitPointsCaption.Location = new System.Drawing.Point(4, 43);
            this.BatHitPointsCaption.Name = "BatHitPointsCaption";
            this.BatHitPointsCaption.Size = new System.Drawing.Size(23, 13);
            this.BatHitPointsCaption.TabIndex = 1;
            this.BatHitPointsCaption.Text = "Bat";
            // 
            // GhostHitPointsCaption
            // 
            this.GhostHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPointsCaption.AutoSize = true;
            this.GhostHitPointsCaption.Location = new System.Drawing.Point(4, 76);
            this.GhostHitPointsCaption.Name = "GhostHitPointsCaption";
            this.GhostHitPointsCaption.Size = new System.Drawing.Size(35, 13);
            this.GhostHitPointsCaption.TabIndex = 2;
            this.GhostHitPointsCaption.Text = "Ghost";
            // 
            // GhoulHitPointsCaption
            // 
            this.GhoulHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPointsCaption.AutoSize = true;
            this.GhoulHitPointsCaption.Location = new System.Drawing.Point(4, 110);
            this.GhoulHitPointsCaption.Name = "GhoulHitPointsCaption";
            this.GhoulHitPointsCaption.Size = new System.Drawing.Size(35, 13);
            this.GhoulHitPointsCaption.TabIndex = 3;
            this.GhoulHitPointsCaption.Text = "Ghoul";
            // 
            // PlayerHitPoints
            // 
            this.PlayerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPoints.AutoSize = true;
            this.PlayerHitPoints.Location = new System.Drawing.Point(64, 10);
            this.PlayerHitPoints.Name = "PlayerHitPoints";
            this.PlayerHitPoints.Size = new System.Drawing.Size(78, 13);
            this.PlayerHitPoints.TabIndex = 4;
            this.PlayerHitPoints.Text = "PlayerHitPoints";
            // 
            // BatHitPoints
            // 
            this.BatHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPoints.AutoSize = true;
            this.BatHitPoints.Location = new System.Drawing.Point(64, 43);
            this.BatHitPoints.Name = "BatHitPoints";
            this.BatHitPoints.Size = new System.Drawing.Size(65, 13);
            this.BatHitPoints.TabIndex = 5;
            this.BatHitPoints.Text = "BatHitPoints";
            // 
            // GhostHitPoints
            // 
            this.GhostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPoints.AutoSize = true;
            this.GhostHitPoints.Location = new System.Drawing.Point(64, 76);
            this.GhostHitPoints.Name = "GhostHitPoints";
            this.GhostHitPoints.Size = new System.Drawing.Size(77, 13);
            this.GhostHitPoints.TabIndex = 6;
            this.GhostHitPoints.Text = "GhostHitPoints";
            // 
            // GhoulHitPoints
            // 
            this.GhoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPoints.AutoSize = true;
            this.GhoulHitPoints.Location = new System.Drawing.Point(64, 110);
            this.GhoulHitPoints.Name = "GhoulHitPoints";
            this.GhoulHitPoints.Size = new System.Drawing.Size(77, 13);
            this.GhoulHitPoints.TabIndex = 7;
            this.GhoulHitPoints.Text = "GhoulHitPoints";
            // 
            // PlayerSprite
            // 
            this.PlayerSprite.BackColor = System.Drawing.Color.Transparent;
            this.PlayerSprite.Image = global::TheQuestAlgoProje.Properties.Resources.player;
            this.PlayerSprite.Location = new System.Drawing.Point(50, 82);
            this.PlayerSprite.Name = "PlayerSprite";
            this.PlayerSprite.Size = new System.Drawing.Size(52, 49);
            this.PlayerSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerSprite.TabIndex = 20;
            this.PlayerSprite.TabStop = false;
            // 
            // BowSprite
            // 
            this.BowSprite.BackColor = System.Drawing.Color.Transparent;
            this.BowSprite.Image = global::TheQuestAlgoProje.Properties.Resources.okyay;
            this.BowSprite.Location = new System.Drawing.Point(437, 82);
            this.BowSprite.Name = "BowSprite";
            this.BowSprite.Size = new System.Drawing.Size(52, 49);
            this.BowSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BowSprite.TabIndex = 21;
            this.BowSprite.TabStop = false;
            this.BowSprite.Visible = false;
            // 
            // GhostSprite
            // 
            this.GhostSprite.BackColor = System.Drawing.Color.Transparent;
            this.GhostSprite.Image = global::TheQuestAlgoProje.Properties.Resources.hayalet2;
            this.GhostSprite.Location = new System.Drawing.Point(351, 82);
            this.GhostSprite.Name = "GhostSprite";
            this.GhostSprite.Size = new System.Drawing.Size(52, 49);
            this.GhostSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GhostSprite.TabIndex = 22;
            this.GhostSprite.TabStop = false;
            this.GhostSprite.Visible = false;
            // 
            // GhoulSprite
            // 
            this.GhoulSprite.BackColor = System.Drawing.Color.Transparent;
            this.GhoulSprite.Image = global::TheQuestAlgoProje.Properties.Resources.ghoul;
            this.GhoulSprite.Location = new System.Drawing.Point(276, 82);
            this.GhoulSprite.Name = "GhoulSprite";
            this.GhoulSprite.Size = new System.Drawing.Size(52, 49);
            this.GhoulSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GhoulSprite.TabIndex = 23;
            this.GhoulSprite.TabStop = false;
            this.GhoulSprite.Visible = false;
            // 
            // MaceSprite
            // 
            this.MaceSprite.BackColor = System.Drawing.Color.Transparent;
            this.MaceSprite.Image = global::TheQuestAlgoProje.Properties.Resources.mace;
            this.MaceSprite.Location = new System.Drawing.Point(670, 83);
            this.MaceSprite.Name = "MaceSprite";
            this.MaceSprite.Size = new System.Drawing.Size(52, 49);
            this.MaceSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaceSprite.TabIndex = 24;
            this.MaceSprite.TabStop = false;
            this.MaceSprite.Visible = false;
            // 
            // SwordSprite
            // 
            this.SwordSprite.BackColor = System.Drawing.Color.Transparent;
            this.SwordSprite.Image = global::TheQuestAlgoProje.Properties.Resources.kılıç3;
            this.SwordSprite.Location = new System.Drawing.Point(119, 84);
            this.SwordSprite.Name = "SwordSprite";
            this.SwordSprite.Size = new System.Drawing.Size(52, 49);
            this.SwordSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwordSprite.TabIndex = 25;
            this.SwordSprite.TabStop = false;
            this.SwordSprite.Visible = false;
            // 
            // BatSprite
            // 
            this.BatSprite.BackColor = System.Drawing.Color.Transparent;
            this.BatSprite.Image = global::TheQuestAlgoProje.Properties.Resources.yarasa1;
            this.BatSprite.Location = new System.Drawing.Point(194, 84);
            this.BatSprite.Name = "BatSprite";
            this.BatSprite.Size = new System.Drawing.Size(52, 49);
            this.BatSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatSprite.TabIndex = 26;
            this.BatSprite.TabStop = false;
            this.BatSprite.Visible = false;
            // 
            // RedPotionSprite
            // 
            this.RedPotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionSprite.Image = global::TheQuestAlgoProje.Properties.Resources.potion_red;
            this.RedPotionSprite.Location = new System.Drawing.Point(510, 83);
            this.RedPotionSprite.Name = "RedPotionSprite";
            this.RedPotionSprite.Size = new System.Drawing.Size(52, 49);
            this.RedPotionSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPotionSprite.TabIndex = 27;
            this.RedPotionSprite.TabStop = false;
            this.RedPotionSprite.Visible = false;
            // 
            // BluePotionSprite
            // 
            this.BluePotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionSprite.Image = global::TheQuestAlgoProje.Properties.Resources.potion_blue;
            this.BluePotionSprite.Location = new System.Drawing.Point(590, 82);
            this.BluePotionSprite.Name = "BluePotionSprite";
            this.BluePotionSprite.Size = new System.Drawing.Size(52, 49);
            this.BluePotionSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluePotionSprite.TabIndex = 28;
            this.BluePotionSprite.TabStop = false;
            this.BluePotionSprite.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(896, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Health";
            // 
            // BowInvSprite
            // 
            this.BowInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.BowInvSprite.Image = global::TheQuestAlgoProje.Properties.Resources.okyay;
            this.BowInvSprite.Location = new System.Drawing.Point(311, 568);
            this.BowInvSprite.Name = "BowInvSprite";
            this.BowInvSprite.Size = new System.Drawing.Size(64, 50);
            this.BowInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BowInvSprite.TabIndex = 30;
            this.BowInvSprite.TabStop = false;
            this.BowInvSprite.Visible = false;
            this.BowInvSprite.Click += new System.EventHandler(this.BowInvSprite_Click);
            // 
            // MaceInvSprite
            // 
            this.MaceInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.MaceInvSprite.Image = global::TheQuestAlgoProje.Properties.Resources.mace;
            this.MaceInvSprite.Location = new System.Drawing.Point(381, 568);
            this.MaceInvSprite.Name = "MaceInvSprite";
            this.MaceInvSprite.Size = new System.Drawing.Size(64, 50);
            this.MaceInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaceInvSprite.TabIndex = 31;
            this.MaceInvSprite.TabStop = false;
            this.MaceInvSprite.Visible = false;
            this.MaceInvSprite.Click += new System.EventHandler(this.MaceInvSprite_Click);
            // 
            // SwordInvSprite
            // 
            this.SwordInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.SwordInvSprite.Image = global::TheQuestAlgoProje.Properties.Resources.kılıç3;
            this.SwordInvSprite.Location = new System.Drawing.Point(227, 568);
            this.SwordInvSprite.Name = "SwordInvSprite";
            this.SwordInvSprite.Size = new System.Drawing.Size(64, 50);
            this.SwordInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwordInvSprite.TabIndex = 32;
            this.SwordInvSprite.TabStop = false;
            this.SwordInvSprite.Visible = false;
            this.SwordInvSprite.Click += new System.EventHandler(this.SwordInvSprite_Click);
            // 
            // BluePotionInvSprite
            // 
            this.BluePotionInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionInvSprite.Image = global::TheQuestAlgoProje.Properties.Resources.potion_blue;
            this.BluePotionInvSprite.Location = new System.Drawing.Point(510, 568);
            this.BluePotionInvSprite.Name = "BluePotionInvSprite";
            this.BluePotionInvSprite.Size = new System.Drawing.Size(64, 50);
            this.BluePotionInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluePotionInvSprite.TabIndex = 33;
            this.BluePotionInvSprite.TabStop = false;
            this.BluePotionInvSprite.Visible = false;
            this.BluePotionInvSprite.Click += new System.EventHandler(this.BluePotionInvSprite_Click);
            // 
            // RedPotionInvSprite
            // 
            this.RedPotionInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionInvSprite.Image = global::TheQuestAlgoProje.Properties.Resources.potion_red;
            this.RedPotionInvSprite.Location = new System.Drawing.Point(580, 569);
            this.RedPotionInvSprite.Name = "RedPotionInvSprite";
            this.RedPotionInvSprite.Size = new System.Drawing.Size(64, 50);
            this.RedPotionInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPotionInvSprite.TabIndex = 34;
            this.RedPotionInvSprite.TabStop = false;
            this.RedPotionInvSprite.Visible = false;
            this.RedPotionInvSprite.Click += new System.EventHandler(this.RedPotionInvSprite_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(159, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Weapon";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(451, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Potion";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 39);
            this.label4.TabIndex = 37;
            this.label4.Text = "Inventory";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Minute
            // 
            this.Minute.BackColor = System.Drawing.Color.Transparent;
            this.Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Minute.Location = new System.Drawing.Point(712, 579);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(55, 54);
            this.Minute.TabIndex = 38;
            this.Minute.Text = "00";
            // 
            // Second
            // 
            this.Second.BackColor = System.Drawing.Color.Transparent;
            this.Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Second.Location = new System.Drawing.Point(788, 579);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(54, 54);
            this.Second.TabIndex = 39;
            this.Second.Text = "00";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(764, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 58);
            this.label7.TabIndex = 40;
            this.label7.Text = ":";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(644, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Timer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(791, 609);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Second";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(715, 609);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Minute";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuestAlgoProje.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1099, 631);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RedPotionInvSprite);
            this.Controls.Add(this.BluePotionInvSprite);
            this.Controls.Add(this.SwordInvSprite);
            this.Controls.Add(this.MaceInvSprite);
            this.Controls.Add(this.BowInvSprite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BluePotionSprite);
            this.Controls.Add(this.RedPotionSprite);
            this.Controls.Add(this.BatSprite);
            this.Controls.Add(this.SwordSprite);
            this.Controls.Add(this.MaceSprite);
            this.Controls.Add(this.GhoulSprite);
            this.Controls.Add(this.GhostSprite);
            this.Controls.Add(this.BowSprite);
            this.Controls.Add(this.PlayerSprite);
            this.Controls.Add(this.HitPointPanel);
            this.Controls.Add(this.AttackPanel);
            this.Controls.Add(this.MovePanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Game War";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.AttackPanel.ResumeLayout(false);
            this.AttackPanel.PerformLayout();
            this.MovePanel.ResumeLayout(false);
            this.MovePanel.PerformLayout();
            this.HitPointPanel.ResumeLayout(false);
            this.HitPointPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInvSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AttackPanel;
        private System.Windows.Forms.Label AttackPanelCaption;
        private System.Windows.Forms.Button AttackUp;
        private System.Windows.Forms.Button AttackLeft;
        private System.Windows.Forms.Button AttackRight;
        private System.Windows.Forms.Button AttackDown;
        private System.Windows.Forms.TableLayoutPanel MovePanel;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Label MovePanelCaption;
        private System.Windows.Forms.TableLayoutPanel HitPointPanel;
        private System.Windows.Forms.Label PlayerHitPointsCaption;
        private System.Windows.Forms.Label BatHitPointsCaption;
        private System.Windows.Forms.Label GhostHitPointsCaption;
        private System.Windows.Forms.Label GhoulHitPointsCaption;
        private System.Windows.Forms.Label PlayerHitPoints;
        private System.Windows.Forms.Label BatHitPoints;
        private System.Windows.Forms.Label GhostHitPoints;
        private System.Windows.Forms.Label GhoulHitPoints;
        private System.Windows.Forms.PictureBox PlayerSprite;
        private System.Windows.Forms.PictureBox BowSprite;
        private System.Windows.Forms.PictureBox GhostSprite;
        private System.Windows.Forms.PictureBox GhoulSprite;
        private System.Windows.Forms.PictureBox MaceSprite;
        private System.Windows.Forms.PictureBox SwordSprite;
        private System.Windows.Forms.PictureBox BatSprite;
        private System.Windows.Forms.PictureBox RedPotionSprite;
        private System.Windows.Forms.PictureBox BluePotionSprite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BowInvSprite;
        private System.Windows.Forms.PictureBox MaceInvSprite;
        private System.Windows.Forms.PictureBox SwordInvSprite;
        private System.Windows.Forms.PictureBox BluePotionInvSprite;
        private System.Windows.Forms.PictureBox RedPotionInvSprite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

