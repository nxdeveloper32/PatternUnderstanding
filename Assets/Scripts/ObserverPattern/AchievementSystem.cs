using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PointOfInterest.OnPointOfInterestEntered += PointOfInterest_OnPointOfInterestEntered;
    }
    void OnDestroy()
    {
        PointOfInterest.OnPointOfInterestEntered -= PointOfInterest_OnPointOfInterestEntered;
    }
    // Update is called once per frame
    private void PointOfInterest_OnPointOfInterestEntered(PointOfInterest poi)
    {
        string achieventKey = "achievement-" + poi.PoiName;
        Debug.Log("Unlocked " + achieventKey);
    }
}
