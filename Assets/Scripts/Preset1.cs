using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.EventSystems;

public class Preset1 : MonoBehaviour, ISelectHandler
{

    public ToggleGroup ToggleGroupA;
    public PlayQuantizedNotes playQuantizedNotes;

    //Part of the non-functioning preset logic. The idea was to call the
    //LoadSequence() function from the PlayQuantizedNotes class when the
    //button is selected. 
    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log(this.gameObject.name + " was selected");

        Debug.Log("Preset1 SCRIPT: " + PlayerPrefs.GetInt("ToggleAPreset0").ToString());
        playQuantizedNotes.LoadSequence();
        PlayQuantizedNotes.presets[0] = true;
        PlayQuantizedNotes.presets[1] = false;
        PlayQuantizedNotes.presets[2] = false;

    }
    void Awake()
    {
        //PlayerPrefs.Set
        
    }

    // Update is called once per frame
    void Update()
    {
        //Toggle selectedToggle = ToggleGroupA.ActiveToggles().FirstOrDefault();
        
        //Debug.Log(selectedToggle);
    }

    
}
