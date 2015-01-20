using UnityEngine;
using System.Collections;

public class SpellBase : MonoBehaviour {
    #region Declarations
    public string spellName;
    public string spellDesc;
    public int spellCost;
    public enum spellSchools { Fire, Frost, Arcane, Nature, Shadow, Holy };
    public spellSchools spellSchool;
    #endregion
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
