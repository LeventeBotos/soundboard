using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySoundd : MonoBehaviour
{
    public AudioSource src;
    public char keyChar = 'q'; // Change the variable name to 'keyChar' and set it to 'H' by default.

    void Start()
    {
        // src.Play(); // You can remove this line if you don't want the audio to play at the start.
    }

    void Update()
    {
        if (Input.GetKeyDown(keyChar.ToString())) // Convert the char to a string to compare with KeyCode.
        {
            src.Play();
        }
    }
}
