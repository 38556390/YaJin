using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YaJin
{
    public partial class Land : Form
    {
        public Land()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = "select * from Users where Account='" + textBox1.Text + "' and Pwd='"+textBox2.Text+"'";
            if (wu.SelectSQL(select) == true)
            {
                wu.account = textBox1.Text;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }
        private int flag = 0;
        public int getFlag()
        {
            return flag;
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            this.Close();
        }

        private void Land_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this.SelectNextControl(this.ActiveControl,true, true, true, true);
                //前台的KeyPreview 需改成 true 才能生效
                SendKeys.Send("{Tab}");  //向活动应用程序发送击键 注意格式：Send("{Tab}");中的{}
            }
        }
    }
}
