using UnityEngine;
using UnityEngine.SceneManagement;

public class ZLevelSwitch : MonoBehaviour
{

    ZGameManager gameManager;
    public string nextLevel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ZGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            if (gameManager.levelCompleted)
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
