﻿using Coffee.UIEffects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayUI : MonoBehaviour
{
    public UITransitionEffect MatchStatusUI;

    private void Start()
    {
        MatchStatusUI.gameObject.SetActive(true);
        StartCoroutine(HideVersusScreen());
    }

    IEnumerator HideVersusScreen()
    {
        yield return new WaitForSeconds(5f);

        while (MatchStatusUI.effectFactor > 0)
        {
            MatchStatusUI.effectFactor -= Time.deltaTime * 2f;
            yield return null;
        }

        // Hide the match status UI for good
        MatchStatusUI.gameObject.SetActive(false);
    }
}
