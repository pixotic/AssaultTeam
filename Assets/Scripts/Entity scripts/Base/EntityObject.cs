using UnityEngine;
using System.Collections;

public class EntityObject : MonoBehaviour {

    #region Declarations
    //These should be private but are set to public so I can fiddle with them in the inspector -rg
    public int maxHealth;
    public int currentHealth;
    public int maxResource;
    public int currentResource;
    
    public enum EntityClasses { None, Tank, dpsMelee, dpsRanged, Healer };
    //^The enum must be public
    //vThis instance of the enum should be private
    public EntityClasses entityClass;

    //Other Inspector related tests

    #endregion

    #region GetSet
    public int MaxHealth {
        get { return maxHealth; }
        set { maxHealth = value; }
    }
    public int CurrentHealth {
        get { return currentHealth; }
        set { currentHealth = value; }
    }
    public int MaxResource {
        get { return maxResource; }
        set { maxResource = value; }
    }
    public int CurrentResource {
        get { return currentResource; }
        set { currentResource = value; }
    }
    public EntityClasses EntityClass {
        get { return entityClass; }
        set { entityClass = value; }
    }
    #endregion

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
