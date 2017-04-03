using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace ServiceMaster
{
    /// <summary>
    /// ���������MS Access ���ݿ�
    /// </summary>
    /// <example>
    /// DBControl.getDataTable("User","UserName,UserAge","UserName Like %DK%");
    /// </example>
    public static class DBControl
    {
        /// <summary>
        /// ���ݼ�
        /// </summary>
        private static DataSet ds;
        /// <summary>
        /// ������ݿ������
        /// </summary>
        /// <returns>���ݿ�����</returns>
        public static OleDbConnection getConnection()
        {
            //string conString =;
            OleDbConnection con = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ Properties.Settings.Default.DBfile+";User ID=admin;Password=;Jet OLEDB:Database Password=19860922");
            return con;
        }
        /// <summary>
        /// ִ��Update/Delete/Insert����
        /// </summary>
        /// <param name="SQLcmd">SQL����</param>
        public static void ExecuteSQL(string SQLcmd)  
        {
            OleDbConnection con = getConnection();
            OleDbCommand cmd = new OleDbCommand(SQLcmd, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// <summary>
        /// ʹ�÷�����ģʽ�������ݵ�DataSet ds����
        /// </summary>
        /// <param name="SQLcommand">SQL����</param>
        public static void loadDataSet(string SQLcommand)
        {
            OleDbConnection con = getConnection();
            con.Open();
            ds = new DataSet();
            try {
                OleDbDataAdapter adp = new OleDbDataAdapter(SQLcommand, con);
                adp.Fill(ds);
            }
            catch (OleDbException OleDbEx)
            {
                throw OleDbEx;
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// ��ȡ�������ݺ��DataSet�����û�м��أ�����SQLcommand��������
        /// </summary>
        /// <param name="SQLcommand">SQL����</param>
        /// <returns>���غ�����ݼ�</returns>
        public static DataSet getDataSet(string SQLcommand)
        {
            if (ds==null)
                loadDataSet(SQLcommand);
            return ds;
        }
        /// <summary>
        /// ��ȡָ�����ݿ��е�ָ�����ݱ���ָ���е�����
        /// </summary>
        /// <param name="TableName">����</param>
        /// <param name="Columns">��</param>
        /// <returns>��Ӧ�Ĳ�ѯ���</returns>
        public static DataTable getDataTable(string TableName, string Columns)
        {
            return getDataSet("Select " + Columns + " From " + TableName).Tables[0];            
        }
        /// <summary>
        /// ��ȡָ�����ݿ��е�ָ�����ݱ���ָ����������ָ����ѯ����������
        /// </summary>
        /// <param name="TableName">����</param>
        /// <param name="Columns">��</param>
        /// /// <param name="Conditions">��ѯ����</param>
        /// <returns>��Ӧ�Ĳ�ѯ���</returns>
        public static DataTable getDataTable(string TableName, string Columns, string Conditions)
        {
            return getDataSet("Select "+Columns+" From "+TableName+" Where "+Conditions).Tables[0];
        }
        /// <summary>
        /// ��ȡָ�����ݿ��е�ָ�����ݱ������
        /// </summary>
        /// <param name="TableName">����</param>
        /// <returns>��Ӧ�Ĳ�ѯ���</returns>
        public static DataTable getDataTable(string TableName)
        {
            return getDataTable(TableName, "*");
        }
    }
}
