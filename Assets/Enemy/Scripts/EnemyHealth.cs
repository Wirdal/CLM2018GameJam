using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int Hp;

    private void Update()
    {
        if (Hp <= 0){
            Destroy(gameObject);
        }
    }

}
