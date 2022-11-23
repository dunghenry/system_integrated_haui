using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Bai11_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadData(object sender, EventArgs e)
        {
            getData();
            getDonVi();
            getDonVis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
            getDonVi();
            
        }
        private void getData()
        {
            string link = "http://localhost/qlluong/api/nhanvien";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] arr = data as NhanVien[];
            dataGridView1.DataSource = arr;

        }

        private void getNhanVien(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nv = (NhanVien)dataGridView1.CurrentRow.DataBoundItem;
            txtHoTen.Text = nv.HoTen;
            txtMa.Text = nv.Ma.ToString();
            txtNgaySinh.Text = nv.NgaySinh;
            txtGioiTinh.Text = nv.GioiTinh;
            txtHsluong.Text = nv.Hesluong.ToString();
        }
        private void getDonVi()
        {
            string link = "http://localhost/qlluong/api/donvi";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DonVi[]));
            object data = js.ReadObject(response.GetResponseStream());
            DonVi[] dsDV = data as DonVi[];
            cbxDonVi.DataSource = dsDV;
            cbxDonVi.ValueMember = "MaDonVi";
            cbxDonVi.DisplayMember = "TenDonVi";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtMa.Clear();
            txtNgaySinh.Clear();
            txtGioiTinh.Clear();
            txtHoTen.Clear();
            txtHsluong.Clear();
            txtTenDV.Clear();
            txtMaDV.Clear();
            txtHSLTo.Clear();
            txtMaDV.Clear();
            txtTenDV.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            getDonVis();
        }
        private void getDonVis()
        {
            string link = "http://localhost/qlluong/api/donvi";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DonVi[]));
            object data = js.ReadObject(response.GetResponseStream());
            DonVi[] dsDV = data as DonVi[];
            dataGridView2.DataSource = dsDV;
        }

        private void getSingleDonVi(object sender, DataGridViewCellEventArgs e)
        {
            DonVi dv = (DonVi)dataGridView2.CurrentRow.DataBoundItem;
            txtMaDV.Text = dv.MaDonVi.ToString();
            txtTenDV.Text = dv.TenDonVi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = "http://localhost/qlluong/api/nhanvien/?manv=" + Int32.Parse(txtMa.Text);
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien nv = data as NhanVien;
            List<NhanVien> lst = new List<NhanVien>();
            lst.Add(nv);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lst;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string link = "http://localhost/qlluong/api/donvi/?madv=" + Int32.Parse(txtMaDV.Text);
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DonVi));
            object data = js.ReadObject(response.GetResponseStream());
            DonVi dv = data as DonVi;
            List<DonVi> lst = new List<DonVi>();
            lst.Add(dv);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lst;
        }

        private void btnGetNhanVienByGT_Click(object sender, EventArgs e)
        {
            string link = "http://localhost/qlluong/api/nhanvien/?gt=" + txtGioiTinh.Text;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            dataGridView1.DataSource = null;
            NhanVien[] dsNV = data as NhanVien[];
            dataGridView1.DataSource = dsNV;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string link = "http://localhost/qlluong/api/nhanvien/?from=" + txtHsluong.Text + "&to=" + txtHSLTo.Text;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            dataGridView1.DataSource = null;
            NhanVien[] dsNV = data as NhanVien[];
            dataGridView1.DataSource = dsNV;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Ma = Int32.Parse(txtMa.Text);
            nv.HoTen = txtHoTen.Text;
            nv.NgaySinh = txtNgaySinh.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.Hesluong = float.Parse(txtHsluong.Text);
            string postNhanVien = string.Format("?manv={0}&hoten={1}&ns={2}&gt={3}&hsl={4}&madv={5}", nv.Ma, nv.HoTen, DateTime.Parse(nv.NgaySinh), nv.GioiTinh, nv.Hesluong, cbxDonVi.SelectedValue);
            string link = "http://localhost/qlluong/api/nhanvien/" + postNhanVien;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(postNhanVien);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool result = (bool)data;
            if(result)
            {
                MessageBox.Show("Them nhan vien thanh cong");
                getData();
                Clear();
            }
            else
            {
                MessageBox.Show("Them nhan vien that bai");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string deleteNhanVien = string.Format("?manv={0}", txtMa.Text);
            string link = "http://localhost/qlluong/api/nhanvien/" + deleteNhanVien;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(deleteNhanVien);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0 , byteArr.Length);
            dataStream.Close();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool rs = (bool)data;
            if (rs)
            {
                MessageBox.Show("Xoa san pham thanh cong");
                Clear();
                getData();
            }
            else
            {
                MessageBox.Show("Xoa san pham that bai");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Ma = Int32.Parse(txtMa.Text);
            nv.HoTen = txtHoTen.Text;
            nv.NgaySinh = txtNgaySinh.Text;
            nv.GioiTinh = txtGioiTinh.Text;
            nv.Hesluong = float.Parse(txtHsluong.Text);
            string postNhanVien = string.Format("?manv={0}&hoten={1}&ns={2}&gt={3}&hsl={4}&madv={5}", nv.Ma, nv.HoTen, DateTime.Parse(nv.NgaySinh), nv.GioiTinh, nv.Hesluong, cbxDonVi.SelectedValue);
            string link = "http://localhost/qlluong/api/nhanvien/" + postNhanVien;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "PUT";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(postNhanVien);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool result = (bool)data;
            if (result)
            {
                MessageBox.Show("Sua nhan vien thanh cong");
                getData();
                Clear();
            }
            else
            {
                MessageBox.Show("Sua nhan vien that bai");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DonVi dv = new DonVi();
            dv.MaDonVi = Int32.Parse(txtMaDV.Text);
            dv.TenDonVi = txtTenDV.Text;
            string updateDonVi = string.Format("?madv={0}&tendv={1}", dv.MaDonVi, dv.TenDonVi);
            string link = "http://localhost/qlluong/api/donvi/" + updateDonVi;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "PUT";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(updateDonVi);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool result = (bool)data;
            if (result)
            {
                MessageBox.Show("Sua don vi thanh cong");
                Clear();
                getDonVis();
                getDonVi();
            }
            else
            {
                MessageBox.Show("Sua don vi that bai");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string deleteDonVi = "?madv=" + txtMaDV.Text;
            string link = "http://localhost/qlluong/api/donvi/" + deleteDonVi;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(deleteDonVi);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool result = (bool)data;
            if (result)
            {
                MessageBox.Show("Xoa don vi thanh cong");
                Clear();
                getDonVis();
                getDonVi();

            }
            else
            {
                MessageBox.Show("Xoa don vi that bai");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DonVi dv = new DonVi();
            dv.MaDonVi = Int32.Parse(txtMaDV.Text);
            dv.TenDonVi = txtTenDV.Text;
            string postDonVi = string.Format("?madv={0}&tendv={1}", dv.MaDonVi, dv.TenDonVi);
            string link = "http://localhost/qlluong/api/donvi/" + postDonVi;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(postDonVi);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool result = (bool)data;
            if (result)
            {
                MessageBox.Show("Them don vi thanh cong");
                Clear();
                getDonVis();
                getDonVi();
            }
            else
            {
                MessageBox.Show("Them don vi that bai");
            }
        }
    }
}