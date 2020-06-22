﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialGame
{
    public abstract class Perk
    {
        private string name { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string desc { get; set; }
        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }
        int cooldown { get; set; }
        int cooldownDelta { get; set; }
        public int CoolDown
        {
            get
            {
                return cooldown - cooldownDelta;
            }
            set
            {
                cooldown = value;
            }
        }
        private bool isGettable { get; set; }
        public bool IsGettable
        {
            get
            {
                return isGettable;
            }
            set
            {
                isGettable = value;
            }
        }
        void OnTile()
        {

        }

        void OnMovement()
        {

        }

        void OnPartner()
        {

        }

        void OnFriend()
        {

        }

        void OnRival()
        {

        }

        void OnPrey()
        {

        }

        void OnEnemy()
        {

        }
    }

}