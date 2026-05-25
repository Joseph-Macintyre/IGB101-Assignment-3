using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MGameManager : MonoBehaviour
{
    public GameObject Player;
    public Text pickupText;

    //Pickup and Level Completion Logic
    public int currentPickups = 0;
    public int maxPickups = 6;
    public bool levelComplete = false;

    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
    }


    private void LevelCompleteCheck()
    {
        
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;

    }

    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }


}
