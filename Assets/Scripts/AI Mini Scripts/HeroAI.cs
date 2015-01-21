using UnityEngine;
using System.Collections;

public class HeroAI : MonoBehaviour {
    public Transform Target;
    public GameObject Enemy;
    public GameObject Player;
    public float Range;
    public float Speed;
    public Vector3 EnemyVector;
    public Vector3 PlayerVector;
    public Vector2 velocity;

    // Use this for initialization
    void Start() {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        EnemyVector = Enemy.transform.position;
        PlayerVector = Player.transform.position;

        Range = Vector2.Distance(new Vector2(PlayerVector.x, PlayerVector.y), new Vector2(EnemyVector.x, EnemyVector.y));

        if (Range > 10f) {
            velocity = new Vector2(0, 0);
        } else if (Range <= 7f) {
            //transform.Translate(Vector2.MoveTowards(new Vector2(EnemyVector.x, EnemyVector.y), new Vector2(PlayerVector.x, PlayerVector.y), Range) * Speed * Time.deltaTime);
             velocity = new Vector2(
                ((transform.position.x - EnemyVector.x) * Speed)*-1,
                ((transform.position.y - EnemyVector.y) * Speed)*-1
                );
        }
        rigidbody2D.velocity = -velocity;
    }
}
