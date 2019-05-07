namespace Распределение_нагрузки
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиButton = new System.Windows.Forms.Button();
            this.группыButton = new System.Windows.Forms.Button();
            this.учебныйПланButton = new System.Windows.Forms.Button();
            this.общаяНагрузкаButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.магистрыButton = new System.Windows.Forms.Button();
            this.бакалаврыButton = new System.Windows.Forms.Button();
            this.сводныйОтчетButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(252, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.преподавателиToolStripMenuItem,
            this.группыToolStripMenuItem,
            this.предметыToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            this.преподавателиToolStripMenuItem.Click += new System.EventHandler(this.преподавателиToolStripMenuItem_Click);
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.группыToolStripMenuItem.Text = "Группы и потоки";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // предметыToolStripMenuItem
            // 
            this.предметыToolStripMenuItem.Name = "предметыToolStripMenuItem";
            this.предметыToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.предметыToolStripMenuItem.Text = "Учебный план";
            this.предметыToolStripMenuItem.Click += new System.EventHandler(this.предметыToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // преподавателиButton
            // 
            this.преподавателиButton.Location = new System.Drawing.Point(12, 40);
            this.преподавателиButton.Name = "преподавателиButton";
            this.преподавателиButton.Size = new System.Drawing.Size(228, 23);
            this.преподавателиButton.TabIndex = 1;
            this.преподавателиButton.Text = "Преподаватели";
            this.преподавателиButton.UseVisualStyleBackColor = true;
            this.преподавателиButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // группыButton
            // 
            this.группыButton.Location = new System.Drawing.Point(12, 69);
            this.группыButton.Name = "группыButton";
            this.группыButton.Size = new System.Drawing.Size(228, 23);
            this.группыButton.TabIndex = 2;
            this.группыButton.Text = "Группы и потоки";
            this.группыButton.UseVisualStyleBackColor = true;
            this.группыButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // учебныйПланButton
            // 
            this.учебныйПланButton.Location = new System.Drawing.Point(12, 98);
            this.учебныйПланButton.Name = "учебныйПланButton";
            this.учебныйПланButton.Size = new System.Drawing.Size(228, 23);
            this.учебныйПланButton.TabIndex = 3;
            this.учебныйПланButton.Text = "Учебный план";
            this.учебныйПланButton.UseVisualStyleBackColor = true;
            this.учебныйПланButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // общаяНагрузкаButton
            // 
            this.общаяНагрузкаButton.Location = new System.Drawing.Point(6, 19);
            this.общаяНагрузкаButton.Name = "общаяНагрузкаButton";
            this.общаяНагрузкаButton.Size = new System.Drawing.Size(216, 23);
            this.общаяНагрузкаButton.TabIndex = 4;
            this.общаяНагрузкаButton.Text = "Общая нагрузка";
            this.общаяНагрузкаButton.UseVisualStyleBackColor = true;
            this.общаяНагрузкаButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.магистрыButton);
            this.groupBox1.Controls.Add(this.бакалаврыButton);
            this.groupBox1.Controls.Add(this.сводныйОтчетButton);
            this.groupBox1.Controls.Add(this.общаяНагрузкаButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчеты";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Бакалавры-дистантники";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // магистрыButton
            // 
            this.магистрыButton.Location = new System.Drawing.Point(117, 48);
            this.магистрыButton.Name = "магистрыButton";
            this.магистрыButton.Size = new System.Drawing.Size(105, 23);
            this.магистрыButton.TabIndex = 7;
            this.магистрыButton.Text = "Магистры";
            this.магистрыButton.UseVisualStyleBackColor = true;
            // 
            // бакалаврыButton
            // 
            this.бакалаврыButton.Location = new System.Drawing.Point(6, 48);
            this.бакалаврыButton.Name = "бакалаврыButton";
            this.бакалаврыButton.Size = new System.Drawing.Size(105, 23);
            this.бакалаврыButton.TabIndex = 6;
            this.бакалаврыButton.Text = "Бакалавры";
            this.бакалаврыButton.UseVisualStyleBackColor = true;
            this.бакалаврыButton.Click += new System.EventHandler(this.бакалаврыButton_Click);
            // 
            // сводныйОтчетButton
            // 
            this.сводныйОтчетButton.Location = new System.Drawing.Point(6, 106);
            this.сводныйОтчетButton.Name = "сводныйОтчетButton";
            this.сводныйОтчетButton.Size = new System.Drawing.Size(216, 23);
            this.сводныйОтчетButton.TabIndex = 5;
            this.сводныйОтчетButton.Text = "Сводный отчет";
            this.сводныйОтчетButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.учебныйПланButton);
            this.Controls.Add(this.группыButton);
            this.Controls.Add(this.преподавателиButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.Button преподавателиButton;
        private System.Windows.Forms.Button группыButton;
        private System.Windows.Forms.Button учебныйПланButton;
        private System.Windows.Forms.Button общаяНагрузкаButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button сводныйОтчетButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button магистрыButton;
        private System.Windows.Forms.Button бакалаврыButton;
    }
}

