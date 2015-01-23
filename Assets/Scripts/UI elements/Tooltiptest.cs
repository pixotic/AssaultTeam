using UnityEngine;
using System.Collections;

public class Tooltiptest : MonoBehaviour {

    protected MonsterObject monsterObject;
    public string entityName;
    public string entitySubname;

    // Use this for initialization
    void Start() {      
        monsterObject = GetComponent<MonsterObject>();
        entityName = monsterObject.monsterName;
        entitySubname = monsterObject.monsterSubname;
    }

	void OnGUI() {
		GUI.Box(new Rect(5, 35, 200, 75), new GUIContent(entityName, entitySubname));
		//GUI.Button(new Rect(10, 55, 100, 20), "No tooltip here");
		//GUI.Button(new Rect(10, 80, 100, 20), new GUIContent("I have a tooltip", "The button overrides the box"));
		GUI.Label(new Rect(10, 40, 100, 40), GUI.tooltip);
	}
}