using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] audiosClipsDialog;
    [SerializeField] private AudioClip[] audiosClipsSounds;
    [SerializeField] AudioSource audioMusic;
    [SerializeField] AudioSource audioDialogue;
    [SerializeField] AudioSource audioInteractions;


    private void Start()
    {
        audioMusic.Play();
    }

    private void Update()
    {
        if (!audioMusic.isPlaying)
        {
            audioMusic.Play();
        }
    }



    public void InteractionSound()
    {
        audioInteractions.PlayOneShot(audiosClipsSounds[0], 1f);
       

    }

    public void Doors()
    {
        audioInteractions.PlayOneShot(audiosClipsSounds[1], 1f);
    }

    public void InteractionDialoge(int whyinteraction)
    {
        audioInteractions.PlayOneShot(audiosClipsDialog[whyinteraction], 1f);


    }




}
