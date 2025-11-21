using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnCollision : MonoBehaviour
{
    [Tooltip("The colliding object that we want to trigger these events with needs to use a tag of the same name as typed in this variable")]
    public string tagToActivate = "Player";
    
    public UnityEvent onCollisionEnter, onCollisionExit;

    private void Awake()
    {
        if ((GetComponent<Collider>() == null) && (GetComponent<Collider2D>() == null))
        {
            Debug.Log($"{gameObject} is missing a collider");
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag(tagToActivate))
        {
            onCollisionEnter.Invoke();
        }
    }
    
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag(tagToActivate))
        {
            onCollisionExit.Invoke();
        }
    }
}
