namespace DiceGame
{
    partial class Form1
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
            this.lbl_p1dice2 = new System.Windows.Forms.Label();
            this.lbl_p1dice1 = new System.Windows.Forms.Label();
            this.lbl_p1dice3 = new System.Windows.Forms.Label();
            this.lbl_p1dice4 = new System.Windows.Forms.Label();
            this.lbl_p1dice5 = new System.Windows.Forms.Label();
            this.btn_p1RollDice = new System.Windows.Forms.Button();
            this.lbl_p1DisplayResults = new System.Windows.Forms.Label();
            this.lbl_p2DisplayResults = new System.Windows.Forms.Label();
            this.btn_p2RollDice = new System.Windows.Forms.Button();
            this.lbl_p2dice5 = new System.Windows.Forms.Label();
            this.lbl_p2dice4 = new System.Windows.Forms.Label();
            this.lbl_p2dice3 = new System.Windows.Forms.Label();
            this.lbl_p2dice1 = new System.Windows.Forms.Label();
            this.lbl_p2dice2 = new System.Windows.Forms.Label();
            this.lbl_compare = new System.Windows.Forms.Label();
            this.lbl_p1Name = new System.Windows.Forms.Label();
            this.lbl_p2Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_p1dice2
            // 
            this.lbl_p1dice2.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice2.Location = new System.Drawing.Point(80, 158);
            this.lbl_p1dice2.Name = "lbl_p1dice2";
            this.lbl_p1dice2.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1dice2.TabIndex = 0;
            // 
            // lbl_p1dice1
            // 
            this.lbl_p1dice1.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice1.Location = new System.Drawing.Point(24, 158);
            this.lbl_p1dice1.Name = "lbl_p1dice1";
            this.lbl_p1dice1.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1dice1.TabIndex = 1;
            // 
            // lbl_p1dice3
            // 
            this.lbl_p1dice3.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice3.Location = new System.Drawing.Point(136, 158);
            this.lbl_p1dice3.Name = "lbl_p1dice3";
            this.lbl_p1dice3.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1dice3.TabIndex = 2;
            // 
            // lbl_p1dice4
            // 
            this.lbl_p1dice4.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice4.Location = new System.Drawing.Point(192, 158);
            this.lbl_p1dice4.Name = "lbl_p1dice4";
            this.lbl_p1dice4.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1dice4.TabIndex = 3;
            // 
            // lbl_p1dice5
            // 
            this.lbl_p1dice5.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice5.Location = new System.Drawing.Point(248, 158);
            this.lbl_p1dice5.Name = "lbl_p1dice5";
            this.lbl_p1dice5.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1dice5.TabIndex = 4;
            // 
            // btn_p1RollDice
            // 
            this.btn_p1RollDice.Location = new System.Drawing.Point(66, 221);
            this.btn_p1RollDice.Name = "btn_p1RollDice";
            this.btn_p1RollDice.Size = new System.Drawing.Size(200, 50);
            this.btn_p1RollDice.TabIndex = 5;
            this.btn_p1RollDice.Text = "Roll Dice!";
            this.btn_p1RollDice.UseVisualStyleBackColor = true;
            this.btn_p1RollDice.Click += new System.EventHandler(this.btn_p1RollDice_Click);
            // 
            // lbl_p1DisplayResults
            // 
            this.lbl_p1DisplayResults.AutoSize = true;
            this.lbl_p1DisplayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1DisplayResults.Location = new System.Drawing.Point(45, 288);
            this.lbl_p1DisplayResults.MaximumSize = new System.Drawing.Size(250, 50);
            this.lbl_p1DisplayResults.MinimumSize = new System.Drawing.Size(250, 50);
            this.lbl_p1DisplayResults.Name = "lbl_p1DisplayResults";
            this.lbl_p1DisplayResults.Size = new System.Drawing.Size(250, 50);
            this.lbl_p1DisplayResults.TabIndex = 6;
            this.lbl_p1DisplayResults.Text = "Roll The Dice!";
            this.lbl_p1DisplayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2DisplayResults
            // 
            this.lbl_p2DisplayResults.AutoSize = true;
            this.lbl_p2DisplayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2DisplayResults.Location = new System.Drawing.Point(346, 288);
            this.lbl_p2DisplayResults.MaximumSize = new System.Drawing.Size(250, 50);
            this.lbl_p2DisplayResults.MinimumSize = new System.Drawing.Size(250, 50);
            this.lbl_p2DisplayResults.Name = "lbl_p2DisplayResults";
            this.lbl_p2DisplayResults.Size = new System.Drawing.Size(250, 50);
            this.lbl_p2DisplayResults.TabIndex = 13;
            this.lbl_p2DisplayResults.Text = "Roll The Dice!";
            this.lbl_p2DisplayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_p2RollDice
            // 
            this.btn_p2RollDice.Location = new System.Drawing.Point(367, 221);
            this.btn_p2RollDice.Name = "btn_p2RollDice";
            this.btn_p2RollDice.Size = new System.Drawing.Size(200, 50);
            this.btn_p2RollDice.TabIndex = 12;
            this.btn_p2RollDice.Text = "Roll Dice!";
            this.btn_p2RollDice.UseVisualStyleBackColor = true;
            this.btn_p2RollDice.Click += new System.EventHandler(this.btn_p2RollDice_Click);
            // 
            // lbl_p2dice5
            // 
            this.lbl_p2dice5.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice5.Location = new System.Drawing.Point(549, 158);
            this.lbl_p2dice5.Name = "lbl_p2dice5";
            this.lbl_p2dice5.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2dice5.TabIndex = 11;
            // 
            // lbl_p2dice4
            // 
            this.lbl_p2dice4.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice4.Location = new System.Drawing.Point(493, 158);
            this.lbl_p2dice4.Name = "lbl_p2dice4";
            this.lbl_p2dice4.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2dice4.TabIndex = 10;
            // 
            // lbl_p2dice3
            // 
            this.lbl_p2dice3.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice3.Location = new System.Drawing.Point(437, 158);
            this.lbl_p2dice3.Name = "lbl_p2dice3";
            this.lbl_p2dice3.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2dice3.TabIndex = 9;
            // 
            // lbl_p2dice1
            // 
            this.lbl_p2dice1.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice1.Location = new System.Drawing.Point(325, 158);
            this.lbl_p2dice1.Name = "lbl_p2dice1";
            this.lbl_p2dice1.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2dice1.TabIndex = 8;
            // 
            // lbl_p2dice2
            // 
            this.lbl_p2dice2.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice2.Location = new System.Drawing.Point(381, 158);
            this.lbl_p2dice2.Name = "lbl_p2dice2";
            this.lbl_p2dice2.Size = new System.Drawing.Size(50, 50);
            this.lbl_p2dice2.TabIndex = 7;
            // 
            // lbl_compare
            // 
            this.lbl_compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compare.Location = new System.Drawing.Point(12, 9);
            this.lbl_compare.Name = "lbl_compare";
            this.lbl_compare.Size = new System.Drawing.Size(610, 50);
            this.lbl_compare.TabIndex = 14;
            this.lbl_compare.Text = "Waiting For Roll";
            this.lbl_compare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p1Name
            // 
            this.lbl_p1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1Name.Location = new System.Drawing.Point(45, 90);
            this.lbl_p1Name.Name = "lbl_p1Name";
            this.lbl_p1Name.Size = new System.Drawing.Size(250, 60);
            this.lbl_p1Name.TabIndex = 15;
            this.lbl_p1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2Name
            // 
            this.lbl_p2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2Name.Location = new System.Drawing.Point(346, 90);
            this.lbl_p2Name.Name = "lbl_p2Name";
            this.lbl_p2Name.Size = new System.Drawing.Size(250, 60);
            this.lbl_p2Name.TabIndex = 16;
            this.lbl_p2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.lbl_p2Name);
            this.Controls.Add(this.lbl_p1Name);
            this.Controls.Add(this.lbl_compare);
            this.Controls.Add(this.lbl_p2DisplayResults);
            this.Controls.Add(this.btn_p2RollDice);
            this.Controls.Add(this.lbl_p2dice5);
            this.Controls.Add(this.lbl_p2dice4);
            this.Controls.Add(this.lbl_p2dice3);
            this.Controls.Add(this.lbl_p2dice1);
            this.Controls.Add(this.lbl_p2dice2);
            this.Controls.Add(this.lbl_p1DisplayResults);
            this.Controls.Add(this.btn_p1RollDice);
            this.Controls.Add(this.lbl_p1dice5);
            this.Controls.Add(this.lbl_p1dice4);
            this.Controls.Add(this.lbl_p1dice3);
            this.Controls.Add(this.lbl_p1dice1);
            this.Controls.Add(this.lbl_p1dice2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_p1dice2;
        private System.Windows.Forms.Label lbl_p1dice1;
        private System.Windows.Forms.Label lbl_p1dice3;
        private System.Windows.Forms.Label lbl_p1dice4;
        private System.Windows.Forms.Label lbl_p1dice5;
        private System.Windows.Forms.Button btn_p1RollDice;
        private System.Windows.Forms.Label lbl_p1DisplayResults;
        private System.Windows.Forms.Label lbl_p2DisplayResults;
        private System.Windows.Forms.Button btn_p2RollDice;
        private System.Windows.Forms.Label lbl_p2dice5;
        private System.Windows.Forms.Label lbl_p2dice4;
        private System.Windows.Forms.Label lbl_p2dice3;
        private System.Windows.Forms.Label lbl_p2dice1;
        private System.Windows.Forms.Label lbl_p2dice2;
        private System.Windows.Forms.Label lbl_compare;
        private System.Windows.Forms.Label lbl_p1Name;
        private System.Windows.Forms.Label lbl_p2Name;
    }
}

