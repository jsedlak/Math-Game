namespace MathGame
{
    partial class frmNewGame
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
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PlayerOneCharacterDropDown = new System.Windows.Forms.ComboBox();
            this.PlayerTwoCharacterDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSingle
            // 
            this.btnSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingle.Location = new System.Drawing.Point(12, 12);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(150, 100);
            this.btnSingle.TabIndex = 0;
            this.btnSingle.Text = "Single Player (Human vs. Computer)";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(168, 12);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(150, 100);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "Two Player (Human vs. Human)";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(232, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 48);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PlayerOneCharacterDropDown
            // 
            this.PlayerOneCharacterDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayerOneCharacterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerOneCharacterDropDown.FormattingEnabled = true;
            this.PlayerOneCharacterDropDown.Items.AddRange(new object[] {
            "Cowboy",
            "Cowgirl",
            "Bandit",
            "Sheriff"});
            this.PlayerOneCharacterDropDown.Location = new System.Drawing.Point(81, 117);
            this.PlayerOneCharacterDropDown.Name = "PlayerOneCharacterDropDown";
            this.PlayerOneCharacterDropDown.Size = new System.Drawing.Size(121, 21);
            this.PlayerOneCharacterDropDown.TabIndex = 7;
            // 
            // PlayerTwoCharacterDropDown
            // 
            this.PlayerTwoCharacterDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayerTwoCharacterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerTwoCharacterDropDown.FormattingEnabled = true;
            this.PlayerTwoCharacterDropDown.Items.AddRange(new object[] {
            "Cowboy",
            "Cowgirl",
            "Bandit",
            "Sheriff"});
            this.PlayerTwoCharacterDropDown.Location = new System.Drawing.Point(81, 144);
            this.PlayerTwoCharacterDropDown.Name = "PlayerTwoCharacterDropDown";
            this.PlayerTwoCharacterDropDown.Size = new System.Drawing.Size(121, 21);
            this.PlayerTwoCharacterDropDown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player One:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player Two:";
            // 
            // frmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 177);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerTwoCharacterDropDown);
            this.Controls.Add(this.PlayerOneCharacterDropDown);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSingle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewGame";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.frmNewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox PlayerOneCharacterDropDown;
        private System.Windows.Forms.ComboBox PlayerTwoCharacterDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}