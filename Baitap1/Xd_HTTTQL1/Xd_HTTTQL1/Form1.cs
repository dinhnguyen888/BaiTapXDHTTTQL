using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xd_HTTTQL1
{
    public partial class Form1 : Form
    {
        // Class-level variables
        private Models.HoaDon hoaDon;
        private List<Models.SanPham> danhSachSanPham;
        private int indexSelected = -1;

        public Form1()
        {
            InitializeComponent();

            // Add form load event handler
            this.Load += new System.EventHandler(this.Form1_Load);

            // Connect event handlers for DataGridView
            DonHangTable.CellClick += new DataGridViewCellEventHandler(this.DonHangTable_CellClick);
        }

        // Load form 
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load hoa don va danh sach san pham
            hoaDon = new Models.HoaDon();
            danhSachSanPham = new List<Models.SanPham>();

            SetupDataGridView();

            NgayLapHoaDonDate.Value = DateTime.Now;
        }

        private void SetupDataGridView()
        {
            DonHangTable.Columns.Clear();
            DonHangTable.Columns.Add("STT", "STT");
            DonHangTable.Columns.Add("TenSanPham", "Sản phẩm");
            DonHangTable.Columns.Add("DonGia", "Đơn giá");
            DonHangTable.Columns.Add("SoLuong", "Số lượng");
            DonHangTable.Columns.Add("ThanhTien", "Thành tiền");

            DonHangTable.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            DonHangTable.Columns["DonGia"].DefaultCellStyle.Format = "N0";
        }

      

        private void DonGiaBox_TextChanged(object sender, EventArgs e)
        {
            // Ham kiem tra du lieu nhap vao
            if (!string.IsNullOrEmpty(DonGiaBox.Text) && !decimal.TryParse(DonGiaBox.Text, out _))
            {
                MessageBox.Show("Đơn giá phải là số!");
                DonGiaBox.Text = "";
            }
        }

        private void SoLuongBox_TextChanged(object sender, EventArgs e)
        {
            // Nhu tren
            if (!string.IsNullOrEmpty(SoLuongBox.Text) && !decimal.TryParse(SoLuongBox.Text, out _))
            {
                MessageBox.Show("Số lượng phải là số!");
                SoLuongBox.Text = "";
            }
        }

        private void ThemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check Input
                if (string.IsNullOrWhiteSpace(SanPhamBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm!");
                    SanPhamBox.Focus();
                    return;
                }

                if (!long.TryParse(DonGiaBox.Text, out long donGia) || donGia <= 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ!");
                    DonGiaBox.Focus();
                    return;
                }

                if (!long.TryParse(SoLuongBox.Text, out long soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                    SoLuongBox.Focus();
                    return;
                }

                
                Models.SanPham sanPham = new Models.SanPham(SanPhamBox.Text, donGia, soLuong);

            
                danhSachSanPham.Add(sanPham);
       
                RefreshDataGridView();

                ClearProductInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaBtn_Click(object sender, EventArgs e)
        {
            if (indexSelected >= 0 && indexSelected < danhSachSanPham.Count)
            {
                danhSachSanPham.RemoveAt(indexSelected);

                RefreshDataGridView();

                ClearProductInputs();

                indexSelected = -1;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
            }
        }

        private void SuaBtn_Click(object sender, EventArgs e)
        {
            if (indexSelected >= 0 && indexSelected < danhSachSanPham.Count)
            {
                try
                {
                    // Check input
                    if (string.IsNullOrWhiteSpace(SanPhamBox.Text))
                    {
                        MessageBox.Show("Vui lòng nhập tên sản phẩm!");
                        SanPhamBox.Focus();
                        return;
                    }

                    if (!long.TryParse(DonGiaBox.Text, out long donGia) || donGia <= 0)
                    {
                        MessageBox.Show("Đơn giá không hợp lệ!");
                        DonGiaBox.Focus();
                        return;
                    }

                    if (!long.TryParse(SoLuongBox.Text, out long soLuong) || soLuong <= 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        SoLuongBox.Focus();
                        return;
                    }

                    Models.SanPham sanPham = new Models.SanPham(SanPhamBox.Text, donGia, soLuong);
                    danhSachSanPham[indexSelected] = sanPham;

                    RefreshDataGridView();

                    ClearProductInputs();

                    indexSelected = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
            }
        }

        private void InHoaDonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Xac nhan du lieu cua hoa don
                if (string.IsNullOrWhiteSpace(SoHoaDonBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập số hóa đơn!");
                    SoHoaDonBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(KhachHangBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng!");
                    KhachHangBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(NhanVienBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên bán hàng!");
                    NhanVienBox.Focus();
                    return;
                }

                if (danhSachSanPham.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào hóa đơn!");
                    return;
                }

                hoaDon = new Models.HoaDon()
                {
                    SoHoaDon = SoHoaDonBox.Text,
                    NgayLap = NgayLapHoaDonDate.Value,
                    KhachHang = KhachHangBox.Text,
                    DienThoai = DienThoaiBox.Text,
                    DiaChi = DiaChiBox.Text,
                    NhanVienBanHang = NhanVienBox.Text,
                    DanhSachSanPham = new List<Models.SanPham>(danhSachSanPham)
                };

                ShowInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamLaiBtn_Click(object sender, EventArgs e)
        {
            // Clear het du lieu
            SoHoaDonBox.Clear();
            NgayLapHoaDonDate.Value = DateTime.Now;
            KhachHangBox.Clear();
            DienThoaiBox.Clear();
            DiaChiBox.Clear();
            NhanVienBox.Clear();

            // Clear het input
            ClearProductInputs();

            danhSachSanPham.Clear();

            RefreshDataGridView();

            indexSelected = -1;
        }

   

        private void DonHangTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachSanPham.Count)
            {
                indexSelected = e.RowIndex;

                Models.SanPham selectedProduct = danhSachSanPham[indexSelected];
                SanPhamBox.Text = selectedProduct.TenSanPham;
                DonGiaBox.Text = selectedProduct.DonGia.ToString();
                SoLuongBox.Text = selectedProduct.SoLuong.ToString();
            }
        }

        private void ClearProductInputs()
        {
            SanPhamBox.Clear();
            DonGiaBox.Clear();
            SoLuongBox.Clear();
            SanPhamBox.Focus();
        }

        private void RefreshDataGridView()
        {
            DonHangTable.Rows.Clear();

            for (int i = 0; i < danhSachSanPham.Count; i++)
            {
                Models.SanPham sanPham = danhSachSanPham[i];
                DonHangTable.Rows.Add(
                    i + 1,
                    sanPham.TenSanPham,
                    sanPham.DonGia,
                    sanPham.SoLuong,
                    sanPham.ThanhTien
                );
            }

            // Tinh Tong tien
            // Show ra TriGiaHoaDonBox
            decimal tongTien = danhSachSanPham.Sum(sp => (decimal)sp.ThanhTien);

            if (Controls.Find("TongTienLabel", true).Length > 0)
            {
                Label TongTienLabel = (Label)Controls.Find("TongTienLabel", true)[0];
                TongTienLabel.Text = string.Format("{0:N0} VND", tongTien);
            }
            TriGiaHoaDonBox.Text = string.Format("{0:N0} VND", tongTien);
        }

        private void ShowInvoice()
        {
            // Tao hoa don va show ra
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("In hoá đơn");
            sb.AppendLine();
            sb.AppendLine($"Hoá đơn: {hoaDon.SoHoaDon}");
            sb.AppendLine($"Ngày lập hoá đơn: {hoaDon.NgayLap.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Nhân viên bán hàng: {hoaDon.NhanVienBanHang}");
            sb.AppendLine($"Khách hàng: {hoaDon.KhachHang}");

            if (!string.IsNullOrEmpty(hoaDon.DienThoai))
            {
                sb.AppendLine($"Điện thoại khách hàng: {hoaDon.DienThoai}");
            }

            if (!string.IsNullOrEmpty(hoaDon.DiaChi))
            {
                sb.AppendLine($"Địa chỉ khách hàng: {hoaDon.DiaChi}");
            }

            sb.AppendLine("---------------Chi tiết hoá đơn---------------");
            sb.AppendLine("STT\tSản phẩm\tĐơn giá\tSố lượng\tThành tiền");

            for (int i = 0; i < hoaDon.DanhSachSanPham.Count; i++)
            {
                Models.SanPham sp = hoaDon.DanhSachSanPham[i];
                sb.AppendLine($"{i + 1}\t{sp.TenSanPham}\t{sp.DonGia:N0}\t{sp.SoLuong}\t{sp.ThanhTien:N0}");
            }

            sb.AppendLine($"--------------- Tổng trị giá hoá đơn: {hoaDon.TinhTriGia():N0} ---------------");

            MessageBox.Show(sb.ToString(), "Hoá đơn bán hàng", MessageBoxButtons.OK);
        }

        private void TriGiaHoaDonBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}