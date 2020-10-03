using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStage : MonoBehaviour
{
    public void BStage1Select()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void BStage2Select()
    {
        SceneManager.LoadScene("Stage2");
    }
}
