using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalBallScript : MonoBehaviour {
    public GameObject canvas;
    UIScript uiscript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        uiscript = canvas.GetComponent<UIScript>();
	}
    private void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.name == "Key1"&&Input.GetKeyDown(KeyCode.D))
        {
            uiscript.countN();
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key2" && Input.GetKeyDown(KeyCode.F))
        {
            uiscript.countN();
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key3" && Input.GetKeyDown(KeyCode.J))
        {
            uiscript.countN();
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key4" && Input.GetKeyDown(KeyCode.K))
        {
            uiscript.countN();
            Destroy(gameObject);
        }
    }
}
