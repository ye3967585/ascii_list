using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ASCII_List
{
    public partial class Home : Form
    {
        private const int ASCII_LENTH = 127;        //ASCII 表的标准长度
        private List<string> controlChar;           //特殊的控制字符
        private List<string> meaning;               //释义
        private ListViewItem item;

        public Home()
        {
            InitializeComponent();

            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            item = new ListViewItem();
            controlChar = new List<string>();
            meaning = new List<string>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        #region 绘制
        /// <summary>
        /// 显示数据
        /// </summary>
        private void ShowData()
        {
            for (int i = 0; i <= ASCII_LENTH; i++)
            {
                WriteASCIIData(i);
            }
        }
        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="data"></param>
        private void WriteASCIIData(int data)
        {
            string str;
            LoadControlChar();
            LoadMeaning();
            item = listView1.Items.Add(Convert.ToString(data, 2));
            item.SubItems.Add(Convert.ToString(data, 8));
            item.SubItems.Add(data.ToString());
            item.SubItems.Add((Convert.ToString(data, 16)).ToString().ToUpper());

            if (data <= 32)
            {
                str = controlChar[data];
            }
            else if (data == 127)
            {
                str = "DEL";
            }
            else
            {
                str = ((char)data).ToString();
            }
            item.SubItems.Add(str);
            item.SubItems.Add(meaning[data].Trim());
        }
        /// <summary>
        /// 初始化控制字符
        /// </summary>
        private void LoadControlChar()
        {
            controlChar.Add("NUL  (\\0)");
            controlChar.Add("SOH");
            controlChar.Add("STX");
            controlChar.Add("ETX");
            controlChar.Add("EOT");
            controlChar.Add("ENQ");
            controlChar.Add("ACK");
            controlChar.Add("BEL  (\\a)");
            controlChar.Add("BS   (\\b)");
            controlChar.Add("HT   (\\t)");
            controlChar.Add("LF   (\\n)");
            controlChar.Add("VT   (\\v)");
            controlChar.Add("FF   (\\f)");
            controlChar.Add("CR   (\\r)");
            controlChar.Add("SO");
            controlChar.Add("SI");
            controlChar.Add("DLE");
            controlChar.Add("DC1");
            controlChar.Add("DC2");
            controlChar.Add("DC3");
            controlChar.Add("DC4");
            controlChar.Add("NAK");
            controlChar.Add("SYN");
            controlChar.Add("ETB");
            controlChar.Add("CAN");
            controlChar.Add("EM");
            controlChar.Add("SUB");
            controlChar.Add("ESC   (\\e)");
            controlChar.Add("FS");
            controlChar.Add("GS");
            controlChar.Add("RS");
            controlChar.Add("US");
            controlChar.Add("SPACE");
        }
        /// <summary>
        /// 载入含义
        /// </summary>
        private void LoadMeaning()
        {
            #region ADD
            meaning.Add("空字符");
            meaning.Add("标题开始");
            meaning.Add("正文开始");
            meaning.Add("正文结束");
            meaning.Add("传输结束");
            meaning.Add("请求");
            meaning.Add("收到通知");
            meaning.Add("响铃");
            meaning.Add("退格");
            meaning.Add("水平制表符");
            meaning.Add("换行键");
            meaning.Add("垂直制表符");
            meaning.Add("换页键");
            meaning.Add("回车键");
            meaning.Add("禁用切换");
            meaning.Add("启用切换");
            meaning.Add("数据链路转义");
            meaning.Add("设备控制1");
            meaning.Add("设备控制2");
            meaning.Add("设备控制3");
            meaning.Add("设备控制4");
            meaning.Add("拒绝接收");
            meaning.Add("同步空闲");
            meaning.Add("结束传输块");
            meaning.Add("取消");
            meaning.Add("媒介结束");
            meaning.Add("代替");
            meaning.Add("换码(溢出)");
            meaning.Add("文件分隔符");
            meaning.Add("分组符");
            meaning.Add("记录分隔符");
            meaning.Add("单元分隔符");
            meaning.Add("空格");
            meaning.Add("叹号");
            meaning.Add("双引号");
            meaning.Add("井号");
            meaning.Add("美元符");
            meaning.Add("百分号");
            meaning.Add("和号");
            meaning.Add("闭单引号");
            meaning.Add("开括号");
            meaning.Add("闭括号");
            meaning.Add("星号");
            meaning.Add("加号");
            meaning.Add("逗号");
            meaning.Add("减号/破折号");
            meaning.Add("句号");
            meaning.Add("斜杠");
            meaning.Add("数字0");
            meaning.Add("数字1");
            meaning.Add("数字2");
            meaning.Add("数字3");
            meaning.Add("数字4");
            meaning.Add("数字5");
            meaning.Add("数字6");
            meaning.Add("数字7");
            meaning.Add("数字8");
            meaning.Add("数字9");
            meaning.Add("冒号");
            meaning.Add("分号");
            meaning.Add("小于号");
            meaning.Add("等号");
            meaning.Add("大于号");
            meaning.Add("问号");
            meaning.Add("At号");
            meaning.Add("大写字母A");
            meaning.Add("大写字母B");
            meaning.Add("大写字母C");
            meaning.Add("大写字母D");
            meaning.Add("大写字母E");
            meaning.Add("大写字母F");
            meaning.Add("大写字母G");
            meaning.Add("大写字母H");
            meaning.Add("大写字母I");
            meaning.Add("大写字母J");
            meaning.Add("大写字母K");
            meaning.Add("大写字母L");
            meaning.Add("大写字母M");
            meaning.Add("大写字母N");
            meaning.Add("大写字母O");
            meaning.Add("大写字母P");
            meaning.Add("大写字母Q");
            meaning.Add("大写字母R");
            meaning.Add("大写字母S");
            meaning.Add("大写字母T");
            meaning.Add("大写字母U");
            meaning.Add("大写字母V");
            meaning.Add("大写字母W");
            meaning.Add("大写字母X");
            meaning.Add("大写字母Y");
            meaning.Add("大写字母Z");
            meaning.Add("开方括号");
            meaning.Add("反斜杠");
            meaning.Add("闭方括号");
            meaning.Add("脱字符");
            meaning.Add("下划线");
            meaning.Add("单引号");
            meaning.Add("小写字母a");
            meaning.Add("小写字母b");
            meaning.Add("小写字母c");
            meaning.Add("小写字母d");
            meaning.Add("小写字母e");
            meaning.Add("小写字母f");
            meaning.Add("小写字母g");
            meaning.Add("小写字母h");
            meaning.Add("小写字母i");
            meaning.Add("小写字母j");
            meaning.Add("小写字母k");
            meaning.Add("小写字母l");
            meaning.Add("小写字母m");
            meaning.Add("小写字母n");
            meaning.Add("小写字母o");
            meaning.Add("小写字母p");
            meaning.Add("小写字母q");
            meaning.Add("小写字母r");
            meaning.Add("小写字母s");
            meaning.Add("小写字母t");
            meaning.Add("小写字母u");
            meaning.Add("小写字母v");
            meaning.Add("小写字母w");
            meaning.Add("小写字母x");
            meaning.Add("小写字母y");
            meaning.Add("小写字母z");
            meaning.Add("开花括号");
            meaning.Add("垂线");
            meaning.Add("闭花括号");
            meaning.Add("波浪号");
            meaning.Add("删除");
            #endregion
        }
        #endregion

        #region 查询
        private void ScreenedData(string option)
        {
            switch (option)
            {
                case "ASCII":
                    listView1.Items.Clear();
                    ShowData();
                    break;
                case "0-9":
                    FindData(48, 57, 2, listView1, Color.BlueViolet, Color.Yellow, clear: true);
                    break;
                case "a-z":
                    FindData(97, 122, 2, listView1, Color.ForestGreen, Color.Yellow, clear: true);
                    break;
                case "A-Z":
                    FindData(65, 90, 2, listView1, Color.DarkBlue, Color.Yellow, clear: true);
                    break;
                case "字符":
                    FindData(32, 126, 2, listView1, Color.DarkBlue, Color.Yellow, clear: true);
                    break;
                case "控制字符(通信专用字符)":
                    FindData(0, 31, 2, listView1, Color.DarkBlue, Color.Yellow, clear: true);
                    break;
                case "退格":
                    FindData(4, listView1, Color.DarkBlue, Color.Yellow, true, "BS   (\\b)");
                    break;
                case "制表":
                    FindData(4, listView1, Color.DarkBlue, Color.Yellow, true, "HT   (\\t)");
                    break;
                case "换行":
                    FindData(4, listView1, Color.DarkBlue, Color.Yellow, true, "LF   (\\n)");
                    break;
                case "回车":
                    FindData(4, listView1, Color.DarkBlue, Color.Yellow, true, "CR   (\\r)");
                    break;
            }
        }
        /// <summary>
        /// 寻找并高亮目标值
        /// </summary>
        /// <param name="row">从第几列寻找</param>
        /// <param name="listView">列表对象</param>
        /// <param name="BackColor">高亮背景色</param>
        /// <param name="ForeColor">高亮前景色</param>
        /// <param name="list">目标值集合</param>
        private void FindData(int row, ListView listView, Color BackColor, Color ForeColor, bool clear, params string[] list)
        {
            if (clear)
            {
                listView.Items.Clear();
                ShowData();
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (listView1.Items[i].SubItems[row].Text == list[j])
                    {
                        listView1.Items[i].BackColor = BackColor;
                        listView1.Items[i].ForeColor = ForeColor;
                        listView1.EnsureVisible(i);
                    }
                }
            }
        }
        /// <summary>
        /// 寻找并高亮目标值
        /// </summary>
        /// <param name="row">从第几列寻找</param>
        /// <param name="listView">列表对象</param>
        /// <param name="BackColor">高亮背景色</param>
        /// <param name="ForeColor">高亮前景色</param>
        /// <param name="end">结束值</param>
        /// <param name="start">起始值</param>
        private void FindData(int start, int end, int row, ListView listView, Color BackColor, Color ForeColor, bool clear)
        {
            if (clear)
            {
                listView.Items.Clear();
                ShowData();
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (int.Parse(listView1.Items[i].SubItems[row].Text) >= start && int.Parse(listView1.Items[i].SubItems[row].Text) <= end)
                {
                    listView1.Items[i].BackColor = BackColor;
                    listView1.Items[i].ForeColor = ForeColor;
                    listView1.EnsureVisible(i);
                }
            }
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScreenedData(toolStripComboBox1.SelectedItem.ToString());
        }
        #endregion

        #region 复制值
        private void 二进制值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(listView1.SelectedItems[0].Text, true);
            toolStripStatusLabel1.Text = "复制了值 " + listView1.SelectedItems[0].Text;
        }
        private void 八进制值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(listView1.SelectedItems[0].SubItems[1].Text, true);
            toolStripStatusLabel1.Text = "复制了值 " + listView1.SelectedItems[0].SubItems[1].Text;
        }
        private void 十进制值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(listView1.SelectedItems[0].SubItems[2].Text, true);
            toolStripStatusLabel1.Text = "复制了值 " + listView1.SelectedItems[0].SubItems[2].Text;
        }
        private void 十六进制值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(listView1.SelectedItems[0].SubItems[3].Text, true);
            toolStripStatusLabel1.Text = "复制了值 " + listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void 二进制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(listView1.SelectedItems[0].Text, true);
            toolStripStatusLabel1.Text = "复制了值 " + listView1.SelectedItems[0].Text;
        }

        private void 八进制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(listView1.SelectedItems[0].SubItems[1].Text, true);
            toolStripStatusLabel1.Text = "复制了值 " + listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void 十进制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(listView1.SelectedItems[0].SubItems[2].Text, true);
            toolStripStatusLabel1.Text = "复制了值 " + listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void 十六进制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(listView1.SelectedItems[0].SubItems[3].Text, true);
            toolStripStatusLabel1.Text = "复制了值 " + listView1.SelectedItems[0].SubItems[3].Text;
        }
        #endregion

        private void aSCII扩展ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ASCII_E aSCII_E = new ASCII_E();
            aSCII_E.Show();
        }
       
        private void 清空标记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ShowData();
        }

        private void 转换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Covrert covrert = new _Covrert();
            covrert.ShowDialog();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                toolStripStatusLabel1.Text = listView1.SelectedItems[0].SubItems[4].Text + "    (" + listView1.SelectedItems[0].SubItems[0].Text + "-" + listView1.SelectedItems[0].SubItems[1].Text + "-" + listView1.SelectedItems[0].SubItems[2].Text + "-" + listView1.SelectedItems[0].SubItems[3].Text + ")";
            }

        }

        private void 帮助文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }


       
    }

}

