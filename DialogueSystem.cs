using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueSystem : MonoBehaviour
{
    //Set The Duration before proceeding into the next sentences;
    [SerializeField] float Timer;

    //Set The Text Mesh Pro GUI Here
	[SerializeField] private TextMeshProUGUI TextDisplay;

    //Set The Sentences
    [SerializeField] private string[] sentences;

    //Sentences Index
    private int Index = 0;


    void Start()
    {
        StartCoroutine(StartText());
    }

    public void IEnumerator StartText()
    {
        //Create A WaitForSeconds Named Wait With the Timer
        WaitForSeconds Wait = new WaitForSeconds(Timer);

        //Make a Loop For which determine how many Does snentences have
        //The -1 removed the last sentences so make blank
        //it will have an error if the there isn't -1

        for (int i = 0; i < sentences.Length - 1; i++)
        {
            //if the Index is equal to sentences
            if (Index == sentences.Length - 1)
            {
                //This will remove the text
                TextDisplay.text = "";

                //This will disabled the Text Mesh Pro GUI
                TextDisplay.enabled = false;

            }

            else
            {
                //This will enalbed the Text Mesh Pro GUI
                TextDisplay.enabled = true;

                //The Text Display will are equal to sentences with the Index
                TextDisplay.text = sentences[Index];

                //Then the Index will be increment to 1
                Index += 1;

                //it will Wait Depends on how long you will set the Timer before proceeding again in For Loop
                yield return Wait;

                //The Text will be resetted
                TextDisplay.text = "";
            }
        }
    }

}