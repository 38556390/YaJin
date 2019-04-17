using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

using System.Diagnostics;


namespace YaJin
{
    public partial class Form1 : Form
    {
        Land l = null;
        public Form1()
        {
            InitializeComponent();
            l = new Land();
            l.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region//保存代码(打印飞机票时不需要此功能)


           
            //if (textBox1.Text == "")
            //{
            //    MessageBox.Show("付款单位（人）不能为空！", "ERROR");
            //    return;
            //}
            //if (textBox20.Text == "")
            //{
            //    MessageBox.Show("发票号不能为空！", "ERROR");
            //    return;
            //}
            //if (textBox20.Text.Length <3)
            //{
            //    MessageBox.Show("发票号至少需填三位数！", "ERROR");
            //    return;
            //}
            //string b = textBox20.Text.Substring(0, 2);//获取前两个英文字母
            //string i = textBox20.Text.Replace(b, "");//过滤英文字母
            //int x = 0;
            //try
            //{
            //    x = Convert.ToInt32(i);//转换为数字，清除无效前位0
            //}
            //catch
            //{
            //    MessageBox.Show("操作失败，发票号第三位起需是数字！", "ERROR");
            //    return;
            //}
            //if (textBox2.Text == "")
            //{
            //    MessageBox.Show("第一行收款项目不能为空！", "ERROR");
            //    return;
            //}
            //if (textBox3.Text == "" || wu.IsValidFloat(textBox3.Text) == false)
            //{
            //    MessageBox.Show("第一行单价格式错误！", "ERROR");
            //    return;
            //}
            //if (textBox4.Text == "" || wu.IsValidInt(textBox4.Text) == false)
            //{
            //    MessageBox.Show("第一行数量格式错误！", "ERROR");
            //    return;
            //}
            //if (wu.IsValidFloat(textBox7.Text) == false)
            //{
            //    MessageBox.Show("第二行单价格式错误！", "ERROR");
            //    return;
            //}
            //if (wu.IsValidInt(textBox8.Text) == false)
            //{
            //    MessageBox.Show("第二行数量格式错误！", "ERROR");
            //    return;
            //}
            //if (wu.IsValidFloat(textBox11.Text) == false)
            //{
            //    MessageBox.Show("第三行单价格式错误！", "ERROR");
            //    return;
            //}
            //if (wu.IsValidInt(textBox12.Text) == false)
            //{
            //    MessageBox.Show("第三行数量格式错误！", "ERROR");
            //    return;
            //}
            //string select = "select id from FaPiao where FaPiaoHao='"+textBox20.Text+"'";
            //if(wu.SelectSQL(select)==true)
            //{
            //    MessageBox.Show("操作失败，已存在此发票号！", "ERROR");
            //    return;
            //}

            //if (textBox21.Text == "" || wu.IsValidInt2(textBox21.Text) == false)
            //{
            //    MessageBox.Show("纸张高度格式错误！", "ERROR");
            //    return;
            //}
            //if (textBox22.Text == "" || wu.IsValidInt2(textBox22.Text) == false)
            //{
            //    MessageBox.Show("内容横向度！", "ERROR");
            //    return;
            //}
            //if (textBox23.Text == "" || wu.IsValidInt2(textBox23.Text) == false)
            //{
            //    MessageBox.Show("内容纵向度！", "ERROR");
            //    return;
            //}

            //string FuKanRen = textBox1.Text;
            //DateTime FuKanShiJian = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            //string FaPiaoHao = textBox20.Text;

            ////第一行
            //string XiangMu1 = textBox2.Text;
            //float DanJia1 = 0.00F;
            //int ShuLiang1 = 0;
            //float JE1 = 0.00F;
            //if (textBox3.Text != "" && textBox4.Text != "")
            //{
            //    DanJia1 = Convert.ToSingle(textBox3.Text);
            //    ShuLiang1 = Convert.ToInt32(textBox4.Text);
            //    JE1 = DanJia1 * ShuLiang1;
            //}

            ////第二行
            //string XiangMu2 = textBox6.Text;
            //float DanJia2 = 0.00F;
            //int ShuLiang2 = 0;
            //float JE2 = 0.00F;
            //if (textBox7.Text != "" && textBox8.Text != "")
            //{
            //    DanJia2 = Convert.ToSingle(textBox7.Text);
            //    ShuLiang2 = Convert.ToInt32(textBox8.Text);
            //    JE2 = DanJia2 * ShuLiang2;
            //}

            ////第三行
            //string XiangMu3 = textBox10.Text;
            //float DanJia3 = 0.00F;
            //int ShuLiang3 = 0;
            //float JE3 = 0.00F;
            //if (textBox11.Text != "" && textBox12.Text != "")
            //{
            //    DanJia3 = Convert.ToSingle(textBox11.Text);
            //    ShuLiang3 = Convert.ToInt32(textBox12.Text);
            //    JE3 = DanJia3 * ShuLiang3;
            //}

            //float HeJi = JE1 + JE2 + JE3;
            //textBox17.Text = Convert.ToString(HeJi);
            //textBox18.Text = MoneyToUpper(textBox17.Text);
            //string BeiZhu = textBox19.Text;
            //string ShouKanDanWei = textBox14.Text;
            //string FuHe = textBox15.Text;
            //string ShouKanRen = textBox16.Text;
            //DateTime Ctime = DateTime.Now;
            //string SysAccount = wu.account;
            //DateTime Ctime2 = DateTime.Now;
            //string SysAccount2 = "";
            //comboBox1.Text = "已打印";
            //string ZhuangTai = comboBox1.Text;
            //label10.Text = textBox20.Text;

            //string insert = "insert into FaPiao (" +
            //                "FuKanRen,FuKanShiJian,XiangMu1,DanJia1,ShuLiang1,XiangMu2,DanJia2," +
            //                "ShuLiang2,XiangMu3,DanJia3,ShuLiang3,HeJi,BeiZhu,ShouKanDanWei," +
            //                "FuHe,ShouKanRen,Ctime,SysAccount,ZhuangTai,Ctime2,SysAccount2,FaPiaoHao" +
            //                ") values ('" +
            //                FuKanRen + "','" + FuKanShiJian + "','" + XiangMu1 + "','" + DanJia1 + "','" +
            //                ShuLiang1 + "','" + XiangMu2 + "','" + DanJia2 + "','" + ShuLiang2 + "','" +
            //                XiangMu3 + "','" + DanJia3 + "','" + ShuLiang3 + "','" + HeJi + "','" +
            //                BeiZhu + "','" + ShouKanDanWei + "','" + FuHe + "','" + ShouKanRen + "','" +
            //                Ctime + "','" + SysAccount + "','" + ZhuangTai + "','" + Ctime2 + "','" +
            //                SysAccount2 + "','" + FaPiaoHao + "')";

            //if (wu.ExecSQL(insert) == true)
            //{
            //    MessageBox.Show("保存成功", "OK");
            //    //return;
            //}
            //else
            //{
            //    MessageBox.Show("系统错误，请联系计算机管理科！", "ERROR");
            //    return;
            //}

            #endregion


            #region//打印代码
            // printDocument1 为 打印控件   
            //设置打印用的纸张 当设置为Custom的时候，可以自定义纸张的大小，还可以选择A4,A5等常用纸型   
            int aHeight = 400 + Convert.ToInt32(textBox21.Text);//设置打印纸张高
            this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 740, aHeight);//百份之英寸为单位
            //以下是飞机票尺寸
            //int aHeight = 397 + Convert.ToInt32(textBox21.Text);//设置打印纸张高
            //this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 823, aHeight);//百份之英寸为单位
            //this.printDocument1.PrintPage += new PrintPageEventHandler(this.MyPrintDocument_PrintPage);
            //this.printDocument1.DefaultPageSettings.Landscape = false;//横向打印，只在打印飞机票时才需要
            //将写好的格式给打印预览控件以便预览 
           
            printPreviewDialog1.Document = printDocument1;
            //显示打印预览   
            //DialogResult result = printPreviewDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //    this.printDocument1.Print();  
           // printDocument1.
                printDocument1.Print();
            #endregion

               // textBox20.Text = BianHao(textBox20.Text);//发票号增1
        }
        /// <summary>   
        /// 打印的格式   
        /// </summary>   
        /// <param name="sender"></param>   
        /// <param name="e"></param>   
        private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = false;//横向打印，只在打印飞机票时才需要
            int xWidth = Convert.ToInt32(textBox22.Text);//横向宽度
            int yHeight = Convert.ToInt32(textBox23.Text);//纵向高度
            #region//正常打印
            /*如果需要改变自己 可以在new Font(new FontFamily("黑体"),11）中的“黑体”改成自己要的字体就行了，黑体 后面的数字代表字体的大小 
             System.Drawing.Brushes.Blue , 170, 10 中的 System.Drawing.Brushes.Blue 为颜色，后面的为输出的位置 */
            string select = "select FuKanRen,FuKanShiJian,XiangMu1,DanJia1,ShuLiang1,XiangMu2,DanJia2,ShuLiang2,XiangMu3" +
                ",DanJia3,ShuLiang3,HeJi,BeiZhu,ShouKanDanWei,FuHe,ShouKanRen" +
                " from FaPiao" +
                " where FuKanRen='" + textBox1.Text + "'  and FaPiaoHao='" + textBox20.Text + "'";
            //string select = "select FuKanRen,FuKanShiJian,XiangMu1,DanJia1,ShuLiang1,XiangMu2,DanJia2,ShuLiang2,XiangMu3" +
            // ",DanJia3,ShuLiang3,HeJi,BeiZhu,ShouKanDanWei,FuHe,ShouKanRen" +
            // " from FaPiao";



            string[] a = wu.get_Value(select);
            string nain = Convert.ToDateTime(a[1]).Year.ToString();
            string yue = Convert.ToDateTime(a[1]).Month.ToString();
            string ri = Convert.ToDateTime(a[1]).Day.ToString();
            e.Graphics.DrawString(a[0], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 100 + xWidth, 61 + yHeight);//付款单位人
            e.Graphics.DrawString(nain, new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 445 + xWidth, 61 + yHeight);//年
            e.Graphics.DrawString(yue, new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 525 + xWidth, 61 + yHeight);//月
            e.Graphics.DrawString(ri, new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 585 + xWidth, 61 + yHeight);//日

            e.Graphics.DrawString(a[2], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 10 + xWidth, 129 + yHeight);//收款项目1
            e.Graphics.DrawString(a[3], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 300 + xWidth, 129 + yHeight);//收款单价1
            e.Graphics.DrawString(a[4], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 390 + xWidth, 129 + yHeight);//收款数量1
            double a1 = Convert.ToDouble(a[3]) * Convert.ToDouble(a[4]);
            e.Graphics.DrawString(DaXie2(a1, 0), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 448 + xWidth, 129 + yHeight);//百万
            e.Graphics.DrawString(DaXie2(a1, 1), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 468 + xWidth, 129 + yHeight);//十万
            e.Graphics.DrawString(DaXie2(a1, 2), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 488 + xWidth, 129 + yHeight);//万
            e.Graphics.DrawString(DaXie2(a1, 3), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 508 + xWidth, 129 + yHeight);//千
            e.Graphics.DrawString(DaXie2(a1, 4), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 528 + xWidth, 129 + yHeight);//百
            e.Graphics.DrawString(DaXie2(a1, 5), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 548 + xWidth, 129 + yHeight);//十
            e.Graphics.DrawString(DaXie2(a1, 6), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 568 + xWidth, 129 + yHeight);//元
            e.Graphics.DrawString(DaXie2(a1, 8), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 588 + xWidth, 129 + yHeight);//角
            e.Graphics.DrawString(DaXie2(a1, 9), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 608 + xWidth, 129 + yHeight);//分

            if (a[5] != "" && a[5] != null)
            {
                e.Graphics.DrawString(a[5], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 10 + xWidth, 161 + yHeight);//收款项目2
                e.Graphics.DrawString(wu.set_null(a[6]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 300 + xWidth, 161 + yHeight);//收款单价2
                e.Graphics.DrawString(wu.set_null(a[7]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 390 + xWidth, 161 + yHeight);//收款数量2
                double a2 = Convert.ToDouble(a[6]) * Convert.ToDouble(a[7]);
                e.Graphics.DrawString(DaXie2(a2, 0), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 448 + xWidth, 161 + yHeight);//百万
                e.Graphics.DrawString(DaXie2(a2, 1), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 468 + xWidth, 161 + yHeight);//十万
                e.Graphics.DrawString(DaXie2(a2, 2), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 488 + xWidth, 161 + yHeight);//万
                e.Graphics.DrawString(DaXie2(a2, 3), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 508 + xWidth, 161 + yHeight);//千
                e.Graphics.DrawString(DaXie2(a2, 4), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 528 + xWidth, 161 + yHeight);//百
                e.Graphics.DrawString(DaXie2(a2, 5), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 548 + xWidth, 161 + yHeight);//十
                e.Graphics.DrawString(DaXie2(a2, 6), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 568 + xWidth, 161 + yHeight);//元
                e.Graphics.DrawString(DaXie2(a2, 8), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 588 + xWidth, 161 + yHeight);//角
                e.Graphics.DrawString(DaXie2(a2, 9), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 608 + xWidth, 161 + yHeight);//分
            }
            if (a[8] != "" && a[8] != null)
            {
                e.Graphics.DrawString(a[8], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 10 + xWidth, 194 + yHeight);//收款项目3
                e.Graphics.DrawString(a[9], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 300 + xWidth, 194 + yHeight);//收款单价3
                e.Graphics.DrawString(a[10], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 390 + xWidth, 194 + yHeight);//收款数量3
                double a3 = Convert.ToDouble(a[9]) * Convert.ToDouble(a[10]);
                e.Graphics.DrawString(DaXie2(a3, 0), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 448 + xWidth, 194 + yHeight);//百万
                e.Graphics.DrawString(DaXie2(a3, 1), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 468 + xWidth, 194 + yHeight);//十万
                e.Graphics.DrawString(DaXie2(a3, 2), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 488 + xWidth, 194 + yHeight);//万
                e.Graphics.DrawString(DaXie2(a3, 3), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 508 + xWidth, 194 + yHeight);//千
                e.Graphics.DrawString(DaXie2(a3, 4), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 528 + xWidth, 194 + yHeight);//百
                e.Graphics.DrawString(DaXie2(a3, 5), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 548 + xWidth, 194 + yHeight);//十
                e.Graphics.DrawString(DaXie2(a3, 6), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 568 + xWidth, 194 + yHeight);//元
                e.Graphics.DrawString(DaXie2(a3, 8), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 588 + xWidth, 194 + yHeight);//角
                e.Graphics.DrawString(DaXie2(a3, 9), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 608 + xWidth, 194 + yHeight);//分
            }

            e.Graphics.DrawString(a[11], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 155 + xWidth, 230 + yHeight);//合计金额（小写）
            double a4 = Convert.ToDouble(a[11]);
            e.Graphics.DrawString(DaXie2(a4, 0), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 448 + xWidth, 230 + yHeight);//百万
            e.Graphics.DrawString(DaXie2(a4, 1), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 468 + xWidth, 230 + yHeight);//十万
            e.Graphics.DrawString(DaXie2(a4, 2), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 488 + xWidth, 230 + yHeight);//万
            e.Graphics.DrawString(DaXie2(a4, 3), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 508 + xWidth, 230 + yHeight);//千
            e.Graphics.DrawString(DaXie2(a4, 4), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 528 + xWidth, 230 + yHeight);//百
            e.Graphics.DrawString(DaXie2(a4, 5), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 548 + xWidth, 230 + yHeight);//十
            e.Graphics.DrawString(DaXie2(a4, 6), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 568 + xWidth, 230 + yHeight);//元
            e.Graphics.DrawString(DaXie2(a4, 8), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 588 + xWidth, 230 + yHeight);//角
            e.Graphics.DrawString(DaXie2(a4, 9), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 608 + xWidth, 230 + yHeight);//分


            e.Graphics.DrawString(DaXie(a4, 0), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 168 + xWidth, 260 + yHeight);//百万
            e.Graphics.DrawString(DaXie(a4, 1), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 218 + xWidth, 260 + yHeight);//十万
            e.Graphics.DrawString(DaXie(a4, 2), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 268 + xWidth, 260 + yHeight);//万
            e.Graphics.DrawString(DaXie(a4, 3), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 318 + xWidth, 260 + yHeight);//千
            e.Graphics.DrawString(DaXie(a4, 4), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 368 + xWidth, 260 + yHeight);//百
            e.Graphics.DrawString(DaXie(a4, 5), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 418 + xWidth, 260 + yHeight);//十
            e.Graphics.DrawString(DaXie(a4, 6), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 468 + xWidth, 260 + yHeight);//元
            e.Graphics.DrawString(DaXie(a4, 8), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 518 + xWidth, 260 + yHeight);//角
            e.Graphics.DrawString(DaXie(a4, 9), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 568 + xWidth, 260 + yHeight);//分

            e.Graphics.DrawString(a[12], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 160 + xWidth, 295 + yHeight);//备注

            e.Graphics.DrawString(a[13], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 92 + xWidth, 323 + yHeight);//收款单位
            e.Graphics.DrawString(a[14], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 237 + xWidth, 323 + yHeight);//复核
            e.Graphics.DrawString(a[15], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 393 + xWidth, 323 + yHeight);//收款人
            #region//不需使用信息
            ////信息的名称   
            //e.Graphics.DrawLine(Pens.Black, 8, 30, 480, 30);
            //e.Graphics.DrawString("入库单编号", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 9, 35);
            //e.Graphics.DrawString("商品名称", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 160, 35);
            //e.Graphics.DrawString("数量", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 260, 35);
            //e.Graphics.DrawString("单价", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 330, 35);
            //e.Graphics.DrawString("总金额", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 400, 35);
            //e.Graphics.DrawLine(Pens.Black, 8, 50, 480, 50);
            ////产品信息   
            //e.Graphics.DrawString("R2011-01-2016:06:35", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 9, 55);
            //e.Graphics.DrawString("联想A460", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 160, 55);
            //e.Graphics.DrawString("100", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 260, 55);
            //e.Graphics.DrawString("200.00", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 330, 55);
            //e.Graphics.DrawString("20000.00", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 400, 55);


            //e.Graphics.DrawLine(Pens.Black, 8, 200, 480, 200);
            //e.Graphics.DrawString("地址：新乡市河南科技学院信息工程学院", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 9, 210);
            //e.Graphics.DrawString("经办人:任忌", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 220, 210);
            //e.Graphics.DrawString("服务热线:15083128577", new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 320, 210);
            //e.Graphics.DrawString("入库时间:" + DateTime.Now.ToString(), new Font(new FontFamily("黑体"), 8), System.Drawing.Brushes.Black, 9, 230);
            #endregion
            #endregion
          
        }
        private string DaXie(double value,int wei)//小写转大写函数
        {
            string ab = value.ToString("0000000.00");
            string a = "零";
            if(ab.Substring(wei,1)!="0")
            {
                Char bbx =Convert.ToChar(ab.Substring(wei, 1));
                a = getint(bbx);//获取大写值
            }
            return a;
        }
        /// <summary>
        /// 单个数字转为大写
        /// </summary>
        /// <param name="c">小写阿拉伯数字 0---9</param>
        /// <returns>大写数字</returns>
        private string getint(Char c)
        {
            string str = "";
            switch (c)
            {
                case '0':
                    str = "零";
                    break;
                case '1':
                    str = "壹";
                    break;
                case '2':
                    str = "贰";
                    break;
                case '3':
                    str = "叁";
                    break;
                case '4':
                    str = "肆";
                    break;
                case '5':
                    str = "伍";
                    break;
                case '6':
                    str = "陆";
                    break;
                case '7':
                    str = "柒";
                    break;
                case '8':
                    str = "拐";
                    break;
                case '9':
                    str = "玖";
                    break;
            }
            return str;
        }

        private string DaXie2(double value, int wei)//获取每个数值
        {
             string   valuestr = value.ToString("#######.00");//值前一个符号清空不写
            
            // int i = value.ToString().IndexOf(".");
            int b;
            //if (i > 0)
            //{
            //    b = valuestr.ToString().Length - 3;//整数位长度
            //}
            //else
            //{
            //    b = valuestr.ToString().Length;//整数位长度
            //}
            b = valuestr.ToString().Length - 3;//整数位长度
            string ab = value.ToString("0000000.00");//值前一个符号清空不写
            string  a= "0";
            if (ab.Length - b - 3 >= wei)
            {
                a = "";
            }
            //if (ab.Length - b - 3 -1== wei)//数字前一位用金钱符号
            //{
            //    //a = "￥";
            //    a = "";
            //}
            //if (wei == i + 1)//数字前一位用金钱符号
            //{
            //    a = "￥";
            //}
            
            if (ab.Substring(wei, 1) != "0")
            {
                Char bbx = Convert.ToChar(ab.Substring(wei, 1));
                a = getint2(bbx);//获取大写值
            }
            //a = wu.set_null(a);
            return a;
        }
        /// <summary>
        /// 单个数字转为大写
        /// </summary>
        /// <param name="c">小写阿拉伯数字 0---9</param>
        /// <returns>大写数字</returns>
        private string getint2(Char c)
        {
            string str = "";
            switch (c)
            {
                case '0':
                    str = "0";
                    break;
                case '1':
                    str = "1";
                    break;
                case '2':
                    str = "2";
                    break;
                case '3':
                    str = "3";
                    break;
                case '4':
                    str = "4";
                    break;
                case '5':
                    str = "5";
                    break;
                case '6':
                    str = "6";
                    break;
                case '7':
                    str = "7";
                    break;
                case '8':
                    str = "8";
                    break;
                case '9':
                    str = "9";
                    break;
            }
            return str;
        }
       private void Form1_Load(object sender, EventArgs e)
        {
            if (l.getFlag() == 1)
                this.Dispose();

            string select = "select UserName from Users where Account='"+wu.account+"'";
            string[] a = wu.get_Value(select);
            textBox16.Text = a[0];

            if (wu.IsValidFloat(textBox3.Text, 0, 2) == false)
            {
                MessageBox.Show("第一行单价格式错误！", "ERROR");
                return;
            }
            if (textBox4.Text == "" || wu.IsValidInt(textBox4.Text) == false)
            {
                MessageBox.Show("第一行数量格式错误！", "ERROR");
                return;
            }
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                float DanJia1 = Convert.ToSingle(textBox3.Text);
                int ShuLiang1 = Convert.ToInt32(textBox4.Text);
                float JE = DanJia1 * ShuLiang1;
                textBox5.Text = Convert.ToString(JE);
            }
            heji();

            string selectX = "select zhiheight,xwidth,yheight from MoRen";
            string[] ax = wu.get_Value(selectX);
            textBox21.Text = ax[0];
            textBox22.Text = ax[1];
            textBox23.Text = ax[2];

        }




     private void Form1_KeyDown(object sender, KeyEventArgs e)
     {
         if (e.KeyCode == Keys.Enter)
         {
             //this.SelectNextControl(this.ActiveControl,true, true, true, true);
             //前台的KeyPreview 需改成 true 才能生效
             SendKeys.Send("{Tab}");  //向活动应用程序发送击键 注意格式：Send("{Tab}");中的{}
         }

     }

     private void textBox4_TextChanged(object sender, EventArgs e)
     {
         if (wu.IsValidFloat(textBox3.Text, 0, 2) == false)
         {
             MessageBox.Show("第一行单价格式错误！", "ERROR");
             return;
         }
         if (textBox4.Text == "" || wu.IsValidInt(textBox4.Text) == false)
         {
             MessageBox.Show("第一行数量格式错误！", "ERROR");
             return;
         }
         if (textBox3.Text != "" && textBox4.Text != "")
         {
             float DanJia1 = Convert.ToSingle(textBox3.Text);
             int ShuLiang1 = Convert.ToInt32(textBox4.Text);
             float JE = DanJia1 * ShuLiang1;
             textBox5.Text = Convert.ToString(JE);
         }
         heji();
     }

     private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
     {
         Pwd pd = new Pwd();
         pd.Show();
     }

     private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
     {
         this.Dispose();
         this.Close();
     }

     private void 导出ExcelToolStripMenuItem_Click(object sender, EventArgs e)
     {
         string select = "select FuKanRen,FuKanShiJian,XiangMu1,DanJia1,ShuLiang1,XiangMu2,DanJia2,ShuLiang2,XiangMu3"+
             ",DanJia3,ShuLiang3,HeJi,BeiZhu,ShouKanDanWei,FuHe,ShouKanRen,ZhuangTai,FaPiaoHao"+
             " from FaPiao";
         wu.dbGridView(select,dataGridView1);
         DataGridviewShowToExcel(dataGridView1,true);
     }



     #region DataGridView数据显示到Excel
     /// <summary> 
     /// 打开Excel并将DataGridView控件中数据导出到Excel
     /// </summary> 
     /// <param name="dgv">DataGridView对象 </param> 
     /// <param name="isShowExcle">是否显示Excel界面 </param> 
     /// <remarks>
     /// add com "Microsoft Excel 11.0 Object Library"
     /// using Excel=Microsoft.Office.Interop.Excel;
     /// </remarks>
     /// <returns> </returns> 
     public bool DataGridviewShowToExcel(DataGridView dgv, bool isShowExcle)
     {
         if (dgv.Rows.Count == 0)
             return false;
         //建立Excel对象 
         Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
         excel.Application.Workbooks.Add(true);
         excel.Visible = isShowExcle;
         //生成字段名称 
         for (int i = 0; i < dgv.ColumnCount; i++)
         {
             excel.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
         }
         //填充数据 
         for (int i = 0; i < dgv.RowCount - 1; i++)
         {
             for (int j = 0; j < dgv.ColumnCount; j++)
             {
                 if (dgv[j, i].ValueType == typeof(string))
                 {
                     excel.Cells[i + 2, j + 1] = "'" + dgv[j, i].Value.ToString();
                 }
                 else
                 {
                     excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                 }
             }
         }
         return true;
     }
     #endregion 

     private void button3_Click(object sender, EventArgs e)
     {
         textBox2.Text = "";
         textBox3.Text = "";
         textBox4.Text = "";
         textBox5.Text = "";
         textBox6.Text = "";
         textBox7.Text = "";
         textBox8.Text = "";
         textBox9.Text = "";
         textBox10.Text = "";
         textBox11.Text = "";
         textBox12.Text = "";
         textBox13.Text = "";
         textBox17.Text = "";
         textBox18.Text = "";
         textBox19.Text = "";
         textBox15.Text = "";

         string FuKanRen = textBox1.Text;
         string FuKanShiJian = dateTimePicker1.Value.ToShortDateString();
         string FaPiaoHao = textBox20.Text;

         string select = "select FuKanRen,FuKanShiJian,XiangMu1,DanJia1,ShuLiang1,XiangMu2,DanJia2," +
                         "ShuLiang2,XiangMu3,DanJia3,ShuLiang3,HeJi,BeiZhu,ShouKanDanWei," +
                         "FuHe,ShouKanRen,Ctime,SysAccount,ZhuangTai,Ctime2,SysAccount2,FaPiaoHao " +
                         "from FaPiao where id <> 0";
         if (textBox1.Text!="")
         {
             select += " and FuKanRen = '" + FuKanRen + "'";
         }
         if (textBox20.Text!="")
         {
             select += " and FaPiaoHao = '" + FaPiaoHao + "'";
         }
         textBox1.Text = wu.get_Value(select)[0];
         dateTimePicker1.Text = wu.get_Value(select)[1];
         textBox2.Text = wu.get_Value(select)[2];
         textBox3.Text =wu.set_null(wu.get_Value(select)[3]);
         textBox4.Text =wu.set_null(wu.get_Value(select)[4]);

         textBox6.Text = wu.get_Value(select)[5];
         textBox7.Text =wu.set_null(wu.get_Value(select)[6]);
         textBox8.Text =wu.set_null(wu.get_Value(select)[7]);

         textBox10.Text = wu.get_Value(select)[8];
         textBox11.Text =wu.set_null(wu.get_Value(select)[9]);
         textBox12.Text = wu.set_null(wu.get_Value(select)[10]);

         textBox17.Text = wu.get_Value(select)[11];
         textBox18.Text = MoneyToUpper(textBox17.Text);

         textBox19.Text = wu.get_Value(select)[12];
         textBox14.Text = wu.get_Value(select)[13];
         textBox15.Text = wu.get_Value(select)[14];
         textBox16.Text = wu.get_Value(select)[15];
         comboBox1.Text = wu.get_Value(select)[18];
         label10.Text = wu.get_Value(select)[21];
     }

     private void button2_Click(object sender, EventArgs e)
     {
         string update = "update FaPiao set ZhuangTai = '"+comboBox1.Text+"' where FaPiaoHao = '" + label10.Text + "'";
         if (wu.ExecSQL(update) == true)
         {
             MessageBox.Show("修改成功！", "ERROR");
             return;
             //#region//保存代码
             //if (textBox1.Text == "")
             //{
             //    MessageBox.Show("付款单位（人）不能为空！", "ERROR");
             //    return;
             //}
             //if (textBox20.Text == "")
             //{
             //    MessageBox.Show("发票号不能为空！", "ERROR");
             //    return;
             //}
             //if (textBox2.Text == "")
             //{
             //    MessageBox.Show("第一行收款项目不能为空！", "ERROR");
             //    return;
             //}
             //if (textBox3.Text == "" || wu.IsValidFloat(textBox3.Text) == false)
             //{
             //    MessageBox.Show("第一行单价格式错误！", "ERROR");
             //    return;
             //}
             //if (textBox4.Text == "" || wu.IsValidInt(textBox4.Text) == false)
             //{
             //    MessageBox.Show("第一行数量格式错误！", "ERROR");
             //    return;
             //}
             //if (wu.IsValidFloat(textBox7.Text) == false)
             //{
             //    MessageBox.Show("第二行单价格式错误！", "ERROR");
             //    return;
             //}
             //if (wu.IsValidInt(textBox8.Text) == false)
             //{
             //    MessageBox.Show("第二行数量格式错误！", "ERROR");
             //    return;
             //}
             //if (wu.IsValidFloat(textBox11.Text) == false)
             //{
             //    MessageBox.Show("第三行单价格式错误！", "ERROR");
             //    return;
             //}
             //if (wu.IsValidInt(textBox12.Text) == false)
             //{
             //    MessageBox.Show("第三行数量格式错误！", "ERROR");
             //    return;
             //}

             //string FuKanRen = textBox1.Text;
             //DateTime FuKanShiJian = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
             //string FaPiaoHao = textBox20.Text;

             ////第一行
             //string XiangMu1 = textBox2.Text;
             //float DanJia1 = 0.00F;
             //int ShuLiang1 = 0;
             //float JE1 = 0.00F;
             //if (textBox3.Text != "" && textBox4.Text != "")
             //{
             //    DanJia1 = Convert.ToSingle(textBox3.Text);
             //    ShuLiang1 = Convert.ToInt32(textBox4.Text);
             //    JE1 = DanJia1 * ShuLiang1;
             //}

             ////第二行
             //string XiangMu2 = textBox6.Text;
             //float DanJia2 = 0.00F;
             //int ShuLiang2 = 0;
             //float JE2 = 0.00F;
             //if (textBox7.Text != "" && textBox8.Text != "")
             //{
             //    DanJia2 = Convert.ToSingle(textBox7.Text);
             //    ShuLiang2 = Convert.ToInt32(textBox8.Text);
             //    JE2 = DanJia2 * ShuLiang2;
             //}

             ////第三行
             //string XiangMu3 = textBox10.Text;
             //float DanJia3 = 0.00F;
             //int ShuLiang3 = 0;
             //float JE3 = 0.00F;
             //if (textBox11.Text != "" && textBox12.Text != "")
             //{
             //    DanJia3 = Convert.ToSingle(textBox11.Text);
             //    ShuLiang3 = Convert.ToInt32(textBox12.Text);
             //    JE3 = DanJia3 * ShuLiang3;
             //}

             //float HeJi = JE1 + JE2 + JE3;
             //textBox17.Text = Convert.ToString(HeJi);
             //textBox18.Text = MoneyToUpper(textBox17.Text);
             //string BeiZhu = textBox19.Text;
             //string ShouKanDanWei = textBox14.Text;
             //string FuHe = textBox15.Text;
             //string ShouKanRen = textBox16.Text;
             //DateTime Ctime = DateTime.Now;
             //string SysAccount = wu.account;
             //DateTime Ctime2 = DateTime.Now;
             //string SysAccount2 = "";
             //comboBox1.Text = "已打印";
             //string ZhuangTai = comboBox1.Text;
             //label10.Text = textBox20.Text;

             ////string insert = "insert into FaPiao (" +
             ////                "FuKanRen,FuKanShiJian,XiangMu1,DanJia1,ShuLiang1,XiangMu2,DanJia2," +
             ////                "ShuLiang2,XiangMu3,DanJia3,ShuLiang3,HeJi,BeiZhu,ShouKanDanWei," +
             ////                "FuHe,ShouKanRen,Ctime,SysAccount,ZhuangTai,Ctime2,SysAccount2,FaPiaoHao" +
             ////                ") values ('" +
             ////                FuKanRen + "','" + FuKanShiJian + "','" + XiangMu1 + "','" + DanJia1 + "','" +
             ////                ShuLiang1 + "','" + XiangMu2 + "','" + DanJia2 + "','" + ShuLiang2 + "','" +
             ////                XiangMu3 + "','" + DanJia3 + "','" + ShuLiang3 + "','" + HeJi + "','" +
             ////                BeiZhu + "','" + ShouKanDanWei + "','" + FuHe + "','" + ShouKanRen + "','" +
             ////                Ctime + "','" + SysAccount + "','" + ZhuangTai + "','" + Ctime2 + "','" +
             ////                SysAccount2 + "','" + FaPiaoHao + "')";

             ////if (wu.ExecSQL(insert) == true)
             ////{
             ////    MessageBox.Show("保存成功", "OK");
             ////    return;
             ////}
             ////else
             ////{
             ////    MessageBox.Show("系统错误，请联系计算机管理科！", "ERROR");
             ////    return;
             ////}

             //#endregion


         }
         else
         {
             MessageBox.Show("系统错误，请联系计算机管理科！", "ERROR");
             return;
         }
     }

     private void heji()
     {
         //第一行
         string XiangMu1 = textBox2.Text;
         float DanJia1 = 0.00F;
         int ShuLiang1 = 0;
         float JE1 = 0.00F;
         if (textBox3.Text != "" && textBox4.Text != "")
         {
             DanJia1 = Convert.ToSingle(textBox3.Text);
             ShuLiang1 = Convert.ToInt32(textBox4.Text);
             JE1 = DanJia1 * ShuLiang1;
         }

         //第二行
         string XiangMu2 = textBox6.Text;
         float DanJia2 = 0.00F;
         int ShuLiang2 = 0;
         float JE2 = 0.00F;
         if (textBox7.Text != "" && textBox8.Text != "")
         {
             DanJia2 = Convert.ToSingle(textBox7.Text);
             ShuLiang2 = Convert.ToInt32(textBox8.Text);
             JE2 = DanJia2 * ShuLiang2;
         }

         //第三行
         string XiangMu3 = textBox10.Text;
         float DanJia3 = 0.00F;
         int ShuLiang3 = 0;
         float JE3 = 0.00F;
         if (textBox11.Text != "" && textBox12.Text != "")
         {
             DanJia3 = Convert.ToSingle(textBox11.Text);
             ShuLiang3 = Convert.ToInt32(textBox12.Text);
             JE3 = DanJia3 * ShuLiang3;
         }

         float HeJi = JE1 + JE2 + JE3;
         textBox17.Text = Convert.ToString(HeJi);
         textBox18.Text = MoneyToUpper(textBox17.Text);
     }

     private string BianHao(string value)//发票自增编号
     {
         string a = "";
         string b = value.Substring(0,2);//获取前两个英文字母
         string i = value.Replace(b,"");//过滤英文字母
         int x = 0;
         x = Convert.ToInt32(i);//转换为数字，清除无效前位0
         x = x + 1;//每次增加1
         if (x.ToString().Length == 1)
         {
             a = "0000000" + x.ToString();
         }
         if (x.ToString().Length == 2)
         {
             a = "000000" + x.ToString();
         }
         if (x.ToString().Length == 3)
         {
             a = "00000" + x.ToString();
         }
         if (x.ToString().Length == 4)
         {
             a = "0000" + x.ToString();
         }
         if (x.ToString().Length == 5)
         {
             a = "000" + x.ToString();
         }
         if (x.ToString().Length == 6)
         {
             a = "00" + x.ToString();
         }
         if (x.ToString().Length == 7)
         {
             a = "0" + x.ToString();
         }
         if (x.ToString().Length == 8)
         {
             a = x.ToString();
         }
         return b + a;
     }

     //数字小写==>大写
     public static string MoneyToUpper(string strAmount)
     {
         if (strAmount != "" && strAmount != null)
         {
             string functionReturnValue = null;
             bool IsNegative = false; // 是否是负数
             if (strAmount.Trim().Substring(0, 1) == "-")
             {
                 // 是负数则先转为正数
                 strAmount = strAmount.Trim().Remove(0, 1);
                 IsNegative = true;
             }
             string strLower = null;
             string strUpart = null;
             string strUpper = null;
             int iTemp = 0;
             // 保留两位小数 123.489→123.49　　123.4→123.4
             strAmount = Math.Round(double.Parse(strAmount), 2).ToString();
             if (strAmount.IndexOf(".") > 0)
             {
                 if (strAmount.IndexOf(".") == strAmount.Length - 2)
                 {
                     strAmount = strAmount + "0";
                 }
             }
             else
             {
                 strAmount = strAmount + ".00";
             }
             strLower = strAmount;
             iTemp = 1;
             strUpper = "";
             while (iTemp <= strLower.Length)
             {
                 switch (strLower.Substring(strLower.Length - iTemp, 1))
                 {
                     case ".":
                         strUpart = "圆";
                         break;
                     case "0":
                         strUpart = "零";
                         break;
                     case "1":
                         strUpart = "壹";
                         break;
                     case "2":
                         strUpart = "贰";
                         break;
                     case "3":
                         strUpart = "叁";
                         break;
                     case "4":
                         strUpart = "肆";
                         break;
                     case "5":
                         strUpart = "伍";
                         break;
                     case "6":
                         strUpart = "陆";
                         break;
                     case "7":
                         strUpart = "柒";
                         break;
                     case "8":
                         strUpart = "捌";
                         break;
                     case "9":
                         strUpart = "玖";
                         break;
                 }

                 switch (iTemp)
                 {
                     case 1:
                         strUpart = strUpart + "分";
                         break;
                     case 2:
                         strUpart = strUpart + "角";
                         break;
                     case 3:
                         strUpart = strUpart + "";
                         break;
                     case 4:
                         strUpart = strUpart + "";
                         break;
                     case 5:
                         strUpart = strUpart + "拾";
                         break;
                     case 6:
                         strUpart = strUpart + "佰";
                         break;
                     case 7:
                         strUpart = strUpart + "仟";
                         break;
                     case 8:
                         strUpart = strUpart + "万";
                         break;
                     case 9:
                         strUpart = strUpart + "拾";
                         break;
                     case 10:
                         strUpart = strUpart + "佰";
                         break;
                     case 11:
                         strUpart = strUpart + "仟";
                         break;
                     case 12:
                         strUpart = strUpart + "亿";
                         break;
                     case 13:
                         strUpart = strUpart + "拾";
                         break;
                     case 14:
                         strUpart = strUpart + "佰";
                         break;
                     case 15:
                         strUpart = strUpart + "仟";
                         break;
                     case 16:
                         strUpart = strUpart + "万";
                         break;
                     default:
                         strUpart = strUpart + "";
                         break;
                 }

                 strUpper = strUpart + strUpper;
                 iTemp = iTemp + 1;
             }

             strUpper = strUpper.Replace("零拾", "零");
             strUpper = strUpper.Replace("零佰", "零");
             strUpper = strUpper.Replace("零仟", "零");
             strUpper = strUpper.Replace("零零零", "零");
             strUpper = strUpper.Replace("零零", "零");
             strUpper = strUpper.Replace("零角零分", "整");
             strUpper = strUpper.Replace("零分", "整");
             strUpper = strUpper.Replace("零角", "零");
             strUpper = strUpper.Replace("零亿零万零圆", "亿圆");
             strUpper = strUpper.Replace("亿零万零圆", "亿圆");
             strUpper = strUpper.Replace("零亿零万", "亿");
             strUpper = strUpper.Replace("零万零圆", "万圆");
             strUpper = strUpper.Replace("零亿", "亿");
             strUpper = strUpper.Replace("零万", "万");
             strUpper = strUpper.Replace("零圆", "圆");
             strUpper = strUpper.Replace("零零", "零");

             // 对壹圆以下的金额的处理
             if (strUpper.Substring(0, 1) == "圆")
             {
                 strUpper = strUpper.Substring(1, strUpper.Length - 1);
             }
             if (strUpper.Substring(0, 1) == "零")
             {
                 strUpper = strUpper.Substring(1, strUpper.Length - 1);
             }
             if (strUpper.Substring(0, 1) == "角")
             {
                 strUpper = strUpper.Substring(1, strUpper.Length - 1);
             }
             if (strUpper.Substring(0, 1) == "分")
             {
                 strUpper = strUpper.Substring(1, strUpper.Length - 1);
             }
             if (strUpper.Substring(0, 1) == "整")
             {
                 strUpper = "零圆整";
             }
             functionReturnValue = strUpper;

             if (IsNegative == true)
             {
                 return "负" + functionReturnValue;
             }
             else
             {
                 return functionReturnValue;
             }
         }
         else
         {
             return "";
         }
     }

     private void textBox8_TextChanged(object sender, EventArgs e)
     {
         if (wu.IsValidFloat(textBox7.Text, 0, 2) == false)
         {
             MessageBox.Show("第二行单价格式错误！", "ERROR");
             return;
         }
         if (wu.IsValidInt(textBox8.Text) == false)
         {
             MessageBox.Show("第二行数量格式错误！", "ERROR");
             return;
         }
         if (textBox7.Text != "" && textBox8.Text != "")
         {
             float DanJia1 = Convert.ToSingle(textBox7.Text);
             int ShuLiang1 = Convert.ToInt32(textBox8.Text);
             float JE = DanJia1 * ShuLiang1;
             textBox9.Text = Convert.ToString(JE);
         }
         heji();
     }

     private void textBox12_TextChanged(object sender, EventArgs e)
     {
         if (wu.IsValidFloat(textBox11.Text, 0, 2) == false)
         {
             MessageBox.Show("第三行单价格式错误！", "ERROR");
             return;
         }
         if (wu.IsValidInt(textBox12.Text) == false)
         {
             MessageBox.Show("第三行数量格式错误！", "ERROR");
             return;
         }
         if (textBox11.Text != "" && textBox12.Text != "")
         {
             float DanJia1 = Convert.ToSingle(textBox11.Text);
             int ShuLiang1 = Convert.ToInt32(textBox12.Text);
             float JE = DanJia1 * ShuLiang1;
             textBox13.Text = Convert.ToString(JE);
         }
         heji();
     }

     private void textBox3_TextChanged(object sender, EventArgs e)
     {
         if (textBox3.Text == "" || wu.IsValidFloat(textBox3.Text, 0, 2) == false)
         {
             MessageBox.Show("第一行单价格式错误！", "ERROR");
             return;
         }
         if (wu.IsValidInt(textBox4.Text) == false)
         {
             MessageBox.Show("第一行数量格式错误！", "ERROR");
             return;
         }
         if (textBox3.Text != "" && textBox4.Text != "")
         {
             float DanJia1 = Convert.ToSingle(textBox3.Text);
             int ShuLiang1 = Convert.ToInt32(textBox4.Text);
             float JE = DanJia1 * ShuLiang1;
             textBox5.Text = Convert.ToString(JE);
         }
         heji();
     }

     private void textBox7_TextChanged(object sender, EventArgs e)
     {
         if (wu.IsValidFloat(textBox7.Text, 0, 2) == false)
         {
             MessageBox.Show("第二行单价格式错误！", "ERROR");
             return;
         }
         if (wu.IsValidInt(textBox8.Text) == false)
         {
             MessageBox.Show("第二行数量格式错误！", "ERROR");
             return;
         }
         if (textBox7.Text != "" && textBox8.Text != "")
         {
             float DanJia1 = Convert.ToSingle(textBox7.Text);
             int ShuLiang1 = Convert.ToInt32(textBox8.Text);
             float JE = DanJia1 * ShuLiang1;
             textBox9.Text = Convert.ToString(JE);
         }
         heji();
     }

     private void textBox11_TextChanged(object sender, EventArgs e)
     {
         if (wu.IsValidFloat(textBox11.Text, 0, 2) == false)
         {
             MessageBox.Show("第三行单价格式错误！", "ERROR");
             return;
         }
         if (wu.IsValidInt(textBox12.Text) == false)
         {
             MessageBox.Show("第三行数量格式错误！", "ERROR");
             return;
         }
         if (textBox11.Text != "" && textBox12.Text != "")
         {
             float DanJia1 = Convert.ToSingle(textBox11.Text);
             int ShuLiang1 = Convert.ToInt32(textBox12.Text);
             float JE = DanJia1 * ShuLiang1;
             textBox13.Text = Convert.ToString(JE);
         }
         heji();
     }

     private void button4_Click(object sender, EventArgs e)
     {
         if (textBox21.Text == "" || wu.IsValidInt2(textBox21.Text) == false)
         {
             MessageBox.Show("纸张高度格式错误！", "ERROR");
             return;
         }
         if (textBox22.Text == "" || wu.IsValidInt2(textBox22.Text) == false)
         {
             MessageBox.Show("内容横向度！", "ERROR");
             return;
         }
         if (textBox23.Text == "" || wu.IsValidInt2(textBox23.Text) == false)
         {
             MessageBox.Show("内容纵向度！", "ERROR");
             return;
         }
         string update = "update MoRen set zhiheight='" + textBox21.Text + "',xwidth='" + textBox22.Text + "',yheight='"+textBox23.Text+"'";
         if (wu.ExecSQL(update) == true)
         {
             MessageBox.Show("设置成功", "OK");
             return;
         }
         else
         {
             MessageBox.Show("设置失败！请确认参数微调是否有输入非法字符串", "ERROR");
             return;
         }
     }

     private void 发票操作ToolStripMenuItem_Click(object sender, EventArgs e)
     {
         Form2 pd = new Form2();
         pd.Show();
     }


    







    }
}
