using System.Collections;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UIElements;
using UnityEngine.UI;

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


    public DoorScript DS;

    public GameObject AmbienceAudio;

    int fogStop = 0;

    GameObject[] Lights;

    public Text PickupText;

    ZLevelSwitch PlatformScript;

    private CharacterController CC;
    private Animator anim;
    public GameObject playerProp;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lights = GameObject.FindGameObjectsWithTag("Lights");
        PlatformScript = GameObject.FindGameObjectWithTag("Finish").GetComponent<ZLevelSwitch>();
        CC = player.GetComponent<CharacterController>();
        anim = player.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        levelCompletedUpdate();
        if (isPlayerOnFire) { StartCoroutine(OnFireCheck()); }
        VOID();
        UpdateGUI();
        Ascension();
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
    

    private void UpdateGUI()
    {
        PickupText.text = "Pickups:" + currentPickups + "/6";
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
                AmbienceAudio.SetActive(false);

                for(int i = 0; i < Lights.Length; i++)
                {
                    Lights[i].SetActive(false);
                }

            }


        }
    }

    IEnumerator DarkSkies()
    {
        if (fogStop < 200)
        {
            Color FogColor = UnityEngine.RenderSettings.fogColor;
            UnityEngine.RenderSettings.fogColor = new Color(FogColor.r - 0.01f, FogColor.g - 0.01f, FogColor.b - 0.01f);
            yield return new WaitForSeconds(2f);
            fogStop++;
        }

    }

    private void Ascension()
    {
        if (PlatformScript.OnPlatform)
        {

            player.SetActive(false);
            playerProp.SetActive(true);
            StartCoroutine(PlayerTransend());
            
        }
        
    }







    IEnumerator PlayerTransend()
    {
        bool TeleportUp = true;
        if (TeleportUp)
        {
            for (int i = 0; i < 50; i++)
            {
                playerProp.transform.position = new Vector3(playerProp.transform.position.x, playerProp.transform.position.y + 0.01f* i*0.1f, playerProp.transform.position.z);
                yield return new WaitForSeconds(i*i + 0.1f);
                
            }
            TeleportUp = false;
        }

    }



}