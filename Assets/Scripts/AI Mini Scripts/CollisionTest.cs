using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll) {
        Debug.Log("Bump from collider");
        //if (coll.gameObject.tag == "DodgemCar")
           

    }

}
