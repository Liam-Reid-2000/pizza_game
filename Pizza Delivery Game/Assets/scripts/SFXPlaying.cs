using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource coins;

    public void PlayCoins()
    {
        coins.Play();
    }
}
