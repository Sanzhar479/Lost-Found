using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioClip PlayerJump, Teleport, sight;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        PlayerJump = Resources.Load<AudioClip>("Jump");
        Teleport = Resources.Load<AudioClip>("PlayerTeleport");
        sight = Resources.Load<AudioClip>("Sight");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    { 
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Jump":
                audioSrc.PlayOneShot(PlayerJump);
                break;
            case "PlayerTeleport":
                audioSrc.PlayOneShot(Teleport);
                break;
            case "Sight":
                audioSrc.PlayOneShot(sight);
                break;

        }

    }
}
