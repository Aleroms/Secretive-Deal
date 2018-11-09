using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 5;
    // Use this for initialization
    void Start () {
        Player = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 LookAtPoint = new Vector2(Player.transform.position.x, Player.transform.position.y);
        transform.LookAt(LookAtPoint);
        transform.Rotate(0, 90, 0);
        transform.position -= MoveSpeed * Time.deltaTime * transform.right;
    }
}
