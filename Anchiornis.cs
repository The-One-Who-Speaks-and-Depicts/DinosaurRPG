﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialGame
{
    public class Anchiornis : ICreature
    {
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int maxHealth
        {
            get
            {
                return new Random().Next(200, 400);
            }
        }
        public int stamina { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int friendliness { get; set; }
        public int maxFriendliness { get => 100; }
        public int attackCoefficient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int defenceCoefficient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        

        public void Fight(ICreature attacker, ICreature defender, int coefficient = 0)
        {
            throw new NotImplementedException();
        }
        public void IncreaseFriendliness (int coefficient)
        {
            if (friendliness < maxFriendliness)
            {
                if ((maxFriendliness - friendliness) > coefficient)
                {
                    friendliness += coefficient;
                }
                else
                {
                    friendliness = maxFriendliness;
                }
            }
            
        }
    }
}