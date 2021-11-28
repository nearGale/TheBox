using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBtnFunctionController : UIBaseController
{
    UIBtnFunctionView m_View = null;

    protected override void OnUIInit()
    {
        base.OnUIInit();
        m_View = InitView() as UIBtnFunctionView;
    }

    public void SetViewData(DescFunc desc)
    {
        m_View.TextBtn.text = desc.Name;
        m_View.BtnFunction.onClick.AddListener(delegate()
        {
            OnBtnClick(desc.eType);
        });
    }

    private void OnBtnClick(EFunctionType funcType)
    {
        switch (funcType)
        {
            case EFunctionType.Print:
                Debug.LogError("TEST");
                break;
            case EFunctionType.GotoVirusNewsPage:
                Application.OpenURL(Config.UrlCovid19);
                break;
            default:
                break;
        }
    }

}
