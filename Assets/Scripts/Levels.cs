using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    
    public void level1Button()
    {
        SceneManager.LoadScene(2);
    }

    public void level2Button()
    {
        SceneManager.LoadScene(3);
    }

    public void level3Button()
    {
        SceneManager.LoadScene(4);
    }

}
