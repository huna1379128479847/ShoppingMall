using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private GameObject _tile;
    [SerializeField] private int _rows = 5;
    [SerializeField] private int _cols = 5;

    private void Start()
    {
        for (int row = 0; row < _rows; row++)
        {
            for (int col = 0; col < _cols; col++)
            {
                Instantiate(_tile, new Vector3(row, col, -6),
                    Quaternion.identity, transform);
            }
        }
    }
}