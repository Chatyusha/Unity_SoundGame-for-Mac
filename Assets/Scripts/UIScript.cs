using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    public Text scoreT;
    int score;
	// Use this for initialization
	void Start () {
        scoreT.text = "SCORE : 0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void countN(){
        score += 100;
        scoreT.text = "SCORE : " + score;
    }
}
