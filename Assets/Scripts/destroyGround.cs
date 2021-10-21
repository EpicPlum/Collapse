using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGround : MonoBehaviour
{
    public GameObject destroyed;
    public static int sumDestroyed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (gameObject.tag == "Ground3")
        {
            //destroyed = GameObject.Find("Ground2");
            Vector3 pos = gameObject.transform.position;

            Destroy(gameObject);
            sumDestroyed++;
            Instantiate(destroyed, pos, Quaternion.identity);
        }
        else if (gameObject.tag == "Ground2")
        {
            //destroyed = GameObject.Find("Ground");
            Vector3 pos = gameObject.transform.position;
            
            Destroy(gameObject);
            sumDestroyed++;
            Instantiate(destroyed, pos, Quaternion.identity);
        }
        else if (gameObject.tag == "Ground")
        {
            //destroyed = GameObject.Find("Air");
            Vector3 pos = gameObject.transform.position;

            Destroy(gameObject);
            sumDestroyed++;
            Instantiate(destroyed, pos, Quaternion.identity);
        }

    }

}
