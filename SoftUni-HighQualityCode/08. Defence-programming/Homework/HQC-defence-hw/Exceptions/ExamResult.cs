using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade cannot be negative number");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("Minimum grade cannot be negative number");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Maximum grade cannot be lower or equal to minimal grade");
        }

        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentException("Comments cannot be empty or null.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
