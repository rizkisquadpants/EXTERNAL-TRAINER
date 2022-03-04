
namespace TRAINER_EXTERNAL
{
    partial class MainForm
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
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.ProcIDIntLabel = new System.Windows.Forms.Label();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.chSpeedHack = new System.Windows.Forms.CheckBox();
            this.chWallHack = new System.Windows.Forms.CheckBox();
            this.chInvincible = new System.Windows.Forms.CheckBox();
            this.chInfiniteHealth = new System.Windows.Forms.CheckBox();
            this.chInfiniteGrenade = new System.Windows.Forms.CheckBox();
            this.chInfiniteAmmo = new System.Windows.Forms.CheckBox();
            this.chFreezeEnemi = new System.Windows.Forms.CheckBox();
            this.chOneHit = new System.Windows.Forms.CheckBox();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPointsKill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.chFreezeTime = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDll = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Location = new System.Drawing.Point(12, 19);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(42, 14);
            this.ProcOpenLabel.TabIndex = 0;
            this.ProcOpenLabel.Text = "label1";
            // 
            // ProcIDIntLabel
            // 
            this.ProcIDIntLabel.AutoSize = true;
            this.ProcIDIntLabel.Location = new System.Drawing.Point(12, 42);
            this.ProcIDIntLabel.Name = "ProcIDIntLabel";
            this.ProcIDIntLabel.Size = new System.Drawing.Size(42, 14);
            this.ProcIDIntLabel.TabIndex = 1;
            this.ProcIDIntLabel.Text = "label2";
            // 
            // BGW
            // 
            this.BGW.WorkerReportsProgress = true;
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGW_ProgressChanged);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // chSpeedHack
            // 
            this.chSpeedHack.AutoSize = true;
            this.chSpeedHack.Location = new System.Drawing.Point(31, 157);
            this.chSpeedHack.Name = "chSpeedHack";
            this.chSpeedHack.Size = new System.Drawing.Size(85, 18);
            this.chSpeedHack.TabIndex = 14;
            this.chSpeedHack.Text = "Speedhack";
            this.chSpeedHack.UseVisualStyleBackColor = true;
            // 
            // chWallHack
            // 
            this.chWallHack.AutoSize = true;
            this.chWallHack.Location = new System.Drawing.Point(31, 135);
            this.chWallHack.Name = "chWallHack";
            this.chWallHack.Size = new System.Drawing.Size(135, 18);
            this.chWallHack.TabIndex = 13;
            this.chWallHack.Text = "Walkthrought Walls";
            this.chWallHack.UseVisualStyleBackColor = true;
            // 
            // chInvincible
            // 
            this.chInvincible.AutoSize = true;
            this.chInvincible.Location = new System.Drawing.Point(31, 111);
            this.chInvincible.Name = "chInvincible";
            this.chInvincible.Size = new System.Drawing.Size(80, 18);
            this.chInvincible.TabIndex = 12;
            this.chInvincible.Text = "Invincible";
            this.chInvincible.UseVisualStyleBackColor = true;
            // 
            // chInfiniteHealth
            // 
            this.chInfiniteHealth.AutoSize = true;
            this.chInfiniteHealth.Location = new System.Drawing.Point(31, 87);
            this.chInfiniteHealth.Name = "chInfiniteHealth";
            this.chInfiniteHealth.Size = new System.Drawing.Size(105, 18);
            this.chInfiniteHealth.TabIndex = 11;
            this.chInfiniteHealth.Text = "Infinite Health";
            this.chInfiniteHealth.UseVisualStyleBackColor = true;
            // 
            // chInfiniteGrenade
            // 
            this.chInfiniteGrenade.AutoSize = true;
            this.chInfiniteGrenade.Location = new System.Drawing.Point(31, 205);
            this.chInfiniteGrenade.Name = "chInfiniteGrenade";
            this.chInfiniteGrenade.Size = new System.Drawing.Size(115, 18);
            this.chInfiniteGrenade.TabIndex = 16;
            this.chInfiniteGrenade.Text = "Infinite Grenade";
            this.chInfiniteGrenade.UseVisualStyleBackColor = true;
            // 
            // chInfiniteAmmo
            // 
            this.chInfiniteAmmo.AutoSize = true;
            this.chInfiniteAmmo.Location = new System.Drawing.Point(31, 181);
            this.chInfiniteAmmo.Name = "chInfiniteAmmo";
            this.chInfiniteAmmo.Size = new System.Drawing.Size(102, 18);
            this.chInfiniteAmmo.TabIndex = 15;
            this.chInfiniteAmmo.Text = "Infinite Ammo";
            this.chInfiniteAmmo.UseVisualStyleBackColor = true;
            // 
            // chFreezeEnemi
            // 
            this.chFreezeEnemi.AutoSize = true;
            this.chFreezeEnemi.Location = new System.Drawing.Point(31, 253);
            this.chFreezeEnemi.Name = "chFreezeEnemi";
            this.chFreezeEnemi.Size = new System.Drawing.Size(106, 18);
            this.chFreezeEnemi.TabIndex = 18;
            this.chFreezeEnemi.Text = "Freeze Enemie";
            this.chFreezeEnemi.UseVisualStyleBackColor = true;
            // 
            // chOneHit
            // 
            this.chOneHit.AutoSize = true;
            this.chOneHit.Location = new System.Drawing.Point(31, 229);
            this.chOneHit.Name = "chOneHit";
            this.chOneHit.Size = new System.Drawing.Size(92, 18);
            this.chOneHit.TabIndex = 17;
            this.chOneHit.Text = "One Hilt Kill";
            this.chOneHit.UseVisualStyleBackColor = true;
            // 
            // cbSpeed
            // 
            this.cbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeed.Enabled = false;
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            "Normal",
            "2x Speed",
            "3x Speed"});
            this.cbSpeed.Location = new System.Drawing.Point(122, 155);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(121, 22);
            this.cbSpeed.TabIndex = 19;
            this.cbSpeed.SelectedIndexChanged += new System.EventHandler(this.cbSpeed_SelectedIndexChanged);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(327, 99);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(135, 22);
            this.txtMoney.TabIndex = 20;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Points Kill ( Merchenaries )";
            // 
            // txtPointsKill
            // 
            this.txtPointsKill.Location = new System.Drawing.Point(327, 201);
            this.txtPointsKill.Name = "txtPointsKill";
            this.txtPointsKill.Size = new System.Drawing.Size(135, 22);
            this.txtPointsKill.TabIndex = 22;
            this.txtPointsKill.TextChanged += new System.EventHandler(this.txtPointsKill_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "Points ( Merchenaries )";
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(327, 149);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(135, 22);
            this.txtPoints.TabIndex = 24;
            this.txtPoints.TextChanged += new System.EventHandler(this.txtPoints_TextChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(41, 451);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(40, 14);
            this.lblTimer.TabIndex = 26;
            this.lblTimer.Text = "TIMER";
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(87, 448);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(100, 22);
            this.txtTimer.TabIndex = 27;
            // 
            // chFreezeTime
            // 
            this.chFreezeTime.AutoSize = true;
            this.chFreezeTime.Location = new System.Drawing.Point(327, 253);
            this.chFreezeTime.Name = "chFreezeTime";
            this.chFreezeTime.Size = new System.Drawing.Size(92, 18);
            this.chFreezeTime.TabIndex = 28;
            this.chFreezeTime.Text = "Freeze Time";
            this.chFreezeTime.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(324, 230);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 14);
            this.lblTime.TabIndex = 29;
            this.lblTime.Text = "00 : 00 : 00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 20);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDll
            // 
            this.txtDll.Location = new System.Drawing.Point(23, 399);
            this.txtDll.Name = "txtDll";
            this.txtDll.Size = new System.Drawing.Size(100, 22);
            this.txtDll.TabIndex = 31;
            this.txtDll.Text = "\\cdimgui.dll";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 24);
            this.button2.TabIndex = 32;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(285, 414);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(172, 24);
            this.progressBar.TabIndex = 33;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 550);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.chFreezeTime);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPointsKill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.cbSpeed);
            this.Controls.Add(this.chFreezeEnemi);
            this.Controls.Add(this.chOneHit);
            this.Controls.Add(this.chInfiniteGrenade);
            this.Controls.Add(this.chInfiniteAmmo);
            this.Controls.Add(this.chSpeedHack);
            this.Controls.Add(this.chWallHack);
            this.Controls.Add(this.chInvincible);
            this.Controls.Add(this.chInfiniteHealth);
            this.Controls.Add(this.ProcIDIntLabel);
            this.Controls.Add(this.ProcOpenLabel);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resident Evil 4 Ultimate HD Edition Trainer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Label ProcIDIntLabel;
        private System.ComponentModel.BackgroundWorker BGW;
        private System.Windows.Forms.CheckBox chSpeedHack;
        private System.Windows.Forms.CheckBox chWallHack;
        private System.Windows.Forms.CheckBox chInvincible;
        private System.Windows.Forms.CheckBox chInfiniteHealth;
        private System.Windows.Forms.CheckBox chInfiniteGrenade;
        private System.Windows.Forms.CheckBox chInfiniteAmmo;
        private System.Windows.Forms.CheckBox chFreezeEnemi;
        private System.Windows.Forms.CheckBox chOneHit;
        private System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPointsKill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.CheckBox chFreezeTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDll;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

