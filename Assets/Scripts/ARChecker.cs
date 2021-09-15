using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using maxstAR;

public class ARChecker : MonoBehaviour
{
    [SerializeField] private GameObject buttonToNaturalDino;

    private void Awake()
    {
        buttonToNaturalDino.SetActive(TrackerManager.GetInstance().IsFusionSupported());
    }
}