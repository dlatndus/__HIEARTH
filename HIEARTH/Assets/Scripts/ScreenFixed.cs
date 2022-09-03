using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFixed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetResolution();
    }

    public void SetResolution()
    {
        int setWidth = 1920;
        int setHight = 1080;

        Screen.SetResolution(setWidth, setHight, true);
    }
}
