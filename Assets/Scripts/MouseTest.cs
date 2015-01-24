using UnityEngine;
using System.Collections;

public class MouseTest : MonoBehaviour {
    //public GameObject targetObject;
    public Vector3 clickCoords;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) { // if left button pressed...            
            clickCoords.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            clickCoords.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
            SendTurnToVector(clickCoords);
        }
        if (Input.GetMouseButtonDown(1)) {
            clickCoords.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            clickCoords.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
            SendTurnAndMoveToVector(clickCoords);
        }
    }

    void SendTurnToVector(Vector3 targetVector) {
        gameObject.SendMessage("TurnToVector", targetVector);
    }
    void SendMoveToVector(Vector3 targetVector) {
        gameObject.SendMessage("MoveToVector", targetVector);
    }
    void SendTurnAndMoveToVector(Vector3 targetVector) {
        SendTurnToVector(targetVector);
        SendMoveToVector(targetVector);
    }

}
