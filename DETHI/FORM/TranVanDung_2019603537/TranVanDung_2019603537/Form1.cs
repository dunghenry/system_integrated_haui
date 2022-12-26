using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace TranVanDung_2019603537
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }

        

      
        private void getData()
        {
            string link = "https://localhost:44301/api/nhanvien";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] arr = data as NhanVien[];
            dataGridView1.DataSource = arr;
        }

        private void loadData(object sender, EventArgs e)
        {
            getData();
        }
        private void ClearTextBoxs()
        {
            tenNV.Clear();
            maNV.Clear();
            HsLuong.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = Int32.Parse(maNV.Text);
            nv.TenNV = maNV.Text;
            nv.HsLuong = decimal.Parse(HsLuong.Text);
            string postNhanVien = string.Format("?manv={0}&tennv={1}&hsluong={2}", nv.MaNV, nv.TenNV, nv.HsLuong);
            string link = "https://localhost:44301/api/nhanvien/" + postNhanVien;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(postNhanVien);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            NhanVien rs = (NhanVien)data;
            if (rs == null)
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
            MessageBox.Show("Thêm nhân viên thành công");
            getData();
            ClearTextBoxs();
        }

        private void getSingleNV(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nv = (NhanVien)dataGridView1.CurrentRow.DataBoundItem;
            tenNV.Text = nv.TenNV;
            maNV.Text = nv.MaNV.ToString();
            HsLuong.Text = nv.HsLuong.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteNhanVien = "?manv=" + Int32.Parse(maNV.Text);
            string link = "https://localhost:44301/api/nhanvien/" + deleteNhanVien;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(deleteNhanVien);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool rs = (bool)data;
            if (rs)
            {
                MessageBox.Show("Xóa nhân viên thành công");
                ClearTextBoxs();
                getData();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
                ClearTextBoxs();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = Int32.Parse(maNV.Text);
            nv.TenNV = tenNV.Text;
            nv.HsLuong = decimal.Parse(HsLuong.Text);
            string puttNhanVien = string.Format("?manv={0}&tennv={1}&hsluong={2}", nv.MaNV, nv.TenNV, nv.HsLuong);
            string link = "https://localhost:44301/api/nhanvien/" + puttNhanVien;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "PUT";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(puttNhanVien);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            NhanVien rs = (NhanVien)data;
            if (rs == null)
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
            MessageBox.Show("Sửa nhân viên thành công");
            getData();
            ClearTextBoxs();
        }
    }
}