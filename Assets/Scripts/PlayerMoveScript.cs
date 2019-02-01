using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    [SerializeField, Range(0, 60*3+42)]
    float time = 1;

    [SerializeField]
    Vector3 endPosition;

    //[SerializeField]
    //AnimationCurve curve;

    private float startTime;
    private Vector3 startPosition;

    // Use this for initialization
    void Start(){

    }
    void OnEnable()
    {
        if (time <= 0)
        {
            transform.position = endPosition;
            enabled = false;
            return;
        }

        startTime = Time.timeSinceLevelLoad;
        startPosition = transform.position;
    }

    void Update()
    {
        var diff = Time.timeSinceLevelLoad - startTime;
        if (diff > time)
        {
            transform.position = endPosition;
            enabled = false;
        }

        var rate = diff / time;
        //var pos = curve.Evaluate(rate);

        transform.position = Vector3.Lerp(startPosition, endPosition, rate);
        //transform.position = Vector3.Lerp (startPosition, endPosition, pos);
    }
}
