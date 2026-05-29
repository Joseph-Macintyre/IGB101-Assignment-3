using UnityEngine;
using UnityEngine.UI;

public class JGameManager : MonoBehaviour
{
    public GameObject player;

    public int currentPickUps = 0;
    public int maxPickUps = 0;
    public bool levelComplete = false;

    public Text pickUpText;

    public AudioClip spawnSound;
    private AudioSource audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio = GetComponent<AudioSource>();
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

    public void SpawnPickUpEffect()
    {
        audio.PlayOneShot(spawnSound, 1.0f);
    }
}
