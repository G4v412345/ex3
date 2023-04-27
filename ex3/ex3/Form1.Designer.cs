namespace ex3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            country = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            bronM = new TextBox();
            silvM = new TextBox();
            goldM = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ath = new TextBox();
            label2 = new Label();
            resultBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // country
            // 
            country.Location = new Point(184, 22);
            country.Name = "country";
            country.Size = new Size(100, 23);
            country.TabIndex = 0;
            country.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Страна";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(bronM);
            groupBox1.Controls.Add(silvM);
            groupBox1.Controls.Add(goldM);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ath);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(country);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 250);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация";
            groupBox1.Enter += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 205);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bronM
            // 
            bronM.Location = new Point(184, 158);
            bronM.Name = "bronM";
            bronM.Size = new Size(100, 23);
            bronM.TabIndex = 10;
            // 
            // silvM
            // 
            silvM.Location = new Point(184, 125);
            silvM.Name = "silvM";
            silvM.Size = new Size(100, 23);
            silvM.TabIndex = 9;
            // 
            // goldM
            // 
            goldM.Location = new Point(184, 92);
            goldM.Name = "goldM";
            goldM.Size = new Size(100, 23);
            goldM.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 158);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 7;
            label5.Text = "Бронзовые медали";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 125);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 6;
            label4.Text = "Серебряные медали";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 92);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Золотые медали";
            // 
            // ath
            // 
            ath.Location = new Point(184, 57);
            ath.Name = "ath";
            ath.Size = new Size(100, 23);
            ath.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 60);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 3;
            label2.Text = "Количество спортсменов";
            // 
            // resultBox
            // 
            resultBox.Location = new Point(357, 55);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(340, 242);
            resultBox.TabIndex = 3;
            resultBox.TextChanged += resultBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox country;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox bronM;
        private TextBox silvM;
        private TextBox goldM;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox ath;
        private Label label2;
        private Button button1;
        private TextBox resultBox;
    }
}