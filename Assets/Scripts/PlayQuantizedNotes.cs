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
    public static bool[] presets = new bool[3];

    public AudioClip[] audioClips = new AudioClip[8];

    public SoundManager soundManager;

    //Begin with preset1 selected.
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

    //call the PlayColumn() function on all the columns for all the beats.
    //Maybe unnecessary, but it keeps the Update() function clean.
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

    //Part of the preset logic. Not functioning, but the idea is to check
    //which preset is selected, then iterate through each column (only column A
    //here) and set a PlayerPrefs int to the corresponding row.
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

    //Part of the preset logic. Not functioning, but the idea is to get the
    //PlayerPrefs int that was saved by the above function and use it to turn
    //the corresponding toggle on.
    public void LoadSequence()
    {
        toggleColumnA[PlayerPrefs.GetInt("ToggleApreset0")].isOn = true;
    }

    //Iterate through toggle array. If the toggle of the column corresponding
    //to the beat is on, stop the note (to avoid overdriving) and play it.
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

