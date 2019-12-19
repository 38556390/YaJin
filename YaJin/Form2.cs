using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace YaJin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hejishu()
        {
            double HeJi = TextToFloat(YiJinEr1) + TextToFloat(YiJinEr2) + TextToFloat(YiJinEr3) + TextToFloat(ZhenJinEr1) + TextToFloat(ZhenJinEr2) +
                TextToFloat(ZhenJinEr3) + TextToFloat(ZhiJinEr1) + TextToFloat(ZhiJinEr2) + TextToFloat(ZhiJinEr3) + TextToFloat(QiJinEr1) + TextToFloat(QiJinEr2)+
                TextToFloat(QiJinEr3);
            HeJi1.Text = Convert.ToString(HeJi);
            textBox18.Text = MoneyToUpper(HeJi1.Text);

            double yujiaostr = TextToFloat(YuJiaoKuan);//预交款

            if (HeJi - yujiaostr > 0)
            {
                TuiKuan.Text = "";
                BuShou.Text = Convert.ToString(HeJi - yujiaostr);
            }
            if (HeJi - yujiaostr < 0)
            {
                BuShou.Text = "";
                TuiKuan.Text = Convert.ToString(yujiaostr - HeJi);
            }
            if (HeJi - yujiaostr == 0)
            {
                TuiKuan.Text = "";
                BuShou.Text = "";
            }
        }
        private double TextToFloat(TextBox txt)
        {
            double a = 0;
            if(txt.Text!="")
            {
                a =Convert.ToDouble(txt.Text);
            }
            return a;
        }

        private string BianHao(string value)//发票自增编号
        {
            string a = "";
            string b = value.Substring(0, 2);//获取前两个英文字母
            string i = value.Replace(b, "");//过滤英文字母
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

        private void button1_Click(object sender, EventArgs e)
        {
            #region//保存代码



            if (XingMing.Text == "")
            {
                MessageBox.Show("姓名不能为空！", "ERROR");
                return;
            }
            if (FaPiaoHao1.Text == "")
            {
                MessageBox.Show("发票号不能为空！", "ERROR");
                return;
            }
            if (FaPiaoHao1.Text.Length <3)
            {
                MessageBox.Show("发票号至少需填三位数！", "ERROR");
                return;
            }
            string b = FaPiaoHao1.Text.Substring(0, 2);//获取前两个英文字母
            string i = FaPiaoHao1.Text.Replace(b, "");//过滤英文字母
            int x = 0;
            try
            {
                x = Convert.ToInt32(i);//转换为数字，清除无效前位0
            }
            catch
            {
                MessageBox.Show("操作失败，发票号第三位起需是数字！", "ERROR");
                return;
            }

            if (YiJinEr1.Text != "" && wu.IsValidFloat(YiJinEr1.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (YiJinEr2.Text != "" && wu.IsValidFloat(YiJinEr2.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (YiJinEr3.Text != "" && wu.IsValidFloat(YiJinEr3.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (ZhenJinEr1.Text != "" && wu.IsValidFloat(ZhenJinEr1.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (ZhenJinEr2.Text != "" && wu.IsValidFloat(ZhenJinEr2.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (ZhenJinEr3.Text != "" && wu.IsValidFloat(ZhenJinEr3.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (ZhiJinEr1.Text != "" && wu.IsValidFloat(ZhiJinEr1.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (ZhiJinEr2.Text != "" && wu.IsValidFloat(ZhiJinEr2.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (ZhiJinEr3.Text != "" && wu.IsValidFloat(ZhiJinEr3.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (QiJinEr1.Text != "" && wu.IsValidFloat(QiJinEr1.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (QiJinEr2.Text != "" && wu.IsValidFloat(QiJinEr2.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }
            if (QiJinEr3.Text != "" && wu.IsValidFloat(QiJinEr3.Text) == false)
            {
                MessageBox.Show("金额格式错误！", "ERROR");
                return;
            }

            if (FaPiaoHao1.Text == "")
            {
                MessageBox.Show("发票号不能为空！", "ERROR");
                return;
            }

            string select = "select id from FaPiao2 where FaPiaoHao='" + FaPiaoHao1.Text + "'";
            if (wu.SelectSQL(select) == true)
            {
                MessageBox.Show("操作失败，已存在此发票号！", "ERROR");
                return;
            }

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

            string FuKanRen = XingMing.Text;
            DateTime FuKanShiJian = Convert.ToDateTime(FuKanShiJian1.Value.ToShortDateString());//缴费日期
            string FaPiaoHao = FaPiaoHao1.Text;
            string zhuCtime = "";//住院日期
            string chuCtime = "";//出院日期
            if (Convert.ToString(ZhuYuanRiQi.Text) != " " && Convert.ToString(ZhuYuanRiQi.Text)!=null)
            {
                zhuCtime = ZhuYuanRiQi.Value.ToShortDateString();
            }
            if (Convert.ToString(ChuYuanRiQi.Text) != " " && Convert.ToString(ChuYuanRiQi.Text) != null)
            {
                chuCtime = ChuYuanRiQi.Value.ToShortDateString();
            }
            //double HeJi = hejishu();
            //textBox17.Text = Convert.ToString(HeJi);
            //textBox18.Text = MoneyToUpper(textBox17.Text);

            string ShouKanDanWei = ShouKanDanWei1.Text;
            string FuHe = FuHe1.Text;
            string ShouKanRen = ShouKanRen1.Text;
            DateTime Ctime = DateTime.Now;
            string SysAccount = wu.account;
            DateTime Ctime2 = DateTime.Now;
            string SysAccount2 = "";
            comboBox1.Text = "已打印";
            string ZhuangTai = comboBox1.Text;
            label10.Text = FaPiaoHao1.Text;//记录发票号

            float YiJinEr1str = jiner(YiJinEr1);
            float YiJinEr2str = jiner(YiJinEr2);
            float YiJinEr3str = jiner(YiJinEr3);

            float ZhenJinEr1str = jiner(ZhenJinEr1);
            float ZhenJinEr2str = jiner(ZhenJinEr2);
            float ZhenJinEr3str = jiner(ZhenJinEr3);

            float ZhiJinEr1str = jiner(ZhiJinEr1);
            float ZhiJinEr2str = jiner(ZhiJinEr2);
            float ZhiJinEr3str = jiner(ZhiJinEr3);

            float QiJinEr1str = jiner(QiJinEr1);
            float QiJinEr2str = jiner(QiJinEr2);
            float QiJinEr3str = jiner(QiJinEr3);

            float HeJistr = jiner(HeJi1);

            float YuJiaoKuanstr = jiner(YuJiaoKuan);
            float BuShoustr = jiner(BuShou);
            float TuiKuanstr = jiner(TuiKuan);
            float QianFeistr = jiner(QianFei);

            string insert = "insert into FaPiao2 (" +
                            "YeWuHao,SheHuiHao,BingLiHao,ZhuYuan,ZhuYuanHao,YiYuan,FuKanShiJian,XingMing,LeiXing,ZhuYuanRiQi,ChuYuanRiQi," +
                            "XingBie,YiBaoTongChou,GeRenJiaoFei,JieShuanFangShi,YiYaoFei1,YiJinEr1,YiYaoFei2,YiJinEr2,YiYaoFei3,YiJinEr3," +
                            "ZhenChaFei1,ZhenJinEr1,ZhenChaFei2,ZhenJinEr2,ZhenChaFei3,ZhenJinEr3,ZhiLiaoFei1,ZhiJinEr1,ZhiLiaoFei2,ZhiJinEr2," +
                            "ZhiLiaoFei3,ZhiJinEr3,QiTa1,QiJinEr1,QiTa2,QiJinEr2,QiTa3,QiJinEr3,YuJiaoKuan,BuShou,TuiKuan,QianFei,HeJi,ShouKanDanWei," +
                            "FuHe,ShouKanRen,Ctime,SysAccount,ZhuangTai,FaPiaoHao" +
                            "" +
                            ") values ("+
                            "'"+YeWuHao.Text+"','"+SheHuiHao.Text+"','"+BingLiHao.Text+"','"+ZhuYuan.Text+"','"+ZhuYuanHao.Text+"','"+YiYuan.Text+"',"+
                            "'"+FuKanShiJian+"','"+XingMing.Text+"','"+LeiXing.Text+"','"+zhuCtime+"','"+chuCtime+"','"+XingBie.Text+"',"+
                            "'" + YiBaoTongChou.Text + "','" + GeRenJiaoFei.Text + "','" + JieShuanFangShi.Text + "','" + YiYaoFei1.Text + "','" + YiJinEr1str + "'," +
                            "'" + YiYaoFei2.Text + "','" + YiJinEr2str + "','" + YiYaoFei3.Text + "','" + YiJinEr3str + "','" + ZhenChaFei1.Text + "'," +
                            "'" + ZhenJinEr1str + "','" + ZhenChaFei2.Text + "','" + ZhenJinEr2str + "','" + ZhenChaFei3.Text + "','" + ZhenJinEr3str + "'," +
                            "'" + ZhiLiaoFei1.Text + "','" + ZhiJinEr1str + "','" + ZhiLiaoFei2.Text + "','" + ZhiJinEr2str + "','" + ZhiLiaoFei3.Text + "'," +
                            "'" + ZhiJinEr3str + "','" + QiTa1.Text + "','" + QiJinEr1str + "','" + QiTa2.Text + "','" + QiJinEr2str + "','" + QiTa3.Text + "'," +
                            "'" + QiJinEr3str + "','" + YuJiaoKuanstr + "','" + BuShoustr + "','" + TuiKuanstr + "','" + QianFeistr + "','" + HeJistr + "'," +
                            "'" + ShouKanDanWei1.Text + "','" + FuHe1.Text + "','" + ShouKanRen1.Text + "','" + Ctime + "','"+SysAccount+"'," +
                            "'" + ZhuangTai + "','"+FaPiaoHao1.Text+"'" +
                            ""+
                            ""+
                            ""+
                            ""+
                            ")";

            if (wu.ExecSQL(insert) == true)
            {
                MessageBox.Show("保存成功", "OK");
                //return;
            }
            else
            {
                MessageBox.Show("系统错误，请联系计算机管理科！", "ERROR");
                return;
            }

            #endregion

            #region//打印代码
            // printDocument1 为 打印控件   
            //设置打印用的纸张 当设置为Custom的时候，可以自定义纸张的大小，还可以选择A4,A5等常用纸型   
            int aHeight = 400 + Convert.ToInt32(textBox21.Text);//设置打印纸张高
            this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 740, aHeight);//百份之英寸为单位
            this.printDocument1.PrintPage += new PrintPageEventHandler(this.MyPrintDocument_PrintPage);
            //将写好的格式给打印预览控件以便预览   
            printPreviewDialog1.Document = printDocument1;
            //显示打印预览   
            //DialogResult result = printPreviewDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //this.MyPrintDocument.Print();  
            printDocument1.Print();
            #endregion

            FaPiaoHao1.Text = BianHao(FaPiaoHao1.Text);//发票号增1
        }
        /// <summary>   
        /// 打印的格式   
        /// </summary>   
        /// <param name="sender"></param>   
        /// <param name="e"></param>   
        private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*如果需要改变自己 可以在new Font(new FontFamily("黑体"),11）中的“黑体”改成自己要的字体就行了，黑体 后面的数字代表字体的大小 
             System.Drawing.Brushes.Blue , 170, 10 中的 System.Drawing.Brushes.Blue 为颜色，后面的为输出的位置 */
            string select = "select YeWuHao,SheHuiHao,BingLiHao,ZhuYuan,ZhuYuanHao,YiYuan,FuKanShiJian,XingMing,LeiXing,ZhuYuanRiQi,ChuYuanRiQi,XingBie," +
                "YiBaoTongChou,GeRenJiaoFei,JieShuanFangShi,YiYaoFei1,YiJinEr1,YiYaoFei2,YiJinEr2,YiYaoFei3,YiJinEr3,ZhenChaFei1,ZhenJinEr1,ZhenChaFei2," +
                "ZhenJinEr2,ZhenChaFei3,ZhenJinEr3,ZhiLiaoFei1,ZhiJinEr1,ZhiLiaoFei2,ZhiJinEr2,ZhiLiaoFei3,ZhiJinEr3,QiTa1,QiJinEr1,QiTa2,QiJinEr2," +
                "QiTa3,QiJinEr3,YuJiaoKuan,BuShou,TuiKuan,QianFei,HeJi,ShouKanDanWei,FuHe,ShouKanRen,FaPiaoHao" +
                " from FaPiao2" +
                " where XingMing='" + XingMing.Text + "'  and FaPiaoHao='" + FaPiaoHao1.Text + "'";
            //string select = "select FuKanRen,FuKanShiJian,XiangMu1,DanJia1,ShuLiang1,XiangMu2,DanJia2,ShuLiang2,XiangMu3" +
            // ",DanJia3,ShuLiang3,HeJi,BeiZhu,ShouKanDanWei,FuHe,ShouKanRen" +
            // " from FaPiao";

            int xWidth = Convert.ToInt32(textBox22.Text);//横向宽度
            int yHeight = Convert.ToInt32(textBox23.Text);//纵向高度

            string[] a = wu.get_Value(select);
            string nain = Convert.ToDateTime(a[6]).Year.ToString();
            string yue = Convert.ToDateTime(a[6]).Month.ToString();
            string ri = Convert.ToDateTime(a[6]).Day.ToString();

            //第一行
            e.Graphics.DrawString(a[0], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 70 + xWidth, 16 + yHeight);//业务流水号
            e.Graphics.DrawString(a[1], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 190 + xWidth, 16 + yHeight);//社会保障号
            e.Graphics.DrawString(a[2], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 420 + xWidth, 16 + yHeight);//病历号
            //第二行
            e.Graphics.DrawString(a[3], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 72 + xWidth, 35 + yHeight);//住院（科室）
            e.Graphics.DrawString(a[4], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 189 + xWidth, 35 + yHeight);//住院号
            e.Graphics.DrawString(a[5], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 420 + xWidth, 35 + yHeight);//医院类型
            e.Graphics.DrawString(nain, new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 490 + xWidth, 33 + yHeight);//年
            e.Graphics.DrawString(yue, new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 550 + xWidth, 33 + yHeight);//月
            e.Graphics.DrawString(ri, new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 600 + xWidth, 33 + yHeight);//日
            //第三行
            e.Graphics.DrawString(a[7], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 72 + xWidth, 62 + yHeight);//姓名
            if (a[8] == "门诊")
            {
                e.Graphics.DrawString("√", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 224 + xWidth, 59 + yHeight);//类型
            }
            if (a[8] == "急诊")
            {
                e.Graphics.DrawString("√", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 275 + xWidth, 59 + yHeight);//类型
            }
            if (a[8] == "住院")
            {
                e.Graphics.DrawString("√", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 330 + xWidth, 59 + yHeight);//类型
            }
            if (a[9] != "")
            {
                e.Graphics.DrawString(a[9], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 450 + xWidth, 62 + yHeight);//住院日期
            }
            if (a[10] != "")
            {
                e.Graphics.DrawString(a[10], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 568 + xWidth, 62 + yHeight);//出院日期
            }
            //第四行
            if (a[11] == "男")
            {
                e.Graphics.DrawString("√", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 73 + xWidth, 84 + yHeight);//性别
            }
            if (a[11] == "女")
            {
                e.Graphics.DrawString("√", new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 104 + xWidth, 84 + yHeight);//性别
            }
            e.Graphics.DrawString(a[12], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 260 + xWidth, 87 + yHeight);//医保统筹
            e.Graphics.DrawString(a[13], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 410 + xWidth, 87 + yHeight);//个人缴费
            e.Graphics.DrawString(a[14], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 560 + xWidth, 87 + yHeight);//结算方式
            //第五行
            e.Graphics.DrawString(a[15], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 25 + xWidth, 139 + yHeight);//医药费1
            e.Graphics.DrawString(wu.set_null(a[16]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 90 + xWidth, 139 + yHeight);//金额1
            e.Graphics.DrawString(a[21], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 165 + xWidth, 139 + yHeight);//诊查费1
            e.Graphics.DrawString(wu.set_null(a[22]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 250 + xWidth, 139 + yHeight);//金额1
            e.Graphics.DrawString(a[27], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 328 + xWidth, 139 + yHeight);//治疗费1
            e.Graphics.DrawString(wu.set_null(a[28]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 410 + xWidth, 139 + yHeight);//金额1
            e.Graphics.DrawString(a[33], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 490 + xWidth, 139 + yHeight);//其他1
            e.Graphics.DrawString(wu.set_null(a[34]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 580 + xWidth, 139 + yHeight);//金额1
            //第六行
            e.Graphics.DrawString(a[17], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 25 + xWidth, 164 + yHeight);//医药费2
            e.Graphics.DrawString(wu.set_null(a[18]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 90 + xWidth, 164 + yHeight);//金额2
            e.Graphics.DrawString(a[23], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 165 + xWidth, 164 + yHeight);//诊查费2
            e.Graphics.DrawString(wu.set_null(a[24]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 250 + xWidth, 164 + yHeight);//金额2
            e.Graphics.DrawString(a[29], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 328 + xWidth, 164 + yHeight);//治疗费2
            e.Graphics.DrawString(wu.set_null(a[30]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 410 + xWidth, 164 + yHeight);//金额2
            e.Graphics.DrawString(a[35], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 490 + xWidth, 164 + yHeight);//其他2
            e.Graphics.DrawString(wu.set_null(a[36]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 580 + xWidth, 164 + yHeight);//金额2
            //第七行
            e.Graphics.DrawString(a[19], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 25 + xWidth, 189 + yHeight);//医药费3
            e.Graphics.DrawString(wu.set_null(a[20]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 90 + xWidth, 189 + yHeight);//金额3
            e.Graphics.DrawString(a[25], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 165 + xWidth, 189 + yHeight);//诊查费3
            e.Graphics.DrawString(wu.set_null(a[26]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 250 + xWidth, 189 + yHeight);//金额3
            e.Graphics.DrawString(a[31], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 328 + xWidth, 189 + yHeight);//治疗费3
            e.Graphics.DrawString(wu.set_null(a[32]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 410 + xWidth, 189 + yHeight);//金额3
            e.Graphics.DrawString(a[37], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 490 + xWidth, 189 + yHeight);//其他3
            e.Graphics.DrawString(wu.set_null(a[38]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 580 + xWidth, 189 + yHeight);//金额3
            //第八行
            e.Graphics.DrawString(wu.set_null(a[39]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 90 + xWidth, 216 + yHeight);//预交款
            e.Graphics.DrawString(wu.set_null(a[40]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 250 + xWidth, 216 + yHeight);//补收
            e.Graphics.DrawString(wu.set_null(a[41]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 410 + xWidth, 216 + yHeight);//退款
            e.Graphics.DrawString(wu.set_null(a[42]), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 580 + xWidth, 216 + yHeight);//欠费
            //第九行
            double a4 = Convert.ToDouble(a[43]);
            //   e.Graphics.DrawString(DaXie(a4, 0), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 158 + xWidth, 242 + yHeight);//百万
            e.Graphics.DrawString(DaXie(a4, 1), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 165 + xWidth, 242 + yHeight);//十万
            e.Graphics.DrawString(DaXie(a4, 2), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 205 + xWidth, 242 + yHeight);//万
            e.Graphics.DrawString(DaXie(a4, 3), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 245 + xWidth, 242 + yHeight);//千
            e.Graphics.DrawString(DaXie(a4, 4), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 283 + xWidth, 242 + yHeight);//百
            e.Graphics.DrawString(DaXie(a4, 5), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 320 + xWidth, 242 + yHeight);//十
            e.Graphics.DrawString(DaXie(a4, 6), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 360 + xWidth, 242 + yHeight);//元
            e.Graphics.DrawString(DaXie(a4, 8), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 400 + xWidth, 242 + yHeight);//角
            e.Graphics.DrawString(DaXie(a4, 9), new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 440 + xWidth, 242 + yHeight);//分

            e.Graphics.DrawString(a[43], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 505 + xWidth, 242 + yHeight);//总金额
            //第十行
            e.Graphics.DrawString(a[44], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 102 + xWidth, 319 + yHeight);//收款单位
            e.Graphics.DrawString(a[45], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 254 + xWidth, 319 + yHeight);//复核
            e.Graphics.DrawString(a[46], new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 400 + xWidth, 319 + yHeight);//收款人


      

            #region//不需使用信息

            #endregion
        }
        private string DaXie(double value, int wei)//小写转大写函数
        {
            string ab = value.ToString("0000000.00");
            string a = "零";
            if (ab.Substring(wei, 1) != "0")
            {
                Char bbx = Convert.ToChar(ab.Substring(wei, 1));
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
                    str = "捌";
                    break;
                case '9':
                    str = "玖";
                    break;
            }
            return str;
        }

        private string DaXie2(double value, int wei)//获取每个数值
        {
            string valuestr = value.ToString("#######.00");//值前一个符号清空不写

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
            string a = "0";
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
        private Single jiner(TextBox txt)
        {
            float a = 0.00F;
            if(txt.Text!="")
            {
                a = Convert.ToSingle(txt.Text);
            }
            return a;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ZhuYuanRiQi.Format = DateTimePickerFormat.Custom;
            ZhuYuanRiQi.CustomFormat = " ";//时间选择初始为空值

            ChuYuanRiQi.Format = DateTimePickerFormat.Custom;
            ChuYuanRiQi.CustomFormat = " ";//时间选择初始为空值

            XingBie.SelectedItem = "女";
            hejishu();
            string select = "select UserName from Users where Account='" + wu.account + "'";
            string[] a = wu.get_Value(select);
            ShouKanRen1.Text = a[0];
            string selectX = "select zhiheight,xwidth,yheight from MoRen2";
            string[] ax = wu.get_Value(selectX);
            textBox21.Text = ax[0];
            textBox22.Text = ax[1];
            textBox23.Text = ax[2];
        }

        private void ZhuYuanRiQi_ValueChanged(object sender, EventArgs e)
        {
            ZhuYuanRiQi.Format = DateTimePickerFormat.Long;
            ZhuYuanRiQi.CustomFormat = null;

        }

        private void ChuYuanRiQi_ValueChanged(object sender, EventArgs e)
        {
            ChuYuanRiQi.Format = DateTimePickerFormat.Long;
            ChuYuanRiQi.CustomFormat = null;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZhuYuanRiQi.Format = DateTimePickerFormat.Custom;
            ZhuYuanRiQi.CustomFormat = " ";//时间选择初始为空值

            ChuYuanRiQi.Format = DateTimePickerFormat.Custom;
            ChuYuanRiQi.CustomFormat = " ";//时间选择初始为空值
        }

        private void YiJinEr1_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void YiJinEr2_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void YiJinEr3_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void ZhenJinEr1_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void ZhenJinEr2_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void ZhenJinEr3_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void ZhiJinEr1_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void ZhiJinEr2_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void ZhiJinEr3_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void QiJinEr1_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void QiJinEr2_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void QiJinEr3_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void YuJiaoKuan_TextChanged(object sender, EventArgs e)
        {
            hejishu();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            YeWuHao.Text = "";
            SheHuiHao.Text = "";
            BingLiHao.Text = "";
            ZhuYuan.Text = "";
            ZhuYuanHao.Text = "";
            YiYuan.Text = "";

           
            XingBie.SelectedItem = "";
            YiBaoTongChou.Text = "";
            GeRenJiaoFei.Text = "";
            JieShuanFangShi.Text = "";
            YiYaoFei1.Text = "";
            YiJinEr1.Text = "";
            YiYaoFei2.Text = "";
            YiJinEr2.Text = "";
            YiYaoFei3.Text = "";
            YiJinEr3.Text = "";
            ZhenChaFei1.Text = "";
            ZhenJinEr1.Text = "";
            ZhenChaFei2.Text = "";
            ZhenJinEr2.Text = "";
            ZhenChaFei3.Text = "";
            ZhenJinEr3.Text = "";
            ZhiLiaoFei1.Text = "";
            ZhiJinEr1.Text = "";
            ZhiLiaoFei2.Text = "";
            ZhiJinEr2.Text = "";
            ZhiLiaoFei3.Text = "";
            ZhiJinEr3.Text = "";
            QiTa1.Text = "";
            QiJinEr1.Text = "";
            QiTa2.Text = "";
            QiJinEr2.Text = "";
            QiTa3.Text = "";
            QiJinEr3.Text = "";
            YuJiaoKuan.Text = "";
            BuShou.Text = "";
            TuiKuan.Text = "";
            QianFei.Text = "";
            HeJi1.Text = "";
            ShouKanDanWei1.Text = "";
            FuHe1.Text = "";
            ShouKanRen1.Text = "";
           

            string select = "select YeWuHao,SheHuiHao,BingLiHao,ZhuYuan,ZhuYuanHao,YiYuan,FuKanShiJian,XingMing,LeiXing,ZhuYuanRiQi,ChuYuanRiQi,XingBie," +
                        "YiBaoTongChou,GeRenJiaoFei,JieShuanFangShi,YiYaoFei1,YiJinEr1,YiYaoFei2,YiJinEr2,YiYaoFei3,YiJinEr3,ZhenChaFei1,ZhenJinEr1,ZhenChaFei2," +
                        "ZhenJinEr2,ZhenChaFei3,ZhenJinEr3,ZhiLiaoFei1,ZhiJinEr1,ZhiLiaoFei2,ZhiJinEr2,ZhiLiaoFei3,ZhiJinEr3,QiTa1,QiJinEr1,QiTa2,QiJinEr2," +
                        "QiTa3,QiJinEr3,YuJiaoKuan,BuShou,TuiKuan,QianFei,HeJi,ShouKanDanWei,FuHe,ShouKanRen,FaPiaoHao" +
                        " from FaPiao2" +
                        " where id <> 0";
            if (XingMing.Text!="")
            {
                select += " and XingMing='" + XingMing.Text + "'";
            }
            if (FaPiaoHao1.Text!="")
            {
                select += " and FaPiaoHao='" + FaPiaoHao1.Text + "'";
            }
            string[] a = wu.get_Value(select);
            YeWuHao.Text = a[0];
            SheHuiHao.Text = a[1];
            BingLiHao.Text = a[2];
            ZhuYuan.Text = a[3];
            ZhuYuanHao.Text = a[4];
            YiYuan.Text = a[5];
            if (a[6] != "")
            {
                FuKanShiJian1.Value = Convert.ToDateTime(a[6]);
            }
            XingMing.Text = a[7];
            LeiXing.SelectedItem = a[8];
            if (a[9] != "")
            {
                ZhuYuanRiQi.Value = Convert.ToDateTime(a[9]);
            }
            else
            {
                ZhuYuanRiQi.Format = DateTimePickerFormat.Custom;
                ZhuYuanRiQi.CustomFormat = " ";//时间选择初始为空值
            }
            if (a[10] != "")
            {
                ChuYuanRiQi.Value = Convert.ToDateTime(a[10]);
            }
            else
            {
                ChuYuanRiQi.Format = DateTimePickerFormat.Custom;
                ChuYuanRiQi.CustomFormat = " ";//时间选择初始为空值
            }
            XingBie.SelectedItem = a[11];
            YiBaoTongChou.Text = a[12];
            GeRenJiaoFei.Text = a[13];
            JieShuanFangShi.Text = a[14];
            YiYaoFei1.Text = a[15];
            YiJinEr1.Text =wu.set_null(a[16]);
            YiYaoFei2.Text = a[17];
            YiJinEr2.Text =wu.set_null(a[18]);
            YiYaoFei3.Text = a[19];
            YiJinEr3.Text =wu.set_null(a[20]);
            ZhenChaFei1.Text = a[21];
            ZhenJinEr1.Text =wu.set_null(a[22]);
            ZhenChaFei2.Text = a[23];
            ZhenJinEr2.Text =wu.set_null(a[24]);
            ZhenChaFei3.Text = a[25];
            ZhenJinEr3.Text =wu.set_null(a[26]);
            ZhiLiaoFei1.Text = a[27];
            ZhiJinEr1.Text =wu.set_null(a[28]);
            ZhiLiaoFei2.Text = a[29];
            ZhiJinEr2.Text =wu.set_null(a[30]);
            ZhiLiaoFei3.Text = a[31];
            ZhiJinEr3.Text =wu.set_null(a[32]);
            QiTa1.Text = a[33];
            QiJinEr1.Text =wu.set_null(a[34]);
            QiTa2.Text = a[35];
            QiJinEr2.Text =wu.set_null(a[36]);
            QiTa3.Text = a[37];
            QiJinEr3.Text =wu.set_null(a[38]);
            YuJiaoKuan.Text =wu.set_null(a[39]);
            BuShou.Text =wu.set_null(a[40]);
            TuiKuan.Text =wu.set_null(a[41]);
            QianFei.Text =wu.set_null(a[42]);
            HeJi1.Text =wu.set_null(a[43]);
            ShouKanDanWei1.Text = a[44];
            FuHe1.Text = a[45];
            ShouKanRen1.Text = a[46];
            FaPiaoHao1.Text = a[47];
            label10.Text = FaPiaoHao1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string update = "update FaPiao2 set ZhuangTai = '" + comboBox1.Text + "' where FaPiaoHao = '" + label10.Text + "'";
            if (wu.ExecSQL(update) == true)
            {
                MessageBox.Show("修改成功！", "ERROR");
                return;



            }
            else
            {
                MessageBox.Show("系统错误，请联系计算机管理科！", "ERROR");
                return;
            }
        }

        private void 导出ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string select = "select YeWuHao,SheHuiHao,BingLiHao,ZhuYuan,ZhuYuanHao,YiYuan,FuKanShiJian,XingMing,LeiXing,ZhuYuanRiQi,ChuYuanRiQi,XingBie," +
               "YiBaoTongChou,GeRenJiaoFei,JieShuanFangShi,YiYaoFei1,YiJinEr1,YiYaoFei2,YiJinEr2,YiYaoFei3,YiJinEr3,ZhenChaFei1,ZhenJinEr1,ZhenChaFei2," +
               "ZhenJinEr2,ZhenChaFei3,ZhenJinEr3,ZhiLiaoFei1,ZhiJinEr1,ZhiLiaoFei2,ZhiJinEr2,ZhiLiaoFei3,ZhiJinEr3,QiTa1,QiJinEr1,QiTa2,QiJinEr2," +
               "QiTa3,QiJinEr3,YuJiaoKuan,BuShou,TuiKuan,QianFei,HeJi,ShouKanDanWei,FuHe,ShouKanRen,FaPiaoHao,ZhuangTai" +
               " from FaPiao2";
               
            wu.dbGridView(select, dataGridView1);
            DataGridviewShowToExcel(dataGridView1, true);
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
            string update = "update MoRen2 set zhiheight='" + textBox21.Text + "',xwidth='" + textBox22.Text + "',yheight='" + textBox23.Text + "'";
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


        private void Form2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this.SelectNextControl(this.ActiveControl,true, true, true, true);
                //前台的KeyPreview 需改成 true 才能生效
                SendKeys.Send("{Tab}");  //向活动应用程序发送击键 注意格式：Send("{Tab}");中的{}
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            YeWuHao.Focus();
        }
    }
}
