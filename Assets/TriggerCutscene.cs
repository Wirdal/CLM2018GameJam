using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerCutscene : MonoBehaviour {

    public Enemy AlienThief;
    public Dialogue AlienDialogue;
    public Dialogue CowboyDialogue;
    public Dialogue ShootDialogue;
    public GameObject Cow;
    public GameObject AlienPlusCow;
    public Dialogue AlienLeaveDialogue;

    public bool Triggered = false;
    public CowboyPlayer Cowboy;

    // Use this for initialization

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Triggered the cutscene!");
        if (collider.CompareTag("cowboy") && Triggered == false){
            Triggered = true;
            Debug.Log("Specifically, cowboy triggered the cutscene!");
            Cowboy.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Cowboy.CanMove = false;
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

        yield return StartCoroutine(CowboyDialogue.Type());
        while (CowboyDialogue.Index < CowboyDialogue.Sentences.Length){
            yield return StartCoroutine(WaitForKey());
            yield return StartCoroutine(CowboyDialogue.NextSentence());
        }

        // the alien points the gun at our cowboy
        AlienThief.GetComponent<Enemy>().Animator.SetBool("theft_trigger", true);

        yield return StartCoroutine(ShootDialogue.Type());

        Cowboy.CanMove = true;

        // after the alien has been hit with 5 bullets, the alien and cow move backwards and disappear
       
        while (AlienThief.HitCounter < 5){
            Debug.Log("Hit counter is less than 5");
            yield return null; 
        }

        yield return StartCoroutine(ShootDialogue.NextSentence());

        Cowboy.CanMove = false;

        yield return StartCoroutine(AlienLeaveDialogue.Type());

        while (AlienLeaveDialogue.Index < AlienLeaveDialogue.Sentences.Length)
        {
            yield return StartCoroutine(WaitForKey());
            yield return StartCoroutine(AlienLeaveDialogue.NextSentence());
        }

        Rigidbody2D AlienCowRb = AlienPlusCow.GetComponent<Rigidbody2D>();

        Debug.Log("About to move position of alien and cow");

        int NumIterations = 0;
        while (NumIterations < 150){
            AlienCowRb.velocity = AlienPlusCow.transform.right * 5;
            NumIterations++;
            yield return null;
        }

        Cowboy.CanMove = true;

        Debug.Log("Moved position of alien and cow!");

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
