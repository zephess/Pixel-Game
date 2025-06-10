using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{

    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private Transform _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _camera.transform.position = new Vector3( _player.position.x, _player.position.y, -10);
    }
}
