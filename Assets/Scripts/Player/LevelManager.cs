using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int currentLevel = 1;
    [HideInInspector]
    public float currentExp = 0;
    private float nextLevelExp;

    [SerializeField]
    private const float MAX_EXPERIENCE_POINTS = 10000;

    [SerializeField]
    private AnimationCurve levelExperienceCurve;
    [SerializeField]
    private int maxLevel = 50;

    private void Awake() {
        Utility.levelManager = this;
        nextLevelExp = Mathf.Floor(levelExperienceCurve.Evaluate((currentLevel / maxLevel)) * MAX_EXPERIENCE_POINTS);
    }

    private void LevelUp() {
        currentLevel++;
        currentExp = 0;
        nextLevelExp = Mathf.Floor(levelExperienceCurve.Evaluate((currentLevel / maxLevel)) * MAX_EXPERIENCE_POINTS);
    }

    public void AddExperiencePoints(float exp) {
        currentExp += exp;
        if(currentExp >= nextLevelExp) {
            float restExp = currentExp - nextLevelExp;
            LevelUp();
            AddExperiencePoints(restExp);
        }
    }
}
