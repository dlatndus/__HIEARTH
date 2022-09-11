using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    public static bool[] ncpTF = { false };
    public GameObject npcK;

    // Start is called before the first frame update
    void Awake()
    {
        isGameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }

        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }

        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }

        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }


    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
