using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public Color color;
    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {

        meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
