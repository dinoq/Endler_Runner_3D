using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;

    private GameSettings settings;
    private float time;

    private void Start()
    {
        settings = FindObjectOfType<GameSettings>();
    }
    void Update()
    {
        if (settings.gameOver)
        {
            return;
        }
        time += Time.deltaTime;
        text.text = time.ToString("0");
    }
}
