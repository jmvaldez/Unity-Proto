using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerTop : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(-1.6f, 25.44f, 0.24f);

    void LateUpdate()
    {
        // offsets the camera behind the player by adding the player's position
        transform.position = player.transform.position + offset;
    }
}
