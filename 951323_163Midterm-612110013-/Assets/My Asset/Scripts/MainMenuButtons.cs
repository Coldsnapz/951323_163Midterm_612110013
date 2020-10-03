using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenuButtons : MonoBehaviour, IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        /*if (audiosourceButtonUI.isPlaying)
            audiosourceButtonUI.Stop();
        Debug.Log("asd");
        audiosourceButtonUI.PlayOneShot(audioclipHoldOver);*/
    }
    public void LoadStageSelection()
    {
        SceneManager.LoadScene("SceneStageSelection");
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
    }
    public void LoadCredit()
    {
        SceneManager.LoadScene("SceneCredit");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
