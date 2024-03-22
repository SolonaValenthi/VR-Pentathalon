using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehavior : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    [SerializeField] float _timer = 2f;
    [SerializeField] GameObject _explosionPrefab;

    private bool _grabbed = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DestroyTimer");
    }

    // Update is called once per frame
    void Update()
    {
        if (!_grabbed)
            RocketMovement();
    }

    private void RocketMovement()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    public void Grabbed()
    {
        _grabbed = true;
        StopCoroutine("DestroyTimer");
    }

    IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(_timer);
        DestroyThisWithExplosion();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target") || other.CompareTag("Ground"))
            DestroyThisWithExplosion();
    }

    void DestroyThisWithExplosion()
    {
        Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
