/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/
/*	  Script Editor: Eazey丶亦泽                      
/*	  Blog   Adress: http://blog.csdn.net/eazey_wj     
/*	  GitHub Adress: https://github.com/Eazey 		 
/*- - - - - - - - - - - - - - - - - - - - - - - - - -*/

/*	 Either none appetency, or determined to win.    */

/* * * * * * * * * * * * * * * * * * * * * * * * * * */
/* Script Overview: 
/* * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class AllEventInterface : MonoBehaviour,
    IPointerEnterHandler, IPointerExitHandler,
    IPointerDownHandler, IPointerUpHandler, IPointerClickHandler,
    IDragHandler,IInitializePotentialDragHandler,IBeginDragHandler,IEndDragHandler,IDropHandler
{

    public void OnDrag(PointerEventData eventData)
    {
        //当鼠标在A对象按下并拖拽时 A对象每帧响应一次此事件
        //注：如果不实现此接口，则后面的四个接口方法都不会触发
        Debug.Log("OnDrag " + name);
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        //当鼠标在A对象按下还没开始拖拽时 A对象响应此事件
        //注：此接口事件与IPointerDownHandler接口事件类似
        //    有兴趣的朋友可以测试下二者的执行顺序这里不再赘述
        Debug.Log("OnInitializePotentialDrag " + name);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //当鼠标在A对象按下并开始拖拽时 A对象响应此事件
        // 此事件在OnInitializePotentialDrag之后响应 OnDrag之前响应
        Debug.Log("OnBeginDrag " + name);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //当鼠标抬起时 A对象响应此事件
        Debug.Log("OnEndDrag " + name);
    }

    public void OnDrop(PointerEventData eventData)
    {
        //A、B对象必须均实现IDropHandler接口，且A至少实现IDragHandler接口
        //当鼠标从A对象上开始拖拽，在B对象上抬起时 B对象响应此事件
        //此时name获取到的是B对象的name属性
        //eventData.pointerDrag表示发起拖拽的对象（GameObject）
        Debug.Log(eventData.pointerDrag.name + " OnDrop to " + name);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //鼠标点击A对象，按下鼠标时A对象响应
        //Debug.Log("OnPointerDown " + name);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //鼠标点击A对象，抬起鼠标时响应
        //无论鼠标在何处抬起（即不在A对象中）
        //都会在A对象中响应此事件
        //注：响应此事件的前提是A对象必须响应过OnPointerDown事件
        //Debug.Log("OnPointerUp " + name);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //鼠标点击该对象，抬起鼠标时响应
        //注：按下和抬起时鼠标要处于同一对象上
        //Debug.Log("OnPointerClick " + name);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter " + name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("OnPointerExit " + name);
    }
    
}


