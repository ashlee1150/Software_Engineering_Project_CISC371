using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers_Script : MonoBehaviour
{
    public bool isCorrect = false;
    public Color_Quiz quizManager;
    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("correct answer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("wrong answer");
            quizManager.correct();
        }
    }
}
