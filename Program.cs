using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		Rover[] rovers = new Rover[]{
        lunokhod, apollo, sojourner
      };
      // DirectAll(rovers);
      Object[] probes = new Object[]{
        lunokhod, apollo, sojourner, sputnik
      };
      IDirectable[] directables = new IDirectable[]{
        lunokhod, apollo, sojourner, sputnik
      };
      DirectAll(directables);

      foreach(IDirectable probe in directables){
        Console.WriteLine($"Tracking a {probe.GetType()}");
      }
    }
    public static void DirectAll(IDirectable[] directables){
          foreach(IDirectable probe in directables){
            Console.WriteLine($"{probe.GetInfo()} \n{probe.Explore()} \n {probe.Collect()}");
          }

    }
  }
}
