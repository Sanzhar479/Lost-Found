using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blindness_Effect : MonoBehaviour
{
    private AudioSource source;
    public SpriteRenderer[] sprites;
    public Collider2D player;
    void Start()
    {
        source = this.GetComponent<AudioSource>();
        for (int i = 0; i < sprites.Length; i++)
            sprites[i].enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < sprites.Length; i++)
            if (collision == player)
            {
                source.Play();
                sprites[i].enabled = true;
            }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        for (int i = 0; i < sprites.Length; i++)
            if (collision == player)
                sprites[i].enabled = false;
    }
}
