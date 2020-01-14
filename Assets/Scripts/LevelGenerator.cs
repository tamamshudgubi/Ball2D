using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GridObject[] _templates;
    [SerializeField] private Transform _player;
    [SerializeField] private float _visibilityLength;
    [SerializeField] private float _cellSize;

    private HashSet<Vector2Int> _collisionMatrix = new HashSet<Vector2Int>();

    private void Update()
    {
        FillRadius(_player.position, _visibilityLength);
    }

    private void FillRadius(Vector2 center, float visibilitylength)
    {
        var cellCountOnAxis = (int)(visibilitylength / _cellSize);
        var fillAreaCenter = WorldToGridPosition(center);

        for (int i = 0; i < cellCountOnAxis; i++)
        {
            TryCreateOnLayer(GridLayer.AboveGround, fillAreaCenter + new Vector2Int(i, 0));
            TryCreateOnLayer(GridLayer.OnGround, fillAreaCenter + new Vector2Int(i, 0));
        }
    }

    private void TryCreateOnLayer(GridLayer layer, Vector2Int gridPosition)
    {
        gridPosition.y = (int)layer;

        if (_collisionMatrix.Contains(gridPosition))
        {
            return;
        }
        else
        {
            _collisionMatrix.Add(gridPosition);
        }

        var template = GetRandomTemplate(layer);

        if (template == null)
        {
            return;
        }

        var position = GridToWorldPosition(gridPosition);

        Instantiate(template, position, Quaternion.identity);
    }

    private GridObject GetRandomTemplate(GridLayer layer)
    {
        var variants = _templates.Where(template => template.Layer == layer);

        if (variants.Count() == 0)
        {
            return variants.First();
        }

        foreach (var template in variants)
        {
            int random = Random.Range(0, 100);

            if (template.Chance > random)
            {
                return template;
            }
        }

        return null;
    }

    private Vector2 GridToWorldPosition(Vector2Int gridPosition)
    {
        return new Vector2(gridPosition.x * _cellSize, gridPosition.y * _cellSize);
    }

    private Vector2Int WorldToGridPosition(Vector2 worldPosition)
    {
        return new Vector2Int((int)(worldPosition.x / _cellSize), (int)(worldPosition.y / _cellSize));
    }
}

