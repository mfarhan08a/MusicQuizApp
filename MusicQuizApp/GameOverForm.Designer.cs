namespace MusicQuizApp
{
    partial class GameOverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_precentage = new System.Windows.Forms.Label();
            this.lbl_totalScore = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Congratulations!";
            // 
            // lbl_precentage
            // 
            this.lbl_precentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precentage.Location = new System.Drawing.Point(417, 217);
            this.lbl_precentage.Name = "lbl_precentage";
            this.lbl_precentage.Size = new System.Drawing.Size(327, 69);
            this.lbl_precentage.TabIndex = 2;
            this.lbl_precentage.Text = "You have pass 66% accuration on the quiz.";
            // 
            // lbl_totalScore
            // 
            this.lbl_totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalScore.Location = new System.Drawing.Point(417, 130);
            this.lbl_totalScore.Name = "lbl_totalScore";
            this.lbl_totalScore.Size = new System.Drawing.Size(327, 69);
            this.lbl_totalScore.TabIndex = 3;
            this.lbl_totalScore.Text = "You have guess 59 of 100 songs right!";
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_continue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_continue.FlatAppearance.BorderSize = 0;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_continue.Location = new System.Drawing.Point(423, 312);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(309, 45);
            this.btn_continue.TabIndex = 4;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 27);
            this.panel1.TabIndex = 5;
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(872, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.lbl_totalScore);
            this.Controls.Add(this.lbl_precentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOverForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_precentage;
        private System.Windows.Forms.Label lbl_totalScore;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Panel panel1;
    }
}