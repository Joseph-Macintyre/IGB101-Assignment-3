using UnityEngine;

public class DoorArea : MonoBehaviour
{
    public bool Player_In_Vicinity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {

            Player_In_Vicinity = true;

        }
    }
}

