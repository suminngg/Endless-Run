using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject popUp;

    private void Start()
    {
        instance = this;
    }

    public void UIActive()
    {
        Invoke("InvokeActive", 1.5f);
    }

    public void InvokeActive()
    {
        popUp.SetActive(true);
    }
}
