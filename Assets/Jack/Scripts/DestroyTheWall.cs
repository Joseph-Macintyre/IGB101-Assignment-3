using UnityEngine;

public class DestroyTheWall : MonoBehaviour
{
    public ButtonClick buttonDead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonDead.ded == true)
        {
            Debug.Log("Fire should be playing now");
            Invoke ("KillWall", 5);
        }
    }

    private void KillWall()
    {
        Destroy(this.gameObject);
    }
}
