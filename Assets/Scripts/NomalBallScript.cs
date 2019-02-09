using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalBallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.name == "Key1"&&Input.GetKeyDown(KeyCode.D))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key2" && Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key3" && Input.GetKeyDown(KeyCode.J))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key4" && Input.GetKeyDown(KeyCode.K))
        {
            Destroy(gameObject);
        }
    }
}
