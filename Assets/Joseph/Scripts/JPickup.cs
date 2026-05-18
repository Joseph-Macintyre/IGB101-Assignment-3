using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class JPickup : MonoBehaviour
{
    JGameManager gameManager;
    public GameObject pickUpEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<JGameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider otherObject)
    { 
        if (otherObject.transform.tag == "Player" && Input.GetKeyDown("e"))
        {
            gameManager.currentPickUps += 1;
            gameManager.SpawnPickUpEffect();
            Destroy(this.gameObject);
        }
    }
}
