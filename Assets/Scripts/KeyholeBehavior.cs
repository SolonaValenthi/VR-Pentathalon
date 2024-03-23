using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyholeBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _keyAttach;
    [SerializeField] private GameObject _key;
    [SerializeField] private GameObject _usedKey;

    GameObject _fakeKey;

    public void TurnKey()
    {
        StartCoroutine(Key());
    }

    IEnumerator Key()
    {
        float elapsed = 0.0f;
        yield return new WaitForSeconds(0.1f);
        _fakeKey = Instantiate(_usedKey, _key.transform.position, _key.transform.rotation);
        _key.SetActive(false);

        while (elapsed < 1)
        {
            _fakeKey.transform.Rotate(Vector3.back * 90 * Time.deltaTime);
            elapsed += Time.deltaTime;
            yield return null;
        }
    }
}
