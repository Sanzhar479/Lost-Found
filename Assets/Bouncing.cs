using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    int randx, randy;
    float randpx, randpy;
    // Start is called before the first frame update
    void Start()
    {
        randpx = Random.Range(-0.5f, 0.5f);
        randpy = Random.Range(-0.7f, 10f);

        while (randx == 0 && randy == 0)
        {
            randx = Random.Range(-5, 5);
            randy = Random.Range(-5, 5);
        }
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(randx, randy);
        this.GetComponent<Rigidbody2D>().position = new Vector2(randpx, randpy);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
