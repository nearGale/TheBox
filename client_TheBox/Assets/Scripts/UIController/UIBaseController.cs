using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBaseController : MonoBehaviour
{
    private void Awake()
    {
        OnUIInit();
    }

    protected virtual void OnUIInit()
    {

    }

    protected UIBaseView InitView()
    {
        UIBaseView view = transform.GetComponent<UIBaseView>();
        return view;
    }
}
