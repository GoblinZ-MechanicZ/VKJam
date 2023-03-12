using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private static bool Busy = false;
    [SerializeField] private Vector3 OnEnterPopup;
    [SerializeField] private Vector3 OnExitPopup;
    [SerializeField] private float hoverAnimationTime = 0.5f;

    private IEnumerator doHover;

    private bool isShow = false;

    public void OnHoverEnter()
    {
        if (Busy && !isShow) { return; }

        if (doHover != null)
        {
            StopCoroutine(doHover);
        }

        isShow = !isShow;
        if (isShow) { Busy = isShow; }

        doHover = DoHover(isShow);
        StartCoroutine(doHover);
    }

    public void OnClick()
    {
        Destroy(this.gameObject);
    }

    private IEnumerator DoHover(bool show)
    {
        float hoverTimer = 0f;
        float hoverTimerEnd = hoverAnimationTime;

        Vector3 startPos, endPos;

        startPos = transform.localPosition;
        endPos = (show) ? OnEnterPopup : OnExitPopup;

        while (hoverTimer < hoverTimerEnd)
        {
            hoverTimer += Time.deltaTime;

            transform.localPosition = Vector3.Lerp(startPos, endPos, hoverTimer / hoverAnimationTime);

            yield return new WaitForEndOfFrame();
        }
        Busy = show;
    }
}
