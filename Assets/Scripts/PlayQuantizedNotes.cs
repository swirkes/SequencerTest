using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayQuantizedNotes : MonoBehaviour
{

    public SoundManager soundManager;
    public AudioClip note_a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BPM.isNewBar)
        {
            soundManager.PlayNote(note_a);
        }
    }
}
