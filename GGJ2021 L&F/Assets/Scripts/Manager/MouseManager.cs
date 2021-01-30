using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

//舍弃拖拽关联的方式，就不用这样序列化事件了
//[System.Serializable]
//public class EventVector3 : UnityEvent<Vector3> { }
public class MouseManager : MonoBehaviour
{
    public static MouseManager Instance;

    
    RaycastHit hitInfo;
    //public EventVector3 OnMouseClicked;
    public event Action<Vector3> OnMouseClicked;

    void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);

        Instance = this;
    }

    public void Update()
    {
        SetCursorTexture();
        MouseControl();
    }

    void SetCursorTexture() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            //切换光标贴图
        }
    }

    void MouseControl() 
    { 
        if(Input.GetMouseButtonDown(0) && hitInfo.collider != null)
        {
            if (hitInfo.collider.gameObject.CompareTag("Ground")) 
            {
                OnMouseClicked?.Invoke(hitInfo.point);
            }

        }
    }
    
}
