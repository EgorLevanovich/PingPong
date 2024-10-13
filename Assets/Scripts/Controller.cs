using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D[] _players;
    [SerializeField] private Transform _movementArea;
    [SerializeField] private Color _gizmosColor;
    
    private bool _isDragging;
    private Vector2 _playerSize;
    private Rigidbody2D _player;
    
    private Camera _camera;

    private void Start()
    {
        int index = PlayerPrefs.GetInt(PlayerSelect.SkinKey);
        for (int i = 0; i < _players.Length; i++)
        {
            if (i == index)
            {
                _player = _players[i];
                _player.gameObject.SetActive(true);
            }
            else
            {
                _players[i].gameObject.SetActive(false);
            }
        }

        _playerSize = _player.GetComponent<SpriteRenderer>().bounds.size;
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isDragging = true;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            _isDragging = false;
        }

        if (_isDragging)
        {
            Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 clampedPosition = GetClampedPosition(mousePos);
            _player.MovePosition(clampedPosition);
        }
    }

    private Vector2 GetClampedPosition(Vector2 targetPosition)
    {
        Vector2 areaMin = _movementArea.position - _movementArea.localScale / 2;
        Vector2 areaMax = _movementArea.position + _movementArea.localScale / 2;
        
        float clampedX = Mathf.Clamp(targetPosition.x, areaMin.x + _playerSize.x / 2, areaMax.x - _playerSize.x / 2);
        float clampedY = Mathf.Clamp(targetPosition.y, areaMin.y + _playerSize.y / 2, areaMax.y - _playerSize.y / 2);

        return new Vector2(clampedX, clampedY);
    }
    
    private void OnDrawGizmos()
    {
        if (_movementArea != null)
        {
            Gizmos.color = _gizmosColor;
            
            Vector2 areaCenter = _movementArea.position;
            Vector2 areaSize = _movementArea.localScale;
            
            Gizmos.DrawCube(areaCenter, areaSize);
            Gizmos.DrawWireCube(areaCenter, areaSize);
        }
    }
}
