using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace UpdateProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData(object sender, EventArgs e)
        {
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
            lstSanPham.DataSource = arr;
            lstSanPham.ValueMember = "Ma";
            lstSanPham.DisplayMember = "Ten";


        }

        private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSanPham.SelectedIndex == -1) return;
            SanPham sp = lstSanPham.SelectedItem as SanPham;
            txtMaSP.Text = sp.Ma + "";
            txtTenSP.Text = sp.Ten + "";
            txtDonGia.Text = sp.DonGia + "";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.Ma = Int32.Parse(txtMaSP.Text);
            sp.Ten = txtTenSP.Text;
            sp.DonGia = Int32.Parse(txtDonGia.Text);

            string putSP = string.Format("?masp={0}&ten={1}&dg={2}&madm={3}", sp.Ma, sp.Ten, sp.DonGia, 1);
            string link = "http://localhost/restfull/api/sanpham/" + putSP;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "PUT";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(putSP);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            SanPham result = (SanPham)data;
            if (result.Ma != null)
            {
                MessageBox.Show("Sua san pham thanh cong");
            }
            else
            {
                MessageBox.Show("Sua san pham that bai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deleteSP = string.Format("?masp={0}", txtMaSP.Text);
            string link = "http://localhost/restfull/api/sanpham/" + deleteSP;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(deleteSP);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(string));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            string result = (string)data;
            if (result == "Xoa san pham thanh cong")
            {
                MessageBox.Show("Xoa san pham thanh cong");
                getData();
            }
            else
            {
                MessageBox.Show("Xoa san pham that bai");
            }
        }
    }
}