using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class Health : MonoBehaviour
{

    public int startingHealth = 3;
    public int currentHealth;
    public GameObject[] heartsLeft;


    void Start()
    {
        currentHealth = startingHealth;
        for (int i = 0; i < currentHealth; i++)
        {
            heartsLeft[i].GetComponent<SpriteRenderer>().enabled = true;
        }
    }


    void Update()
    {

    }


    public void ChangeHealth(int amount)
    {
        currentHealth += amount;

        for (int i = startingHealth - 1; i > currentHealth - 1; i--)
        {
            GameObject heartObj = heartsLeft[i];
            heartObj.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}