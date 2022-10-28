namespace Bai07_Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataUtil data = new DataUtil();

        private void Form1_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            dataGridView1.DataSource = data.getAllStudents();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[0].Width = 200;
            lblCount.Text = dataGridView1.Rows.Count + "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.id = txtId.Text;
            s.name = txtName.Text;
            s.age = txtAge.Text;
            s.city = txtCity.Text;
            data.addStudent(s);
            clearTextboxs();
            displayData();
        }
        private void clearTextboxs()
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCity.Clear();
            ActiveControl = txtId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Student s = new Student();
            s.id = txtId.Text;
            s.name = txtName.Text;
            s.age = txtAge.Text;
            s.city = txtCity.Text;
            bool kt = data.updateStudent(s);
            if (!kt)
            {
                MessageBox.Show("Không cập nhật được sinh viên có id = " + s.id);
                return;
            }
            displayData();
            clearTextboxs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (d == DialogResult.Yes)
            {
                bool kt = data.deleteStudent(txtId.Text);
                if (!kt)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa", "Thông báo");
                    return;
                }
                displayData();
                clearTextboxs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextboxs();
                
        }

        private void btnFindbyID_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            List<Student> li = new List<Student>();
            Student s = data.findById(id);
            if(s!= null)
            {
                li.Add(s);
                dataGridView1.DataSource = li;
                lblCount.Text = dataGridView1.Rows.Count + "";
                txtId.Text = s.id;
                txtAge.Text = s.age;
                txtCity.Text = s.city;
                txtName.Text = s.name;
            }
            else
            {
                MessageBox.Show("Không có sinh viên có id = " + id, "Thông báo");
            }
        }

        private void btnFindbyCity_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            dataGridView1.DataSource = data.findByCity(city);
            lblCount.Text = dataGridView1.Rows.Count + "";
            clearTextboxs();
            txtCity.Text = city;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            dsa
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getStudent(object sender, DataGridViewCellEventArgs e)
        {
            Student s = (Student)dataGridView1.CurrentRow.DataBoundItem;
            txtId.Text = s.id;
            txtName.Text = s.name;
            txtAge.Text = s.age;
            txtCity.Text = s.city;
        }
    }
}