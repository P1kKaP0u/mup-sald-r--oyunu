using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skor : MonoBehaviour
{

    public static int scoreValue = 0;

    Text scoreTxt;

    private void Start()
    {
        scoreTxt = GetComponent<Text>();
    }

    private void Update()
    {
        scoreTxt.text = "SKOR: " + scoreValue;
    }

}
