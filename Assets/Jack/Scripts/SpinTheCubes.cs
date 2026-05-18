using UnityEngine;

public class SpinTheCubes : MonoBehaviour
{
    bool Up;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GoUp();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0,3f,0);
        if (Up)
        {
            transform.Translate(0,0.02f,0);
        }
        else
        {
            transform.Translate(0,-0.02f,0);
        }
    }

    private void GoUp()
    {
        Up = true;
        Invoke("GoDown", 3);
    }

    private void GoDown()
    {
        Up = false;
        Invoke("GoUp", 3);
    }
}
