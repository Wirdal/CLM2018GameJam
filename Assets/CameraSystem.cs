using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {

    private GameObject Player;

    // BOUNDS
    public float XMin;
    public float XMax;
    public float YMin;
    public float YMax;


	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("cowboy");

	}
	
	// Update is called once per frame
	void LateUpdate () {
        float X = Mathf.Clamp(Player.transform.position.x, XMin, XMax);
        float Y = Mathf.Clamp(Player.transform.position.y, YMin, YMax);
        gameObject.transform.position = new Vector3(X, Y, gameObject.transform.position.z);
	}
}
