using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform Firepoint;
    public GameObject BulletPrefab;
    public int Dmg;
    public CowboyPlayer Player; // may be more generic in the future

    private void Start()
    {
        BulletPrefab.GetComponent<Bullet>().Dmg = Dmg;
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
	}

    void Shoot(){
        if (Player.CanMove){
            Instantiate(BulletPrefab, Firepoint.position, Firepoint.rotation);
        }
    }
}
