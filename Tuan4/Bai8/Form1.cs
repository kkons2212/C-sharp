namespace Bai8;

public partial class Form1 : Form
{
    private MangSoNguyen mang = new MangSoNguyen();

    public Form1()
    {
        InitializeComponent();
        this.Text = "Mảng Số Nguyên";

        btnThucHien.Click += btnThucHien_Click;
        btnTong.Click += btnTong_Click;
        btnMaxMin.Click += btnMaxMin_Click;
        btnReset.Click += btnReset_Click;
        btnThoat.Click += btnThoat_Click;
        this.FormClosing += Form1_FormClosing;
    }

    // Nút Thực Hiện (Nạp mảng, Sắp xếp, Tìm kiếm, Xóa, Thêm, Thay thế)
    private void btnThucHien_Click(object sender, EventArgs e)
    {
        // 1. Kiểm tra và nạp mảng từ ô Nhập mảng
        if (!mang.NhapChuoi(txtNhapMang.Text))
        {
            MessageBox.Show("Vui lòng nhập dãy số nguyên hợp lệ (cách nhau bằng khoảng trắng hoặc dấu phẩy)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNhapMang.Focus();
            return;
        }

        // 2. Xử lý Sắp xếp
        if (rdoTang.Checked) mang.SapXepTang();
        else if (rdoGiam.Checked) mang.SapXepGiam();

        // 3. Xử lý Tìm kiếm 
        if (rdoTimGiaTri.Checked && int.TryParse(txtTimGiaTri.Text, out int valTim))
        {
            int vt = mang.TimViTriCuaGiaTri(valTim);
            txtTimOutput.Text = vt != -1 ? vt.ToString() : "Không thấy";
        }
        else if (rdoTimViTri.Checked && int.TryParse(txtTimViTri.Text, out int idxTim))
        {
            int val = mang.TimGiaTriTaiViTri(idxTim);
            txtTimOutput.Text = val != int.MinValue ? val.ToString() : "Vị trí sai";
        }

        // 4. Xử lý Xóa
        if (rdoXoaGiaTri.Checked && int.TryParse(txtXoaInput.Text, out int valXoa))
        {
            mang.XoaGiaTri(valXoa);
        }
        else if (rdoXoaViTri.Checked && int.TryParse(txtXoaInput.Text, out int idxXoa))
        {
            mang.XoaTaiViTri(idxXoa);
        }

        // 5. Xử lý Thêm
        if (int.TryParse(txtThemVal.Text, out int valThem) && int.TryParse(txtThemIdx.Text, out int idxThem))
        {
            mang.ThemTaiViTri(valThem, idxThem);
        }

        // 6. Xử lý Thay thế
        if (rdoThayGiaTri.Checked && int.TryParse(txtThayCu.Text, out int valOld) && int.TryParse(txtThayMoi.Text, out int valNew1))
        {
            mang.ThayTheGiaTri(valOld, valNew1);
        }
        else if (rdoThayViTri.Checked && int.TryParse(txtThayCu.Text, out int idxOld) && int.TryParse(txtThayMoi.Text, out int valNew2))
        {
            mang.ThayTheTaiViTri(idxOld, valNew2);
        }

        
        txtKetQuaMang.Text = mang.InMang();
    }

    // Nút Tính Tổng
    private void btnTong_Click(object sender, EventArgs e)
    {
        if (mang.DanhSach.Count == 0 && !mang.NhapChuoi(txtNhapMang.Text))
        {
            MessageBox.Show("Vui lòng nhập mảng số nguyên trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        txtTongMang.Text = mang.TongMang().ToString();
        txtTongChan.Text = mang.TongChan().ToString();
        txtTongLe.Text = mang.TongLe().ToString();
    }

    // Nút Max - Min
    private void btnMaxMin_Click(object sender, EventArgs e)
    {
        if (mang.DanhSach.Count == 0 && !mang.NhapChuoi(txtNhapMang.Text))
        {
            MessageBox.Show("Vui lòng nhập mảng số nguyên trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        txtMax.Text = mang.Max().ToString();
        txtMin.Text = mang.Min().ToString();
    }

   
    private void btnReset_Click(object sender, EventArgs e)
    {
        mang.DanhSach.Clear();
        txtNhapMang.Clear();
        txtKetQuaMang.Clear();

        txtTimGiaTri.Clear();
        txtTimViTri.Clear();
        txtTimOutput.Clear();

        txtXoaInput.Clear();

        txtThemVal.Clear();
        txtThemIdx.Clear();
       
        txtTongMang.Clear();
        TongChan.Text = string.Empty;
        txtTongLe.Clear();

        txtMax.Clear();
        txtMin.Clear();

        txtThayCu.Clear();
        txtThayMoi.Clear();

        txtNhapMang.Focus();
    }

    
    private void btnThoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void groupBox1_Enter(object sender, EventArgs e) { }
    private void label8_Click(object sender, EventArgs e) { }
    private void label1_Click(object sender, EventArgs e) { }
    private void textBox3_TextChanged(object sender, EventArgs e) { }
    private void textBox5_TextChanged(object sender, EventArgs e) { }
    private void textBox6_TextChanged(object sender, EventArgs e) { }
    private void label11_Click(object sender, EventArgs e) { }
}

// Class  Mảng Số Nguyên
public class MangSoNguyen
{
    private List<int> a = new List<int>();

    public List<int> DanhSach => a;

    public bool NhapChuoi(string input)
    {
        a.Clear();
        if (string.IsNullOrWhiteSpace(input)) return false;

        string[] parts = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var part in parts)
        {
            if (int.TryParse(part, out int val))
            {
                a.Add(val);
            }
            else
            {
                return false;
            }
        }
        return a.Count > 0;
    }

    public string InMang() => string.Join(" ", a);

    public void SapXepTang() => a.Sort();
    public void SapXepGiam() { a.Sort(); a.Reverse(); }

    public int TimViTriCuaGiaTri(int val) => a.IndexOf(val);
    public int TimGiaTriTaiViTri(int index) => (index >= 0 && index < a.Count) ? a[index] : int.MinValue;

    public bool XoaGiaTri(int val) => a.Remove(val);
    public bool XoaTaiViTri(int index)
    {
        if (index >= 0 && index < a.Count)
        {
            a.RemoveAt(index);
            return true;
        }
        return false;
    }

    public bool ThemTaiViTri(int val, int index)
    {
        if (index >= 0 && index <= a.Count)
        {
            a.Insert(index, val);
            return true;
        }
        return false;
    }

    public long TongMang() => a.Select(x => (long)x).Sum();
    public long TongChan() => a.Where(x => x % 2 == 0).Select(x => (long)x).Sum();
    public long TongLe() => a.Where(x => x % 2 != 0).Select(x => (long)x).Sum();

    public int Max() => a.Count > 0 ? a.Max() : 0;
    public int Min() => a.Count > 0 ? a.Min() : 0;

    public bool ThayTheGiaTri(int oldVal, int newVal)
    {
        int idx = a.IndexOf(oldVal);
        if (idx != -1)
        {
            a[idx] = newVal;
            return true;
        }
        return false;
    }

    public bool ThayTheTaiViTri(int index, int newVal)
    {
        if (index >= 0 && index < a.Count)
        {
            a[index] = newVal;
            return true;
        }
        return false;
    }
}