using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsEditor : MonoBehaviour
{

    public static bool level1, level2, level3;

    public Button lvl1_btn, lvl2_btn, lvl3_btn;

    void Start()
    {
        level1 = true;
    }


    private void Update()
    {
        if (level2 == true)
        {
            lvl2_btn.interactable = true;
        }

        if (level3 == true)
        {
            lvl3_btn.interactable = true;
        }
    }

}
