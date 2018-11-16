using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour {

    PickupsManager pickup;
    string CurrentPickup;
    public GameObject currentObject;
    public Image pickupSprite;
    public Sprite bombSprite;
    public Text pickupCount;
	// Use this for initialization
	void Start () {
        pickup = gameObject.GetComponent<PickupsManager>();
        pickup.Pickups = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Jump")){
            if(pickup.Pickups > 0){
                if(CurrentPickup == "Bomb"){
                    Vector2 spawn = gameObject.transform.position;
                    Instantiate(currentObject, spawn, Quaternion.identity);
                    pickup.Pickups--;
                    if(pickup.Pickups == 0){
                        pickupSprite.sprite = null;
                    }
                }
            }
        }
        pickupCount.text = "x" + pickup.Pickups;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bomb"){

            pickup.Pickups++;
            CurrentPickup = collision.tag;
            Debug.Log("Current Pickups: " + pickup.Pickups);
            pickupSprite.sprite = bombSprite;
        } else if(collision.tag == "Ammo"){

            gameObject.transform.Find("NinjaSprite").transform.Find("ShootingOrigin").GetComponent<weaponInfo>().addAmmo(10);
            Destroy(collision.gameObject);

        }
    }
}
