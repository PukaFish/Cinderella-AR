using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour
{
    private SpriteRenderer sprite;
    public float speed;
    private Transform target;

    public bool facingRight = false;

    // Start is called before the first frame update
    void Start()
    {
        //  Invoke("Update", 30);
        StartCoroutine(enumerator());
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
       
        if (target.transform.position.x < gameObject.transform.position.x && facingRight)
            Flip();
        if (target.transform.position.x > gameObject.transform.position.x && !facingRight)
            Flip();
    }
    void Flip()
    {
        //here your flip funktion, as example
        facingRight = !facingRight;
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.x *= -1;
        gameObject.transform.localScale = tmpScale;
    }

    IEnumerator enumerator()
    {
        yield return new WaitForSecondsRealtime(30.0f);
    }
}