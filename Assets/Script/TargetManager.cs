using UnityEngine;

namespace Unity.Template.VR.Script
{
    public class TargetManager : MonoBehaviour
    {
        [SerializeField] private int targetsAmount;
        [SerializeField] private Transform pointA;
        [SerializeField] private Transform pointB;
        [SerializeField] private Target targetPrefab;

        public Target[] targets;

        private int _targetCount;

        private void Start()
        {
            targets = new Target[targetsAmount];
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
                var target = Instantiate(targetPrefab, targetPosition, Quaternion.identity);
                targets[i] = target;
                target.Hit += OnTargetHit;
            }
        }

        private void OnTargetHit()
        {
            _targetCount--;
            if (_targetCount == 0)
            {
                foreach (var target in targets)
                    target.Hit -= OnTargetHit;
                    
                targets = new Target[targetsAmount];
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
}