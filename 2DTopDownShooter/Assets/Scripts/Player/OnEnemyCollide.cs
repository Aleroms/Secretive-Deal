using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnemyCollide : MonoBehaviour {
    public int startingHealth = 1;
    public int currentHealth;
	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            currentHealth -= 1;
            Debug.Log("Hit by enemy");
            collision.gameObject.GetComponent<enemyBehavior>().reduceHealth(1);
        }
    }
}
