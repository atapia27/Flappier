using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Zoomies : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    public float timesHit;
    

    // Use this for initialization
    void Start()
    {
        timesHit = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //Jump
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if(timesHit == 3)
        {
            gameManager.GameOver();
        }
    }


}
