namespace AdventOfCode.Days;

internal class Day1
{
    private readonly List<int> elfCalories = new();

    private void Calc()
    {
        string calories = File.ReadAllText("./2022/Day1/Calories.txt");
        int currIndex = 0;
        int index = 0;
        string[] calSplit = calories.Split();

        foreach (string item in calSplit)
        {
            if (calSplit[currIndex] == "" && calSplit[currIndex + 1] == "" && calSplit[currIndex + 2] == "")
            {
                var result = 0;
                for (int i = index; i <= currIndex; i++)
                {
                    if (calories.Split()[i] != "")
                    {
                        result += Convert.ToInt32(calSplit[i]);
                    }
                }
                index = currIndex + 3;
                elfCalories.Add(result);
            }
            currIndex++;
        }
        
        
    }

    internal int GetMaxCalories()
    {
        Calc();
        return elfCalories.Max();
    }

    internal int GetSumTopThree()
    {
        int result = 0;
        for (int i = 0; i < 3; i++)
        {
            result += elfCalories.OrderDescending().ToArray()[i];
        }

        return result;
    }
}