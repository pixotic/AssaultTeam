using UnityEngine;
using System.Collections;

public class Rotationtest : MonoBehaviour {
    public GameObject targetObject;
    public int speed;
    public int rotOffset;
    public float angle;

    public Vector3 vectorToTarget;

	// Use this for initialization
	void Start () {
        vectorToTarget = new Vector3 (transform.position.x, transform.position.y - 1, 0);
	}
	
	// Update is called once per frame
	void Update () {
        //Keep object turned to face target
        Vector3 vectorToFace = vectorToTarget - transform.position;
        angle = (Mathf.Atan2(vectorToFace.y, vectorToFace.x) * Mathf.Rad2Deg) + rotOffset;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
	
	}

    void TurnToVector(Vector3 targetVector) {
        vectorToTarget = targetVector;
    }

}
