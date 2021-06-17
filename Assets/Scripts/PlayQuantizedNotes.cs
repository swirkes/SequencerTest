using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayQuantizedNotes : MonoBehaviour
{

    public Toggle[] toggleList0 = new Toggle[8];
    public Toggle[] toggleList1 = new Toggle[8];
    public Toggle[] toggleList2 = new Toggle[8];
    public Toggle[] toggleList3 = new Toggle[8];
    public Toggle[] toggleList4 = new Toggle[8];
    public Toggle[] toggleList5 = new Toggle[8];
    public Toggle[] toggleList6 = new Toggle[8];
    public Toggle[] toggleList7 = new Toggle[8];
    public SoundManager soundManager;
    public AudioClip[] audioClips = new AudioClip[8];

        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlaySequence();
        //if(BPM.isNewBar)
        //{
        //    if(toggleList0[0].isOn)
        //    {
        //        //soundManager.StopNote(note_a);
        //        soundManager.PlayNote(note_a);
        //    }
            
            
        //}
        //if(BPM.isBeat && BPM.upperTimeSignature == 4)
        //{
        //    if (toggleList0[3].isOn)
        //    {
        //        //soundManager.StopNote(note_a);
        //        soundManager.PlayNote(note_a);
        //    }
            

    }

    void PlaySequence()
    {
       
        switch (BPM.upperTimeSignature)
        {
            case 1:
                if(BPM.isBeat)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (toggleList0[i].isOn)
                        {

                            soundManager.StopNote(audioClips[i]);
                            soundManager.PlayNote(audioClips[i]);
                            
                        }
                    }
                }
                
                break;
            case 2:
                if(BPM.isBeat)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (toggleList1[i].isOn)
                        {
                            soundManager.StopNote(audioClips[i]);
                            soundManager.PlayNote(audioClips[i]);
                        }
                    }
                }
                
                break;
            case 3:
                for (int i = 0; i < 8; i++)
                {
                    if (toggleList2[i].isOn)
                    {
                        soundManager.StopNote(audioClips[i]);
                        soundManager.PlayNote(audioClips[i]);
                    }
                }
                break;
            case 4:
                for (int i = 0; i < 8; i++)
                {
                    if (toggleList3[i].isOn)
                    {
                        soundManager.StopNote(audioClips[i]);
                        soundManager.PlayNote(audioClips[i]);
                    }
                }
                break;
            case 5:
                for (int i = 0; i < 8; i++)
                {
                    if (toggleList4[i].isOn)
                    {
                        soundManager.StopNote(audioClips[i]);
                        soundManager.PlayNote(audioClips[i]);
                    }
                }
                break;
            case 6:
                for (int i = 0; i < 8; i++)
                {
                    if (toggleList5[i].isOn)
                    {
                        soundManager.StopNote(audioClips[i]);
                        soundManager.PlayNote(audioClips[i]);
                    }
                }
                break;
            case 7:
                for (int i = 0; i < 8; i++)
                {
                    if (toggleList6[i].isOn)
                    {
                        soundManager.StopNote(audioClips[i]);
                        soundManager.PlayNote(audioClips[i]);
                    }
                }
                break;
            case 8:
                for (int i = 0; i < 8; i++)
                {
                    if (toggleList7[i].isOn)
                    {
                        soundManager.StopNote(audioClips[i]);
                        soundManager.PlayNote(audioClips[i]);
                    }
                }
                break;
            default:
                break;

        }
    }
}
