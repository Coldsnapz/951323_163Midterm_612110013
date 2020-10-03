using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextStage : MonoBehaviour
{
    [SerializeField] float _timeLeft = 30f;
    [SerializeField] Text _timeCounterHolder;
    [SerializeField] string _nextStage;
    private bool loseConfirm;
    void Start()
    {
        _timeCounterHolder.text = Mathf.Round(_timeLeft).ToString();
    }
    void Update()
    {
        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            _timeCounterHolder.text = Mathf.Round(_timeLeft).ToString();
        }
        if (_timeLeft <= 0)
        {
            _timeLeft = 0;
            if (!loseConfirm)
            {
                _timeCounterHolder.text = Mathf.Round(_timeLeft).ToString();
                SceneManager.LoadScene("SceneLosing", LoadSceneMode.Additive);
                loseConfirm = true;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Singleton_ScoreBoard.Instance.Score += (int)((_timeLeft)*1000);
            Singleton_ScoreBoard.Instance.Winning++;
            SceneManager.LoadScene(_nextStage);
        }
    }
}
