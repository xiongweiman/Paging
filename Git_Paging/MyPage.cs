using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Git_Paging
{
    public partial class MyPage : UserControl
    {
        public MyPage()
        {
            InitializeComponent();
        }
        #region 分页字段和属性
        private int pageIndex = 1;// 当前页面
        private int pageSize = 100;// 每页记录数
        private int recordCount = 0;// 总记录数
        private int pageCount = 0;// 总页数
        public int PageCount
        {
            get
            {
                if (pageSize != 0)
                {
                    pageCount = GetPageCount();
                }
                return pageCount;
            }
        }
        public virtual int RecordCount
        {
            get { return recordCount; }
            set { recordCount = value; }
        }
        public virtual int PageSize
        {
            get { return pageSize; }
            set { pageSize =Convert.ToInt32(txt_pagesize.Text); }
        }
        public virtual int PageIndex
        {
            get { return pageIndex; }
            set { pageIndex = value; }
        }
        #endregion
        #region 页码变化触发事件

        public event EventHandler OnPageChanged;

        #endregion
        #region 分页及相关事件功能实现
        private void SetFormCtrEnabled()
        {
            btn_home.Enabled = true;
            btn_pre.Enabled = true;
            btn_next.Enabled = true;
            btn_last.Enabled = true;
        }
        // 计算总页数
        private int GetPageCount()
        {
            if (PageSize == 0)
            {
                return 0;
            }
            int pageCount = RecordCount / PageSize;
            if (RecordCount % PageSize == 0)
            {
                pageCount = RecordCount / PageSize;
            }
            else
            {
                pageCount = RecordCount / PageSize + 1;
            }
            return pageCount;
        }
        /// <summary>
        /// 外部调用
        /// </summary>
        public void DrawControl(int count)
        {
            recordCount = count;
            DrawControl(false);
        }
        // 页面控件呈现
        private void DrawControl(bool callEvent)
        {
            lab_index.Text = PageIndex.ToString();
            lab_pagecount.Text = PageCount.ToString();
            lab_count.Text = RecordCount.ToString();
            if (callEvent && OnPageChanged != null)
            {
                OnPageChanged(this, null);//当前分页数字改变时，触发委托事件
            }
            SetFormCtrEnabled();
            if (PageCount == 1)//有且仅有一页
            {
                btn_home.Enabled = false;
                btn_pre.Enabled = false;
                btn_next.Enabled = false;
                btn_last.Enabled = false;
            }
            else if (PageIndex == 1)//第一页
            {
                btn_home.Enabled = false;
                btn_pre.Enabled = false;
            }
            else if (PageIndex == PageCount)//最后一页
            {
                btn_next.Enabled = false;
                btn_last.Enabled = false;
            }
        }
        #endregion
        #region 首页
        private void btn_home_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            PageSize = Convert.ToInt32(txt_pagesize.Text);
            DrawControl(true);
        }
        #endregion
        #region 上一页
        private void btn_pre_Click(object sender, EventArgs e)
        {
            PageIndex = Math.Max(1, PageIndex - 1);
            PageSize = Convert.ToInt32(txt_pagesize.Text);
            DrawControl(true);
        }
        #endregion
        #region 下一页
        private void btn_next_Click(object sender, EventArgs e)
        {
            PageIndex = Math.Min(PageCount, PageIndex + 1);
            PageSize = Convert.ToInt32(txt_pagesize.Text);
            DrawControl(true);
        }
        #endregion
        #region 末页
        private void btn_last_Click(object sender, EventArgs e)
        {
            PageIndex = PageCount;
            PageSize = Convert.ToInt32(txt_pagesize.Text);
            DrawControl(true);
        } 
        #endregion
    }
}
