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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerTwoNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoNameLabel = new System.Windows.Forms.Label();
            this.PlayerOneNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerOneNameLabel = new System.Windows.Forms.Label();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSingle
            // 
            this.btnSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSingle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSingle.Location = new System.Drawing.Point(44, 214);
            this.btnSingle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(159, 34);
            this.btnSingle.TabIndex = 1;
            this.btnSingle.Text = "Play the Computer";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMulti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMulti.Location = new System.Drawing.Point(210, 214);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(118, 34);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "Two Player";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please choose names and select whether you want to play against the computer, or " +
    "against another human. Player One is represented by the Triangle. Player Two is " +
    "represented by the Circle.";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.Location = new System.Drawing.Point(340, 214);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DestinationBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PlayerTwoNameTextBox);
            this.groupBox1.Controls.Add(this.PlayerTwoNameLabel);
            this.groupBox1.Controls.Add(this.PlayerOneNameTextBox);
            this.groupBox1.Controls.Add(this.PlayerOneNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(425, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Information";
            // 
            // PlayerTwoNameTextBox
            // 
            this.PlayerTwoNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerTwoNameTextBox.Location = new System.Drawing.Point(131, 52);
            this.PlayerTwoNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayerTwoNameTextBox.Name = "PlayerTwoNameTextBox";
            this.PlayerTwoNameTextBox.Size = new System.Drawing.Size(287, 23);
            this.PlayerTwoNameTextBox.TabIndex = 1;
            this.PlayerTwoNameTextBox.TextChanged += new System.EventHandler(this.PlayerTwoNameTextBox_TextChanged);
            // 
            // PlayerTwoNameLabel
            // 
            this.PlayerTwoNameLabel.Location = new System.Drawing.Point(7, 56);
            this.PlayerTwoNameLabel.Name = "PlayerTwoNameLabel";
            this.PlayerTwoNameLabel.Size = new System.Drawing.Size(117, 19);
            this.PlayerTwoNameLabel.TabIndex = 3;
            this.PlayerTwoNameLabel.Text = "Player Two Name:";
            // 
            // PlayerOneNameTextBox
            // 
            this.PlayerOneNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerOneNameTextBox.Location = new System.Drawing.Point(131, 22);
            this.PlayerOneNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayerOneNameTextBox.Name = "PlayerOneNameTextBox";
            this.PlayerOneNameTextBox.Size = new System.Drawing.Size(287, 23);
            this.PlayerOneNameTextBox.TabIndex = 0;
            this.PlayerOneNameTextBox.TextChanged += new System.EventHandler(this.PlayerOneNameTextBox_TextChanged);
            // 
            // PlayerOneNameLabel
            // 
            this.PlayerOneNameLabel.Location = new System.Drawing.Point(7, 26);
            this.PlayerOneNameLabel.Name = "PlayerOneNameLabel";
            this.PlayerOneNameLabel.Size = new System.Drawing.Size(117, 19);
            this.PlayerOneNameLabel.TabIndex = 2;
            this.PlayerOneNameLabel.Text = "Player One Name:";
            // 
            // DestinationBox
            // 
            this.DestinationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationBox.Location = new System.Drawing.Point(131, 83);
            this.DestinationBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(287, 23);
            this.DestinationBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination:";
            // 
            // frmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSingle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PlayerTwoNameTextBox;
        private System.Windows.Forms.Label PlayerTwoNameLabel;
        private System.Windows.Forms.TextBox PlayerOneNameTextBox;
        private System.Windows.Forms.Label PlayerOneNameLabel;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.Label label2;
    }
}