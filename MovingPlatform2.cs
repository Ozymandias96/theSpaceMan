using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform2 : MonoBehaviour {

    public Transform Cube;
    public Transform Position3;
    public Transform Position4;
    public Vector3 newpos;
    public string currentState;
    public float smooth;
    public float resetTime;


    // Use this for initialization
    void Start () {
        ChangeTarget();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Cube.position = Vector3.Lerp(Cube.position, newpos, smooth * Time.deltaTime);
    }

    void ChangeTarget()
    {
        if (currentState == "Moving to Position3")
        {
            currentState = "Moving to Position4";
            newpos = Position4.position;
        }
        else if (currentState == "Moving to Position4")
        {
            currentState = "Moving to Position3";
            newpos = Position3.position;
        }

        else if (currentState == "")
        {
            currentState = "Moving to Position3";
            newpos = Position3.position;
        }

        Invoke("ChangeTarget", resetTime);
    }

}
