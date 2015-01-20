using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public void Changetoscene (string scenetochangeto) {
		Application.LoadLevel (scenetochangeto);
	}
}
