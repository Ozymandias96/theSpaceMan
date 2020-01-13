using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldCharacter : MonoBehaviour {

	void onColissionEnter(Collision col)
    {
        if (col.gameObject.tag == "TPMan")
        {
            col.collider.transform.SetParent(transform);
        }

    }

    void onCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "TPMan")
        {
            col.collider.transform.SetParent(null);
        }
    }
}
