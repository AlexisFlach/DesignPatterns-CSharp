// See https://aka.ms/new-console-template for more information
using observerpattern;

var liveScore = new LiveScore();

var display = new CurrentScoreDisplay(liveScore);
System.Console.WriteLine("Hello");
liveScore.SetResult(1, 0);
