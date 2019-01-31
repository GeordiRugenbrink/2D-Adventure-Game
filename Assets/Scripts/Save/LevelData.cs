public class LevelData
{
    public int level;
    public float currentExp;

    public LevelData(LevelManager levelManager) {
        level = levelManager.currentLevel;
        currentExp = levelManager.currentExp;
    }
}
