using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // the camera should be the same as the car's position
    // Start is called before the first frame update
    [SerializeField] GameObject thingToFollow;
    // Update is called once per frame
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-15);
    }
}
