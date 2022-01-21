using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Uo
        if(collision.gameObject.name == "First_UP")
        {
            transform.position = GameObject.Find("Second_Exit").transform.position;
        }
        else if(collision.gameObject.name == "Second_UP")
        {
            transform.position = GameObject.Find("Third_Exit").transform.position;
        }
        else if (collision.gameObject.name == "Third_UP")
        {
            transform.position = GameObject.Find("Fourth_Exit").transform.position;
        }

        //Down
        if(collision.gameObject.name == "Second_Down")
        {
            transform.position = GameObject.Find("First_Exitz").transform.position;
        }
        else if (collision.gameObject.name == "Third_Down")
        {
            transform.position = GameObject.Find("Second_Exitz").transform.position;
        }
        else if (collision.gameObject.name == "Fourth_Down")
        {
            transform.position = GameObject.Find("Third_Exitz").transform.position;
        }
    }
}
