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
    //public Toggle[] presets = new Toggle[3];
    public SoundManager soundManager;
    public AudioClip[] audioClips = new AudioClip[8];
    public static bool[] presets = new bool[3];


    // Start is called before the first frame update
    void Start()
    {
        presets[0] = true;
        presets[1] = false;
        presets[2] = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        PlaySequence();
        SaveSequence();
    }

    void PlaySequence()
    {
        PlayColumn(toggleColumnA, 1);
        PlayColumn(toggleColumnB, 2);
        PlayColumn(toggleColumnC, 3);
        PlayColumn(toggleColumnD, 4);
        PlayColumn(toggleColumnE, 5);
        PlayColumn(toggleColumnF, 6);
        PlayColumn(toggleColumnG, 7);
        PlayColumn(toggleColumnH, 8);
    }

    void SaveSequence()
    {
        for (int i = 0; i < presets.Length - 1; i++)
        {
            if (presets[i])
            {
                for (int j = 0; j < 8; j++)
                {
                    if (toggleColumnA[j].isOn)
                    {
                        PlayerPrefs.SetInt("ToggleAPreset" + i.ToString(), j);
                        Debug.Log("Column A: Preset: " + i.ToString() + " Row: " + j.ToString());
                        Debug.Log(PlayerPrefs.GetInt("ToggleAPreset0"));
                    }
                }
            }
        }
    }

    public void LoadSequence()
    {
        toggleColumnA[PlayerPrefs.GetInt("ToggleApreset0")].isOn = true;
    }

    void PlayColumn(Toggle[] toggles, int beat)
    {
        if (BPM.isBeat && BPM.upperTimeSignature == beat)
        {
            for (int i = 0; i < toggles.Length; i++)
            {
                if (toggles[i].isOn)
                {
                    soundManager.StopNote(audioClips[i]);
                    soundManager.PlayNote(audioClips[i], 0.125f);
                }
                
            }
        }
    }

}

