using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collect : MonoBehaviour
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreCounter.coinAmount += 1;
            Destroy(gameObject);
        }

    }
    private void Update()
    {
        if (ScoreCounter.coinAmount >= 15)
        {
            SceneManager.LoadScene("Cutscene_Two");
        }
    }
}
