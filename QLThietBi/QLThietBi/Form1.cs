using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThietBi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadTBMax()
        {
            tbTBNhiuNhat.Text = TB_PhongP.GetInstance.timTBlapMax().ToString();
        }
        void loaiPhongChuaLapTB()
        {
            dgvChuaLapTB.DataSource = PhongP.GetInstance.timPhongChuaTrangBi();
        }
        void loadTB_Phong()
        {
            dgvP_TB.DataSource = TB_PhongP.GetInstance.GetTB_Phong();
        }
        void loadCB()
        {
            cbPhong.DataSource = PhongP.GetInstance.GetPhong();
            cbPhong.DisplayMember = "TenPhong";
            cbPhong.ValueMember = "MaPhong";
            cbThietBi.DataSource = ThietBiP.GetInstance.GetTB();
            cbThietBi.DisplayMember = "TenThietBi";
            cbThietBi.ValueMember = "MaThietBi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TB_Phong tB_Phong = new TB_Phong();
            tB_Phong.MaPhong = cbPhong.SelectedValue.ToString();
            tB_Phong.MaThietBi = cbThietBi.SelectedValue.ToString();
            tB_Phong.Ngay = DateTime.Parse(dateTimePicker1.Text);
            tB_Phong.SoLuong = int.Parse(tbSoLuong.Text);
            try
            {
                TB_PhongP.GetInstance.themTB_Phong(tB_Phong);
                MessageBox.Show("Thêm thiết bị vào phòng thành công", "Insert Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTB_Phong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thiết bị vào phòng thất bại", "Insert Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TB_Phong tB_Phong = new TB_Phong();
            tB_Phong.MaPhong = cbPhong.SelectedValue.ToString();
            tB_Phong.MaThietBi = cbThietBi.SelectedValue.ToString();
            tB_Phong.Ngay = DateTime.Parse(dateTimePicker1.Text);
            tB_Phong.SoLuong = int.Parse(tbSoLuong.Text);
            try
            {
                TB_PhongP.GetInstance.suaTB_Phong(tB_Phong);
                MessageBox.Show("Cập nhật thiết bị thành công", "Insert Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTB_Phong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thiết bị thất bại", "Insert Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaPhong = cbPhong.SelectedValue.ToString();
            string MaTB = cbThietBi.SelectedValue.ToString();
            try
            {
                TB_PhongP.GetInstance.xoaTB_Phong(MaPhong, MaTB);
                MessageBox.Show("Xóa thiết bị thành công", "Insert Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTB_Phong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thiết bị thất bại", "Insert Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loadTB_Phong();
            loaiPhongChuaLapTB();
            loadTBMax();
            tbSoLuong.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCB();
            loadTB_Phong();
            dgvP_TB.Columns[0].HeaderText = "Mã phòng";
            dgvP_TB.Columns[1].HeaderText = "Mã Thiết bị";
            dgvP_TB.Columns[2].HeaderText = "Ngày lắp";
            dgvP_TB.Columns[3].HeaderText = "Số lượng";
            loaiPhongChuaLapTB();
            dgvChuaLapTB.Columns[0].HeaderText = "Mã phòng";
            dgvChuaLapTB.Columns[1].HeaderText = "Tên phòng";
            loadTBMax();
        }

        private void dgvP_TB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaPhong = dgvP_TB.CurrentRow.Cells[0].Value.ToString();
            cbPhong.Text = PhongP.GetInstance.layTenPhong(MaPhong);
            string MaTB = dgvP_TB.CurrentRow.Cells[1].Value.ToString();
            cbThietBi.Text = ThietBiP.GetInstance.layTenTB(MaTB);
            dateTimePicker1.Text = dgvP_TB.CurrentRow.Cells[2].Value.ToString();
            tbSoLuong.Text = dgvP_TB.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvP_TB.DataSource = TB_PhongP.GetInstance.timTheoPhong(cbPhong.SelectedValue.ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
