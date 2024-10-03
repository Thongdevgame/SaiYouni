using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    void Start()
    {
        BaiTap1();  // In các số từ 1 đến 100
        BaiTap2();  // Tính tổng các số từ 1 đến 50
        BaiTap3();  // In các số chẵn từ 1 đến 100
        BaiTap4();  // Tính tích các số từ 1 đến 10
        BaiTap5();  // Tìm số lớn nhất trong một mảng
        BaiTap6();  // Tính tổng các số lẻ từ 1 đến 100
        BaiTap7();  // Đảo ngược chuỗi
        //BaiTap8();  // In bảng cửu chương
        //BaiTap9();  // Đếm các số nguyên dương trong mảng
        //BaiTap10(); // In tam giác số
        //BaiTap11(); // Tìm phần tử nhỏ nhất trong mảng
        //BaiTap12(); // In dãy Fibonacci
        //BaiTap13(); // Tính giai thừa của một số
        //BaiTap14(); // In các số từ n đến 1
        //BaiTap15(); // Tính tổng các phần tử trong mảng
        //BaiTap16(); // Kiểm tra số nguyên tố
        //BaiTap17(); // In ra các số chia hết cho 3
        //BaiTap18(); // Tính tổng các số chẵn trong mảng
        //BaiTap19(); // Tính trung bình cộng của mảng
        //BaiTap20(); // Đếm số ký tự hoa trong chuỗi
    }

    // Bài Tập 1: In các số từ 1 đến 100
    void BaiTap1()
    {
       for(int i = 1;i<= 100; i++)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 2: Tính tổng các số từ 1 đến 50
    void BaiTap2()
    {
        int sum = 0;
        for (int i = 1; i <= 50; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
    }

    // Bài Tập 3: In các số chẵn từ 1 đến 100
    void BaiTap3()
    {
        for (int i = 1; i <= 100; i++)
        {
           if(i%2 == 0) Debug.Log(i);
        }
    }

    // Bài Tập 4: Tính tích các số từ 1 đến 10
    void BaiTap4()
    {
        int mul = 1;
        for(int i = 1;i<= 10; i++)
        {
            mul *= i;
        }
        Debug.Log(mul);
    }

    // Bài Tập 5: Tìm số lớn nhất trong mảng
    void BaiTap5()
    {
        int max = int.MinValue;
        int[] arr = { -5, -4, -3, -2, 1, 5, 4, 7, 32, 64, 75, 5, 5 };
        for(int i = 0;i< arr.Length; i++)
        {
            if (arr[i]> max) max = arr[i];
        }
        Debug.Log(max);
    }

    // Bài Tập 6: Tính tổng các số lẻ từ 1 đến 100
    void BaiTap6()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0) sum += i;
        }
        Debug.Log(sum);
    }

    // Bài Tập 7: Đảo ngược chuỗi
    void BaiTap7()
    {
        string originalStr = "Xin chao minh la Thong";
        string reversedStr = "";
        for(int i = originalStr.Length -1; i>=0;i--)
        {
            reversedStr += originalStr[i];
        }
        Debug.Log(reversedStr);
    }

    // Bài Tập 8: In bảng cửu chương
    void BaiTap8()
    {
        
    }

    // Bài Tập 9: Đếm các số nguyên dương trong mảng
    void BaiTap9()
    {
        
    }

    // Bài Tập 10: In tam giác số
    void BaiTap10()
    {
        
        }
    

    // Bài Tập 11: Tìm phần tử nhỏ nhất trong mảng
    void BaiTap11()
    {
        
    }

    // Bài Tập 12: In dãy Fibonacci
    void BaiTap12()
    {
        
    }

    // Bài Tập 13: Tính giai thừa của một số
    void BaiTap13()
    {
        
    }

    // Bài Tập 14: In các số từ n đến 1
    void BaiTap14()
    {
       
    }

    // Bài Tập 15: Tính tổng các phần tử trong mảng
    void BaiTap15()
    {
        
    }

    // Bài Tập 16: Kiểm tra số nguyên tố
    void BaiTap16()
    {
        
    }

    // Bài Tập 17: In các số chia hết cho 3
    void BaiTap17()
    {
        
    }

    // Bài Tập 18: Tính tổng các số chẵn trong mảng
    void BaiTap18()
    {
        
    }

    // Bài Tập 19: Tính trung bình cộng của mảng
    void BaiTap19()
    {
       
    }

    // Bài Tập 20: Đếm số ký tự hoa trong chuỗi
    void BaiTap20()
    {
        
    }
}
