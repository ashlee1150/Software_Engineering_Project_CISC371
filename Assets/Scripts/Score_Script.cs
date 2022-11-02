using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Score_Script : MonoBehaviour
{

    public changing_background script;
    public int score;
    public TMP_Text scoreText;
    private int lossing_score = 0;
    public AudioSource wrong_sound;
    public AudioSource right_sound;
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
        if (lossing_score == 3)
        {
            SceneManager.LoadScene("Color_Quiz_Lose_Screen");
        }
    }

    //this function changes score if the right button is pressed
    public void add_sub_score_right()
    {
        //if the right button has the answer add 1 to score if not subtract (if the score is greater than 0)
        if (script.options[1].GetComponentInChildren<TMP_Text>().text == "cyan" || script.options[1].GetComponentInChildren<TMP_Text>().text == "red" || script.options[1].GetComponentInChildren<TMP_Text>().text == "yellow" || script.options[1].GetComponentInChildren<TMP_Text>().text == "blue" || script.options[1].GetComponentInChildren<TMP_Text>().text == "white" || script.options[1].GetComponentInChildren<TMP_Text>().text == "magenta"  || script.options[1].GetComponentInChildren<TMP_Text>().text == "grey")
        {
            score = score + 1;
            right_sound.Play();
            if (lossing_score > 0)
            {
                lossing_score = lossing_score - 1;
                //Debug.Log("subtract lossing score");
            }
            

        }
        else
        {
            wrong_sound.Play();
            if (score > 0)
            {
                score = score - 1;
                
            }
            lossing_score = lossing_score + 1;
            //Debug.Log("add to lossing score");
        }
    
    
    }
    
    //this function changes score if the left button is pressed
    public void add_sub_score_left()
    {

        //if the right button has the answer add 1 to score if not subtract (if the score is greater than 0)
        if (script.options[0].GetComponentInChildren<TMP_Text>().text == "cyan" || script.options[0].GetComponentInChildren<TMP_Text>().text == "red" || script.options[0].GetComponentInChildren<TMP_Text>().text == "yellow" || script.options[0].GetComponentInChildren<TMP_Text>().text == "blue" || script.options[0].GetComponentInChildren<TMP_Text>().text == "white" || script.options[0].GetComponentInChildren<TMP_Text>().text == "magenta" || script.options[0].GetComponentInChildren<TMP_Text>().text == "grey")
        {
            score = score + 1;
            right_sound.Play();
            if (lossing_score != 0)
            {
                lossing_score = 0;
                //Debug.Log("subtract to lossing score");
            }

        }
        else
        {
            wrong_sound.Play();
            if (score > 0)
            {
                score = score - 1;
             
            }
            lossing_score = lossing_score + 1;
            //Debug.Log("add to lossing score");

        }


    }

    


}

