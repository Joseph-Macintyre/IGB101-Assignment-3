using UnityEngine;

public class MPickup : MonoBehaviour
{
    MGameManager gameManager;
    private void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.transform.tag == "Player")
        {
            gameManager.currentPickups += 1;
            Destroy(this.gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<MGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
