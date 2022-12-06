using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;


public class Hover_Script_Buttons : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject[] sprites;
    

    private bool mouse_over = false;
    void Update()
    {

        if (mouse_over)
        {
            Debug.Log("mouse over!");
        }
        if(mouse_over && GetComponent<Image>().color == Color.green)
        {
            StartCoroutine(WaitForNext());
        }
        if (mouse_over && GetComponent<Image>().color == Color.red)
        {
            StartCoroutine(WaitForNext());
        }
        

    }

    IEnumerator WaitForNext()
    {
        yield return new WaitForSeconds(0.25f);

        if (mouse_over)
        {
            GetComponent<Image>().color = Color.grey;
        }
        else
        {
            GetComponent<Image>().color = Color.white;
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
        if( GetComponent<Image>().color == Color.green || mouse_over == false)
        {
            for (int i = 0; i < sprites.Length; i++)
            {
                sprites[i].GetComponent<Image>().color = Color.white;

            }
        }
        
    }
    
}
