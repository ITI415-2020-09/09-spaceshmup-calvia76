using UnityEngine;
    public class HomingMissile : MonoBehaviour
    {
        public Transform GetClosestEnemy(GameObject[] enemies, Transform fromThis)
        {
            Transform closestTarget = null;
            float closestDist = Mathf.Infinity;
            Vector3 currentPos = fromThis.transform.position;
            foreach (GameObject potentialTarget in enemies)
            {
                Vector3 directionToTarget = potentialTarget.transform.position - currentPos;
                float DistToTarget = directionToTarget.sqrMagnitude;
                if (DistToTarget < closestDist)
                {
                    closestDist = DistToTarget;
                    Transform transform1 = potentialTarget.transform;
                    closestTarget = transform1;
                }
            }
            return closestTarget;
        }
    }
