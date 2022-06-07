using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    int dusmanSayisi;

    private void Update()
    {
         dusmanSayisi = GameObject.FindGameObjectsWithTag("Enemies").Length;
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        


        if (collision.tag == "Player" && dusmanSayisi == 0)
        {
            Debug.Log(dusmanSayisi);

            string aktfisahne = SceneManager.GetActiveScene().name;


            switch (aktfisahne)
            {

                case "Level1":
                    LevelsEditor.level2 = true;
                    break;

                case "Level2":
                    LevelsEditor.level3 = true;
                    break;

                default:
                    break;
            }

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
