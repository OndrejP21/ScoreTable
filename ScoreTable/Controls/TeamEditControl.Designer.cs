namespace ScoreTable.Controls
{
    partial class TeamEditControl
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
            this._btnApply = new System.Windows.Forms.Button();
            this._txtTeamName = new System.Windows.Forms.TextBox();
            this._numScore = new System.Windows.Forms.NumericUpDown();
            this._lblTeamType = new System.Windows.Forms.Label();
            this._lblScore = new System.Windows.Forms.Label();
            this._btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnApply
            // 
            this._btnApply.Location = new System.Drawing.Point(125, 84);
            this._btnApply.Name = "_btnApply";
            this._btnApply.Size = new System.Drawing.Size(94, 29);
            this._btnApply.TabIndex = 0;
            this._btnApply.Text = "Apply";
            this._btnApply.UseVisualStyleBackColor = true;
            this._btnApply.Click += new System.EventHandler(this._btnApply_Click);
            // 
            // _txtTeamName
            // 
            this._txtTeamName.Location = new System.Drawing.Point(26, 51);
            this._txtTeamName.Name = "_txtTeamName";
            this._txtTeamName.Size = new System.Drawing.Size(193, 27);
            this._txtTeamName.TabIndex = 1;
            // 
            // _numScore
            // 
            this._numScore.Enabled = false;
            this._numScore.Location = new System.Drawing.Point(26, 182);
            this._numScore.Name = "_numScore";
            this._numScore.Size = new System.Drawing.Size(193, 27);
            this._numScore.TabIndex = 2;
            this._numScore.ValueChanged += new System.EventHandler(this._numScore_ValueChanged);
            // 
            // _lblTeamType
            // 
            this._lblTeamType.AutoSize = true;
            this._lblTeamType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblTeamType.Location = new System.Drawing.Point(26, 16);
            this._lblTeamType.Name = "_lblTeamType";
            this._lblTeamType.Size = new System.Drawing.Size(24, 32);
            this._lblTeamType.TabIndex = 3;
            this._lblTeamType.Text = "-";
            // 
            // _lblScore
            // 
            this._lblScore.AutoSize = true;
            this._lblScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblScore.Location = new System.Drawing.Point(94, 149);
            this._lblScore.Name = "_lblScore";
            this._lblScore.Size = new System.Drawing.Size(58, 23);
            this._lblScore.TabIndex = 4;
            this._lblScore.Text = "Score";
            // 
            // _btnAdd
            // 
            this._btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnAdd.Location = new System.Drawing.Point(50, 226);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(141, 46);
            this._btnAdd.TabIndex = 5;
            this._btnAdd.Text = "ADD POINT";
            this._btnAdd.UseVisualStyleBackColor = false;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // TeamEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._lblScore);
            this.Controls.Add(this._lblTeamType);
            this.Controls.Add(this._numScore);
            this.Controls.Add(this._txtTeamName);
            this.Controls.Add(this._btnApply);
            this.Name = "TeamEditControl";
            this.Size = new System.Drawing.Size(253, 284);
            ((System.ComponentModel.ISupportInitialize)(this._numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnApply;
        private System.Windows.Forms.TextBox _txtTeamName;
        private System.Windows.Forms.NumericUpDown _numScore;
        private System.Windows.Forms.Label _lblTeamType;
        private System.Windows.Forms.Label _lblScore;
        private System.Windows.Forms.Button _btnAdd;
    }
}
