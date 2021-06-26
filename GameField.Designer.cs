
namespace WindowsFormsApp1
{
    partial class GameFieldForm
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
            this.srttingButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.health = new System.Windows.Forms.TextBox();
            this.bootsButton = new System.Windows.Forms.Button();
            this.backpackButton = new System.Windows.Forms.Button();
            this.rightHandButton = new System.Windows.Forms.Button();
            this.leftHandButton = new System.Windows.Forms.Button();
            this.helmetButton = new System.Windows.Forms.Button();
            this.breastplateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // srttingButton
            // 
            this.srttingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srttingButton.Location = new System.Drawing.Point(900, 28);
            this.srttingButton.Name = "srttingButton";
            this.srttingButton.Size = new System.Drawing.Size(50, 50);
            this.srttingButton.TabIndex = 0;
            this.srttingButton.Text = "⚙";
            this.srttingButton.UseVisualStyleBackColor = true;
            this.srttingButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Emty;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(545, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 150);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(673, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 150);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(805, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 150);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(545, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 150);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(673, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 150);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(805, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 150);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // health
            // 
            this.health.Location = new System.Drawing.Point(22, 12);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(104, 20);
            this.health.TabIndex = 15;
            // 
            // bootsButton
            // 
            this.bootsButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.BootsEmpty;
            this.bootsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bootsButton.Location = new System.Drawing.Point(197, 430);
            this.bootsButton.Name = "bootsButton";
            this.bootsButton.Size = new System.Drawing.Size(100, 150);
            this.bootsButton.TabIndex = 14;
            this.bootsButton.Text = "bootsButton";
            this.bootsButton.UseVisualStyleBackColor = true;
            this.bootsButton.Click += new System.EventHandler(this.BootsButton_Click);
            // 
            // backpackButton
            // 
            this.backpackButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Backpack__1_;
            this.backpackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backpackButton.Location = new System.Drawing.Point(70, 253);
            this.backpackButton.Name = "backpackButton";
            this.backpackButton.Size = new System.Drawing.Size(100, 150);
            this.backpackButton.TabIndex = 12;
            this.backpackButton.Text = "backpackButton";
            this.backpackButton.UseVisualStyleBackColor = true;
            this.backpackButton.Click += new System.EventHandler(this.BbackpackButton_Click);
            // 
            // rightHandButton
            // 
            this.rightHandButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.RightHand;
            this.rightHandButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightHandButton.Location = new System.Drawing.Point(329, 346);
            this.rightHandButton.Name = "rightHandButton";
            this.rightHandButton.Size = new System.Drawing.Size(100, 150);
            this.rightHandButton.TabIndex = 10;
            this.rightHandButton.Text = "rightHandButton";
            this.rightHandButton.UseVisualStyleBackColor = true;
            this.rightHandButton.Click += new System.EventHandler(this.RightHandButton_Click);
            // 
            // leftHandButton
            // 
            this.leftHandButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.LeftHand;
            this.leftHandButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftHandButton.Location = new System.Drawing.Point(329, 171);
            this.leftHandButton.Name = "leftHandButton";
            this.leftHandButton.Size = new System.Drawing.Size(100, 150);
            this.leftHandButton.TabIndex = 9;
            this.leftHandButton.Text = "leftHandButton";
            this.leftHandButton.UseVisualStyleBackColor = true;
            this.leftHandButton.Click += new System.EventHandler(this.LeftHandButton_Click);
            // 
            // helmetButton
            // 
            this.helmetButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.HelmetEmpty;
            this.helmetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.helmetButton.Location = new System.Drawing.Point(197, 73);
            this.helmetButton.Name = "helmetButton";
            this.helmetButton.Size = new System.Drawing.Size(100, 150);
            this.helmetButton.TabIndex = 8;
            this.helmetButton.Text = "helmetButton";
            this.helmetButton.UseVisualStyleBackColor = true;
            this.helmetButton.Click += new System.EventHandler(this.HelmetButton_Click);
            // 
            // breastplateButton
            // 
            this.breastplateButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.BreastplateEmty;
            this.breastplateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.breastplateButton.Location = new System.Drawing.Point(197, 253);
            this.breastplateButton.Name = "breastplateButton";
            this.breastplateButton.Size = new System.Drawing.Size(100, 150);
            this.breastplateButton.TabIndex = 7;
            this.breastplateButton.Text = "breastplateButton";
            this.breastplateButton.UseVisualStyleBackColor = true;
            this.breastplateButton.Click += new System.EventHandler(this.BreastplateButton_Click);
            // 
            // GameFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.health);
            this.Controls.Add(this.bootsButton);
            this.Controls.Add(this.backpackButton);
            this.Controls.Add(this.rightHandButton);
            this.Controls.Add(this.leftHandButton);
            this.Controls.Add(this.helmetButton);
            this.Controls.Add(this.breastplateButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.srttingButton);
            this.Name = "GameFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game field";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button srttingButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button breastplateButton;
        private System.Windows.Forms.Button helmetButton;
        private System.Windows.Forms.Button leftHandButton;
        private System.Windows.Forms.Button rightHandButton;
        private System.Windows.Forms.Button backpackButton;
        private System.Windows.Forms.Button bootsButton;
        private System.Windows.Forms.TextBox health;
    }
}