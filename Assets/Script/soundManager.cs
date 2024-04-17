using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class soundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] audiosClipsDialog;
    [SerializeField] private AudioClip[] audiosClipsSounds;
    [SerializeField] AudioSource audioMusic;
    [SerializeField] AudioSource audioDialogue;
    [SerializeField] AudioSource audioInteractions;

    public UnityEvent OnAudioComplete;


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
        audioInteractions.Stop();
        audioInteractions.PlayOneShot(audiosClipsSounds[0], 1f);
       

    }

    public void Doors()
    {
        audioInteractions.Stop();
        audioInteractions.PlayOneShot(audiosClipsSounds[100], 1f);
    }

    public void InteractionDialoge(int whyinteraction)
    {
        audioDialogue.Stop();
        audioDialogue.PlayOneShot(audiosClipsDialog[whyinteraction], 1f);
        if (whyinteraction != 13 && whyinteraction != 14 && whyinteraction != 15 && whyinteraction != 16 && whyinteraction != 17 && whyinteraction != 18 && whyinteraction != 19)
        {
            Invoke("AudioComplete", audiosClipsDialog[whyinteraction].length);
        }

    }

    void AudioComplete()
    {
        OnAudioComplete.Invoke();
    }




}
