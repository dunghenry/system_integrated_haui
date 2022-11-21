using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Text;

namespace CallAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            string link = "http://localhost/data/api/sanpham";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arr = data as SanPham[];
            dataGridView1.DataSource = arr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData(object sender, EventArgs e)
        {
            string link = "http://localhost/restfull/api/danhmuc";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object Data = js.ReadObject(response.GetResponseStream());
            DanhMuc[] dsDM = Data as DanhMuc[];
            cbDanhMuc.DataSource = dsDM;
            cbDanhMuc.ValueMember = "MaDanhMuc";
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            getData();
        }
        private void getData()
        {
            string link = "http://localhost/restfull/api/sanpham";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arr = data as SanPham[];
            dataGridView1.DataSource = arr;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            string maSP = txtMaSP.Text;
            sp.Ma = Int32.Parse(maSP);
            sp.Ten = txtTenSP.Text;
            sp.DonGia = Int32.Parse(txtDonGia.Text);

            string postSP = string.Format("?masp={0}&ten={1}&dg={2}&madm={3}", sp.Ma, sp.Ten, sp.DonGia, cbDanhMuc.SelectedValue);
            string link = "http://localhost/restfull/api/sanpham/" + postSP;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(postSP);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            SanPham result = (SanPham)data;
            if (result.Ma != null)
            {
                MessageBox.Show("Them san pham thanh cong");
            }
            else
            {
                MessageBox.Show("Them san pham that bai");
            }
        }
    }
}