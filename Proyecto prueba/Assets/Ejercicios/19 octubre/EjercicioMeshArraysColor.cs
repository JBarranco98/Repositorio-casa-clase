using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioMeshArraysColor : MonoBehaviour
{
    public MeshRenderer[] meshes;

    // Start is called before the first frame update
    private void Start()
    {
        meshes = GetComponentsInChildren<MeshRenderer>();
        for (int i = 0; i < meshes.Length; i++)
        {
            meshes[i].material.color = Color.red;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}