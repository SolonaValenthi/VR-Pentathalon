using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyholeBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _key;

    public void TurnKey()
    {
        Debug.Log("keyhole selcted.");
        StartCoroutine(Key());
    }

    IEnumerator Key()
    {
        float elapsed = 0.0f;

        while (elapsed < 1)
        {
            _key.transform.Rotate(Vector3.back * 90 * Time.deltaTime);
            elapsed += Time.deltaTime;
            yield return null;
        }
    }
}
