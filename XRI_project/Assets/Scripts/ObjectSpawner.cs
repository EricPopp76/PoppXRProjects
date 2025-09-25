using UnityEngine;
using UnityEngine.XR;

public class ObjectSpawner : MonoBehaviour
{

    /*
    Select to spawn
    Where Objects Spawn
    Cooldown period
    Input - Button
    Hand
     
     */

    public GameObject objectPrefab; //Object to spawn
    public Transform spawnPoint; //Where it spawns
    public XRNode controllerNode = XRNode.RightHand;
    public float spawnCooldown = 1.0f; // Need a coroutine
    private bool CanSpawn = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
