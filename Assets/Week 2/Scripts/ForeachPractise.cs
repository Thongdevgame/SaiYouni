using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        //BaiTap1(); // In tất cả các phần tử trong mảng
        //BaiTap2(); // Tính tổng các phần tử trong mảng
        //BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        //BaiTap4(); // Đếm số lượng số chẵn trong mảng
        //BaiTap5(); // In tất cả các chuỗi trong danh sách
        //BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        //BaiTap7(); // Tính tổng các số lẻ trong mảng
        //BaiTap8(); // In các số chẵn trong mảng
        //BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        //BaiTap10(); // Đếm số phần tử âm trong mảng
        //BaiTap11(); // In các số lớn hơn 10 trong mảng
        //BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        //BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
       //BaiTap14(); // Tìm số lớn thứ hai trong mảng
        //BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        //BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        foreach (int i in arr) Debug.Log(i);
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        int sum = 0;
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        foreach(int i in arr)
        {
            sum+= i;
        }
        Debug.Log(sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int max = arr[0];
        foreach (int i in arr)
        {
            if (i > max) max = i;
        }
        Debug.Log(max);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int count=0;
        foreach (int i in arr)
        {
            if (i%2==0) count++;
        }
        Debug.Log(count);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        List<string> name = new List<string>() { "Thong", "Vuong", "Quan", "Khanh", "Tuyen" };
        foreach (string str in name)
        {
            Debug.Log(str);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        List<string> name = new List<string>() { "Thongdeptrai", "Vuong", "Quan", "Khanh", "Tuyen" };
        string longestStr = "";
        foreach (string str in name)
        {
            if(str.Length > longestStr.Length) longestStr = str;
        }
        Debug.Log(longestStr);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int sum = 0;
        foreach(int i in arr)
        {
            if (i % 2 != 0) sum += i;
        }
        Debug.Log(sum);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        
        foreach (int i in arr)
        {
            if (i % 2 == 0) Debug.Log(i);
        }
        
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int check = 5;
        bool found = false;
        foreach (int i in arr)
        {
            if (i == check)
            {
            found = true;
            break; 
            }
        }
        if (found) Debug.Log("Found");
        else Debug.Log("Not Found");
        
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        int count = 0;
        int[] arr = { -5, -4, -3, -2, 1, 5, 4, 7, 32, 64, 75 };
        foreach (int i in arr)
        {
            if(i <0) count++;
        }
        Debug.Log(count);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        
        int[] arr = { -5, -4, -3, -2, 1, 5, 4, 7, 32, 64, 75 };
        foreach (int i in arr)
        {
            if (i > 10) Debug.Log(i);
        }
        
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        List<string> name = new List<string>() { "Thongdeptrai", "Vuong", "Quan", "Khanh", "Tuyen" };
        string shortestStr = name[0];
        foreach (string str in name)
        {
            if (str.Length < shortestStr.Length) shortestStr = str;
        }
        Debug.Log(shortestStr);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        int[] arr = { -5, -4, -3, -2, 1, 5, 4, 7, 32, 64, 75 };
        foreach (int i in arr)
        {
           Debug.Log(i*2);
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        int numMax1 = int.MinValue;
        int numMax2 = int.MinValue;
        int[] arr = { -5, -4, -3, -2, 1, 5, 4, 7, 32, 64, 75 };
        foreach (int i in arr)
        {
            if (numMax1 < i)
            {
                numMax2 = numMax1;
                numMax1 = i;
            }
            else if (numMax2 < i && i != numMax1) numMax2 = i;
        }
        Debug.Log("So lon thu 2 trong mang la: "+numMax2);
    }
    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {

        List<string> name = new List<string>() { "Thongdeptrai", "Vuong", "Quan", "Khanh", "Tuyen", "Anh", "NhuQuynh" };
        foreach (string str in name)
        {
            if (str.StartsWith("A")) Debug.Log(str);
            if(str.Length > 0 && (str[0] == 'A')) Debug.Log(str);
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        List<string> name = new List<string>() { "Thongdeptrai", "Vuong", "Quan", "Khanh", "Tuyen", "Anh", "NhuQuynh","Hello","Hellocaichoaj" };
        foreach (string str in name)
        {
            if (str.StartsWith("Hello")) Debug.Log(str);
            
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        int[] arr = { -5, -4, -3, -2, 1, 5, 4, 7, 32, 64, 75 };
        foreach (int i in arr)
        {
            if (i < 0) Debug.Log(i);
        }
        Debug.Log("======================");
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        int x = 5;
        int count = 0;
        int[] arr = { -5, -4, -3, -2, 1, 5, 4, 7, 32, 64, 75,5,5 };
        foreach (int i in arr)
        {
            if (i == x) count++;
        }
        Debug.Log(count);
        Debug.Log("======================");

    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        int[] arr = { -5, -4, -3, -2, 1, 5, 4, 7, 32, 64, 75, 5, 5 };
        List<int> list = new List<int>();
        foreach (int i in arr)
        {
            if(i>10) list.Add(i);
        }
        foreach (int i in list)
        {
            Debug.Log(i);
        }
        Debug.Log("======================");
    }
        // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
        void BaiTap20()
    {
        List<string> name = new List<string>() { "Thongdeptrai", "Vuong", "Quan", "Khanh", "Tuyen", "Anh", "NhuQuynh", "Hello", "Hellocaichoaj" };
        foreach (string str in name)
        {
            if(str.Length > 5) Debug.Log(str);
        }
        Debug.Log("======================");
    }

}
