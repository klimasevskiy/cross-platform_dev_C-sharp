namespace lab1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NameTag = new System.Windows.Forms.ColumnHeader();
            this.Birth = new System.Windows.Forms.ColumnHeader();
            this.Number = new System.Windows.Forms.ColumnHeader();
            this.City = new System.Windows.Forms.ColumnHeader();
            this.Created_Date_Time = new System.Windows.Forms.ColumnHeader();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сортувати за прізвищем";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Вивести без сортування";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameTag,
            this.Birth,
            this.Number,
            this.City,
            this.Created_Date_Time});
            this.listView1.Location = new System.Drawing.Point(192, 23);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(987, 537);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NameTag
            // 
            this.NameTag.Text = "П. І. Б.";
            this.NameTag.Width = 300;
            // 
            // Birth
            // 
            this.Birth.DisplayIndex = 2;
            this.Birth.Text = "Дата народження";
            this.Birth.Width = 150;
            // 
            // Number
            // 
            this.Number.DisplayIndex = 1;
            this.Number.Text = "Номер";
            this.Number.Width = 150;
            // 
            // City
            // 
            this.City.Text = "Місто";
            this.City.Width = 150;
            // 
            // Created_Date_Time
            // 
            this.Created_Date_Time.Text = "Дата та час створення";
            this.Created_Date_Time.Width = 200;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 83);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сортувати за датою народження";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 83);
            this.button4.TabIndex = 5;
            this.button4.Text = "Сортувати за датою та часом створення";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 68);
            this.button5.TabIndex = 6;
            this.button5.Text = "Додати контакт";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 418);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 68);
            this.button6.TabIndex = 6;
            this.button6.Text = "Показати львівські номери";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 492);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 68);
            this.button7.TabIndex = 6;
            this.button7.Text = "Показати номери Life та Київстар";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 600);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button2;
        private ListView listView1;
        private ColumnHeader NameTag;
        private ColumnHeader Birth;
        private ColumnHeader Number;
        private ColumnHeader City;
        private ColumnHeader Created_Date_Time;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}