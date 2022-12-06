
namespace AdventOfCode._2022.Day2;

public class Day2
{
    public int Play()
    {
        string input = File.ReadAllText("./2022/Day2/Input.txt");
        string[] inputSplit = input.Split();
        int currIndex = 0;
        int score = 0;
        int win = 6;
        int draw = 3;
        int rock = 1;
        int paper = 2;
        int scissors = 3;

        foreach (string item in inputSplit)
        {
            if (item is not "Y" and not "X" and not "Z" and not "")
            {
                string myChoice = inputSplit[currIndex + 1];
                score += myChoice switch
                {
                    "Y" => paper,
                    "X" => rock,
                    "Z" => scissors,
                    _ => throw new ArgumentOutOfRangeException()
                };

                switch (item)
                {
                    case "A":
                        if (myChoice is "Y")
                        {
                            score += win;
                        }
                        else if (myChoice is "X")
                        {
                            score += draw;
                        }

                        break;
                    case "B":
                        if (myChoice is "Z")
                        {
                            score += win;
                        }
                        else if (myChoice is "Y")
                        {
                            score += draw;
                        }

                        break;
                    case "C":
                        if (myChoice is "X")
                        {
                            score += win;
                        }
                        else if (myChoice is "Z")
                        {
                            score += draw;
                        }

                        break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }

            currIndex++;
        }

        return score;
    }
}