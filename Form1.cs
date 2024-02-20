using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void action_Click(object sender, EventArgs e)
        {
            action.Enabled = false;

            


            if (radioButton1.Created == true && radioButton2.Checked == false)
            {
                AsyncFunc();
            }
            else if (radioButton2.Checked == true && radioButton1.Checked == false)
            {
                SyncFunc();
            }
            else
            {
                MessageLabel.Text = "しっぱい";
            }
        }

        
        

        private async void AsyncFunc()
        {
            await Task.Run(() => HeavyMethodAsync());
            MessageLabel.Text = "重い処理終わり";
            action.Enabled = true;
            InitializeCounter();
        }
        private void SyncFunc()
        {
            HeavyMethodAsync();
            MessageLabel.Text = "重い処理終わり";
            action.Enabled = true;
            InitializeCounter();
        }

        private async Task HeavyMethodAsync()
        {
            foreach (var i in Enumerable.Range(0, 1000000000))
            {
               
            }
        }
        
        private void HeavyMedhodSync()
        {
            
            foreach (var i in Enumerable.Range(0, 1000000000))
            {

            }
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCounter();
        }

        private void InitializeCounter()
        {
            label2.Text = "0";
        }

        private void AddCounter()
        {
            int number;
            var text = label2.Text;

            if (int.TryParse(text, out number))
            {
                label2.Text = (number + 1).ToString();
            }
            else
            {
                label2.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = !radioButton1.Checked;
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = !radioButton2.Checked;
        }
    }
}
