using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBtnGroupController : UIBaseController
{
    private UIBtnGroupView m_View = null;

    protected override void OnUIInit()
    {
        base.OnUIInit();
        m_View = InitView() as UIBtnGroupView;
    }
    
    public void SetViewData(List<DescFunc> listFunc)
    {
        if(listFunc == null)
        {
            return;
        }

        foreach (var descFunc in listFunc) {
            UIBtnFunctionController ctrl = ManagerUI.Instance.Instant("UIBtnFunction", m_View.GridBtnGroup.transform) as UIBtnFunctionController;
            if (ctrl != null)
            {
                ctrl.SetViewData(descFunc);
            }
        }
    }
}
