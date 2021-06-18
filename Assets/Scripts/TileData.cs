using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class TileData : MonoBehaviour
{
    [System.Serializable]
    public struct rowData
    {
        public Toggle[] row;
    }

    public rowData[] rows = new rowData[8];
}