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
using System.Collections;
using System;

public class ScrollButton : MonoBehaviour,
    IPointerDownHandler,IPointerUpHandler,IPointerClickHandler
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

    [Range(0f, 1f)]
    public float Speed;
    private float progress = 0f;

    void ChangeBarValueByBtn(int dir)
    {
        progress = TargetScrollBar.value;
        progress += Speed * dir;
        progress = Mathf.Clamp01(progress);
        TargetScrollBar.value = progress;
    }

    private bool isDown = false;
    private float lastDownTime;
    public float DelayTime;

	void Update () 
	{
        if (isDown)
        {
            if (lastDownTime - Time.time > DelayTime)
            {

            }
        }
        else
        {
            lastDownTime = Time.time;
        }
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}
