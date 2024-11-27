using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPratices : MonoBehaviour
{
    [Header("Bai 1: ")]
    [SerializeField] int data = 1;
    [Header("Bai 2: ")]
    [SerializeField] int[] array = { 1, 2, 2, 6, 4, 5 };
    [SerializeField] string[] array2 = { "Hello", "NVT", "NguyenLuc", "NgThienDucAnh" };
    [Header("Bai 3: ")]
    [SerializeField] string a = "Xin chao";
    [SerializeField] string b = "Tam biet";
    [Header("Bai 4: ")]
    [SerializeField] List<string> list = new List<string>();


    void Start()
    {
       
        // Bai 1
        Bai1<int> bai1 = new();
        bai1.data = data;
        Debug.Log("Bai 1: "+ bai1.data  );

        // Bai 2
        Bai2<int> bai2 = new();
        int max = bai2.FindMax(array);
        Bai2<string> b2 = new();
        string max2 = b2.FindMax(array2);
        Debug.Log("max : " + max + "; max2 : " + max2);

        //Bai 3
        Bai3<string> bai3 = new();
        bai3.Swap(ref a, ref b);
        Debug.Log(a +" "+ b);

        //Bai 4
        Bai4<int> bai4 = new();
        bai4.AddItem(1);
        bai4.RemoveItem(2);
        bai4.DisplayIteams();

        //Bai 5
        Bai5<string> bai5 = new();
        bai5.Check(array2, "Hello");
    }
    void Update() { }
}