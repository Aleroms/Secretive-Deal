using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAim : MonoBehaviour {
    float VertRotation;
    float HorizRotation; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        VertRotation = Input.GetAxis("Vertical Aim");
        HorizRotation = Input.GetAxis("Horizontal Aim");
        if(VertRotation != 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90 * VertRotation);
        }
        if(HorizRotation < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180 * HorizRotation);

        } else if(HorizRotation > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        
	}
}
