using UnityEngine;

public class DoorAnimation : MonoBehaviour
{

    public Animation doorAnimation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorAnimation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        openDoor();
    }

    private void openDoor()
    {
        if (Input.GetKeyDown("f"))
            doorAnimation.Play();
    }
}
