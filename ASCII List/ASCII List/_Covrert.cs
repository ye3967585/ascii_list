using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetroTime.IO;

namespace ASCII_List
{
    public partial class _Covrert : Form
    {
        public _Covrert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0)
            {
                textBox2.Text = CONVERT.ToASCII(textBox1.Text, checkBox1.Checked);
            }
            else
            {
                MessageBox.Show("不可以转换空值。", "警告");
            }
           
            if (checkBox2.Checked) Clipboard.SetDataObject(textBox2.Text);
            if (checkBox3.Checked)
            {
                if (textBox3.Text != null)
                {
                    FILE.Create(textBox3.Text, textBox2.Text);
                }
                else
                {
                    MessageBox.Show("路径为空或非法", "警告");
                } 
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = textBox3.Visible = button2.Visible = checkBox3.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sav = new SaveFileDialog();
            sav.Filter = "Text Document(*.txt)|*.txt|All Files|*.*";
            sav.ShowDialog();
            textBox3.Text = sav.FileName;
        }
    }
}
