using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Color_Quiz : MonoBehaviour
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
    private void Start()
    {
        totalQuestions = QnA.Count;
        generateQuestion();
    }

    public void GameOver()
    {
        Game_Quiz.SetActive(false);
        Score_scene.SetActive(true);
        ScoreTxt.text = scorecount + "/" + totalQuestions;
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

            if(QnA[currentQindex].CorrectAnswer == i+1)
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
