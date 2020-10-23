using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clock {
  /// Main class
  class MainClass {
    static void Main(string[] args) {
      try {
        AlarmClock clock = new AlarmClock(); //时钟

        clock.AlarmTime=new ClockTime(DateTime.Now.Hour,
                      DateTime.Now.Minute,
                      DateTime.Now.Second + 5); 
        clock.TickEvent += ShowTime;
        clock.AlarmEvent += Alarming;
        new Thread(clock.Run).Start();

      }catch (Exception e) {
        Console.WriteLine(e.Message);
      }
    }

    private static void ShowTime(AlarmClock sender) {
      ClockTime time = sender.CurrentTime;
      Console.WriteLine($"Tick Event: " +
        $"{time.Hour}:{time.Minute}:{time.Second}");
    }

    public static void Alarming(AlarmClock sender) {
      ClockTime time = sender.CurrentTime;
      Console.WriteLine($"Alarm Event: {time.Hour}:{time.Minute}:{time.Second}");
      Console.WriteLine("dingling dingling dingling");
    }
  }
}
