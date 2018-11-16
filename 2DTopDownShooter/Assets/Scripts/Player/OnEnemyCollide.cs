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
        if(collision.CompareTag("Enemy")){
            doDamage(25);
        }
    }

    public void doDamage(int damage){

        if(currentHealth - damage < 0){

            currentHealth = 0;

        } else {

            currentHealth -= damage;
        }

    }
}
