using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public void onbuttonclick()
    {
        SceneManager.LoadScene("Mini_Game_Selection");
    }
}
