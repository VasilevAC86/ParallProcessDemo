namespace ParallProcessDemo
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
            this.btnCownDown = new System.Windows.Forms.Button();
            this.lbCountDown001 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lBCountDown002 = new System.Windows.Forms.Label();
            this.lbCountDown003 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCownDown
            // 
            this.btnCownDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCownDown.Location = new System.Drawing.Point(26, 22);
            this.btnCownDown.Name = "btnCownDown";
            this.btnCownDown.Size = new System.Drawing.Size(193, 86);
            this.btnCownDown.TabIndex = 0;
            this.btnCownDown.Text = "Обратный отсчёт";
            this.btnCownDown.UseVisualStyleBackColor = true;
            this.btnCownDown.Click += new System.EventHandler(this.btnCownDown_Click);
            // 
            // lbCountDown001
            // 
            this.lbCountDown001.AutoSize = true;
            this.lbCountDown001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountDown001.Location = new System.Drawing.Point(265, 34);
            this.lbCountDown001.Name = "lbCountDown001";
            this.lbCountDown001.Size = new System.Drawing.Size(30, 24);
            this.lbCountDown001.TabIndex = 1;
            this.lbCountDown001.Text = "__";
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo.Location = new System.Drawing.Point(26, 357);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(295, 72);
            this.tbInfo.TabIndex = 2;
            // 
            // lBCountDown002
            // 
            this.lBCountDown002.AutoSize = true;
            this.lBCountDown002.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBCountDown002.Location = new System.Drawing.Point(371, 34);
            this.lBCountDown002.Name = "lBCountDown002";
            this.lBCountDown002.Size = new System.Drawing.Size(30, 24);
            this.lBCountDown002.TabIndex = 4;
            this.lBCountDown002.Text = "__";
            // 
            // lbCountDown003
            // 
            this.lbCountDown003.AutoSize = true;
            this.lbCountDown003.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountDown003.Location = new System.Drawing.Point(495, 34);
            this.lbCountDown003.Name = "lbCountDown003";
            this.lbCountDown003.Size = new System.Drawing.Size(30, 24);
            this.lbCountDown003.TabIndex = 5;
            this.lbCountDown003.Text = "__";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCountDown003);
            this.Controls.Add(this.lBCountDown002);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lbCountDown001);
            this.Controls.Add(this.btnCownDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCownDown;
        private System.Windows.Forms.Label lbCountDown001;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lBCountDown002;
        private System.Windows.Forms.Label lbCountDown003;
    }
}

