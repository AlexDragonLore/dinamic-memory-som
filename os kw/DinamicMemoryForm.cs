using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os_kw
{
    public partial class DinamicMemoryForm : Form
    {
        public DinamicMemoryForm()
        {
            InitializeComponent();
        }
        DinamicMemory DinamicMemory = new DinamicMemory();

        private void startDistribution_Click(object sender, EventArgs e)
        {
            showTasks.Clear();
            bool trigger = DinamicMemory.doOneTask();
            while (trigger)
            {
                trigger = DinamicMemory.doOneTask();
            }
            showTasks.Text += getTascksInStr();
            memoryDraw(sender, e);
            taskDrow(sender, e);

            timer1.Start();

        }

        private void generateTasks_Click(object sender, EventArgs e)
        {
            showTasks.Clear();
  
            DinamicMemory.generateTask();

            showTasks.Font = new Font("Arial", 10);

            showTasks.Text += getTascksInStr();
        }

        private string getTascksInStr()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Активных задач: " + DinamicMemory.activeTasks.Count);
            sb.AppendLine("Активные задачи:");
            int usageMamory = 0;
            foreach (int[] actibeTask in DinamicMemory.activeTasks)
            {
                sb.AppendLine(Convert.ToString(actibeTask[1]) + " МБайт");
                usageMamory+= actibeTask[1];
            }
            sb.AppendLine("Памяти используеться: "+ usageMamory.ToString() + " МБайт из 512");
            sb.AppendLine("");
            sb.AppendLine("Задач в очереди: " + DinamicMemory.tasks.Count);
            sb.AppendLine("Задачи в очереди: ");
            foreach (int task in DinamicMemory.tasks)
            {
                sb.AppendLine(Convert.ToString(task) + " МБайт");
            }
            return sb.ToString();
        }
        private void memoryDraw(object sender, EventArgs e)
        {
            for (int i = 0; i < 512; i++)
            {
                if (DinamicMemory.memory[i])
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.Red;
                else
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.Green;
            }
        }
        private void taskDrow(object sender, EventArgs e)
        {                    
                dataGridView2.Rows.Clear();
            int i = 0;
            int pos = 0;
            for (; ; ) 
            {
                if (DinamicMemory.activeTasks.Count > 0)
                {
                    foreach (int[] activeTask in DinamicMemory.activeTasks)
                    {
                        if (activeTask[0]- pos > 0)
                        {
                            dataGridView2.Rows.Add("Empty "+ (activeTask[0]- pos).ToString()+" Мбайт");
                            dataGridView2.Rows[i].Height = activeTask[0]- pos;
                            dataGridView2.Rows[i].Cells[0].Style.BackColor = Color.Green;
                            pos = activeTask[0];
                            i++;
                        }
                        dataGridView2.Rows.Add(activeTask[1].ToString() + " Мбайт");
                        dataGridView2.Rows[i].Height = activeTask[1];
                        dataGridView2.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        i++;
                        pos += activeTask[1];
                    }
                    int end = DinamicMemory.activeTasks[DinamicMemory.activeTasks.Count - 1][1] + DinamicMemory.activeTasks[DinamicMemory.activeTasks.Count - 1][0];
                    if (512 - end > 0)
                    {
                        dataGridView2.Rows.Add("Empty " + (512 - end).ToString() + " Мбайт");
                        dataGridView2.Rows[i].Height = 512 - end;
                        dataGridView2.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    }
                    dataGridView2.ClearSelection();
                    break;
                }
                else
                {
                    dataGridView2.Rows.Add("Empty 512 Мбайт");
                    dataGridView2.Rows[0].Height = 512;
                    dataGridView2.Rows[0].Cells[0].Style.BackColor = System.Drawing.Color.Green;
                    dataGridView2.ClearSelection();
                    break;
                }
            }
        }

        private void DinamicMemoryForm_Load(object sender, EventArgs e)
        {
            
            showTasks.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Columns.Add("str", "memory") ;
            dataGridView2.Columns.Add("str", "tasts");
            dataGridView1.Columns[0].Width = 172;
            dataGridView2.Columns[0].Width = 158;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView1.ClearSelection();

            dataGridView2.Rows.Add("Empty 512 Мбайт");
            dataGridView2.Rows[0].Height = 512;
            dataGridView2.Rows[0].Cells[0].Style.BackColor = System.Drawing.Color.Green;
            dataGridView2.ClearSelection();



            for (int i = 0; i < 512; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 1;
                dataGridView1.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.Green;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showTasks.Clear();
            if (DinamicMemory.readonlyDoFewTasks())
            {
                timer1.Stop();
                MessageBox.Show("Все задания решены.");
            }
            bool trigger = DinamicMemory.doOneTask();
            while (trigger)
            {
                trigger = DinamicMemory.doOneTask();
            }
            showTasks.Text += getTascksInStr();
            memoryDraw(sender, e);
            taskDrow(sender, e);
        }

        private void speedUp_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(timer1.Interval * 0.7);
            speedTasks.Text = timer1.Interval.ToString();
        }

        private void speedDown_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(timer1.Interval * 1.3) + 1;
            speedTasks.Text = timer1.Interval.ToString();
        }


        private void pausebutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void addTasks_Click(object sender, EventArgs e)
        {
            try
            {
                DinamicMemory.addFewTasks(Convert.ToInt32(textBox1.Text));
                showTasks.Clear();
                showTasks.Text += getTascksInStr();
            }
            catch
            {
                MessageBox.Show("Поле \"Задач для ОЗУ\" должно содержать только цифры и не должно быть пустым", 
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutProgram_Click(object sender, EventArgs e)
        {
            aboutForm about = new aboutForm();
            about.Show();
        }
    }
}
