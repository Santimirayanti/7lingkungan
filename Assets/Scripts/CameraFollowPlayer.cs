using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public BirdMovement birdMovement;
    public Vector3 offset;

    private void Update()
    {
        // Make camera follow the x position of the bird
        transform.position =new Vector3(birdMovement.transform.position.x + offset.x, offset.y, offset.z);
    }

}
