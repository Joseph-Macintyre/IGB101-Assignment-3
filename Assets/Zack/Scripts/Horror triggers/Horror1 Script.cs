using UnityEngine;

public class Horror1Script : MonoBehaviour
{
    public GameObject Horror1;
    public bool StopRunning = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            StopRunning = true;
            Horror1.SetActive(true);
        }
    }
}
