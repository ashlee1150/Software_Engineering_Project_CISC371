using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit_Canvas_Change : MonoBehaviour
{

    public GameObject mainmenu_button1; //begin button
    public GameObject mainmenu_button2; // credits button
    public GameObject title; //title of game
    public GameObject names; //names of creators
    public GameObject credits_scene1_button1; //go to mainmenu
    public GameObject credits_scene1_button2; // goto credits 2
    public GameObject credits_scene2_button1; // goback to credits 2
    public GameObject credits_gobacktocredits2;
    public GameObject credit_scene3_button; //credits_3 proceed
    public GameObject credits_title;
    public GameObject MainMenu_Canvas;
    public GameObject Credits_Scene2;
    public GameObject Credits_Scene3;
    public GameObject credits_scene4;


    public void disable_mainmenue_enable_Credits1()
    {
        mainmenu_button1.SetActive(false);
        mainmenu_button2.SetActive(false);
        MainMenu_Canvas.SetActive(false);
        title.SetActive(false);
        names.SetActive(false);
        Credits_Scene2.SetActive(true);
        credits_title.SetActive(true);
        credits_scene1_button2.SetActive(true);
        credits_scene1_button1.SetActive(true);

    }

    public void disable_credits1_enableMainmenu()
    {
        mainmenu_button1.SetActive(true);
        mainmenu_button2.SetActive(true);
        MainMenu_Canvas.SetActive(true);
        title.SetActive(true);
        names.SetActive(true);
        Credits_Scene2.SetActive(false);
        credits_title.SetActive(false);
        credits_scene1_button2.SetActive(false);
        credits_scene1_button1.SetActive(false);
        credits_gobacktocredits2.SetActive(false);
        credit_scene3_button.SetActive(false);

    }

    public void disable_credits1_enablecredits2()
    {
        Credits_Scene2.SetActive(false);
        Credits_Scene3.SetActive(true);
        credits_scene2_button1.SetActive(true);
        credit_scene3_button.SetActive(true);
        credits_title.SetActive(true);
        credits_scene1_button2.SetActive(false);
        credits_scene1_button1.SetActive(false);


    }

    public void disable_credits2_enablecredits1()
    {
        Credits_Scene2.SetActive(true);
        Credits_Scene3.SetActive(false);
        credits_scene2_button1.SetActive(false);
        credits_title.SetActive(true);
        credits_scene1_button2.SetActive(true);
        credits_scene1_button1.SetActive(true);
        credit_scene3_button.SetActive(false);

    }

    public void disable_credits2_enablecredits3()
    {
        Credits_Scene3.SetActive(false);
        credits_scene4.SetActive(true);
        credits_scene2_button1.SetActive(false);
        credit_scene3_button.SetActive(false);
        credits_gobacktocredits2.SetActive(true);
        credits_title.SetActive(true);
    }

    public void disable_credits3_enable_credits2()
    {
        Credits_Scene3.SetActive(true);
        credits_scene4.SetActive(false);
        credits_scene2_button1.SetActive(true);
        credit_scene3_button.SetActive(true);
        credits_gobacktocredits2.SetActive(false);
        credits_title.SetActive(true);
    }
}
