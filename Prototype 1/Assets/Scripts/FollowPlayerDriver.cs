using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerDriver : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-0.17f, 2.27f, -0.09f);

    void LateUpdate()
    {
        // offsets the camera behind the player by adding the player's position
        transform.position = player.transform.position + offset;
    }
}
