namespace Пятнашки
{
    partial class PuzzleForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGame = new System.Windows.Forms.DataGridView();
            this.lbSteps = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPlayer = new System.Windows.Forms.TextBox();
            this.BLastResults = new System.Windows.Forms.Button();
            this.BBestSteps = new System.Windows.Forms.Button();
            this.BBestTime = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BDeleteResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGame
            // 
            this.dataGridViewGame.AllowUserToAddRows = false;
            this.dataGridViewGame.AllowUserToDeleteRows = false;
            this.dataGridViewGame.AllowUserToResizeColumns = false;
            this.dataGridViewGame.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Yellow;
            this.dataGridViewGame.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewGame.CausesValidation = false;
            this.dataGridViewGame.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGame.ColumnHeadersVisible = false;
            this.dataGridViewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGame.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewGame.EnableHeadersVisualStyles = false;
            this.dataGridViewGame.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewGame.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGame.MultiSelect = false;
            this.dataGridViewGame.Name = "dataGridViewGame";
            this.dataGridViewGame.ReadOnly = true;
            this.dataGridViewGame.RowHeadersVisible = false;
            this.dataGridViewGame.RowTemplate.Height = 24;
            this.dataGridViewGame.ShowCellErrors = false;
            this.dataGridViewGame.ShowCellToolTips = false;
            this.dataGridViewGame.ShowEditingIcon = false;
            this.dataGridViewGame.ShowRowErrors = false;
            this.dataGridViewGame.Size = new System.Drawing.Size(625, 420);
            this.dataGridViewGame.TabIndex = 0;
            this.dataGridViewGame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGame_CellClick_1);
            this.dataGridViewGame.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbSteps
            // 
            this.lbSteps.AutoSize = true;
            this.lbSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbSteps.Location = new System.Drawing.Point(652, 64);
            this.lbSteps.Name = "lbSteps";
            this.lbSteps.Size = new System.Drawing.Size(97, 29);
            this.lbSteps.TabIndex = 1;
            this.lbSteps.Text = "Шаги: 0";
            this.lbSteps.Click += new System.EventHandler(this.lbSteps_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbTime.Location = new System.Drawing.Point(652, 104);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(114, 29);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Время: 0";
            this.lbTime.Click += new System.EventHandler(this.lbTime_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(657, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ещё раз";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(657, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 66);
            this.button2.TabIndex = 4;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя игрока";
            // 
            // TBPlayer
            // 
            this.TBPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPlayer.Location = new System.Drawing.Point(17, 487);
            this.TBPlayer.Name = "TBPlayer";
            this.TBPlayer.Size = new System.Drawing.Size(143, 34);
            this.TBPlayer.TabIndex = 6;
            this.TBPlayer.Text = "Player";
            this.TBPlayer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BLastResults
            // 
            this.BLastResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BLastResults.Location = new System.Drawing.Point(196, 446);
            this.BLastResults.Name = "BLastResults";
            this.BLastResults.Size = new System.Drawing.Size(129, 75);
            this.BLastResults.TabIndex = 7;
            this.BLastResults.Text = "10 последних\r\n результатов";
            this.BLastResults.UseVisualStyleBackColor = true;
            this.BLastResults.Click += new System.EventHandler(this.BLastResults_Click);
            // 
            // BBestSteps
            // 
            this.BBestSteps.Location = new System.Drawing.Point(357, 446);
            this.BBestSteps.Name = "BBestSteps";
            this.BBestSteps.Size = new System.Drawing.Size(126, 75);
            this.BBestSteps.TabIndex = 8;
            this.BBestSteps.Text = "10 лучших\r\n результатов\r\n по шагам\r\n";
            this.BBestSteps.UseVisualStyleBackColor = true;
            this.BBestSteps.Click += new System.EventHandler(this.BBestSteps_Click);
            // 
            // BBestTime
            // 
            this.BBestTime.Location = new System.Drawing.Point(511, 446);
            this.BBestTime.Name = "BBestTime";
            this.BBestTime.Size = new System.Drawing.Size(126, 75);
            this.BBestTime.TabIndex = 9;
            this.BBestTime.Text = "10 лучших\r\n результатов\r\n по времени\r\n";
            this.BBestTime.UseVisualStyleBackColor = true;
            this.BBestTime.Click += new System.EventHandler(this.BBestTime_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(657, 410);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(146, 22);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // BDeleteResults
            // 
            this.BDeleteResults.Location = new System.Drawing.Point(657, 438);
            this.BDeleteResults.Name = "BDeleteResults";
            this.BDeleteResults.Size = new System.Drawing.Size(146, 75);
            this.BDeleteResults.TabIndex = 11;
            this.BDeleteResults.Text = "Удалить результаты \r\nдо заданной даты\r\n";
            this.BDeleteResults.UseVisualStyleBackColor = true;
            this.BDeleteResults.Click += new System.EventHandler(this.BDeleteResults_Click);
            // 
            // PuzzleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 535);
            this.Controls.Add(this.BDeleteResults);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.BBestTime);
            this.Controls.Add(this.BBestSteps);
            this.Controls.Add(this.BLastResults);
            this.Controls.Add(this.TBPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbSteps);
            this.Controls.Add(this.dataGridViewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PuzzleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_15_4on4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PuzzleForm_FormClosing);
            this.Load += new System.EventHandler(this._15_4on4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGame;
        private System.Windows.Forms.Label lbSteps;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBPlayer;
        private System.Windows.Forms.Button BLastResults;
        private System.Windows.Forms.Button BBestSteps;
        private System.Windows.Forms.Button BBestTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button BDeleteResults;
    }
}