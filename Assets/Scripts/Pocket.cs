using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocket : MonoBehaviour
{
    [SerializeField] private Transform _mainCamera;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(_mainCamera.localPosition.x, _mainCamera.localPosition.y / 1.7f, _mainCamera.localPosition.z);
        transform.localEulerAngles = Vector3.up * _mainCamera.localEulerAngles.y;
    }
}
