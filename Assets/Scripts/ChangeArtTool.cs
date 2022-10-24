using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArtTool : MonoBehaviour
{
    [SerializeField] private MeshFilter _meshRendererTools;
    [SerializeField] private Mesh[] _modelsToChange;

    private int _currentModelIndex = 0;

    public void ChangeTool()
    {
        _meshRendererTools.mesh = _modelsToChange[_currentModelIndex];
        _currentModelIndex++;
        if (_currentModelIndex >= _modelsToChange.Length)
        {
            _currentModelIndex = 0;
        }
    }
}
