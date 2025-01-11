using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] public int _numSeeds = 5;
    [SerializeField] private PlantCountUI _plantCountUI;
    [SerializeField] private Rigidbody2D _rigidBody2D;


  
    private void Update()
    { 
        _rigidBody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * _speed;
    }

    public void PlantSeed ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_plantPrefab, transform.position, Quaternion.identity);
        }
        
    }
}
