using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public Selectable firstInput;

    private void OnEnable()
    {
        firstInput.Select();
    }
}
