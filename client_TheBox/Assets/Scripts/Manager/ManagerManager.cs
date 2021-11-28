using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerManager : Singleton<ManagerManager>
{
    public void Init()
    {
        ManagerUI.Instance.Init();
    }
}
