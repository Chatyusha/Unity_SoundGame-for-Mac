using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    public Text scoreT;
    public Text cbT;
    public GameObject rs;
    int score;
    int cb = 0;
	// Use this for initialization
	void Start () {
        scoreT.text = "SCORE : 0";
        cbT.text = 0+"コンボ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CountN(){
        score += 100;
        cb += 1;
        scoreT.text = "SCORE : " + score;
        cbT.text = cb + "コンボ";
    }
    public void Conbo(){
        score += 50 * cb;
        scoreT.text = "SCORE : " + score;
        cb = 0;
        cbT.text = cb + "コンボ";
    }
    public void CountS(){
        score += 200;
        cb += 1;
        scoreT.text = "SCORE : " + score;
        cbT.text = cb + "コンボ";
    }
}
