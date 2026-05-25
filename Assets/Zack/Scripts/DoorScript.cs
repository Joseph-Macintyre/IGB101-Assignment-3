using System.Threading.Tasks;
using UnityEditor.Build;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    ZGameManager gameManager;
    public Animator anims;
    public DoorArea DA;
    public bool DoorOpened;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ZGameManager>();
    }

    // Update is called once per frame
    async void Update()
    {

      if (Input.GetKey(KeyCode.F))
        {
            if (gameManager.levelCompleted & DA.Player_In_Vicinity)
            {
                anims.Play("Door Open");
                DoorOpened = true;
                await Awaitable.WaitForSecondsAsync(4f);
                if (this.gameObject != null) 
                {
                    //Destroy(this.gameObject);
                }
                
            }

        }

    }
}
