namespace Пятнашки
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BNewGame = new System.Windows.Forms.Button();
            this.BParams = new System.Windows.Forms.Button();
            this.BExtit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BNewGame
            // 
            this.BNewGame.BackColor = System.Drawing.Color.DarkOrange;
            this.BNewGame.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BNewGame.Location = new System.Drawing.Point(272, 49);
            this.BNewGame.Name = "BNewGame";
            this.BNewGame.Size = new System.Drawing.Size(300, 80);
            this.BNewGame.TabIndex = 0;
            this.BNewGame.Text = "Новая игра";
            this.BNewGame.UseVisualStyleBackColor = false;
            this.BNewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // BParams
            // 
            this.BParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BParams.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BParams.Location = new System.Drawing.Point(272, 161);
            this.BParams.Name = "BParams";
            this.BParams.Size = new System.Drawing.Size(300, 80);
            this.BParams.TabIndex = 1;
            this.BParams.Text = "Насторойки";
            this.BParams.UseVisualStyleBackColor = false;
            this.BParams.Click += new System.EventHandler(this.button2_Click);
            // 
            // BExtit
            // 
            this.BExtit.BackColor = System.Drawing.Color.Yellow;
            this.BExtit.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExtit.Location = new System.Drawing.Point(272, 276);
            this.BExtit.Name = "BExtit";
            this.BExtit.Size = new System.Drawing.Size(300, 80);
            this.BExtit.TabIndex = 2;
            this.BExtit.Text = "Выход";
            this.BExtit.UseVisualStyleBackColor = false;
            this.BExtit.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(812, 433);
            this.Controls.Add(this.BExtit);
            this.Controls.Add(this.BParams);
            this.Controls.Add(this.BNewGame);
            this.MaximumSize = new System.Drawing.Size(830, 480);
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра Пятнашки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BNewGame;
        private System.Windows.Forms.Button BParams;
        private System.Windows.Forms.Button BExtit;
    }
}

