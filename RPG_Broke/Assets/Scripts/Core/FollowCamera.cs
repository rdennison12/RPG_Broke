using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;

        GameObject player;
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        void LateUpdate()
        {
            transform.position = target.position;
        }
    } 
}
