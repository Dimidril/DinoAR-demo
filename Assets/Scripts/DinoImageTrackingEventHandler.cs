using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DinoImageTrackingEventHandler : TrackingEventHandler
{
    public UnityEvent OnTrack;

    public override void OnTrackingFail()
    {
    }

    public override void OnTrackingSuccess()
    {
        OnTrack?.Invoke();
    }
}
