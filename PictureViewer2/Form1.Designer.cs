namespace PictureViewer2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chield = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.krokodial = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krokodial)).BeginInit();
            this.SuspendLayout();
            // 
            // chield
            // 
            this.chield.Image = ((System.Drawing.Image)(resources.GetObject("chield.Image")));
            this.chield.Location = new System.Drawing.Point(466, 28);
            this.chield.Name = "chield";
            this.chield.Size = new System.Drawing.Size(322, 255);
            this.chield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.chield.TabIndex = 0;
            this.chield.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(152, 289);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(247, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Крокодила не тревожить!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // krokodial
            // 
            this.krokodial.Image = ((System.Drawing.Image)(resources.GetObject("krokodial.Image")));
            this.krokodial.Location = new System.Drawing.Point(12, 84);
            this.krokodial.Name = "krokodial";
            this.krokodial.Size = new System.Drawing.Size(204, 143);
            this.krokodial.TabIndex = 3;
            this.krokodial.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.krokodial);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chield);
            this.Name = "Form1";
            this.Text = "Крокодильчик";
            ((System.ComponentModel.ISupportInitialize)(this.chield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krokodial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox chield;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.PictureBox krokodial;
    }
}

