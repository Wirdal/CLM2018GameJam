using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.y < -7)
        {
            StartCoroutine("Die");
        }

	}

    void Die(){
        SceneManager.LoadScene("SampleScene");
    }
}
