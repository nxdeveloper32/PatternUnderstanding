using System.Collections;
using System;
using UnityEngine;

public class PointOfInterest : MonoBehaviour
{
    public static event Action<PointOfInterest> OnPointOfInterestEntered;

    [SerializeField]
    private string _poiName;
    public string PoiName { get { return _poiName; } }

    private void OnTriggerEnter(Collider other)
    {
        OnPointOfInterestEntered?.Invoke(this);
    }
}
