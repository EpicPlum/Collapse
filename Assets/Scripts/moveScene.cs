using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    public string nextLevel;
    public static string currLevel;
    public int beatLevel;
    public int beatLevel2;
    public float beatSeconds;
    //public AudioSource source;
    public static bool playerWon;

    void Start()
    {
        /*
        if (gameObject.GetComponent<AudioSource>() != null)
        {
            source = gameObject.GetComponent<AudioSource>();
        }
        */

        currLevel = SceneManager.GetActiveScene().name;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Player" &&  (beatLevel == destroyGround.sumDestroyed || beatLevel2 == destroyGround.sumDestroyed) && Timer.seconds >= 0)
        {
            resetLevel(false);
        }
        else
        {
            resetLevel(true);
        }
    }

    public void resetLevel(bool dead)
    {
        if(dead)
        {
            Destroy(GameObject.FindWithTag("Player"));
            Debug.Log("numtoBeatLevel: " + beatLevel.ToString());
            Debug.Log("numDestroyed: " + destroyGround.sumDestroyed.ToString());
            destroyGround.sumDestroyed = 1;
            Timer.seconds = beatSeconds;
            Timer.milSeconds = 0;
            SceneManager.LoadScene("Death");
        }
        else
        {
            playerWon = true;
            SceneManager.LoadScene(nextLevel);
            destroyGround.sumDestroyed = 0;
            Timer.seconds = beatSeconds;
            Timer.milSeconds = 0;
        }
    }
}
