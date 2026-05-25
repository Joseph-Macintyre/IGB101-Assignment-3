using System.Collections;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ZGameManager : MonoBehaviour
{
    public GameObject player;
    public int currentPickups = 0;
    public int maxPickups = 6;
    public bool levelCompleted = false;
    public GameObject FireT;
    public GameObject FireAL;
    public GameObject FireAR;
    public GameObject FireLL;
    public GameObject FireLR;
    public bool isPlayerOnFire;
    public Material DarkSkybox;
    public DoorScript DS;
    public GameObject AmbienceAudio;
    public GameObject Horror1;
    int fogStop = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        levelCompletedUpdate();
        if (isPlayerOnFire) { StartCoroutine(OnFireCheck()); }
        VOID();
    }



    private void levelCompletedUpdate() 
    {
        if (currentPickups >= maxPickups)
        {
            levelCompleted = true;
        }
        else 
        { 
            levelCompleted = false;
        }

    }


    IEnumerator OnFireCheck()
    {
        if (isPlayerOnFire == true)
        {
            FireT.SetActive(true);
            FireAL.SetActive(true);
            FireAR.SetActive(true);
            FireLL.SetActive(true);
            FireLR.SetActive(true);

            yield return new WaitForSeconds(5);

            FireT.SetActive(false);
            FireAL.SetActive(false);
            FireAR.SetActive(false);
            FireLL.SetActive(false);
            FireLR.SetActive(false);
        }
    }

    private void VOID()
    {
        if (levelCompleted)
        {
            if (DS != null & DS.DoorOpened)
            {
                StartCoroutine(DarkSkies());
                UnityEngine.RenderSettings.skybox = DarkSkybox;

            }


        }
    }

    IEnumerator DarkSkies()
    {
        if (fogStop < 200)
        {
            Color FogColor = UnityEngine.RenderSettings.fogColor;
            Debug.Log(FogColor);
            UnityEngine.RenderSettings.fogColor = new Color(FogColor.r - 0.01f, FogColor.g - 0.01f, FogColor.b - 0.01f);
            yield return new WaitForSeconds(2f);
            fogStop++;
        }

    }

}