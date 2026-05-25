using UnityEngine;

public class youspinmerightround : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int rotSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
    }
}
