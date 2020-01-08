using UnityEngine;

public class GroundCreator : MonoBehaviour
{
    [SerializeField] private GameObject _groundPrefab;

    [SerializeField] private Transform _renderPoint;

    [SerializeField] private int _counter;

    public void CreateGround()
    {
        Instantiate(_groundPrefab, new Vector3(_counter, _renderPoint.transform.position.y, _renderPoint.transform.position.z), Quaternion.identity);

        _counter += _counter;
    }
}
