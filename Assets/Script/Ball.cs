<<<<<<< HEAD
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
=======
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
>>>>>>> b000295c51912edf5bea5828bb8492ee79425d10
