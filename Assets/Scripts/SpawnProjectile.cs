using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject projectile;
    [SerializeField] private float nextSpawn = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nextSpawn -= Time.deltaTime;
        if (nextSpawn <= 0)
        {
            nextSpawn = 5;
            Instantiate(projectile, transform.position, transform.rotation);
        }
        
    }
}
