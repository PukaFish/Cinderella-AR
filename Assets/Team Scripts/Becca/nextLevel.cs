using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    void OnCollisionEnter2D (Collision2D coll)
    {
     
     string tagName = coll.collider.gameObject.tag;
      if(tagName == "endOfLevelTwo")
      {
        SceneManager.LoadScene("Cutscene_Three"); 
      } 
    }
}
