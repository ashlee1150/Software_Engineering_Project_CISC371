using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score_Script : MonoBehaviour
{

    public changing_background script;
    public int score;
    public TMP_Text scoreText;
    //private List<string> correct_colors;
    // Start is called before the first frame update


    void Start()
    {


        


    }

    // Update is called once per frame
    void Update()
    {
        //updates the score at every frame
        scoreText.text = score.ToString();
    }

    //this function changes score if the right button is pressed
    public void add_sub_score_right()
    {
        //if the right button has the answer add 1 to score if not subtract (if the score is greater than 0)
        if (script.options[1].GetComponentInChildren<TMP_Text>().text == "cyan" || script.options[1].GetComponentInChildren<TMP_Text>().text == "red" || script.options[1].GetComponentInChildren<TMP_Text>().text == "yellow" || script.options[1].GetComponentInChildren<TMP_Text>().text == "blue")
        {
            score = score + 1;
        }
        else
        {
            if (score > 0)
            {
                score = score - 1;
            }
        }
    
    
    }
    
    //this function changes score if the left button is pressed
    public void add_sub_score_left()
    {

        //if the right button has the answer add 1 to score if not subtract (if the score is greater than 0)
        if (script.options[0].GetComponentInChildren<TMP_Text>().text == "cyan" || script.options[0].GetComponentInChildren<TMP_Text>().text == "red" || script.options[0].GetComponentInChildren<TMP_Text>().text == "yellow" || script.options[0].GetComponentInChildren<TMP_Text>().text == "blue")
        {
            score = score + 1;
        }
        else
        {
            if (score > 0)
            {
                score = score - 1;
            }
            
        }


    }

}

