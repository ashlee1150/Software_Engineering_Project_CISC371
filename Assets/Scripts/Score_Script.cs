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
    public GameObject gamecanvas;
    public GameObject losingcanvas;
    public TMP_Text ScoreTxt;
    public Color color_start;
    public Button button1;
    public Button button2;
    

    // Start is called before the first frame update


    void Start()
    {
        color_start = button1.GetComponent<Image>().color;
        gamecanvas.SetActive(true);
        losingcanvas.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        //updates the score at every frame
        scoreText.text = score.ToString();
        if (lossing_score == 3)
        {
            gamecanvas.SetActive(false);
            losingcanvas.SetActive(true);
            ScoreTxt.text = score.ToString();
        }
    }

    //this function changes score if the right button is pressed
    public void add_sub_score_right()
    {
        //if the right button has the answer add 1 to score if not subtract (if the score is greater than 0)
        if (script.options[1].GetComponentInChildren<TMP_Text>().text == "cyan" || script.options[1].GetComponentInChildren<TMP_Text>().text == "red" || script.options[1].GetComponentInChildren<TMP_Text>().text == "yellow" || script.options[1].GetComponentInChildren<TMP_Text>().text == "blue" || script.options[1].GetComponentInChildren<TMP_Text>().text == "white" || script.options[1].GetComponentInChildren<TMP_Text>().text == "magenta"  || script.options[1].GetComponentInChildren<TMP_Text>().text == "grey")
        {
            button2.GetComponent<Image>().color = Color.green;
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
            button2.GetComponent<Image>().color = Color.red;
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
            button1.GetComponent<Image>().color = Color.green;
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
            button1.GetComponent<Image>().color = Color.red;
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

