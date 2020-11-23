using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public GameObject player;
    private float CurrentPosition;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "000000";
        CurrentPosition = player.transform.position.z;
    }

    public int GetMyScore()
    {
        return ((int)(player.transform.position.z - CurrentPosition));
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = ((int)(player.transform.position.z - CurrentPosition)).ToString("D6");
    }
}
