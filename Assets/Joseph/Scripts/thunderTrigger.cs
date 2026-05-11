using UnityEngine;

public class thunderTrigger : MonoBehaviour
{
    public GameObject fallenTwig;
    public GameObject oakTree;
    public AudioClip thunder;
    private AudioSource audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        Instantiate(fallenTwig, oakTree.transform.position, oakTree.transform.rotation);
        audio.PlayOneShot(thunder, 1.0f);
    }
}
