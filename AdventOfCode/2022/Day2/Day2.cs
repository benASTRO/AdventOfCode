
namespace AdventOfCode._2022.Day2;

public class Day2
{
    private static int score;

    private static int currIndex;
    
    private const byte win = 6;
    private const byte draw = 3;
    
    private const byte rock = 1;
    private const byte paper = 2;
    private const byte scissors = 3;

    public int CalcPart1()
    {
        currIndex = 0;
        score = 0;
        string input = File.ReadAllText("./2022/Day2/Input.txt");
        string[] inputSplit = input.Split();

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

    public int CalcPart2()
    {
        currIndex = 0;
        score = 0;
        string input = File.ReadAllText("./2022/Day2/Input.txt");
        string[] inputSplit = input.Split();

        foreach (string item in inputSplit)
        {
            if (item is not "Y" and not "X" and not "Z" and not "")
            {
                string myChoice = inputSplit[currIndex + 1];

                Options option;
                option = myChoice switch
                {
                    "Y" => Options.Draw,
                    "X" => Options.Lose,
                    "Z" => Options.Win,
                    _ => throw new ArgumentOutOfRangeException()
                };

                switch (item)
                {
                    case "A":
                        if (option is Options.Win)
                        {
                            score += win + paper;
                        }
                        else if (option is Options.Draw)
                        {
                            score += draw + rock;
                        }
                        else
                        {
                            score += scissors;
                        }
                        break;
                    case "B":
                        if (option is Options.Win)
                        {
                            score += win + scissors;
                        }
                        else if (option is Options.Draw)
                        {
                            score += draw + paper;
                        }
                        else
                        {
                            score += rock;
                        }
                        break;
                    case "C":
                        if (option is Options.Win)
                        {
                            score += win + rock;
                        }
                        else if (option is Options.Draw)
                        {
                            score += draw + scissors;
                        }
                        else
                        {
                            score += paper;
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

public enum Options
{
    Win,
    Lose,
    Draw,
}