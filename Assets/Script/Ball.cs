using Unity.Template.VR.Script;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private LayerMask targetLayerMask;
    
    public void ResetBallFromManager()
    {
        // Cuando se suelta la bola
        BallManager.Instance.ResetBall(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == targetLayerMask)
        {
            GameObject target = collision.gameObject;
            TargetManager.Instance.OnTargetHit(target);
            Destroy(gameObject, 0.5f);
        }
    }
}
