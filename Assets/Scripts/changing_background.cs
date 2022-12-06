using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;
using System.Linq;

public class changing_background : MonoBehaviour
{
    public Score_Script script;

    public GameObject[] options;

    public Image sprite; //access to background

    private Dictionary<string, Color> dictionary_colors = new Dictionary<string, Color>(); // dictionary of both names of colors and actual colors

    private Dictionary<string, string> colors = new Dictionary<string, string>(); // dictionary of both names of colors and actual colors

    private int randomize;


    [HideInInspector]
    public String randomKey;
    [HideInInspector]
    public String randomKey2;

    public Color start_color;


    // Start is called before the first frame update
    void Start()
    {

        start_color = GetComponent<Image>().color;
        dictionary_colors.Add("cyan", Color.cyan);
        dictionary_colors.Add("red", Color.red);
        dictionary_colors.Add("yellow", Color.yellow);
        dictionary_colors.Add("blue", Color.blue);
        dictionary_colors.Add("magenta", Color.magenta);
        dictionary_colors.Add("grey", Color.grey);
        dictionary_colors.Add("white", Color.white);


        colors.Add("pink", "pink");
        colors.Add("orange", "orange");
        colors.Add("forest green", "forest green");
        colors.Add("black", "black");
        colors.Add("lime", "lime");
        colors.Add("periwinkle", "periwinkle");

        changebgColor();

    }

    // Update is called once per frame
    void Update()
    {
        script.scoreText.text = script.score.ToString();


    }
    

    public void changebgColor()
    {
        List<string> keyList_names_colors = new List<string>(dictionary_colors.Keys); // correct colors for sprite
        List<string> keyList_names_color = new List<string>(colors.Keys);//wrong colors string


        var rnd = new System.Random();

        var randomEntry = dictionary_colors.ElementAt(rnd.Next(0, dictionary_colors.Count));
        randomKey = randomEntry.Key;
        
        
        
        var randomEntry2 = colors.ElementAt(rnd.Next(0, colors.Count));
        randomKey2 = randomEntry2.Key;
        
        Color randomValue = randomEntry.Value;




        //getting specific color from chosenColor
        Color color_chosen = randomValue;
        sprite.GetComponent<Image>().color = color_chosen;


        randomize = UnityEngine.Random.Range(0, options.Length); //randomly pick button

        options[randomize].GetComponentInChildren<TMP_Text>().text = randomKey; //correct button

        if (options[0].GetComponentInChildren<TMP_Text>().text == randomKey)
        {

            options[1].GetComponentInChildren<TMP_Text>().text = randomKey2;
            Debug.Log("button on right has incorrect answer");
        }
        if (options[1].GetComponentInChildren<TMP_Text>().text == randomKey)
        {

            options[0].GetComponentInChildren<TMP_Text>().text = randomKey2;
            Debug.Log("button on left has incorrect answer");
        }
    }



    



    public void onbuttonclick()
    {
        changebgColor();
    }
}

    
