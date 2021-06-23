
namespace WindowsFormsApp1
{
    partial class MainMenuForm
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
            this.toRightButton = new System.Windows.Forms.Button();
            this.toLeftButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toRightButton
            // 
            this.toRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toRightButton.Location = new System.Drawing.Point(250, 250);
            this.toRightButton.Name = "toRightButton";
            this.toRightButton.Size = new System.Drawing.Size(50, 50);
            this.toRightButton.TabIndex = 0;
            this.toRightButton.Text = "▶";
            this.toRightButton.UseVisualStyleBackColor = true;
            this.toRightButton.Click += new System.EventHandler(this.ToRightButton_Click);
            // 
            // toLeftButton
            // 
            this.toLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLeftButton.Location = new System.Drawing.Point(100, 250);
            this.toLeftButton.Name = "toLeftButton";
            this.toLeftButton.Size = new System.Drawing.Size(50, 50);
            this.toLeftButton.TabIndex = 1;
            this.toLeftButton.Text = "◀";
            this.toLeftButton.UseVisualStyleBackColor = true;
            this.toLeftButton.Click += new System.EventHandler(this.ToLeftButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(100, 325);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 50);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Начать высадку";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.toLeftButton);
            this.Controls.Add(this.toRightButton);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toRightButton;
        private System.Windows.Forms.Button toLeftButton;
        private System.Windows.Forms.Button startButton;
    }
}

