using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    int health;
    public int StartingHealth = 100;
    public int Lives = 5;
    public int Ammo = 100;


	void Start ()
    {
        health = StartingHealth;
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("asteroid"))
        {
            health = collision.gameObject.GetComponent<EnemyData>().damage;
        }

    }
    void Update ()
    {
        if(health <= 0)
        {
            Lives--;
            health = StartingHealth;
        }
        if (Lives <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

		
	}
}
