using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int Speed = 20;
    public Rigidbody2D Rb;
    public int Dmg; 

	// Use this for initialization
	void Start () {

        Rb.velocity = transform.right * Speed;
		
	}
	
    void OnTriggerEnter2D(Collider2D hitInfo){
        
        Enemy EnemyPlayer = hitInfo.GetComponent<Enemy>();
        EnemyPlayer.HitCounter++;
        Debug.Log("Hit Counter is" + EnemyPlayer.HitCounter);
        if (EnemyPlayer != null){
            EnemyPlayer.TakeDamage(Dmg);
        }
        Destroy(gameObject);
    }
}
