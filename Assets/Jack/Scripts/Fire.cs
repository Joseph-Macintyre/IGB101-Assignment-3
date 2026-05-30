using UnityEngine;

public class Fire : MonoBehaviour
{
    public ButtonClick buttonDead;

    [SerializeField] private ParticleSystem particleSystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (buttonDead.ded == true)
        {
            particleSystem.Play();
            Invoke ("KillEverything", 5);
        }
    }

    private void KillEverything()
    {
        Destroy(this.gameObject);
    }
}
