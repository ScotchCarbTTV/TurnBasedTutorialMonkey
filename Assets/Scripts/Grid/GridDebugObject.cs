using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GridDebugObject : MonoBehaviour
{
    
    [SerializeField] private TextMeshPro textMeshPro;
    private GridObject gridObject;
       

    private void Update()
    {
        textMeshPro.text = gridObject.ToString();
    }

    public void SetGridObject(GridObject gridObject)
    {
        this.gridObject = gridObject;
    }
}
