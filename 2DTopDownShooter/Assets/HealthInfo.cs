﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthInfo : MonoBehaviour {

    public int currentHealth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Image>().transform.localScale = new Vector3((float)GameObject.FindWithTag("Player").GetComponent<OnEnemyCollide>().currentHealth * .01f, 1, 1);
	}
}
