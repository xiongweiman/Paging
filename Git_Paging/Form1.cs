using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Paging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //分页控件
        private void myPage1_OnPageChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            int row = int.Parse(SqlHelper.ExcuteScalar("select count(1) from t_xw").ToString());
            myPage1.DrawControl(row);
            string sql = $"select top {myPage1.PageSize} * from (select row_number() over(order by id) as rownumber,*from t_xw) as a where rownumber> {(myPage1.PageIndex-1)*myPage1.PageSize}";
            dataGridView1.DataSource = SqlHelper.ExcuteDataTable(sql);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
