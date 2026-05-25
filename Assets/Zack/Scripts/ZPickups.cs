using UnityEngine;

public class ZPickups : MonoBehaviour
{
    ZGameManager gameManager;
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
        if(other.transform.tag == "Player")
        {
            gameManager.currentPickups += 1;
            if (this.gameObject.name == "FirePit") {
                gameManager.isPlayerOnFire = true;
                Debug.Log("Check");
            }
            Destroy(this.gameObject);

        }
    }
}
