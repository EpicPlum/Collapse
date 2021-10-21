using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public bool isGrounded = true;
    public float beatSeconds;
    public static bool playerDestroyed;
    public GameObject finish;
    public moveScene reset;



    // Start is called before the first frame update
    void Start()
    {
         finish = GameObject.Find("Finish");
        reset = (moveScene)finish.GetComponent(typeof(moveScene));
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded == false  || Timer.seconds == 0)
        {
            reset.resetLevel(true);
            playerDestroyed = true;
        }

    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Ground2" || col.gameObject.tag == "Ground3")
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
