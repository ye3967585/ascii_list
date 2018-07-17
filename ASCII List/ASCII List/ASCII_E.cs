using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII_List
{
    public partial class ASCII_E : Form
    {
        public ASCII_E()
        {
            InitializeComponent();
        }

        private void Text_Load(object sender, EventArgs e)
        {
            MessageBox.Show("本程序无法显示扩展ASCII表中的多半部分字符，故此采用图片的形式来列出。","须知");
        }
    }
}
