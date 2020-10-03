using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStageSelect : MonoBehaviour
{
    public void BBackToStageSelect()
    {
        SceneManager.LoadScene("SceneStageSelection");
    }
}
