using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    float cinderTimer;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
        cinderTimer = 30;
        seconds = 0;
    }

    // Update is called once per frame
    void Update()
    {
         cinderTimer -= Time.deltaTime;
         seconds = (int)(cinderTimer);
         GameObject.Find("Time_UI").GetComponent<Text>().text = "Intermission to next level ends in: " + seconds;

        if (SceneManager.GetActiveScene().name == "Cutscene_One" && seconds==0){
            SceneManager.LoadScene("First_Level");
        }
        else if(SceneManager.GetActiveScene().name == "Cutscene_Two" && seconds == 0)
        {
            SceneManager.LoadScene("Second_Level");
        }
    }
}


