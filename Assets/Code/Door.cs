using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    private AudioSource source;
    public int nextLevel;
    void Start()
    {
        source = this.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.Play();
        SceneManager.LoadScene(nextLevel);
    }
}
