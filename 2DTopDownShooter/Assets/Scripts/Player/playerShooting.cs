using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    [Header("Shooting Number Variables")]
    public float shootingDistance = 300.0f; //how far the bullet should travel (detect enemy)
    public Transform firingPoint; //Where the bullet will travel/check from (realistic gun)
    private Vector2 mousePosition; //position of mouse
    private Vector2 firingOrigin; //the (x,y) coordinates of the firingpoint gameObject
    private RaycastHit2D hit; //the line the bullet will follow
    private enemyBehavior damaging; //the enemy script to access variables
    private weaponInfo useClip; //the weapon info script to access variables
    public GameObject bullet;
    // Use this for initialization
    void Start()
    {

        useClip = firingPoint.GetComponent<weaponInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire();
        }
    }

    void fire()
    {
        //if your current ammo is empty, we try to reload
        if (useClip.currentClip == 0)
        {
            useClip.reload();
        }
        else //you can fire if u have ammo in your clip
        {
            /*
            firingOrigin = new Vector2(firingPoint.position.x, firingPoint.position.y);
            mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            hit = Physics2D.Raycast(firingOrigin, mousePosition-firingOrigin, shootingDistance);

            //Make sure that the firingOrigin is far from the player gameObject 
            //to ensure that the raycast hits the enemies and not collide with the player itself
            //and tag all enemies with the same tag to compare
            if (hit && hit.collider.CompareTag("Enemy"))
            {
                damaging = hit.collider.GetComponent<enemyBehavior>();
                damaging.currentHealth--;
            } */

            //fires one bullet, subtracting from the current ammo
            Vector2 BulletSpawnPos = firingPoint.transform.position;
            Quaternion BulletSpawnRot = firingPoint.transform.rotation;
            var x = (GameObject)Instantiate(bullet, BulletSpawnPos, BulletSpawnRot);
            x.GetComponent<Rigidbody2D>().velocity = x.transform.right * 12.0f;
            Destroy(x, 2.0f);
            useClip.currentClip--;
        }
    }
}
