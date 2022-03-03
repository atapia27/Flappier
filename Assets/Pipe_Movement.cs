using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Movement : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
