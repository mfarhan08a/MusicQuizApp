namespace MusicQuizApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_welcome = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.pnl_welcome = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_play = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_answer = new System.Windows.Forms.Button();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_settings = new System.Windows.Forms.Panel();
            this.dataSongsView = new System.Windows.Forms.DataGridView();
            this.btn_skip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_welcome.SuspendLayout();
            this.pnl_play.SuspendLayout();
            this.pnl_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSongsView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.btn_welcome);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 681);
            this.panel1.TabIndex = 0;
            // 
            // btn_welcome
            // 
            this.btn_welcome.Location = new System.Drawing.Point(20, 161);
            this.btn_welcome.Margin = new System.Windows.Forms.Padding(2);
            this.btn_welcome.Name = "btn_welcome";
            this.btn_welcome.Size = new System.Drawing.Size(146, 42);
            this.btn_welcome.TabIndex = 4;
            this.btn_welcome.Text = "Welcome";
            this.btn_welcome.UseVisualStyleBackColor = true;
            this.btn_welcome.Click += new System.EventHandler(this.btn_welcome_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 320);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(20, 267);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(146, 42);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.Window;
            this.btn_play.Location = new System.Drawing.Point(20, 214);
            this.btn_play.Margin = new System.Windows.Forms.Padding(2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(146, 42);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // pnl_welcome
            // 
            this.pnl_welcome.Controls.Add(this.label2);
            this.pnl_welcome.Controls.Add(this.label1);
            this.pnl_welcome.Location = new System.Drawing.Point(389, 113);
            this.pnl_welcome.Name = "pnl_welcome";
            this.pnl_welcome.Size = new System.Drawing.Size(863, 556);
            this.pnl_welcome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click play button to start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Music Quiz";
            // 
            // pnl_play
            // 
            this.pnl_play.Controls.Add(this.btn_skip);
            this.pnl_play.Controls.Add(this.label5);
            this.pnl_play.Controls.Add(this.btn_answer);
            this.pnl_play.Controls.Add(this.guessBox);
            this.pnl_play.Controls.Add(this.label4);
            this.pnl_play.Controls.Add(this.label3);
            this.pnl_play.Location = new System.Drawing.Point(363, 84);
            this.pnl_play.Name = "pnl_play";
            this.pnl_play.Size = new System.Drawing.Size(873, 569);
            this.pnl_play.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // btn_answer
            // 
            this.btn_answer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_answer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_answer.Location = new System.Drawing.Point(359, 449);
            this.btn_answer.Name = "btn_answer";
            this.btn_answer.Size = new System.Drawing.Size(146, 45);
            this.btn_answer.TabIndex = 11;
            this.btn_answer.Text = "Enter";
            this.btn_answer.UseVisualStyleBackColor = false;
            this.btn_answer.Click += new System.EventHandler(this.btn_answer_Click);
            // 
            // guessBox
            // 
            this.guessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(184, 399);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(496, 44);
            this.guessBox.TabIndex = 10;
            this.guessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Your Guess";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Timer";
            // 
            // pnl_settings
            // 
            this.pnl_settings.Controls.Add(this.dataSongsView);
            this.pnl_settings.Location = new System.Drawing.Point(183, 12);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(1039, 622);
            this.pnl_settings.TabIndex = 4;
            // 
            // dataSongsView
            // 
            this.dataSongsView.AllowUserToAddRows = false;
            this.dataSongsView.AllowUserToDeleteRows = false;
            this.dataSongsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSongsView.Location = new System.Drawing.Point(4, 4);
            this.dataSongsView.Name = "dataSongsView";
            this.dataSongsView.ReadOnly = true;
            this.dataSongsView.Size = new System.Drawing.Size(1032, 562);
            this.dataSongsView.TabIndex = 0;
            // 
            // btn_skip
            // 
            this.btn_skip.Location = new System.Drawing.Point(730, 521);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(121, 29);
            this.btn_skip.TabIndex = 13;
            this.btn_skip.Text = "Skip";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnl_play);
            this.Controls.Add(this.pnl_settings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_welcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_welcome.ResumeLayout(false);
            this.pnl_welcome.PerformLayout();
            this.pnl_play.ResumeLayout(false);
            this.pnl_play.PerformLayout();
            this.pnl_settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSongsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_welcome;
        private System.Windows.Forms.Panel pnl_welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_play;
        private System.Windows.Forms.Button btn_answer;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_settings;
        private System.Windows.Forms.DataGridView dataSongsView;
        private System.Windows.Forms.Button btn_skip;
    }
}

