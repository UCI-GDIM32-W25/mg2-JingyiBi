using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float moveSpeed = 7f;
    
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UI.instance.AddPoint();
            Destroy(gameObject);
        }
    }
}
