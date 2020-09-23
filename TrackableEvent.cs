using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrackableEvent : DefaultTrackableEventHandler
{

    public UnityEvent onTrackingFound;
    public UnityEvent onTrackingLost;
    // Start is called before the first frame update
    protected override void OnTrackingFound()
    {
       base.OnTrackingFound();
       onTrackingFound.Invoke();
    }

    // Update is called once per frame
    protected override void OnTrackingLost()
    {
      base.OnTrackingLost();
      onTrackingLost.Invoke();
    }
}
