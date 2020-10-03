using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnFallOff : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "FallOffZone")
        {
            SceneManager.LoadScene("SceneLosing", LoadSceneMode.Additive);
            Singleton_ScoreBoard.Instance.Losing++;
        }
    }
}
