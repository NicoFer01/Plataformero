using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingPlayer : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private void Start()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(_player.position.x, -7.7f, 135.5f), transform.position.y, transform.position.z);
    }
}
