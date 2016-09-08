namespace Shotgun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGameName = new System.Windows.Forms.Label();
            this.UserControls = new System.Windows.Forms.Panel();
            this.lblBulletCount = new System.Windows.Forms.Label();
            this.picBlock = new System.Windows.Forms.PictureBox();
            this.picShoot = new System.Windows.Forms.PictureBox();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.picHeaderCactus = new System.Windows.Forms.PictureBox();
            this.picAIBulletCount = new System.Windows.Forms.PictureBox();
            this.lblAIBulletCount = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblAction = new System.Windows.Forms.Label();
            this.picAction = new System.Windows.Forms.PictureBox();
            this.lblAIAction = new System.Windows.Forms.Label();
            this.picAIAction = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWinCount = new System.Windows.Forms.Label();
            this.picWinCount = new System.Windows.Forms.PictureBox();
            this.AIBulletDisplay = new System.Windows.Forms.Panel();
            this.UserControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderCactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAIBulletCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAIAction)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinCount)).BeginInit();
            this.AIBulletDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(292, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.BackColor = System.Drawing.Color.Black;
            this.lblGameName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGameName.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.LightGray;
            this.lblGameName.Location = new System.Drawing.Point(0, 0);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(334, 51);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "SHOTGUN";
            this.lblGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControls
            // 
            this.UserControls.BackColor = System.Drawing.Color.Black;
            this.UserControls.Controls.Add(this.lblBulletCount);
            this.UserControls.Controls.Add(this.picBlock);
            this.UserControls.Controls.Add(this.picShoot);
            this.UserControls.Controls.Add(this.picReload);
            this.UserControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserControls.Location = new System.Drawing.Point(0, 311);
            this.UserControls.Name = "UserControls";
            this.UserControls.Size = new System.Drawing.Size(334, 100);
            this.UserControls.TabIndex = 2;
            // 
            // lblBulletCount
            // 
            this.lblBulletCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBulletCount.AutoSize = true;
            this.lblBulletCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulletCount.ForeColor = System.Drawing.Color.White;
            this.lblBulletCount.Location = new System.Drawing.Point(94, 3);
            this.lblBulletCount.Name = "lblBulletCount";
            this.lblBulletCount.Size = new System.Drawing.Size(25, 25);
            this.lblBulletCount.TabIndex = 4;
            this.lblBulletCount.Text = "0";
            // 
            // picBlock
            // 
            this.picBlock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picBlock.BackColor = System.Drawing.Color.Transparent;
            this.picBlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBlock.BackgroundImage")));
            this.picBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBlock.Location = new System.Drawing.Point(232, 11);
            this.picBlock.Name = "picBlock";
            this.picBlock.Size = new System.Drawing.Size(80, 80);
            this.picBlock.TabIndex = 2;
            this.picBlock.TabStop = false;
            this.picBlock.Click += new System.EventHandler(this.picBlock_Click);
            // 
            // picShoot
            // 
            this.picShoot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picShoot.BackColor = System.Drawing.Color.Transparent;
            this.picShoot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picShoot.BackgroundImage")));
            this.picShoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picShoot.Location = new System.Drawing.Point(128, 11);
            this.picShoot.Name = "picShoot";
            this.picShoot.Size = new System.Drawing.Size(80, 80);
            this.picShoot.TabIndex = 1;
            this.picShoot.TabStop = false;
            this.picShoot.Click += new System.EventHandler(this.picShoot_Click);
            // 
            // picReload
            // 
            this.picReload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picReload.BackColor = System.Drawing.Color.Transparent;
            this.picReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picReload.BackgroundImage")));
            this.picReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picReload.Location = new System.Drawing.Point(25, 11);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(80, 80);
            this.picReload.TabIndex = 0;
            this.picReload.TabStop = false;
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // picHeaderCactus
            // 
            this.picHeaderCactus.BackColor = System.Drawing.Color.Black;
            this.picHeaderCactus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHeaderCactus.BackgroundImage")));
            this.picHeaderCactus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHeaderCactus.Location = new System.Drawing.Point(12, 6);
            this.picHeaderCactus.Name = "picHeaderCactus";
            this.picHeaderCactus.Size = new System.Drawing.Size(45, 45);
            this.picHeaderCactus.TabIndex = 3;
            this.picHeaderCactus.TabStop = false;
            // 
            // picAIBulletCount
            // 
            this.picAIBulletCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAIBulletCount.BackColor = System.Drawing.Color.Transparent;
            this.picAIBulletCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAIBulletCount.BackgroundImage")));
            this.picAIBulletCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAIBulletCount.Location = new System.Drawing.Point(8, 9);
            this.picAIBulletCount.Name = "picAIBulletCount";
            this.picAIBulletCount.Size = new System.Drawing.Size(55, 55);
            this.picAIBulletCount.TabIndex = 5;
            this.picAIBulletCount.TabStop = false;
            // 
            // lblAIBulletCount
            // 
            this.lblAIBulletCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAIBulletCount.AutoSize = true;
            this.lblAIBulletCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAIBulletCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIBulletCount.ForeColor = System.Drawing.Color.White;
            this.lblAIBulletCount.Location = new System.Drawing.Point(69, 23);
            this.lblAIBulletCount.Name = "lblAIBulletCount";
            this.lblAIBulletCount.Size = new System.Drawing.Size(25, 25);
            this.lblAIBulletCount.TabIndex = 6;
            this.lblAIBulletCount.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblAction);
            this.splitContainer1.Panel1.Controls.Add(this.picAction);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblAIAction);
            this.splitContainer1.Panel2.Controls.Add(this.picAIAction);
            this.splitContainer1.Size = new System.Drawing.Size(334, 178);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 8;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(39, 79);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(87, 24);
            this.lblAction.TabIndex = 1;
            this.lblAction.Text = "ACTION";
            // 
            // picAction
            // 
            this.picAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAction.Location = new System.Drawing.Point(43, 48);
            this.picAction.Name = "picAction";
            this.picAction.Size = new System.Drawing.Size(80, 80);
            this.picAction.TabIndex = 0;
            this.picAction.TabStop = false;
            // 
            // lblAIAction
            // 
            this.lblAIAction.AutoSize = true;
            this.lblAIAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIAction.Location = new System.Drawing.Point(39, 77);
            this.lblAIAction.Name = "lblAIAction";
            this.lblAIAction.Size = new System.Drawing.Size(87, 24);
            this.lblAIAction.TabIndex = 10;
            this.lblAIAction.Text = "ACTION";
            // 
            // picAIAction
            // 
            this.picAIAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAIAction.Location = new System.Drawing.Point(43, 48);
            this.picAIAction.Name = "picAIAction";
            this.picAIAction.Size = new System.Drawing.Size(80, 80);
            this.picAIAction.TabIndex = 9;
            this.picAIAction.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblWinCount);
            this.panel1.Controls.Add(this.picWinCount);
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 70);
            this.panel1.TabIndex = 9;
            // 
            // lblWinCount
            // 
            this.lblWinCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWinCount.AutoSize = true;
            this.lblWinCount.BackColor = System.Drawing.Color.Transparent;
            this.lblWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinCount.ForeColor = System.Drawing.Color.Black;
            this.lblWinCount.Location = new System.Drawing.Point(64, 18);
            this.lblWinCount.Name = "lblWinCount";
            this.lblWinCount.Size = new System.Drawing.Size(37, 39);
            this.lblWinCount.TabIndex = 7;
            this.lblWinCount.Text = "0";
            // 
            // picWinCount
            // 
            this.picWinCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWinCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWinCount.BackgroundImage")));
            this.picWinCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWinCount.Location = new System.Drawing.Point(6, 8);
            this.picWinCount.Name = "picWinCount";
            this.picWinCount.Size = new System.Drawing.Size(55, 55);
            this.picWinCount.TabIndex = 0;
            this.picWinCount.TabStop = false;
            // 
            // AIBulletDisplay
            // 
            this.AIBulletDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AIBulletDisplay.BackColor = System.Drawing.Color.DimGray;
            this.AIBulletDisplay.Controls.Add(this.picAIBulletCount);
            this.AIBulletDisplay.Controls.Add(this.lblAIBulletCount);
            this.AIBulletDisplay.Location = new System.Drawing.Point(233, 242);
            this.AIBulletDisplay.Name = "AIBulletDisplay";
            this.AIBulletDisplay.Size = new System.Drawing.Size(101, 70);
            this.AIBulletDisplay.TabIndex = 10;
            this.AIBulletDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.AIBulletDisplay_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.ControlBox = false;
            this.Controls.Add(this.AIBulletDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.picHeaderCactus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.UserControls);
            this.Controls.Add(this.lblGameName);
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dP - Shotgun";
            this.UserControls.ResumeLayout(false);
            this.UserControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderCactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAIBulletCount)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAIAction)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinCount)).EndInit();
            this.AIBulletDisplay.ResumeLayout(false);
            this.AIBulletDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Panel UserControls;
        private System.Windows.Forms.PictureBox picShoot;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.PictureBox picBlock;
        private System.Windows.Forms.PictureBox picHeaderCactus;
        private System.Windows.Forms.PictureBox picAIBulletCount;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picAction;
        private System.Windows.Forms.PictureBox picAIAction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picWinCount;
        private System.Windows.Forms.Panel AIBulletDisplay;
        public System.Windows.Forms.Label lblAction;
        public System.Windows.Forms.Label lblAIAction;
        public System.Windows.Forms.Label lblAIBulletCount;
        public System.Windows.Forms.Label lblBulletCount;
        public System.Windows.Forms.Label lblWinCount;
    }
}

