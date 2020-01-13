using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public Transform Cube;
    public Transform Position1;
    public Transform Position2;
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
        Cube.position = Vector3.Lerp(Cube.position, newpos, smooth*Time.deltaTime);
	}


    void ChangeTarget()
    {
        if(currentState == "Moving to Position1")
        {
            currentState = "Moving to Position2";
            newpos = Position2.position;
        }
        else if (currentState == "Moving to Position2")
        {
            currentState = "Moving to Position1";
            newpos = Position1.position;
        }

        else if(currentState == "")
        {
            currentState = "Moving to Position2";
            newpos = Position2.position;
        }

        Invoke("ChangeTarget", resetTime);
    }
}
