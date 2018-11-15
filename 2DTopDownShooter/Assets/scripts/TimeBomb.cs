using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBomb : MonoBehaviour {


    public float TimeToDetonate;
    public GameObject explotion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(BombActivated());
        StartCoroutine(BombGrowth());
        Debug.Log("BOOM");
    }

    IEnumerator BombActivated()
    {
        yield return new WaitForSeconds(TimeToDetonate);
        Instantiate(explotion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    IEnumerator BombGrowth(){
        yield return new WaitForSeconds(.75f);
        gameObject.transform.localScale += new Vector3(.05f, .05f, 0);
        yield return new WaitForSeconds(.75f);
        gameObject.transform.localScale += new Vector3(.05f, .05f, 0);
        yield return new WaitForSeconds(.75f);
        gameObject.transform.localScale += new Vector3(.05f, .05f, 0);

    }
}
