﻿namespace Zoo
{
    public class Animal
    {
        private string _name;

        public Animal(string name) 
        {
            this._name = name;  
        }

        public string Name  => this._name; 
    }
}