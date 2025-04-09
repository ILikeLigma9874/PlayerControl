using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayre : MonoBehaviour
{
    public GameObject RizzlerAndMostSkibidiestPersonInExistanceOfTheWholeEntireUniverseOMGImAboutToBUST;
    Vector3 offset = new Vector3(0, 6, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Updates camera position to stay behind the player in a certain xyz cooridnate
        transform.position = RizzlerAndMostSkibidiestPersonInExistanceOfTheWholeEntireUniverseOMGImAboutToBUST.transform.position + offset;
    }
}
