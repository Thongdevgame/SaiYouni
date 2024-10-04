using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    // Nhập một số từ bàn phím
    // Kiểm tra xem số đó là số dương, âm hay bằng 0
    void BaiTap1()
    {
        int n = 5;
        if (n == 0) Debug.Log(n + " la so 0");
        else if (n > 0) Debug.Log(n + " la so duong");
        else if (n < 0) Debug.Log(n + " la so am");
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    // Nhập một số từ bàn phím
    // Kiểm tra xem số đó là số chẵn hay lẻ
    void BaiTap2()
    {
        int n = 5;
        if (n %2 == 0) Debug.Log(n + " la so chan");
        else if (n %2 !=0) Debug.Log(n + " la so le");
        
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    // Nhập điểm trung bình của học sinh từ bàn phím
    // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
    void BaiTap3()
    {
        float n = 8.5f;
        if (n > 5.0f) Debug.Log("Hoc sinh do");
        else Debug.Log("Hoc sinh truot");
        
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    // Nhập hai số nguyên từ bàn phím
    // Kiểm tra và in ra số lớn nhất trong hai số đó
    void BaiTap4()
    {
        int x = 100;
        int y = 200;
        if (x > y) Debug.Log(x);
        else Debug.Log(y);
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
    // Kiểm tra xem người dùng có đủ tiền mua hàng không
    void BaiTap5()
    {
        int availableMoney = 100;
        int productPrice = 47;
        if (availableMoney >= productPrice)
        {
            Debug.Log("You have enough money to purchase the product.");
        }
        else
        {
            Debug.Log("You do not have enough money to purchase the product.");
        }
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    // Nhập một năm từ bàn phím
    // Kiểm tra xem năm đó có phải là năm nhuận hay không
    void BaiTap6()
    {
        
        int year = 2003;
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) Debug.Log("Nam nhuan");
        else Debug.Log("Khong phai nam nhuan");
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    // Nhập tuổi của người mua vé từ bàn phím
    // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
    // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
    void BaiTap7()
    {
        int n = 20;
        if (n < 18) Debug.Log("Gia ve la 50,000 dong");
        else Debug.Log("Gia ve la 100,000 dong");
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    // Nhập điểm trung bình của học sinh từ bàn phím
    // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
    void BaiTap8()
    {
        
        float gpa = 8.8f;
        if (gpa >= 9.0) Debug.Log("Hoc sinh dat danh hieu xuat sac");
        else Debug.Log("Hoc sinh khong dat danh hieu hoc sinh xuat sac");
    }

    // Bài Tập 9: So Sánh Ba Số
    // Nhập ba số nguyên từ bàn phím
    // Kiểm tra và in ra số lớn nhất trong ba số đó
    void BaiTap9()
    {
        int x = 10;
        int y = 20;
        int z = 30;
        if (x > y && x > z) Debug.Log(x);
        else if (y > x && y > z) Debug.Log(y);
        else Debug.Log(z);
    }

    // Bài Tập 10: Tính Tiền Lương
    // Nhập số giờ làm việc và mức lương cố định từ bàn phím
    // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
    // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
    void BaiTap10()
    {
        int gioLamViec = 50;
        int luongCoBan = 25000;
        int luongNgoaiGio = 35000;
        if (gioLamViec > 40) Debug.Log("Luong: " + (40 * luongCoBan + (gioLamViec - 40) * luongNgoaiGio));
        else Debug.Log("Luong: " + (gioLamViec * luongCoBan));
        
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
    // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
    void BaiTap11()
    {
        int age = 20; 
        bool hasMembership = true; 

        if (age >= 18 && hasMembership)
        {
            Debug.Log("You can enter the club.");
        }
        else
        {
            Debug.Log("You cannot enter the club.");
        }
    }

    // Bài Tập 12: Phân Loại Học Sinh
    // Nhập điểm trung bình của học sinh từ bàn phím
    // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
    void BaiTap12()
    {
        float averageScore = 8.5f;
        if (averageScore >= 9.0f)
            Debug.Log("Xuất sắc");
        else if (averageScore >= 7.0f)
            Debug.Log("Khá");
        else if (averageScore >= 5.0f)
            Debug.Log("Trung bình");
        else
            Debug.Log("Yếu");
    }

    // Bài Tập 13: Tính Tiền Điện
    // Nhập số điện tiêu thụ từ bàn phím
    // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
    void BaiTap13()
    {
        int electricityUsage = 120; 
        int bill;
        if (electricityUsage <= 100)
            bill = electricityUsage * 1500;
        else
            bill = 100 * 1500 + (electricityUsage - 100) * 2000;

        Debug.Log("Tiền điện: " + bill + " đồng");
    }


    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    // Nhập số năm làm việc và đánh giá công việc
    // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
    void BaiTap14()
    {
        int yearsWorked = 6; 
        bool goodPerformance = true; 
        if (yearsWorked > 5 && goodPerformance)
            Debug.Log("Eligible for promotion.");
        else
            Debug.Log("Not eligible for promotion.");
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    // Nhập giá trị đơn hàng từ bàn phím
    // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
    void BaiTap15()
    {
        float orderValue = 600000; 
        if (orderValue >= 500000)
            Debug.Log("Free shipping!");
        else
            Debug.Log("No free shipping.");
    }


    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    // Nhập thu nhập từ bàn phím
    // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
    void BaiTap16()
    {
        float income = 12000000;
        float tax;
        if (income <= 5000000)
            tax = income * 0.05f;
        else if (income <= 10000000)
            tax = income * 0.1f;
        else
            tax = income * 0.2f;
        Debug.Log("Tax to pay: " + tax + " VND");
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    // Nhập điểm của 3 bài kiểm tra từ bàn phím
    // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
    void BaiTap17()
    {
        float test1 = 7.0f; 
        float test2 = 6.5f;
        float test3 = 8.0f;
        float average = (test1 + test2 + test3) / 3;
        if (average >= 5.0f)
            Debug.Log("Passed.");
        else
            Debug.Log("Failed.");
    }


    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
    void BaiTap18()
    {
        int currentStock = 90; 
        int maxCapacity = 100;
        if (currentStock < maxCapacity)
            Debug.Log("Can order more stock.");
        else
            Debug.Log("Stock is full.");
    }


    // Bài Tập 19: Tìm Số Lớn Hơn 10
    // Nhập một số từ bàn phím
    // Kiểm tra xem số đó có lớn hơn 10 hay không
    void BaiTap19()
    {
        int number = 15; 
        if (number > 10)
            Debug.Log(number + " is greater than 10.");
        else
            Debug.Log(number + " is not greater than 10.");
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
    // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
    void BaiTap20()
    {
        float finalGrade = 7.5f; 
        bool passedPreviousCourse = true;
        if (finalGrade >= 6.0f && passedPreviousCourse)
            Debug.Log("Eligible to enroll in the advanced course.");
        else
            Debug.Log("Not eligible for the advanced course.");
    }

}
