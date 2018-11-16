using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnEnemyCollide : MonoBehaviour {
    public int startingHealth = 100;
    public int currentHealth;
    public Text healthMeter;

	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
        //healthMeter.text = "Health: " + currentHealth;
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            currentHealth -= 25;
            Debug.Log("Hit by enemy");
            collision.gameObject.GetComponent<enemyBehavior>().reduceHealth(1);
        }
    }
}
