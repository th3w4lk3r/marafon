﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон1._1
{
    public partial class Form_runner : Form
    {
        public Form_runner()
        {
            InitializeComponent();
        }

        private void Form_runner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_МарафонV1_1DataSet.Бегуны". При необходимости она может быть перемещена или удалена.
            this.бегуныTableAdapter.Fill(this._МарафонV1_1DataSet.Бегуны);


            string temp;
            int numb = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                temp = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (temp == Class1.NowID)
                {
                    numb = i;
                   
                    break;
                }
            }
            textBox1.Text = dataGridView1.Rows[numb].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[numb].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[numb].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_result f = new Form_result();
            f.Show();
        }
    }
}
