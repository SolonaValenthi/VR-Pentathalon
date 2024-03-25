using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocket : MonoBehaviour
{
    [SerializeField] private Transform _mainCamera;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = _mainCamera.localPosition / 2;
    }
}
