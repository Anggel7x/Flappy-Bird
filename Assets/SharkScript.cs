using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkScript : MonoBehaviour
{   
    public Rigidbody2D myRigidbody;
    public float flatStrength; 
    public LogicManager logic;
    public bool birdIsAlive = true; 
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flatStrength;
        }
    }

    public void OnCollisionEnter2D()
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
