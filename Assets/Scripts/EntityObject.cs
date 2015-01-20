using UnityEngine;
using System.Collections;

public class EntityObject : MonoBehaviour {

    #region Declarations
    //Must be public to appear in Inspector.
    public int maxHealth;
    public int curHealth;
    public int maxResource;
    public int curResource;

    //Testing enumerated lists
    public enum entClass { None, Tank, dpsMelee, dpsRanged, Healer };
    public entClass Class;

    //Other Inspector related tests


    #endregion

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
