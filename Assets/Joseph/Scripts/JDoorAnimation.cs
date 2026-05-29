using UnityEngine;

public class JDoorAnimation : MonoBehaviour
{

    public Animation animation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        //openDoor();
    }

    private void OnTriggerStay()
    {
        if (Input.GetKey("f"))
            animation.Play();
    }
}
