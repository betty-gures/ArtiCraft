using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArtTool : MonoBehaviour
{
    [SerializeField] private MeshFilter _meshRendererTools;
    [SerializeField] private Mesh[] _modelsToChange;
    [SerializeField] private Material[] _materials;
    [SerializeField] private GameObject[] _tryGrabMesh;

    private MeshRenderer _meshRenderer;

    public List<MeshFilter> _trygrabMeshRenderer = new List<MeshFilter>();
    private int _currentModelIndex = 0;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        foreach (var gameObject in _tryGrabMesh)
        {
            var mesh= gameObject.GetComponent<MeshRenderer>();
            //_trygrabMeshRenderer.Add(mesh);
        }
        
    }


    public void ChangeTool()
    {
        //_meshRendererTools.mesh = _trygrabMeshRenderer[0].;
        _currentModelIndex++;
        if (_currentModelIndex >= _modelsToChange.Length)
        {
            _currentModelIndex = 0;
        }
    }

    public void ChangeMaterial1()
    {
        _meshRenderer.material = _materials[0];
    }
    public void ChangeMaterial2()
    {
        _meshRenderer.material = _materials[1];
    }
    public void ChangeMaterial3()
    {
        _meshRenderer.material = _materials[2];
    }
    public void ChangeMaterial4()
        {
            _meshRenderer.material = _materials[3];
        }
    public void ChangeMaterial5()
        {
            _meshRenderer.material = _materials[4];
        }
    public void ChangeMaterial6()
        {
            _meshRenderer.material = _materials[5];
        }
    public void ChangeMaterial7()
        {
            _meshRenderer.material = _materials[6];
        }
   
}
