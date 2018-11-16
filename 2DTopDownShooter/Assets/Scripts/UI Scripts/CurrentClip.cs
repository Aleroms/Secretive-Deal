using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentClip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Text>().text = GameObject.FindWithTag("Player").transform.GetChild(0).transform.GetChild(0).GetComponent<weaponInfo>().currentClip.ToString();
    }
}
