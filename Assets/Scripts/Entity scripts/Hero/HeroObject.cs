using UnityEngine;
using System.Collections;

public class HeroObject : EntityObject {
    #region Declarations
    //General fluff
    public string heroName;
    public string heroCharacterName;
    public string heroCharacterTitle;
    public string heroCharacterGuildName;

    //Gear stats
    public int heroCharacterWeaponIlvl;
    public int heroCharacterArmourIlvl;

    //Character and Hero stats
    public int heroStatObservation;
    public int heroStatReaction;
    public int heroStatIntelligence;
    public int heroStatKnowledge;
    public int heroStatSkill;

    public int heroStatStamina;
    public int heroStatStrength;
    public int heroStatAgility;
    public int heroStatIntellect;

    //todo: secondary stats like block, dodge, mana regen etc

    #endregion
    //todo: set declarations to private, add getters and setters

    public int avgIlvl {
        get { return (heroCharacterWeaponIlvl + heroCharacterArmourIlvl) / 2; }
    }

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
