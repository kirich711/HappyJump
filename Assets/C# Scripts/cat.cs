using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cat : MonoBehaviour
{
    public static cat instance;

    float horizontal;
    public Rigidbody2D catRigid;
    public object deathScreen;

    void Start()
    {
        if (instance == null)
        {
            instance = this; 
        }

        

    }

    
    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }

        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        catRigid.velocity = new Vector2(Input.acceleration.x * 10f, catRigid.velocity.y);

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {   
            SceneManager.LoadScene(0);
        }
    }
}
