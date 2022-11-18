using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score_text_Farm : MonoBehaviour
{
    public TMP_Text ScoreTxt;
    private Farm_Quiz scorecount;
    private Farm_Quiz totalQuestions;
    // Start is called before the first frame update
    void Start()
    {
        print(totalQuestions);
        print(scorecount);
        ScoreTxt.text = scorecount + "/" + totalQuestions;
    }

    public void change_score_text()
    {
        ScoreTxt.text = scorecount  + "/" + totalQuestions;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
