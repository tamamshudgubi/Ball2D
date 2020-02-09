using UnityEngine;

public class GroundCreator : MonoBehaviour
{
    [SerializeField] private GameObject _groundPrefab;
    [SerializeField] private Transform _renderPoint;

    private int _nextGroundNumber = 1;
    private int _groundLength = 15;

    public void CreateGround()
    {
        Instantiate(_groundPrefab, GetPosition(), Quaternion.identity);

        _nextGroundNumber++;
    }

    private Vector3 GetPosition()
    {
        return new Vector3(_nextGroundNumber * _groundLength, _renderPoint.transform.position.y, _renderPoint.transform.position.z);
    }
}
