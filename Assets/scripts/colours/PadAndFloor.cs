using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadAndFloor : MonoBehaviour
{
    Renderer m_Renderer;

    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        m_Renderer.material.color = Color.cyan;
    }
}
