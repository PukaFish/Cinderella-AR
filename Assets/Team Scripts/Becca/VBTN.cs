using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class VBTN : MonoBehaviour
{
    //https://www.youtube.com/watch?v=Ckw4RKKVE3k 
    //^youtube video for setting up a virtual button
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        SceneManager.LoadScene("First_Level");
        ScoreCounter.coinAmount = 0;
        //"Game" is just the name of the scene I switch it to, replace it with the name of your scene 
    }   //Also make sure to add the scenes to your build settings
}
