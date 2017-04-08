/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/
/*	  Script Editor: Eazey丶亦泽                      
/*	  Blog   Adress: http://blog.csdn.net/eazey_wj     
/*	  GitHub Adress: https://github.com/Eazey 		 
/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/

/*	 Either none appetency, or determined to win.    */

/* * * * * * * * * * * * * * * * * * * * * * * * * * */
/* Script Overview: 
 * The script target is that realize effect of drag image.
/* * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragImage : MonoBehaviour,
    IDragHandler,IBeginDragHandler,IEndDragHandler
    {

    private Image image;
    private GameObject go;

    void OnEnable()
    {
        image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (image.sprite == null)
        {
            Debug.LogError("Current component of 'Image' have none 'Sprite'.");
            return;
        }

        go = new GameObject("Draging");
        go.transform.SetParent(eventData.pointerDrag.transform.parent);

        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;

        Image goImg = go.AddComponent<Image>();
        goImg.sprite = image.sprite;
        goImg.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (go == null)
            return;

        go.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Destroy(go);
        go = null;
    }
}
