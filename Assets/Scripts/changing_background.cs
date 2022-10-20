using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;
using System.Linq;

public class changing_background : MonoBehaviour
{

    public GameObject[] options;

    public SpriteRenderer sprite; //access to background
    
    private Dictionary<string, Color> dictionary_colors = new Dictionary<string, Color>(); // dictionary of both names of colors and actual colors

    private Dictionary<string, Color> colors = new Dictionary<string, Color>(); // dictionary of both names of colors and actual colors

    private int randomize;
   
    private String randomKey;
    private String randomKey2;
   
    
    // Start is called before the first frame update
    void Start()
    {


        dictionary_colors.Add("black", Color.black);
        dictionary_colors.Add("red", Color.red);
        dictionary_colors.Add("yellow", Color.yellow);
        dictionary_colors.Add("blue", Color.blue);

        colors.Add("grey", Color.grey);
        colors.Add("magenta",Color.magenta);
        colors.Add("green", Color.green);
        colors.Add("white", Color.white);


        List<string> keyList_names_colors = new List<string>(dictionary_colors.Keys);
        List<string> keyList_names_color = new List<string>(colors.Keys);
        var rnd = new System.Random();

        var randomEntry = dictionary_colors.ElementAt(rnd.Next(0, dictionary_colors.Count));
        var randomEntry2 = colors.ElementAt(rnd.Next(0, colors.Count));


        randomKey = randomEntry.Key;
        randomKey2 = randomEntry2.Key;

        Color randomValue = randomEntry.Value;




        //getting specific color from chosenColor
        Color color_chosen = randomValue;
        sprite.color = color_chosen;


        randomize = UnityEngine.Random.Range(0, options.Length);

        options[randomize].GetComponentInChildren<TMP_Text>().text = randomKey;
        options[randomize].GetComponentInChildren<TMP_Text>().text = randomKey2;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (options[0].GetComponentInChildren<TMP_Text>().text == randomKey && options[1].GetComponentInChildren<TMP_Text>().text == randomKey)
        {
            options[randomize].GetComponentInChildren<TMP_Text>().text = randomKey;
        }

        if (options[0].GetComponentInChildren<TMP_Text>().text != randomKey || options[1].GetComponentInChildren<TMP_Text>().text != randomKey){
            options[randomize].GetComponentInChildren<TMP_Text>().text = randomKey;

        }
    }

    public void changebgColor()
    {
        List<string> keyList_names_colors = new List<string>(dictionary_colors.Keys);
        List<string> keyList_names_color = new List<string>(colors.Keys);
        var rnd = new System.Random();

        var randomEntry = dictionary_colors.ElementAt(rnd.Next(0, dictionary_colors.Count));
        var randomEntry2 = colors.ElementAt(rnd.Next(0, colors.Count));


        randomKey = randomEntry.Key;
        randomKey2 = randomEntry2.Key;

        Color randomValue = randomEntry.Value;




        //getting specific color from chosenColor
        Color color_chosen = randomValue;
        sprite.color = color_chosen;


        randomize = UnityEngine.Random.Range(0, options.Length);

        options[randomize].GetComponentInChildren<TMP_Text>().text = randomKey;
        options[randomize].GetComponentInChildren<TMP_Text>().text = randomKey2;


    }

    public void onbuttonclick()
    {
        if (options[0].GetComponentInChildren<TMP_Text>().text == randomKey )
        {
            changebgColor();
        }
        if(options[1].GetComponentInChildren<TMP_Text>().text == randomKey)
        {
            changebgColor();
        }
        else
        {
            Debug.Log("wrong");
        }
    }

}
