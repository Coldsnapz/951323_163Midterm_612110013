using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockMouse : MonoBehaviour
{
    CursorLockMode lockMode;
    CursorLockMode unlockMode;

    void Awake()
    {
        lockMode = CursorLockMode.Locked;
        unlockMode = CursorLockMode.None;
        Cursor.lockState = lockMode;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Cursor.lockState == lockMode)
            {
                Cursor.lockState = unlockMode;
            }
            else
            {
                Cursor.lockState = lockMode;
            }
        }
    }
}
