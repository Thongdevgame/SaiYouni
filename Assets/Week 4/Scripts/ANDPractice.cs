using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANDPractice : MonoBehaviour
{
    [Header("Bai tap 1: ")]
    public int tuoi = 19;
    public bool coGiayPhepLX = false;
    public int kinhNghiemLaiXe = 2;
    [Header("Bai tap 2: ")]
    public bool coVe = true;
    public bool daDangKy = true;
    public bool tienSuBenhTim = true;
    [Header("Bai tap 3: ")]
    public float diemTrungBinh = 8.0f;
    public float diemNgoaiKhoa = 9.0f;
    public bool viPhamKyLuat = false;
    [Header("Bai tap 4: ")]
    public bool emailHL = false;
    public bool daXNQuaDT = false;
    public bool daThanhToanPhiTG = false;
    [Header("Bai tap 5 : ")]
    public float diemTK = 4f;
    public int monThiTruot = 1;
    public float diemCC = 0.9f;
    [Header("Bai tap 6 : ")]
    public bool daTNDH = false;
    public int namKN = 1;
    public bool quaBaiKTNL = true;
    [Header("Bai tap 7 : ")]
    public bool coDuTien = false;
    public bool coHangTrongKho = false;
    public bool duDKTGKM = false;
    [Header("Bai tap 8 : ")]
    public int soNVHT = 10;
    public float diemTBNV = 8.5f;
    public bool dangNhapHeThongTrong7NgayQua = true;
    [Header("Bai tap 9 : ")]
    public int soNamLV = 10;
    public bool datChiTieuCongViecHangNam = true;
    public bool khongViPhamKiLuat = true;
    [Header("Bai tap 10 : ")]
    public int age = 50;
    public bool dangLaTVVip = false;
    public int soLanMuaVeTrongNam = 5;
    void Start()
    {
        BaiTap1(); // Kiểm tra tuổi, giấy phép, và kinh nghiệm
        BaiTap2(); // Kiểm tra điều kiện vào công viên giải trí
        BaiTap3(); // Điều kiện đạt học bổng
        BaiTap4(); // Kiểm tra đăng ký hợp lệ
        BaiTap5(); // Kiểm tra điều kiện thi lại
        BaiTap6(); // Xét tuyển nhân viên
        BaiTap7(); // Kiểm tra điều kiện mua hàng
        BaiTap8(); // Đủ điều kiện nhận phần thưởng
        BaiTap9(); // Kiểm tra điều kiện thăng chức
        BaiTap10(); // Điều kiện nhận vé miễn phí
    }

    // Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm
    void BaiTap1()
    {
        // Nhập tuổi, giấy phép lái xe, và kinh nghiệm lái xe
        // Kiểm tra nếu người dùng trên 18 tuổi, có giấy phép lái xe, và có kinh nghiệm trên 1 năm
        if (tuoi > 18 && coGiayPhepLX == true && kinhNghiemLaiXe > 1)
            Debug.Log("Nguoi dung du dieu kien lai xe");
        else 
            Debug.Log("Nguoi dung khong du dieu kien lai xe");
    }

    // Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí
    void BaiTap2()
    {
        // Nhập thông tin về vé, đã đăng ký trước, và tiền sử bệnh tim
        // Kiểm tra nếu người dùng có vé, đã đăng ký trước, và không có tiền sử bệnh tim
        if ((coVe = true) && (daDangKy = true) && (tienSuBenhTim = false))
            Debug.Log("Duoc vao cong vien");
        else
            Debug.Log("Khong du dieu kien vao cong vien giai tri");
    }

    // Bài Tập 3: Điều Kiện Đạt Học Bổng
    void BaiTap3()
    {
        // Nhập điểm trung bình, điểm hoạt động ngoại khóa, và kiểm tra kỷ luật
        // Kiểm tra nếu điểm trung bình >= 9.0, điểm ngoại khóa >= 8.0, và không vi phạm kỷ luật
        if (diemTrungBinh >= 9 && diemNgoaiKhoa >= 8 && viPhamKyLuat == true)
            Debug.Log("Hoc sinh dat hoc bong");
        else
            Debug.Log("Hoc sinh khong dat hoc bong");
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
        if (emailHL == true && daXNQuaDT == true && daThanhToanPhiTG == true)
            Debug.Log("Don dang ki hop le");
        else
            Debug.Log("Don dang ki khong hop le");
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
        if (diemTK < 5 && monThiTruot <= 2 && diemCC > 0.75)
            Debug.Log("Hoc sinh duoc phep thi lai");
        else
            Debug.Log("hoc sinh khong duoc thi lai");
    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
        if (daTNDH == true && namKN >= 2 && quaBaiKTNL == true)
            Debug.Log("Ung vien duoc tuyen dung");
        else
            Debug.Log("Ung vien khong duoc tuyen dung");
    }

    // Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap7()
    {
        // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
        if (coDuTien == true && coHangTrongKho == true && duDKTGKM == true)
            Debug.Log("Nguoi dung co the mua san pham");
        else
            Debug.Log("Nguoi dung khong the mua san pham");
    }

    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
        if (soNVHT >= 10 && diemTBNV >= 8 && dangNhapHeThongTrong7NgayQua == true)
            Debug.Log("Nguoi dung du dieu kien nhan phan thuong");
        else
            Debug.Log("Nguoi dung khong du dieu kien nhan phan thuong");
    }

    // Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap9()
    {
        // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
        if (soNamLV > 5 && datChiTieuCongViecHangNam == true && khongViPhamKiLuat == true)
            Debug.Log("Nhan vien du dieu kien thang chuc");
        else
            Debug.Log("Nhan vien khong du dieu kien thang chuc");
    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm
        if (age > 60 && dangLaTVVip == true && soLanMuaVeTrongNam >= 3)
            Debug.Log("Nguoi dung nhan duoc ve mien phi");
        else
            Debug.Log("Nguoi dung khong nhan duoc ve mien phi");
    }
}
