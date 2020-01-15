using UnityEngine;

public class GroundCreator : MonoBehaviour
{
    [SerializeField] private GameObject _groundPrefab;
    [SerializeField] private Transform _renderPoint;

    private int _counter = 10;

    public void CreateGround()
    {
        Instantiate(_groundPrefab, new Vector3(_counter, _renderPoint.transform.position.y, _renderPoint.transform.position.z), Quaternion.identity);

        _counter *= 2;
    }
}
