namespace Week_4_test
{
    partial class CreatesFormula
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "CreatesFormula";


            comboBoxDaysInWeek = new ComboBox();
            comboBoxDayInMonth = new ComboBox();
            comboBoxMonth = new ComboBox();
            comboBoxYears = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // comboBoxDaysInWeek
            // 
            comboBoxDaysInWeek.FormattingEnabled = true;
            comboBoxDaysInWeek.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            comboBoxDaysInWeek.Location = new Point(1014, 177);
            comboBoxDaysInWeek.Name = "comboBoxDaysInWeek";
            comboBoxDaysInWeek.RightToLeft = RightToLeft.Yes;
            comboBoxDaysInWeek.Size = new Size(315, 49);
            comboBoxDaysInWeek.TabIndex = 0;
            // 
            // comboBoxDayInMonth
            // 
            comboBoxDayInMonth.FormattingEnabled = true;
            comboBoxDayInMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBoxDayInMonth.Location = new Point(678, 177);
            comboBoxDayInMonth.Name = "comboBoxDayInMonth";
            comboBoxDayInMonth.RightToLeft = RightToLeft.Yes;
            comboBoxDayInMonth.Size = new Size(321, 49);
            comboBoxDayInMonth.TabIndex = 1;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" });
            comboBoxMonth.Location = new Point(318, 177);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.RightToLeft = RightToLeft.Yes;
            comboBoxMonth.Size = new Size(333, 49);
            comboBoxMonth.TabIndex = 2;
            // 
            // comboBoxYears
            // 
            comboBoxYears.FormattingEnabled = true;
            comboBoxYears.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"פ", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            comboBoxYears.Location = new Point(12, 177);
            comboBoxYears.Name = "comboBoxYears";
            comboBoxYears.RightToLeft = RightToLeft.Yes;
            comboBoxYears.Size = new Size(288, 49);
            comboBoxYears.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 115);
            label1.Name = "label1";
            label1.Size = new Size(74, 41);
            label1.TabIndex = 4;
            label1.Text = "שנה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 115);
            label2.Name = "label2";
            label2.Size = new Size(84, 41);
            label2.TabIndex = 5;
            label2.Text = "חודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(768, 115);
            label3.Name = "label3";
            label3.Size = new Size(166, 41);
            label3.TabIndex = 6;
            label3.Text = "היום בחודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1074, 115);
            label4.Name = "label4";
            label4.Size = new Size(167, 41);
            label4.TabIndex = 7;
            label4.Text = "היום בשבוע";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(558, 23);
            label5.Name = "label5";
            label5.Size = new Size(194, 41);
            label5.TabIndex = 8;
            label5.Text = "כתיבת תאריך";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(574, 861);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(188, 58);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "שמור";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 966);
            Controls.Add(buttonSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxYears);
            Controls.Add(comboBoxMonth);
            Controls.Add(comboBoxDayInMonth);
            Controls.Add(comboBoxDaysInWeek);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDaysInWeek;
        private ComboBox comboBoxDayInMonth;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYears;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonSave;
    }

    
}