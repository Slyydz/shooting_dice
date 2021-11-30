﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large
            };

            PlayMany(players);

            Console.WriteLine("-------------------");
            //Number 1
            SmackTalkingPlayer player4 = new SmackTalkingPlayer();
            player4.Name = "Josh";
            player4.Play(player2);

            Console.WriteLine("-------------------");
            //Number 2
            OneHigherPlayer player5 = new OneHigherPlayer();
            player5.Name = "Colby";
            player5.Play(player4);

            Console.WriteLine("-------------------");
            //Number 3
            HumanPlayer player6 = new HumanPlayer();
            player6.Name = "Jawsh";
            player6.Play(player3);

            Console.WriteLine("-------------------");
            //Number 4
            CreativeSmackTalkingPlayer player7 = new CreativeSmackTalkingPlayer();
            player7.Name = "Coby";
            player7.Play(player2);

            Console.WriteLine("-------------------");
            Number 5
            SoreLoserPlayer player8 = new SoreLoserPlayer();
            player8.Name = "KT";
            player8.Play(player5);

            Console.WriteLine("-------------------");
            //Number 6
            UpperHalfPlayer player9 = new UpperHalfPlayer();
            player9.Name = "Yeshua";
            player9.Play(player5);

            Console.WriteLine("-------------------");
            //Number 7
            SoreLoserUpperHalfPlayer player10 = new SoreLoserUpperHalfPlayer();
            player10.Name = "Bwady";
            player10.Play(player5);

        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}