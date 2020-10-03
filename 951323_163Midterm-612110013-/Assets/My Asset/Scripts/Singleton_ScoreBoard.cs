using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton_ScoreBoard : Singleton<Singleton_ScoreBoard>
{
    [SerializeField]private Text _scoreHolder; private int _score = 0; 
    public int Score { get { return _score;} set { _score = value; Singleton_ScoreBoard.Instance._scoreHolder.text = "  Score: " + _score; } }
    [SerializeField]private Text _winningHolder; private int _winning = 0;
    public int Winning { get { return _winning;} set { _winning = value; Singleton_ScoreBoard.Instance._winningHolder.text = "  Winning: " + _winning; } }
    [SerializeField]private Text _losingHolder; private int _losing = 0;
    public int Losing { get { return _losing;} set { _losing = value; Singleton_ScoreBoard.Instance._losingHolder.text = "  Losing: " + _losing; } }



    private void Awake()
    {
        if (GameObject.Find("ScoreBoardNoDestroy") != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.gameObject.name = "ScoreBoardNoDestroy";
        }
        Singleton_ScoreBoard.Instance._scoreHolder.text = "  Score: " + _score;
        Singleton_ScoreBoard.Instance._winningHolder.text = "  Winning: " + _winning;
        Singleton_ScoreBoard.Instance._losingHolder.text = "  Losing: " + _losing;
    }
}
