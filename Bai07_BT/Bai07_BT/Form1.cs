using System.Xml.Linq;

namespace Bai07_BT
{
    public partial class Form1 : Form
    {
        DataUtil data = new DataUtil();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.sotaikhoan = txtSoTaiKhoan.Text;
            tk.tentaikhoan = txtTenTaiKhoan.Text;
            tk.diachi = txtDiaChi.Text;
            tk.dienthoai = txtDienThoai.Text;
            tk.sotien = txtSoTien.Text;
            data.addTaiKhoan(tk);
            clearTextboxs();
            displayData();

        }

        private void clearTextboxs()
        {
            txtSoTaiKhoan.Clear();
            txtTenTaiKhoan.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtSoTien.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void displayData()
        {
            dataGridView1.DataSource = data.getAllTaiKhoan();
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[0].Width = 50;
            //lblCount.Text = dataGridView1.Rows.Count + "";
        }

        private void getTaiKhoan(object sender, DataGridViewCellEventArgs e)
        {
            TaiKhoan tk = (TaiKhoan)dataGridView1.CurrentRow.DataBoundItem;
            txtSoTaiKhoan.Text = tk.sotaikhoan;
            txtTenTaiKhoan.Text = tk.tentaikhoan;
            txtDiaChi.Text = tk.diachi;
            txtDienThoai.Text = tk.dienthoai;
            txtSoTien.Text = tk.sotien;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void LoadData(object sender, EventArgs e)
        {
            displayData();
        }

        private void btnFinBySTK_Click(object sender, EventArgs e)
        {
            string stk = txtSoTaiKhoan.Text;
            List<TaiKhoan> li = new List<TaiKhoan>();
            TaiKhoan tk = data.findBySTK(stk);
            if(tk != null)
            {
                li.Add(tk);
                dataGridView1.DataSource = li;
                txtSoTaiKhoan.Text = tk.sotaikhoan;
                txtTenTaiKhoan.Text = tk.tentaikhoan;
                txtDiaChi.Text = tk.diachi;
                txtDienThoai.Text = tk.dienthoai;
                txtSoTien.Text = tk.sotien;

            }
            else
            {
                MessageBox.Show("Không có tai khoản nào có số tài khoản = " + stk, "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (d == DialogResult.Yes)
            {
                bool check = data.deleteTaiKhoan(txtSoTaiKhoan.Text);
                if (!check)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa", "Thông báo");
                    return;

                }
                displayData();
                clearTextboxs();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.sotaikhoan = txtSoTaiKhoan.Text;
            tk.tentaikhoan = txtTenTaiKhoan.Text;
            tk.diachi = txtDiaChi.Text;
            tk.dienthoai = txtDienThoai.Text;
            tk.sotien = txtSoTien.Text;
            bool check = data.updateTaiKhoan(tk);
            if (!check)
            {
                MessageBox.Show("Không cập nhật được tài khoản có số tài khoản = " + tk.sotaikhoan);
                return;
            }
            displayData();
            clearTextboxs();
        }
    }
}