using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Text score;
    float gameTime;
    [SerializeField]
    float scoreModifier=2f;
    public bool isAlive = true;
    [SerializeField]
    AudioManager audioManager;
    [SerializeField]
    GameObject reloadButton;
    // Start is called before the first frame update
    void Start()
    {
        reloadButton.SetActive(false);
        Time.timeScale = 1f;
        reloadButton.SetActive(false);
        gameTime = Time.time;
        audioManager.PlayClip();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        if (isAlive == false)
        {
            Time.timeScale = 0f;
            audioManager.StopClip();
            reloadButton.SetActive(true);
        }
    }

    void UpdateScore()
    {
        score.text = "Score: " +(int)(Time.time- gameTime) * scoreModifier;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }
}
