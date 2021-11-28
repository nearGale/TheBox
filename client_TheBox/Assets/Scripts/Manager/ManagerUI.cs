using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerUI : Singleton<ManagerUI>
{
    public Transform RootUI = null;
    string UI_PREFAB_PATH = "Prefabs/";

    public void Init()
    {
        FindRootUI();
    }

    public void ShowPopupWnd()
    {
    }

    public void FindRootUI()
    {
        if(RootUI != null)
        {
            return;
        }

        RootUI = GameObject.Find("Canvas").transform;
    }

    public UIBaseController Instant(string name, Transform parentTr = null)
    {
        if(parentTr == null)
        {
            parentTr = RootUI;
        }
        Object prefabObj = Resources.Load(UI_PREFAB_PATH + name);
        GameObject uiObj = GameObject.Instantiate(prefabObj, parentTr) as GameObject;
        UIBaseController uiController = uiObj.GetComponent<UIBaseController>();
        return uiController;
    }
}
