<<<<<<< HEAD
﻿using UnityEngine;

namespace Unity.Template.VR.Script
{
    public class TargetManager : MonoBehaviour
    {
        public static TargetManager Instance { get; private set; }
        [SerializeField] private int targetsAmount;
        [SerializeField] private Transform pointA;
        [SerializeField] private Transform pointB;
        [SerializeField] private GameObject targetPrefab;

        private int _targetCount;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            InstantiateTargets();
            _targetCount = targetsAmount;
        }

        private void InstantiateTargets() {
            for (int i = 0; i < targetsAmount; i++)
            {
                float randomX = Random.Range(pointA.position.x, pointB.position.x);
                float randomY = Random.Range(pointA.position.y, pointB.position.y);
                float randomZ = Random.Range(pointA.position.z, pointB.position.z);
                Vector3 targetPosition = new Vector3(randomX, randomY, randomZ);
                GameObject target = Instantiate(targetPrefab, targetPosition, 
                    Quaternion.Euler(90,0,0));
            }
        }

        public void OnTargetHit(GameObject target)
        {
            _targetCount--;
            Destroy(target);
            if (_targetCount == 0)
            {
                InstantiateTargets();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Vector3 center = (pointA.position + pointB.position) / 2;
            float sizeX = Mathf.Abs(pointA.position.x - pointB.position.x);
            float sizeY = Mathf.Abs(pointA.position.y - pointB.position.y);
            float sizeZ = Mathf.Abs(pointA.position.z - pointB.position.z);
            Gizmos.DrawWireCube(center, new Vector3(sizeX, sizeY, sizeZ)); 
        }
    }
=======
﻿using UnityEngine;

namespace Unity.Template.VR.Script
{
    public class TargetManager : MonoBehaviour
    {
        public static TargetManager Instance { get; private set; }
        [SerializeField] private int targetsAmount;
        [SerializeField] private Transform pointA;
        [SerializeField] private Transform pointB;
        [SerializeField] private GameObject targetPrefab;

        private int _targetCount;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            InstantiateTargets();
            _targetCount = targetsAmount;
        }

        private void InstantiateTargets() {
            for (int i = 0; i < targetsAmount; i++)
            {
                float randomX = Random.Range(pointA.position.x, pointB.position.x);
                float randomY = Random.Range(pointA.position.y, pointB.position.y);
                float randomZ = Random.Range(pointA.position.z, pointB.position.z);
                Vector3 targetPosition = new Vector3(randomX, randomY, randomZ);
                GameObject target = Instantiate(targetPrefab, targetPosition, 
                    Quaternion.Euler(90,0,0));
            }
        }

        public void OnTargetHit(GameObject target)
        {
            _targetCount--;
            Destroy(target);
            if (_targetCount == 0)
            {
                InstantiateTargets();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Vector3 center = (pointA.position + pointB.position) / 2;
            float sizeX = Mathf.Abs(pointA.position.x - pointB.position.x);
            float sizeY = Mathf.Abs(pointA.position.y - pointB.position.y);
            float sizeZ = Mathf.Abs(pointA.position.z - pointB.position.z);
            Gizmos.DrawWireCube(center, new Vector3(sizeX, sizeY, sizeZ)); 
        }
    }
>>>>>>> b000295c51912edf5bea5828bb8492ee79425d10
}