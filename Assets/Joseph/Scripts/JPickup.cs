using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using System.Collections;

public class JPickup : MonoBehaviour
{
    JGameManager gameManager;
    public GameObject pickUpEffect;
    public GameObject pickUpEffectPos;

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
        if (otherObject.transform.tag == "Player" && Input.GetKey("e"))
        {
            
            StartCoroutine(pickUp());
        }
    }

    private IEnumerator pickUp()
    {
        Instantiate(pickUpEffect, pickUpEffectPos.transform.position, transform.rotation);
        

        yield return new WaitForSeconds (0.1f);

        Destroy(this.gameObject);
        gameManager.currentPickUps += 1;
    }
}
