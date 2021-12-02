using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCollision : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("WinScreen");
    }
}
