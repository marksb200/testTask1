namespace testTask1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Psychiatrist_disease = new System.Windows.Forms.CheckedListBox();
            this.Disease_therapist = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bed_habits = new System.Windows.Forms.TextBox();
            this.Vision = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.NamePerson = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.upData = new System.Windows.Forms.Button();
            this.dataGW = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.resTests = new System.Windows.Forms.Button();
            this.outData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Common = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Psychiatrist_disease);
            this.tabPage1.Controls.Add(this.Disease_therapist);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Bed_habits);
            this.tabPage1.Controls.Add(this.Vision);
            this.tabPage1.Controls.Add(this.Age);
            this.tabPage1.Controls.Add(this.Height);
            this.tabPage1.Controls.Add(this.Weight);
            this.tabPage1.Controls.Add(this.NamePerson);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Psychiatrist_disease
            // 
            this.Psychiatrist_disease.FormattingEnabled = true;
            this.Psychiatrist_disease.Items.AddRange(new object[] {
            "alcoholism",
            "insomnia",
            "narcomania",
            "injury"});
            this.Psychiatrist_disease.Location = new System.Drawing.Point(820, 6);
            this.Psychiatrist_disease.Name = "Psychiatrist_disease";
            this.Psychiatrist_disease.Size = new System.Drawing.Size(120, 106);
            this.Psychiatrist_disease.TabIndex = 20;
            // 
            // Disease_therapist
            // 
            this.Disease_therapist.FormattingEnabled = true;
            this.Disease_therapist.Items.AddRange(new object[] {
            "cold",
            "bronchitis",
            "virus",
            "allergy",
            "quinsy",
            "insomnia"});
            this.Disease_therapist.Location = new System.Drawing.Point(680, 6);
            this.Disease_therapist.Name = "Disease_therapist";
            this.Disease_therapist.Size = new System.Drawing.Size(120, 106);
            this.Disease_therapist.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(842, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Psychiatrist";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Therapist";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bed habits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // Bed_habits
            // 
            this.Bed_habits.Location = new System.Drawing.Point(538, 6);
            this.Bed_habits.Name = "Bed_habits";
            this.Bed_habits.Size = new System.Drawing.Size(100, 22);
            this.Bed_habits.TabIndex = 6;
            // 
            // Vision
            // 
            this.Vision.Location = new System.Drawing.Point(432, 6);
            this.Vision.Name = "Vision";
            this.Vision.Size = new System.Drawing.Size(100, 22);
            this.Vision.TabIndex = 5;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(326, 6);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 22);
            this.Age.TabIndex = 4;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(220, 6);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 22);
            this.Height.TabIndex = 3;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(114, 6);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(100, 22);
            this.Weight.TabIndex = 2;
            // 
            // NamePerson
            // 
            this.NamePerson.Location = new System.Drawing.Point(8, 6);
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.Size = new System.Drawing.Size(100, 22);
            this.NamePerson.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.upData);
            this.tabPage2.Controls.Add(this.dataGW);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // upData
            // 
            this.upData.Location = new System.Drawing.Point(8, 362);
            this.upData.Name = "upData";
            this.upData.Size = new System.Drawing.Size(75, 44);
            this.upData.TabIndex = 1;
            this.upData.Text = "Update data";
            this.upData.UseVisualStyleBackColor = true;
            this.upData.Click += new System.EventHandler(this.upData_Click);
            // 
            // dataGW
            // 
            this.dataGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGW.Location = new System.Drawing.Point(8, 6);
            this.dataGW.Name = "dataGW";
            this.dataGW.RowHeadersWidth = 51;
            this.dataGW.RowTemplate.Height = 24;
            this.dataGW.Size = new System.Drawing.Size(952, 334);
            this.dataGW.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.outData);
            this.tabPage3.Controls.Add(this.resTests);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(963, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tests";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(18, 453);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resTests
            // 
            this.resTests.Location = new System.Drawing.Point(159, 453);
            this.resTests.Name = "resTests";
            this.resTests.Size = new System.Drawing.Size(75, 23);
            this.resTests.TabIndex = 2;
            this.resTests.Text = "results";
            this.resTests.UseVisualStyleBackColor = true;
            this.resTests.Click += new System.EventHandler(this.resTests_Click);
            // 
            // outData
            // 
            this.outData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Test1,
            this.Test2,
            this.Test3,
            this.Common});
            this.outData.Location = new System.Drawing.Point(3, 6);
            this.outData.Name = "outData";
            this.outData.RowHeadersWidth = 51;
            this.outData.RowTemplate.Height = 24;
            this.outData.Size = new System.Drawing.Size(952, 315);
            this.outData.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Test1
            // 
            this.Test1.HeaderText = "Test1";
            this.Test1.MinimumWidth = 6;
            this.Test1.Name = "Test1";
            this.Test1.ReadOnly = true;
            this.Test1.Width = 125;
            // 
            // Test2
            // 
            this.Test2.HeaderText = "Test2";
            this.Test2.MinimumWidth = 6;
            this.Test2.Name = "Test2";
            this.Test2.ReadOnly = true;
            this.Test2.Width = 125;
            // 
            // Test3
            // 
            this.Test3.HeaderText = "Test3";
            this.Test3.MinimumWidth = 6;
            this.Test3.Name = "Test3";
            this.Test3.ReadOnly = true;
            this.Test3.Width = 125;
            // 
            // Common
            // 
            this.Common.HeaderText = "Common";
            this.Common.MinimumWidth = 6;
            this.Common.Name = "Common";
            this.Common.ReadOnly = true;
            this.Common.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 548);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGW)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Bed_habits;
        private System.Windows.Forms.TextBox Vision;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox NamePerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox Psychiatrist_disease;
        private System.Windows.Forms.CheckedListBox Disease_therapist;
        private System.Windows.Forms.DataGridView dataGW;
        private System.Windows.Forms.Button upData;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button resTests;
        private System.Windows.Forms.DataGridView outData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Common;
    }
}

