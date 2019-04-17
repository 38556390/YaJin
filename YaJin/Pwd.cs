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
    public partial class Pwd : Form
    {
        public Pwd()
        {
            InitializeComponent();
        }

        private void Pwd_Load(object sender, EventArgs e)
        {
            Account.Text = wu.account;
            string select = "select UserName from Users where Account='" + Account.Text + "'";
            string[] a = wu.get_Value(select);
            UserName.Text = a[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update = "update Users set Pwd='" + Pwds.Text + "' where Account='"+wu.account+"'";
            if(wu.ExecSQL(update)==true)
            {
                MessageBox.Show("密码修改成功，下次登陆请使用新密码！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insert = "insert into Users(Account,Pwd,UserName) values "+
                " ('"+Account.Text+"','"+Pwds.Text+"','"+UserName.Text+"')";
            string select = "select id from Users where Account='"+Account.Text+"'";
            if(wu.SelectSQL(select)==true)
            {
                MessageBox.Show("操作失败，原因：已存在此登陆号！");
                return;
            }
            if(wu.ExecSQL(insert)==true)
            {
                MessageBox.Show("用户新增成功！");
            }
        }
    }
}
