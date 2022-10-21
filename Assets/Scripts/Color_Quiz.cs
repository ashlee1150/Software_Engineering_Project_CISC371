using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Color_Quiz : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQindex;

    public TMP_Text questionstext;

    private void Start()
    {
        
        generateQuestion();
    }


    public void correct()
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

            if(QnA[currentQindex].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<Answers_Script>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        currentQindex = Random.Range(0, QnA.Count);
        questionstext.text = QnA[currentQindex].Questions;
        SetAnswers();

        
    }
}
