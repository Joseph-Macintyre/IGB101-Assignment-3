using UnityEngine;

public class chimeTrigger : MonoBehaviour
{
    public AudioClip chime;
    private AudioSource audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player") 
        {
            audio.PlayOneShot(chime, 1.0f);
        }    
    }
}
