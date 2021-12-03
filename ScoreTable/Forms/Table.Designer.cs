namespace ScoreTable.Forms
{
    partial class Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this._lblTitle = new System.Windows.Forms.Label();
            this._matchHome = new ScoreTable.Controls.MatchControl();
            this._matchHost = new ScoreTable.Controls.MatchControl();
            this._lblTime = new System.Windows.Forms.Label();
            this._pctPeriod1 = new System.Windows.Forms.PictureBox();
            this._boxFirst = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lblFirstHome = new System.Windows.Forms.Label();
            this._lblFirstHost = new System.Windows.Forms.Label();
            this._boxSecond = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._lblSecondHome = new System.Windows.Forms.Label();
            this._lblSecondHost = new System.Windows.Forms.Label();
            this._boxThird = new System.Windows.Forms.GroupBox();
            this._lblThirdHost = new System.Windows.Forms.Label();
            this._lblThirdHome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._btnNextPeriod = new System.Windows.Forms.Button();
            this._pctPeriod2 = new System.Windows.Forms.PictureBox();
            this._pctPeriod3 = new System.Windows.Forms.PictureBox();
            this._pctPeriod4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._pctPeriod1)).BeginInit();
            this._boxFirst.SuspendLayout();
            this._boxSecond.SuspendLayout();
            this._boxThird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pctPeriod2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pctPeriod3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pctPeriod4)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblTitle
            // 
            this._lblTitle.AutoSize = true;
            this._lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblTitle.Location = new System.Drawing.Point(269, 3);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(256, 35);
            this._lblTitle.TabIndex = 0;
            this._lblTitle.Text = "Table of Match";
            // 
            // _matchHome
            // 
            this._matchHome.Location = new System.Drawing.Point(83, 89);
            this._matchHome.Name = "_matchHome";
            this._matchHome.Size = new System.Drawing.Size(264, 184);
            this._matchHome.TabIndex = 1;
            // 
            // _matchHost
            // 
            this._matchHost.Location = new System.Drawing.Point(455, 89);
            this._matchHost.Name = "_matchHost";
            this._matchHost.Size = new System.Drawing.Size(264, 184);
            this._matchHost.TabIndex = 2;
            // 
            // _lblTime
            // 
            this._lblTime.AutoSize = true;
            this._lblTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this._lblTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this._lblTime.Location = new System.Drawing.Point(353, 246);
            this._lblTime.Name = "_lblTime";
            this._lblTime.Size = new System.Drawing.Size(36, 49);
            this._lblTime.TabIndex = 3;
            this._lblTime.Text = "-";
            // 
            // _pctPeriod1
            // 
            this._pctPeriod1.Image = ((System.Drawing.Image)(resources.GetObject("_pctPeriod1.Image")));
            this._pctPeriod1.Location = new System.Drawing.Point(332, 41);
            this._pctPeriod1.Name = "_pctPeriod1";
            this._pctPeriod1.Size = new System.Drawing.Size(100, 100);
            this._pctPeriod1.TabIndex = 4;
            this._pctPeriod1.TabStop = false;
            // 
            // _boxFirst
            // 
            this._boxFirst.Controls.Add(this.label2);
            this._boxFirst.Controls.Add(this.label1);
            this._boxFirst.Controls.Add(this._lblFirstHome);
            this._boxFirst.Controls.Add(this._lblFirstHost);
            this._boxFirst.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this._boxFirst.Location = new System.Drawing.Point(21, 368);
            this._boxFirst.Name = "_boxFirst";
            this._boxFirst.Size = new System.Drawing.Size(250, 125);
            this._boxFirst.TabIndex = 5;
            this._boxFirst.TabStop = false;
            this._boxFirst.Text = "First Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(164, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Host";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // _lblFirstHome
            // 
            this._lblFirstHome.AutoSize = true;
            this._lblFirstHome.BackColor = System.Drawing.Color.Fuchsia;
            this._lblFirstHome.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblFirstHome.Location = new System.Drawing.Point(40, 59);
            this._lblFirstHome.Name = "_lblFirstHome";
            this._lblFirstHome.Size = new System.Drawing.Size(33, 35);
            this._lblFirstHome.TabIndex = 6;
            this._lblFirstHome.Text = "0";
            // 
            // _lblFirstHost
            // 
            this._lblFirstHost.AutoSize = true;
            this._lblFirstHost.BackColor = System.Drawing.Color.Fuchsia;
            this._lblFirstHost.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblFirstHost.Location = new System.Drawing.Point(175, 59);
            this._lblFirstHost.Name = "_lblFirstHost";
            this._lblFirstHost.Size = new System.Drawing.Size(33, 35);
            this._lblFirstHost.TabIndex = 7;
            this._lblFirstHost.Text = "0";
            // 
            // _boxSecond
            // 
            this._boxSecond.Controls.Add(this.label3);
            this._boxSecond.Controls.Add(this.label4);
            this._boxSecond.Controls.Add(this._lblSecondHome);
            this._boxSecond.Controls.Add(this._lblSecondHost);
            this._boxSecond.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this._boxSecond.Location = new System.Drawing.Point(294, 368);
            this._boxSecond.Name = "_boxSecond";
            this._boxSecond.Size = new System.Drawing.Size(250, 125);
            this._boxSecond.TabIndex = 0;
            this._boxSecond.TabStop = false;
            this._boxSecond.Text = "Second Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Home";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(164, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Host";
            // 
            // _lblSecondHome
            // 
            this._lblSecondHome.AutoSize = true;
            this._lblSecondHome.BackColor = System.Drawing.Color.Fuchsia;
            this._lblSecondHome.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblSecondHome.Location = new System.Drawing.Point(40, 59);
            this._lblSecondHome.Name = "_lblSecondHome";
            this._lblSecondHome.Size = new System.Drawing.Size(33, 35);
            this._lblSecondHome.TabIndex = 8;
            this._lblSecondHome.Text = "0";
            // 
            // _lblSecondHost
            // 
            this._lblSecondHost.AutoSize = true;
            this._lblSecondHost.BackColor = System.Drawing.Color.Fuchsia;
            this._lblSecondHost.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblSecondHost.Location = new System.Drawing.Point(175, 59);
            this._lblSecondHost.Name = "_lblSecondHost";
            this._lblSecondHost.Size = new System.Drawing.Size(33, 35);
            this._lblSecondHost.TabIndex = 9;
            this._lblSecondHost.Text = "0";
            // 
            // _boxThird
            // 
            this._boxThird.Controls.Add(this._lblThirdHost);
            this._boxThird.Controls.Add(this._lblThirdHome);
            this._boxThird.Controls.Add(this.label6);
            this._boxThird.Controls.Add(this.label5);
            this._boxThird.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this._boxThird.Location = new System.Drawing.Point(569, 368);
            this._boxThird.Name = "_boxThird";
            this._boxThird.Size = new System.Drawing.Size(250, 125);
            this._boxThird.TabIndex = 0;
            this._boxThird.TabStop = false;
            this._boxThird.Text = "Third Period";
            // 
            // _lblThirdHost
            // 
            this._lblThirdHost.AutoSize = true;
            this._lblThirdHost.BackColor = System.Drawing.Color.Fuchsia;
            this._lblThirdHost.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblThirdHost.Location = new System.Drawing.Point(175, 59);
            this._lblThirdHost.Name = "_lblThirdHost";
            this._lblThirdHost.Size = new System.Drawing.Size(33, 35);
            this._lblThirdHost.TabIndex = 11;
            this._lblThirdHost.Text = "0";
            // 
            // _lblThirdHome
            // 
            this._lblThirdHome.AutoSize = true;
            this._lblThirdHome.BackColor = System.Drawing.Color.Fuchsia;
            this._lblThirdHome.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblThirdHome.Location = new System.Drawing.Point(40, 59);
            this._lblThirdHome.Name = "_lblThirdHome";
            this._lblThirdHome.Size = new System.Drawing.Size(33, 35);
            this._lblThirdHome.TabIndex = 10;
            this._lblThirdHome.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(164, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Host";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Home";
            // 
            // _btnNextPeriod
            // 
            this._btnNextPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            this._btnNextPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnNextPeriod.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnNextPeriod.Location = new System.Drawing.Point(660, 246);
            this._btnNextPeriod.MaximumSize = new System.Drawing.Size(200, 100);
            this._btnNextPeriod.MinimumSize = new System.Drawing.Size(100, 50);
            this._btnNextPeriod.Name = "_btnNextPeriod";
            this._btnNextPeriod.Size = new System.Drawing.Size(159, 65);
            this._btnNextPeriod.TabIndex = 10;
            this._btnNextPeriod.Text = "Next Period";
            this._btnNextPeriod.UseVisualStyleBackColor = false;
            this._btnNextPeriod.Visible = false;
            this._btnNextPeriod.Click += new System.EventHandler(this._btnNextPeriod_Click);
            // 
            // _pctPeriod2
            // 
            this._pctPeriod2.Image = ((System.Drawing.Image)(resources.GetObject("_pctPeriod2.Image")));
            this._pctPeriod2.Location = new System.Drawing.Point(334, 41);
            this._pctPeriod2.Name = "_pctPeriod2";
            this._pctPeriod2.Size = new System.Drawing.Size(100, 100);
            this._pctPeriod2.TabIndex = 11;
            this._pctPeriod2.TabStop = false;
            this._pctPeriod2.Visible = false;
            // 
            // _pctPeriod3
            // 
            this._pctPeriod3.Image = ((System.Drawing.Image)(resources.GetObject("_pctPeriod3.Image")));
            this._pctPeriod3.Location = new System.Drawing.Point(334, 41);
            this._pctPeriod3.Name = "_pctPeriod3";
            this._pctPeriod3.Size = new System.Drawing.Size(100, 100);
            this._pctPeriod3.TabIndex = 12;
            this._pctPeriod3.TabStop = false;
            this._pctPeriod3.Visible = false;
            // 
            // _pctPeriod4
            // 
            this._pctPeriod4.Image = ((System.Drawing.Image)(resources.GetObject("_pctPeriod4.Image")));
            this._pctPeriod4.Location = new System.Drawing.Point(334, 41);
            this._pctPeriod4.Name = "_pctPeriod4";
            this._pctPeriod4.Size = new System.Drawing.Size(100, 100);
            this._pctPeriod4.TabIndex = 13;
            this._pctPeriod4.TabStop = false;
            this._pctPeriod4.Visible = false;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 517);
            this.Controls.Add(this._pctPeriod4);
            this.Controls.Add(this._pctPeriod3);
            this.Controls.Add(this._pctPeriod2);
            this.Controls.Add(this._btnNextPeriod);
            this.Controls.Add(this._boxSecond);
            this.Controls.Add(this._boxThird);
            this.Controls.Add(this._boxFirst);
            this.Controls.Add(this._pctPeriod1);
            this.Controls.Add(this._lblTime);
            this.Controls.Add(this._matchHost);
            this.Controls.Add(this._matchHome);
            this.Controls.Add(this._lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Table";
            this.Text = "Table";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Table_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this._pctPeriod1)).EndInit();
            this._boxFirst.ResumeLayout(false);
            this._boxFirst.PerformLayout();
            this._boxSecond.ResumeLayout(false);
            this._boxSecond.PerformLayout();
            this._boxThird.ResumeLayout(false);
            this._boxThird.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pctPeriod2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pctPeriod3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pctPeriod4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblTitle;
        private Controls.MatchControl _matchHome;
        private Controls.MatchControl _matchHost;
        private System.Windows.Forms.Label _lblTime;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.PictureBox _pctPeriod1;
        private System.Windows.Forms.GroupBox _boxFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblFirstHome;
        private System.Windows.Forms.Label _lblFirstHost;
        private System.Windows.Forms.GroupBox _boxSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblSecondHome;
        private System.Windows.Forms.Label _lblSecondHost;
        private System.Windows.Forms.GroupBox _boxThird;
        private System.Windows.Forms.Label _lblThirdHost;
        private System.Windows.Forms.Label _lblThirdHome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _btnNextPeriod;
        private System.Windows.Forms.PictureBox _pctPeriod2;
        private System.Windows.Forms.PictureBox _pctPeriod3;
        private System.Windows.Forms.PictureBox _pctPeriod4;
    }
}