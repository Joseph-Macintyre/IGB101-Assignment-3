using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public int currentPickUps = 0;
    public int maxPickUps = 0;
    public bool levelComplete = false;

    public Text pickUpText;

    public AudioSource[] audioSources;
    public float audioProx = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
    }

    private void LevelCompleteCheck()
    {
        if (currentPickUps >= maxPickUps)
            levelComplete = true;
        else
            levelComplete = false;
    }

    private void UpdateGUI()
    {
        pickUpText.text = "Pickups: " + currentPickUps + '/' + maxPickUps;
    }
}
