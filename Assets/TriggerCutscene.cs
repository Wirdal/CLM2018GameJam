using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerCutscene : MonoBehaviour {

    public Enemy AlienThief;
    public Dialogue AlienDialogue;
    public bool Triggered = false;

    // Use this for initialization

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Triggered the cutscene!");
        if (collider.CompareTag("cowboy") && Triggered == false){
            Triggered = true;
            Debug.Log("Specifically, cowboy triggered the cutscene!");
            StartCoroutine(TheftCutscene());
        }
    }

    IEnumerator TheftCutscene(){

        // display some text from the alien thief
        yield return StartCoroutine(AlienDialogue.Type());
        while (AlienDialogue.Index < AlienDialogue.Sentences.Length){
            yield return StartCoroutine(WaitForKey());
            yield return StartCoroutine(AlienDialogue.NextSentence());
        }

        // the alien points the gun at our cowboy
        AlienThief.GetComponent<Enemy>().Animator.SetBool("theft_trigger", true);


        yield return null;
    }

    IEnumerator WaitForKey(){
        while (!Input.GetButtonDown("Next"))
        {
            Debug.Log("didn't get next.");
            yield return null;
        }
        Debug.Log("Got next.");
    }


}
