namespace ScoreTable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnStop = new System.Windows.Forms.Button();
            this._btnStart = new System.Windows.Forms.Button();
            this._lblCurrentTime = new System.Windows.Forms.Label();
            this._home = new ScoreTable.Controls.TeamEditControl();
            this._host = new ScoreTable.Controls.TeamEditControl();
            this.SuspendLayout();
            // 
            // _btnStop
            // 
            this._btnStop.Location = new System.Drawing.Point(21, 409);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(94, 29);
            this._btnStop.TabIndex = 0;
            this._btnStop.Text = "Stop";
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
            // 
            // _btnStart
            // 
            this._btnStart.Location = new System.Drawing.Point(143, 409);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(94, 29);
            this._btnStart.TabIndex = 1;
            this._btnStart.Text = "Start";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _lblCurrentTime
            // 
            this._lblCurrentTime.AutoSize = true;
            this._lblCurrentTime.Location = new System.Drawing.Point(688, 23);
            this._lblCurrentTime.Name = "_lblCurrentTime";
            this._lblCurrentTime.Size = new System.Drawing.Size(15, 20);
            this._lblCurrentTime.TabIndex = 2;
            this._lblCurrentTime.Text = "-";
            // 
            // _home
            // 
            this._home.Location = new System.Drawing.Point(33, 45);
            this._home.Name = "_home";
            this._home.Size = new System.Drawing.Size(316, 302);
            this._home.TabIndex = 3;
            // 
            // _host
            // 
            this._host.Location = new System.Drawing.Point(345, 45);
            this._host.Name = "_host";
            this._host.Size = new System.Drawing.Size(316, 302);
            this._host.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._host);
            this.Controls.Add(this._home);
            this.Controls.Add(this._lblCurrentTime);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._btnStop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnStop;
        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.Label _lblCurrentTime;
        private Controls.TeamEditControl _home;
        private Controls.TeamEditControl _host;
    }
}
