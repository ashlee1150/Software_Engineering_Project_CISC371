using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Farm_Quiz : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    
    public int currentQindex;
    public GameObject Game_Quiz;
    public GameObject Score_scene;
    public TMP_Text questionstext;
    public TMP_Text ScoreTxt;
    public int scorecount;
    public int totalQuestions = 0;

    //sounds objects
    //public AudioSource correct_sound;
    public AudioSource cat_sound;
    public AudioSource dog_sound;
    public AudioSource cow_sound;
    public AudioSource duck_sound;
    public AudioSource donkey_sound;
    public AudioSource pig_sound;
    public AudioSource turkey_sound;
    public AudioSource rooster_sound;
    public AudioSource sheep_sound;
    public AudioSource chicken_sound;
    public AudioSource geese_sound;

    private bool gameover = false;

    private void Start()
    {
        totalQuestions = QnA.Count;
        generateQuestion();
    }

    private void Update()
    {
        if (gameover == true)
        {
            if ((cat_sound.isPlaying || dog_sound.isPlaying || cow_sound.isPlaying || duck_sound.isPlaying || donkey_sound.isPlaying || pig_sound.isPlaying || turkey_sound.isPlaying || rooster_sound.isPlaying || sheep_sound.isPlaying || chicken_sound.isPlaying || geese_sound.isPlaying))
            { //prob add the rest of the sounds here 
                cat_sound.Stop();
                dog_sound.Stop();
                cow_sound.Stop();
                duck_sound.Stop();
                donkey_sound.Stop();
                pig_sound.Stop();
                turkey_sound.Stop();
                rooster_sound.Stop();
                sheep_sound.Stop();
                chicken_sound.Stop();
                geese_sound.Stop();  //prob add the rest of the sounds here 
            }
        }
    }

    public void GameOver()
    {

        gameover = true;
        Game_Quiz.SetActive(false);
        Score_scene.SetActive(true);
        ScoreTxt.text = scorecount + " / " + totalQuestions;
    }
    public void correct()
    {
        
        scorecount++;
        QnA.RemoveAt(currentQindex);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQindex);
        generateQuestion();
    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers_Script>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQindex].Answers[i];
           
            if (QnA[currentQindex].CorrectAnswer == i+1)
            {
                options[i].GetComponent<Answers_Script>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQindex = Random.Range(0, QnA.Count);
            questionstext.text = QnA[currentQindex].Questions;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of questions");
            GameOver();
        }

        
    }
}
