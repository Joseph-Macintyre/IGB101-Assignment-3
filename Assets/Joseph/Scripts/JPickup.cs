using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using System.Collections;

public class JPickup : MonoBehaviour
{
    JGameManager gameManager;
    public GameObject pickUpEffect;
    public GameObject pickUpEffectPos;
    private bool coroutineRunning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<JGameManager>();
    }

    private void OnTriggerStay(Collider otherObject)
    { 
        if (otherObject.transform.tag == "Player" && Input.GetKey("e") && coroutineRunning == false)
        {
            
            StartCoroutine(pickUp());
        }
    }

    private IEnumerator pickUp()
    {
        coroutineRunning = true;

        Instantiate(pickUpEffect, pickUpEffectPos.transform.position, transform.rotation);
        gameManager.SpawnPickUpEffect();

        yield return new WaitForSeconds (0.1f);

        coroutineRunning = false;
        gameManager.currentPickUps += 1;
        Destroy(this.gameObject);
    }
}
