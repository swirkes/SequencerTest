using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayQuantizedNotes : MonoBehaviour
{

    
    public Toggle[] toggleColumnA = new Toggle[8];
    public Toggle[] toggleColumnB = new Toggle[8];
    public Toggle[] toggleColumnC = new Toggle[8];
    public Toggle[] toggleColumnD = new Toggle[8];
    public Toggle[] toggleColumnE = new Toggle[8];
    public Toggle[] toggleColumnF = new Toggle[8];
    public Toggle[] toggleColumnG = new Toggle[8];
    public Toggle[] toggleColumnH = new Toggle[8];
    public Button Preset1;
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

    }

    void PlaySequence()
    {
        if (BPM.isNewBar)
        {
            for (int i = 0; i < toggleColumnA.Length; i++)
            {
                if (toggleColumnA[i].isOn)
                {
                    PlayerPrefs.SetInt("ToggleASelected", i);
                    soundManager.StopNote(audioClips[i]);
                    soundManager.PlayNote(audioClips[i], 0.125f);
                }
            }
        }
        if (BPM.isBeat && BPM.upperTimeSignature == 2)
        {
            for (int i = 0; i < toggleColumnB.Length; i++)
            {
                if (toggleColumnB[i].isOn)
                {
                    PlayerPrefs.SetInt("ToggleASelected", i);
                    soundManager.StopNote(audioClips[i]);
                    soundManager.PlayNote(audioClips[i], 0.125f);
                }
            }
        }
        if (BPM.isBeat && BPM.upperTimeSignature == 3)
        {
            for (int i = 0; i < toggleColumnC.Length; i++)
            {
                if (toggleColumnC[i].isOn)
                {
                    PlayerPrefs.SetInt("ToggleASelected", i);
                    soundManager.StopNote(audioClips[i]);
                    soundManager.PlayNote(audioClips[i], 0.125f);
                }
            }
        }
        if (BPM.isBeat && BPM.upperTimeSignature == 4)
        {
            for (int i = 0; i < toggleColumnD.Length; i++)
            {
                if (toggleColumnD[i].isOn)
                {
                    PlayerPrefs.SetInt("ToggleASelected", i);
                    soundManager.StopNote(audioClips[i]);
                    soundManager.PlayNote(audioClips[i], 0.125f);
                }
            }
        }
        if (BPM.isBeat && BPM.upperTimeSignature == 5)
        {
            for (int i = 0; i < toggleColumnE.Length; i++)
            {
                if (toggleColumnE[i].isOn)
                {
                    PlayerPrefs.SetInt("ToggleASelected", i);
                    soundManager.StopNote(audioClips[i]);
                    soundManager.PlayNote(audioClips[i], 0.125f);
                }
            }
        }
        if (BPM.isBeat && BPM.upperTimeSignature == 6)
        {
            for (int i = 0; i < toggleColumnF.Length; i++)
            {
                if (toggleColumnF[i].isOn)
                {
                    PlayerPrefs.SetInt("ToggleASelected", i);
                    soundManager.StopNote(audioClips[i]);
                    soundManager.PlayNote(audioClips[i], 0.125f);
                }
            }
        }
        if (BPM.isBeat && BPM.upperTimeSignature == 7)
        {
            for (int i = 0; i < toggleColumnG.Length; i++)
            {
                if (toggleColumnG[i].isOn)
                {
                    soundManager.StopNote(audioClips[i]);
                    soundManager.PlayNote(audioClips[i], 0.125f);
                }
            }
        }
        if (BPM.isBeat && BPM.upperTimeSignature == 8)
        {
            for (int i = 0; i < toggleColumnH.Length; i++)
            {
                if (toggleColumnH[i].isOn)
                {
                    soundManager.StopNote(audioClips[i]);
                    soundManager.PlayNote(audioClips[i], 0.125f);
                }
            }
        }
    }
}

