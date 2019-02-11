using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalBallScript : MonoBehaviour {
    public GameObject canvas;
    UIScript ui;
	// Use this for initialization
	void Start () {
        ui = canvas.GetComponent<UIScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.name == "Key1"&&Input.GetKeyDown(KeyCode.D))
        {
            ui.CountN();
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key2" && Input.GetKeyDown(KeyCode.F))
        {
            ui.CountN();
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key3" && Input.GetKeyDown(KeyCode.J))
        {
            ui.CountN();
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key4" && Input.GetKeyDown(KeyCode.K))
        {
            ui.CountN();
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ui.Conbo();
    }
}
