using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupA : MonoBehaviour
{
    public Toggle GetSelectedToggle()
    {
        Toggle[] toggles = GetComponentsInChildren<Toggle>();
        foreach (var t in toggles)
            if (t.isOn) return t;  //returns selected toggle
        return null;           // if nothing is selected return null
    }
}
