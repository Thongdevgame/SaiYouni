using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionPractice : MonoBehaviour
{
    [Header("Bai tap 1: Tinh giai thua cua mot so")]
    public int a = 5;
    [Header("Bai tap 2: Tinh tong cua cac so tu 1 den n")]
    public int b = 10;
    [Header("Bai tap 3: Chuoi Fibonacci")]
    public int c = 6;
    [Header("Bai tap 4: Dem nguoc tu N ve 1")]
    public int d = 5;
    [Header("Bai tap 5: UCLN cua hai so")]
    public int e1 = 24;
    public int e2 = 36;
    void Start()
    {
        BaiTap1(); // Tính giai thừa của một số
        BaiTap2(); // Tính tổng các số từ 1 đến n
        BaiTap3(); // Chuỗi Fibonacci
        BaiTap4(); // Đếm ngược từ n về 1
        BaiTap5(); // Tìm UCLN của hai số
    }

    // Bài Tập 1: Tính Giai Thừa Của Một Số
    void BaiTap1()
    {
        int result = GiaiThua(a);
        Debug.Log("Giai thừa của " + a + " là: " + result);
    }
    int GiaiThua(int n)
    {
        if (n <= 1) return 1; // Điều kiện dừng
        return n * GiaiThua(n - 1); // Đệ quy
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    void BaiTap2()
    {
        int result = SumToN(b);
        Debug.Log("Tổng từ 1 đến " + b + " là: " + result);
    }

    int SumToN(int n)
    {
        if (n <= 1) return n; // Điều kiện dừng
        return n + SumToN(n - 1); // Đệ quy
    }

    // Bài Tập 3: Chuỗi Fibonacci
    void BaiTap3()
    {
        string output = "Chuỗi Fibonacci: ";

        for (int i = 1; i <= c; i++)
        {
            output += Fibonacci(i) + " "; 
        }

        Debug.Log(output); 
    }

    int Fibonacci(int n)
    {
        if (n <= 1) return n; // Điều kiện dừng
        return Fibonacci(n - 1) + Fibonacci(n - 2); // Đệ quy
    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4()
    {
        string output = "Đếm ngược: ";
        Countdown(d, ref output);
        Debug.Log(output);
    }

    void Countdown(int n, ref string output)
    {
        if (n < 1) return; 
        output += n + " "; // Thêm số hiện tại vào chuỗi
        Countdown(n - 1, ref output); // Gọi đệ quy với n - 1
    }


    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    void BaiTap5()
    {
        int result = GCD(e1, e2);
        Debug.Log("Ước chung lớn nhất của " + e1 + " và " + e2 + " là: " + result);
    }

    int GCD(int a, int b)
    {
        if (b == 0) return a; // Điều kiện dừng
        return GCD(b, a % b); // Đệ quy theo thuật toán Euclid
    }
}