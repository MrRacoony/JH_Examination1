using UnityEngine;

public class TriangleProjectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float timeAlive = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;
        transform.position += Vector3.left * (Time.deltaTime * 3);
        if (timeAlive >= 10)
        {
            Destroy(this.gameObject);
        }

    }
}
