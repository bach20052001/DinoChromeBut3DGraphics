using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel;
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.GetComponent<AutoGenerateTree>().SetTime(0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
