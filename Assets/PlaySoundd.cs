using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class PlaySoundd : MonoBehaviour
{

    public AudioSource src;
    // Start is called before the first frame update
    void Start()
    {
        // src.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            src.Play();
        }
    }
}
