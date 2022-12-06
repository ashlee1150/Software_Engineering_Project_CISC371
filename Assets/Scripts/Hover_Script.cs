using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;


public class Hover_Script : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject[] sprites;
    

    private bool mouse_over = false;
    void Update()
    {

        if (mouse_over)
        {
            Debug.Log("mouse over!");
        }
        

    }

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        Debug.Log("Mouse enter");
        for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].GetComponent<Image>().color = Color.grey;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        Debug.Log("Mouse exit");
        
            for (int i = 0; i < sprites.Length; i++)
            {
                sprites[i].GetComponent<Image>().color = Color.white;

            }
        
        
    }
    
}
