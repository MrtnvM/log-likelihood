namespace Log_Likelihood
{
    partial class LogLikelihoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogLikelihoodForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.ofdBrowse = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.activityIndicatorFront = new System.Windows.Forms.PictureBox();
            this.lbLikelihood = new Log_Likelihood.BetterListBox();
            this.lbTwowords = new Log_Likelihood.BetterListBox();
            ((System.ComponentModel.ISupportInitialize)(this.activityIndicatorFront)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Двусловие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Правдоподобие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Файл для анализа";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(331, 47);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(192, 20);
            this.tbFile.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(331, 73);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(192, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Выбрать файл для анализа";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnalyze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnalyze.Font = new System.Drawing.Font("Georgia", 12.25F);
            this.btnAnalyze.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAnalyze.Location = new System.Drawing.Point(331, 309);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(192, 61);
            this.btnAnalyze.TabIndex = 7;
            this.btnAnalyze.Text = "Анализировать";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // activityIndicatorFront
            // 
            this.activityIndicatorFront.Image = ((System.Drawing.Image)(resources.GetObject("activityIndicatorFront.Image")));
            this.activityIndicatorFront.Location = new System.Drawing.Point(331, 102);
            this.activityIndicatorFront.Name = "activityIndicatorFront";
            this.activityIndicatorFront.Size = new System.Drawing.Size(192, 201);
            this.activityIndicatorFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activityIndicatorFront.TabIndex = 12;
            this.activityIndicatorFront.TabStop = false;
            this.activityIndicatorFront.Visible = false;
            // 
            // lbLikelihood
            // 
            this.lbLikelihood.FormattingEnabled = true;
            this.lbLikelihood.ItemHeight = 14;
            this.lbLikelihood.Location = new System.Drawing.Point(208, 31);
            this.lbLikelihood.Name = "lbLikelihood";
            this.lbLikelihood.Size = new System.Drawing.Size(104, 340);
            this.lbLikelihood.TabIndex = 9;
            // 
            // lbTwowords
            // 
            this.lbTwowords.FormattingEnabled = true;
            this.lbTwowords.ItemHeight = 14;
            this.lbTwowords.Location = new System.Drawing.Point(12, 31);
            this.lbTwowords.Name = "lbTwowords";
            this.lbTwowords.Size = new System.Drawing.Size(181, 340);
            this.lbTwowords.TabIndex = 8;
            // 
            // LogLikelihoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 382);
            this.Controls.Add(this.activityIndicatorFront);
            this.Controls.Add(this.lbLikelihood);
            this.Controls.Add(this.lbTwowords);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.Name = "LogLikelihoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-Likelihood";
            this.Load += new System.EventHandler(this.LogLikelihoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityIndicatorFront)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.OpenFileDialog ofdBrowse;
        private BetterListBox lbTwowords;
        private BetterListBox lbLikelihood;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox activityIndicatorFront;
    }
}

