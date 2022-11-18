using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public void Mini_GameSelection()
    {
        SceneManager.LoadScene("Mini_Game_Selection");
    }

    public void replay_game_colorQuiz()
    {
        SceneManager.LoadScene("Color_Quiz");
    }
    public void replay_game_FarmQuiz()
    {
        SceneManager.LoadScene("Farm_Animal_Game");
    }

    public void InstructionsScreenForColorQuiz()
    {
        SceneManager.LoadScene("Instruction_Color_Quiz");
    }
    public void InstructionsScreenForFarmGame()
    {
        SceneManager.LoadScene("Instructions_Farm");
    }

    public void Credit_Scene()
    {
        SceneManager.LoadScene("Credit_Scene");
    }
    public void Main_Menu_Scene()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
