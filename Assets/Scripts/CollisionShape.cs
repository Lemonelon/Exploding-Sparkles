using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionShape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            var meshRenderer = this.GetComponent<MeshRenderer>();
            meshRenderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
