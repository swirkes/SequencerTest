using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BPM : MonoBehaviour
{
    private static BPM BPMInstance;
    private static int numColumns = 8;
    public float bpm = 60;
    private float barInterval, barTimer, beatInterval, beatTimer;
    public static bool isNewBar, isBeat;
    public static int barCount, beatCount;
    public static int upperTimeSignature;
    public TextMeshProUGUI timeSignature;

    //Make sure there is only one instance of the game object.
    private void Awake()
    {
        if(BPMInstance != null && BPMInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            BPMInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Update()
    {
        DetectBeat();
    }

    //Using deltaTime to count seconds and divide them by the tempo to get
    //the bar length. Dividing that by 8 to get each beat and sending that
    //value to the game screen to display the current column.
    void DetectBeat()
    {
        isNewBar = false;
        barInterval = 60 / bpm;
        barTimer += Time.deltaTime;
        if(barTimer >= barInterval)
        {
            barTimer -= barInterval;
            isNewBar = true;
            barCount++;
            Debug.Log("Bar");
        }

        isBeat = false;
        beatInterval = barInterval / numColumns;
        beatTimer += Time.deltaTime;
        if(beatTimer >= beatInterval)
        {
            beatTimer -= beatInterval;
            isBeat = true;
            beatCount++;
            Debug.Log("Beat");
            upperTimeSignature = (beatCount % 8) + 1;
            timeSignature.text = upperTimeSignature.ToString() + "/8";
        }
    }

}
