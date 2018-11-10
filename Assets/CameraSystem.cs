﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {

    private GameObject player;

    // BOUNDS
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("cowboy");

	}
	
	// Update is called once per frame
	void LateUpdate () {
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
	}
}
