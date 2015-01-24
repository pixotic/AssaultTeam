using UnityEngine;
using System.Collections;

public class Tooltiptest : MonoBehaviour {
	void OnGUI() {
		GUI.Box(new Rect(5, 35, 110, 75), new GUIContent("Box", "this box has a tooltip"));
		GUI.Button(new Rect(10, 55, 100, 20), "No tooltip here");
		GUI.Button(new Rect(10, 80, 100, 20), new GUIContent("I have a tooltip", "The button overrides the box"));
		GUI.Label(new Rect(10, 40, 100, 40), GUI.tooltip);
	}
}