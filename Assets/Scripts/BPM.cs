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
    private static int upperTimeSignature;
    public TextMeshProUGUI timeSignature;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectBeat();
    }

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
