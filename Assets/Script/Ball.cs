using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Ball : MonoBehaviour
{
    [SerializeField] private Throwable throwable;

    public void ResetBallFromManager() {
        BallManager.Instance.ResetBall(gameObject);
    }
}
