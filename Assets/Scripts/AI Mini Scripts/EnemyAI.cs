using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	
	public Transform Target;
	public GameObject Enemy;
	public GameObject Player;
	public float Range;
	public float Speed;
    public Vector3 EnemyVector;
    public Vector3 PlayerVector;
	
	
	// Use this for initialization
	void Start () {
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		Player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
        EnemyVector = Enemy.transform.position;
        PlayerVector = Player.transform.position;

		Range = Vector2.Distance (new Vector2(EnemyVector.x, EnemyVector.y), new Vector2(PlayerVector.x, PlayerVector.y));
		if (Range <= 15f) {
            //transform.Translate(Vector2.MoveTowards(new Vector2(EnemyVector.x, EnemyVector.y), new Vector2(PlayerVector.x, PlayerVector.y), Range) * Speed * Time.deltaTime);
            Vector2 velocity = new Vector2(
                (transform.position.x - PlayerVector.x) * Speed, 
                (transform.position.y - PlayerVector.y) * Speed);

            if (Range < 1f) {
                velocity = new Vector2(0, 0);
            }

            rigidbody2D.velocity = -velocity;
		}
	}
}