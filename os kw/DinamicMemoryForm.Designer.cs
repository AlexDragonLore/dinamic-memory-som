namespace os_kw
{
    partial class DinamicMemoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DinamicMemoryForm));
            this.startDistribution = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showTasks = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PauseButton = new System.Windows.Forms.Button();
            this.speedDecrease = new System.Windows.Forms.Button();
            this.speedIncease = new System.Windows.Forms.Button();
            this.addTasks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.speedTasks = new System.Windows.Forms.Label();
            this.aboutProgram = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // startDistribution
            // 
            this.startDistribution.Location = new System.Drawing.Point(517, 744);
            this.startDistribution.Name = "startDistribution";
            this.startDistribution.Size = new System.Drawing.Size(134, 37);
            this.startDistribution.TabIndex = 0;
            this.startDistribution.Text = "Запустить распределение ";
            this.startDistribution.UseVisualStyleBackColor = true;
            this.startDistribution.Click += new System.EventHandler(this.startDistribution_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(192, 905);
            this.dataGridView1.TabIndex = 2;
            // 
            // showTasks
            // 
            this.showTasks.Location = new System.Drawing.Point(377, 12);
            this.showTasks.Multiline = true;
            this.showTasks.Name = "showTasks";
            this.showTasks.Size = new System.Drawing.Size(274, 726);
            this.showTasks.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(517, 787);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(134, 37);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.pausebutton_Click);
            // 
            // speedDecrease
            // 
            this.speedDecrease.Location = new System.Drawing.Point(517, 830);
            this.speedDecrease.Name = "speedDecrease";
            this.speedDecrease.Size = new System.Drawing.Size(134, 37);
            this.speedDecrease.TabIndex = 5;
            this.speedDecrease.Text = "Замедлить выполнение";
            this.speedDecrease.UseVisualStyleBackColor = true;
            this.speedDecrease.Click += new System.EventHandler(this.speedDown_Click);
            // 
            // speedIncease
            // 
            this.speedIncease.Location = new System.Drawing.Point(377, 830);
            this.speedIncease.Name = "speedIncease";
            this.speedIncease.Size = new System.Drawing.Size(134, 37);
            this.speedIncease.TabIndex = 6;
            this.speedIncease.Text = "Ускорить выполнение";
            this.speedIncease.UseVisualStyleBackColor = true;
            this.speedIncease.Click += new System.EventHandler(this.speedUp_Click);
            // 
            // addTasks
            // 
            this.addTasks.Location = new System.Drawing.Point(377, 787);
            this.addTasks.Name = "addTasks";
            this.addTasks.Size = new System.Drawing.Size(134, 37);
            this.addTasks.TabIndex = 7;
            this.addTasks.Text = "Добавить";
            this.addTasks.UseVisualStyleBackColor = true;
            this.addTasks.Click += new System.EventHandler(this.addTasks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 870);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Скорость выполнения задач в милисекундах:";
            // 
            // speedTasks
            // 
            this.speedTasks.AutoSize = true;
            this.speedTasks.Location = new System.Drawing.Point(620, 870);
            this.speedTasks.Name = "speedTasks";
            this.speedTasks.Size = new System.Drawing.Size(31, 13);
            this.speedTasks.TabIndex = 9;
            this.speedTasks.Text = "1000";
            // 
            // aboutProgram
            // 
            this.aboutProgram.Location = new System.Drawing.Point(377, 894);
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(274, 23);
            this.aboutProgram.TabIndex = 10;
            this.aboutProgram.Text = "О программе";
            this.aboutProgram.UseVisualStyleBackColor = true;
            this.aboutProgram.Click += new System.EventHandler(this.aboutProgram_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 761);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "35";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 745);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Задач для ОЗУ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(210, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(161, 914);
            this.dataGridView2.TabIndex = 15;
            // 
            // DdinamicMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 929);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aboutProgram);
            this.Controls.Add(this.speedTasks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTasks);
            this.Controls.Add(this.speedIncease);
            this.Controls.Add(this.speedDecrease);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.showTasks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.startDistribution);
            this.Name = "DdinamicMemory";
            this.Text = "Memory simulator";
            this.Load += new System.EventHandler(this.DinamicMemoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startDistribution;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox showTasks;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button speedDecrease;
        private System.Windows.Forms.Button speedIncease;
        private System.Windows.Forms.Button addTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speedTasks;
        private System.Windows.Forms.Button aboutProgram;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

