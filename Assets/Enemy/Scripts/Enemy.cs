using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int HitCounter = 0;
    public Animator Animator = null;

	// Use this for initialization
	void Awake () {
        Animator = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(int Dmg){

        gameObject.GetComponent<EnemyHealth>().Hp -= Dmg;
    }
}
