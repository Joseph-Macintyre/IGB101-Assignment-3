using UnityEngine;

public class ManaquinScript : MonoBehaviour
{
    Horror3Trigger Horror3Trigger;
    GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Horror3Trigger = GameObject.FindGameObjectWithTag("Horror3").GetComponent<Horror3Trigger>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Horror3Trigger.moveManaquins == true)
        {
            Lookat(Player.transform);
        }
    }

    private void Lookat(Transform target)
    {
        transform.LookAt(target);
    }
}
