using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class Pickup : MonoBehaviour
{
    GameManager gameManager;
    public GameObject pickUpEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>(); 
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
            Instantiate(pickUpEffect, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
