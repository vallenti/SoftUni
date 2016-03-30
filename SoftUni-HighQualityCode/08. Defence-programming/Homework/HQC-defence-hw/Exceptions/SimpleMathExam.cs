using System;

public class SimpleMathExam : Exam
{
    private const int MinProblemsSolved = 0;
    private const int MaxProblemsSolved = 10;
    private const int MinGrade = 2;
    private const int MaxGrade = 6;
    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }
        private set
        {
            if(value < MinProblemsSolved || MaxProblemsSolved < value  )
            {
                string exceptionMessage = 
                    string.Format(
                        "Solved problem must be in the range [{0}, {1}]",
                        MinProblemsSolved, 
                        MaxProblemsSolved);
                throw new ArgumentOutOfRangeException("problemsSolved",exceptionMessage);
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        switch(this.ProblemsSolved)
        {
            case 0:
            case 1:
            case 2:
                return new ExamResult(2, MinGrade, MaxGrade, "Bad result: nothing done.");
            case 3:                      
            case 4:                      
                return new ExamResult(3, MinGrade, MaxGrade, "Poor result: few problems solved");
            case 5:                      
            case 6:                     
                return new ExamResult(4, MinGrade, MaxGrade, "Average result: half of the problems solved");
            case 7:                      
            case 8:                      
                return new ExamResult(5, MinGrade, MaxGrade, "Good result: most of the problems solved");
            case 9:                     
            case 10:                     
                return new ExamResult(6, MinGrade, MaxGrade, "Excellent result: everything is perfect.");
            default:
                throw new ArgumentOutOfRangeException("problemsSolved", "The number of problems solved is invalid.");
        }
    }
}
