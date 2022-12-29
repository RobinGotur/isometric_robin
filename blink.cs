using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{
    private Renderer rendererd;
    // Start is called before the first frame update
    void Start()
    {
        rendererd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        rendererd.material.color = Color.red;
    }
    private void OnMouseExit()
    {
        rendererd.material.color = Color.white;
    }
}
