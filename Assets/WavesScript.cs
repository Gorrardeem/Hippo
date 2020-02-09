using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesScript : MonoBehaviour
{
    public Sprite waves1;
    public Sprite waves2;
    public float waveSwitchSeconds = .25f;
    private SpriteRenderer renderer;
    private float timeRemaining; 

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        timeRemaining = waveSwitchSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if(timeRemaining<= 0)
        {
            timeRemaining = waveSwitchSeconds;
            if(renderer.sprite== waves1)
            {
                renderer.sprite = waves2;
            }
            else
            {
                renderer.sprite = waves1;
            }
        }
    }
}
