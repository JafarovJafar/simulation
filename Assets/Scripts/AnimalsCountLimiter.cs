public class AnimalsCountLimiter
{
    public int GetAnimalsCount(int levelSize, int goalAnimalsCount)
    {
        int maxAnimalsCount = levelSize * levelSize / 2;
        if (goalAnimalsCount > maxAnimalsCount) return maxAnimalsCount;

        return goalAnimalsCount;
    }
}