using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}