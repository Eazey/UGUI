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

public class AllEventInterface : MonoBehaviour,
    IPointerEnterHandler, IPointerExitHandler,
    IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter " + name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("OnPointerExit " + name);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //鼠标点击A对象，按下鼠标时A对象响应
        Debug.Log("OnPointerDown " + name);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //鼠标点击A对象，抬起鼠标时响应
        //无论鼠标在何处抬起（即不在A对象中）
        //都会在A对象中响应此事件
        //注：响应此事件的前提是A对象必须响应过OnPointerDown事件
        Debug.Log("OnPointerUp " + name);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //鼠标点击该对象，抬起鼠标时响应
        //注：按下和抬起时鼠标要处于同一对象上
        Debug.Log("OnPointerClick " + name);
    }
}


