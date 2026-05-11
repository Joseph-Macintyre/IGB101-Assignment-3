using UnityEngine;

public class spawnTrigger : MonoBehaviour
{
    public GameObject spawnEffect;
    public GameObject skeleton;
    public GameObject spawnLocation;
    public AudioClip spawnSound;
    private AudioSource audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        Instantiate(spawnEffect, spawnLocation.transform.position, spawnLocation.transform.rotation);
        Instantiate(skeleton, spawnLocation.transform.position, spawnLocation.transform.rotation);
        audio.PlayOneShot(spawnSound, 1.0f);
    }
}
