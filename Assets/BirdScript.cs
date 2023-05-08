using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody2D;
    public float flapStrength;
    public LogicScripts logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        // gameObject.name = "Birds";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripts>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody2D.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
