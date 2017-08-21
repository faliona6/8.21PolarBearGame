using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Health health;
    private bool hasCollided = false;

    // Use this for initialization
    void Awake ()
    {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!hasCollided)
            {
                hasCollided = true;
                health.ChangeHealth(-1);
                Destroy(gameObject);
            }
        }
    }
}
