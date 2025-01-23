using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    Renderer m_Renderer;

    
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        m_Renderer.material.color = Color.grey;
    }
}
