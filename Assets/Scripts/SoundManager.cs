using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{

    public int soundListSize = 8;
    private List<AudioSource> soundFileList;
    
    
    // Start is called before the first frame update
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

    public void PlayNote(AudioClip clip)
    {
        for(int i = 0; i < soundFileList.Count; i++)
        {
            if(!soundFileList[i].isPlaying)
            {
                soundFileList[i].clip = clip;
                soundFileList[i].volume = 0.25f;
                soundFileList[i].PlayOneShot(clip);
                return;
            }
            else if (soundFileList[i].isPlaying)
            {
                soundFileList[i].clip = clip;
                soundFileList[i].volume = 0.25f;
                soundFileList[i].Stop();
                soundFileList[i].PlayOneShot(clip);
            }
        }
        GameObject note = new GameObject("note");
        note.AddComponent<AudioSource>();
        note.transform.parent = this.transform;
        note.GetComponent<AudioSource>().clip = clip;
        note.GetComponent<AudioSource>().volume = 0.25f;
        note.GetComponent<AudioSource>().PlayOneShot(clip);
        soundFileList.Add(note.GetComponent<AudioSource>());
    }

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
