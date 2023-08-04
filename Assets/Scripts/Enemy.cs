using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    private void Update()
    {
        if(health <0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == ("Player"))
        {
            SceneManager.LoadScene(1);
        }

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
