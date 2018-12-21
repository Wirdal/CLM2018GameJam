using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue: MonoBehaviour {

    public TextMeshProUGUI TmGUI;
    public string[] Sentences;
    public int Index;
    public float TypeSpeed;

    public IEnumerator Type()
    {

        foreach (char letter in Sentences[Index].ToCharArray())
        { // for every letter in the sentence...
            TmGUI.text += letter; // add a letter to the text box's text
        }

        yield return new WaitForSeconds(TypeSpeed);
    }

    public IEnumerator NextSentence()
    {
        //if (index < sentences.Length - 1)
        //{
        Index++;
        TmGUI.text = "";
        yield return StartCoroutine(Type());

        //}
    }
}
