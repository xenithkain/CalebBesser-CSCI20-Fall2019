using System;

  class Rank {
 
    static void Main () 
  {
      string CurrentRank, WantedRank, Wins_S, Losses_S; 
      float WinRate, WinRate_Decimal, TotalGames,Wins_D, Losses_D, GamesTimesWinRate;
      int Elo, WantedRank_I, GamesNeeded;
    
      Console.WriteLine("This is a calculator that will take your current win rate, and current rank in League of Legends. Then you tell it what rank you want, and it will tell you how many games it will take with your current winrate. (Note, if your winrate is below 50% you are not going to climb, and need to get gud m8.)");
      
      Console.WriteLine("What is your currect number of Ranked Wins?");
     
      Wins_S = Console.ReadLine();
      
      Console.WriteLine("Okay, what is your current number of Ranked Losses?");
      
      Losses_S = Console.ReadLine();
      Wins_D = float.Parse(Wins_S);
      Losses_D = float.Parse(Losses_S);
      TotalGames = Wins_D + Losses_D;
      WinRate = Wins_D / TotalGames  * 100;
     
      Console.WriteLine( "Now what is your current rank. Put it in this form,'Silver1'. So the rank then the division. (Note, Master,Grandmaster, and Challenger, all are single tier divisions. So they cannot be calculated. Pick a rank Diamond or under.)");
     
      CurrentRank = Console.ReadLine(); 
      
      switch (CurrentRank)
      {
        case "Iron4":
          Elo = 0;
          break;
        case "Iron3":
          Elo = 100;
          break;
        case "Iron2":
          Elo = 200;
          break;
        case "Iron1":
          Elo = 300;
          break;
        case "Bronze4":
          Elo = 400;
          break;
        case "Bronze3":
          Elo = 500;
          break;
        case "Bronze2":
          Elo = 600;
          break;
        case "Bronze1":
          Elo = 700;
          break;
        case "Silver4":
          Elo = 800;
          break;
        case "Silver3":
          Elo = 900;
          break;
        case "Silver2":
          Elo = 1000;
          break;
        case "Silver1":
          Elo = 1100;
          break;
        case "Gold4":
          Elo = 1200;
          break;
        case "Gold3":
          Elo = 1300;
          break;
        case "Gold2":
          Elo = 1400;
          break;
        case "Gold1":
          Elo = 1500;
          break;
        case "Platinum4":
          Elo = 1600;
          break;
        case "Platinum3":
          Elo = 1700;
          break;
        case "Platinum2":
          Elo = 1800;
          break;
        case "Platinum1":
          Elo = 1900;
          break;
        case "Diamond4":
          Elo = 2000;
          break;
        case "Diamond3":
          Elo = 2100;
          break;
        case "Diamond2":
          Elo = 2200;
          break;
        case "Diamond1":
          Elo = 2300;
          break;

        default:
          Elo = 0;
          break;
      }
      Console.WriteLine("Now what rank do you want? Same rules apply from you current rank.");

      WantedRank = Console.ReadLine();

      switch (WantedRank)
      {
        case "Iron4":
          WantedRank_I = 0;
          break;
        case "Iron3":
          WantedRank_I = 100;
          break;
        case "Iron2":
          WantedRank_I = 200;
          break;
        case "Iron1":
          WantedRank_I = 300;
          break;
        case "Bronze4":
          WantedRank_I = 400;
          break;
        case "Bronze3":
          WantedRank_I = 500;
          break;
        case "Bronze2":
          WantedRank_I = 600;
          break;
        case "Bronze1":
          WantedRank_I = 700;
          break;
        case "Silver4":
          WantedRank_I = 800;
          break;
        case "Silver3":
          WantedRank_I = 900;
          break;
        case "Silver2":
          WantedRank_I = 1000;
          break;
        case "Silver1":
          WantedRank_I = 1100;
          break;
        case "Gold4":
          WantedRank_I = 1200;
          break;
        case "Gold3":
          WantedRank_I = 1300;
          break;
        case "Gold2":
          WantedRank_I = 1400;
          break;
        case "Gold1":
          WantedRank_I = 1500;
          break;
        case "Platinum4":
          WantedRank_I = 1600;
          break;
        case "Platinum3":
          WantedRank_I = 1700;
          break;
        case "Platinum2":
          WantedRank_I = 1800;
          break;
        case "Platinum1":
          WantedRank_I = 1900;
          break;
        case "Diamond4":
          WantedRank_I = 2000;
          break;
        case "Diamond3":
          WantedRank_I = 2100;
          break;
        case "Diamond2":
          WantedRank_I = 2200;
          break;
        case "Diamond1":
          WantedRank_I = 2300;
          break;

        default:
          WantedRank_I = 0;
          break;
      }

      GamesNeeded = WantedRank_I - Elo;
      float GamesNeeded_f = GamesNeeded / 20;
      WinRate_Decimal = WinRate * (float) .01;
      GamesTimesWinRate = GamesNeeded_f * WinRate_Decimal;
      int FinalGames = (int) GamesNeeded_f + GamesTimesWinRate;
      Console.WriteLine(GamesTimesWinRate);
      
      Console.WriteLine("Good your Winrate is " + WinRate + "%. You wanted " + WantedRank + ", to get there with that winrate would take " + GamesNeeded_f + " Games." );

      
      
  }
}