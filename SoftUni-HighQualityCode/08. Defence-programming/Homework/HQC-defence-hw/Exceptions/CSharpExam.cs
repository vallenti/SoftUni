using System;

public class CSharpExam : Exam
{
    private const int MinScore = 0;
    private const int MaxScore = 100;
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (value < MinScore || MaxScore < value)
            {
                string exceptionMessage = 
                    string.Format(
                        "Score must be a number in range [{0}, {1}]",
                        MinScore, 
                        MaxScore);
                throw new ArgumentOutOfRangeException(exceptionMessage);
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");
    }
}
