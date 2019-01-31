using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;

    ParticleSystem ps1;
    ParticleSystem ps2;
    ParticleSystem ps3;
    ParticleSystem ps4;
	// Use this for initialization
	void Start () {
        ps1 = key1.GetComponent<ParticleSystem>();
        ps2 = key2.GetComponent<ParticleSystem>();
        ps3 = key3.GetComponent<ParticleSystem>();
        ps4 = key4.GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.D)){
            ps1.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            ps2.Play();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            ps3.Play();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            ps4.Play();
        }

    }
}
