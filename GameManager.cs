using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Button audioButton;
    [SerializeField]
    Sprite[] audioButtonSprites;
    AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.Find("Music").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ToogleAudioButton()
    {
        audioManager.ToogleAudio();
        if (audioManager.isMuted)
        {
            audioButton.image.sprite = audioButtonSprites[1];
        }
        else
        {
            audioButton.image.sprite = audioButtonSprites[0];
        }
        
    }
}
