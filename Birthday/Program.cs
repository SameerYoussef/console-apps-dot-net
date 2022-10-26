var ticks = (DateTime.Now - DateTime.Now.Subtract(TimeSpan.FromDays(10000))).Ticks;
var d = new DateTime(ticks);
Console.Write($"ticks is {d.Year}");

int i=0;
int maxWaitMs = 1500;
TimeSpan maxWait = TimeSpan.FromMilliseconds(1500);
int incrementMs = 500;
TimeSpan waitIncrement = TimeSpan.FromMilliseconds(500);
var _delayTimer = new System.Timers.Timer(waitIncrement.Milliseconds);
_delayTimer.Elapsed += (sender, e) => Console.WriteLine($"The Elapsed event was raised at {e.SignalTime} for i: {++i}");
_delayTimer.Start();
while (i != maxWaitMs/incrementMs) { };

DateTime dt = DateTime.ParseExact("Sun, 28/Nov/2021", "ddd, dd/MMM/yyyy", null).AddDays(14);

Console.Write(dt.AddDays(14));