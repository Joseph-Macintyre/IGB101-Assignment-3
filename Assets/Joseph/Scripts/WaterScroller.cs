using UnityEngine;

public class WaterScroller : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Renderer water = GetComponent<Renderer>();

        water.material.mainTextureOffset = new Vector2(Time.time * scrollSpeed, 0);
    }
}
