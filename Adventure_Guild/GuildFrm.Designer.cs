
namespace Adventure_Guild {
    partial class GuildFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.adventurerPanel = new System.Windows.Forms.Panel();
            this.adventurer = new System.Windows.Forms.Label();
            this.createAdventurerBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.newAdventurerPanel = new System.Windows.Forms.Panel();
            this.startWorldBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.bonusesPnl = new System.Windows.Forms.Panel();
            this.bonusesLbl = new System.Windows.Forms.Label();
            this.lotteryBtn = new System.Windows.Forms.Button();
            this.freeInnBtn = new System.Windows.Forms.Button();
            this.moreMoneyBtn = new System.Windows.Forms.Button();
            this.createBackPnl = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.questBoardPnl = new System.Windows.Forms.Panel();
            this.questBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adventurerInfoPnl = new System.Windows.Forms.Panel();
            this.coinsLbl = new System.Windows.Forms.Label();
            this.rankLbl = new System.Windows.Forms.Label();
            this.adventurerNameLbl = new System.Windows.Forms.Label();
            this.guildInfoPnl = new System.Windows.Forms.Panel();
            this.profitLbl = new System.Windows.Forms.Label();
            this.guildLbl = new System.Windows.Forms.Label();
            this.logoutPnl = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.actionPnl = new System.Windows.Forms.Panel();
            this.bonusBtn = new System.Windows.Forms.Button();
            this.adventurerPanel.SuspendLayout();
            this.newAdventurerPanel.SuspendLayout();
            this.bonusesPnl.SuspendLayout();
            this.createBackPnl.SuspendLayout();
            this.questBoardPnl.SuspendLayout();
            this.adventurerInfoPnl.SuspendLayout();
            this.guildInfoPnl.SuspendLayout();
            this.logoutPnl.SuspendLayout();
            this.actionPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // adventurerPanel
            // 
            this.adventurerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adventurerPanel.Controls.Add(this.adventurer);
            this.adventurerPanel.Location = new System.Drawing.Point(430, 12);
            this.adventurerPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adventurerPanel.Name = "adventurerPanel";
            this.adventurerPanel.Size = new System.Drawing.Size(11, 10);
            this.adventurerPanel.TabIndex = 0;
            // 
            // adventurer
            // 
            this.adventurer.AutoSize = true;
            this.adventurer.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.adventurer.Location = new System.Drawing.Point(32, -1);
            this.adventurer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adventurer.Name = "adventurer";
            this.adventurer.Size = new System.Drawing.Size(125, 22);
            this.adventurer.TabIndex = 0;
            this.adventurer.Text = "Adventurers";
            // 
            // createAdventurerBtn
            // 
            this.createAdventurerBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAdventurerBtn.Location = new System.Drawing.Point(51, 48);
            this.createAdventurerBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createAdventurerBtn.Name = "createAdventurerBtn";
            this.createAdventurerBtn.Size = new System.Drawing.Size(112, 34);
            this.createAdventurerBtn.TabIndex = 1;
            this.createAdventurerBtn.TabStop = false;
            this.createAdventurerBtn.Text = "Add Adventure";
            this.createAdventurerBtn.UseVisualStyleBackColor = true;
            this.createAdventurerBtn.Visible = false;
            this.createAdventurerBtn.Click += new System.EventHandler(this.createAdventurerBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(2, 21);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(79, 17);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Username:";
            this.nameLbl.Visible = false;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(80, 19);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(132, 23);
            this.usernameTxt.TabIndex = 3;
            this.usernameTxt.Visible = false;
            // 
            // newAdventurerPanel
            // 
            this.newAdventurerPanel.Controls.Add(this.startWorldBtn);
            this.newAdventurerPanel.Controls.Add(this.usernameTxt);
            this.newAdventurerPanel.Controls.Add(this.createAdventurerBtn);
            this.newAdventurerPanel.Controls.Add(this.nameLbl);
            this.newAdventurerPanel.Location = new System.Drawing.Point(446, 12);
            this.newAdventurerPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newAdventurerPanel.Name = "newAdventurerPanel";
            this.newAdventurerPanel.Size = new System.Drawing.Size(10, 10);
            this.newAdventurerPanel.TabIndex = 4;
            // 
            // startWorldBtn
            // 
            this.startWorldBtn.Enabled = false;
            this.startWorldBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startWorldBtn.Location = new System.Drawing.Point(38, 37);
            this.startWorldBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startWorldBtn.Name = "startWorldBtn";
            this.startWorldBtn.Size = new System.Drawing.Size(147, 40);
            this.startWorldBtn.TabIndex = 4;
            this.startWorldBtn.TabStop = false;
            this.startWorldBtn.Text = "Enter World";
            this.startWorldBtn.UseVisualStyleBackColor = true;
            this.startWorldBtn.Click += new System.EventHandler(this.startWorldBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createBtn.Location = new System.Drawing.Point(24, 7);
            this.createBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(119, 32);
            this.createBtn.TabIndex = 5;
            this.createBtn.TabStop = false;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(24, 45);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(119, 37);
            this.backBtn.TabIndex = 6;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // bonusesPnl
            // 
            this.bonusesPnl.Controls.Add(this.bonusesLbl);
            this.bonusesPnl.Controls.Add(this.lotteryBtn);
            this.bonusesPnl.Controls.Add(this.freeInnBtn);
            this.bonusesPnl.Controls.Add(this.moreMoneyBtn);
            this.bonusesPnl.Location = new System.Drawing.Point(135, 12);
            this.bonusesPnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bonusesPnl.Name = "bonusesPnl";
            this.bonusesPnl.Size = new System.Drawing.Size(10, 10);
            this.bonusesPnl.TabIndex = 7;
            this.bonusesPnl.Visible = false;
            // 
            // bonusesLbl
            // 
            this.bonusesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bonusesLbl.AutoSize = true;
            this.bonusesLbl.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bonusesLbl.Location = new System.Drawing.Point(37, 10);
            this.bonusesLbl.Name = "bonusesLbl";
            this.bonusesLbl.Size = new System.Drawing.Size(59, 24);
            this.bonusesLbl.TabIndex = 3;
            this.bonusesLbl.Text = "Bonuses";
            this.bonusesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lotteryBtn
            // 
            this.lotteryBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lotteryBtn.Location = new System.Drawing.Point(16, 111);
            this.lotteryBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lotteryBtn.Name = "lotteryBtn";
            this.lotteryBtn.Size = new System.Drawing.Size(102, 30);
            this.lotteryBtn.TabIndex = 2;
            this.lotteryBtn.TabStop = false;
            this.lotteryBtn.Text = "Lottery";
            this.lotteryBtn.UseVisualStyleBackColor = true;
            this.lotteryBtn.Click += new System.EventHandler(this.lotteryBtn_Click);
            // 
            // freeInnBtn
            // 
            this.freeInnBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.freeInnBtn.Location = new System.Drawing.Point(16, 75);
            this.freeInnBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.freeInnBtn.Name = "freeInnBtn";
            this.freeInnBtn.Size = new System.Drawing.Size(102, 30);
            this.freeInnBtn.TabIndex = 1;
            this.freeInnBtn.TabStop = false;
            this.freeInnBtn.Text = "Free Inn Stay";
            this.freeInnBtn.UseVisualStyleBackColor = true;
            this.freeInnBtn.Click += new System.EventHandler(this.freeInnBtn_Click);
            // 
            // moreMoneyBtn
            // 
            this.moreMoneyBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moreMoneyBtn.Location = new System.Drawing.Point(16, 39);
            this.moreMoneyBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.moreMoneyBtn.Name = "moreMoneyBtn";
            this.moreMoneyBtn.Size = new System.Drawing.Size(102, 30);
            this.moreMoneyBtn.TabIndex = 0;
            this.moreMoneyBtn.TabStop = false;
            this.moreMoneyBtn.Text = "Extra Pay";
            this.moreMoneyBtn.UseVisualStyleBackColor = true;
            this.moreMoneyBtn.Click += new System.EventHandler(this.moreMoneyBtn_Click);
            // 
            // createBackPnl
            // 
            this.createBackPnl.Controls.Add(this.cancelBtn);
            this.createBackPnl.Controls.Add(this.createBtn);
            this.createBackPnl.Controls.Add(this.backBtn);
            this.createBackPnl.Location = new System.Drawing.Point(415, 12);
            this.createBackPnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createBackPnl.Name = "createBackPnl";
            this.createBackPnl.Size = new System.Drawing.Size(10, 10);
            this.createBackPnl.TabIndex = 8;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(24, 46);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 35);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // questBoardPnl
            // 
            this.questBoardPnl.Controls.Add(this.questBtn);
            this.questBoardPnl.Controls.Add(this.button1);
            this.questBoardPnl.Controls.Add(this.button2);
            this.questBoardPnl.Controls.Add(this.button3);
            this.questBoardPnl.Controls.Add(this.button4);
            this.questBoardPnl.Controls.Add(this.button5);
            this.questBoardPnl.Controls.Add(this.button6);
            this.questBoardPnl.Controls.Add(this.button7);
            this.questBoardPnl.Controls.Add(this.button8);
            this.questBoardPnl.Controls.Add(this.button9);
            this.questBoardPnl.Controls.Add(this.button10);
            this.questBoardPnl.Controls.Add(this.button11);
            this.questBoardPnl.Controls.Add(this.label1);
            this.questBoardPnl.Location = new System.Drawing.Point(290, 79);
            this.questBoardPnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.questBoardPnl.Name = "questBoardPnl";
            this.questBoardPnl.Size = new System.Drawing.Size(10, 10);
            this.questBoardPnl.TabIndex = 9;
            this.questBoardPnl.Visible = false;
            // 
            // questBtn
            // 
            this.questBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questBtn.Location = new System.Drawing.Point(8, 73);
            this.questBtn.Name = "questBtn";
            this.questBtn.Size = new System.Drawing.Size(146, 65);
            this.questBtn.TabIndex = 6;
            this.questBtn.TabStop = false;
            this.questBtn.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.questBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(160, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 65);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(312, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 65);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(8, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 65);
            this.button3.TabIndex = 9;
            this.button3.TabStop = false;
            this.button3.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(160, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 65);
            this.button4.TabIndex = 10;
            this.button4.TabStop = false;
            this.button4.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(312, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 65);
            this.button5.TabIndex = 11;
            this.button5.TabStop = false;
            this.button5.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(8, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 65);
            this.button6.TabIndex = 12;
            this.button6.TabStop = false;
            this.button6.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(160, 215);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 65);
            this.button7.TabIndex = 13;
            this.button7.TabStop = false;
            this.button7.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(312, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 65);
            this.button8.TabIndex = 14;
            this.button8.TabStop = false;
            this.button8.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(8, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 65);
            this.button9.TabIndex = 15;
            this.button9.TabStop = false;
            this.button9.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(160, 286);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(146, 65);
            this.button10.TabIndex = 16;
            this.button10.TabStop = false;
            this.button10.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(312, 286);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(146, 65);
            this.button11.TabIndex = 17;
            this.button11.TabStop = false;
            this.button11.Text = "Quest Name\r\nQuest Rank\r\nReward Coins";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(171, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quest Board";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adventurerInfoPnl
            // 
            this.adventurerInfoPnl.Controls.Add(this.coinsLbl);
            this.adventurerInfoPnl.Controls.Add(this.rankLbl);
            this.adventurerInfoPnl.Controls.Add(this.adventurerNameLbl);
            this.adventurerInfoPnl.Location = new System.Drawing.Point(208, 12);
            this.adventurerInfoPnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adventurerInfoPnl.Name = "adventurerInfoPnl";
            this.adventurerInfoPnl.Size = new System.Drawing.Size(10, 10);
            this.adventurerInfoPnl.TabIndex = 10;
            this.adventurerInfoPnl.Visible = false;
            // 
            // coinsLbl
            // 
            this.coinsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coinsLbl.AutoSize = true;
            this.coinsLbl.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coinsLbl.Location = new System.Drawing.Point(3, 78);
            this.coinsLbl.Name = "coinsLbl";
            this.coinsLbl.Size = new System.Drawing.Size(72, 24);
            this.coinsLbl.TabIndex = 2;
            this.coinsLbl.Text = "Coins Here";
            this.coinsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankLbl
            // 
            this.rankLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rankLbl.AutoSize = true;
            this.rankLbl.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rankLbl.Location = new System.Drawing.Point(37, 37);
            this.rankLbl.Name = "rankLbl";
            this.rankLbl.Size = new System.Drawing.Size(75, 24);
            this.rankLbl.TabIndex = 1;
            this.rankLbl.Text = "RANK Here";
            this.rankLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adventurerNameLbl
            // 
            this.adventurerNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adventurerNameLbl.AutoSize = true;
            this.adventurerNameLbl.Font = new System.Drawing.Font("Bodoni MT Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.adventurerNameLbl.Location = new System.Drawing.Point(28, 12);
            this.adventurerNameLbl.Name = "adventurerNameLbl";
            this.adventurerNameLbl.Size = new System.Drawing.Size(117, 22);
            this.adventurerNameLbl.TabIndex = 0;
            this.adventurerNameLbl.Text = "Name Here";
            this.adventurerNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guildInfoPnl
            // 
            this.guildInfoPnl.Controls.Add(this.profitLbl);
            this.guildInfoPnl.Controls.Add(this.guildLbl);
            this.guildInfoPnl.Location = new System.Drawing.Point(548, 15);
            this.guildInfoPnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guildInfoPnl.Name = "guildInfoPnl";
            this.guildInfoPnl.Size = new System.Drawing.Size(10, 10);
            this.guildInfoPnl.TabIndex = 11;
            this.guildInfoPnl.Visible = false;
            // 
            // profitLbl
            // 
            this.profitLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profitLbl.AutoSize = true;
            this.profitLbl.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profitLbl.Location = new System.Drawing.Point(12, 29);
            this.profitLbl.Name = "profitLbl";
            this.profitLbl.Size = new System.Drawing.Size(72, 24);
            this.profitLbl.TabIndex = 4;
            this.profitLbl.Text = "Coins Here";
            this.profitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guildLbl
            // 
            this.guildLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guildLbl.AutoSize = true;
            this.guildLbl.Font = new System.Drawing.Font("Bodoni MT Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guildLbl.Location = new System.Drawing.Point(3, 7);
            this.guildLbl.Name = "guildLbl";
            this.guildLbl.Size = new System.Drawing.Size(178, 22);
            this.guildLbl.TabIndex = 3;
            this.guildLbl.Text = "Adventurer Guild";
            this.guildLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutPnl
            // 
            this.logoutPnl.Controls.Add(this.logoutBtn);
            this.logoutPnl.Location = new System.Drawing.Point(785, 19);
            this.logoutPnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoutPnl.Name = "logoutPnl";
            this.logoutPnl.Size = new System.Drawing.Size(10, 10);
            this.logoutPnl.TabIndex = 12;
            this.logoutPnl.Visible = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.Location = new System.Drawing.Point(81, 24);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(105, 29);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // actionPnl
            // 
            this.actionPnl.Controls.Add(this.bonusBtn);
            this.actionPnl.Location = new System.Drawing.Point(273, 15);
            this.actionPnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.actionPnl.Name = "actionPnl";
            this.actionPnl.Size = new System.Drawing.Size(10, 10);
            this.actionPnl.TabIndex = 13;
            this.actionPnl.Visible = false;
            // 
            // bonusBtn
            // 
            this.bonusBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bonusBtn.Location = new System.Drawing.Point(3, 155);
            this.bonusBtn.Name = "bonusBtn";
            this.bonusBtn.Size = new System.Drawing.Size(93, 27);
            this.bonusBtn.TabIndex = 0;
            this.bonusBtn.TabStop = false;
            this.bonusBtn.Text = "Get Bonus";
            this.bonusBtn.UseVisualStyleBackColor = true;
            this.bonusBtn.Click += new System.EventHandler(this.bonusBtn_Click);
            // 
            // GuildFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.actionPnl);
            this.Controls.Add(this.logoutPnl);
            this.Controls.Add(this.guildInfoPnl);
            this.Controls.Add(this.adventurerInfoPnl);
            this.Controls.Add(this.questBoardPnl);
            this.Controls.Add(this.createBackPnl);
            this.Controls.Add(this.bonusesPnl);
            this.Controls.Add(this.newAdventurerPanel);
            this.Controls.Add(this.adventurerPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GuildFrm";
            this.Text = "Adventure Guild";
            this.Load += new System.EventHandler(this.GuildFrm_Load);
            this.adventurerPanel.ResumeLayout(false);
            this.adventurerPanel.PerformLayout();
            this.newAdventurerPanel.ResumeLayout(false);
            this.newAdventurerPanel.PerformLayout();
            this.bonusesPnl.ResumeLayout(false);
            this.bonusesPnl.PerformLayout();
            this.createBackPnl.ResumeLayout(false);
            this.questBoardPnl.ResumeLayout(false);
            this.questBoardPnl.PerformLayout();
            this.adventurerInfoPnl.ResumeLayout(false);
            this.adventurerInfoPnl.PerformLayout();
            this.guildInfoPnl.ResumeLayout(false);
            this.guildInfoPnl.PerformLayout();
            this.logoutPnl.ResumeLayout(false);
            this.actionPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adventurerPanel;
        private System.Windows.Forms.Button createAdventurerBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Panel newAdventurerPanel;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label adventurer;
        private System.Windows.Forms.Panel bonusesPnl;
        private System.Windows.Forms.Button moreMoneyBtn;
        private System.Windows.Forms.Button freeInnBtn;
        private System.Windows.Forms.Button lotteryBtn;
        private System.Windows.Forms.Panel createBackPnl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button startWorldBtn;
        private System.Windows.Forms.Panel questBoardPnl;
        private System.Windows.Forms.Panel adventurerInfoPnl;
        private System.Windows.Forms.Panel guildInfoPnl;
        private System.Windows.Forms.Panel logoutPnl;
        private System.Windows.Forms.Panel actionPnl;
        private System.Windows.Forms.Label bonusesLbl;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button questBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coinsLbl;
        private System.Windows.Forms.Label rankLbl;
        private System.Windows.Forms.Label adventurerNameLbl;
        private System.Windows.Forms.Label profitLbl;
        private System.Windows.Forms.Label guildLbl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button bonusBtn;
    }
}