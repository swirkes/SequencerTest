using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{

    public int soundListSize = 8;
    private List<AudioSource> soundFileList;
    
    
    //Create a list of audio source game objects.
    void Start()
    {
        soundFileList = new List<AudioSource>();
        for(int i = 0; i < soundListSize; i++)
        {
            GameObject note = new GameObject("note");
            note.AddComponent<AudioSource>();
            note.transform.parent = this.transform;
            soundFileList.Add(note.GetComponent<AudioSource>());
        }
    }

    //Iterate through the list of audio sources and if it's not playing,
    //play it. If it is playing, stop the clip to avoid overdriving the
    //soundcard and then play it.
    public void PlayNote(AudioClip clip, float volume)
    {
        for(int i = 0; i < soundFileList.Count; i++)
        {
            if(!soundFileList[i].isPlaying)
            {
                soundFileList[i].clip = clip;
                soundFileList[i].volume = volume;
                soundFileList[i].Play();
                return;
            }
            else if (soundFileList[i].isPlaying)
            {
                soundFileList[i].clip = clip;
                soundFileList[i].volume = volume;
                soundFileList[i].Stop();
                soundFileList[i].Play();
            }
        }
    }

    //If the clip is playing, stop it.
    public void StopNote(AudioClip clip)
    {
        for (int i = 0; i < soundFileList.Count; i++)
        {
            if (soundFileList[i].isPlaying)
            {
                soundFileList[i].clip = clip;
                soundFileList[i].Stop();
                return;
            }
        }
    }  
}
