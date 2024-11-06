using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nearby : MonoBehaviour
{
    protected float range = 5f;
    [SerializeField] protected Vector3 enemyNearest;
    [SerializeField] protected Vector2 itemNearest;
    [SerializeField] protected List<Vector3> enemies = new List<Vector3>();
    [SerializeField] protected List<Vector2> items = new List<Vector2>();
    void Start()
    {
        BaiTap1(); // Tìm kẻ địch gần nhất
        BaiTap2(); // Tìm vật phẩm gần nhất
    }

    // Bài Tập 1: Tìm Kẻ Địch Gần Nhất
    void BaiTap1()
    {
        for (int i = 0; i < 5; i++)
        {
            float posX = Random.Range(-range, range);
            float posY = Random.Range(-range, range);
            float posZ = Random.Range(-range, range);
            Vector3 newEnemy = new Vector3(posX, posY, posZ);
            this.enemies.Add(newEnemy);
        }
        Vector3 playerPos = transform.position;
        float distanceMin = Mathf.Infinity;
        foreach (Vector3 pos in enemies)
        {
            float currentDistance = Vector3.Distance(playerPos, pos);
            if (currentDistance < distanceMin)
            {
                distanceMin = currentDistance;
                enemyNearest = pos;
            }
        }
        Debug.Log("Ke dich gan nhat la : " + enemyNearest);
    }

    // Bài Tập 2: Tìm Vật Phẩm Gần Nhất
    void BaiTap2()
    {
        for (int i = 0; i < 10; i++)
        {
            float posX = Random.Range(-range, range);
            float posY = Random.Range(-range, range);
            Vector3 newItem = new Vector2(posX, posY);
            this.items.Add(newItem);
        }
        Vector2 playerPos = transform.position;
        float distanceMin = Mathf.Infinity;
        foreach (Vector2 pos in items)
        {
            float currentDistance = Vector2.Distance(playerPos, pos);
            if (currentDistance < distanceMin)
            {
                distanceMin = currentDistance;
                itemNearest = pos;
            }
        }
        Debug.Log("Vat pham gan nhat la : " + itemNearest);
    }
}