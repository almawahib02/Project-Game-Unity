using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationFunction : MonoBehaviour
{
    [SerializeField] menuButtonController MenuButtonController;
    void PlaySound(AudioClip whichSound){
        MenuButtonController.audioSource.PlayOneShot(whichSound);
    }
}
