namespace DIGIMONAPP
{
    partial class DIGIMON
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIGIMON));
            this.STARTBUTTON = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.oPTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QUITBUTTON = new System.Windows.Forms.ToolStripMenuItem();
            this.Scene_panel1 = new System.Windows.Forms.Panel();
            this.Scene_panel2 = new System.Windows.Forms.Panel();
            this.picture_Effect = new System.Windows.Forms.PictureBox();
            this.picture_Ending = new System.Windows.Forms.PictureBox();
            this.LVup_BUTTON = new System.Windows.Forms.Button();
            this.ATKBUTTON = new System.Windows.Forms.Button();
            this.SKILL_BUTTON = new System.Windows.Forms.Button();
            this.label_ELevel = new System.Windows.Forms.Label();
            this.label_EDmg = new System.Windows.Forms.Label();
            this.label_EHp = new System.Windows.Forms.Label();
            this.label_EName = new System.Windows.Forms.Label();
            this.label_PLevel = new System.Windows.Forms.Label();
            this.label_PDmg = new System.Windows.Forms.Label();
            this.label_PHp = new System.Windows.Forms.Label();
            this.label_PName = new System.Windows.Forms.Label();
            this.picture_ENEMY = new System.Windows.Forms.PictureBox();
            this.picture_PLAYER = new System.Windows.Forms.PictureBox();
            this.Select_tunomon = new System.Windows.Forms.PictureBox();
            this.Select_coromon = new System.Windows.Forms.PictureBox();
            this.MAINLOGO = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UnitLibrary = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.Scene_panel1.SuspendLayout();
            this.Scene_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Effect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Ending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ENEMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_PLAYER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_tunomon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_coromon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAINLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // STARTBUTTON
            // 
            this.STARTBUTTON.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.STARTBUTTON.Location = new System.Drawing.Point(307, 324);
            this.STARTBUTTON.Name = "STARTBUTTON";
            this.STARTBUTTON.Size = new System.Drawing.Size(212, 59);
            this.STARTBUTTON.TabIndex = 1;
            this.STARTBUTTON.Text = "GAME START";
            this.STARTBUTTON.UseVisualStyleBackColor = true;
            this.STARTBUTTON.Click += new System.EventHandler(this.STARTBUTTON_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPTIONToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // oPTIONToolStripMenuItem
            // 
            this.oPTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QUITBUTTON});
            this.oPTIONToolStripMenuItem.Name = "oPTIONToolStripMenuItem";
            this.oPTIONToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.oPTIONToolStripMenuItem.Text = "OPTION";
            // 
            // QUITBUTTON
            // 
            this.QUITBUTTON.Name = "QUITBUTTON";
            this.QUITBUTTON.Size = new System.Drawing.Size(100, 22);
            this.QUITBUTTON.Text = "QUIT";
            this.QUITBUTTON.Click += new System.EventHandler(this.QUITBUTTON_Click);
            // 
            // Scene_panel1
            // 
            this.Scene_panel1.Controls.Add(this.Scene_panel2);
            this.Scene_panel1.Controls.Add(this.Select_tunomon);
            this.Scene_panel1.Controls.Add(this.Select_coromon);
            this.Scene_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scene_panel1.Location = new System.Drawing.Point(0, 24);
            this.Scene_panel1.Name = "Scene_panel1";
            this.Scene_panel1.Size = new System.Drawing.Size(800, 426);
            this.Scene_panel1.TabIndex = 3;
            this.Scene_panel1.Visible = false;
            // 
            // Scene_panel2
            // 
            this.Scene_panel2.Controls.Add(this.picture_Ending);
            this.Scene_panel2.Controls.Add(this.UnitLibrary);
            this.Scene_panel2.Controls.Add(this.dataGridView1);
            this.Scene_panel2.Controls.Add(this.picture_Effect);
            this.Scene_panel2.Controls.Add(this.LVup_BUTTON);
            this.Scene_panel2.Controls.Add(this.ATKBUTTON);
            this.Scene_panel2.Controls.Add(this.SKILL_BUTTON);
            this.Scene_panel2.Controls.Add(this.label_ELevel);
            this.Scene_panel2.Controls.Add(this.label_EDmg);
            this.Scene_panel2.Controls.Add(this.label_EHp);
            this.Scene_panel2.Controls.Add(this.label_EName);
            this.Scene_panel2.Controls.Add(this.label_PLevel);
            this.Scene_panel2.Controls.Add(this.label_PDmg);
            this.Scene_panel2.Controls.Add(this.label_PHp);
            this.Scene_panel2.Controls.Add(this.label_PName);
            this.Scene_panel2.Controls.Add(this.picture_ENEMY);
            this.Scene_panel2.Controls.Add(this.picture_PLAYER);
            this.Scene_panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scene_panel2.Location = new System.Drawing.Point(0, 0);
            this.Scene_panel2.Name = "Scene_panel2";
            this.Scene_panel2.Size = new System.Drawing.Size(800, 426);
            this.Scene_panel2.TabIndex = 2;
            this.Scene_panel2.Visible = false;
            // 
            // picture_Effect
            // 
            this.picture_Effect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_Effect.Location = new System.Drawing.Point(405, 250);
            this.picture_Effect.Name = "picture_Effect";
            this.picture_Effect.Size = new System.Drawing.Size(173, 145);
            this.picture_Effect.TabIndex = 14;
            this.picture_Effect.TabStop = false;
            this.picture_Effect.Visible = false;
            // 
            // picture_Ending
            // 
            this.picture_Ending.Location = new System.Drawing.Point(141, 45);
            this.picture_Ending.Name = "picture_Ending";
            this.picture_Ending.Size = new System.Drawing.Size(546, 322);
            this.picture_Ending.TabIndex = 13;
            this.picture_Ending.TabStop = false;
            this.picture_Ending.Visible = false;
            // 
            // LVup_BUTTON
            // 
            this.LVup_BUTTON.Location = new System.Drawing.Point(271, 216);
            this.LVup_BUTTON.Name = "LVup_BUTTON";
            this.LVup_BUTTON.Size = new System.Drawing.Size(95, 35);
            this.LVup_BUTTON.TabIndex = 12;
            this.LVup_BUTTON.Text = "LEVEL UP";
            this.LVup_BUTTON.UseVisualStyleBackColor = true;
            this.LVup_BUTTON.Click += new System.EventHandler(this.LVup_BUTTON_Click);
            // 
            // ATKBUTTON
            // 
            this.ATKBUTTON.Location = new System.Drawing.Point(271, 324);
            this.ATKBUTTON.Name = "ATKBUTTON";
            this.ATKBUTTON.Size = new System.Drawing.Size(95, 35);
            this.ATKBUTTON.TabIndex = 11;
            this.ATKBUTTON.Text = "ATTACK";
            this.ATKBUTTON.UseVisualStyleBackColor = true;
            this.ATKBUTTON.Click += new System.EventHandler(this.ATKBUTTON_Click);
            // 
            // SKILL_BUTTON
            // 
            this.SKILL_BUTTON.Location = new System.Drawing.Point(271, 271);
            this.SKILL_BUTTON.Name = "SKILL_BUTTON";
            this.SKILL_BUTTON.Size = new System.Drawing.Size(95, 35);
            this.SKILL_BUTTON.TabIndex = 10;
            this.SKILL_BUTTON.Text = "SKILL Dmg+20";
            this.SKILL_BUTTON.UseVisualStyleBackColor = true;
            this.SKILL_BUTTON.Click += new System.EventHandler(this.SKILL_BUTTON_Click);
            // 
            // label_ELevel
            // 
            this.label_ELevel.AutoSize = true;
            this.label_ELevel.Location = new System.Drawing.Point(582, 366);
            this.label_ELevel.Name = "label_ELevel";
            this.label_ELevel.Size = new System.Drawing.Size(47, 12);
            this.label_ELevel.TabIndex = 9;
            this.label_ELevel.Text = "LEVEL:";
            // 
            // label_EDmg
            // 
            this.label_EDmg.AutoSize = true;
            this.label_EDmg.Location = new System.Drawing.Point(582, 344);
            this.label_EDmg.Name = "label_EDmg";
            this.label_EDmg.Size = new System.Drawing.Size(37, 12);
            this.label_EDmg.TabIndex = 8;
            this.label_EDmg.Text = "DMG:";
            // 
            // label_EHp
            // 
            this.label_EHp.AutoSize = true;
            this.label_EHp.Location = new System.Drawing.Point(582, 321);
            this.label_EHp.Name = "label_EHp";
            this.label_EHp.Size = new System.Drawing.Size(33, 12);
            this.label_EHp.TabIndex = 7;
            this.label_EHp.Text = "HP : ";
            // 
            // label_EName
            // 
            this.label_EName.AutoSize = true;
            this.label_EName.Location = new System.Drawing.Point(582, 300);
            this.label_EName.Name = "label_EName";
            this.label_EName.Size = new System.Drawing.Size(53, 12);
            this.label_EName.TabIndex = 6;
            this.label_EName.Text = "NAME : ";
            // 
            // label_PLevel
            // 
            this.label_PLevel.AutoSize = true;
            this.label_PLevel.Location = new System.Drawing.Point(31, 90);
            this.label_PLevel.Name = "label_PLevel";
            this.label_PLevel.Size = new System.Drawing.Size(47, 12);
            this.label_PLevel.TabIndex = 5;
            this.label_PLevel.Text = "LEVEL:";
            // 
            // label_PDmg
            // 
            this.label_PDmg.AutoSize = true;
            this.label_PDmg.Location = new System.Drawing.Point(31, 68);
            this.label_PDmg.Name = "label_PDmg";
            this.label_PDmg.Size = new System.Drawing.Size(37, 12);
            this.label_PDmg.TabIndex = 4;
            this.label_PDmg.Text = "DMG:";
            // 
            // label_PHp
            // 
            this.label_PHp.AutoSize = true;
            this.label_PHp.Location = new System.Drawing.Point(31, 45);
            this.label_PHp.Name = "label_PHp";
            this.label_PHp.Size = new System.Drawing.Size(33, 12);
            this.label_PHp.TabIndex = 3;
            this.label_PHp.Text = "HP : ";
            // 
            // label_PName
            // 
            this.label_PName.AutoSize = true;
            this.label_PName.Location = new System.Drawing.Point(31, 24);
            this.label_PName.Name = "label_PName";
            this.label_PName.Size = new System.Drawing.Size(53, 12);
            this.label_PName.TabIndex = 2;
            this.label_PName.Text = "NAME : ";
            // 
            // picture_ENEMY
            // 
            this.picture_ENEMY.Location = new System.Drawing.Point(545, 0);
            this.picture_ENEMY.Name = "picture_ENEMY";
            this.picture_ENEMY.Size = new System.Drawing.Size(252, 279);
            this.picture_ENEMY.TabIndex = 1;
            this.picture_ENEMY.TabStop = false;
            // 
            // picture_PLAYER
            // 
            this.picture_PLAYER.Location = new System.Drawing.Point(3, 146);
            this.picture_PLAYER.Name = "picture_PLAYER";
            this.picture_PLAYER.Size = new System.Drawing.Size(252, 279);
            this.picture_PLAYER.TabIndex = 0;
            this.picture_PLAYER.TabStop = false;
            // 
            // Select_tunomon
            // 
            this.Select_tunomon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Select_tunomon.Image = ((System.Drawing.Image)(resources.GetObject("Select_tunomon.Image")));
            this.Select_tunomon.Location = new System.Drawing.Point(454, 68);
            this.Select_tunomon.Name = "Select_tunomon";
            this.Select_tunomon.Size = new System.Drawing.Size(256, 263);
            this.Select_tunomon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Select_tunomon.TabIndex = 1;
            this.Select_tunomon.TabStop = false;
            this.Select_tunomon.Click += new System.EventHandler(this.Select_tunomon_Click);
            // 
            // Select_coromon
            // 
            this.Select_coromon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Select_coromon.Image = ((System.Drawing.Image)(resources.GetObject("Select_coromon.Image")));
            this.Select_coromon.Location = new System.Drawing.Point(89, 68);
            this.Select_coromon.Name = "Select_coromon";
            this.Select_coromon.Size = new System.Drawing.Size(256, 263);
            this.Select_coromon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Select_coromon.TabIndex = 0;
            this.Select_coromon.TabStop = false;
            this.Select_coromon.Click += new System.EventHandler(this.Select_coromon_Click);
            // 
            // MAINLOGO
            // 
            this.MAINLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MAINLOGO.Image = ((System.Drawing.Image)(resources.GetObject("MAINLOGO.Image")));
            this.MAINLOGO.Location = new System.Drawing.Point(240, 83);
            this.MAINLOGO.Name = "MAINLOGO";
            this.MAINLOGO.Size = new System.Drawing.Size(338, 206);
            this.MAINLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MAINLOGO.TabIndex = 0;
            this.MAINLOGO.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(206, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(304, 122);
            this.dataGridView1.TabIndex = 15;
            // 
            // UnitLibrary
            // 
            this.UnitLibrary.Location = new System.Drawing.Point(210, 0);
            this.UnitLibrary.Name = "UnitLibrary";
            this.UnitLibrary.Size = new System.Drawing.Size(100, 33);
            this.UnitLibrary.TabIndex = 16;
            this.UnitLibrary.Text = "유닛도감";
            this.UnitLibrary.UseVisualStyleBackColor = true;
            this.UnitLibrary.Click += new System.EventHandler(this.UnitLibrary_Click);
            // 
            // DIGIMON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Scene_panel1);
            this.Controls.Add(this.STARTBUTTON);
            this.Controls.Add(this.MAINLOGO);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "DIGIMON";
            this.Text = "DIGIMON";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.Scene_panel1.ResumeLayout(false);
            this.Scene_panel2.ResumeLayout(false);
            this.Scene_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Effect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Ending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ENEMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_PLAYER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_tunomon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_coromon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAINLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MAINLOGO;
        private System.Windows.Forms.Button STARTBUTTON;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem oPTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QUITBUTTON;
        private System.Windows.Forms.Panel Scene_panel1;
        private System.Windows.Forms.PictureBox Select_tunomon;
        private System.Windows.Forms.PictureBox Select_coromon;
        private System.Windows.Forms.Panel Scene_panel2;
        private System.Windows.Forms.PictureBox picture_ENEMY;
        private System.Windows.Forms.PictureBox picture_PLAYER;
        private System.Windows.Forms.Label label_ELevel;
        private System.Windows.Forms.Label label_EDmg;
        private System.Windows.Forms.Label label_EHp;
        private System.Windows.Forms.Label label_EName;
        private System.Windows.Forms.Label label_PLevel;
        private System.Windows.Forms.Label label_PDmg;
        private System.Windows.Forms.Label label_PHp;
        private System.Windows.Forms.Label label_PName;
        private System.Windows.Forms.Button SKILL_BUTTON;
        private System.Windows.Forms.Button ATKBUTTON;
        private System.Windows.Forms.Button LVup_BUTTON;
        private System.Windows.Forms.PictureBox picture_Ending;
        private System.Windows.Forms.PictureBox picture_Effect;
        private System.Windows.Forms.Button UnitLibrary;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

