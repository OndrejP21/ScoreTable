namespace ScoreTable.Forms
{
    partial class TotalScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lblHomeTotalScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._lblHostTotalScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._lblWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "End of Match – final score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home";
            // 
            // _lblHomeTotalScore
            // 
            this._lblHomeTotalScore.AutoSize = true;
            this._lblHomeTotalScore.BackColor = System.Drawing.Color.Blue;
            this._lblHomeTotalScore.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblHomeTotalScore.Location = new System.Drawing.Point(107, 104);
            this._lblHomeTotalScore.Name = "_lblHomeTotalScore";
            this._lblHomeTotalScore.Size = new System.Drawing.Size(28, 29);
            this._lblHomeTotalScore.TabIndex = 2;
            this._lblHomeTotalScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(365, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Host";
            // 
            // _lblHostTotalScore
            // 
            this._lblHostTotalScore.AutoSize = true;
            this._lblHostTotalScore.BackColor = System.Drawing.Color.Blue;
            this._lblHostTotalScore.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblHostTotalScore.Location = new System.Drawing.Point(379, 104);
            this._lblHostTotalScore.Name = "_lblHostTotalScore";
            this._lblHostTotalScore.Size = new System.Drawing.Size(28, 29);
            this._lblHostTotalScore.TabIndex = 4;
            this._lblHostTotalScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Winner:";
            // 
            // _lblWinner
            // 
            this._lblWinner.AutoSize = true;
            this._lblWinner.BackColor = System.Drawing.Color.Gold;
            this._lblWinner.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblWinner.Location = new System.Drawing.Point(245, 188);
            this._lblWinner.Name = "_lblWinner";
            this._lblWinner.Size = new System.Drawing.Size(51, 29);
            this._lblWinner.TabIndex = 6;
            this._lblWinner.Text = "Tie";
            // 
            // TotalScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 254);
            this.Controls.Add(this._lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._lblHostTotalScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._lblHomeTotalScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TotalScore";
            this.Text = "TotalScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblHomeTotalScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblHostTotalScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _lblWinner;
    }
}