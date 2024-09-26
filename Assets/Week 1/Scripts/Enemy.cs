using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int damage;
    public float speed;
    public bool isAlive;
    public Vector3 position;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Attack(Player player)
    {
        if (isAlive)
        {
            player.TakeDamage(damage);
        }
    }

    public void Move(Vector3 direction)
    {
        position += direction * speed * Time.deltaTime;
    }

    public void Die()
    {
        isAlive = false;
        // Th?c hi?n các hành ??ng khi k? ??ch ch?t, nh? kích ho?t hi?u ?ng, lo?i b? kh?i b?n ??, v.v.
    }

    public void Respawn(Vector3 newPosition)
    {
        position = newPosition;
        health = 100;  // H?i ??y máu
        isAlive = true;
    }
}
