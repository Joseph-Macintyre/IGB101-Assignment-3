using UnityEngine;

public class rotator : MonoBehaviour
{

    public float xrotSpeed = 0.15f;
    public float yrotSpeed = 0.15f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xrotSpeed, yrotSpeed, 0.0f, Space.Self);// * rotSpeed * Time.deltaTime);
    }
}
