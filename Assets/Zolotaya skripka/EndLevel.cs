using System;
using UnityEngine;
using UnityEngine.Events;
using YG;

public class EndLevel : MonoBehaviour
{
    private bool isAbleToFinish = true;
    public UnityEvent onFinish = new UnityEvent();
    public UnityEvent onFailure = new UnityEvent();
    public int collisionsCount = 0;
    public int levelOrder = 1;

    private void OnCollisionEnter2D(Collision2D other)
    {
        collisionsCount++;
        if (isAbleToFinish && other.gameObject.CompareTag("Finish"))
        {
            isAbleToFinish = false;
            Debug.Log(collisionsCount);

            if (levelOrder == YG2.saves.Progress)
            {
                YG2.saves.Progress++;
                YG2.SaveProgress();
            }
            
            onFinish.Invoke();
        }
    }

    private void OnDestroy()
    {
        onFailure.Invoke();
    }
}
