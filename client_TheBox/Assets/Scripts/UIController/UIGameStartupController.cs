using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameStartupController : MonoBehaviour
{
    void Start()
    {
        ManagerManager.Instance.Init();
        InitView();
    }

    private void InitView()
    {
        List<DescFunc> listFunc = new List<DescFunc>
        {
            new DescFunc
            {
                eType = EFunctionType.GotoVirusNewsPage,
                Name = "疫情中风险地区"
            },
            //new DescFunc
            //{
            //    eType = EFunctionType.Print,
            //    Name = "BB"
            //},
        };

        UIBtnGroupController ctrl = ManagerUI.Instance.Instant("UIBtnGroup") as UIBtnGroupController;
        if(ctrl != null)
        {
            ctrl.SetViewData(listFunc);
        }
    }
}
