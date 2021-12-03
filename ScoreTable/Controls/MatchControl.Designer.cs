namespace ScoreTable.Controls
{
    partial class MatchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblState = new System.Windows.Forms.Label();
            this._lblName = new System.Windows.Forms.Label();
            this._lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblState
            // 
            this._lblState.AutoSize = true;
            this._lblState.Font = new System.Drawing.Font("Source Serif Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblState.Location = new System.Drawing.Point(99, 0);
            this._lblState.Name = "_lblState";
            this._lblState.Size = new System.Drawing.Size(22, 32);
            this._lblState.TabIndex = 0;
            this._lblState.Text = "-";
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this._lblName.Location = new System.Drawing.Point(22, 49);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(65, 28);
            this._lblName.TabIndex = 1;
            this._lblName.Text = "Name";
            // 
            // _lblScore
            // 
            this._lblScore.AutoSize = true;
            this._lblScore.BackColor = System.Drawing.SystemColors.Highlight;
            this._lblScore.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblScore.Location = new System.Drawing.Point(145, 49);
            this._lblScore.Name = "_lblScore";
            this._lblScore.Size = new System.Drawing.Size(36, 37);
            this._lblScore.TabIndex = 2;
            this._lblScore.Text = "0";
            // 
            // MatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblScore);
            this.Controls.Add(this._lblName);
            this.Controls.Add(this._lblState);
            this.Name = "MatchControl";
            this.Size = new System.Drawing.Size(211, 147);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblState;
        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.Label _lblScore;
    }
}
