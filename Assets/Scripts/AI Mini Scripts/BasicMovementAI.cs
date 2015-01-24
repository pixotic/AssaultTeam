using UnityEngine;
using System.Collections;

public class BasicMovementAI : MonoBehaviour {
    public int MovementSpeed;
    public Vector3 MovementTarget;
	// Use this for initialization
	void Start () {
        MovementTarget = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 velocity = new Vector2(
                (transform.position.x - MovementTarget.x) * MovementSpeed,
                (transform.position.y - MovementTarget.y) * MovementSpeed);

        rigidbody2D.velocity = -velocity;
	}

    void MoveToVector(Vector3 targetVector) {
        MovementTarget = targetVector;
    }
}
