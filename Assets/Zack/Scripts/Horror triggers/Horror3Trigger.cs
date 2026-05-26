using UnityEngine;

public class Horror3Trigger : MonoBehaviour
{
    public GameObject Horror3;
    public bool moveManaquins;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Horror3.SetActive(true);
            moveManaquins = true;
        }
    }
}
