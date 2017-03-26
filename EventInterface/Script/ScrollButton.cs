/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/
/*	  Script Editor: Eazey丶亦泽                      
/*	  Blog   Adress: http://blog.csdn.net/eazey_wj     
/*	  GitHub Adress: https://github.com/Eazey 		 
/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/

/*	 Either none appetency, or determined to win.    */

/* * * * * * * * * * * * * * * * * * * * * * * * * * */
/* Script Overview: 
 * This is how to make IPointerDownHandler,
 * IPointerUpHandler and IPointerClickHandler
 * to complete UGUI Example that
 * use button to control scroll bar.
/* * * * * * * * * * * * * * * * * * * * * * * * * * */

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollButton : MonoBehaviour,
    IPointerDownHandler,IPointerUpHandler, IPointerClickHandler
{

    public enum DirectionType
    {
        None = 0,
        ToUp,
        ToDown
    }
    public DirectionType Direction;

    private int dir
    {
        get
        {
            switch (Direction)
            {
                case DirectionType.None:
                    return 0;

                case DirectionType.ToUp:
                    return 1;

                case DirectionType.ToDown:
                    return -1;
                default:
                    Debug.LogError("The type of direction is none!");
                    return 0;
            }
        }
    }

    public Scrollbar TargetScrollBar;

    //Click type - Long
    [Range(0f, 1f)] public float Speed;
    private float progress = 0f;

    //Click type - Once
    public float ScrollViewHeight;
    public float ContentHeight;
    private float progressLength { get { return ContentHeight - ScrollViewHeight; } }

    enum ClickType
    {
        Once,
        Long
    }

    void ChangeBarValueByBtn(ClickType clickType)
    {
        progress = TargetScrollBar.value;

        if (clickType == ClickType.Long)
            progress += Speed * dir * Time.deltaTime;
        else if (clickType == ClickType.Once)
            progress += ScrollViewHeight / progressLength * dir;

        progress = Mathf.Clamp01(progress);
        TargetScrollBar.value = progress;
    }

    private bool isDown = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }

    private float lastUpBtnTime = 0f;
    [Range(0f, 1f)] public float DelayTime;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Time.time - lastUpBtnTime <= DelayTime)
        {
            ChangeBarValueByBtn(ClickType.Once);
        }
    }

    void Update()
    {
        if (isDown)
        {
            if (Time.time - lastUpBtnTime > DelayTime)
            {
                ChangeBarValueByBtn(ClickType.Long);
            }
        }
        else
        {
            lastUpBtnTime = Time.time;
        }
    }   
}
