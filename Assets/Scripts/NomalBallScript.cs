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
        bool isShift = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        if (other.gameObject.name == "Key1"&&Input.GetKeyDown(KeyCode.D)&&isShift==false)
        {
            Debug.Log("succes");
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key2" && Input.GetKeyDown(KeyCode.F) && isShift == false)
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key3" && Input.GetKeyDown(KeyCode.K) && isShift == false)
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Key4" && Input.GetKeyDown(KeyCode.L) && isShift == false)
        {
            Destroy(gameObject);
        }
    }
}
