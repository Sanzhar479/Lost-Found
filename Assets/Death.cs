using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public int nextLevel;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        SceneManager.LoadScene(nextLevel);
    }
}
