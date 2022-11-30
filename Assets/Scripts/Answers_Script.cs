using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Answers_Script : MonoBehaviour
{
    public bool isCorrect = false;
    private int played = 1; 
    public Farm_Quiz quizManager;
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
    public TMP_Text button_text;
    public TMP_Text button_text2;
    public AudioSource right_answer;
    public AudioSource wrong_answer;
    public GameObject answer;
    void Start()
    {
        
        Sounds();
    }
    private void Update()
    {
        if (!(cat_sound.isPlaying || dog_sound.isPlaying || cow_sound.isPlaying || duck_sound.isPlaying || donkey_sound.isPlaying || pig_sound.isPlaying || turkey_sound.isPlaying || rooster_sound.isPlaying || sheep_sound.isPlaying || chicken_sound.isPlaying || geese_sound.isPlaying)) //prob add the rest of the sounds here 
        {
            Button button_intereact = answer.GetComponent<Button>();

            button_intereact.interactable = true;
           
        }
        else
        {
            Button button_intereact = answer.GetComponent<Button>();

            button_intereact.interactable = false;
        }
    }

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("correct answer play animal sound");
            quizManager.correct();
            right_answer.Play();
        }

        else
        {
            Debug.Log("wrong answer");
            quizManager.wrong();
            wrong_answer.Play();
        }
    }
    public void Sounds()
    {
        //compare both button texts 
        
        
        if (button_text.text == "Cat" || button_text2.text == "Cat")
        {

            {

               
                cat_sound.Play();
                played++;
               
                //Debug.Log(played);
            }
        }

        if (button_text.text == "Dog" || button_text2.text == "Dog")
        {
            {
                dog_sound.Play();
                played++;
                Debug.Log(played);
            }
        }
        if (button_text.text == "Geese" || button_text2.text == "Geese")
        {
            {
                geese_sound.Play();
                played++;
                Debug.Log(played);
            }
        }
        if (button_text.text == "Cow" || button_text2.text == "Cow")
        {
            {
                cow_sound.Play();
                played++;
                Debug.Log(played);
            }
        }
        if (button_text.text == "Turkey" || button_text2.text == "Turkey")
        {
            {
                turkey_sound.Play();
                played++;
                Debug.Log(played);
            }
        }
        if (button_text.text == "Pig" || button_text2.text == "Pig")
        {
            {
                pig_sound.Play();
                played++;
                Debug.Log(played);
       
            }
        }
        if (button_text.text == "Chicken" || button_text2.text == "Chicken")
        {
            {
                chicken_sound.Play();
                played++;
                Debug.Log(played);
       
            }
        }
        if (button_text.text == "Rooster" || button_text2.text == "Rooster")
        {
            {
                rooster_sound.Play();
                played++;
                Debug.Log(played);
       
            }
        }
        if (button_text.text == "Donkey" || button_text2.text == "Donkey")
        {
            {
                donkey_sound.Play();
                played++;
                Debug.Log(played);
        
            }
        }
        if (button_text.text == "Sheep" || button_text2.text == "Sheep")
        {
            {
                sheep_sound.Play();
                played++;
                Debug.Log(played);
        
            }
        }
        if (button_text.text == "Duck" || button_text2.text == "Duck")
        {
            {
                duck_sound.Play();
                played++;
                Debug.Log(played);

            }
        }


    }
    public void replay()
    {
        if (played > 0) 
        {
            //if (button_text2.text == "Woof" || button_text2.text == "Oink" || button_text2.text == "Moo" || button_text2.text == "Quack" || button_text2.text == "Hee-Haw" || button_text2.text == "Cluck" || button_text2.text == "Gobble Gobble" || button_text2.text == "Honk Honk")
            if (button_text.text == "Cat" || button_text2.text == "Cat")
             { 
                cat_sound.Play();
             }
            if (button_text.text == "Dog" || button_text2.text == "Dog")
            {
                {
                    dog_sound.Play();
                }
            }
            if (button_text.text == "Geese" || button_text2.text == "Geese")
            {
                {
                    geese_sound.Play();
                }
            }
            if (button_text.text == "Cow" || button_text2.text == "Cow")
            {
                {
                    cow_sound.Play();
                    
                }
            }
            if (button_text.text == "Turkey" || button_text2.text == "Turkey")
            {
                {
                    turkey_sound.Play();
                }
            }
            if (button_text.text == "Pig" || button_text2.text == "Pig")
            {
                {
                    pig_sound.Play();

                }
            }
            if (button_text.text == "Chicken" || button_text2.text == "Chicken")
            {
                {
                    chicken_sound.Play();
                    

                }
            }
            if (button_text.text == "Rooster" || button_text2.text == "Rooster")
            {
                {
                    rooster_sound.Play();

                }
            }
            if (button_text.text == "Donkey" || button_text2.text == "Donkey")
            {
                {
                    donkey_sound.Play();


                }
            }
            if (button_text.text == "Sheep" || button_text2.text == "Sheep")
            {
                {
                    sheep_sound.Play();

                }
            }
            if (button_text.text == "Duck" || button_text2.text == "Duck")
            {
                {
                    duck_sound.Play();

                }
            }


        }
    }
}
