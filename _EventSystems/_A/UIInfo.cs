/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/
/*	  Script Editor: Eazey丶亦泽                      
/*	  Blog   Adress: http://blog.csdn.net/eazey_wj     
/*	  GitHub Adress: https://github.com/Eazey 		 
/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/

/*	 Either none appetency, or determined to win.    */

/* * * * * * * * * * * * * * * * * * * * * * * * * * */
/* Script Overview: 
 * 
/* * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIInfo : MonoBehaviour,
    IPointerEnterHandler,IPointerExitHandler{

    public Text TextContent;

    void Start()
    {
        HideText();
    }

    public void ShowText()
    {
        TextContent.text = "This is " + name + "'s infomation!";
    }

    public void HideText()
    {
        TextContent.text = "None infomation.";
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ShowText();
        Debug.Log("OnPointerEnter call by " + name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HideText();
        Debug.Log("OnPointerExit call by" + name);
    }
}
