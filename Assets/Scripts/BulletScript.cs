using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float damage;
    public GameObject player;
    public ZombieScript zombie;

    private Dictionary<string, System.Action<Collision>> actions 
        = new Dictionary<string, System.Action<Collision>>();
    
    private void Start()
    {
        actions.Add("Zombie", HandleZombies);
        actions.Add("Environment", HandleEnvironment);
    }

    private void HandleEnvironment(Collision obj)
    {
        Destroy(gameObject);
    }

    private void HandleZombies(Collision obj)
    {
        zombie =  obj.gameObject.GetComponent<ZombieScript>();
        // destroy the bullet on impact
        Destroy(gameObject);
        zombie.health -= damage;
    }

    void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;
        if(actions.ContainsKey(tag))
        {
            actions[tag](collision);
        }
    }
}
