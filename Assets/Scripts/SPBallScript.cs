using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPBallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}
    private void OnTriggerStay(Collider other)
    {
        bool shiftkey = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        if(other.name=="Key1"&&Input.GetKeyDown(KeyCode.D)&&shiftkey==true){
            Destroy(gameObject);
        }else if (other.name == "Key2" && Input.GetKeyDown(KeyCode.F) && shiftkey == true)
        {
            Destroy(gameObject);
        }else if (other.name == "Key3" && Input.GetKeyDown(KeyCode.J) && shiftkey == true)
        {
            Destroy(gameObject);
        }else if (other.name == "Key4" && Input.GetKeyDown(KeyCode.K) && shiftkey == true)
        {
            Destroy(gameObject);
        }
    }
}
