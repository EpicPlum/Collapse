using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource destroySource;
    public AudioSource moveSource;
    public AudioSource beatLevelSource;
    private static Audio instance = null;

    int count = 0;
    int count2 = 0;
    int count3 = 0;

    public static Audio Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        /*
        Component[] sources = gameObject.GetComponents(typeof(AudioSource));

        destroySource = (AudioSource) sources[0];
        moveSource = (AudioSource) sources[1];
        beatLevelSource = (AudioSource) sources[2];
        */

    }

    // Update is called once per frame
    void Update()
    {

        if (Collision.playerDestroyed)
        {
            destroySource.Play();
            destroySource.Stop();
            count++;
            Debug.Log("destroySource Count: " + count);
        }

        if(Movement.playerMoved)
        {
            moveSource.Play();
            count2++;
            Debug.Log("moveSource Count: " + count2);
        }

        if (moveScene.playerWon)
        {
            beatLevelSource.Play();
            beatLevelSource.Stop();
            count3++;
            Debug.Log("beatLevelSource Count: " + count3);
        }


    }
}
