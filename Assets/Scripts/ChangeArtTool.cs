using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArtTool : MonoBehaviour
{
    [SerializeField] private MeshFilter _meshRendererTools;
    [SerializeField] private GameObject[] _gameObjects;
    
    List<Mesh> _modelsToChange = new List<Mesh>();
    private int _currentModelIndex = 0;

    private void Start()
    {
        foreach (var gameObject in _gameObjects)
        {
            var mesh= gameObject.GetComponent<Mesh>();
            _modelsToChange.Add(mesh);
        }
    }

    public void ChangeTool()
    {
        _meshRendererTools.mesh = _modelsToChange[_currentModelIndex];
        _currentModelIndex++;
        if (_currentModelIndex >= _modelsToChange.Count)
        {
            _currentModelIndex = 0;
        }
    }
}
