using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBusyUI : MonoBehaviour
{
    //[SerializeField] GameObject BusyUIObject;

    private void Start()
    {
        //gameObject.SetActive(false);

        //UnitActionSystem.Instance.OnBusyChanged += ToggleBusyUIDisplay;

        UnitActionSystem.Instance.OnBusyChanged += UnitActionSystem_OnBusyChanged;

        Hide();
    }

    /*
    private void ToggleBusyUIDisplay(object sender, EventArgs e)
    {
        if(BusyUIObject.activeSelf == false)
        {
            BusyUIObject.SetActive(true);
        }
        else
        {
            BusyUIObject.SetActive(false);
        }
    }
    */
    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    private void UnitActionSystem_OnBusyChanged(object sender, bool isBusy)
    {
        if (isBusy)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }
}
