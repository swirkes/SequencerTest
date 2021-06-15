using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                soundFileList[i].Play();
                return;
            }
        }
        GameObject note = new GameObject("note");
        note.AddComponent<AudioSource>();
        note.transform.parent = this.transform;
        note.GetComponent<AudioSource>().clip = clip;
        note.GetComponent<AudioSource>().Play();
        soundFileList.Add(note.GetComponent<AudioSource>());
    }
}
