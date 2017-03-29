/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/
/*	  Script Editor: Eazey丶亦泽                      
/*	  Blog   Adress: http://blog.csdn.net/eazey_wj     
/*	  GitHub Adress: https://github.com/Eazey 		 
/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/

/*	 Either none appetency, or determined to win.    */

/* * * * * * * * * * * * * * * * * * * * * * * * * * */
/* Script Overview: 
/* * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropImage : MonoBehaviour,IDropHandler {

    private Image image;

    void OnEnable()
    {
        image = GetComponent<Image>();
        if (image == null)
            image = gameObject.AddComponent<Image>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        Sprite s = GetSprite(eventData);
        if (s != null)
            image.sprite = s;
    }

    private Sprite GetSprite(PointerEventData eventData)
    {
        GameObject goSource = eventData.pointerDrag;
        if (goSource == null)
            return null;

        Image imgSource = eventData.pointerDrag.GetComponent<Image>();
        if (imgSource == null)
            return null;

        DragImage DragSource = imgSource.GetComponent<DragImage>();
        if (DragSource == null)
            return null;

        return imgSource.sprite;
    }
}
