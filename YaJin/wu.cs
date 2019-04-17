using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace YaJin
{
    class wu
    {
        public static string account="";//记录账号
        /// <summary>
        ///返回SQL连接串 
        /// </summary>
        public static string get_conn()
        {
            string conn = "";

            //conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Windows.Forms.Application.StartupPath + "/YaJin.mdb";//access2013
            conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.Windows.Forms.Application.StartupPath + "/YaJin.mdb";//access2010
             // conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= F:\\项目\\票据打印程序\\数据库\\YaJin.mdb";
            return conn;
        }
        /// <summary>
        ///参数：SQLStr SQL查询语句
        /// </summary>
        /// 获取数据显示
        public static string[] get_Value(string SQLStr)
        {
            string conn = get_conn();
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            string select = SQLStr;
            OleDbCommand com = new OleDbCommand(select, con);
            OleDbDataReader dir = com.ExecuteReader();
            string[] strField = new string[dir.FieldCount];//动态定义数组长度
            if (dir.Read())
            {
                for (int i = 0; i < dir.FieldCount; i++)//dir.FieldCount为当前行中的列数
                {
                    strField[i] = Convert.ToString(dir["" + dir.GetName(i) + ""]);//dir.GetName(i)为列的字段名称
                }
            }
            dir.Close();
            con.Close();
            return strField;
        }

        /// <summary>
        /// 说明：ExecSQL用来执行SQL语句。
        ///	返回值：操作是否成功(true\false)。
        ///	参数：sqlList 多条SQL语句执行事条
        /// </summary>
        /// 执行操作SQL语句函数（插入、更新、删除操作）
        public static Boolean ExecSQL(List<string> sqlList)
        {
            string conn = get_conn();
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbCommand myCommand = con.CreateCommand();
            OleDbTransaction myTrans;
            myTrans = con.BeginTransaction(IsolationLevel.ReadCommitted);
            myCommand.Connection = con;
            myCommand.Transaction = myTrans;
            try
            {
                foreach (string item in sqlList)
                {
                    myCommand.CommandText = item;
                    myCommand.ExecuteNonQuery();
                }
                myTrans.Commit();
                return true;
            }
            catch (Exception)
            {
                myTrans.Rollback();
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        /// <summary>
        /// 说明：ExecSQL用来执行SQL语句。
        ///	返回值：操作是否成功(true\false)。
        ///	参数：sQueryString SQL字符串
        /// </summary>
        /// 执行操作SQL语句函数（插入、更新、删除操作）
        public static Boolean ExecSQL(string sQueryString)
        {
            Boolean k;
            string conn = get_conn();
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbCommand dbCommand = new OleDbCommand(sQueryString, con);
            try
            {
                dbCommand.ExecuteNonQuery();
                k = true;
            }
            catch
            {
                k = false;
            }
            finally
            {
                con.Close();
            }
            return k;
        }
        /// <summary>
        /// 说明：ExecSQL用来执行SQL语句(含事务)。
        ///	返回值：操作是否成功(true\false)。
        ///	参数：sQueryString01,sQueryString02 SQL字符串
        /// </summary>
        /// 执行操作SQL语句函数（插入、更新、删除操作）
        public static Boolean ExecSQL(string sQueryString01, string sQueryString02)
        {
            Boolean k;

            string conn = get_conn();
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbTransaction tran = con.BeginTransaction();//创建事务
            OleDbCommand dbCommand = new OleDbCommand(sQueryString01, con);
            OleDbCommand dbCommand02 = new OleDbCommand(sQueryString02, con);
            try
            {
                dbCommand.Transaction = tran;
                dbCommand.ExecuteNonQuery();
                dbCommand02.Transaction = tran;
                dbCommand02.ExecuteNonQuery();
                tran.Commit();//提交事务
                k = true;
            }
            catch
            {
                tran.Rollback();//提交失败恢复一致数据
                k = false;
            }
            finally
            {
                con.Close();
            }
            return k;
        }
        /// <summary>
        /// 说明：ExecSQL用来执行SQL语句(含事务)。
        ///	返回值：操作是否成功(true\false)。
        ///	参数：sQueryString01,sQueryString02,sQueryString03 SQL字符串
        /// </summary>
        /// 执行操作SQL语句函数（插入、更新、删除操作）
        public static Boolean ExecSQL(string sQueryString01, string sQueryString02, string sQueryString03)
        {
            Boolean k;
            string conn = get_conn();
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbTransaction tran = con.BeginTransaction();//创建事务
            OleDbCommand dbCommand = new OleDbCommand(sQueryString01, con);
            OleDbCommand dbCommand02 = new OleDbCommand(sQueryString02, con);
            OleDbCommand dbCommand03 = new OleDbCommand(sQueryString03, con);
            try
            {
                dbCommand.Transaction = tran;
                dbCommand.ExecuteNonQuery();
                dbCommand02.Transaction = tran;
                dbCommand02.ExecuteNonQuery();
                dbCommand03.Transaction = tran;
                dbCommand03.ExecuteNonQuery();
                tran.Commit();//提交事务
                k = true;
            }
            catch
            {
                tran.Rollback();//提交失败恢复一致数据
                k = false;
            }
            finally
            {
                con.Close();
            }
            return k;
        }
        /// <summary>
        /// 说明：SelectSQL用来执行SQL语句。
        ///	返回值：操作是否成功(true\false)。
        ///	参数：sQueryString SQL字符串
        /// </summary>
        /// 数据查询、登陆判断方法
        public static Boolean SelectSQL(string sQueryString)
        {
            Boolean k;
            string conn = get_conn();
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sQueryString, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                k = true;
            }
            else
            {
                k = false;
            }
            con.Close();
            return k;
        }

        /// <summary>
        ///参数：SqlStr SQL查询语句，Gd 控件名称
        /// </summary>
        /// GridView绑定方法
        public static void dbGridView(string SqlStr, DataGridView Gd)
        {
            string conn = get_conn();
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            string select = SqlStr;
            OleDbDataAdapter da = new OleDbDataAdapter(select, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Gd.DataSource = ds.Tables[0];
            
            con.Close();
        }

        /// <summary>
        ///参数：strIn 输入值
        /// </summary>
        /// 验证正整数
        public static bool IsValidInt(string strIn)
        {
            if (strIn != "")
            {
                return Regex.IsMatch(strIn, @"^[0-9]*$");
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        ///参数：strIn 输入值
        /// </summary>
        /// 验证数字值（正负整数）
        public static bool IsValidInt2(string strIn)
        {
            if (strIn != "")
            {
               // strIn = Math.Abs(strIn);
                return Regex.IsMatch(strIn, @"^[+\-]?(\d|[0123456789]\d{1,2})$");
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        ///参数：strIn 输入值,n 最少位数，m 最多位数
        /// </summary>
        /// 验证正整数
        public static bool IsValidInt(string strIn, int n, int m)
        {
            if (strIn != "")
            {
                return Regex.IsMatch(strIn, @"^\d{" + n + "," + m + "}$");
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        ///参数：strIn 输入值
        /// </summary>
        /// 验证浮点数
        public static bool IsValidFloat(string strIn)
        {
            if (strIn != "")
            {
                return Regex.IsMatch(strIn, @"^\d+(\.\d+)?$");
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        ///参数：strIn 输入值,n 最少小数点数，m 最多小数点数
        /// </summary>
        /// 验证浮点数
        public static bool IsValidFloat(string strIn, int n, int m)
        {
            if (strIn != "")
            {
                return Regex.IsMatch(strIn, @"^[0-9]+(.[0-9]{" + n + "," + m + "})?$");
            }
            else
            {
                return true;
            }
        }

        public static string set_null(string value)
        {
            string a = "";
            a = value;
            if (a == "0.0000")
            {
                a = "";
            }
            if (a == "0")
            {
                a = "";
            }
            if (a == "0.00")
            {
                a = "";
            }
            return a;
        }
    }
}
