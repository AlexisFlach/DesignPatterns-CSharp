using System;

public interface IQuestion {
    string GetDescription();
    void PrintQuestionChoices();
}
public class RangeQuestion : IQuestion {

    private string _description {get; set;}
    public RangeQuestion(string desc)
    {
        _description = desc;
    }
        public string GetDescription() {
        return _description;
    }

    public void PrintQuestionChoices() {
        Console.WriteLine("Minimum: ____________");
        Console.WriteLine("Maximum: ____________");
    }
}

public class BooleanQuestion : IQuestion 
{   
    private string _description;
    
    public BooleanQuestion(string desc) {
        _description = desc;
    }
        public string GetDescription() {
        return _description;
    }
     public void PrintQuestionChoices() {
        Console.WriteLine("1: true");
        Console.WriteLine("2: false");
    }
}

public class MultipleChoiceQuestion : IQuestion {
    private string _description;
    private List<string> _options = new List<string>() {};

    public string GetDescription() {
        return _description;
    }

    public MultipleChoiceQuestion(string desc, params string[] list )
    {
        _description = desc;
        foreach(var item in list) {
            _options.Add(item);
        }
    }
    public void PrintQuestionChoices() {
        foreach(var option in _options) {
            System.Console.WriteLine(option);
        }
    }
}
public class SetupGame {
    private static List<IQuestion> _questions = new List<IQuestion>() {};

    public static void PrintQuestions(params IQuestion[] questions)
    {
        foreach(var q in questions) {
            _questions.Add(q);
        }
    } 

    public static void StartGame()
    {
        foreach(var q in _questions) {
            System.Console.WriteLine( q.GetDescription()  );
            q.PrintQuestionChoices();
        }
    }
}

public class Quiz {
    public static void Run() 
    {
        var multiple = new MultipleChoiceQuestion("Is any of this true", "yes", "no", "maybe");
        var rightOrWrong = new BooleanQuestion("Is this true?");
        SetupGame.PrintQuestions(multiple,rightOrWrong );
        SetupGame.StartGame();
    }
} 