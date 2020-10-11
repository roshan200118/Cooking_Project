namespace RoshanNanthapalanA1Cooking
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmrStartGame = new System.Windows.Forms.Timer(this.components);
            this.picBun = new System.Windows.Forms.PictureBox();
            this.picPatty = new System.Windows.Forms.PictureBox();
            this.picLettuce = new System.Windows.Forms.PictureBox();
            this.picTomato = new System.Windows.Forms.PictureBox();
            this.picKetchup = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rctCounter3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctCounter2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctCounter1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctServe = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctBunGrill = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctKetchup = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctPattyGrill = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctPrep = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctTomato = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctLettuce = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctPatty = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctBun = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tmrGrill = new System.Windows.Forms.Timer(this.components);
            this.lblBunTimer = new System.Windows.Forms.Label();
            this.lblPattyTimer = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.btnHomeScreen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblPattyStatus = new System.Windows.Forms.Label();
            this.lblBunStatus = new System.Windows.Forms.Label();
            this.picBurger = new System.Windows.Forms.PictureBox();
            this.lblPrepTime = new System.Windows.Forms.Label();
            this.lblGameTime = new System.Windows.Forms.Label();
            this.pnlHomeScreen = new System.Windows.Forms.Panel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.picBlockLegend = new System.Windows.Forms.PictureBox();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPatty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLettuce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTomato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKetchup)).BeginInit();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).BeginInit();
            this.pnlHomeScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlockLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Image = global::RoshanNanthapalanA1Cooking.Properties.Resources.Snoop;
            this.picPlayer.Location = new System.Drawing.Point(539, 213);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(50, 104);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // tmrStartGame
            // 
            this.tmrStartGame.Enabled = true;
            this.tmrStartGame.Interval = 25;
            this.tmrStartGame.Tick += new System.EventHandler(this.tmrStartGame_Tick);
            // 
            // picBun
            // 
            this.picBun.BackColor = System.Drawing.Color.Transparent;
            this.picBun.Image = global::RoshanNanthapalanA1Cooking.Properties.Resources.BunGood;
            this.picBun.Location = new System.Drawing.Point(457, 434);
            this.picBun.Name = "picBun";
            this.picBun.Size = new System.Drawing.Size(43, 37);
            this.picBun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBun.TabIndex = 1;
            this.picBun.TabStop = false;
            // 
            // picPatty
            // 
            this.picPatty.BackColor = System.Drawing.Color.Transparent;
            this.picPatty.Image = global::RoshanNanthapalanA1Cooking.Properties.Resources.RawMeat2;
            this.picPatty.Location = new System.Drawing.Point(380, 435);
            this.picPatty.Name = "picPatty";
            this.picPatty.Size = new System.Drawing.Size(37, 38);
            this.picPatty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPatty.TabIndex = 2;
            this.picPatty.TabStop = false;
            // 
            // picLettuce
            // 
            this.picLettuce.BackColor = System.Drawing.Color.Transparent;
            this.picLettuce.Image = global::RoshanNanthapalanA1Cooking.Properties.Resources.Lettuce2;
            this.picLettuce.Location = new System.Drawing.Point(299, 436);
            this.picLettuce.Name = "picLettuce";
            this.picLettuce.Size = new System.Drawing.Size(40, 40);
            this.picLettuce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLettuce.TabIndex = 3;
            this.picLettuce.TabStop = false;
            // 
            // picTomato
            // 
            this.picTomato.BackColor = System.Drawing.Color.Transparent;
            this.picTomato.Image = global::RoshanNanthapalanA1Cooking.Properties.Resources.TomatoSlice;
            this.picTomato.Location = new System.Drawing.Point(230, 438);
            this.picTomato.Name = "picTomato";
            this.picTomato.Size = new System.Drawing.Size(30, 27);
            this.picTomato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTomato.TabIndex = 4;
            this.picTomato.TabStop = false;
            // 
            // picKetchup
            // 
            this.picKetchup.BackColor = System.Drawing.Color.Transparent;
            this.picKetchup.Image = global::RoshanNanthapalanA1Cooking.Properties.Resources.Ketchup2;
            this.picKetchup.Location = new System.Drawing.Point(576, 433);
            this.picKetchup.Name = "picKetchup";
            this.picKetchup.Size = new System.Drawing.Size(27, 54);
            this.picKetchup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKetchup.TabIndex = 6;
            this.picKetchup.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rctCounter3,
            this.rctCounter2,
            this.rctCounter1,
            this.rctServe,
            this.rctBunGrill,
            this.rctKetchup,
            this.rctPattyGrill,
            this.rctPrep,
            this.rctTomato,
            this.rctLettuce,
            this.rctPatty,
            this.rctBun});
            this.shapeContainer1.Size = new System.Drawing.Size(940, 499);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // rctCounter3
            // 
            this.rctCounter3.BorderColor = System.Drawing.Color.Black;
            this.rctCounter3.BorderWidth = 2;
            this.rctCounter3.FillColor = System.Drawing.Color.Black;
            this.rctCounter3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctCounter3.Location = new System.Drawing.Point(662, 376);
            this.rctCounter3.Name = "rctCounter3";
            this.rctCounter3.Size = new System.Drawing.Size(53, 47);
            // 
            // rctCounter2
            // 
            this.rctCounter2.BorderColor = System.Drawing.Color.Black;
            this.rctCounter2.BorderWidth = 2;
            this.rctCounter2.FillColor = System.Drawing.Color.Black;
            this.rctCounter2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctCounter2.Location = new System.Drawing.Point(600, 184);
            this.rctCounter2.Name = "rctCounter2";
            this.rctCounter2.Size = new System.Drawing.Size(53, 47);
            // 
            // rctCounter1
            // 
            this.rctCounter1.BorderColor = System.Drawing.Color.Black;
            this.rctCounter1.BorderWidth = 2;
            this.rctCounter1.FillColor = System.Drawing.Color.Black;
            this.rctCounter1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctCounter1.Location = new System.Drawing.Point(228, 184);
            this.rctCounter1.Name = "rctCounter1";
            this.rctCounter1.Size = new System.Drawing.Size(53, 47);
            // 
            // rctServe
            // 
            this.rctServe.BackColor = System.Drawing.SystemColors.Control;
            this.rctServe.BorderColor = System.Drawing.Color.DarkGray;
            this.rctServe.BorderWidth = 2;
            this.rctServe.FillColor = System.Drawing.Color.White;
            this.rctServe.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctServe.Location = new System.Drawing.Point(683, 240);
            this.rctServe.Name = "rctServe";
            this.rctServe.Size = new System.Drawing.Size(49, 45);
            // 
            // rctBunGrill
            // 
            this.rctBunGrill.BackColor = System.Drawing.SystemColors.Control;
            this.rctBunGrill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(119)))), ((int)(((byte)(63)))));
            this.rctBunGrill.BorderWidth = 2;
            this.rctBunGrill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(145)))), ((int)(((byte)(46)))));
            this.rctBunGrill.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.LargeConfetti;
            this.rctBunGrill.Location = new System.Drawing.Point(339, 185);
            this.rctBunGrill.Name = "rctBunGrill";
            this.rctBunGrill.Size = new System.Drawing.Size(49, 45);
            // 
            // rctKetchup
            // 
            this.rctKetchup.BorderColor = System.Drawing.Color.Red;
            this.rctKetchup.BorderWidth = 2;
            this.rctKetchup.FillColor = System.Drawing.Color.Red;
            this.rctKetchup.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctKetchup.Location = new System.Drawing.Point(563, 377);
            this.rctKetchup.Name = "rctKetchup";
            this.rctKetchup.Size = new System.Drawing.Size(53, 47);
            // 
            // rctPattyGrill
            // 
            this.rctPattyGrill.BackColor = System.Drawing.SystemColors.Control;
            this.rctPattyGrill.BorderColor = System.Drawing.Color.HotPink;
            this.rctPattyGrill.BorderWidth = 2;
            this.rctPattyGrill.FillColor = System.Drawing.Color.HotPink;
            this.rctPattyGrill.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctPattyGrill.Location = new System.Drawing.Point(464, 185);
            this.rctPattyGrill.Name = "rctPattyGrill";
            this.rctPattyGrill.Size = new System.Drawing.Size(49, 45);
            // 
            // rctPrep
            // 
            this.rctPrep.BackColor = System.Drawing.SystemColors.Control;
            this.rctPrep.BorderColor = System.Drawing.Color.Blue;
            this.rctPrep.BorderWidth = 2;
            this.rctPrep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rctPrep.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctPrep.Location = new System.Drawing.Point(117, 239);
            this.rctPrep.Name = "rctPrep";
            this.rctPrep.Size = new System.Drawing.Size(51, 45);
            // 
            // rctTomato
            // 
            this.rctTomato.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rctTomato.BorderWidth = 2;
            this.rctTomato.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rctTomato.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctTomato.Location = new System.Drawing.Point(220, 378);
            this.rctTomato.Name = "rctTomato";
            this.rctTomato.Size = new System.Drawing.Size(52, 46);
            // 
            // rctLettuce
            // 
            this.rctLettuce.BorderColor = System.Drawing.Color.Lime;
            this.rctLettuce.BorderWidth = 2;
            this.rctLettuce.FillColor = System.Drawing.Color.Lime;
            this.rctLettuce.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctLettuce.Location = new System.Drawing.Point(294, 379);
            this.rctLettuce.Name = "rctLettuce";
            this.rctLettuce.Size = new System.Drawing.Size(51, 45);
            // 
            // rctPatty
            // 
            this.rctPatty.BorderColor = System.Drawing.Color.HotPink;
            this.rctPatty.BorderWidth = 2;
            this.rctPatty.FillColor = System.Drawing.Color.HotPink;
            this.rctPatty.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rctPatty.Location = new System.Drawing.Point(374, 380);
            this.rctPatty.Name = "rctPatty";
            this.rctPatty.Size = new System.Drawing.Size(50, 45);
            // 
            // rctBun
            // 
            this.rctBun.BackColor = System.Drawing.SystemColors.Control;
            this.rctBun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rctBun.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.rctBun.BorderWidth = 2;
            this.rctBun.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.rctBun.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.LargeConfetti;
            this.rctBun.Location = new System.Drawing.Point(454, 380);
            this.rctBun.Name = "rctBun";
            this.rctBun.Size = new System.Drawing.Size(50, 44);
            // 
            // tmrGrill
            // 
            this.tmrGrill.Enabled = true;
            this.tmrGrill.Interval = 1000;
            this.tmrGrill.Tick += new System.EventHandler(this.tmrGrill_Tick);
            // 
            // lblBunTimer
            // 
            this.lblBunTimer.AutoSize = true;
            this.lblBunTimer.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBunTimer.Location = new System.Drawing.Point(6, 6);
            this.lblBunTimer.Name = "lblBunTimer";
            this.lblBunTimer.Size = new System.Drawing.Size(144, 17);
            this.lblBunTimer.TabIndex = 9;
            this.lblBunTimer.Text = "Bun\'s Time on Grill:";
            // 
            // lblPattyTimer
            // 
            this.lblPattyTimer.AutoSize = true;
            this.lblPattyTimer.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattyTimer.Location = new System.Drawing.Point(714, 9);
            this.lblPattyTimer.Name = "lblPattyTimer";
            this.lblPattyTimer.Size = new System.Drawing.Size(163, 17);
            this.lblPattyTimer.TabIndex = 10;
            this.lblPattyTimer.Text = "Patty\'s Time on Grill:";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.Yellow;
            this.pnlStatus.Controls.Add(this.btnHomeScreen);
            this.pnlStatus.Controls.Add(this.btnReset);
            this.pnlStatus.Controls.Add(this.lblGameStatus);
            this.pnlStatus.Controls.Add(this.lblOrder);
            this.pnlStatus.Controls.Add(this.lblPattyStatus);
            this.pnlStatus.Controls.Add(this.lblBunStatus);
            this.pnlStatus.Controls.Add(this.lblBunTimer);
            this.pnlStatus.Controls.Add(this.lblPattyTimer);
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(940, 97);
            this.pnlStatus.TabIndex = 11;
            // 
            // btnHomeScreen
            // 
            this.btnHomeScreen.BackColor = System.Drawing.Color.Blue;
            this.btnHomeScreen.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeScreen.Location = new System.Drawing.Point(814, 64);
            this.btnHomeScreen.Name = "btnHomeScreen";
            this.btnHomeScreen.Size = new System.Drawing.Size(114, 27);
            this.btnHomeScreen.TabIndex = 16;
            this.btnHomeScreen.Text = "Home Screen";
            this.btnHomeScreen.UseVisualStyleBackColor = false;
            this.btnHomeScreen.Click += new System.EventHandler(this.btnHomeScreen_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Blue;
            this.btnReset.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(7, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 27);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblGameStatus.Location = new System.Drawing.Point(362, 4);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(55, 19);
            this.lblGameStatus.TabIndex = 14;
            this.lblGameStatus.Text = "Game";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(206, 6);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(54, 17);
            this.lblOrder.TabIndex = 13;
            this.lblOrder.Text = "Order:";
            // 
            // lblPattyStatus
            // 
            this.lblPattyStatus.AutoSize = true;
            this.lblPattyStatus.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattyStatus.Location = new System.Drawing.Point(668, 33);
            this.lblPattyStatus.Name = "lblPattyStatus";
            this.lblPattyStatus.Size = new System.Drawing.Size(129, 19);
            this.lblPattyStatus.TabIndex = 12;
            this.lblPattyStatus.Text = "Patty Status";
            // 
            // lblBunStatus
            // 
            this.lblBunStatus.AutoSize = true;
            this.lblBunStatus.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBunStatus.Location = new System.Drawing.Point(5, 33);
            this.lblBunStatus.Name = "lblBunStatus";
            this.lblBunStatus.Size = new System.Drawing.Size(107, 19);
            this.lblBunStatus.TabIndex = 11;
            this.lblBunStatus.Text = "Bun Status";
            // 
            // picBurger
            // 
            this.picBurger.BackColor = System.Drawing.Color.Transparent;
            this.picBurger.Image = global::RoshanNanthapalanA1Cooking.Properties.Resources.Burger;
            this.picBurger.Location = new System.Drawing.Point(49, 239);
            this.picBurger.Name = "picBurger";
            this.picBurger.Size = new System.Drawing.Size(48, 46);
            this.picBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBurger.TabIndex = 12;
            this.picBurger.TabStop = false;
            // 
            // lblPrepTime
            // 
            this.lblPrepTime.AutoSize = true;
            this.lblPrepTime.BackColor = System.Drawing.Color.Transparent;
            this.lblPrepTime.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepTime.ForeColor = System.Drawing.Color.Black;
            this.lblPrepTime.Location = new System.Drawing.Point(36, 132);
            this.lblPrepTime.Name = "lblPrepTime";
            this.lblPrepTime.Size = new System.Drawing.Size(96, 19);
            this.lblPrepTime.TabIndex = 15;
            this.lblPrepTime.Text = "Prep Time";
            // 
            // lblGameTime
            // 
            this.lblGameTime.AutoSize = true;
            this.lblGameTime.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTime.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTime.ForeColor = System.Drawing.Color.Black;
            this.lblGameTime.Location = new System.Drawing.Point(676, 287);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(55, 19);
            this.lblGameTime.TabIndex = 15;
            this.lblGameTime.Text = "Game";
            // 
            // pnlHomeScreen
            // 
            this.pnlHomeScreen.BackgroundImage = global::RoshanNanthapalanA1Cooking.Properties.Resources.SnoopCook;
            this.pnlHomeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHomeScreen.Controls.Add(this.lblInstructions);
            this.pnlHomeScreen.Controls.Add(this.picBlockLegend);
            this.pnlHomeScreen.Controls.Add(this.btnInstructions);
            this.pnlHomeScreen.Controls.Add(this.btnPlay);
            this.pnlHomeScreen.Location = new System.Drawing.Point(895, 450);
            this.pnlHomeScreen.Name = "pnlHomeScreen";
            this.pnlHomeScreen.Size = new System.Drawing.Size(940, 499);
            this.pnlHomeScreen.TabIndex = 16;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblInstructions.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInstructions.Location = new System.Drawing.Point(418, 185);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(82, 14);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Instructions";
            // 
            // picBlockLegend
            // 
            this.picBlockLegend.Image = global::RoshanNanthapalanA1Cooking.Properties.Resources.BlockLegendGood2;
            this.picBlockLegend.Location = new System.Drawing.Point(-1, 185);
            this.picBlockLegend.Name = "picBlockLegend";
            this.picBlockLegend.Size = new System.Drawing.Size(417, 253);
            this.picBlockLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlockLegend.TabIndex = 2;
            this.picBlockLegend.TabStop = false;
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.Blue;
            this.btnInstructions.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInstructions.Location = new System.Drawing.Point(171, 447);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(138, 40);
            this.btnInstructions.TabIndex = 1;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Blue;
            this.btnPlay.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(3, 445);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(138, 42);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RoshanNanthapalanA1Cooking.Properties.Resources.TilesGood6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 499);
            this.Controls.Add(this.pnlHomeScreen);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.lblGameTime);
            this.Controls.Add(this.lblPrepTime);
            this.Controls.Add(this.picBurger);
            this.Controls.Add(this.picKetchup);
            this.Controls.Add(this.picTomato);
            this.Controls.Add(this.picLettuce);
            this.Controls.Add(this.picPatty);
            this.Controls.Add(this.picBun);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPatty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLettuce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTomato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKetchup)).EndInit();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).EndInit();
            this.pnlHomeScreen.ResumeLayout(false);
            this.pnlHomeScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlockLegend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer tmrStartGame;
        private System.Windows.Forms.PictureBox picBun;
        private System.Windows.Forms.PictureBox picPatty;
        private System.Windows.Forms.PictureBox picLettuce;
        private System.Windows.Forms.PictureBox picTomato;
        private System.Windows.Forms.PictureBox picKetchup;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctPattyGrill;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctPrep;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctTomato;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctLettuce;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctPatty;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctBun;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctKetchup;
        private System.Windows.Forms.Timer tmrGrill;
        private System.Windows.Forms.Label lblBunTimer;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctBunGrill;
        private System.Windows.Forms.Label lblPattyTimer;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblBunStatus;
        private System.Windows.Forms.Label lblPattyStatus;
        private System.Windows.Forms.PictureBox picBurger;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctServe;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.Label lblPrepTime;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlHomeScreen;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picBlockLegend;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnHomeScreen;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctCounter3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctCounter2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctCounter1;
    }
}

