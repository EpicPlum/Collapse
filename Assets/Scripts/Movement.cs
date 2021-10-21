using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public AudioSource source;
    public static bool playerMoved;

    // Start is called before the first frame update
    void Start()
    {
        /*
        if (gameObject.GetComponent<AudioSource>() != null)
        {
            source = gameObject.GetComponent<AudioSource>();
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        playerMoved = false;

        playerMovement();
    }

    void playerMovement()
    {
        bool up = Input.GetKeyDown(KeyCode.UpArrow);
        bool down = Input.GetKeyDown(KeyCode.DownArrow);
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);

        //Move Up
        if (up && !(down || left || right))
        {
            playerMoved = true;
            //source.Play();
            transform.Translate(0,1,0);
        }
        //Move Down
        if (down && !(up || left || right))
        {
            playerMoved = true;
            //source.Play();
            transform.Translate(0,-1,0);
        }
        //Move Left
        if (left && !(down || up || right))
        {
            playerMoved = true;
            //source.Play();
            transform.Translate(-1,0,0);
        }
        //Move Right
        if (right && !(down || left || up))
        {
            playerMoved = true;
            //source.Play();
            transform.Translate(1,0,0);
        }
    }
}
