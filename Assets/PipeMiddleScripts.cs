using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScripts : MonoBehaviour
{
    public LogicScripts logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripts>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {

            logic.addScore(1);
        }
    }
}
