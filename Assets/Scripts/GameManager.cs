using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerMovement Player;
    public GameObject GameOverPanel;
    public GameObject Light;
    public GetScore Score;
    public void GameOver()
    {
        GameOverPanel.SetActive(true);

        transform.gameObject.GetComponent<AutoGenerateTree>().enabled = false;
        transform.gameObject.GetComponent<AutoGenerateBird>().enabled = false;
        transform.gameObject.GetComponent<AutoGenerateGround>().enabled = false;

        Light.GetComponent<DayCycle>().enabled = false;
        Player.enabled = false;
        Score.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.GetComponent<AutoGenerateTree>().SetTime(1.5f);
        transform.gameObject.GetComponent<AutoGenerateBird>().SetTime(12.5f);
    }
}
