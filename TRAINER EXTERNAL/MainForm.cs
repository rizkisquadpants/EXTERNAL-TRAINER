using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace TRAINER_EXTERNAL
{
    public partial class MainForm : Form
    {
        public Mem mem = new Mem();
        private bool IsProcOpen;
        private int ProcessID;

        public MainForm()
        {

            InitializeComponent();
        }
        
        //======================================================================================================================================================
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            BGW.RunWorkerAsync();
            cbSpeed.SelectedIndex = 0;
        }
        
        //======================================================================================================================================================
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessID = mem.GetProcIdFromName("bio4");
            if (ProcessID != 0)
            {
                IsProcOpen = mem.OpenProcess(ProcessID);
                Thread.Sleep(100);
                BGW.ReportProgress(0);
            }
            else
            {
                ProcOpenLabel.Invoke(new MethodInvoker(delegate
                {
                    ProcOpenLabel.Text = "NONE";
                }));
                ProcIDIntLabel.Invoke(new MethodInvoker(delegate
                {
                    ProcIDIntLabel.Text = "NONE";
                }));
            }
        }
        
        //======================================================================================================================================================
        private void BGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (IsProcOpen)
            {
                ProcOpenLabel.Text = "bio4.exe";
                ProcIDIntLabel.Text = ProcessID.ToString();

                // CALL CHEAT
                PlayerHack();
                WeaponHack();
                EnemieHack();
                ETCHack();
                MoneyHack(txtMoney,txtPoints,txtPointsKill);
                GetTime(lblTime);
                Timer(txtTimer);

            }
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        //======================================================================================================================================================
        private void GetTime(Label Time)
        {
            Time.Text = mem.ReadByte("base+84D814").ToString() + " : " + mem.ReadByte("base+84D815").ToString() + " : " + mem.ReadByte("base+84D816").ToString();
        }

        private void MoneyHack(TextBox Money, TextBox Points, TextBox PointsKill)
        {
            Money.Text = mem.ReadInt(BaseAddress.Address.Money).ToString();
            Points.Text = mem.ReadInt(BaseAddress.Address.Points).ToString();
            PointsKill.Text = mem.ReadInt(BaseAddress.Address.PointsKill).ToString();
        }

        private void Timer(TextBox Timer)
        {
            Timer.Text = mem.ReadFloat(BaseAddress.Address.Timer).ToString();
        }

        private void PlayerHack()
        {
            if (chInfiniteHealth.Checked)
            {
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInfiniteHP1, "bytes", BaseAddress.PlayerAddr.OnInfiniteHP1);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInfiniteHP2, "bytes", BaseAddress.PlayerAddr.OnInfiniteHP2);
            }
            else
            {
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInfiniteHP1, "bytes", BaseAddress.PlayerAddr.OffInfiniteHP1);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInfiniteHP2, "bytes", BaseAddress.PlayerAddr.OffInfiniteHP2);
            }

            if (chInvincible.Checked)
            {
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible1, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible2, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible3, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible4, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible5, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible6, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible7, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible8, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible9, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible10, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible11, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible12, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible13, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible14, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible15, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible16, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible17, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible18, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible19, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible20, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible21, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible22, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible23, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible24, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible25, "bytes", BaseAddress.PlayerAddr.OnInvincible25);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible26, "bytes", BaseAddress.PlayerAddr.OnInvincible26);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible27, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible28, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible29, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible30, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible31, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible32, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible33, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible34, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible35, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible36, "bytes", BaseAddress.PlayerAddr.OnInvincibleC3);

                mem.WriteMemory(BaseAddress.PlayerAddr.NoDamage1, "int", "32768");
                mem.WriteMemory(BaseAddress.PlayerAddr.NoDamage2, "int", "32768");
            }
            else
            {
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible1, "bytes", BaseAddress.PlayerAddr.OffInvincible1);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible2, "bytes", BaseAddress.PlayerAddr.OffInvincible2);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible3, "bytes", BaseAddress.PlayerAddr.OffInvincible3);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible4, "bytes", BaseAddress.PlayerAddr.OffInvincible4);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible5, "bytes", BaseAddress.PlayerAddr.OffInvincible5);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible6, "bytes", BaseAddress.PlayerAddr.OffInvincible6);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible7, "bytes", BaseAddress.PlayerAddr.OffInvincible7);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible8, "bytes", BaseAddress.PlayerAddr.OffInvincible8);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible9, "bytes", BaseAddress.PlayerAddr.OffInvincible9);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible10, "bytes", BaseAddress.PlayerAddr.OffInvincible10);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible11, "bytes", BaseAddress.PlayerAddr.OffInvincible11);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible12, "bytes", BaseAddress.PlayerAddr.OffInvincible12);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible13, "bytes", BaseAddress.PlayerAddr.OffInvincible13);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible14, "bytes", BaseAddress.PlayerAddr.OffInvincible14);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible15, "bytes", BaseAddress.PlayerAddr.OffInvincible15);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible16, "bytes", BaseAddress.PlayerAddr.OffInvincible16);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible17, "bytes", BaseAddress.PlayerAddr.OffInvincible17);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible18, "bytes", BaseAddress.PlayerAddr.OffInvincible18);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible19, "bytes", BaseAddress.PlayerAddr.OffInvincible19);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible20, "bytes", BaseAddress.PlayerAddr.OffInvincible20);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible21, "bytes", BaseAddress.PlayerAddr.OffInvincible21);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible22, "bytes", BaseAddress.PlayerAddr.OffInvincible22);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible23, "bytes", BaseAddress.PlayerAddr.OffInvincible23);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible24, "bytes", BaseAddress.PlayerAddr.OffInvincible24);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible25, "bytes", BaseAddress.PlayerAddr.OffInvincible25);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible26, "bytes", BaseAddress.PlayerAddr.OffInvincible26);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible27, "bytes", BaseAddress.PlayerAddr.OffInvincible27);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible28, "bytes", BaseAddress.PlayerAddr.OffInvincible28);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible29, "bytes", BaseAddress.PlayerAddr.OffInvincible29);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible30, "bytes", BaseAddress.PlayerAddr.OffInvincible30);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible31, "bytes", BaseAddress.PlayerAddr.OffInvincible31);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible32, "bytes", BaseAddress.PlayerAddr.OffInvincible32);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible33, "bytes", BaseAddress.PlayerAddr.OffInvincible33);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible34, "bytes", BaseAddress.PlayerAddr.OffInvincible34);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible35, "bytes", BaseAddress.PlayerAddr.OffInvincible35);
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrInvincible36, "bytes", BaseAddress.PlayerAddr.OffInvincible36);

                mem.WriteMemory(BaseAddress.PlayerAddr.NoDamage1, "int", "0");
                mem.WriteMemory(BaseAddress.PlayerAddr.NoDamage2, "int", "0");
            }

            if (chWallHack.Checked)
            {
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrWallHack, "bytes", BaseAddress.PlayerAddr.OnWallHack);
            }
            else
            {
                mem.WriteMemory(BaseAddress.PlayerAddr.AddrWallHack, "bytes", BaseAddress.PlayerAddr.OffWallHack);
            }


            if (chSpeedHack.Checked)
            {
                cbSpeed.Enabled = true;
            
                int Index = cbSpeed.SelectedIndex;
                if (Index == 0)
                {
                    mem.WriteMemory(BaseAddress.PlayerAddr.AddrSpeedHack, "float", "1");
                }
                if (Index == 1)
                {
                    mem.WriteMemory(BaseAddress.PlayerAddr.AddrSpeedHack, "float", "2");
                }
                if (Index == 2)
                {
                    mem.WriteMemory(BaseAddress.PlayerAddr.AddrSpeedHack, "float", "3");
                }
            }
            else
            {
                cbSpeed.Enabled = false;
            }
        }

        private void WeaponHack()
        {
            if (chInfiniteAmmo.Checked)
            {
                mem.WriteMemory(BaseAddress.WeaponAddr.AddrAmmo, "bytes", BaseAddress.WeaponAddr.OnWeapon);
            }
            else
            {
                mem.WriteMemory(BaseAddress.WeaponAddr.AddrAmmo, "bytes", BaseAddress.WeaponAddr.OffAmmo);
            }

            if (chInfiniteGrenade.Checked)
            {
                mem.WriteMemory(BaseAddress.WeaponAddr.AddrGrenade, "bytes", BaseAddress.WeaponAddr.OnWeapon);
            }
            else
            {
                mem.WriteMemory(BaseAddress.WeaponAddr.AddrGrenade, "bytes", BaseAddress.WeaponAddr.OffGrenade);
            }
        }

        private void EnemieHack()
        {
            if (chFreezeEnemi.Checked)
            {
                mem.WriteMemory(BaseAddress.EnemieAddr.AddrFreezeEnemi, "bytes", BaseAddress.EnemieAddr.OnFreezeEnemi);
            }
            else
            {
                mem.WriteMemory(BaseAddress.EnemieAddr.AddrFreezeEnemi, "bytes", BaseAddress.EnemieAddr.OffFreezeEnemi);
            }

            if (chOneHit.Checked)
            {
                mem.WriteMemory(BaseAddress.EnemieAddr.AddrOneHit, "bytes", BaseAddress.EnemieAddr.OnOneHit);
            }
            else
            {
                int BaseOffNormal = mem.ReadInt("base+1B5D6E");
                if (BaseOffNormal != 616442214)
                {
                    mem.WriteMemory(BaseAddress.EnemieAddr.AddrOneHit, "bytes", BaseAddress.EnemieAddr.OffOneHit);
                }
                    
            }
        }


        private void ETCHack()
        {
            if(chFreezeTime.Checked)
            {
                mem.WriteMemory(BaseAddress.Address.Timer, "float", txtTimer.Text);
            }
            else
            {
                mem.UnfreezeValue(BaseAddress.Address.Timer);
            }
        }


        private void cbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtMoney.Text == "")
                {
                    txtMoney.Text = "0";
                }
                else
                {
                    mem.WriteMemory(BaseAddress.Address.Money, "int", txtMoney.Text);
                }
            }

            catch
            {
                MessageBox.Show("Error !!! please enter only numbers", "RE4UHD Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtPoints.Text == "")
                {
                    txtPoints.Text = "0";
                }
                else
                {
                    mem.WriteMemory(BaseAddress.Address.Points, "int", txtPoints.Text);
                }
            }

            catch
            {
                MessageBox.Show("Error !!! please enter only numbers", "RE4UHD Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPointsKill_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtPointsKill.Text == "")
                {
                    txtPointsKill.Text = "0";
                }
                else
                {
                    mem.WriteMemory(BaseAddress.Address.PointsKill, "int", txtPointsKill.Text);
                }
            }

            catch
            {
                MessageBox.Show("Error !!! please enter only numbers", "RE4UHD Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MyDll = Properties.Resources.cdimgui;


            //mem.InjectDll(MyDll.);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri("https://github.com/rizkisquadpants/RE4UHD/raw/main/cdimgui.dll"),
                    // Param2 = Path to save
                    "D:\\Base.dll"
                );
            }
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
    }

}
