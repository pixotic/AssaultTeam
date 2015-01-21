using UnityEngine;
using System.Collections;

public class SpellBase : MonoBehaviour {
    #region Declarations
    //todo change vars to private, add getters/setters

    public string spellName;
    public string spellTooltip;
    public enum SpellSchools { Fire, Frost, Arcane, Nature, Holy, Shadow };
    public SpellSchools spellSchool;
    public bool spellDealsDamage;
    public int spellPower;
    public float spellCastTime;
    public float spellCooldown;

    #endregion


    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
