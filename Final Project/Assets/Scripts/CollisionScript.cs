using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    public GameObject player;

    //Detect collisions between the GameObjects with Colliders attached
    private void OnTriggerEnter(Collider other)
        {
            SceneManager.LoadScene("DeathScreen");
        }
}