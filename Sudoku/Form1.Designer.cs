namespace sudoku
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.beginnerLevel = new System.Windows.Forms.RadioButton();
            this.IntermediateLevel = new System.Windows.Forms.RadioButton();
            this.AdvancedLevel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(76, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 630);
            this.panel1.TabIndex = 0;
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(712, 520);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(179, 103);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(712, 76);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(179, 100);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check Input";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(712, 193);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(179, 59);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear Input";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // beginnerLevel
            // 
            this.beginnerLevel.AutoSize = true;
            this.beginnerLevel.Checked = true;
            this.beginnerLevel.Location = new System.Drawing.Point(712, 430);
            this.beginnerLevel.Name = "beginnerLevel";
            this.beginnerLevel.Size = new System.Drawing.Size(98, 24);
            this.beginnerLevel.TabIndex = 3;
            this.beginnerLevel.TabStop = true;
            this.beginnerLevel.Text = "Beginner";
            this.beginnerLevel.UseVisualStyleBackColor = true;
            // 
            // IntermediateLevel
            // 
            this.IntermediateLevel.AutoSize = true;
            this.IntermediateLevel.Location = new System.Drawing.Point(712, 460);
            this.IntermediateLevel.Name = "IntermediateLevel";
            this.IntermediateLevel.Size = new System.Drawing.Size(124, 24);
            this.IntermediateLevel.TabIndex = 3;
            this.IntermediateLevel.Text = "Intermediate";
            this.IntermediateLevel.UseVisualStyleBackColor = true;
            // 
            // AdvancedLevel
            // 
            this.AdvancedLevel.AutoSize = true;
            this.AdvancedLevel.Location = new System.Drawing.Point(712, 490);
            this.AdvancedLevel.Name = "AdvancedLevel";
            this.AdvancedLevel.Size = new System.Drawing.Size(105, 24);
            this.AdvancedLevel.TabIndex = 3;
            this.AdvancedLevel.Text = "Advanced";
            this.AdvancedLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdvancedLevel);
            this.Controls.Add(this.IntermediateLevel);
            this.Controls.Add(this.beginnerLevel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton beginnerLevel;
        private System.Windows.Forms.RadioButton IntermediateLevel;
        private System.Windows.Forms.RadioButton AdvancedLevel;
        private System.Windows.Forms.Label label1;
    }
}

