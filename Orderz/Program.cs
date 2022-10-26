Console.WriteLine("Return latest DateTime");
sfCase.Transitions.Add(new sfCase.MyTransitions() {TransitionDateTime = new DateTime(2014, 12, 31)});
sfCase.Transitions.Add(new sfCase.MyTransitions() {TransitionDateTime = new DateTime(2011, 12, 31)});
sfCase.Transitions.Add(new sfCase.MyTransitions() {TransitionDateTime = new DateTime(2012, 12, 31)});
sfCase.Transitions.Add(new sfCase.MyTransitions() {TransitionDateTime = new DateTime(2013, 12, 31)});

MyCode.MyFun();
Console.Write(metricsCase.LastTransitionDate);

public class MyCode{
    public static void MyFun(){
        string DATE_FORMAT = "yyyy-MM-dd";
        
        // metricsCase.LastTransitionDate = 
        //     sfCase
        //     .Transitions
        //     .OrderByDescending(d => d.TransitionDateTime)
        //     .Select(d => d.TransitionDateTime.ToString(DATE_FORMAT))
        //     .FirstOrDefault();

        metricsCase.LastTransitionDate = 
        sfCase.Transitions.Select(d => d.TransitionDateTime.ToString(DATE_FORMAT)).OrderBy(d => d).Last();
    }
}

public class sfCase{
    public static List<MyTransitions> Transitions = new List<MyTransitions>();
    public class MyTransitions{
        public DateTime TransitionDateTime = new DateTime();
    }
}

public class metricsCase
{
    public static string LastTransitionDate = "";
}
