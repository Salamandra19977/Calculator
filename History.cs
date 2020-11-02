using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.LoadData();
        }

        private void LoadData()
        {
            foreach (string item in HistoryList.OperationList)
            {
                textBox1.Text += item + Environment.NewLine;
            }
        }
    }
}
