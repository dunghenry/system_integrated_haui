namespace TranVanDung_2019603537
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();

        private void loadData(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            dataGridView1.DataSource = data.getSachs();
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[0].Width = 50;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void getSach(object sender, DataGridViewCellEventArgs e)
        {
            Sach s = (Sach)dataGridView1.CurrentRow.DataBoundItem;
            txtNXB.Text = s.nxb;
            txtMS.Text = s.ms;
            txtTS.Text = s.ts;
            txtGB.Text = s.gb;
            txtTG.Text = s.tg;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.nxb = txtNXB.Text;
            s.ms = txtMS.Text;
            s.ts = txtTS.Text;
            s.gb = txtGB.Text;
            s.tg = txtTG.Text;
            data.addSach(s);
            loadData();
            clearTextboxs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.nxb = txtNXB.Text;
            s.ms = txtMS.Text;
            s.ts = txtTS.Text;
            s.gb = txtGB.Text;
            s.tg = txtTG.Text;
            bool check = data.updateSach(s);
            if (!check)
            {
                MessageBox.Show("Không cập nhật được tài khoản có số tài khoản = " + s.ms);
                return;
            }
           
            clearTextboxs();
            loadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (d == DialogResult.Yes)
            {
                bool check = data.deleteSach(txtMS.Text);
                if (!check)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa", "Thông báo");
                    return;

                }
                loadData();
                clearTextboxs();

            }
        }

        private void clearTextboxs()
        {
            txtNXB.Clear();
            txtMS.Clear();
            txtTS.Clear();
            txtGB.Clear();
            txtTG.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}