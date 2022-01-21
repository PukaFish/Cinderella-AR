using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class Cutscene : MonoBehaviour
{
    public GameObject comic;
    public Animator animator;

    public VirtualButtonBehaviour Vb;
    
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        comic.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        animator.Play("Read_One");
        comic.SetActive(true);
        //SceneManager.LoadScene("First_Level");
        //ScoreCounter.coinAmount = 0;
    }
}
