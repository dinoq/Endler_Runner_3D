using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{

    public float gameSpeed = 10;
    public float speedCoeficient = 0.2f;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameSpeed += Time.deltaTime * speedCoeficient;
    }

    public float getSpeed()
    {
        return gameSpeed;
    }

    public void stopGame()
    {
        gameSpeed = 0;
        speedCoeficient = 0;
        gameOver = true;
        GameObject panel = FindObjectOfType<Canvas>().transform.GetChild(1).gameObject;
        int time, coins;
        time = coins = 0;

        panel.SetActive(true);
        time = int.Parse(GameObject.Find("Current Time").GetComponent<Text>().text);
        GameObject.Find("Time Value").GetComponent<Text>().text = time.ToString();
        GameObject.Find("Total Value").GetComponent<Text>().text = (time + coins).ToString();

    }
}
