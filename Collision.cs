using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    AudioSource aud;
    [SerializeField]
    AudioClip clip;
    UIManager uIManager;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        if (aud != null)
        {
            aud.clip = clip;
        }
        uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            aud.PlayOneShot(clip);
            uIManager.isAlive = false;
            Destroy(gameObject, 0.3f);
        }
    }
}
