namespace Game1
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
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.progressEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnAttackEnemyTwo = new System.Windows.Forms.Button();
            this.textEnemyHealth = new System.Windows.Forms.TextBox();
            this.progressPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.progressPlayerMana = new System.Windows.Forms.ProgressBar();
            this.labelPlayerHealth = new System.Windows.Forms.Label();
            this.labelPlayerMana = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.Button();
            this.pictureEnemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.Location = new System.Drawing.Point(452, 548);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(284, 47);
            this.btnNewPlayer.TabIndex = 0;
            this.btnNewPlayer.Text = "New Game";
            this.btnNewPlayer.UseVisualStyleBackColor = true;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // progressEnemyHealth
            // 
            this.progressEnemyHealth.Location = new System.Drawing.Point(389, 381);
            this.progressEnemyHealth.Maximum = 20;
            this.progressEnemyHealth.Name = "progressEnemyHealth";
            this.progressEnemyHealth.Size = new System.Drawing.Size(412, 24);
            this.progressEnemyHealth.TabIndex = 2;
            this.progressEnemyHealth.Visible = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(389, 461);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(147, 49);
            this.btnAttack.TabIndex = 3;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnAttackEnemyTwo
            // 
            this.btnAttackEnemyTwo.Location = new System.Drawing.Point(389, 461);
            this.btnAttackEnemyTwo.Name = "btnAttackEnemyTwo";
            this.btnAttackEnemyTwo.Size = new System.Drawing.Size(147, 49);
            this.btnAttackEnemyTwo.TabIndex = 4;
            this.btnAttackEnemyTwo.Text = "Attack";
            this.btnAttackEnemyTwo.UseVisualStyleBackColor = true;
            this.btnAttackEnemyTwo.Visible = false;
            this.btnAttackEnemyTwo.Click += new System.EventHandler(this.btnAttackEnemyTwo_Click);
            // 
            // textEnemyHealth
            // 
            this.textEnemyHealth.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textEnemyHealth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEnemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEnemyHealth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEnemyHealth.Location = new System.Drawing.Point(544, 355);
            this.textEnemyHealth.Name = "textEnemyHealth";
            this.textEnemyHealth.Size = new System.Drawing.Size(104, 13);
            this.textEnemyHealth.TabIndex = 5;
            this.textEnemyHealth.TabStop = false;
            this.textEnemyHealth.Text = "Enemy Health";
            this.textEnemyHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEnemyHealth.Visible = false;
            // 
            // progressPlayerHealth
            // 
            this.progressPlayerHealth.Location = new System.Drawing.Point(12, 577);
            this.progressPlayerHealth.Name = "progressPlayerHealth";
            this.progressPlayerHealth.Size = new System.Drawing.Size(332, 18);
            this.progressPlayerHealth.TabIndex = 6;
            this.progressPlayerHealth.Visible = false;
            // 
            // progressPlayerMana
            // 
            this.progressPlayerMana.Location = new System.Drawing.Point(836, 577);
            this.progressPlayerMana.Name = "progressPlayerMana";
            this.progressPlayerMana.Size = new System.Drawing.Size(332, 18);
            this.progressPlayerMana.TabIndex = 7;
            this.progressPlayerMana.Visible = false;
            // 
            // labelPlayerHealth
            // 
            this.labelPlayerHealth.AutoSize = true;
            this.labelPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerHealth.Location = new System.Drawing.Point(143, 558);
            this.labelPlayerHealth.Name = "labelPlayerHealth";
            this.labelPlayerHealth.Size = new System.Drawing.Size(53, 16);
            this.labelPlayerHealth.TabIndex = 8;
            this.labelPlayerHealth.Text = "Health";
            this.labelPlayerHealth.Visible = false;
            // 
            // labelPlayerMana
            // 
            this.labelPlayerMana.AutoSize = true;
            this.labelPlayerMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerMana.Location = new System.Drawing.Point(999, 558);
            this.labelPlayerMana.Name = "labelPlayerMana";
            this.labelPlayerMana.Size = new System.Drawing.Size(46, 16);
            this.labelPlayerMana.TabIndex = 9;
            this.labelPlayerMana.Text = "Mana";
            this.labelPlayerMana.Visible = false;
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(654, 463);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(147, 47);
            this.btnRest.TabIndex = 10;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Visible = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // pictureEnemy
            // 
            this.pictureEnemy.Location = new System.Drawing.Point(389, 46);
            this.pictureEnemy.Name = "pictureEnemy";
            this.pictureEnemy.Size = new System.Drawing.Size(412, 297);
            this.pictureEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureEnemy.TabIndex = 1;
            this.pictureEnemy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 625);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.labelPlayerMana);
            this.Controls.Add(this.labelPlayerHealth);
            this.Controls.Add(this.progressPlayerMana);
            this.Controls.Add(this.progressPlayerHealth);
            this.Controls.Add(this.textEnemyHealth);
            this.Controls.Add(this.btnAttackEnemyTwo);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.progressEnemyHealth);
            this.Controls.Add(this.pictureEnemy);
            this.Controls.Add(this.btnNewPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.PictureBox pictureEnemy;
        private System.Windows.Forms.ProgressBar progressEnemyHealth;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnAttackEnemyTwo;
        private System.Windows.Forms.TextBox textEnemyHealth;
        private System.Windows.Forms.ProgressBar progressPlayerHealth;
        private System.Windows.Forms.ProgressBar progressPlayerMana;
        private System.Windows.Forms.Label labelPlayerHealth;
        private System.Windows.Forms.Label labelPlayerMana;
        private System.Windows.Forms.Button btnRest;
    }
}

