[System.Serializable]
public class SaveData
{
    public LevelData levelData;
    public PlayerHealthData playerHealthData;

    //This is (going to be) a pretty long constructor, but it works
    public SaveData(LevelData levelData, PlayerHealthData playerHealthData) {
        this.levelData = levelData;
        this.playerHealthData = playerHealthData;
    }
}
