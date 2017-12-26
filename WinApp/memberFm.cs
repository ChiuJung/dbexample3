using System;
using System.Windows.Forms;
using ActivitySystemEntity;


namespace WinApp
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();
        }
        private BindingSource bindingSource = new BindingSource();

        private void btnSearch_Click(object sender, EventArgs e)
        {      
            Member mm = new Member();
            Member getMember = mm.selectSingleObject(txtSearch.Text);
            bindingSource.Clear();
            bindingSource.Add(getMember);
            dbvShowData.AutoSize = true;
            dbvShowData.DataSource = bindingSource;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Member mm = new Member();
            bool flag = mm.update();
            if (flag)
            {
                MessageBox.Show("更新成功");
            }
            else {
                MessageBox.Show("更新失敗");
            };
        }
    }
}
