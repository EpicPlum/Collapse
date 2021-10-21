using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text counterText;

    public static float seconds;
    public static float milSeconds;
    public float beatSeconds;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        seconds = (int)(beatSeconds - Time.timeSinceLevelLoad % 60f);
        milSeconds = (int)((beatSeconds - Time.timeSinceLevelLoad) * 1000f) % 1000;

        counterText.text = seconds.ToString("00") + ":" + milSeconds.ToString("000");
    }
}
