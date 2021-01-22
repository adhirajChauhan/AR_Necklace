using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class FaceMask : MonoBehaviour
{
    public GameObject faceMask;
    private List<AugmentedFace> _tempFaceMask = new List<AugmentedFace>();

    
    void Update()
    {
        Session.GetTrackables(_tempFaceMask, TrackableQueryFilter.All);

        if (_tempFaceMask.Count == 0)
        {
            faceMask.SetActive(false);
        }
        else
        {
            faceMask.SetActive(true);
        }
    }
}
