using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class level2 : MonoBehaviour
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
        SceneManager.LoadScene("Second_Level");
    }
}
