using System.Collections;
using UnityEngine;

public class Horror2Trigger : MonoBehaviour
{
    public GameObject Horror2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Horror2.SetActive(true);
            StartCoroutine(MoveObject());
        }
    }

    IEnumerator MoveObject()
    {
        for (float i = Horror2.transform.position.x; i < -17; i++)
        {
            yield return new WaitForSeconds(0.2f);
            Horror2.transform.position = new Vector3(i, Horror2.transform.position.y, Horror2.transform.position.y);
        }
        
    }
}
