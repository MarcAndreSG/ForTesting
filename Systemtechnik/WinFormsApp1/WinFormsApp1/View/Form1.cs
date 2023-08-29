using Newtonsoft.Json;
using System.ComponentModel;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Form1Model _form1Model = new Form1Model();
        private BindingSource bindingSource;
        private List<Post> posts;
        private DataGridViewColumnHeaderCell clickedHeaderCell;
        private bool sortAscending = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void BT_GetData_Click(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            posts = _form1Model.testcAsync().Result;
            DG_Result.DataSource = posts;
        }

        private void DG_Result_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (posts != null && posts.Any())
            {
                string propertyName = DG_Result.Columns[e.ColumnIndex].DataPropertyName;

                if (sortAscending)
                {
                    DG_Result.DataSource = new BindingList<Post>(posts.OrderBy(p => p.GetType().GetProperty(propertyName).GetValue(p, null)).ToList());
                    sortAscending = false;
                }
                else
                {
                    DG_Result.DataSource = new BindingList<Post>(posts.OrderByDescending(p => p.GetType().GetProperty(propertyName).GetValue(p, null)).ToList());
                    sortAscending = true;
                }
            }
        }
    }
}