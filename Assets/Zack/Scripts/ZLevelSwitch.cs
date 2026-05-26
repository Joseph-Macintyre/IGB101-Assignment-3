using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZLevelSwitch : MonoBehaviour
{

    ZGameManager gameManager;
    public string nextLevel;
    public bool OnPlatform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ZGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private async void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            if (gameManager.levelCompleted)
            {
                OnPlatform = true;
                await Awaitable.WaitForSecondsAsync(5);
                SceneManager.LoadScene(nextLevel);
            }
        }
    }


}
