﻿
namespace BiServis
{
    partial class MsgYanlis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgYanlis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tamamBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.tamamBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 39);
            this.panel1.TabIndex = 3;
            // 
            // tamamBtn
            // 
            this.tamamBtn.ActiveBorderThickness = 1;
            this.tamamBtn.ActiveCornerRadius = 20;
            this.tamamBtn.ActiveFillColor = System.Drawing.Color.LightSlateGray;
            this.tamamBtn.ActiveForecolor = System.Drawing.Color.White;
            this.tamamBtn.ActiveLineColor = System.Drawing.Color.LightSlateGray;
            this.tamamBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tamamBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tamamBtn.BackgroundImage")));
            this.tamamBtn.ButtonText = "Tamam";
            this.tamamBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tamamBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tamamBtn.ForeColor = System.Drawing.Color.LightSlateGray;
            this.tamamBtn.IdleBorderThickness = 1;
            this.tamamBtn.IdleCornerRadius = 20;
            this.tamamBtn.IdleFillColor = System.Drawing.Color.White;
            this.tamamBtn.IdleForecolor = System.Drawing.Color.LightSlateGray;
            this.tamamBtn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.tamamBtn.Location = new System.Drawing.Point(193, 4);
            this.tamamBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tamamBtn.Name = "tamamBtn";
            this.tamamBtn.Size = new System.Drawing.Size(66, 30);
            this.tamamBtn.TabIndex = 0;
            this.tamamBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tamamBtn.Click += new System.EventHandler(this.tamamBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Cambria", 10F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.AliceBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(399, 16);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Girdiğiniz şifreler uyuşmuyor veya mail adresiniz yanlış girilmiş.";
            // 
            // MsgYanlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(450, 124);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgYanlis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgYanlis";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 tamamBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}